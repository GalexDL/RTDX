/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class PlayerCommandParameter_DebugCreatureChange : IStructDefParameter // TypeDefIndex: 8504
	{
		// Fields
		private const uint Magic_ = 1774312482; // Metadata: 0x00614BCD
		public ulong creatureNativePointer; // 0x10
		public int nextCreature; // 0x18
	
		// Properties
		public virtual uint Magic { get => default; } // 0x007519F0-0x00751A00 
	
		// Constructors
		public PlayerCommandParameter_DebugCreatureChange() {} // 0x00751B40-0x00751B50
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00751A00-0x00751AA0
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x00751AA0-0x00751B40
	}
}
