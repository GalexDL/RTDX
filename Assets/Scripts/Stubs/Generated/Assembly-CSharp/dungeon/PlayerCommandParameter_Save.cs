﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace dungeon
{
	public class PlayerCommandParameter_Save : IStructDefParameter // TypeDefIndex: 8506
	{
		// Fields
		private const uint Magic_ = 1237857555; // Metadata: 0x00614BD5
		public bool bRescue; // 0x10
		public bool bContinue; // 0x11
	
		// Properties
		public virtual uint Magic { get => default; } // 0x007522F0-0x00752300 
	
		// Constructors
		public PlayerCommandParameter_Save() {} // 0x00752450-0x00752460
	
		// Methods
		public void ExportToStream(IBinaryDataByteStream stream) {} // 0x00752300-0x007523A0
		public void ImportFromStream(IBinaryDataByteStream stream) {} // 0x007523A0-0x00752450
	}
}
