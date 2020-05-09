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

namespace SpecialAnim
{
	public class Anim<T> // TypeDefIndex: 8354
	{
		// Fields
		private T NoneState; // 0x00
		private T viewState_; // 0x00
		private T targetViewState_; // 0x00
		private GameObject obj_; // 0x00
		private string actionName_; // 0x00
		private int nAnim_; // 0x00
	
		// Properties
		public T NowViewState { get => default; set {} }
		public T TargetViewState { get => default; }
	
		// Constructors
		public Anim() {} // Dummy constructor
		public Anim(GameObject obj, T noneState) {}
	
		// Methods
		public void SetData(T state, string actionName) {}
		private void _cbAnime(UIAnimationBase.ActionType act) {}
		// [IteratorStateMachine] // 0x0063B7A0-0x0063B810
		public IEnumerator PlayAnim(Action cb = null) => default;
		public void SkipAnim() {}
		// [IteratorStateMachine] // 0x0063B810-0x0063B880
		public IEnumerator PlayAnim_Continuous(Action cb = null) => default;
	}
}
