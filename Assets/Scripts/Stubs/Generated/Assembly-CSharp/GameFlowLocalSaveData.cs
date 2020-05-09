/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class GameFlowLocalSaveData // TypeDefIndex: 4675
{
	// Fields
	public SuspendMode mode; // 0x10
	[SerializeField] // 0x00616010-0x00616020
	private string suspendExecuteStackData_; // 0x18
	[SerializeField] // 0x00616020-0x00616030
	private string topBlobResumeDataJson_; // 0x20
	[SerializeField] // 0x00616030-0x00616040
	private string subScenarioManagerDataJson_; // 0x28
	[SerializeField] // 0x00616040-0x00616050
	private DungeonStartMode dungeonStartMode_; // 0x30

	// Properties
	public bool IsNeedSuspendOrResume { get => default; } // 0x00A64A20-0x00A64A30 

	// Nested types
	public enum SuspendMode // TypeDefIndex: 4676
	{
		None = 0,
		Suspend = 1
	}

	// Constructors
	public GameFlowLocalSaveData() {} // 0x00A64A30-0x00A64AA0

	// Methods
	public void Suspend<T>(GameFlowExecStack execStack, T topBlobSaveData, GameFlow_SubScenarioManager subScenarioManager) {}
	public void SetDungeonStartMode(DungeonStartMode startMode) {} // 0x00A644E0-0x00A644F0
	public bool ResumeStack(GameFlowExecStack execStack) => default; // 0x00A644F0-0x00A64500
	public bool ResumeSubScenarioManager(GameFlow_SubScenarioManager subScenarioManager) => default; // 0x00A64500-0x00A64550
	public T ResumeBlobSaveData<T>() => default;
	public DungeonStartMode ResumeDungeonStartMode() => default; // 0x00A64950-0x00A64960
	public void ClearSuspendData() {} // 0x00A64960-0x00A649C0
	public GameFlowLocalSaveData CloneData() => default; // 0x00A649C0-0x00A64A20
}

