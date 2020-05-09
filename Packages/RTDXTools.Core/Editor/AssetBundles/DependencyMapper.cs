using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DependencyMapper : EditorWindow
{
    private const string None = "<none>";
    
    private DependencyPathIdMap _pathIdMap;

    private string _srcAbName;
    private string _dstAbName;

    private AssetBundle _srcAb;
    private AssetBundle _dstAb;

    private List<PathIdTaggedSourceAsset> _srcAssets;
    private Dictionary<Type, List<PathIdTaggedSourceAsset>> _srcAssetsByType;
    private List<PathIdTaggedAsset> _dstAssets;
    private Dictionary<Type, List<PathIdTaggedAsset>> _dstAssetsByType;
    private Dictionary<Type, string[]> _dstAssetNamesByType;

    private Vector2 _scrollPos;
    private bool _showPathIds;

    [MenuItem("Tools/Dependency Mapper")]
    static void Init()
    {
        GetWindow<DependencyMapper>().Show();
    }

    private void OnGUI()
    {
        if (_pathIdMap == null)
        {
            _pathIdMap = DependencyPathIdMap.Load();
        }

        if (_pathIdMap == null)
        {
            EditorGUILayout.HelpBox("DependencyPathIdMap missing! Please create it in the Resources folder.", MessageType.Error);
            return;
        }

        _srcAbName = EditorGUILayout.TextField("Custom AssetBundle", _srcAbName);
        _dstAbName = EditorGUILayout.TextField("Original AssetBundle", _dstAbName);
        _showPathIds = EditorGUILayout.ToggleLeft("Show Path IDs", _showPathIds);
        if (GUILayout.Button("Load"))
        {
            LoadAssets();
        }

        if (_srcAb == null || _dstAb == null || _srcAssetsByType == null || _dstAssetsByType == null)
        {
            EditorGUILayout.HelpBox("No AssetBundles loaded.", MessageType.Info);
            return;
        }
        
        EditorGUILayout.Separator();
        using (new EditorGUILayout.HorizontalScope())
        {
            EditorGUILayout.LabelField("Source Asset", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Type", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Destination Asset", EditorStyles.boldLabel);
        }

        using (var scrollView = new EditorGUILayout.ScrollViewScope(_scrollPos))
        {
            _scrollPos = scrollView.scrollPosition;
            DrawMainGUI();
        }
    }

    private void DrawMainGUI()
    {
        for (int i = 0; i < _srcAssets.Count; i++)
        {
            var srcAsset = _srcAssets[i];
            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.LabelField(srcAsset.Asset.name);
                EditorGUILayout.LabelField($"({srcAsset.AssetType.Name})");
                if (_dstAssetsByType.ContainsKey(srcAsset.AssetType))
                {
                    var dstAssetIndex = _dstAssets.IndexOf(srcAsset.DestinationAsset) + 1;
                    using (var changeCheck = new EditorGUI.ChangeCheckScope())
                    {
                        dstAssetIndex = EditorGUILayout.Popup(dstAssetIndex, _dstAssetNamesByType[srcAsset.AssetType]);
                        if (changeCheck.changed)
                        {
                            srcAsset.DestinationAsset = dstAssetIndex > 0 ? _dstAssets[dstAssetIndex - 1] : null;
                        }
                    }
                }
                else
                {
                    EditorGUILayout.LabelField("<no matching assets>");
                }
            }

            if (_showPathIds)
            {
                using (new EditorGUILayout.HorizontalScope())
                {
                    EditorGUILayout.LabelField(srcAsset.PathId.ToString(), EditorStyles.miniLabel);
                    EditorGUILayout.LabelField(string.Empty, EditorStyles.miniLabel);
                    if (srcAsset.DestinationAsset != null)
                    {
                        EditorGUILayout.LabelField(srcAsset.DestinationAsset.PathId.ToString(),
                            EditorStyles.miniLabel);
                    }
                    else
                    {
                        EditorGUILayout.LabelField("-");
                    }
                }
            }
        }
    }

    private void LoadAssets()
    {
        try
        {
            EditorUtility.DisplayProgressBar("DependencyMapper", "Loading...", 0.0f);
            _srcAb = Helpers.GetAssetBundle(Directory.GetCurrentDirectory() + "/" + AbBuilder.TempPath, _srcAbName);
            EditorUtility.DisplayProgressBar("DependencyMapper", "Loading...", 0.25f);
            _dstAb = Helpers.GetAssetBundle(EditorHelpers.GetRomFsAssetBundlePath(), _dstAbName);

            if (_srcAb != null && _dstAb != null)
            {
                EditorUtility.DisplayProgressBar("DependencyMapper", "Loading...", 0.5f);
                _srcAssets = _srcAb.LoadAllAssets().Select(CreateTaggedAsset<PathIdTaggedSourceAsset>).ToList();
                _srcAssetsByType = _srcAssets.GroupBy(x => x.AssetType).ToDictionary(g => g.Key, g => g.ToList());
                
                EditorUtility.DisplayProgressBar("DependencyMapper", "Loading...", 0.75f);
                _dstAssets = _dstAb.LoadAllAssets().Select(CreateTaggedAsset<PathIdTaggedAsset>).ToList();
                _dstAssetsByType = _dstAssets.GroupBy(x => x.AssetType)
                    .ToDictionary(g => g.Key, g => g.ToList());
                var empty = new List<string> { None };
                _dstAssetNamesByType = _dstAssets.GroupBy(x => x.AssetType)
                    .ToDictionary(g => g.Key, g => empty.Union(g.Select(i => i.Asset.name)).ToArray());

                EditorUtility.DisplayProgressBar("DependencyMapper", "Loading...", 0.9f);
                AssignFromPathIdMap();
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
        finally
        {
            EditorUtility.ClearProgressBar();
        }
    }

    private void AssignFromPathIdMap()
    {
        var filteredPathIdMap = _pathIdMap.Mappings
            .Where(m => m.SourceAssetBundleName == _srcAbName)
            .ToDictionary(m => m.Source);

        var dstAssetPathIdLookup = _dstAssets.ToDictionary(dst => dst.PathId);

        foreach (var srcAsset in _srcAssets)
        {
            if (filteredPathIdMap.ContainsKey(srcAsset.PathId))
            {
                var pathMapEntry = filteredPathIdMap[srcAsset.PathId];
                if (dstAssetPathIdLookup.ContainsKey(pathMapEntry.Target))
                {
                    srcAsset.DestinationAsset = dstAssetPathIdLookup[pathMapEntry.Target];
                }
            }
        }
    }

    private T CreateTaggedAsset<T>(UnityEngine.Object asset) where T : PathIdTaggedAsset, new()
    {
        if (AssetDatabase.TryGetGUIDAndLocalFileIdentifier(asset, out string guid, out long localId))
        {
            return new T
            {
                Asset = asset,
                AssetType = asset.GetType(),
                PathId = localId
            };
        }
        throw new Exception("Could not get localId");
    }

    private class PathIdTaggedAsset
    {
        public UnityEngine.Object Asset;
        public Type AssetType;
        public long PathId;
    }

    private class PathIdTaggedSourceAsset : PathIdTaggedAsset
    {
        public PathIdTaggedAsset DestinationAsset;
    }
}