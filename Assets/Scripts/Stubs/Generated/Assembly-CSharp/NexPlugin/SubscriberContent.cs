/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class SubscriberContent // TypeDefIndex: 9374
	{
		// Fields
		internal ulong contentId; // 0x10
		internal ulong pid; // 0x18
		internal NpDateTime postTime; // 0x20
		internal List<uint> topics; // 0x28
		internal List<byte> binary; // 0x30
		internal string message; // 0x38
	
		// Constructors
		public SubscriberContent() {} // 0x00FBD7D0-0x00FBD880
	
		// Methods
		public ulong GetContentId() => default; // 0x00FCA980-0x00FCA990
		public string GetMessage() => default; // 0x00FCA990-0x00FCA9A0
		public List<byte> GetBinary() => default; // 0x00FCA9A0-0x00FCA9B0
		public ulong GetPosterPrincipalId() => default; // 0x00FCA9B0-0x00FCA9C0
		public List<uint> GetTopic() => default; // 0x00FCA9C0-0x00FCA9D0
		public uint GetTopicSingle() => default; // 0x00FCA9D0-0x00FCAA50
		public NpDateTime GetPostDateTime() => default; // 0x00FCAA50-0x00FCAA60
		public void Trace() {} // 0x00FCAA60-0x00FCAA70
		public override string ToString() => default; // 0x00FCAA70-0x00FCADB0
	}
}
