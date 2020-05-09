/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CommonSimpleInfoWindow : UIWindowBase // TypeDefIndex: 6191
{
	// Fields
	private GameObject objMoney_; // 0x30
	private GameObject objFriend_; // 0x38
	private GameObject objRank_; // 0x40
	private static string[] iconRankSprites; // 0x00
	private bool bRunning_; // 0x48
	private bool bReqEnd_; // 0x49
	private bool bReqClose_; // 0x4A
	private bool bReqUpdate_; // 0x4B
	private int viewCount_; // 0x4C

	// Constructors
	public CommonSimpleInfoWindow() {} // 0x0097E000-0x0097E010
	static CommonSimpleInfoWindow() {} // 0x0097E010-0x0097E5D0

	// Methods
	public static UICommonGuideWindow Create() => default; // 0x0097CFD0-0x0097D0A0
	protected override void _doUpdate() {} // 0x0097D0A0-0x0097D1D0
	public override void Init(GameObject root) {} // 0x0097D210-0x0097D3E0
	public void UpdateFace(bool bViewMoneyOnly = false /* Metadata: 0x0061297C */) {} // 0x0097D3E0-0x0097DB70
	public void Start() {} // 0x0097DB70-0x0097DC80
	public void StartMoneyOnly() {} // 0x0097DCF0-0x0097DE00
	public void End() {} // 0x0097DE70-0x0097DE80
	public void Close() {} // 0x0097DE80-0x0097DE90
	// [IteratorStateMachine] // 0x00625020-0x00625090
	public IEnumerator WaitEnd() => default; // 0x0097DE90-0x0097DF00
	public void RequestUpdate() {} // 0x0097DF30-0x0097DF50
	private bool _isSkip() => default; // 0x0097DF50-0x0097DF60
	// [IteratorStateMachine] // 0x00625090-0x00625100
	private IEnumerator MainLoop() => default; // 0x0097DC80-0x0097DCF0
	// [IteratorStateMachine] // 0x00625100-0x00625170
	private IEnumerator MainLoopMoneyOnly() => default; // 0x0097DE00-0x0097DE70
	public void ViewClear() {} // 0x0097D1D0-0x0097D1E0
	public void ViewCountup(int nCountUp = 1 /* Metadata: 0x0061297D */) {} // 0x0097D1E0-0x0097D210
	public void GroundEnable(bool bEnable) {} // 0x0097DFC0-0x0097E000
}

