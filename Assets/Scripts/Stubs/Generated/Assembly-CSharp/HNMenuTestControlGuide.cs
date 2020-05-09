/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A360-0x0060A370
public class HNMenuTestControlGuide : UIManagerBase // TypeDefIndex: 6404
{
	// Fields
	private UIPrefabLoader pl_; // 0x20
	private UIControlText text_; // 0x28
	public FiniteStateMachine<HNMenuTestControlGuide, States> FSM; // 0x30

	// Nested types
	public enum States // TypeDefIndex: 6405
	{
		Init = 0,
		Run = 1,
		End = 2
	}

	public class StateInit : FSMState<HNMenuTestControlGuide, States> // TypeDefIndex: 6406
	{
		// Properties
		public override States StateID { get => default; } // 0x008EBA90-0x008EBAA0 

		// Constructors
		public StateInit() {} // 0x008EB6B0-0x008EB700

		// Methods
		public override void Enter() {} // 0x008EBAA0-0x008EBAB0
		public override void Execute() {} // 0x008EBAB0-0x008EBAC0
		public override void Exit() {} // 0x008EBAC0-0x008EBAD0
	}

	public class StateRun : FSMState<HNMenuTestControlGuide, States> // TypeDefIndex: 6407
	{
		// Properties
		public override States StateID { get => default; } // 0x008EBAD0-0x008EBAE0 

		// Constructors
		public StateRun() {} // 0x008EB700-0x008EB750

		// Methods
		public override void Enter() {} // 0x008EBAE0-0x008EBAF0
		public override void Execute() {} // 0x008EBAF0-0x008EBB00
		public override void Exit() {} // 0x008EBB00-0x008EBB10
	}

	public class StateEnd : FSMState<HNMenuTestControlGuide, States> // TypeDefIndex: 6408
	{
		// Properties
		public override States StateID { get => default; } // 0x008EBA50-0x008EBA60 

		// Constructors
		public StateEnd() {} // 0x008EB750-0x008EB7A0

		// Methods
		public override void Enter() {} // 0x008EBA60-0x008EBA70
		public override void Execute() {} // 0x008EBA70-0x008EBA80
		public override void Exit() {} // 0x008EBA80-0x008EBA90
	}

	// Constructors
	public HNMenuTestControlGuide() {} // 0x008EBA40-0x008EBA50

	// Methods
	private void Start() {} // 0x008EB4D0-0x008EB6B0
	private void Update() {} // 0x008EB7A0-0x008EB7F0
	public void DoInitialize() {} // 0x008EB7F0-0x008EB980
	public void DoExecute() {} // 0x008EBA30-0x008EBA40
	public void SetText(string contents) {} // 0x008EB980-0x008EBA30
}

