using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AbBuilder : EditorWindow
{
    public const string TempPath = "AssetBundleBuildTemp";

    /// <summary>
    /// AssetBundles that shouldn't be copied to the romfs since they are
    /// referenced in game and contain files (e.g. shaders) we can't replaace
    /// </summary>
    private static readonly string[] CopyBlacklist =
    {
        "shader_pack"
    };

    private List<string> _bundleNames = new List<string>();
    private bool _alsoBuildNca = false;
    private bool _forceRebuild = false;
    private bool _skipPostprocess;
    
    private string _buildInfo = "";
    private bool _expanded = false;
    private Vector2 _scrollPos;

    [MenuItem("Tools/AbBuilder", false, 0)]
    static void Init()
    {
        GetWindow<AbBuilder>().Show();
    }

    private void OnEnable()
    {
        _bundleNames = EditorPrefs.GetString("bundlename", "").Split(',').ToList();
        _alsoBuildNca = EditorPrefs.GetBool("alsoBuildNCA", false);
        _forceRebuild = EditorPrefs.GetBool("forceRebuild", false);
    }

    private void OnGUI()
    {
        EditorGUI.BeginChangeCheck();

        _expanded = EditorGUILayout.Foldout(_expanded, "Bundles");
        if (_expanded)
        {
            using (var scrollView = new EditorGUILayout.ScrollViewScope(_scrollPos))
            {
                _scrollPos = scrollView.scrollPosition;
                
                EditorGUI.indentLevel++;
                foreach (var abName in AssetDatabase.GetAllAssetBundleNames()
                    .Where(n => !CopyBlacklist.Contains(n.ToLower())))
                {
                    bool inList = _bundleNames.Contains(abName);
                    bool enabled = EditorGUILayout.ToggleLeft(abName, inList);
                    if (enabled && !inList)
                    {
                        _bundleNames.Add(abName);
                    }
                    else if (!enabled && inList)
                    {
                        _bundleNames.Remove(abName);
                    }
                }

                EditorGUI.indentLevel--;
            }
        }
        EditorGUILayout.Space();

        if (GUILayout.Button("Build"))
        {
            Build(_bundleNames, _forceRebuild, !_skipPostprocess);
            
            _buildInfo = "Finished at " + DateTime.Now.ToShortTimeString();

            if (_alsoBuildNca)
            {
                GetWindow<RomTools>().BuildNCA();
            }
        }
        
        _alsoBuildNca = EditorGUILayout.ToggleLeft("Also Build NCA", _alsoBuildNca);
        _skipPostprocess = EditorGUILayout.ToggleLeft("Skip Postprocessing", _skipPostprocess);
        _forceRebuild = EditorGUILayout.ToggleLeft("Force Rebuild", _forceRebuild);
        
        if (EditorGUI.EndChangeCheck())
        {
            EditorPrefs.SetString("bundlename", string.Join(",", _bundleNames.ToArray()));
            EditorPrefs.SetBool("alsoBuildNCA", _alsoBuildNca);
            EditorPrefs.SetBool("forceRebuild", _forceRebuild);
        }

        GUILayout.Label(_buildInfo);
        GUILayout.Space(10f);
    }

    public static void Build(IEnumerable<string> bundleNames, bool forceRebuild = false, bool postProcess = true)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), TempPath);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
            
        EditorUtility.DisplayProgressBar("Building AssetBundles...", "", 0f);

        var options = BuildAssetBundleOptions.UncompressedAssetBundle;
        if (forceRebuild)
        {
            options |= BuildAssetBundleOptions.ForceRebuildAssetBundle;
        }
        BuildPipeline.BuildAssetBundles(TempPath, options, BuildTarget.StandaloneWindows);

        foreach (var bundleName in bundleNames)
        {
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), TempPath, bundleName);
            if (!File.Exists(fileName))
            {
                Debug.LogWarning(fileName + " does not exist.");
                continue;
            }

            if (postProcess)
            {
                EditorUtility.DisplayProgressBar("PostProcessing...", "", 0.7f);
                new BuildPostprocessor(fileName).Run();
            }

            EditorUtility.DisplayProgressBar("Copying...", "", 0.9f);

            string buildPath = ConfigManager.AssetBundleBuildPath;
            string destFile = Path.Combine(buildPath, $"{bundleName}.ab");
            File.Copy(fileName, destFile, true);
            Debug.Log($"Saved to {buildPath}");
                
        } 
        EditorUtility.ClearProgressBar();
    }
}
