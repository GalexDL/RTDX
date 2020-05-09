/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Plugins
{
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 3597
	{
		// Constructors
		public Vector3Plugin() {} // 0x004D5EE0-0x004D5F30
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x004D55B0-0x004D55C0
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) => default; // 0x004D55C0-0x004D55D0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x004D55D0-0x004D5690
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x004D5690-0x004D5800
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x004D5800-0x004D5840
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D5840-0x004D5EE0
	}
}
