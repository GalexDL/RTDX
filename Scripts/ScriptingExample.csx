// Run with "./SkyEditor.RomEditor.Rtdx.ConsoleApp [rom path] CommandLineExample.csx --save".
// You'll need to install the Sky Editor console app separately: 

using System;
using System.IO;
using System.Diagnostics;
using SkyEditor.RomEditor.Rtdx.Domain;
using SkyEditor.RomEditor.Rtdx.Domain.Models;

void ExecuteUnityCommand(string command)
{
    Console.WriteLine($"Running command in Unity: {command}");
    var process = new Process();
    process.StartInfo = new ProcessStartInfo
    {
        FileName = UNITY_PATH,
        Arguments = 
            "-nographics " +
            "-batchmode " +
            $"-executeMethod {command} " + 
            "-quit " + 
            "-logfile", // Enable logging to console
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false
    };
    process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
    process.ErrorDataReceived += (sender, args) => Console.WriteLine(args.Data);
    process.Start();
    
    process.WaitForExit();
}

// Adjust this
const string UNITY_PATH = "D:\\UnityEditors\\2018.4.16f1\\Editor\\Unity.exe";

Console.WriteLine("Importing models");

// Import character models specified in Data/psmd_import.yml
// Note that Unity will use the ROM path in Data/config.yml instead of
// the command line argument for Sky Editor so make sure that those match
ExecuteUnityCommand("PSMDImport.Import");

Console.WriteLine("Adding starters");

var starters = Rom.GetStarters();
starters.Starters[0].PokemonId = CreatureIndex.FOKKO;
starters.Starters[1].PokemonId = CreatureIndex.ZOROA;
