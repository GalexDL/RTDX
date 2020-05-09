/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[CustomLuaClass] // 0x0060A860-0x0060A870
public class Deleg : MonoBehaviour // TypeDefIndex: 8105
{
	// Fields
	public static GetBundleInfoDelegate d; // 0x00
	public static SimpleDelegate s; // 0x08
	private LuaSvr l; // 0x18
	public static Action<int, Dictionary<int, object>> daction; // 0x10

	// Properties
	public static GetBundleInfoDelegate dx { get => default; set {} } // 0x00991180-0x009911D0 0x009911D0-0x00991230

	// Nested types
	public delegate bool GetBundleInfoDelegate(string a1, int a2, int a3, ref int a4, out string a5, out int a6); // TypeDefIndex: 8106; 0x00991460-0x00991B60

	public delegate void SimpleDelegate(string path, GameObject g); // TypeDefIndex: 8107; 0x00991B60-0x00992190

	// Constructors
	public Deleg() {} // 0x00992480-0x00992490

	// Methods
	private void Start() {} // 0x00991230-0x009912E0
	public static void callD() {} // 0x009912E0-0x00991460
	public static void setcallback2(Action<int> a, Action<string> b) {} // 0x00992190-0x00992230
	public static void testFunc(Func<int> f) {} // 0x00992230-0x009922F0
	public static void testAction(Action<int, string> f) {} // 0x009922F0-0x00992350
	public static void testDAction(Action<int, Dictionary<int, object>> f) {} // 0x00992350-0x009923D0
	public static void callDAction() {} // 0x009923D0-0x00992470
	public static Func<int, string, bool> getFunc(Func<int, string, bool> f) => default; // 0x00992470-0x00992480
}

