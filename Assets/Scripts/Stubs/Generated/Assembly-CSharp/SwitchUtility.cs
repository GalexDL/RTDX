/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.account;
using UnityEngine;
using UnityEngine.Switch;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SwitchUtility // TypeDefIndex: 5566
{
	// Fields
	private static int cpuBoostRefCount; // 0x00
	public static bool HomeMenuOrApplet; // 0x04
	private static ulong sleepStartTime; // 0x08

	// Nested types
	public class FriendOption // TypeDefIndex: 5567
	{
		// Fields
		public bool bFavoriteOnly; // 0x10

		// Constructors
		public FriendOption() {} // 0x0091AC00-0x0091AC10

		// Methods
		public uint ConvertFlags() => default; // 0x0091A470-0x0091A480
	}

	public class FriendParameter // TypeDefIndex: 5568
	{
		// Fields
		public ulong AccountId; // 0x10
		public bool Favorite; // 0x18
		public bool Newly; // 0x19

		// Constructors
		public FriendParameter() {} // 0x0091A480-0x0091A490
	}

	// Constructors
	public SwitchUtility() {} // 0x0091ABE0-0x0091ABF0
	static SwitchUtility() {} // 0x0091ABF0-0x0091AC00

	// Methods
	public static List<FriendParameter> GetFriendParameterList(UserHandle handle, FriendOption option) => default; // 0x0091A280-0x0091A470
	public static List<ulong> GetFriendList(UserHandle handle, FriendOption option) => default; // 0x0091A490-0x0091A630
	public static void BeginCpuBoost() {} // 0x0091A630-0x0091A710
	public static void EndCpuBoost() {} // 0x0091A710-0x0091A7F0
	public static void SetUserInactivityDetectionTimeExtended(bool bEnable) {} // 0x00912510-0x00912580
	public static void EnterExitRequestHandlingSection() {} // 0x0091A7F0-0x0091A870
	private static void NotificationMessageReceived(Notification.Message message) {} // 0x0091A870-0x0091AAE0
	[RuntimeInitializeOnLoadMethod] // 0x00620F90-0x00620FA0
	private static void OnRuntimeMethodLoad() {} // 0x0091AAE0-0x0091ABE0
}

