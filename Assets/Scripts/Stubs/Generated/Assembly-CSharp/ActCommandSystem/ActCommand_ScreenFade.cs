/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;
using FadeConst;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060CEB0-0x0060CF30
	public class ActCommand_ScreenFade : ActCommand_Basic // TypeDefIndex: 8868
	{
		// Fields
		private List<KeyValuePair<string, float>> FadeTimeConstLst; // 0x28
		[SerializeField] // 0x00617780-0x00617790
		public ActParam_MoveCamera moveCameraParam; // 0x30
		public bool isWait; // 0x38
		public FadeMode fadeMode; // 0x3C
		public FadeLayer fadeLayer; // 0x40
		public float fadeTime; // 0x44
		public string fadeTimeSymbol; // 0x48
		public Color fadeColorStart; // 0x50
		public Color fadeColorEnd; // 0x60
	
		// Nested types
		public enum FadeMode // TypeDefIndex: 8869
		{
			BlackIn = 0,
			BlackOut = 100,
			WhiteIn = 200,
			WhiteOut = 300,
			ColorChange = 500
		}
	
		public enum FadeLayer // TypeDefIndex: 8870
		{
			Front = 0,
			Back = 1
		}
	
		// Constructors
		public ActCommand_ScreenFade() {} // 0x00A8FC30-0x00A8FE10
	
		// Methods
		// [IteratorStateMachine] // 0x0063DA60-0x0063DAD0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A8FB20-0x00A8FBA0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A8FBD0-0x00A8FC30
	}
}
