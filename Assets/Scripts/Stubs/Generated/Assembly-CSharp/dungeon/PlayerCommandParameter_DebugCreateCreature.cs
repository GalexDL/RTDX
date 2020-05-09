/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class PlayerCommandParameter_DebugCreateCreature : IStructDefParameter // TypeDefIndex: 8509
	{
		// Fields
		private const uint Magic_ = 2145401762; // Metadata: 0x00614BE1
		public int creatureIndex; // 0x10
		public ushort distance; // 0x14
		public ushort level; // 0x16
		public ushort method; // 0x18
		public ushort direction; // 0x1A
		public bool isGuest; // 0x1C
	
		// Properties
		public virtual uint Magic { get => default; } // 0x00751550-0x00751560 
	
		// Constructors
		public PlayerCommandParameter_DebugCreateCreature() {} // 0x007518A0-0x007518B0
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00751560-0x00751650
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x00751650-0x007518A0
	}
}
