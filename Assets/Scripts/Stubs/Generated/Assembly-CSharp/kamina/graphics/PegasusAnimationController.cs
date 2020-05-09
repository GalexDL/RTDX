/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina.graphics
{
	[ExecuteInEditMode] // 0x0060B170-0x0060B180
	public class PegasusAnimationController : MonoBehaviour // TypeDefIndex: 8396
	{
		// Fields
		private List<IAnimationCallback> m_animationCallbackLst; // 0x18
		private float m_fMotionScale; // 0x20
		private float m_fWalkScale; // 0x24
		private float m_fRunScale; // 0x28
		private AnimGrapch_ m_animGrapch; // 0x30
		private AnimationClipManage_ animationClipManage_; // 0x38
		protected Dictionary<string, PartsWork_> m_dicPartsWork; // 0x40
		protected bool m_bDelayWait; // 0x48
		protected bool m_bRequestWrapMode; // 0x49
		protected bool m_bFixedTimeMode; // 0x4A
		protected float m_fWrapSetSec; // 0x4C
		protected WrapMode m_requestWrapMode; // 0x50
		private AnimationControlForTimeline animationControlForTimeline_; // 0x58
		private Dictionary<string, float> motionSpeedScaleTable; // 0x60
	
		// Properties
		public bool IsTimelineMode { get => default; } // 0x00BA2750-0x00BA2760 
		public bool FixedTimeMode { get => default; set {} } // 0x00BA27E0-0x00BA27F0 0x00BA27D0-0x00BA27E0
	
		// Nested types
		private static class GCCache // TypeDefIndex: 8397
		{
			// Fields
			private static Stack<AnimationKey> animationKeyCache_; // 0x00
	
			// Constructors
			static GCCache() {} // 0x00A09340-0x00A093C0
	
			// Methods
			public static AnimationKey Create_AnimationKey() => default; // 0x00A091A0-0x00A09280
			public static void Free_AnimationKey(AnimationKey v) {} // 0x00A09280-0x00A09340
		}
	
		private class AnimGrapch_ // TypeDefIndex: 8398
		{
			// Fields
			public PlayableGraph m_graph; // 0x10
			public Animator m_target; // 0x20
			public bool m_bGraphCreated; // 0x28
			public AnimationPlayableOutput m_playableOutput; // 0x30
			public AnimationLayerMixerPlayable m_animationLayerMixerPlayable; // 0x40
			public Action<Playable, FrameData> m_preparaCallback; // 0x50
			public Dictionary<AnimationMixerPlayable, int> m_mixerPlayablePortTbl; // 0x58
			private List<AnimationMixerPlayable> m_animMixerPlayableLst; // 0x60
	
			// Constructors
			public AnimGrapch_() {} // 0x00A06E30-0x00A06ED0
	
			// Methods
			public void SetupSimple(Animator animator) {} // 0x00A065C0-0x00A06640
			public void Setup(PlayableGraph graph, Playable parentPlayable, Animator animator, bool bNeedCallCallback) {} // 0x00A06640-0x00A068B0
			public void ClearAll() {} // 0x00A068B0-0x00A06B00
			public void SetEnable(bool bEnable) {} // 0x00A06B10-0x00A06B90
			public AnimationMixerPlayable AddMixerPlayable() => default; // 0x00A06B90-0x00A06DB0
			public void SetMixerPlayable_OutputWeight(AnimationMixerPlayable mixerPlayable, float weight) {} // 0x00A06DB0-0x00A06E30
		}
	
		public class DirectControl_AnimationClipState // TypeDefIndex: 8399
		{
			// Fields
			public string key; // 0x10
			public float blendWeight; // 0x18
			public float time; // 0x1C
	
			// Constructors
			public DirectControl_AnimationClipState() {} // 0x00A09190-0x00A091A0
		}
	
		public class AnimationKey // TypeDefIndex: 8400
		{
			// Fields
			private string key_; // 0x10
			private uint hash_; // 0x18
			private string partSymbol_; // 0x20
			private string motionKey_; // 0x28
	
			// Properties
			public string key { get => default; } // 0x00A07780-0x00A077E0 
			public uint hash { get => default; } // 0x00A08980-0x00A08990 
			public string partSymbol { get => default; } // 0x00A08990-0x00A089F0 
			public string motionKey { get => default; } // 0x00A089F0-0x00A08A50 
	
			// Constructors
			public AnimationKey() {} // 0x00A07650-0x00A07660
			public AnimationKey(string partSymbol, string motionKey) {} // 0x00A08810-0x00A088D0
	
			// Methods
			public void SetKey(string partSymbol, string motionKey) {} // 0x00A088D0-0x00A08980
			public bool IsEmpty() => default; // 0x00A08A50-0x00A08A60
			public bool IsValid() => default; // 0x00A08A60-0x00A08A70
			public void Copy(AnimationKey animKey) {} // 0x00A08A70-0x00A08A90
			public void Clear() {} // 0x00A08A90-0x00A08AF0
			public override int GetHashCode() => default; // 0x00A08AF0-0x00A08B00
			public override bool Equals(object obj) => default; // 0x00A08B00-0x00A08C60
			public static bool operator ==(AnimationKey class1, AnimationKey class2) => default; // 0x00A08C60-0x00A08CD0
			public static bool operator !=(AnimationKey class1, AnimationKey class2) => default; // 0x00A08CD0-0x00A08D50
		}
	
		private class AnimationClipManage_ // TypeDefIndex: 8401
		{
			// Fields
			private Dictionary<AnimationKey, Data> m_animationClipTbl; // 0x10
	
			// Properties
			public Dictionary<AnimationKey, Data> AnimationClipTbl { get => default; } // 0x00A06FF0-0x00A07000 
	
			// Nested types
			public class Data // TypeDefIndex: 8402
			{
				// Fields
				public AnimationClip clip; // 0x10
				public Func<AnimationClip> clipLazyFunc; // 0x18
				public bool bCommonMotion; // 0x20
	
				// Constructors
				public Data() {} // Dummy constructor
				public Data(AnimationClip _clip, bool _bCommonMotion) {} // 0x00A07120-0x00A07160
				public Data(Func<AnimationClip> _clipLazyFunc, bool _bCommonMotion) {} // 0x00A07230-0x00A07270
	
				// Methods
				public void TryLoadLazy() {} // 0x00A073C0-0x00A07460
			}
	
			// Constructors
			public AnimationClipManage_() {} // 0x00A077E0-0x00A07850
	
			// Methods
			public void Clear() {} // 0x00A06FA0-0x00A06FF0
			public void Terminate() {} // 0x00A07000-0x00A07050
			public void RegistClip(AnimationKey animKey, AnimationClip animationClip, bool bCommonMotion) {} // 0x00A07050-0x00A07120
			public void RegistClip(AnimationKey animKey, Func<AnimationClip> animationClipLazyFunc, bool bCommonMotion) {} // 0x00A07160-0x00A07230
			public bool IsExistClip(AnimationKey animKey) => default; // 0x00A07270-0x00A072D0
			public AnimationClip FindClip(AnimationKey animKey) => default; // 0x00A072D0-0x00A073C0
			public AnimationKey GetAnimationClipHashKey(AnimationClip animationClip) => default; // 0x00A07460-0x00A07650
			public bool FindCommonMotion(AnimationKey animKey) => default; // 0x00A07660-0x00A07780
		}
	
		public class ClipWork // TypeDefIndex: 8403
		{
			// Fields
			private float speed_; // 0x10
			private float weight_; // 0x14
			public AnimationKey animationKey; // 0x18
			public bool bLoop; // 0x20
			public AnimationClipPlayable animationClipPlayable; // 0x28
			public AnimationMixerPlayable animationMixerPlayable; // 0x38
	
			// Properties
			public float Speed { get => default; set {} } // 0x00A08D50-0x00A08D60 0x00A08D60-0x00A08DD0
			public float Weight { get => default; set {} } // 0x00A08DD0-0x00A08DE0 0x00A087A0-0x00A08810
	
			// Constructors
			public ClipWork() {} // 0x00A09120-0x00A09190
	
			// Methods
			public void Stop() {} // 0x00A08DE0-0x00A08E50
			public void StopAndTimeZero() {} // 0x00A08E50-0x00A08F00
			public float GetNormalizeTime_() => default; // 0x00A08F50-0x00A08FE0
			public void SetNormalizeTime(float normalizeTime) {} // 0x00A08F00-0x00A08F50
			public float GetTime() => default; // 0x00A090C0-0x00A09120
			public void SetTime(float time) {} // 0x00A08FE0-0x00A090C0
		}
	
		private class PartsWorkSimple_ // TypeDefIndex: 8404
		{
			// Fields
			private PegasusAnimationController m_owner; // 0x10
			private AnimGrapch_ m_animGraph; // 0x18
			private AnimationMixerPlayable m_animationMixerPlayable; // 0x20
			private Dictionary<AnimationKey, Stack<AnimationClipPlayable>> m_animClipPlayableUnusedTbl_; // 0x30
			private List<ClipWork> clipWorkTbl_; // 0x38
			public string partsSymbol; // 0x40
	
			// Properties
			public List<ClipWork> ClipWorkTable { get => default; } // 0x00A07A10-0x00A07A20 
	
			// Constructors
			public PartsWorkSimple_() {} // Dummy constructor
			public PartsWorkSimple_(string _partsSymbol, AnimGrapch_ animGraph, PegasusAnimationController owner) {} // 0x00A07D00-0x00A07DE0
	
			// Methods
			public void SetEnable(bool bEnable) {} // 0x00A07DE0-0x00A07E60
			public ClipWork AddClip(string key) => default; // 0x00A07F60-0x00A08360
			public void RemoveClip(ClipWork work) {} // 0x00A08490-0x00A08570
			public void AllClear() {} // 0x00A093C0-0x00A09520
		}
	
		protected class PartsWork_ // TypeDefIndex: 8405
		{
			// Fields
			private PegasusAnimationController m_owner; // 0x10
			private AnimationMixerPlayable m_animationMixerPlayable; // 0x18
			public string partsSymbol; // 0x28
			private MotionState_ stateCurrent_; // 0x30
			private MotionState_ stateNext_; // 0x38
			private float carryOverSpeed_; // 0x40
			private bool carryOverSpeedRequest_; // 0x44
			public Action changeNextMotionCallback; // 0x48
			public AnimationClipPlayable currentClipPlayable; // 0x50
			private AnimationClipPlayable lastPlayClipPlayable_; // 0x60
			private bool bLastPlayClipPlayableCommonMotion_; // 0x70
			private float fCurrentMotionFixTimeModeStep; // 0x74
			public bool bCurrentEndFlag; // 0x78
			private AnimationClipPlayable blendClipPlayable_; // 0x80
			private float fBlendTimer_; // 0x90
			private float fBlendTimerLen_; // 0x94
			private bool bBlendClipPlayableCommonMotion_; // 0x98
			private Dictionary<uint, Stack<AnimationClipPlayable>> m_dicEntryClipPlayableUnuse; // 0xA0
	
			// Nested types
			public class MotionState_ // TypeDefIndex: 8406
			{
				// Fields
				private PartsWork_ partWork_; // 0x10
				public string motionKey; // 0x18
				public AnimationKey animationKey; // 0x20
				public float fMotionStartBlendSec; // 0x28
				public float fMotionSpeed; // 0x2C
				public bool bMotionLoop; // 0x30
				public bool bCommonMotion; // 0x31
	
				// Constructors
				public MotionState_() {} // Dummy constructor
				public MotionState_(PartsWork_ partWork) {} // 0x00A09700-0x00A097A0
	
				// Methods
				public void SetKey(string key) {} // 0x00A0B2B0-0x00A0B360
				public bool IsValid() => default; // 0x00A0A450-0x00A0A470
				public void Clear() {} // 0x00A0B370-0x00A0B410
			}
	
			// Constructors
			public PartsWork_() {} // Dummy constructor
			public PartsWork_(string _partsSymbol, PegasusAnimationController owner) {} // 0x00A09550-0x00A09700
	
			// Methods
			public void GetForNative(out string currentMotionKey, out string nextMotionKey, out bool bCurrentMotionLoop) {
				currentMotionKey = default;
				nextMotionKey = default;
				bCurrentMotionLoop = default;
			} // 0x00A09520-0x00A09550
			public void Terminate() {} // 0x00A097A0-0x00A097F0
			private void SetPartsAnimEnable_(bool bEnable) {} // 0x00A097F0-0x00A09920
			private AnimationClipPlayable CreateClipPlayable_(AnimationKey toAnimationKey) => default; // 0x00A09B30-0x00A09DE0
			private void MoveClipPlayable_(ref AnimationClipPlayable dstClip, ref AnimationClipPlayable srcClip) {} // 0x00A09DE0-0x00A09E10
			private void RemoveClipPlayable_(ref AnimationClipPlayable animClipPlayable) {} // 0x00A099D0-0x00A09B30
			private float GetNormalizeTime_(AnimationClipPlayable clipPlayable) => default; // 0x00A09EB0-0x00A09F40
			private void ClipPlayable_SetNormalizeTime_(AnimationClipPlayable clipPlayable, float normalizeTime) {} // 0x00A09F40-0x00A0A020
			private float GetClipPlayable_Time_(AnimationClipPlayable clipPlayable) => default; // 0x00A0A0D0-0x00A0A140
			private void SetClipPlayable_Time_(AnimationClipPlayable clipPlayable, float time) {} // 0x00A0A020-0x00A0A0D0
			private bool IsWalkMotion_(AnimationKey animationKey) => default; // 0x00A0A140-0x00A0A280
			private bool IsRunMotion_(AnimationKey animationKey) => default; // 0x00A0A280-0x00A0A3C0
			public void SetNextSpeedAnimation(float fSpeed) {} // 0x00A0A3C0-0x00A0A3D0
			public bool IsPlayAnimation(string key) => default; // 0x00A0A3D0-0x00A0A420
			public bool IsNextPlayAnimation(string key) => default; // 0x00A0A420-0x00A0A450
			public bool IsPlayAnimation() => default; // 0x00A0A470-0x00A0A480
			public bool GetCurrentAnimationKeyCommonMotionFlag() => default; // 0x00A0A480-0x00A0A490
			public void ChangeCurrentMotionLoop(bool bMotionLoop) {} // 0x00A0A490-0x00A0A750
			public void ChangeCurrentSpeedAnimation(float fSpeed) {} // 0x00A0A750-0x00A0AC40
			public float GetCurrentSpeedAnimation() => default; // 0x00A0AC40-0x00A0AC50
			public bool IsPause() => default; // 0x00A0AC50-0x00A0AC70
			public bool IsMotionValid() => default; // 0x00A0AC70-0x00A0AC90
			public void SetTime(float fTime) {} // 0x00A0AC90-0x00A0AD50
			public float GetTime() => default; // 0x00A0AD50-0x00A0ADD0
			public void SetNormalizeTime(float fNormalizeTime) {} // 0x00A0ADD0-0x00A0ADF0
			public void TryPreLoad(string key) {} // 0x00A0ADF0-0x00A0AF80
			public void SetCurrent(string key, float fBlendSec, bool bLoop, bool bCommonMotion) {} // 0x00A0AF80-0x00A0B2B0
			public void SetCurrentBlendSec(float fBlendSec) {} // 0x00A0B360-0x00A0B370
			public void ClearCurrent() {} // 0x00A09920-0x00A099D0
			public void SetNext(string key, float fBlendSec, bool bLoop, bool bCommonMotion, Action changeNextMotionCallback) {} // 0x00A0B410-0x00A0B520
			public void ClearNext() {} // 0x00A0B520-0x00A0B5D0
			public void StopAndDisalbe() {} // 0x00A0B5D0-0x00A0B670
			public void Stop() {} // 0x00A0B6F0-0x00A0B810
			private void ClipPlayable_Stop_(AnimationClipPlayable clipPlayable) {} // 0x00A0B670-0x00A0B6F0
			private void ClipPlayable_StopAndTimeZero_(AnimationClipPlayable clipPlayable) {} // 0x00A09E10-0x00A09EB0
			public void PlayCurrent() {} // 0x00A0B810-0x00A0BCD0
			public bool IsNowAnimationBlending() => default; // 0x00A0BCD0-0x00A0BD40
			public float CalcNowAnimationBlendRate() => default; // 0x00A0BD40-0x00A0BD50
			public bool GetNowBlendAnimationCommonMotionFlag() => default; // 0x00A0BD50-0x00A0BD60
			public void UpdateAnimation_(float deltaTime) {} // 0x00A0BD60-0x00A0BED0
			public void UpdateParts_() {} // 0x00A0BED0-0x00A0C400
		}
	
		public class AnimationControlForTimeline // TypeDefIndex: 8407
		{
			// Fields
			private PegasusAnimationController m_owner; // 0x10
			private AnimGrapch_ m_animGraph; // 0x18
			private Dictionary<string, PartsWorkSimple_> m_partsWorkTbl; // 0x20
			private Dictionary<string, List<ClipWork>> m_partsWorkLstTbl; // 0x28
	
			// Properties
			public Dictionary<string, List<ClipWork>> PartsClipWorkListTable { get => default; } // 0x00A07850-0x00A07860 
	
			// Constructors
			public AnimationControlForTimeline() {} // Dummy constructor
			public AnimationControlForTimeline(PlayableGraph graph, Playable parentPlayable, PegasusAnimationController owner) {} // 0x00A07A20-0x00A07BC0
	
			// Methods
			private void UpdatePartsClipWorkListTable_() {} // 0x00A07860-0x00A07A10
			public void AddParts(string parts) {} // 0x00A07BC0-0x00A07D00
			public void ClearAll() {} // 0x00A07E60-0x00A07EC0
			public ClipWork AddClip(string parts, string key) => default; // 0x00A07EC0-0x00A07F60
			public void RemoveClip(ClipWork work) {} // 0x00A08360-0x00A08490
			public void SetEnableGraph(bool bEnable) {} // 0x00A08570-0x00A085F0
			public void SetPartsWeightAllZero(string parts) {} // 0x00A085F0-0x00A087A0
		}
	
		// Constructors
		public PegasusAnimationController() {} // 0x00BA31C0-0x00BA32D0
	
		// Methods
		private void OnEnable() {} // 0x00BA2030-0x00BA2110
		private void OnDisable() {} // 0x00BA2110-0x00BA2120
		private void OnDestroy() {} // 0x00BA2120-0x00BA2130
		private void PreparaCallback_(Playable playable, FrameData framedata) {} // 0x00BA2130-0x00BA2250
		public void Terminate() {} // 0x00B9CE90-0x00B9D020
		public void CreateAnimationControlForTimeline(PlayableGraph graph, Playable parentPlayable) {} // 0x00BA2580-0x00BA2740
		public void DestoryAnimationControlForTimeline() {} // 0x00BA2250-0x00BA2580
		public AnimationControlForTimeline GetAnimationControlForTimeline() => default; // 0x00BA2740-0x00BA2750
		public void AddMotionSpeedScale(string key, float speed) {} // 0x00BA2760-0x00BA27D0
		public void AddParts(string parts) {} // 0x00B9BA80-0x00B9BB40
		public void RegistClip(string parts, string key, AnimationClip animationClip, bool bCommonMotion = false /* Metadata: 0x00614AF1 */) {} // 0x00B9DB30-0x00B9DC40
		public void RegistClip(string parts, string key, Func<AnimationClip> animationClipLazyFunc, bool bCommonMotion = false /* Metadata: 0x00614AF2 */) {} // 0x00B9DA20-0x00B9DB30
		public bool IsExistClip(string parts, string key) => default; // 0x00BA27F0-0x00BA2880
		public void Stop(string parts) {} // 0x00B9F000-0x00B9F070
		public void StopAndDisable(string parts) {} // 0x00BA2880-0x00BA28F0
		public void AddCallback(IAnimationCallback callback) {} // 0x00BA28F0-0x00BA2950
		public void RemoveCallback(IAnimationCallback callback) {} // 0x00BA2950-0x00BA29B0
		public void Play(string parts, string key, float fBlendSec, bool bLoop) {} // 0x00BA29B0-0x00BA2AA0
		public void PlayCurrent(string parts) {} // 0x00B9EB60-0x00B9EBD0
		public void ForcePlayCurrentAllParts() {} // 0x00B9ED90-0x00B9EF10
		public void SetCurrent(string parts, string key, float fBlendSec, bool bLoop) {} // 0x00B9DD20-0x00B9DDF0
		public void TryPreLoad(string parts, string key) {} // 0x00BA2AA0-0x00BA2B10
		public void ClearCurrent(string parts) {} // 0x00B9DEE0-0x00B9DF50
		public void ClearCurrentAll() {} // 0x00BA2B10-0x00BA2D00
		public void SetNext(string parts, string key, float fBlendSec, bool bLoop, Action changeNextMotionCallback) {} // 0x00B9E0E0-0x00B9E1C0
		public void ClearNext(string parts) {} // 0x00B9E340-0x00B9E3B0
		public void SetNextSpeed(string parts, float fSpeed) {} // 0x00B9E2C0-0x00B9E340
		public bool IsPlay(string parts, string key) => default; // 0x00B9F2B0-0x00B9F320
		public bool IsNextPlay(string parts, string key) => default; // 0x00BA2D00-0x00BA2D70
		public bool IsPlay(string parts) => default; // 0x00BA2D70-0x00BA2DE0
		public bool IsBindPose(string parts) => default; // 0x00BA2DE0-0x00BA2EC0
		public bool GetCurrentAnimationKeyCommonMotionFlag(string parts) => default; // 0x00BA2EC0-0x00BA2F30
		public bool IsNowAnimationBlending(string parts) => default; // 0x00BA2F30-0x00BA2FA0
		public float CalcNowAnimationBlendRate(string parts) => default; // 0x00BA2FA0-0x00BA3010
		public bool GetNowBlendAnimationCommonMotionFlag(string parts) => default; // 0x00BA3010-0x00BA3080
		public void ChangeCurrentLoop(string parts, bool bMotionLoop) {} // 0x00BA3080-0x00BA30F0
		public void ChangeCurrentSpeed(string parts, float fSpeed) {} // 0x00B9F420-0x00B9F4A0
		public float GetCurrentSpeed(string parts) => default; // 0x00B9F590-0x00B9F600
		public bool IsPause(string parts) => default; // 0x00B9F150-0x00B9F1C0
		public void SetTime(string parts, float fTime) {} // 0x00B9E4B0-0x00B9E530
		public float GetTime(string parts) => default; // 0x00B9E790-0x00B9E800
		public float GetMaxTime(string parts) => default; // 0x00B9E8F0-0x00B9E970
		public void SetNormalizeTime(string parts, float fNormalizeTime) {} // 0x00B9E630-0x00B9E6B0
		public float GetNormalizeTime(string parts) => default; // 0x00BA30F0-0x00BA31C0
		public void UpdateToNative(int nativeControlId) {} // 0x00B9C160-0x00B9C4D0
	}
}
