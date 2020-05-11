using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class SkyEditorTest
{
   [MenuItem("Tools/SkyEditor Test")]
   public static void TestSkyEditor()
   {
      Debug.Log(string.Join(",", SkyEditorHelpers.GetRom().GetFixedPokemon().Entries.Select(e => e.PokemonId).Take(100)));
   }
}
