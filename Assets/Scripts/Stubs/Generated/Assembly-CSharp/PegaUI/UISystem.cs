/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace PegaUI
{
	public static class UISystem // TypeDefIndex: 8350
	{
		// Methods
		public static void CallUiAction(GameObject rootObj, string actionName, UnityAction endCallback) {} // 0x0078B770-0x0078BA20
		public static void ApplyFunc(GameObject rootObj, string id, UnityAction<UIAttribute> func) {} // 0x0078BA20-0x0078BA30
		public static void ApplyFunc<ComponentT>(GameObject rootObj, string id, UnityAction<ComponentT, UIAttribute> func) {}
		public static void Each(GameObject rootObj, string id, UnityAction<UIAttribute> func) {} // 0x0078BA30-0x0078BB00
		public static void Each<ComponentT>(GameObject rootObj, string id, UnityAction<ComponentT, UIAttribute> func) {}
		public static UIAttribute Find(GameObject rootObj, string id) => default; // 0x0078BC20-0x0078BCF0
		public static List<UIAttribute> FindAll(GameObject rootObj, string id) => default; // 0x0078BB10-0x0078BC20
	}
}
