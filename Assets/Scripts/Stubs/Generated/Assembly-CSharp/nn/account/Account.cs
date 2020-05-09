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
	public static class Account // TypeDefIndex: 9170
	{
		// Fields
		public const int UserCountMax = 8; // Metadata: 0x0063143F
		public const int ProfileImageBytesMax = 131072; // Metadata: 0x00631443
		public const int SaveDataThumbnailImageBytesMax = 147456; // Metadata: 0x00631447
	
		// Properties
		public static ErrorRange ResultCancelled { get; } // 0x00A0FEB0-0x00A0FEC0 
		public static ErrorRange ResultCancelledByUser { get; } // 0x00A0FEC0-0x00A0FED0 
		public static ErrorRange ResultUserNotExist { get; } // 0x00A0FED0-0x00A0FEE0 
	
		// Methods
		public static extern Result GetUserCount(ref int pOutCount); // 0x00A0F890-0x00A0F8B0
		public static extern Result GetUserExistence(ref bool pOutExistence, Uid user); // 0x00A0F8B0-0x00A0F8D0
		public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers) => default; // 0x00A0F8D0-0x00A0F990
		private static extern Result ListAllUsers(ref int pOutActualLength, out Uid[] outUsers, int arrayLength); // 0x00A0F990-0x00A0FA60
		public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers) => default; // 0x00A0FA60-0x00A0FB20
		private static extern Result ListOpenUsers(ref int pOutActualLength, out Uid[] outUsers, int arrayLength); // 0x00A0FB20-0x00A0FBF0
		public static extern Result GetLastOpenedUser(ref Uid pOutUser); // 0x00A0FBF0-0x00A0FC10
		public static extern Result GetNickname(ref Nickname pOut, Uid user); // 0x00A0FC10-0x00A0FCE0
		public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user) => default; // 0x00A0FCE0-0x00A0FD10
		private static extern Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, long bufferSize, Uid user); // 0x00A0FD10-0x00A0FD40
		public static extern void Initialize(); // 0x00A0FD40-0x00A0FD50
		public static extern Result OpenUser(ref UserHandle pOutHandle, Uid user); // 0x00A0FD50-0x00A0FD70
		public static extern bool TryOpenPreselectedUser(ref UserHandle pOutHandle); // 0x00A0FD70-0x00A0FD90
		public static extern Result ListQualifiedUsers(ref int pOutActualLength, Uid[] outUsers, int arrayLength); // 0x00A0FD90-0x00A0FDC0
		public static extern void CloseUser(UserHandle handle); // 0x00A0FDC0-0x00A0FDF0
		public static extern Result GetUserId(ref Uid pOut, UserHandle handle); // 0x00A0FDF0-0x00A0FE30
		public static Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer) => default; // 0x00A0FE30-0x00A0FE60
		private static extern Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer, int imageBufferSize); // 0x00A0FE60-0x00A0FE90
		public static extern Result DeleteSaveDataThumbnailImage(Uid user); // 0x00A0FE90-0x00A0FEB0
		public static extern Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg); // 0x00A0FEE0-0x00A0FF20
		public static extern Result ShowUserSelector(ref Uid pOut); // 0x00A0FF20-0x00A0FF40
		public static extern Result ShowUserCreator(); // 0x00A0FF40-0x00A0FF60
		public static Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg, bool suspendUnityThreads) => default; // 0x00A0FF60-0x00A0FFF0
		public static Result ShowUserSelector(ref Uid pOut, bool suspendUnityThreads) => default; // 0x00A0FFF0-0x00A10050
		public static Result ShowUserCreator(bool suspendUnityThreads) => default; // 0x00A10050-0x00A100A0
	}
}
