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
	public static class Utility // TypeDefIndex: 9380
	{
		// Nested types
		public delegate void AcquireNexUniqueIdCB(AsyncResult asyncResult, ulong nexUniqueId); // TypeDefIndex: 9381; 0x0077EF40-0x0077F980
	
		public delegate void AcquireNexUniqueIdWithPasswordCB(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo); // TypeDefIndex: 9382; 0x0077FA40-0x007805E0
	
		public delegate void GetAssociatedNexUniqueIdWithMyPrincipalIdCB(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo); // TypeDefIndex: 9383; 0x00780630-0x00780C60
	
		public delegate void GetAssociatedNexUniqueIdWithMyPrincipalIdListCB(AsyncResult asyncResult, List<UniqueIdInfo> uniqueIdInfo); // TypeDefIndex: 9384; 0x00780CB0-0x00781850
	
		public delegate void GetIntegerSettingsCB(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings); // TypeDefIndex: 9385; 0x007818A0-0x00782440
	
		// Methods
		public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631EB9 */, AcquireNexUniqueIdCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD00-0x00FCBD10
		public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631EBD */, AcquireNexUniqueIdWithPasswordCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD10-0x00FCBD20
		public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo uniqueIdInfo, int timeOut = 0 /* Metadata: 0x00631EC1 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD20-0x00FCBD30
		public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> uniqueIdInfo, int timeOut = 0 /* Metadata: 0x00631EC5 */, AsyncResultCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD30-0x00FCBD40
		public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631EC9 */, GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD40-0x00FCBD50
		public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0 /* Metadata: 0x00631ECD */, GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD50-0x00FCBD60
		public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0 /* Metadata: 0x00631ED1 */, GetIntegerSettingsCB callback = null) {
			asyncId = default;
			return default;
		} // 0x00FCBD60-0x00FCBD70
		public static extern bool IsValidNexUniqueId(ulong nexUniqueId); // 0x00FCBD70-0x00FCBD90
	}
}
