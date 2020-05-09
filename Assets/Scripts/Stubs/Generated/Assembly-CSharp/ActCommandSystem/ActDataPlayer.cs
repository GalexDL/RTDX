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
	public class ActDataPlayer // TypeDefIndex: 8708
	{
		// Nested types
		public class PlayContext // TypeDefIndex: 8709
		{
			// Fields
			public ScriptDataPlayer.PlayerContext scriptDataPlayerContext; // 0x10
			public bool bRequestTaskLoopEnd; // 0x18
			public bool bRequestTaskForceExit; // 0x19
			public List<Action> forceExitCbList; // 0x20
			public HashSet<ActCommandCell> highlight_playingCommandSet; // 0x28
			public HashSet<ActCommandCell> highlight_endCommandSet; // 0x30
	
			// Properties
			public ScriptDataPlayer.PlayerTaskSys taskSys { get => default; } // 0x00A90A60-0x00A90A70 
	
			// Constructors
			public PlayContext() {} // 0x00A9E780-0x00A9E840
		}
	
		public class CommandInstance // TypeDefIndex: 8710
		{
			// Fields
			public ActTargetBase target; // 0x10
			public PlayContext context; // 0x18
			public ActCommandCell commandCell; // 0x20
	
			// Constructors
			public CommandInstance() {} // 0x00A9C6A0-0x00A9C6B0
	
			// Methods
			// [IteratorStateMachine] // 0x006547C0-0x00654830
			public virtual IEnumerator Play(Action<ActCommandCell> waitEndCb) => default; // 0x00A9E470-0x00A9E4F0
		}
	
		// Constructors
		public ActDataPlayer() {} // 0x00A9A910-0x00A9A920
	
		// Methods
		// [IteratorStateMachine] // 0x0063BF20-0x0063BF90
		public static IEnumerator Play(ActDataSet actDataSet, Action endCb, Action stepCb, PlayContext context) => default; // 0x00A9A620-0x00A9A6B0
		// [IteratorStateMachine] // 0x0063BF90-0x0063C000
		public static IEnumerator Play(List<ActTargetCommandParallelData> seqList, Action endCb, Action stepCb, PlayContext context) => default; // 0x00A9A6E0-0x00A9A770
		// [IteratorStateMachine] // 0x0063C000-0x0063C070
		public static IEnumerator Play(ActTargetCommands targetCommands, Action endCb, Action stepCb, PlayContext context) => default; // 0x00A9A7A0-0x00A9A820
		// [IteratorStateMachine] // 0x0063C070-0x0063C0E0
		public static IEnumerator PlayCore(HashSet<CommandInstance> commandInstanceSet, Action<bool> endCb, Action stepCb, Action<Exception, ActCommandCell> commandExceptionCb, PlayContext context) => default; // 0x00A9A850-0x00A9A8E0
	}
}
