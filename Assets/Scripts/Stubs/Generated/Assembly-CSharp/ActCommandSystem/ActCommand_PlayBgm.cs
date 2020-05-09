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
	[ActCommand] // 0x0060CC00-0x0060CC50
	public class ActCommand_PlayBgm : ActCommand_Basic // TypeDefIndex: 8849
	{
		// Fields
		public string symbol; // 0x28
		public float fadeInTime; // 0x30
		public bool isLoop; // 0x34
		public Channel channel; // 0x38
		public float volume; // 0x3C
		public string volumeSymbol; // 0x40
		public static List<KeyValuePair<string, float>> VolumeConstLst; // 0x00
	
		// Nested types
		public enum Channel // TypeDefIndex: 8850
		{
			BGM_0 = 0,
			BGM_1 = 1,
			ENV_0 = 2,
			ENV_1 = 3
		}
	
		// Constructors
		public ActCommand_PlayBgm() {} // 0x008E87F0-0x008E88C0
		static ActCommand_PlayBgm() {} // 0x008E88C0-0x008E8A80
	
		// Methods
		// [IteratorStateMachine] // 0x0063D670-0x0063D6E0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E8680-0x008E86F0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E8720-0x008E87F0
	}
}
