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
	public class SubscriberPostContentParam // TypeDefIndex: 9375
	{
		// Fields
		internal List<uint> topics; // 0x10
		internal List<byte> binary; // 0x18
		internal string message; // 0x20
	
		// Constructors
		public SubscriberPostContentParam() {} // 0x00FBD930-0x00FBD960
	
		// Methods
		public void SetTopic(List<uint> topics_) {} // 0x00FCB210-0x00FCB290
		public void SetTopic(uint topic_) {} // 0x00FCB290-0x00FCB340
		public List<uint> GetTopic() => default; // 0x00FCB340-0x00FCB350
		public uint GetTopicSingle() => default; // 0x00FCB350-0x00FCB3D0
		public void SetMessage(string message_) {} // 0x00FCB3D0-0x00FCB440
		public string GetMessage() => default; // 0x00FCB440-0x00FCB450
		public void SetBinary(List<byte> binary_) {} // 0x00FCB450-0x00FCB4D0
		public List<byte> GetBinary() => default; // 0x00FCB4D0-0x00FCB4E0
		public void Reset() {} // 0x00FCB0B0-0x00FCB210
		public void Trace() {} // 0x00FCB4E0-0x00FCB4F0
		public override string ToString() => default; // 0x00FCB4F0-0x00FCB5B0
	}
}
