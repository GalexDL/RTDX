/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening
{
	public class DOTween // TypeDefIndex: 3559
	{
		// Fields
		public static readonly string Version; // 0x00
		public static bool useSafeMode; // 0x08
		public static bool showUnityEditorReport; // 0x09
		public static float timeScale; // 0x0C
		public static bool useSmoothDeltaTime; // 0x10
		public static float maxSmoothUnscaledTime; // 0x14
		private static LogBehaviour _logBehaviour; // 0x18
		public static bool drawGizmos; // 0x1C
		public static UpdateType defaultUpdateType; // 0x20
		public static bool defaultTimeScaleIndependent; // 0x24
		public static AutoPlay defaultAutoPlay; // 0x28
		public static bool defaultAutoKill; // 0x2C
		public static LoopType defaultLoopType; // 0x30
		public static bool defaultRecyclable; // 0x34
		public static Ease defaultEaseType; // 0x38
		public static float defaultEaseOvershootOrAmplitude; // 0x3C
		public static float defaultEasePeriod; // 0x40
		internal static DOTweenComponent instance; // 0x48
		internal static bool isUnityEditor; // 0x50
		internal static int maxActiveTweenersReached; // 0x54
		internal static int maxActiveSequencesReached; // 0x58
		internal static readonly List<TweenCallback> GizmosDelegates; // 0x60
		internal static bool initialized; // 0x68
		internal static bool isQuitting; // 0x69
	
		// Properties
		public static LogBehaviour logBehaviour { get => default; set {} } // 0x004CCC90-0x004CCD00 0x004CCD00-0x004CCDF0
	
		// Constructors
		public DOTween() {} // Dummy constructor
		static DOTween() {} // 0x004CCDF0-0x004CCF30
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default) => default; // 0x004CCF30-0x004CD0C0
		private static void AutoInit() {} // 0x004CDA40-0x004CDB10
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour) => default; // 0x004CD0C0-0x004CDA40
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) => default; // 0x004CDB10-0x004CDBB0
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) => default; // 0x004CDBB0-0x004CDC60
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) => default; // 0x004CDC60-0x004CDD20
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) => default; // 0x004CDD20-0x004CDDE0
		public static Tweener ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) => default; // 0x004CDDE0-0x004CDEC0
		public static Sequence Sequence() => default; // 0x004CDEE0-0x004CDF70
		private static void InitCheck() {} // 0x004CDF70-0x004CE040
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions => default;
	}
}
