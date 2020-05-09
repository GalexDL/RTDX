/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowExecStack // TypeDefIndex: 4670
{
	// Fields
	private Stack<ExecPointer> execPointerStack; // 0x10
	public bool IsExitTop_SubFlowSingle; // 0x18
	public bool IsExitTop_SubFlowEnd; // 0x19

	// Properties
	public GameFlowBlobBase PeekExecFlowBlob { get => default; } // 0x00A638E0-0x00A63A50 
	public int StackDepth { get => default; } // 0x00A63B50-0x00A63BA0 
	public Stack<ExecPointer> DebugAccessExecPointerStack { get => default; } // 0x00A63BA0-0x00A63BB0 

	// Nested types
	public class ExecPointer // TypeDefIndex: 4671
	{
		// Fields
		public IGameFlowPlayable flowPlayable; // 0x10
		public GameFlowBlobList subFlowBlobList; // 0x18
		public int subFlowBlobListIdx; // 0x20

		// Properties
		public bool IsSubFlowPointer { get => default; } // 0x00A644D0-0x00A644E0 

		// Constructors
		public ExecPointer() {} // 0x00A637B0-0x00A637C0

		// Methods
		public void ClearSubFlowPointer() {} // 0x00A644C0-0x00A644D0
		public GameFlowBlobBase GetBlob() => default; // 0x00A63A50-0x00A63B50
	}

	[Serializable]
	private class SaveExecPointer_ // TypeDefIndex: 4672
	{
		// Fields
		public string flowId; // 0x10
		public string blobListName; // 0x18
		public int blobListIdx; // 0x20

		// Constructors
		public SaveExecPointer_() {} // 0x00A640A0-0x00A640B0
	}

	[Serializable]
	private class SaveExecStack_ // TypeDefIndex: 4673
	{
		// Fields
		public List<SaveExecPointer_> pointerList; // 0x10
		public bool isExitTop_SubFlowSingle; // 0x18
		public bool isExitTop_SubFlowEnd; // 0x19

		// Constructors
		public SaveExecStack_() {} // 0x00A64030-0x00A640A0
	}

	// Constructors
	public GameFlowExecStack() {} // 0x00A64430-0x00A644A0

	// Methods
	public void Clear() {} // 0x00A5F130-0x00A5F190
	public void PushExecPointer(IGameFlowPlayable flowPlayable) {} // 0x00A5AA80-0x00A5AB10
	public void PushExecPointer(IGameFlowPlayable owner, GameFlowBlobList subFlowBlobList, int subFlowBlobListIdx) {} // 0x00A637C0-0x00A63860
	public void PopExecPointer() {} // 0x00A5AC50-0x00A5ACA0
	public bool IsResumeExecPointer(IGameFlowPlayable owner) => default; // 0x00A5A9E0-0x00A5AA80
	public string PeekResumeListName() => default; // 0x00A5AB10-0x00A5ABC0
	public ExecPointer PeekExecPointer() => default; // 0x00A63860-0x00A638E0
	public void SetupPlayRange_TopOnly() {} // 0x00A63BB0-0x00A63C70
	public void SetupPlayRange_TopSubflowOnly() {} // 0x00A63C70-0x00A63D30
	public string Serialize() => default; // 0x00A63D30-0x00A64030
	public bool Deserialize(string data) => default; // 0x00A640B0-0x00A64420
}

