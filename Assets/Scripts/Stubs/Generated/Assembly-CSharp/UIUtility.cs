/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public static class UIUtility // TypeDefIndex: 5851
{
	// Fields
	public const string AS_ERROR = "As Error"; // Metadata: 0x00612066
	public const string PARENTOBJ_ERROR = "ParentObj null Obj Error"; // Metadata: 0x00612072
	public const string OBJ_ERROR = "Find Null Obj Error"; // Metadata: 0x0061208E
	public const string GETCOMPONENT_ERROR = "GetComponent Error"; // Metadata: 0x006120A5
	public const string INITIALIZATION_ERROR = "Initialization Error"; // Metadata: 0x006120BB
	public const string PARAM_UP_COLOR_TAG = "#00A2F8FF"; // Metadata: 0x006120D3
	public const string PARAM_DOWN_COLOR_TAG = "#FF0994FF"; // Metadata: 0x006120E0
	public const string PARAM_METAL_UP_COLOR_TAG = "#45F8FFCC"; // Metadata: 0x006120ED
	public const string PARAM_EVEN_COLOR_TAG = "#708CA0FF"; // Metadata: 0x006120FA
	public const string PARAM_DEF_COLOR_TAG = "#FFFFFFFF"; // Metadata: 0x00612107

	// Methods
	public static Color GetParamDefColor() => default; // 0x00A4F0A0-0x00A4F110
	public static Color GetParamUpDownColor(int subVal, bool isNormalColor = false /* Metadata: 0x00612064 */) => default; // 0x00A4F780-0x00A4F830
	public static Color GetParamUpDownColor(int mainVal, int subVal, bool isNormalColor = false /* Metadata: 0x00612065 */) => default; // 0x00A4F830-0x00A4F8E0
	public static Color GetMetalParamUpDownColor(int subVal) => default; // 0x00A4F8E0-0x00A4F970
	public static Color GetMetalParamUpDownColor(int mainVal, int subVal) => default; // 0x00A4F970-0x00A4FA10
	public static bool GetBit(int n, uint data) => default; // 0x00A4FA10-0x00A4FA30

	// Extension methods
	public static GameObject FindRecursive(this GameObject obj, string name) => default; // 0x00A4F110-0x00A4F230
	public static GameObject[] GatGameObjectsInChildren(this GameObject obj, bool includeInactive = false /* Metadata: 0x00612063 */) => default; // 0x00A4F230-0x00A4F370
	public static GameObject FindRootParent(this GameObject obj) => default; // 0x00A4F370-0x00A4F440
	public static GameObject FindRootParentPathName(this GameObject obj, ref string pathName) => default; // 0x00A4F440-0x00A4F5A0
	public static T[] GetComponentsInChildrenWithoutchildren<T>(this GameObject self)
		where T : Component => default;
	public static T[] GetComponentsInChildrenWithoutchildren<T>(this Component self)
		where T : Component => default;
	public static T FindRecursive<T>(this GameObject obj, string name)
		where T : class => default;
	public static int GetId(this GameObject obj) => default; // 0x00A4F5A0-0x00A4F600
	public static string GetStringId(this GameObject obj) => default; // 0x00A4F600-0x00A4F650
	public static GameObject SafeFindRecursive(this GameObject parentObj, string objectName) => default; // 0x00A4F650-0x00A4F730
	public static T FindRecursiveSafeGetComponent<T>(this GameObject parentObj, string objectName)
		where T : Component => default;
	public static T SafeGetComponent<T>(this GameObject gameObject)
		where T : Component => default;
	public static T SetComponent<T>(this GameObject gameObject)
		where T : Component => default;
	public static UnityEvent SetEventListener(this UnityEvent unityEvent, UnityAction unityAction) => default; // 0x00A4F730-0x00A4F780
}

