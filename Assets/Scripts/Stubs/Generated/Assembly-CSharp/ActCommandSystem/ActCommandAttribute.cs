/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	public class ActCommandAttribute : Attribute // TypeDefIndex: 8729
	{
		// Fields
		public string CommandUniqName; // 0x10
		public Type AcceptTargetType; // 0x18
		public bool isNoDispUI; // 0x20
		public bool isNoImplement; // 0x21
		public bool isNoWaitCmd; // 0x22
	
		// Properties
		public Type[] AcceptTargetTypes { get; set; } // 0x008DB4F0-0x008DB500 0x008DB500-0x008DB510
	
		// Constructors
		public ActCommandAttribute() {} // 0x008DB510-0x008DB520
	}
}
