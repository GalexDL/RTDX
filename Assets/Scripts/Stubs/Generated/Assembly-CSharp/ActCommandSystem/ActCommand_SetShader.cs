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
	[ActCommand] // 0x0060C3D0-0x0060C470
	public class ActCommand_SetShader : ActCommand_Basic // TypeDefIndex: 8814
	{
		// Fields
		public ShaderType shaderType; // 0x28
	
		// Nested types
		public enum ShaderType // TypeDefIndex: 8815
		{
			DEFAULT = 0,
			GENEI = 100
		}
	
		// Constructors
		public ActCommand_SetShader() {} // 0x00A92F60-0x00A92F70
	
		// Methods
		// [IteratorStateMachine] // 0x0063CF00-0x0063CF70
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A92E90-0x00A92F10
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A92F40-0x00A92F50
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A92F50-0x00A92F60
	}
}
