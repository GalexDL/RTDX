/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace pokemon
{
	public class LevelUpDialogInParameter : IStructDefParameter // TypeDefIndex: 8667
	{
		// Fields
		private const uint Magic_ = 1777057408; // Metadata: 0x00630B29
		public ulong statusPointer; // 0x10
		public int valueDiffLv; // 0x18
		public int valueDiffHp; // 0x1C
		public int valueDiffAttack; // 0x20
		public int valueDiffDefend; // 0x24
		public int valueDiffExAttack; // 0x28
		public int valueDiffExDefend; // 0x2C
		public int valueDiffSubayasa; // 0x30
		public uint statusUniqueId; // 0x34
	
		// Properties
		public virtual uint Magic { get => default; } // 0x00AF1C50-0x00AF1C60 
	
		// Constructors
		public LevelUpDialogInParameter() {} // 0x00AF1EC0-0x00AF1ED0
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00AF1C60-0x00AF1D90
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x00AF1D90-0x00AF1EC0
	}
}
