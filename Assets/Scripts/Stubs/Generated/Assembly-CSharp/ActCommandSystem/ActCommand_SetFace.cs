/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CharacterConst;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060B9F0-0x0060BA70
	public class ActCommand_SetFace : ActCommand_Basic // TypeDefIndex: 8779
	{
		// Fields
		public FaceType faceType; // 0x28
		public EyeType eyeType; // 0x2C
		public MouthType mouthType; // 0x30
		private static FacePair[] facePairTbl_; // 0x00
	
		// Nested types
		public enum FaceType // TypeDefIndex: 8780
		{
			NONE = 0,
			NORMAL = 1,
			TALK = 2,
			BLINK = 3,
			HAPPY = 4,
			PAIN = 5,
			ANGRY = 6,
			THINK = 7,
			SAD = 8,
			WEEP = 9,
			SHOUT = 10,
			TEARS = 11,
			DECIDE = 12,
			GLADNESS = 13,
			EMOTION = 14,
			SURPRISE = 15,
			FAINT = 16,
			RELIEF = 17,
			CATCHBREATH = 18,
			SLEEP = 19,
			DAMAGE = 20,
			DOWN = 21
		}
	
		public enum EyeType // TypeDefIndex: 8781
		{
			NORMAL = 0,
			CLOSE = 1,
			ANGRY = 2,
			HAPPY = 3,
			PAIN = 4,
			SAD = 5,
			DOWN = 6,
			RESERVE00 = 7,
			NONE = 8
		}
	
		public enum MouthType // TypeDefIndex: 8782
		{
			NORMAL = 0,
			ANGRY = 1,
			HAPPY = 2,
			PAIN = 3,
			SAD = 4,
			SURPRISE = 5,
			RESERVE00 = 6,
			RESERVE01 = 7,
			NONE = 8
		}
	
		private struct FacePair // TypeDefIndex: 8783
		{
			// Fields
			public EyeType eye; // 0x10
			public MouthType mouth; // 0x14
		}
	
		// Constructors
		public ActCommand_SetFace() {} // 0x00A918C0-0x00A918D0
		static ActCommand_SetFace() {} // 0x00A918D0-0x00A91D40
	
		// Methods
		// [IteratorStateMachine] // 0x0063C870-0x0063C8E0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A916F0-0x00A91770
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A917A0-0x00A918C0
	}
}
