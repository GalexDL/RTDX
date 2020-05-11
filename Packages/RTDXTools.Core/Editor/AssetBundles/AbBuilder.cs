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

    private string _buildPath = "";
    private List<string> _bundleNames = new List<string>();
    private bool _alsoBuildNca = false;
    private bool _expanded = false;
    private bool _skipPostprocess;
    
    private string _buildInfo = "";

    [MenuItem("Tools/AbBuilder", false, 0)]
    static void Init()
    {
        GetWindow<AbBuilder>().Show();
    }

    private void OnEnable()
    {
        _buildPath = EditorPrefs.GetString("romfsabpath", "");
        _bundleNames = EditorPrefs.GetString("bundlename", "").Split(',').ToList();
        _alsoBuildNca = EditorPrefs.GetBool("alsoBuildNCA", false);
    }

    private void OnGUI()
    {
        EditorGUI.BeginChangeCheck();
        _buildPath = EditorGUILayout.TextField("Build Path with / (e.g. StreamingAssets/ab/)", _buildPath);

        _expanded = EditorGUILayout.Foldout(_expanded, "Bundles");
        if (_expanded)
        {
            EditorGUI.indentLevel++;
            foreach (var abName in AssetDatabase.GetAllAssetBundleNames().Where(n => !CopyBlacklist.Contains(n.ToLower())))
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
        EditorGUILayout.Space();
        

        if (EditorGUI.EndChangeCheck())
        {
            EditorPrefs.SetString("romfsabpath", _buildPath);
            EditorPrefs.SetString("bundlename", string.Join(",", _bundleNames.ToArray()));
            EditorPrefs.SetBool("alsoBuildNCA", _alsoBuildNca);

        }

        if (GUILayout.Button("Build"))
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), TempPath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            EditorUtility.DisplayProgressBar("Building AssetBundles...", "", 0f);

            BuildPipeline.BuildAssetBundles(TempPath, BuildAssetBundleOptions.UncompressedAssetBundle | BuildAssetBundleOptions.ForceRebuildAssetBundle,
                BuildTarget.StandaloneWindows);

            foreach (var bundleName in _bundleNames)
            {
                string fileName = Path.Combine(Directory.GetCurrentDirectory() + "/", TempPath, bundleName);
                if (!File.Exists(fileName))
                {
                    Debug.LogWarning(fileName + " does not exist.");
                    continue;
                }

                if (!_skipPostprocess)
                {
                    EditorUtility.DisplayProgressBar("PostProcessing...", "", 0.7f);
                    new BuildPostprocessor(fileName).Run();
                }

                EditorUtility.DisplayProgressBar("Copying...", "", 0.9f);

                string destFile = _buildPath + bundleName + ".ab";
                File.Copy(fileName, destFile, true);
                Debug.Log("Saved to " + _buildPath);
                
                _buildInfo = "Finished at " + DateTime.Now.ToShortTimeString();
            } 
            EditorUtility.ClearProgressBar();
            
            if (_alsoBuildNca)
            {
                GetWindow<RomTools>().BuildNCA();
            }
        }
        
        _alsoBuildNca = EditorGUILayout.ToggleLeft("Also Build NCA", _alsoBuildNca);
        _skipPostprocess = EditorGUILayout.ToggleLeft("Skip Postprocessing", _skipPostprocess);

        GUILayout.Label(_buildInfo);

    }
}
