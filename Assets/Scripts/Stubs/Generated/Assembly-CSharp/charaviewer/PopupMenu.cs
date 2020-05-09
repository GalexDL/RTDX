/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class PopupMenu : MonoBehaviour // TypeDefIndex: 8480
	{
		// Fields
		[SerializeField] // 0x00617520-0x00617530
		private Vector2 positionClose; // 0x18
		[SerializeField] // 0x00617530-0x00617540
		private Vector2 positionOpen; // 0x20
		[SerializeField] // 0x00617540-0x00617550
		private float timeOfOpenAndClose; // 0x28
		[SerializeField] // 0x00617550-0x00617560
		private bool InitialState; // 0x2C
		private State nowState; // 0x30
		private float timerCounter; // 0x34
	
		// Properties
		public bool OpenState { get; set; } // 0x0074FE50-0x0074FE60 0x0074FE60-0x0074FE70
	
		// Nested types
		private enum State // TypeDefIndex: 8481
		{
			MOVE = 0,
			CLOSE = 1,
			OPEN = 2
		}
	
		// Constructors
		public PopupMenu() {} // 0x00750130-0x00750150
	
		// Methods
		private void Start() {} // 0x0074FE70-0x0074FF40
		private void Update() {} // 0x0074FF40-0x0074FF80
		private void StateClose() {} // 0x0074FF80-0x0074FF90
		private void StateOpen() {} // 0x0074FF90-0x0074FFB0
		private void StateMove() {} // 0x0074FFB0-0x00750100
		private float MoveFunction(float rate) => default; // 0x00750100-0x00750120
		public void TogglePopupState() {} // 0x00750120-0x00750130
	}
}
