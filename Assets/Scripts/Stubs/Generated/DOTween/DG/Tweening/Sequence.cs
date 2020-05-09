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
using DG.Tweening.Core.Enums;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening
{
	public sealed class Sequence : Tween // TypeDefIndex: 3566
	{
		// Fields
		internal readonly List<Tween> sequencedTweens; // 0x108
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x110
		internal float lastTweenInsertTime; // 0x118
	
		// Constructors
		internal Sequence() {} // 0x004CB1B0-0x004CB270
	
		// Methods
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) => default; // 0x004D6B20-0x004D6C90
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval) => default; // 0x004D6C90-0x004D6D50
		internal override void Reset() {} // 0x004D6D50-0x004D6E30
		internal override bool Startup() => default; // 0x004D6EB0-0x004D6EC0
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) => default; // 0x004D7090-0x004D70A0
		internal static void Setup(Sequence s) {} // 0x004CE040-0x004CE160
		internal static bool DoStartup(Sequence s) => default; // 0x004D6EC0-0x004D7090
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) => default; // 0x004D70A0-0x004D73B0
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x0060FA28 */) => default; // 0x004D73B0-0x004D7990
		private static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b) => default; // 0x004D7990-0x004D79B0
	}
}
