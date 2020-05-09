/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemDatabase // TypeDefIndex: 5093
{
	// Nested types
	public struct RiseParameterStatus // TypeDefIndex: 5094
	{
		// Fields
		public GummyAndSweetsUpStatus target; // 0x10
		public int value; // 0x14
	}

	// Constructors
	public ItemDatabase() {} // 0x008FB140-0x008FB150

	// Methods
	public static int GetItemCategory(Const.item.Index itemIndex) => default; // 0x008FA450-0x008FA4C0
	public static int GetPrice(Const.item.Index index, PriceType priceType) => default; // 0x008FA4C0-0x008FA540
	public static int GetSortKey(Const.item.Index index) => default; // 0x008F75E0-0x008F7650
	public static string GetName(Const.item.Index index, bool bPural) => default; // 0x008FA540-0x008FA660
	public static bool IsEnableItem(Const.item.Index itemIndex) => default; // 0x008FA660-0x008FA6D0
	public static Kind GetKind(Const.item.Index itemIndex) => default; // 0x008FA6D0-0x008FA740
	public static bool IsNumberItem(Const.item.Index itemIndex) => default; // 0x008FA740-0x008FA7B0
	public static bool IsShootingKind(Const.item.Index itemIndex) => default; // 0x008FA7B0-0x008FA820
	public static List<Const.item.Index> GetEnableItemList(bool bIgnoreChest, bool bIgnoreMoney = true /* Metadata: 0x00610EEF */) => default; // 0x008FA820-0x008FAA60
	public static bool IsHighClassChest(Const.item.Index itemIndex) => default; // 0x008FA3D0-0x008FA440
	public static bool IsSecureItem(Const.item.Index itemIndex) => default; // 0x008FAA60-0x008FAAD0
	public static CommandType GetCommandType(Const.item.Index itemIndex) => default; // 0x008FAAD0-0x008FAB40
	public static Const.waza.Index GetLearningWazaIndex(Const.item.Index itemIndex) => default; // 0x008FAB40-0x008FABB0
	public static string GetThumbnailFileName(Const.item.Index itemIndex) => default; // 0x008FABB0-0x008FACF0
	public static string GetItemFileName(Const.item.Index itemIndex) => default; // 0x008FACF0-0x008FAE30
	public static Color GetColor(Const.item.Index itemIndex) => default; // 0x008FAE30-0x008FAFA0
	public static bool IsGummy(Const.item.Index index) => default; // 0x008FAFA0-0x008FAFB0
	public static List<RiseParameterStatus> GetRiseParameterStatus(Const.item.Index index) => default; // 0x008FAFB0-0x008FB130
	public static bool IsGATSUN(Const.item.Index index) => default; // 0x008FB130-0x008FB140
}

