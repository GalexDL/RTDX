using System;
using System.Collections.Generic;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[CreateAssetMenu(menuName = "DependencyPathIdMap", fileName = "DependencyPathIdMap")]
public class DependencyPathIdMap : ScriptableObject
{
    public static DependencyPathIdMap Load()
    {
        return Resources.Load<DependencyPathIdMap>("DependencyPathIDMap");
    }
    
    public List<Mapping> Mappings = new List<Mapping>();

    public Dictionary<long, long> OptimizedMap => Mappings.ToDictionary(mapping => mapping.Source, mapping => mapping.Target);

    [Serializable]
    public class Mapping
    {
        public string SourceAssetBundleName;
        public UnityEngine.Object SourceObject;
        public long Source;
        public long Target;
    }

    #if UNITY_EDITOR
    /*[ContextMenu("Resolve")]
    public void Resolve()
    {
        foreach (var mapping in Mappings)
        {
            AssetDatabase.TryGetGUIDAndLocalFileIdentifier(mapping.SourceObject, out string guid, out long localId);
            mapping.Source = localId;
        }
        EditorUtility.SetDirty(this);
    }*/
    #endif
}