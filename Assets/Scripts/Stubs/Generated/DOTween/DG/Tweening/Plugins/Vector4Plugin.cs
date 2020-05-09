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
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 3593
	{
		// Constructors
		public Vector4Plugin() {} // 0x004D6AB0-0x004D6B00
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x004D5F30-0x004D5F40
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) => default; // 0x004D5F40-0x004D5F50
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x004D5F50-0x004D6030
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x004D6030-0x004D61F0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) => default; // 0x004D61F0-0x004D6230
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) {} // 0x004D6230-0x004D6AB0
	}
}
