using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class RomTools : EditorWindow
{
    private const string HacpackPath = "Tools/hacpack/hacpack.exe";
    private const string KeysPath = "Tools/hacpack/prod.keys";
    private const string TitleId = "01003d200baa2000";
    
    private string _exefsPath = "";
    private string _romfsPath = "";
    
    private string _emulatorPath = "";
    private bool _autoLaunch;

    private Process _hacpack;
    
    public static string GetRomFsPath() => EditorPrefs.GetString("romfspath", "");
    public static string GetAssetBundlesPath() => Path.Combine(GetRomFsPath(), "Data", "StreamingAssets", "ab");
    
    [MenuItem("Tools/RomTools", false, 0)]
    static void Init()
    {
        GetWindow<RomTools>().Show();
    }

    private void OnEnable()
    {
        _exefsPath = EditorPrefs.GetString("exefspath", "");
        _romfsPath = EditorPrefs.GetString("romfspath", "");
        _emulatorPath = EditorPrefs.GetString("emulatorPath", "");
        _autoLaunch = EditorPrefs.GetBool("autoLaunch");
    }

    private void OnGUI()
    {
        EditorGUI.BeginChangeCheck();
        _exefsPath = EditorGUILayout.TextField("ExeFSPath", _exefsPath);
        _romfsPath = EditorGUILayout.TextField("RomFSPath", _romfsPath);
        
        EditorGUILayout.Space();
        _emulatorPath = EditorGUILayout.TextField("Emulator path", _emulatorPath);
        //_autoLaunch = EditorGUILayout.ToggleLeft("Auto-launch after build", _autoLaunch);

        if (EditorGUI.EndChangeCheck())
        {
            EditorPrefs.SetString("exefspath", _exefsPath);
            EditorPrefs.SetString("romfspath", _romfsPath);
            EditorPrefs.SetString("emulatorPath", _emulatorPath);
            EditorPrefs.SetBool("autoLaunch", _autoLaunch);
        }

        if (_hacpack != null)
        {
            GUILayout.Label(_hacpack.HasExited ? "Packing finished at " + _hacpack.ExitTime.ToShortTimeString() : "hacpack is running...");
        }

        if (GUILayout.Button("Build NCA"))
        {
            BuildNCA();
        }

        if (GUILayout.Button("Launch emulator with latest build"))
        {
            LaunchEmulator();
        }
        
        if (GUILayout.Button("Delete Builds"))
        {
            DeleteBuilds();
        }
    }

    private void LaunchEmulator()
    {
        var latestBuildFile = new DirectoryInfo("./Build").GetFiles()
            .OrderByDescending(f => f.LastWriteTime)
            .First(); // The file with the last write time is probably the right one
            
        var emulator = new Process(); 
        emulator.StartInfo = new ProcessStartInfo
        {
            FileName = _emulatorPath,
            Arguments = latestBuildFile.FullName
        };
        emulator.Start();
            
        Debug.Log("Launched emulator with " + latestBuildFile.FullName);
    }
    
    private void DeleteBuilds()
    {
        var files = new DirectoryInfo("./Build").GetFiles();
        int cnt = 0;
        foreach (var fileInfo in files)
        {
            fileInfo.Delete();
            cnt++;
        }
        Debug.Log($"Deleted {cnt} files.");
    }

    public void BuildNCA()
    {
        if (!File.Exists(Directory.GetCurrentDirectory() + "/" + KeysPath))
        {
            Debug.LogError(KeysPath + " is missing. This will probably cause hacpack to fail.");
        }

        string args = "-k " + Directory.GetCurrentDirectory() + "/" + KeysPath +
                      " -o Build --ncatype program --titleid "
                      + TitleId + " --exefsdir " + _exefsPath + " --romfsdir " + _romfsPath;
            
        Debug.Log(args);
        _hacpack = new Process(); 
        _hacpack.StartInfo = new ProcessStartInfo
        {
            FileName = Directory.GetCurrentDirectory() + "/" + HacpackPath,
            Arguments = args,
            UseShellExecute = true,
            //WindowStyle = ProcessWindowStyle.Minimized,
        };
        _hacpack.Exited += (sender, _) =>
        {
            Repaint();
            if (_autoLaunch)
            {
                LaunchEmulator();
            }
        };
        _hacpack.Start();
        /*hacPack.OutputDataReceived += (sender, args) =>
        {
            Debug.Log(args.Data);
        };
        hacPack.ErrorDataReceived += (sender, args) =>
        {
            Debug.LogError(args.Data);
        };*/
    }
}
