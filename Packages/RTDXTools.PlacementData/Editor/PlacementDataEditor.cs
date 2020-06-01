using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;

public class PlacementDataEditor : IDataFileEditor
{
    private Vector2 _scrollPos;

    private bool _useSourceFile;
    private DataFileBrowser.Node _file;
    private bool _showGizmos;
    private bool _showAreaGizmos;
    private readonly List<PlacementDataEntry> _entries = new List<PlacementDataEntry>();
    private GUIStyle _sceneLabelStyle;

    public DataFileBrowser.Node CurrentFile => _file;

    public void Open(DataFileBrowser.Node file, bool useSourceFile)
    {
        EditorUtility.DisplayProgressBar("PlacementDataEditor", "Parsing...", 0f);
        
        _file = file;
        _useSourceFile = useSourceFile;
        _showGizmos = EditorPrefs.GetBool($"{nameof(PlacementDataEditor)}_showGizmos", true);
        _showAreaGizmos = EditorPrefs.GetBool($"{nameof(PlacementDataEditor)}_showAreaGizmos", true);

        var lines = File.ReadAllLines(useSourceFile ? _file.SourceFile.FullName : _file.LayeredFSFile.FullName);
        foreach (var line in lines)
        {
            if (!line.Contains("{"))
                continue;
            
            var split = line.Split('{');
            string fullIdentifier = split[0];
            string dataStr = "{" + string.Join("{", split.Skip(1));
            var data = JObject.Parse(dataStr);
            if (!fullIdentifier.Contains(":"))
                return;
            
            var splitIdentifier = fullIdentifier.Split(':');
            var type = splitIdentifier[0];

            switch (type)
            {
                case "ASSET":
                {
                    if (splitIdentifier.Length != 4)
                    {
                        Debug.LogError("Malformed asset: " + fullIdentifier);
                        EditorUtility.ClearProgressBar();
                        return;
                    }

                    string assetType = splitIdentifier[1];
                    string name = splitIdentifier[2];
                    
                    _entries.Add(CreateAsset(assetType, name, data));
                    
                    break;
                }
                case "MISC":
                {
                    _entries.Add(new Misc { Data = data });
                    break;
                }
            }
        }

        EditorUtility.DisplayProgressBar("PlacementDataEditor", "Loading preview models...", 0.5f);
        try
        {
            LoadPreviewModels();
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

    private void Save()
    {
        var sb = new StringBuilder();
        foreach (var entry in _entries)
        {
            var asset = entry as PlacementDataAsset;
            string fullIdentifier = asset != null ? $"{asset.Type}:{asset.AssetType}:{asset.Name}" : entry.Type;
            string dataString = entry.Data.ToString(Formatting.None);

            sb.AppendLine($"{fullIdentifier}:{dataString}");
        }

        var fileName = _file.DestinationFile.FullName;
        if (_file.DestinationFile.Exists)
        {
           ((FileInfo) _file.DestinationFile).CopyTo(fileName + ".bak", true);
        }

        File.WriteAllText(_file.DestinationFile.FullName, sb.ToString());
        Debug.Log("Saved to " + fileName);
    }

    public void Close()
    {
        foreach (var chara in _entries.OfType<CharaAsset>())
        {
            if (chara.PreviewModel != null)
            {
                UnityEngine.Object.DestroyImmediate(chara.PreviewModel);
            }
        }
    }

    public void DrawGUI()
    {
        EditorGUILayout.LabelField($"Editing {(_useSourceFile ? _file.SourceFile.FullName : _file.LayeredFSFile.FullName)}");

        if (GUILayout.Button("Save"))
        {
            Save();
        }

        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            _showGizmos = EditorGUILayout.ToggleLeft("Show Asset Gizmos", _showGizmos);
            using (new EditorGUI.DisabledScope(!_showGizmos))
            {
                _showAreaGizmos = EditorGUILayout.ToggleLeft("Show Area Gizmos", _showAreaGizmos);
            }

            if (changeCheck.changed)
            {
                EditorPrefs.SetBool($"{nameof(PlacementDataEditor)}_showGizmos", _showGizmos);
                EditorPrefs.SetBool($"{nameof(PlacementDataEditor)}_showAreaGizmos", _showAreaGizmos);
            }
        }

        using (var scroll = new EditorGUILayout.ScrollViewScope(_scrollPos))
        {
            _scrollPos = scroll.scrollPosition;
            foreach (var entry in _entries)
            {
                var oldColor = GUI.color;
                bool editing = IsEntrySelected(entry);

                using (new EditorGUILayout.HorizontalScope())
                {
                    if (editing)
                    {
                        GUILayout.Label(EditorGUIUtility.IconContent("d_editicon.sml", entry.ToString()),
                            GUILayout.Width(20));
                        GUI.color = Color.cyan;
                    }
                    if (GUILayout.Button(entry.ToString(), EditorStyles.label))
                    {
                        if (editing)
                        {
                            var transformEntry = entry as IHasTransform;
                            if (transformEntry != null)
                            {
                                SceneView.lastActiveSceneView.pivot = transformEntry.Position;
                            }
                        }
                        
                        PlacementDataEntryInspector.Edit(entry);
                    }
                }

                GUI.color = oldColor;
            }
        }
    }

    public void DrawSceneGUI()
    {
        if (_sceneLabelStyle == null)
        {
            _sceneLabelStyle = new GUIStyle(EditorStyles.miniButton)
            {
                margin = new RectOffset(),
                padding = new RectOffset(),
                border = new RectOffset(),
                overflow = new RectOffset(),
                stretchWidth = true,
                alignment = TextAnchor.MiddleCenter
            };
        }

        var oldCol = GUI.color;
        var oldBgCol = GUI.backgroundColor;
        GUI.contentColor = Color.cyan;
        GUI.backgroundColor = new Color(1f, 1f, 1f,0.7f);
        foreach (var entry in _entries)
        {
            var transformAsset = entry as IHasTransform;
            if (transformAsset == null)
                continue;

            var pos = transformAsset.Position;
            bool selected = IsEntrySelected(entry);

            var areaAsset = entry as AreaAsset;
            if (areaAsset != null && (_showGizmos && _showAreaGizmos || selected))
            {
                var size = areaAsset.Size;
                var size3D = new Vector3(size.x, 3f, size.y);
                var rotatedSize3D = areaAsset.Rotation * size3D;
                
                var oldHandleColor = Handles.color;
                Handles.color = areaAsset.HandleColor;
                Handles.DrawWireCube(pos, rotatedSize3D);
                Handles.color = oldHandleColor;
            }
            
            if (selected)
            {
                if ((entry as CharaAsset)?.PreviewModel == null)
                {
                    Handles.Button(pos, transformAsset.Rotation, 0.2f, 0f, Handles.SphereHandleCap);
                }
            }
            else if (_showGizmos)
            {
                if (Handles.Button(pos, transformAsset.Rotation, 0.4f, 0.5f, Handles.ConeHandleCap))
                {
                    PlacementDataEntryInspector.Edit(entry);
                }

                Handles.Label(pos, transformAsset.ToString(), _sceneLabelStyle);
            }
        }

        GUI.contentColor = oldCol;
        GUI.backgroundColor = oldBgCol;
    }

    private PlacementDataAsset CreateAsset(string assetType, string name, JObject data)
    {
        PlacementDataAsset asset;
        switch (assetType)
        {
            case "ActAsset_Chara":
            {
                asset = new CharaAsset();
                break;
            }
            case "ActAsset_Point":
            {
                asset = new PointAsset();
                break;
            }
            case "ActAsset_Trigger":
            {
                asset = new TriggerAsset();
                break;
            }
            case "ActAsset_BgmArea":
            {
                asset = new BgmAreaAsset();
                break;
            }
            case "ActAsset_MoveArea":
            {
                asset = new MoveAreaAsset();
                break;
            }
            default:
            {
                asset = new OtherAsset(assetType);
                break;
            }
        }

        asset.Name = name;
        asset.Data = data;

        return asset;
    }

    private void LoadPreviewModels()
    {
        foreach (var entry in _entries)
        {
            var chara = entry as CharaAsset;
            if (chara == null)
                return;

            string name = chara.Name;
            
            // TODO: Allow to switch preview hero and partner
            if (name == "HERO")
            {
                name = "MIZUGOROU"; // Mudkip
            }
            if (name == "PARTNER")
            {
                name = "HINOARASHI"; // Cyndaquil
            }

            // Purple Kecleon needs special treatment
            string assetBundleNameWithoutExtension = name == "KAKUREON2" ? "kakureon_11" : $"{name.ToLower()}_10";
            string assetBundleName = assetBundleNameWithoutExtension + ".ab";
            string assetBundlePath = Path.Combine(ConfigManager.AssetBundleSourcePath, assetBundleName);
            if (!File.Exists(assetBundlePath))
            {
                Debug.LogWarning($"Could not load preview model for character '{chara.Name}' (searched at {assetBundleName}).");
            }

            var assetBundle = Helpers.GetAssetBundle(ConfigManager.AssetBundleSourcePath, assetBundleName);

            try
            {
                var go = (GameObject) UnityEngine.Object.Instantiate(
                    assetBundle.LoadAsset(assetBundleNameWithoutExtension));
                Helpers.ReplaceModelShaders(go);
                go.hideFlags = HideFlags.HideAndDontSave;
                go.transform.position = chara.Position;
                go.transform.rotation = chara.Rotation;
                go.AddComponent<ProxyModel>().PlacementDataAsset = chara;
                foreach (Transform child in go.transform)
                {
                    child.gameObject.AddComponent<ProxyModel>().PlacementDataAsset = chara;
                }

                chara.PreviewModel = go;
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
    
    private static bool IsEntrySelected(PlacementDataEntry entry)
    {
        return (Selection.activeObject is PlacementDataEntryInspector.Wrapper &&
                ((PlacementDataEntryInspector.Wrapper) Selection.activeObject).Entry == entry);
    }
}