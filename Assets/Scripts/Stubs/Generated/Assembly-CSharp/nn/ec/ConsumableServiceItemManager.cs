/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 9150
	{
		// Fields
		private IntPtr _consumableServiceItemManager; // 0x10
		private IntPtr _workMemory; // 0x18
		private bool isDisposed; // 0x20
	
		// Constructors
		public ConsumableServiceItemManager() {} // 0x00A13020-0x00A13080
	
		// Methods
		~ConsumableServiceItemManager() {} // 0x00A13090-0x00A13170
		public Result Initialize(ShopServiceAccessor accessor, Uid user) => default; // 0x00A13210-0x00A13240
		public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) => default; // 0x00A13270-0x00A132C0
		public bool IsInitialized() => default; // 0x00A132F0-0x00A13310
		public bool CanQueryNewData() => default; // 0x00A13330-0x00A13350
		public bool IsConsumptionRequired() => default; // 0x00A13370-0x00A13390
		public bool IsRecoveryRequired() => default; // 0x00A133B0-0x00A133D0
		public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) {} // 0x00A133F0-0x00A13420
		public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) {} // 0x00A13430-0x00A13460
		public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) {} // 0x00A13470-0x00A134A0
		public long GetRequiredBufferSizeToExportSerializedRightData() => default; // 0x00A134B0-0x00A134C0
		public long ExportSerializedRightData(byte[] buffer) => default; // 0x00A134D0-0x00A134F0
		public byte[] ExportSerializedRightData() => default; // 0x00A13500-0x00A13590
		public int GetProvidableItemIdCount() => default; // 0x00A13590-0x00A135A0
		public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) => default; // 0x00A135B0-0x00A13680
		public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) {
			outItemIdArray = default;
			return default;
		} // 0x00A13750-0x00A137E0
		public Result MarkServiceProvided(ConsumableServiceItemId itemId) => default; // 0x00A137E0-0x00A13850
		public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) => default; // 0x00A138C0-0x00A13930
		public void Dispose() {} // 0x00A139A0-0x00A13A90
		private void _Dispose() {} // 0x00A13170-0x00A13210
		private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user); // 0x00A13250-0x00A13270
		private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize); // 0x00A132C0-0x00A132F0
		private static extern bool IsInitialized(IntPtr consumableServiceItemManager); // 0x00A13310-0x00A13330
		private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager); // 0x00A13350-0x00A13370
		private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager); // 0x00A13390-0x00A133B0
		private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager); // 0x00A133D0-0x00A133F0
		private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest); // 0x00A13420-0x00A13430
		private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest); // 0x00A13460-0x00A13470
		private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest); // 0x00A134A0-0x00A134B0
		private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager); // 0x00A134C0-0x00A134D0
		private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize); // 0x00A134F0-0x00A13500
		private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager); // 0x00A135A0-0x00A135B0
		private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, out ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount); // 0x00A13680-0x00A13750
		private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId); // 0x00A13850-0x00A138C0
		private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId); // 0x00A13930-0x00A139A0
		private static extern void New(ref IntPtr consumableServiceItemManager); // 0x00A13080-0x00A13090
		private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer); // 0x00A13A90-0x00A13AF0
	}
}
