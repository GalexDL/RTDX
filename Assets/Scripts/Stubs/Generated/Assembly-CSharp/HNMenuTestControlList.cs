/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A370-0x0060A380
public class HNMenuTestControlList : UIManagerBase // TypeDefIndex: 6409
{
	// Fields
	private UIPrefabLoader pl_; // 0x20
	private UIBasicList list_; // 0x28
	private UISelectorManager menu_; // 0x30
	private static string[] itemTable_; // 0x00
	public FiniteStateMachine<HNMenuTestControlList, States> FSM; // 0x38

	// Events
	protected event CallbackAction actionCalled;

	// Nested types
	public enum States // TypeDefIndex: 6410
	{
		Init = 0,
		Run = 1,
		End = 2
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6411; 0x008EBD60-0x008EC110

	public enum ActionType // TypeDefIndex: 6412
	{
		Decide = 0,
		Cancel = 1,
		Focus = 2
	}

	public class StateInit : FSMState<HNMenuTestControlList, States> // TypeDefIndex: 6413
	{
		// Properties
		public override States StateID { get => default; } // 0x008EDB40-0x008EDB50 

		// Constructors
		public StateInit() {} // 0x008EC300-0x008EC350

		// Methods
		public override void Enter() {} // 0x008EDB50-0x008EDB60
		public override void Execute() {} // 0x008EDB60-0x008EDB70
		public override void Exit() {} // 0x008EDB70-0x008EDB80
	}

	public class StateRun : FSMState<HNMenuTestControlList, States> // TypeDefIndex: 6414
	{
		// Properties
		public override States StateID { get => default; } // 0x008EDB80-0x008EDB90 

		// Constructors
		public StateRun() {} // 0x008EC350-0x008EC3A0

		// Methods
		public override void Enter() {} // 0x008EDB90-0x008EDBA0
		public override void Execute() {} // 0x008EDBA0-0x008EDBB0
		public override void Exit() {} // 0x008EDBB0-0x008EDBC0
	}

	public class StateEnd : FSMState<HNMenuTestControlList, States> // TypeDefIndex: 6415
	{
		// Properties
		public override States StateID { get => default; } // 0x008EDB00-0x008EDB10 

		// Constructors
		public StateEnd() {} // 0x008EC3A0-0x008EC3F0

		// Methods
		public override void Enter() {} // 0x008EDB10-0x008EDB20
		public override void Execute() {} // 0x008EDB20-0x008EDB30
		public override void Exit() {} // 0x008EDB30-0x008EDB40
	}

	public class UILocalSelector : UISelectorBase // TypeDefIndex: 6416
	{
		// Constructors
		public UILocalSelector() {} // 0x008ECA70-0x008ECAE0

		// Methods
		protected override void SetupFace() {} // 0x008EDBC0-0x008EDD70
	}

	// Constructors
	public HNMenuTestControlList() {} // 0x008ED210-0x008ED220
	static HNMenuTestControlList() {} // 0x008ED220-0x008EDA50

	// Methods
	public void RegisterActionListener(CallbackAction cb) {} // 0x008EBD30-0x008EBD40
	public void UnregisterActionListener(CallbackAction cb) {} // 0x008EBD40-0x008EBD50
	public void callAction(ActionType action) {} // 0x008EBD50-0x008EBD60
	private void Start() {} // 0x008EC110-0x008EC300
	private void Update() {} // 0x008EC3F0-0x008EC450
	public void DoInitialize() {} // 0x008EC450-0x008ECA70
	public void DoExecute() {} // 0x008ECAE0-0x008ECF40
	public int GetFocusIndex() => default; // 0x008ECF60-0x008ECFC0
	public int GetSelectIndex() => default; // 0x008ECFC0-0x008ED100
	public void Continue() {} // 0x008ED100-0x008ED210
}

