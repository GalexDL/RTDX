/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class AttachSoundPlayer : MonoBehaviour // TypeDefIndex: 5971
{
	// Fields
	private const int DEFAULT_PARAMETER_NUM = 4; // Metadata: 0x00612333
	public Parameter[] aParameter_; // 0x18
	protected float fTime_; // 0x20
	protected float fPrevTime_; // 0x24

	// Nested types
	[Serializable]
	public class Parameter // TypeDefIndex: 5972
	{
		// Fields
		public float timingSeconds; // 0x10
		public string symbol; // 0x18

		// Properties
		public bool IsVald { get => default; } // 0x00865EA0-0x00865F00 

		// Constructors
		public Parameter() {} // 0x00866100-0x00866160
	}

	// Constructors
	public AttachSoundPlayer() {} // 0x00865BA0-0x00865C10

	// Methods
	private void Start() {} // 0x00865C10-0x00865C20
	public void SetParameter(int id, float fTimingSec, string symbol) {} // 0x00865C20-0x00865C90
	private void CheckPlay(Parameter param, float fPrevTime, float fNowTime) {} // 0x00865C90-0x00865D70
	private int CheckPlayPossibleCount(float fNowTime) => default; // 0x00865D70-0x00865EA0
	private void Update() {} // 0x00865F00-0x00865F70
	protected virtual bool CanUpdate() => default; // 0x008659C0-0x008659E0
	protected virtual void ReStart() {} // 0x00865F70-0x00865F80
	protected virtual void OnUpdateCheckReStart() {} // 0x00865F80-0x00865F90
	protected virtual void OnStart() {} // 0x00865F90-0x00865FA0
	protected virtual void OnUpdateSound(float fPrevTime, float fNowTime) {} // 0x00865FA0-0x008660C0
	protected virtual void OnUpdateTime() {} // 0x008660C0-0x00866100
}

