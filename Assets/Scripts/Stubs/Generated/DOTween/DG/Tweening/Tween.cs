/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening
{
	public abstract class Tween : ABSSequentiable // TypeDefIndex: 3577
	{
		// Fields
		public float timeScale; // 0x28
		public bool isBackwards; // 0x2C
		public object id; // 0x30
		public object target; // 0x38
		internal UpdateType updateType; // 0x40
		internal bool isIndependentUpdate; // 0x44
		internal TweenCallback onPlay; // 0x48
		internal TweenCallback onPause; // 0x50
		internal TweenCallback onRewind; // 0x58
		internal TweenCallback onUpdate; // 0x60
		internal TweenCallback onStepComplete; // 0x68
		internal TweenCallback onComplete; // 0x70
		internal TweenCallback onKill; // 0x78
		internal TweenCallback<int> onWaypointChange; // 0x80
		internal bool isFrom; // 0x88
		internal bool isBlendable; // 0x89
		internal bool isRecyclable; // 0x8A
		internal bool isSpeedBased; // 0x8B
		internal bool autoKill; // 0x8C
		internal float duration; // 0x90
		internal int loops; // 0x94
		internal LoopType loopType; // 0x98
		internal float delay; // 0x9C
		internal bool isRelative; // 0xA0
		internal Ease easeType; // 0xA4
		internal EaseFunction customEase; // 0xA8
		public float easeOvershootOrAmplitude; // 0xB0
		public float easePeriod; // 0xB4
		internal Type typeofT1; // 0xB8
		internal Type typeofT2; // 0xC0
		internal Type typeofTPlugOptions; // 0xC8
		internal bool active; // 0xD0
		internal bool isSequenced; // 0xD1
		internal Sequence sequenceParent; // 0xD8
		internal int activeId; // 0xE0
		internal SpecialStartupMode specialStartupMode; // 0xE4
		internal bool creationLocked; // 0xE8
		internal bool startupDone; // 0xE9
		internal bool playedOnce; // 0xEA
		internal float position; // 0xEC
		internal float fullDuration; // 0xF0
		internal int completedLoops; // 0xF4
		internal bool isPlaying; // 0xF8
		internal bool isComplete; // 0xF9
		internal float elapsedDelay; // 0xFC
		internal bool delayComplete; // 0x100
		internal int miscInt; // 0x104
	
		// Constructors
		protected Tween() {} // 0x004D6B00-0x004D6B20
	
		// Methods
		internal virtual void Reset() {} // 0x004D6E30-0x004D6EB0
		internal virtual float UpdateDelay(float elapsed) => default; // 0x004D87C0-0x004D87E0
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) => default; // 0x004CC570-0x004CC870
		internal static bool OnTweenCallback(TweenCallback callback) => default; // 0x004CBE90-0x004CC1F0
	}
}
