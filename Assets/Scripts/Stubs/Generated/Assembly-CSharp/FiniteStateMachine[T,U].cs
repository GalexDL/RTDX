/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FiniteStateMachine<T, U> // TypeDefIndex: 6229
{
	// Fields
	private T Owner; // 0x00
	private FSMState<T, U> PreviousState; // 0x00
	private FSMState<T, U> DelayState; // 0x00
	private Dictionary<U, FSMState<T, U>> stateRef; // 0x00

	// Properties
	public FSMState<T, U> CurrentState { get; private set; }

	// Constructors
	public FiniteStateMachine() {} // Dummy constructor
	public FiniteStateMachine(T owner) {}

	// Methods
	public void Awake() {}
	public void Update() {}
	protected void ChangeState(FSMState<T, U> NewState) {}
	public void ChangeState(U key) {}
	public void SetDelayState(U key) {}
	public void RevertToPreviousState() {}
	public FSMState<T, U> RegisterState(FSMState<T, U> state) => default;
	public void UnregisterState(FSMState<T, U> state) {}
}

