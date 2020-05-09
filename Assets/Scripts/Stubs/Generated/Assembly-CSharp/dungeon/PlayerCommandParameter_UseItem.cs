/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class PlayerCommandParameter_UseItem : IStructDefParameter // TypeDefIndex: 8505
	{
		// Fields
		private const uint Magic_ = 1012064038; // Metadata: 0x00614BD1
		public ulong statusId; // 0x10
		public int[] selectItemIds; // 0x18
		public int selectItemCount; // 0x20
		public int itemUniqueId; // 0x24
		public int selectWaza; // 0x28
		public uint statusUniqueId; // 0x2C
	
		// Properties
		public virtual uint Magic { get => default; } // 0x00752460-0x00752470 
	
		// Constructors
		public PlayerCommandParameter_UseItem() {} // 0x007526D0-0x00752730
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00752470-0x007525A0
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x007525A0-0x007526D0
	}
}
