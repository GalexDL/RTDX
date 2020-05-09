/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SimpleGeneralMenu : SimpleMenuBase // TypeDefIndex: 8020
{
	// Fields
	public List<SimpleMenuBase> items; // 0x20
	public Func<List<SimpleMenuBase>> itemsGen; // 0x28
	public Func<MenuResult> actionFn; // 0x30
	public Func<Action<MenuResult>, IEnumerator> actionCo; // 0x38
	public int startCursorIdx; // 0x40

	// Nested types
	public class Param // TypeDefIndex: 8021
	{
		// Fields
		public TextId textId; // 0x10
		public Func<TextId> textFunc; // 0x18
		public List<SimpleMenuBase> items; // 0x20
		public Func<List<SimpleMenuBase>> itemsGen; // 0x28
		public Func<SimpleMenuBase.MenuResult> actionFn; // 0x30
		public Func<Action<SimpleMenuBase.MenuResult>, IEnumerator> actionCo; // 0x38
		public int startCursorIdx; // 0x40

		// Constructors
		public Param() {} // 0x009E6D60-0x009E6D70
	}

	// Constructors
	public SimpleGeneralMenu() {} // 0x009E5E10-0x009E5E80
	public SimpleGeneralMenu(TextId text, List<SimpleMenuBase> items) {} // 0x009E5EF0-0x009E5F80
	public SimpleGeneralMenu(TextId text, Func<List<SimpleMenuBase>> itemsGen) {} // 0x009E5F80-0x009E6040
	public SimpleGeneralMenu(TextId text, Func<MenuResult> actionFn) {} // 0x009E6040-0x009E60D0
	public SimpleGeneralMenu(TextId text, Func<Action<MenuResult>, IEnumerator> actionCo) {} // 0x009E60D0-0x009E6160
	public SimpleGeneralMenu(Func<TextId> textFunc, List<SimpleMenuBase> items) {} // 0x009E6160-0x009E61E0
	public SimpleGeneralMenu(Func<TextId> textFunc, Func<List<SimpleMenuBase>> itemsGen) {} // 0x009E61E0-0x009E62A0
	public SimpleGeneralMenu(Func<TextId> textFunc, Func<MenuResult> actionFn) {} // 0x009E62A0-0x009E6330
	public SimpleGeneralMenu(Func<TextId> textFunc, Func<Action<MenuResult>, IEnumerator> actionCo) {} // 0x009E6330-0x009E63C0
	public SimpleGeneralMenu(Param param) {} // 0x009E63C0-0x009E6470

	// Methods
	// [IteratorStateMachine] // 0x00630180-0x006301F0
	public override IEnumerator MenuFlow(Action<MenuResult> resultCb) => default; // 0x009E6470-0x009E64F0
}

