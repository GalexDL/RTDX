/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class NotificationEvent // TypeDefIndex: 9239
	{
		// Fields
		internal ulong param1; // 0x10
		internal ulong param2; // 0x18
		internal Common.NotificationEvents type; // 0x20
		internal uint subType; // 0x24
		internal string stringParam; // 0x28
		internal ulong pid; // 0x30
	
		// Constructors
		public NotificationEvent() {} // 0x00FAF3B0-0x00FAF3C0
	
		// Methods
		public ulong GetSource() => default; // 0x00FBFC40-0x00FBFC50
		public Common.NotificationEvents GetType() => default; // 0x00FBFC50-0x00FBFC60
		public uint GetSubType() => default; // 0x00FBFC60-0x00FBFC70
		public ulong GetParam1() => default; // 0x00FBFC70-0x00FBFC80
		public ulong GetParam2() => default; // 0x00FBFC80-0x00FBFC90
		public string GetStringParam() => default; // 0x00FBFC90-0x00FBFCA0
		public void Trace() {} // 0x00FBFCA0-0x00FBFCB0
		internal new string ToString() => default; // 0x00FBFCB0-0x00FBFFD0
	}
}
