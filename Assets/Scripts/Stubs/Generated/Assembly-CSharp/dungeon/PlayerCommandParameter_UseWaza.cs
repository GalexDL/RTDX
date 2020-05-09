/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class PlayerCommandParameter_UseWaza : IStructDefParameter // TypeDefIndex: 8497
	{
		// Fields
		private const uint Magic_ = 1475101446; // Metadata: 0x00614BB1
		public int wazaIndex; // 0x10
		public int itemUniqueId; // 0x14
		public int index; // 0x18
		public byte checkWaruagaki; // 0x1C
	
		// Properties
		public virtual uint Magic { get => default; } // 0x00752730-0x00752740 
	
		// Constructors
		public PlayerCommandParameter_UseWaza() {} // 0x007528E0-0x007528F0
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00752740-0x00752810
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x00752810-0x007528E0
	}
}
