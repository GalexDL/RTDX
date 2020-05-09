/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Core
{
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 3627
		where TPlugOptions : struct, IPlugOptions
	{
		// Fields
		public T2 startValue; // 0x00
		public T2 endValue; // 0x00
		public T2 changeValue; // 0x00
		public TPlugOptions plugOptions; // 0x00
		public DOGetter<T1> getter; // 0x00
		public DOSetter<T1> setter; // 0x00
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin; // 0x00
	
		// Constructors
		internal TweenerCore() {}
	
		// Methods
		internal sealed override void Reset() {}
		internal override float UpdateDelay(float elapsed) => default;
		internal override bool Startup() => default;
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) => default;
	}
}
