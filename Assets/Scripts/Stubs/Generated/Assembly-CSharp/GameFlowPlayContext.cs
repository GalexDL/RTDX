/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowPlayContext // TypeDefIndex: 4677
{
	// Fields
	public GameFlowExecStack ExecuteStack; // 0x10
	public Action<IGameFlowPlayable> stepCb; // 0x18
	public Action<string> errorCb; // 0x20
	public GameFlow_SubScenarioManager subScenarioManager; // 0x28
	public GameFlowLocalSaveData gameFlowLocalSaveData; // 0x30
	public DebugStartParam debugStartParam; // 0x38
	public HashSet<string> flowNotifyMsgSet; // 0x40
	public GameFlowSaveFunc gameFlowSaveFunc; // 0x48

	// Properties
	public bool IsNeedSuspendOrResume { get => default; } // 0x00A64B00-0x00A64B20 

	// Nested types
	public class DebugStartParam // TypeDefIndex: 4678
	{
		// Fields
		public GameFlowBlobBase targetBlob; // 0x10
		public object param0; // 0x18
		public object param1; // 0x20

		// Constructors
		public DebugStartParam() {} // 0x00A65960-0x00A65970
	}

	public delegate void GameFlowSaveFunc(GameFlowLocalSaveData localSaveData); // TypeDefIndex: 4679; 0x00A65980-0x00A661F0

	// Constructors
	public GameFlowPlayContext() {} // 0x00A64D20-0x00A64E70

	// Methods
	public void SetSuspend<T>(T optionResumeData) {}
	public T ResumeBlobSaveData<T>()
		where T : class => default;
	public void ClearSuspend() {} // 0x00A64AA0-0x00A64B00
	public GameFlowLocalSaveData MakeSuspendDataSnapshot<T>(T optionResumeData) => default;
	public void CallErrorCb(string msg) {} // 0x00A5B500-0x00A5B580
	public void CallStepCb(IGameFlowPlayable playable) {} // 0x00A64B20-0x00A64BA0
	// [IteratorStateMachine] // 0x0061A9D0-0x0061AA40
	public static IEnumerator DispAndAutoCloseDebugMessage(TextId textId) => default; // 0x00A64BA0-0x00A64C10
	// [IteratorStateMachine] // 0x0061AA40-0x0061AAB0
	public static IEnumerator DispErrorMessage(TextId textId) => default; // 0x00A5ABD0-0x00A5AC40
	// [IteratorStateMachine] // 0x0061AAB0-0x0061AB20
	public IEnumerator Play(Func<bool> isNeedExit) => default; // 0x00A64C70-0x00A64CF0
}

