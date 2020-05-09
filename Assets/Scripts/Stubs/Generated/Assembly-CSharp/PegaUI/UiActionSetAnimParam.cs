/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace PegaUI
{
	// [AddComponentMenu] // 0x0060AEA0-0x0060AEE0
	public class UiActionSetAnimParam : MonoBehaviour, IUiAction, IEventSystemHandler // TypeDefIndex: 8343
	{
		// Fields
		public string TargetActionName; // 0x18
		public string ParamaterName; // 0x20
		public ActionType Action; // 0x28
		public float valueFloat; // 0x2C
		public int valueInt; // 0x30
		public bool valueBool; // 0x34
	
		// Properties
		string IUiAction.TargetActionName { get => default; } // 0x0078BD80-0x0078BD90 
	
		// Nested types
		public enum ActionType // TypeDefIndex: 8344
		{
			SetFloat = 0,
			SetInt = 1,
			SetBool = 2,
			SetTrigger = 3
		}
	
		// Constructors
		public UiActionSetAnimParam() {} // 0x0078BEE0-0x0078BEF0
	
		// Methods
		public void On_UiActionCall(UnityAction endCallback) {} // 0x0078BD90-0x0078BEE0
	}
}
