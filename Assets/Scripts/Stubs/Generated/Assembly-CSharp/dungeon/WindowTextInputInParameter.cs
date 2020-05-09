/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class WindowTextInputInParameter : IStructDefParameter // TypeDefIndex: 8515
	{
		// Fields
		private const uint Magic_ = 1317129746; // Metadata: 0x00614BF9
		public int max; // 0x10
		public int mode; // 0x14
		public ushort[] text; // 0x18
	
		// Properties
		public virtual uint Magic { get => default; } // 0x00752E70-0x00752E80 
	
		// Constructors
		public WindowTextInputInParameter() {} // 0x00753080-0x007530E0
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00752E80-0x00752F80
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x00752F80-0x00753080
	}
}
