/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using dungeon;
using pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MainFiberUnity : Singleton<MainFiberUnity> // TypeDefIndex: 5545
{
	// Fields
	private IMainFiberUnityDungeonEngineInterrupt dungeonEngineInterrupt_; // 0x10
	private ManualCoroutineTask task_; // 0x18
	private UnityControlMode controlMode_; // 0x20
	private byte[] generalBuffer_; // 0x28
	private byte[] generalTempBuffer_; // 0x30

	// Constructors
	public MainFiberUnity() {} // 0x0088DE30-0x0088DF40

	// Methods
	public void SetDungeonEngineInterface(IMainFiberUnityDungeonEngineInterrupt engine) {} // 0x0088E070-0x0088E080
	private void FromNativeInParameter(IStructDefParameter inParameter) {} // 0x0088E080-0x0088E100
	private void ToNativeOutParameter(IStructDefParameter outParameter) {} // 0x0088E1C0-0x0088E2E0
	// [IteratorStateMachine] // 0x00620AA0-0x00620B10
	private IEnumerator MainLoop() => default; // 0x0088DF40-0x0088DFB0
	public DataExchangeByteMemoryStream ReadFiberSwitchGeneralBuffer() => default; // 0x0088E100-0x0088E1C0
	public void WriteFiberSwitchGeneralBuffer(DataExchangeByteMemoryStream stream) {} // 0x0088E2E0-0x0088E370
	public void UpdateMainFiber() {} // 0x0088E3A0-0x0088E430
}

