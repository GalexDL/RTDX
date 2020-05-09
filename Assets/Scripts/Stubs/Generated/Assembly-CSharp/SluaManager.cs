/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00608CD0-0x00608D10
[ExecuteInEditMode] // 0x00608CD0-0x00608D10
public class SluaManager : SingletonMonoBehaviour<SluaManager> // TypeDefIndex: 4594
{
	// Fields
	private LuaSvr l; // 0x18
	private int progress_; // 0x20

	// Nested types
	public class LuaErrorInfo // TypeDefIndex: 4595
	{
		// Fields
		public string errorMessage; // 0x10
		public string stackTrace; // 0x18

		// Constructors
		public LuaErrorInfo() {} // 0x00907140-0x00907150
	}

	private class LuaThread_ : LuaVar // TypeDefIndex: 4596
	{
		// Fields
		private IntPtr _thread; // 0x20

		// Properties
		public bool IsLastLuaError { get; private set; } // 0x00907490-0x009074A0 0x009078D0-0x009078E0
		public string LastLuaErrorMessage { get; private set; } // 0x009075A0-0x009075B0 0x009078E0-0x009078F0

		// Constructors
		public LuaThread_() {} // Dummy constructor
		public LuaThread_(LuaFunction func) {} // 0x00907150-0x009072B0

		// Methods
		~LuaThread_() {} // 0x00907640-0x009076C0
		public override void Dispose(bool disposeManagedResources) {} // 0x009076C0-0x00907720
		public bool EqualsTo(IntPtr L) => default; // 0x00907720-0x00907730
		private object TopObjects_(int nArgs) => default; // 0x00907730-0x009078D0
		public bool Resume(out object retVal) {
			retVal = default;
			return default;
		} // 0x009072B0-0x00907490
		public string GetNowStackTrace() => default; // 0x009074A0-0x009075A0
	}

	// Constructors
	public SluaManager() {} // 0x00906A70-0x00906AE0

	// Methods
	private void OnEnable() {} // 0x00906670-0x00906730
	private void OnDisable() {} // 0x00906830-0x00906870
	private void AddLog(string str) {} // 0x009068B0-0x009068C0
	private void AddError(string str) {} // 0x009068C0-0x009068D0
	private void playmodeChange_() {} // 0x009068D0-0x009068E0
	private void createLuaState_() {} // 0x00906730-0x00906830
	private void destoryLuaState_() {} // 0x00906870-0x009068B0
	public void DoLuaCommand(string luaStr, string srcName) {} // 0x009068E0-0x009069A0
	// [IteratorStateMachine] // 0x0061A4A0-0x0061A510
	public IEnumerator DoLuaCoroutine(string luaStr, string srcName, Action endCb, Action<LuaErrorInfo> errorCb, Func<bool> exitCheck) => default; // 0x009069A0-0x00906A40
}

