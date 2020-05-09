/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.creature;
using Const.dungeon;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TagSet // TypeDefIndex: 5569
{
	// Fields
	private static int nestCount; // 0x00

	// Nested types
	public class Scope : IDisposable // TypeDefIndex: 5570
	{
		// Constructors
		public Scope() {} // 0x0091E5E0-0x0091E660

		// Methods
		public void Dispose() {} // 0x0091E660-0x0091E6D0
	}

	// Constructors
	public TagSet() {} // 0x0091E5C0-0x0091E5D0
	static TagSet() {} // 0x0091E5D0-0x0091E5E0

	// Methods
	public static void Begin() {} // 0x0091C850-0x0091C950
	public static void End() {} // 0x0091C950-0x0091CA60
	public static TextId EndAndReplace(TextId textId) => default; // 0x0091CA60-0x0091CAE0
	public static TextId ReplaceTagText(TextId textId) => default; // 0x0091CAE0-0x0091CBB0
	public static TextId ReplaceTagText(string srcText) => default; // 0x0091CC30-0x0091CD40
	private static void CheckScope_() {} // 0x0091CE80-0x0091CF40
	public static void SetCreatureName(int bufferId, string str) {} // 0x0091CF40-0x0091D080
	public static void SetCreatureName(int bufferId, Const.creature.Index index) {} // 0x0091D080-0x0091D1C0
	public static void SetItemName(int bufferId, string str, string strPlural, Const.item.Index strBaseItemIndex) {} // 0x0091D1C0-0x0091D310
	public static void SetItemName(int bufferId, IItem item) {} // 0x0091D310-0x0091D5E0
	public static void SetItemNameNoCount(int bufferId, Const.item.Index index) {} // 0x0091D5E0-0x0091D750
	public static void SetItemNameNoCountMoneyPoke(int bufferId, Const.item.Index index) {} // 0x0091D750-0x0091D8C0
	public static void SetCampName(int bufferId, Const.camp.Index index) {} // 0x0091D8C0-0x0091DAA0
	public static void SetString(int bufferId, string str) {} // 0x0091DB80-0x0091DCC0
	public static void SetValue(int bufferId, int value) {} // 0x0091DCC0-0x0091DE00
	public static void SetMoney(int bufferId, int value) {} // 0x0091DE00-0x0091DF40
	public static void SetMoneyNi(int bufferId, int value) {} // 0x0091DF40-0x0091E080
	public static void SetDungeonIndex(int bufferId, Const.dungeon.Index dungeonIndex, DungeonNameType nameType = DungeonNameType.FULL_KANJI_RUBY /* Metadata: 0x00611C5B */) {} // 0x0091E080-0x0091E1D0
	public static void SetDungeonIndexFromFloor(int bufferId, Const.dungeon.Index dungeonIndex, int floor, DungeonNameType nameType = DungeonNameType.FULL_KANJI_RUBY /* Metadata: 0x00611C5F */) {} // 0x0091E1D0-0x0091E320
	public static void SetFloor(int bufferId, int value, Const.dungeon.Index dungeonIndex) {} // 0x0091E320-0x0091E470
	public static void SetFloorWithoutColor(int bufferId, int value, Const.dungeon.Index dungeonIndex) {} // 0x0091E470-0x0091E5C0
}

