/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060D0B0-0x0060D130
	public class ActCommand_PostEffectBlur : ActCommand_Basic // TypeDefIndex: 8880
	{
		// Fields
		public bool isWait; // 0x28
		public Mode mode; // 0x2C
		public float blurAmount; // 0x30
		public float blurRateScale; // 0x34
		public float blurRateRotate; // 0x38
		public float blurRateCenterAlpha; // 0x3C
		public bool isBlurTwoLoop; // 0x40
		public float timeSec; // 0x44
	
		// Nested types
		public enum Mode // TypeDefIndex: 8881
		{
			Off = 0,
			On = 100
		}
	
		// Constructors
		public ActCommand_PostEffectBlur() {} // 0x008EA6B0-0x008EA760
	
		// Methods
		// [IteratorStateMachine] // 0x0063DC90-0x0063DD00
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008EA540-0x008EA5C0
		// [IteratorStateMachine] // 0x0063DD00-0x0063DD70
		public IEnumerator actFunc() => default; // 0x008EA5C0-0x008EA630
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008EA660-0x008EA6B0
	}
}
