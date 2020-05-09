/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.creature;
using Const.dungeon;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TagSetLazyBuffer // TypeDefIndex: 5571
{
	// Fields
	private List<Action> lazyFuncList_; // 0x10
	private int nestCount; // 0x18

	// Constructors
	public TagSetLazyBuffer() {} // 0x0091F9A0-0x0091FA10

	// Methods
	public void Begin() {} // 0x0091E6D0-0x0091E770
	public void End() {} // 0x0091E770-0x0091E820
	public void ApplyLazyFuncToTagSet() {} // 0x0091E820-0x0091E930
	public TextId EndAndReplace(TextId textId) => default; // 0x0091E930-0x0091EA80
	public TextId ReplaceTagText(TextId textId) => default; // 0x0091EA80-0x0091EB10
	private void AddLazyFunc_(Action func) {} // 0x0091EB10-0x0091EBB0
	public void SetCreatureName(int bufferId, string str) {} // 0x0091EBB0-0x0091ECD0
	public void SetCreatureName(int bufferId, Const.creature.Index index) {} // 0x0091ECE0-0x0091EDF0
	public void SetItemName(int bufferId, string str, string strPlural, Const.item.Index strBaseItemIndex) {} // 0x0091EE00-0x0091EF30
	public void SetItemName(int bufferId, IItem item) {} // 0x0091EF40-0x0091F060
	public void SetItemName(int bufferId, Const.item.Index index) {} // 0x0091F070-0x0091F180
	public void SetCampName(int bufferId, Const.camp.Index index) {} // 0x0091F190-0x0091F2A0
	public void SetString(int bufferId, string str) {} // 0x0091F2B0-0x0091F3D0
	public void SetValue(int bufferId, int value) {} // 0x0091F3E0-0x0091F4F0
	public void SetMoney(int bufferId, int value) {} // 0x0091F500-0x0091F610
	public void SetMoneyNi(int bufferId, int value) {} // 0x0091F620-0x0091F730
	public void SetDungeonIndex(int bufferId, Const.dungeon.Index dungeonIndex, DungeonNameType nameType = DungeonNameType.FULL_KANJI_RUBY /* Metadata: 0x00611C63 */) {} // 0x0091F740-0x0091F860
	public void SetFloor(int bufferId, int value, Const.dungeon.Index dungeonIndex) {} // 0x0091F870-0x0091F990
}

