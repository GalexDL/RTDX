/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace PegaUI
{
	// [AddComponentMenu] // 0x0060AEE0-0x0060AF20
	public class UiActionTween : MonoBehaviour, IUiAction, IEventSystemHandler // TypeDefIndex: 8345
	{
		// Fields
		public string TargetActionName; // 0x18
		public List<TweenParam> tweenParamList; // 0x20
	
		// Properties
		string IUiAction.TargetActionName { get => default; } // 0x0078BEF0-0x0078BF00 
	
		// Nested types
		public enum TweenType // TypeDefIndex: 8346
		{
			MoveTo = 0,
			AnchorPos = 1,
			LocalMoveTo = 2,
			AlphaTo = 3,
			RotateTo = 4,
			ScaleTo = 5
		}
	
		[Serializable]
		public class TweenParam // TypeDefIndex: 8347
		{
			// Fields
			public TweenType tweenType; // 0x10
			public Vector3 ValueV0; // 0x14
			public float ValueF0; // 0x20
			public float Time; // 0x24
			public float DelayTime; // 0x28
			public int enumValue0; // 0x2C
	
			// Constructors
			public TweenParam() {} // 0x0078C600-0x0078C610
		}
	
		// Constructors
		public UiActionTween() {} // 0x0078C560-0x0078C5D0
	
		// Methods
		public void On_UiActionCall(UnityAction endCallback) {} // 0x0078BF00-0x0078C550
	}
}
