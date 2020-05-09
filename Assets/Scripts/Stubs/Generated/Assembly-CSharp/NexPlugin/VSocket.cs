/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class VSocket // TypeDefIndex: 9347
	{
		// Fields
		public const uint MAX_DATA_SIZE = 1250; // Metadata: 0x00631E61
		public const uint MARGIN_SIZE = 12; // Metadata: 0x00631E65
		public const uint DEFAULT_MAX_RECV_PACKTES = 128; // Metadata: 0x00631E69
		public const uint TOTAL_NAT_TRAVERSAL_TIMEOUT_MS = 120000; // Metadata: 0x00631E6D
	
		// Nested types
		public enum Result // TypeDefIndex: 9348
		{
			Success = 0,
			Error = 1,
			WouldBlock = 2,
			PacketBufferFull = 3
		}
	
		// Constructors
		public VSocket() {} // 0x00782480-0x00782490
	}
}
