/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowPlayer // TypeDefIndex: 4824
{
	// Fields
	private PlayMode_ playMode_; // 0x10
	private ManualCoroutineTask manualTask_; // 0x18
	private GameFlowPlayContext context_; // 0x20

	// Properties
	public bool IsPlaying { get => default; } // 0x00A66480-0x00A664A0 
	public GameFlowPlayContext CurrentPlayContext { get => default; } // 0x00A66780-0x00A66790 

	// Nested types
	private enum PlayMode_ // TypeDefIndex: 4825
	{
		None = 0,
		Playing = 1,
		PlayStopping = 2
	}

	public class Param // TypeDefIndex: 4826
	{
		// Fields
		public GameFlowLocalSaveData resumeData; // 0x10
		public GameFlow_SubScenarioManager subScenarioManager; // 0x18
		public GameFlowPlayContext.GameFlowSaveFunc gameFlowSaveFunc; // 0x20
		public PlaySequensMode playSequenceMode; // 0x28
		public object debugStartParam0; // 0x30
		public object debugStartParam1; // 0x38

		// Nested types
		public enum PlaySequensMode // TypeDefIndex: 4827
		{
			Single = 0,
			SubFlow = 1,
			All = 2
		}

		// Constructors
		public Param() {} // 0x00A67400-0x00A674C0
	}

	public class Result // TypeDefIndex: 4828
	{
		// Fields
		public GameFlowPlayContext context; // 0x10
		public GameFlowLocalSaveData suspendData; // 0x18
		public ErrorCode errorCode; // 0x20

		// Properties
		public bool IsError { get => default; } // 0x00A674C0-0x00A674D0 

		// Nested types
		public enum ErrorCode // TypeDefIndex: 4829
		{
			None = 0,
			Error = 1,
			ResumeError = 2
		}

		// Constructors
		public Result() {} // 0x00A67180-0x00A67240
	}

	// Constructors
	public GameFlowPlayer() {} // 0x00A612B0-0x00A612C0

	// Methods
	// [IteratorStateMachine] // 0x0061C0C0-0x0061C130
	private IEnumerator playerExecute_(GameFlowBlobBase startBlob, Param param, Action<GameFlowBlobBase> stepCb, Action<Result> endCb) => default; // 0x00A66230-0x00A662C0
	private static void startTask_(IEnumerator co) {} // 0x00A662F0-0x00A66370
	public void Play(GameFlowBlobBase startBlob, Param param, Action<GameFlowBlobBase> stepCb, Action<Result> endCb) {} // 0x00A66370-0x00A66480
	public void Play_ManualUpdate(GameFlowBlobBase startBlob, Param param, Action<GameFlowBlobBase> stepCb, Action<Result> endCb) {} // 0x00A664A0-0x00A66590
	public void ManualUpdate() {} // 0x00A66590-0x00A665B0
	public void Stop() {} // 0x00A665B0-0x00A665D0
	public void StopAndPlay(GameFlowBlobBase startBlob, Param param, Action<GameFlowBlobBase> stepCb, Action<Result> endCb) {} // 0x00A665D0-0x00A666C0
	// [IteratorStateMachine] // 0x0061C130-0x0061C1A0
	private IEnumerator stopAndPlay_(GameFlowBlobBase startBlob, Param param, Action<GameFlowBlobBase> stepCb, Action<Result> endCb) => default; // 0x00A666C0-0x00A66750
}

