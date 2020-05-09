/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Core
{
	internal static class TweenManager // TypeDefIndex: 3625
	{
		// Fields
		internal static int maxActive; // 0x00
		internal static int maxTweeners; // 0x04
		internal static int maxSequences; // 0x08
		internal static bool hasActiveTweens; // 0x0C
		internal static bool hasActiveDefaultTweens; // 0x0D
		internal static bool hasActiveLateTweens; // 0x0E
		internal static bool hasActiveFixedTweens; // 0x0F
		internal static int totActiveTweens; // 0x10
		internal static int totActiveDefaultTweens; // 0x14
		internal static int totActiveLateTweens; // 0x18
		internal static int totActiveFixedTweens; // 0x1C
		internal static int totActiveTweeners; // 0x20
		internal static int totActiveSequences; // 0x24
		internal static int totPooledTweeners; // 0x28
		internal static int totPooledSequences; // 0x2C
		internal static int totTweeners; // 0x30
		internal static int totSequences; // 0x34
		internal static bool isUpdateLoop; // 0x38
		internal static Tween[] _activeTweens; // 0x40
		private static Tween[] _pooledTweeners; // 0x48
		private static readonly Stack<Tween> _PooledSequences; // 0x50
		private static readonly List<Tween> _KillList; // 0x58
		private static int _maxActiveLookupId; // 0x60
		private static bool _requiresActiveReorganization; // 0x64
		private static int _reorganizeFromId; // 0x68
		private static int _minPooledTweenerId; // 0x6C
		private static int _maxPooledTweenerId; // 0x70
		private static bool _despawnAllCalledFromUpdateLoopCallback; // 0x74
	
		// Nested types
		internal enum CapacityIncreaseMode // TypeDefIndex: 3626
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager() {} // 0x004CCB50-0x004CCC90
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
		internal static Sequence GetSequence() => default; // 0x004CA8A0-0x004CAC40
		internal static void AddActiveTweenToSequence(Tween t) {} // 0x004CB270-0x004CB2F0
		internal static void Despawn(Tween t, bool modifyActiveLists = true /* Metadata: 0x0060FA75 */) {} // 0x004CB7D0-0x004CBE90
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) {} // 0x004C7CF0-0x004C7DE0
		internal static void Update(UpdateType updateType, float deltaTime, float independentTime) {} // 0x004C6BE0-0x004C7080
		internal static void ForceInit(Tween t, bool isSequenced = false /* Metadata: 0x0060FA76 */) {} // 0x004CC940-0x004CCA20
		internal static bool Goto(Tween t, float to, bool andPlay = false /* Metadata: 0x0060FA77 */, UpdateMode updateMode = UpdateMode.Goto /* Metadata: 0x0060FA78 */) => default; // 0x004CCA20-0x004CCB50
		private static void MarkForKilling(Tween t) {} // 0x004CC4F0-0x004CC570
		private static void AddActiveTween(Tween t) {} // 0x004CAC40-0x004CAF30
		private static void ReorganizeActiveTweens() {} // 0x004CC1F0-0x004CC4F0
		private static void DespawnActiveTweens(List<Tween> tweens) {} // 0x004CC870-0x004CC940
		private static void RemoveActiveTween(Tween t) {} // 0x004CB2F0-0x004CB7D0
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode) {} // 0x004CAF30-0x004CB1B0
	}
}
