/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonEnterMenu // TypeDefIndex: 7968
{
	// Fields
	public string scenarioDgOrganizationSymbol; // 0x10
	private Index enterDungeon_; // 0x18
	private int enterPresetIndex_; // 0x1C

	// Nested types
	public enum ResultType // TypeDefIndex: 7969
	{
		None = 0,
		Cancel = 1,
		Dungeon = 2
	}

	// Constructors
	public DungeonEnterMenu() {} // 0x007CDBF0-0x007CDC50

	// Methods
	public Index GetEnterDungeon() => default; // 0x007CDA10-0x007CDA20
	public int GetEnterPreset() => default; // 0x007CDA20-0x007CDA30
	// [IteratorStateMachine] // 0x0062FA10-0x0062FA80
	private IEnumerator _noticeMessage(TextId textId, Action cb = null) => default; // 0x007CDA30-0x007CDAB0
	// [IteratorStateMachine] // 0x0062FA80-0x0062FAF0
	private IEnumerator _askMessage(TextId textId, MessageWindow.AskParam askParam, int presetPosition = 0 /* Metadata: 0x00613BEF */, Action<int> cb = null) => default; // 0x007CDAB0-0x007CDB40
	// [IteratorStateMachine] // 0x0062FAF0-0x0062FB60
	public IEnumerator MainFlow(Action<ResultType> cb = null) => default; // 0x007CDB40-0x007CDBC0
}

