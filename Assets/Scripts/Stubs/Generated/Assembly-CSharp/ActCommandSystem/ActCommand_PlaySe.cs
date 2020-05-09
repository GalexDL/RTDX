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
	[ActCommand] // 0x0060CA40-0x0060CA80
	public class ActCommand_PlaySe : ActCommand_Basic // TypeDefIndex: 8837
	{
		// Fields
		public bool isWait; // 0x28
		public string symbol; // 0x30
		public float fadeInTime; // 0x38
		public float volume; // 0x3C
		public string volumeSymbol; // 0x40
		public static List<KeyValuePair<string, float>> VolumeConstLst; // 0x00
	
		// Constructors
		public ActCommand_PlaySe() {} // 0x008EA080-0x008EA150
		static ActCommand_PlaySe() {} // 0x008EA150-0x008EA310
	
		// Methods
		// [IteratorStateMachine] // 0x0063D3D0-0x0063D440
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E9ED0-0x008E9F50
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E9F80-0x008EA080
	}
}
