/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening
{
	public static class TweenSettingsExtensions // TypeDefIndex: 3575
	{
		// Extension methods
		public static T SetTarget<T>(this T t, object target)
			where T : Tween => default;
		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
			where T : Tween => default;
		public static T OnComplete<T>(this T t, TweenCallback action)
			where T : Tween => default;
		public static Sequence Append(this Sequence s, Tween t) => default; // 0x004D8980-0x004D89D0
		public static Sequence Join(this Sequence s, Tween t) => default; // 0x004D89D0-0x004D8A20
		public static Sequence Insert(this Sequence s, float atPosition, Tween t) => default; // 0x004D8A20-0x004D8A60
		public static Sequence PrependInterval(this Sequence s, float interval) => default; // 0x004D8A60-0x004D8B40
		public static T SetDelay<T>(this T t, float delay)
			where T : Tween => default;
		public static T SetRelative<T>(this T t)
			where T : Tween => default;
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) => default; // 0x004D8B40-0x004D8B60
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) => default; // 0x004D7B80-0x004D7BA0
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0060FA31 */) => default; // 0x004D7D90-0x004D7DB0
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly) => default; // 0x004CDEC0-0x004CDEE0
	}
}
