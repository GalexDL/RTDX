using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using SkyEditor.RomEditor.Domain.Rtdx;
using SkyEditor.RomEditor.Infrastructure.Automation;
using UnityEditor;
using UnityEngine;

public class SkyEditorScriptWindow : EditorWindow
{
    private IRtdxRom _rom;
    private string _scriptText;
    
    [MenuItem("Tools/Run Sky Editor Deluxe script", false, 50)]
    static void Init()
    {
        GetWindow<SkyEditorScriptWindow>().Show();
    }

    private void OnEnable()
    {
        _rom = SkyEditorHelpers.GetRom();
    }

    private void OnGUI()
    {
        _scriptText = EditorGUILayout.TextArea(_scriptText, GUILayout.ExpandHeight(true));
        if (GUILayout.Button("Run"))
        {
            var scriptHost = new CustomScriptHost(_rom);
            try
            {
                EditorUtility.DisplayProgressBar("Script execution", "Executing script...", 0f);
                scriptHost.ExecuteCSharp(_scriptText).Wait();
                EditorUtility.DisplayProgressBar("Script execution", "Saving rom...", 0.7f);
                SkyEditorHelpers.SaveRom(_rom);
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
        }
    }

    // Adapted C# script host, as a workaround for issues due to missing Lua DLL's
    // (see https://github.com/evandixon/SkyEditor.RomEditor.Rtdx/blob/master/SkyEditor.RomEditor.Rtdx/Infrastructure/Automation/ScriptHost.cs)
    public class CustomScriptHost
    {
        private static readonly Regex CSharpPreprocessorRegex = new Regex(@"^\s*\#.*?$", RegexOptions.Compiled | RegexOptions.Multiline);

        public CustomScriptHost(IRtdxRom rom)
        {
            Globals = new ScriptContext<IRtdxRom>(rom);
            CSharpScriptImports = new List<string>();
        }

        private List<string> CSharpScriptImports { get; set; }

        private ScriptContext<IRtdxRom> Globals { get; set; }

        public async Task ExecuteCSharp(string cSharpScript)
        {
            // Don't allow preprocessor directives
            var scriptWithoutPreprocessorDirectives = CSharpPreprocessorRegex.Replace(cSharpScript, "");

            await CSharpScript
                .RunAsync(string.Join(Environment.NewLine, CSharpScriptImports) + scriptWithoutPreprocessorDirectives,                
                ScriptOptions.Default
                .WithReferences(typeof(ScriptHost<>).Assembly)
                .WithImports(
                        "System",
                        "System.Linq",
                        "SkyEditor.RomEditor",
                        "SkyEditor.RomEditor.Domain.Rtdx.Constants"
                    ),
                globals: Globals)
                .ConfigureAwait(false);
        }
    }
}
