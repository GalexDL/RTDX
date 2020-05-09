/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.account;
using nn.err;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public sealed class ShopServiceAccessor : IDisposable // TypeDefIndex: 9160
	{
		// Fields
		private IntPtr _shopServiceAccessor; // 0x10
		private bool isDisposed; // 0x18
	
		// Properties
		public static ErrorRange ResultShopServiceAccessError { get => default; } // 0x00A14490-0x00A144A0 
		public static ErrorRange ResultShopServiceAccessCanceled { get => default; } // 0x00A144A0-0x00A144B0 
		public static ErrorRange ResultShopServiceAccessInsufficientBuffer { get => default; } // 0x00A144B0-0x00A144C0 
		public static ErrorRange ResultShopServiceAccessInsufficientWorkMemory { get => default; } // 0x00A144C0-0x00A144D0 
		public static ErrorRange ResultShopServiceAccessInvalidCharacter { get => default; } // 0x00A144D0-0x00A144E0 
		public static ErrorRange ResultShopServiceAccessOverRequest { get => default; } // 0x00A144E0-0x00A144F0 
		public static ErrorRange ResultShopServiceAccessRequestTimeout { get => default; } // 0x00A144F0-0x00A14500 
		public static ErrorRange ResultShowErrorCodeRequired { get => default; } // 0x00A14500-0x00A14510 
		public static ErrorRange ResultInternetRequestNotAccepted { get => default; } // 0x00A14510-0x00A14520 
		public static ErrorRange ResultInsufficientWorkMemory { get => default; } // 0x00A14520-0x00A14530 
		internal IntPtr Ptr { get => default; } // 0x00A13240-0x00A13250 
		public static TimeSpan DefaultTimeout { get => default; } // 0x00A14530-0x00A14570 
	
		// Nested types
		public sealed class AsyncResponse : IDisposable // TypeDefIndex: 9161
		{
			// Fields
			internal IntPtr _asyncResponse; // 0x10
			private bool isDisposed; // 0x18
	
			// Constructors
			public AsyncResponse() {} // 0x00A14DB0-0x00A14E10
			public AsyncResponse(IntPtr asyncResponsePtr) {} // 0x00A14E20-0x00A14E80
	
			// Methods
			~AsyncResponse() {} // 0x00A14E80-0x00A14F00
			public Result Get(ref string outJson) => default; // 0x00A14FB0-0x00A15080
			public void Wait() {} // 0x00A150D0-0x00A150E0
			public bool TryWait() => default; // 0x00A150F0-0x00A15110
			public void Cancel() {} // 0x00A15130-0x00A15140
			public ErrorCode GetErrorCode() => default; // 0x00A15150-0x00A15160
			public void Dispose() {} // 0x00A14F00-0x00A14FB0
			private static extern Result GetSize(IntPtr asyncResponse, ref int outSize); // 0x00A15080-0x00A150A0
			private static extern Result Get(IntPtr asyncResponse, byte[] outReceivedData, int bufferCapacity); // 0x00A150A0-0x00A150D0
			private static extern void Wait(IntPtr asyncResponce); // 0x00A150E0-0x00A150F0
			private static extern bool TryWait(IntPtr asyncResponce); // 0x00A15110-0x00A15130
			private static extern void Cancel(IntPtr asyncResponce); // 0x00A15140-0x00A15150
			private static extern ErrorCode GetErrorCode(IntPtr asyncResponce); // 0x00A15160-0x00A15170
			private static extern void New(ref IntPtr asyncResponce); // 0x00A14E10-0x00A14E20
			private static extern void Delete(IntPtr asyncResponce); // 0x00A15170-0x00A15180
		}
	
		// Constructors
		public ShopServiceAccessor() {} // 0x00A145B0-0x00A14610
	
		// Methods
		public static extern Result InitializeForShopServiceAccessors(); // 0x00A14570-0x00A14590
		public static extern Result FinalizeForShopServiceAccessors(); // 0x00A14590-0x00A145B0
		~ShopServiceAccessor() {} // 0x00A14620-0x00A146F0
		public Result Initialize(ShopService targetType) => default; // 0x00A14780-0x00A147A0
		public Result Request(AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, TimeSpan timeout) => default; // 0x00A147C0-0x00A14880
		public Result Request(AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, TimeSpan timeout) => default; // 0x00A14920-0x00A149C0
		public Result Request(AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData) => default; // 0x00A14A50-0x00A14B00
		public Result Request(AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath) => default; // 0x00A14B00-0x00A14B80
		public void Dispose() {} // 0x00A14C00-0x00A14CE0
		private void _Dispose() {} // 0x00A146F0-0x00A14780
		private static extern Result Initialize(IntPtr shopServiceAccessor, ShopService target); // 0x00A147A0-0x00A147C0
		private static extern Result Finalize(IntPtr shopServiceAccessor); // 0x00A14CE0-0x00A14D00
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, long timeoutMilliseconds); // 0x00A14880-0x00A14920
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, long timeoutMilliseconds); // 0x00A149C0-0x00A14A50
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData); // 0x00A14D10-0x00A14DB0
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath); // 0x00A14B80-0x00A14C00
		private static extern void New(ref IntPtr shopServiceAccessor); // 0x00A14610-0x00A14620
		private static extern void Delete(IntPtr shopServiceAccessor); // 0x00A14D00-0x00A14D10
	}
}
