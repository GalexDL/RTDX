/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Events;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[CustomLuaClass] // 0x0060A8D0-0x0060A920
public class HelloWorld // TypeDefIndex: 8115
{
	// Fields
	public Color32 cc; // 0x10
	public UnityAction someAct; // 0x18
	private LuaFunction f; // 0x20
	[DoNotToLua] // 0x00616AF0-0x00616B00
	public int a; // 0x28
	internal int b; // 0x2C

	// Properties
	public object this[string path] { get => default; set {} } // 0x008EFA50-0x008EFAD0 0x008EFAD0-0x008EFB40
	public object this[int index] { get => default; set {} } // 0x008EFB40-0x008EFBC0 0x008EFBC0-0x008EFC30
	[DoNotToLua] // 0x0065AD70-0x0065AD80
	public int A { get => default; } // 0x008F0540-0x008F0550 

	// Constructors
	public HelloWorld() {} // 0x008F0710-0x008F0720

	// Methods
	public static void say() {} // 0x008EEDA0-0x008EEE10
	public static byte[] bytes() => default; // 0x008EEE10-0x008EEE80
	public static void int16Array(short[] array) {} // 0x008EEE80-0x008EEF80
	public static Vector3[] vectors() => default; // 0x008EEF80-0x008EF0B0
	public static void nullf(int? a = default) {} // 0x008EF0B0-0x008EF190
	// [IteratorStateMachine] // 0x00630FE0-0x00631050
	public IEnumerator y() => default; // 0x008EF190-0x008EF1F0
	public Dictionary<string, GameObject> foo() => default; // 0x008EF220-0x008EF290
	public Dictionary<string, GameObject>[] foos() => default; // 0x008EF290-0x008EF2E0
	public int gos(Dictionary<string, GameObject>[] x) => default; // 0x008EF2E0-0x008EF2F0
	public Dictionary<GameObject, string> too() => default; // 0x008EF2F0-0x008EF360
	public List<GameObject> getList() => default; // 0x008EF360-0x008EF440
	public static void setv(LuaTable t) {} // 0x008EF440-0x008EF810
	public static int getNegInt() => default; // 0x008EF810-0x008EF820
	public static LuaTable getv() => default; // 0x008EF820-0x008EFA50
	public static void ofunc(Type t) {} // 0x008EFC30-0x008EFCB0
	public static void ofunc(GameObject go) {} // 0x008EFCB0-0x008EFD30
	public static void AFunc(int a) {} // 0x008EFD30-0x008EFDA0
	public static void AFunc(float a) {} // 0x008EFDA0-0x008EFE10
	public static void AFunc(string a) {} // 0x008EFE10-0x008EFE80
	// [LuaOverride] // 0x00631050-0x00631090
	public static void AFunc(double a) {} // 0x008EFE80-0x008EFEF0
	public void generic<T>() {}
	public void perf() {} // 0x008EFEF0-0x008EFF60
	public static void testvec3(Vector3 v) {} // 0x008EFF60-0x008F0060
	public static void testset(GameObject go) {} // 0x008F0060-0x008F00B0
	public static void test2(GameObject go) {} // 0x008F00B0-0x008F0150
	public static void test3(GameObject go) {} // 0x008F0150-0x008F0220
	public static void test4(GameObject go) {} // 0x008F0220-0x008F02E0
	public static Vector3 test5(GameObject go) => default; // 0x008F02E0-0x008F03A0
	public static void func6(string str, params /* 0x0065AC80-0x0065AC90 */ object[] args) {} // 0x008F03A0-0x008F0490
	public void func7(LuaFunction func) {} // 0x008F0490-0x008F04A0
	public void func7(int a) {} // 0x008F04A0-0x008F0530
	[DoNotToLua] // 0x00631090-0x006310A0
	public static void dontexport() {} // 0x008F0530-0x008F0540
	public void func8(List<int> result) {} // 0x008F0550-0x008F05B0
	public static void byteArrayTest() {} // 0x008F05B0-0x008F06A0
	public static void transformArray(Transform[] arr) {} // 0x008F06A0-0x008F0710
}

