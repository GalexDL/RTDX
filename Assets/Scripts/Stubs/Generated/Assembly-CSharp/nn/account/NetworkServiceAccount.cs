/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.account
{
	public static class NetworkServiceAccount // TypeDefIndex: 9171
	{
		// Fields
		public const int IdTokenLengthMax = 3072; // Metadata: 0x0063144B
	
		// Properties
		public static ErrorRange ResultNetworkServiceAccountUnavailable { get; } // 0x00A10590-0x00A105A0 
		public static ErrorRange ResultTokenCacheUnavailable { get; } // 0x00A105A0-0x00A105B0 
		public static ErrorRange ResultNetworkCommunicationError { get; } // 0x00A105B0-0x00A105C0 
		public static ErrorRange ResultSslService { get; } // 0x00A105C0-0x00A105D0 
	
		// Methods
		public static extern Result EnsureAvailable(UserHandle handle); // 0x00A103B0-0x00A103F0
		public static extern Result IsAvailable(ref bool pOut, UserHandle handle); // 0x00A103F0-0x00A10430
		public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle); // 0x00A10430-0x00A10470
		public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) => default; // 0x00A10470-0x00A104B0
		public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle); // 0x00A104B0-0x00A104F0
		public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) => default; // 0x00A104F0-0x00A10550
		private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle); // 0x00A10550-0x00A10590
	}
}
