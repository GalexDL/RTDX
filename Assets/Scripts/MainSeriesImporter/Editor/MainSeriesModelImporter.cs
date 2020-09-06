using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using kamina;
using SkyEditor.RomEditor.Domain.Rtdx.Structures;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class MainSeriesModelImporter : EditorWindow, IHasCustomMenu
{
    #region Variables
    
    private readonly string[] AnimationBundlePrefixes = {"1leg", "2leg", "4leg", "6leg", "float", "fly", "bound", "body_bound"};

    private Vector2 _scrollPos;

    private List<PokemonGraphicsDatabase.PokemonGraphicsDatabaseEntry> _graphicsDatabaseEntries;
    private FileInfo[] _animationBundles;
    private string[] _animationBundleNames;
    private Texture2D _pikachuMouthTexture;
    private List<string> _texturePaths = new List<string>();
    
    private string _modelPath;
    private string _targetModelName;
    private string _targetAnimationBundleName = "2leg_pokemon_00";
    private float _scale = 0.016f;
    private bool _autoFixTexturesOnLoad = true;
    private string _sourceModelBundle = "rioru_00.ab";
    private FileInfo _sourceAnimationBundle;
    private bool _buildAssetBundlesAfterImport = true;

    private bool _footCorrection = true;
    private bool _createSkeletalMouthAnimations;
    private bool _mirrorMouth;

    private AnimationClip _currentPreviewClip;
    private bool _loopPreview = true;
    private float _previewSpeed = 1f;
    private bool _previewPlaying;
    private float _startTime;
    private bool _showSourceModel;

    private GameObject _targetObject;
    private GameObject _sourceObject;
    private MouthModel _mouthModel;
    private (AnimationClip clip, bool belongsToModelBundle)[] _animationClips;
    private string[] _previewClipNames;

    private bool _showTextureEditor;
    private bool _showBodyAnimationEditor;
    private bool _showMouthAnimationEditor;
    private bool _showRotationHandles;
    private bool _showYHandles;
    private bool _showZHandles;
    
    #endregion
    
    #region Properties

    private bool Loaded => _targetObject != null && _sourceObject != null && _animationClips != null 
                           && _animationClips.Length > 0;

    public Texture2D PikachuMouthTexture
    {
        get
        {
            // The asset bundle might have been unloaded
            if (_pikachuMouthTexture == null)
            {
                _pikachuMouthTexture = Helpers.GetAssetBundle(ConfigManager.AssetBundleSourcePath, "pikachuu_10.ab")
                    .LoadAsset<Texture2D>("pikachuu_mo_10");
            }

            return _pikachuMouthTexture;
        }
    }

    private IEnumerable<(AnimationClip clip, bool belongsToModelBundle)> BodyAnimations =>
        _animationClips.Where(clip => clip.clip.name.StartsWith("bd_"));
    private IEnumerable<(AnimationClip clip, bool belongsToModelBundle)> EyeAnimations =>
        _animationClips.Where(clip => clip.clip.name.StartsWith("ey_"));
    private IEnumerable<(AnimationClip clip, bool belongsToModelBundle)> MouthAnimations =>
        _animationClips.Where(clip => clip.clip.name.StartsWith("mo_"));
    
    #endregion
    
    #region UI

    [MenuItem("Tools/Main series model importer", false, 0)]
    static void Init()
    {
        GetWindow<MainSeriesModelImporter>().Show();
    }

    private void OnEnable()
    {
        _graphicsDatabaseEntries = SkyEditorHelpers.GetRom().GetPokemonGraphicsDatabase().Entries;
        _animationBundles = new DirectoryInfo(ConfigManager.AssetBundleSourcePath).EnumerateFiles()
            .Where(file => AnimationBundlePrefixes.Any(prefix => file.Name.StartsWith(prefix)) &&
                           file.Name.EndsWith(".ab")).ToArray();
        _animationBundleNames = new []{"From Graphics DB"}.Concat(_animationBundles.Select(file => file.Name)).ToArray();
    }

    private void OnDisable()
    {
        if (_previewPlaying)
        {
            EditorApplication.update -= UpdateAnimation;
        }
    }

    private void OnGUI()
    {
        var foldoutHeaderStyle = new GUIStyle(EditorStyles.foldout);
        foldoutHeaderStyle.fontStyle = FontStyle.Bold;
        
        using (var scrollView = new EditorGUILayout.ScrollViewScope(_scrollPos))
        {
            _scrollPos = scrollView.scrollPosition;

            DrawGeneralSettingsEditor();

            if (!Loaded)
                return;

            EditorGUILayout.Space();
            _showTextureEditor = EditorGUILayout.Foldout(_showTextureEditor, "Textures", foldoutHeaderStyle);
            if (_showTextureEditor)
            {
                EditorGUI.indentLevel++;
                DrawTextureEditor();
                EditorGUI.indentLevel--;
                EditorGUILayout.Space();
            }

            _showBodyAnimationEditor = EditorGUILayout.Foldout(_showBodyAnimationEditor, "Body animation", foldoutHeaderStyle);
            if (_showBodyAnimationEditor)
            {
                EditorGUI.indentLevel++;
                DrawBodyAnimationEditor();
                EditorGUI.indentLevel--;
                EditorGUILayout.Space();
            }

            if (_mouthModel != null)
            {
                _showMouthAnimationEditor = EditorGUILayout.Foldout(_showMouthAnimationEditor, "Mouth animation", foldoutHeaderStyle);

                if (_showMouthAnimationEditor)
                {
                    EditorGUI.indentLevel++;
                    DrawMouthPoseEditor();
                    EditorGUI.indentLevel--;
                }
            }

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Import", EditorStyles.boldLabel);

            _buildAssetBundlesAfterImport = EditorGUILayout.ToggleLeft("Build AssetBundles",
                _buildAssetBundlesAfterImport);

            if (GUILayout.Button("Save prefab and animations"))
            {
                EditorCoroutineUtility.StartCoroutine(Save(), this);
            }
            
            EditorGUILayout.Space();
        }
    }

    private void DrawGeneralSettingsEditor()
    {
        using (new EditorGUILayout.HorizontalScope())
        {
            _modelPath = EditorGUILayout.TextField("Model path", _modelPath);
            if (GUILayout.Button("Browse...", GUILayout.MaxWidth(80f)))
            {
                string path = EditorUtility.OpenFilePanelWithFilters("Open model", "", new[] {"Model", "fbx,dae"});
                if (path.Length > 0)
                {
                    _modelPath = path;
                }
            }
        }

        _targetModelName = EditorGUILayout.TextField("Target model name", _targetModelName);
        _targetAnimationBundleName =
            EditorGUILayout.TextField("Animation bundle name", _targetAnimationBundleName);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Retargeting sources", EditorStyles.boldLabel);

        _sourceModelBundle = EditorGUILayout.TextField("Source model bundle", _sourceModelBundle);

        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            int sourceAnimationBundleIndex = Array.IndexOf(_animationBundles, _sourceAnimationBundle);
            if (sourceAnimationBundleIndex != -1)
                sourceAnimationBundleIndex++;
            sourceAnimationBundleIndex = EditorGUILayout.Popup("Source animation bundle",
                sourceAnimationBundleIndex,
                _animationBundleNames);

            if (changeCheck.changed)
            {
                if (sourceAnimationBundleIndex == 0)
                {
                    string animationName = _graphicsDatabaseEntries
                        .Where(entry => _sourceModelBundle.StartsWith(entry.ModelName))
                        .Select(entry => entry.AnimationName)
                        .First();

                    sourceAnimationBundleIndex =
                        Array.FindIndex(_animationBundles, file => file.Name == animationName + ".ab") + 1;
                }

                _sourceAnimationBundle = _animationBundles[sourceAnimationBundleIndex - 1];
            }
        }

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Adjustments", EditorStyles.boldLabel);
        _scale = EditorGUILayout.FloatField("Import Scale", _scale);
        _autoFixTexturesOnLoad = EditorGUILayout.ToggleLeft("AutoFix textures on load", _autoFixTexturesOnLoad);

        using (new EditorGUI.DisabledScope(string.IsNullOrEmpty(_modelPath) ||
                                           string.IsNullOrEmpty(_sourceModelBundle) ||
                                           _sourceAnimationBundle == null))
        {
            if (GUILayout.Button("Load"))
            {
                try
                {
                    LoadModel();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                    EditorUtility.DisplayDialog("Error",
                        "An error occured. Please read the detailed error message in the console.", "OK");
                }
                finally
                {
                    EditorUtility.ClearProgressBar();
                }
            }
        }
    }
    
    private void DrawTextureEditor()
    {
        if (_texturePaths.Count <= 0)
            return;

        if (GUILayout.Button("Auto Fix"))
        {
            AutoFixTextures();
        }

        foreach (var texturePath in _texturePaths)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                EditorGUILayout.LabelField(Path.GetFileName(texturePath));
                if (GUILayout.Button("Fix..."))
                {
                    GenericMenu fixedMenu = new GenericMenu();
                    fixedMenu.AddItem(new GUIContent("Create mirrored texture"), false, 
                        () => CreateMirroredTexture(texturePath));
                    fixedMenu.AddItem(new GUIContent("Create mirrored texture with -25% X offset (eyes)"), false, 
                        () => CreateMirroredTextureForEyes(texturePath));

                    var mousePos = Event.current.mousePosition;
                    fixedMenu.DropDown(new Rect(mousePos, new Vector2(0, 0)));
                }
            }
        }
    }

    private void DrawBodyAnimationEditor()
    {
        using (new EditorGUILayout.HorizontalScope())
        {
            if (GUILayout.Button("Set Pose"))
            {
                AddConstraints();
            }
            if (GUILayout.Button("Remove constraints"))
            {
                RemoveConstraints();
            }
        }

        _footCorrection = EditorGUILayout.ToggleLeft("Synchronize foot position", _footCorrection);

        EditorGUILayout.Space();
        
        int selectedIndex = EditorGUILayout.Popup("Preview clip",
            Array.FindIndex(_animationClips, clip => clip.clip == _currentPreviewClip),
            _previewClipNames);
        _currentPreviewClip = _animationClips[selectedIndex].clip;

        using (var changeCheck = new EditorGUI.ChangeCheckScope())
        {
            _showSourceModel = EditorGUILayout.ToggleLeft("Show source model", _showSourceModel);
            if (changeCheck.changed)
            {
                UpdateSourceModelVisibility();
            }
        }

        _loopPreview = EditorGUILayout.ToggleLeft("Loop preview", _loopPreview);
        _previewSpeed = EditorGUILayout.FloatField("Preview speed", _previewSpeed);

        if (_previewPlaying)
        {
            if (GUILayout.Button("Stop animation preview"))
            {
                StopPreview();
            }
        }
        else
        {
            if (GUILayout.Button("Play animation preview"))
            {
                PlayPreview();
            }
        }
    }

    private void DrawMouthPoseEditor()
    {
        _createSkeletalMouthAnimations = EditorGUILayout.ToggleLeft("Create skeletal mouth animations", _createSkeletalMouthAnimations);
        if (!_createSkeletalMouthAnimations)
            return;

        using (new EditorGUILayout.HorizontalScope())
        {
            for (int i = 0; i < MouthModel.MouthPoseCount; i++)
            {
                float width = position.width / MouthModel.MouthPoseCount;
                var rect = GUILayoutUtility.GetRect(width - 5, width * 0.7f);

                var prevColor = GUI.backgroundColor;
                if (i == _mouthModel.CurrentPoseIndex)
                {
                    GUI.backgroundColor = Color.green;
                }

                if (GUI.Button(rect, ""))
                {
                    _mouthModel.CurrentPoseIndex = i;
                }

                GUI.backgroundColor = prevColor;
                GUI.DrawTextureWithTexCoords(new Rect(rect.x + 8, rect.y + 8, rect.width - 16, rect.height - 16),
                    PikachuMouthTexture, new Rect((i % 4) * 0.25f, (i / 4) * 0.5f + 0.5f, 0.25f, 0.5f));
            }
        }

        using (new GUILayout.HorizontalScope())
        {
            if (GUILayout.Button("Reset"))
            {
                _mouthModel.ResetTransform();
            }
            if (GUILayout.Button("Show in Hierarchy"))
            {
                _mouthModel.SelectAndExpandRoot();
            }
        }

        _mirrorMouth = EditorGUILayout.ToggleLeft("Mirror", _mirrorMouth);

        _showRotationHandles = EditorGUILayout.Foldout(_showRotationHandles, "Rotation");
        if (_showRotationHandles)
        {
            DrawMouthJointHandles(helper => helper is MouthModel.RotationJointHelper);
        }
        
        _showYHandles = EditorGUILayout.Foldout(_showYHandles, "Y Translation");
        if (_showYHandles)
        {
            DrawMouthJointHandles(helper => helper is MouthModel.TranslationJointHelper jointHelper
                && jointHelper.Axis == Axis.Y);
        }
        
        _showZHandles = EditorGUILayout.Foldout(_showZHandles, "Z Translation");
        if (_showZHandles)
        {
            DrawMouthJointHandles(helper => helper is MouthModel.TranslationJointHelper jointHelper
                                            && jointHelper.Axis == Axis.Z);
        }
    }

    private void DrawMouthJointHandles(Func<MouthModel.JointHelper, bool> condition)
    {
        EditorGUI.indentLevel++;
        foreach (var joint in _mouthModel.JointHelpers.Where(condition))
        {
            if (_mirrorMouth && _mouthModel.IsJointMirrored(joint))
            {
                continue;
            }
            
            using (var changeCheck = new EditorGUI.ChangeCheckScope())
            {
                using (new EditorGUILayout.HorizontalScope())
                {
                    float newValue = EditorGUILayout.Slider($"{joint.Name} ({joint.PropertyName})",
                        joint.Value, joint.MinValue, joint.MaxValue);
                    if (changeCheck.changed)
                    {
                        joint.Value = newValue;
                        if (_mirrorMouth)
                        {
                            _mouthModel.Mirror(joint);
                        }
                    }
                    
                    if (GUILayout.Button("Sel.", GUILayout.Width(40)))
                    {
                        _mouthModel.SelectJoint(joint, _mirrorMouth);
                    }
                }
            }
        }

        EditorGUI.indentLevel--;
    }
    
    public void AddItemsToMenu(GenericMenu menu)
    {
        menu.AddItem(new GUIContent("Open SwSh model list"), false,
            () => Application.OpenURL(
                "https://gbatemp.net/threads/wip-sword-and-shield-pokemon-models-and-textures.552281/"));
    }
    
    #endregion
    
    #region Import

    private void LoadModel()
    {
        EditorUtility.DisplayProgressBar("Loading model...", "Importing model...", 0f);
        
        if (_targetObject != null)
        {
            DestroyImmediate(_targetObject);
        }

        if (_sourceObject != null)
        {
            DestroyImmediate(_sourceObject);
        }
        
        StopPreview();
        
        string importDir = ImportHelpers.CreateDirectoryForImport(_targetModelName);
        string texturesDir = Path.Combine(importDir, "Textures");
        string materialsDir = Path.Combine(importDir, "Materials");
        ImportHelpers.EnsureDirectoryExists(texturesDir);
        ImportHelpers.EnsureDirectoryExists(materialsDir);
        
        string extension = Path.GetExtension(_modelPath);
        string modelImportPath = Path.Combine(importDir, $"{_targetModelName}{extension}");
        File.Copy(_modelPath, modelImportPath, true);
        AssetDatabase.ImportAsset(modelImportPath.ToAssetPath());
        
        EditorUtility.DisplayProgressBar("Loading model...", "Importing textures...", 0.2f);

        // Try to guess which files in the same folder could be textures
        string importedFileWithoutExtension = Path.GetFileName(_modelPath).Replace(Path.GetExtension(_modelPath), "");

        _texturePaths.Clear();
        foreach (var file in new DirectoryInfo(Path.GetDirectoryName(_modelPath)).EnumerateFiles()
            .Where(file => file.Name.StartsWith(importedFileWithoutExtension) && file.Name.Contains("col") && file.Extension == ".png"))
        {
            var destFileName = Path.Combine(texturesDir, file.Name);
            file.CopyTo(destFileName, true);

            _texturePaths.Add(destFileName.ToAssetPath());
            AssetDatabase.ImportAsset(destFileName.ToAssetPath());
        }
        
        EditorUtility.DisplayProgressBar("Loading model...", "Applying textures...", 0.4f);
        
        var modelImporter = AssetImporter.GetAtPath(modelImportPath.ToAssetPath()) as ModelImporter;
        if (modelImporter == null)
        {
            throw new Exception("Couldn't import model.");
        }
        
        modelImporter.globalScale = _scale;
        // Reimport here to make sure that the textures get applied
        modelImporter.SaveAndReimport();
        
        EditorUtility.DisplayProgressBar("Loading model...", "Creating materials...", 0.6f);

        var originalMaterials = AssetDatabase.LoadAllAssetsAtPath(modelImportPath.ToAssetPath()).OfType<Material>();
        foreach (var material in originalMaterials)
        {
            var newMaterial = Instantiate(material);
            ImportHelpers.ApplyDefaultMaterialProperties(newMaterial, ImportHelpers.GuessCharacterMaterialType(material.name));
            AssetDatabase.CreateAsset(newMaterial, $"{materialsDir}/{material.name}.asset");
            modelImporter.AddRemap(new AssetImporter.SourceAssetIdentifier(typeof(Material), material.name), newMaterial);
        }

        modelImporter.SaveAndReimport();
        
        EditorUtility.DisplayProgressBar("Loading model...", "Processing rig...", 0.8f);

        var targetModel = AssetDatabase.LoadAssetAtPath<GameObject>(modelImportPath.ToAssetPath());
        _targetObject = Instantiate(targetModel);

        MainSeriesRigHelper.Process(_targetObject.transform);

        var sourceModelBundle = Helpers.GetAssetBundle(ConfigManager.AssetBundleSourcePath, _sourceModelBundle);
        _sourceObject = Instantiate(sourceModelBundle.LoadAllAssets<GameObject>()[0]);
        FixSourceObjectShaders();

        AddConstraints();

        var sourceAnimationBundle =
            Helpers.GetAssetBundle(ConfigManager.AssetBundleSourcePath, _sourceAnimationBundle.Name);
        _animationClips = sourceAnimationBundle.LoadAllAssets<AnimationClip>().Select(animClip => (animClip, false))
            .Concat(sourceModelBundle.LoadAllAssets<AnimationClip>().Select(animClip => (animClip, true))).ToArray();
        _previewClipNames = _animationClips.Select(clip => clip.clip.name).ToArray();
        _currentPreviewClip = _animationClips[0].clip;
        UpdateSourceModelVisibility();

        var rootJaw = _targetObject.transform.FindDeepChild("RootJaw");
        _mouthModel = rootJaw != null ? new MouthModel(rootJaw) : null;

        if (_autoFixTexturesOnLoad)
        {
            EditorUtility.DisplayProgressBar("Loading model...", "Fixing textures...", 1f);
            AutoFixTextures();
        }
    }

    public IEnumerator Save()
    {
        try
        {
            string importDir = ImportHelpers.CreateDirectoryForImport(_targetModelName);
            string animationsDir = Path.Combine(importDir, "Animations");
            string modelAnimationsDir = Path.Combine(importDir, "ModelAnimations");
            ImportHelpers.EnsureDirectoryExists(animationsDir);
            if (_animationClips.Any(clip => clip.belongsToModelBundle))
            {
                ImportHelpers.EnsureDirectoryExists(modelAnimationsDir);
            }

            ResetMouth();

            var bodyAnimationProcessor = new BodyAnimationProcessor
            {
                SourceObject = _sourceObject,
                TargetObject = _targetObject,
                BodyAnimations = BodyAnimations.ToArray()
            };
            yield return bodyAnimationProcessor.ExportBodyAnimation(modelAnimationsDir, animationsDir,
                _targetModelName, _targetAnimationBundleName, _footCorrection);

            EditorUtility.DisplayProgressBar("Animation transfer", "Importing eye animations...", .9f);

            TextureAnimationImporter.Import(ConfigManager.AssetBundleSourcePath + "/" + _sourceModelBundle,
                modelAnimationsDir, _targetModelName,
                TextureAnimationImporter.AnimationType.Eyes,
                _targetObject.GetComponentsInChildren<SkinnedMeshRenderer>());
            TextureAnimationImporter.Import(_sourceAnimationBundle.FullName, animationsDir,
                _targetAnimationBundleName,
                TextureAnimationImporter.AnimationType.Eyes,
                _targetObject.GetComponentsInChildren<SkinnedMeshRenderer>());

            EditorUtility.DisplayProgressBar("Animation transfer", "Generating mouth animations (Step 1/4)...", .92f);

            var importedAnims = TextureAnimationImporter.Import(
                ConfigManager.AssetBundleSourcePath + "/" + _sourceModelBundle,
                modelAnimationsDir,
                _targetModelName,
                TextureAnimationImporter.AnimationType.Mouth,
                _targetObject.GetComponentsInChildren<SkinnedMeshRenderer>());

            if (_createSkeletalMouthAnimations)
            {
                EditorUtility.DisplayProgressBar("Animation transfer", "Generating mouth animations (Step 2/4)...",
                    .94f);

                MouthAnimationProcessor.CreateSkeletalMouthAnimationsFromTextureAnimations(importedAnims, _mouthModel,
                    _targetObject.transform.FindDeepChild("PG_root"));
            }

            EditorUtility.DisplayProgressBar("Animation transfer", "Generating mouth animations (Step 3/4)...", .96f);

            importedAnims = TextureAnimationImporter.Import(_sourceAnimationBundle.FullName,
                animationsDir,
                _targetAnimationBundleName,
                TextureAnimationImporter.AnimationType.Mouth,
                _targetObject.GetComponentsInChildren<SkinnedMeshRenderer>());

            if (_createSkeletalMouthAnimations)
            {
                EditorUtility.DisplayProgressBar("Animation transfer", "Generating mouth animations (Step 4/4)...",
                    .98f);

                MouthAnimationProcessor.CreateSkeletalMouthAnimationsFromTextureAnimations(importedAnims, _mouthModel,
                    _targetObject.transform.FindDeepChild("PG_root"));
            }

            ResetMouth();

            EditorUtility.DisplayProgressBar("Animation transfer", "Saving model...", 1f);

            RemoveConstraints();

            foreach (var bindposeStore in _targetObject.GetComponentsInChildren<BindposeStore>())
            {
                bindposeStore.Restore();
                DestroyImmediate(bindposeStore);
            }

            string prefabPath = Path.Combine(importDir, $"{_targetModelName}.prefab").ToAssetPath();
            ImportHelpers.GeneratePrefabForModel(_targetObject, prefabPath,
                Path.Combine(importDir, "Meshes").ToAssetPath());
            AssetImporter.GetAtPath(prefabPath).assetBundleName = _targetModelName;

            EditorUtility.DisplayProgressBar("Animation transfer", "Creating resource files...", 1f);

            CreateResourceFile(_targetModelName, importDir, clip => clip.belongsToModelBundle, true);
            CreateResourceFile(_targetAnimationBundleName, importDir, clip => !clip.belongsToModelBundle, false);

            EditorUtility.DisplayProgressBar("Animation transfer", "Refreshing asset database...", 1f);

            AssetDatabase.Refresh();

            EditorUtility.DisplayProgressBar("Animation transfer", "Building asset bundles...", 1f);

            if (_buildAssetBundlesAfterImport)
            {
                AbBuilder.Build(new[] {_targetModelName, _targetAnimationBundleName});
            }

            DestroyImmediate(_sourceObject);
            DestroyImmediate(_targetObject);
        }
        finally
        {
            EditorUtility.ClearProgressBar();
        }
    }
    
    #endregion
    
    #region Textures

    private void AutoFixTextures()
    {
        foreach (string texturePath in _texturePaths)
        {
            string fileName = Path.GetFileName(texturePath);
            if (fileName.ToLower().Contains("body"))
            {
                CreateMirroredTexture(texturePath);
            }
            else if (fileName.ToLower().Contains("eye") || fileName.ToLower().Contains("mouth"))
            {
                CreateMirroredTextureForEyes(texturePath);
            }
        }
    }

    private static void CreateMirroredTexture(string texturePath)
    {
        MainSeriesTextureHelper.ExpandTexture(texturePath);
    }
    
    private static void CreateMirroredTextureForEyes(string texturePath)
    {
        MainSeriesTextureHelper.ExpandTexture(texturePath, new Vector2(0.75f, 0f));
    }
    
    #endregion
    
    #region Animation

    private void UpdateAnimation()
    {
        float previewTime = (float) EditorApplication.timeSinceStartup - _startTime;
        if (previewTime > _currentPreviewClip.length && !_loopPreview)
        {
            StopPreview();
            Repaint();
            return;
        }

        _currentPreviewClip.SampleAnimation(_sourceObject, previewTime * _previewSpeed % _currentPreviewClip.length);
        if (_footCorrection)
        {
            JointConstraintHelper.ApplyFootCorrection(_sourceObject.transform, _targetObject.transform);
        }
    }

    private void PlayPreview()
    {
        _previewPlaying = true;
        _startTime = (float) EditorApplication.timeSinceStartup;
        EditorApplication.update += UpdateAnimation;
    }

    private void StopPreview()
    {
        _previewPlaying = false;
        EditorApplication.update -= UpdateAnimation;
    }

    private void AddConstraints()
    {
        RemoveConstraints();
        JointConstraintHelper.AddConstraints(_sourceObject.transform, _targetObject.transform);
    }

    private void RemoveConstraints()
    {
        foreach (var bindposeStore in _targetObject.GetComponentsInChildren<BindposeStore>())
        {
            DestroyImmediate(bindposeStore);
        }
        foreach (var constraint in _targetObject.GetComponentsInChildren<IConstraint>())
        {
            DestroyImmediate(constraint as UnityEngine.Object);
        }
    }
    
    #endregion
    
    #region Helpers
    
    private void CreateResourceFile(string assetBundleName, string targetFolder,
        Func<(AnimationClip clip, bool belongsToModelBundle), bool> filter, bool includeModel)
    {
        
        var resourceInfo = ModelResourceInfoEditorUtility.CreateResourceInfo(
            includeModel ? new[] {assetBundleName} : new string[]{},
            _animationClips.Where(filter)
                .Select(clip =>
                {
                    var animationName = $"{assetBundleName}__{clip.clip.name}";
                    // Ignore the "native" material animations since we don't know how they work.
                    // We can use skeletal animations even if we animate textures with Unity's animation system
                    return new GameObjectManager.ModelResourceInfo.AnimationInfo(animationName, animationName, "");
                }).ToArray()
            );
        
        string path = Path.Combine(targetFolder, $"{assetBundleName}_resource.bytes");
        ModelResourceInfoEditorUtility.WriteToFile(resourceInfo, path);
        ImportAssetToBundle(path.ToAssetPath(), assetBundleName);
    }

    public static void ImportAssetToBundle(string assetPath, string bundleName)
    {
        AssetDatabase.ImportAsset(assetPath);
        var importer = AssetImporter.GetAtPath(assetPath);
        importer.assetBundleName = bundleName;
        importer.SaveAndReimport();
    }
    
    private void ResetMouth()
    {
        if (_mouthModel != null)
        {
            _mouthModel.CurrentPoseIndex = 0;
        }
    }

    private void UpdateSourceModelVisibility()
    {
        foreach (var renderer in _sourceObject.GetComponentsInChildren<Renderer>())
        {
            renderer.enabled = _showSourceModel;
        }
    }

    private void FixSourceObjectShaders()
    {
        foreach (var renderer in _sourceObject.GetComponentsInChildren<Renderer>())
        {
            foreach (var material in renderer.sharedMaterials)
            {
                material.shader = Shader.Find("Custom/Preview");
            }
        }
    }
    
    #endregion
}
