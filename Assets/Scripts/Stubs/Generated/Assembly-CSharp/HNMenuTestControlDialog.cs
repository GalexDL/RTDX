/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A350-0x0060A360
public class HNMenuTestControlDialog : UIManagerBase // TypeDefIndex: 6394
{
	// Fields
	private UIPrefabLoader pl_; // 0x20
	private UISelectorManager menu_; // 0x28
	public FiniteStateMachine<HNMenuTestControlDialog, States> FSM; // 0x30

	// Events
	protected event CallbackAction actionCalled;

	// Nested types
	public enum States // TypeDefIndex: 6395
	{
		Init = 0,
		Run = 1,
		Close = 2,
		End = 3
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6396; 0x008EAE40-0x008EB1F0

	public enum ActionType // TypeDefIndex: 6397
	{
		Decide = 0,
		Cancel = 1
	}

	public class StateInit : FSMState<HNMenuTestControlDialog, States> // TypeDefIndex: 6398
	{
		// Properties
		public override States StateID { get => default; } // 0x008EB3B0-0x008EB3C0 

		// Constructors
		public StateInit() {} // 0x008EB3F0-0x008EB440

		// Methods
		public override void Enter() {} // 0x008EB3C0-0x008EB3D0
		public override void Execute() {} // 0x008EB3D0-0x008EB3E0
		public override void Exit() {} // 0x008EB3E0-0x008EB3F0
	}

	public class StateRun : FSMState<HNMenuTestControlDialog, States> // TypeDefIndex: 6399
	{
		// Properties
		public override States StateID { get => default; } // 0x008EB440-0x008EB450 

		// Constructors
		public StateRun() {} // 0x008EB480-0x008EB4D0

		// Methods
		public override void Enter() {} // 0x008EB450-0x008EB460
		public override void Execute() {} // 0x008EB460-0x008EB470
		public override void Exit() {} // 0x008EB470-0x008EB480
	}

	public class StateClose : FSMState<HNMenuTestControlDialog, States> // TypeDefIndex: 6400
	{
		// Properties
		public override States StateID { get => default; } // 0x008EB290-0x008EB2A0 

		// Constructors
		public StateClose() {} // 0x008EB2D0-0x008EB320

		// Methods
		public override void Enter() {} // 0x008EB2A0-0x008EB2B0
		public override void Execute() {} // 0x008EB2B0-0x008EB2C0
		public override void Exit() {} // 0x008EB2C0-0x008EB2D0
	}

	public class StateEnd : FSMState<HNMenuTestControlDialog, States> // TypeDefIndex: 6401
	{
		// Properties
		public override States StateID { get => default; } // 0x008EB320-0x008EB330 

		// Constructors
		public StateEnd() {} // 0x008EB360-0x008EB3B0

		// Methods
		public override void Enter() {} // 0x008EB330-0x008EB340
		public override void Execute() {} // 0x008EB340-0x008EB350
		public override void Exit() {} // 0x008EB350-0x008EB360
	}

	// Constructors
	public HNMenuTestControlDialog() {} // 0x0080BD00-0x0080BD10

	// Methods
	public void RegisterActionListener(CallbackAction cb) {} // 0x0080B240-0x0080B250
	public void UnregisterActionListener(CallbackAction cb) {} // 0x0080B250-0x0080B260
	public void callAction(ActionType action) {} // 0x0080B510-0x0080B530
	private void Start() {} // 0x0080B530-0x0080B810
	private void Update() {} // 0x0080B810-0x0080B860
	public void DoInitialize() {} // 0x0080B860-0x0080BAE0
	public void DoExecute() {} // 0x0080BAE0-0x0080BC40
	public void DoCloseEnter() {} // 0x0080BC40-0x0080BD00
	public bool IsSelectYes() => default; // 0x0080ACF0-0x0080AD30
}

