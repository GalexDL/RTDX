/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Core
{
	// [AddComponentMenu] // 0x005F5A10-0x005F5A50
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 3616
	{
		// Fields
		public int inspectorUpdater; // 0x18
		private float _unscaledTime; // 0x1C
		private float _unscaledDeltaTime; // 0x20
		private bool _duplicateToDestroy; // 0x24
	
		// Constructors
		public DOTweenComponent() {} // 0x004C8410-0x004C8420
	
		// Methods
		private void Awake() {} // 0x004C6710-0x004C6740
		private void Start() {} // 0x004C6740-0x004C6830
		private void Update() {} // 0x004C6830-0x004C6BE0
		private void LateUpdate() {} // 0x004C7080-0x004C71E0
		private void FixedUpdate() {} // 0x004C71E0-0x004C73A0
		private void OnDrawGizmos() {} // 0x004C73A0-0x004C74C0
		private void OnDestroy() {} // 0x004C7830-0x004C7B70
		private void OnApplicationQuit() {} // 0x004C7C00-0x004C7C70
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) => default; // 0x004C7C70-0x004C7CF0
		internal IEnumerator WaitForCompletion(Tween t) => default; // 0x004C7DE0-0x004C7E50
		internal IEnumerator WaitForRewind(Tween t) => default; // 0x004C7E80-0x004C7EF0
		internal IEnumerator WaitForKill(Tween t) => default; // 0x004C7F20-0x004C7F90
		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops) => default; // 0x004C7FC0-0x004C8040
		internal IEnumerator WaitForPosition(Tween t, float position) => default; // 0x004C8070-0x004C80F0
		internal IEnumerator WaitForStart(Tween t) => default; // 0x004C8120-0x004C8190
		internal static void Create() {} // 0x004C81C0-0x004C82F0
		internal static void DestroyInstance() {} // 0x004C82F0-0x004C8410
	}
}
