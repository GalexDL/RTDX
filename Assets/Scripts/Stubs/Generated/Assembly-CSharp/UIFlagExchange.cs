/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIFlagExchange : UIManagerBase // TypeDefIndex: 6900
{
	// Fields
	private bool bCancel_; // 0x1C
	private GameObject mainObj_; // 0x20
	private ScenarioManager.TeamFlagIndex nowFlagIndex_; // 0x28
	private UIMainMenu.ActionType act_; // 0x2C
	private FlagMenu flagMenu_; // 0x30
	public FiniteStateMachine<UIFlagExchange, States> FSM; // 0x38

	// Nested types
	public enum ResultType // TypeDefIndex: 6901
	{
		NONE = 0,
		DECIDE = 1,
		CANCEL = 2
	}

	public class Result // TypeDefIndex: 6902
	{
		// Fields
		public ResultType resultType; // 0x10
		public ScenarioManager.TeamFlagIndex flagIndex; // 0x14

		// Constructors
		public Result() {} // 0x00A788F0-0x00A78900
	}

	public class FlagMenu : UIMainMenu.GridMainMenuWindow // TypeDefIndex: 6903
	{
		// Fields
		private static string[] aItemToken; // 0x00

		// Nested types
		public class MenuParam // TypeDefIndex: 6904
		{
			// Fields
			public ScenarioManager.TeamFlagIndex flagIndex; // 0x10
			public bool bDisable; // 0x14
			public bool bEnable; // 0x15

			// Constructors
			public MenuParam() {} // 0x00A788C0-0x00A788F0
		}

		// Constructors
		public FlagMenu() {} // 0x00A780F0-0x00A78160
		static FlagMenu() {} // 0x00A78160-0x00A78840

		// Methods
		protected override bool _doYButton() => default; // 0x00A777F0-0x00A77800
		protected override bool _cancel() => default; // 0x00A77800-0x00A77810
		public void Init(GameObject root, UIFlagExchange manager, List<MenuParam> aMenuParam, int defaultIndex) {} // 0x00A77810-0x00A77E90
		protected override void _setMenuFaceRotation(UISelectorBase sel) {} // 0x00A77E90-0x00A780E0
	}

	public enum States // TypeDefIndex: 6906
	{
		FlagSelect = 0,
		End = 1
	}

	public class StateFlagSelect : FSMState<UIFlagExchange, States> // TypeDefIndex: 6907
	{
		// Properties
		public override States StateID { get => default; } // 0x00A78990-0x00A789A0 

		// Constructors
		public StateFlagSelect() {} // 0x00A78AC0-0x00A78B10

		// Methods
		public override void Enter() {} // 0x00A789A0-0x00A78A90
		public override void Execute() {} // 0x00A78A90-0x00A78AB0
		public override void Exit() {} // 0x00A78AB0-0x00A78AC0
	}

	public class StateEnd : FSMState<UIFlagExchange, States> // TypeDefIndex: 6908
	{
		// Properties
		public override States StateID { get => default; } // 0x00A78900-0x00A78910 

		// Constructors
		public StateEnd() {} // 0x00A78940-0x00A78990

		// Methods
		public override void Enter() {} // 0x00A78910-0x00A78920
		public override void Execute() {} // 0x00A78920-0x00A78930
		public override void Exit() {} // 0x00A78930-0x00A78940
	}

	// Constructors
	public UIFlagExchange() {} // 0x00D784F0-0x00D78500

	// Methods
	public static UIFlagExchange Create(ScenarioManager.TeamFlagIndex nowFlagIndex) => default; // 0x00D77940-0x00D77A70
	public void Init(ScenarioManager.TeamFlagIndex nowFlagIndex) {} // 0x00D77B70-0x00D78050
	// [IteratorStateMachine] // 0x006289A0-0x00628A10
	private IEnumerator Message(Action yes, Action no) => default; // 0x00D78050-0x00D780D0
	private string GetMessage(string label, string csvFileName) => default; // 0x00D780D0-0x00D781B0
	public void _cbFromGridMenu(ListWindowBase.ActionType act) {} // 0x00D781B0-0x00D78340
	public void Construct() {} // 0x00D77A70-0x00D77B70
	// [IteratorStateMachine] // 0x00628A10-0x00628A80
	public IEnumerator MainFlow(Action<Result> resultCb) => default; // 0x00D78340-0x00D783C0
	// [IteratorStateMachine] // 0x00628A80-0x00628AF0
	public override IEnumerator MainFlow() => default; // 0x00D783F0-0x00D78460
	private void Update() {} // 0x00D78490-0x00D784F0
}

