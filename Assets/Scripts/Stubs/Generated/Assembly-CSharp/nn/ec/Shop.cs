/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public static class Shop // TypeDefIndex: 9162
	{
		// Methods
		public static extern void ShowApplicationInformation(ulong applicationId); // 0x00A13F40-0x00A13F50
		public static extern void ShowApplicationInformation(ulong applicationId, UserHandle selectedUser); // 0x00A13F50-0x00A13F80
		public static extern void ShowAddOnContentList(ulong applicationId); // 0x00A13F80-0x00A13F90
		public static extern void ShowAddOnContentList(ulong applicationId, UserHandle selectedUser); // 0x00A13F90-0x00A13FC0
		public static extern void ShowSubscriptionList(ulong applicationId); // 0x00A13FC0-0x00A13FD0
		public static extern void ShowSubscriptionList(ulong applicationId, UserHandle selectedUser); // 0x00A13FD0-0x00A14000
		public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId); // 0x00A14000-0x00A14060
		public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId, UserHandle selectedUser); // 0x00A14060-0x00A140E0
		public static extern void ShowConsumableItemList(ulong applicationId); // 0x00A140E0-0x00A140F0
		public static extern void ShowConsumableItemList(ulong applicationId, UserHandle selectedUser); // 0x00A140F0-0x00A14120
		public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid); // 0x00A14120-0x00A14190
		public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid, UserHandle selectedUser); // 0x00A14190-0x00A14220
		public static extern void ShowEnterCodeScene(); // 0x00A14220-0x00A14230
		public static extern void ShowEnterCodeScene(UserHandle selectedUser); // 0x00A14230-0x00A14260
		public static extern void ShowShopProductDetails(NsUid nsuid); // 0x00A14260-0x00A14270
		public static extern void ShowShopProductDetails(NsUid nsuid, UserHandle selectedUser); // 0x00A14270-0x00A142A0
		public static void ShowShopProductList(NsUid[] nsuidList, string listName) {} // 0x00A142A0-0x00A142F0
		private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName); // 0x00A142F0-0x00A14340
		public static void ShowShopProductList(NsUid[] nsuidList, string listName, UserHandle selectedUser) {} // 0x00A14340-0x00A143C0
		private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName, UserHandle selectedUser); // 0x00A143C0-0x00A14440
		public static extern NsUid MakeNsUid(string str); // 0x00A14440-0x00A14480
	}
}
