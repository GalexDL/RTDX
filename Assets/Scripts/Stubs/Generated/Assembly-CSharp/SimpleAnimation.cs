/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [RequireComponent] // 0x0060A280-0x0060A310
// [RequireComponent] // 0x0060A280-0x0060A310
public class SimpleAnimation : MonoBehaviour // TypeDefIndex: 6059
{
	// Fields
	protected PlayableGraph m_Graph; // 0x18
	protected AnimationPlayableOutput m_PlayableOutput; // 0x28
	protected PlayableHandle m_LayerMixer; // 0x38
	protected PlayableHandle m_TransitionMixer; // 0x48
	protected Animator m_Animator; // 0x58
	protected Animator m_SetupAnimator; // 0x60
	protected AnimationLayerMixerPlayable m_AnimationLayerMixerPlayable; // 0x68
	protected bool m_Initialized; // 0x78
	protected bool m_IsPlaying; // 0x79
	protected bool m_bSetupMode; // 0x7A
	protected Dictionary<uint, SimpleAnimationPlayable> m_dicPlayable; // 0x80
	[SerializeField] // 0x00616A20-0x00616A30
	protected bool m_PlayAutomatically; // 0x88
	[SerializeField] // 0x00616A30-0x00616A40
	protected bool m_AnimatePhysics; // 0x89
	[SerializeField] // 0x00616A40-0x00616A50
	protected AnimatorCullingMode m_CullingMode; // 0x8C
	[SerializeField] // 0x00616A50-0x00616A60
	protected WrapMode m_WrapMode; // 0x90
	[SerializeField] // 0x00616A60-0x00616A70
	protected AnimationClip m_Clip; // 0x98
	[SerializeField] // 0x00616A70-0x00616A80
	private EditorState[] m_States; // 0xA0

	// Properties
	public Animator animator { get => default; } // 0x009DC440-0x009DC450 
	public bool animatePhysics { get => default; set {} } // 0x009DC450-0x009DC460 0x009DC460-0x009DC480
	public AnimatorCullingMode cullingMode { get => default; set {} } // 0x009DC480-0x009DC490 0x009DC490-0x009DC4A0
	public bool playAutomatically { get => default; set {} } // 0x009DC4A0-0x009DC4B0 0x009DC4B0-0x009DC4C0
	public AnimationClip clip { get => default; set {} } // 0x009DC4C0-0x009DC4D0 0x009DC4D0-0x009DC500
	public WrapMode wrapMode { get => default; set {} } // 0x009DC5F0-0x009DC600 0x009DC600-0x009DC610

	// Nested types
	public interface State // TypeDefIndex: 6060
	{
		// Properties
		bool enabled { get; set; }
		bool isValid { get; }
		float time { get; set; }
		float normalizedTime { get; set; }
		float speed { get; set; }
		string name { get; set; }
		float weight { get; set; }
		float length { get; }
		AnimationClip clip { get; }
		WrapMode wrapMode { get; set; }
	}

	private class StateEnumerable : IEnumerable<State>, IEnumerable // TypeDefIndex: 6061
	{
		// Fields
		private SimpleAnimation m_Owner; // 0x10
		private uint m_layerId; // 0x18

		// Nested types
		private class StateEnumerator : IEnumerator<State>, IEnumerator, IDisposable // TypeDefIndex: 6062
		{
			// Fields
			private SimpleAnimation m_Owner; // 0x10
			private uint m_layerId; // 0x18
			private IEnumerator<SimpleAnimationPlayable.IState> m_Impl; // 0x20

			// Properties
			object IEnumerator.Current { get => default; } // 0x009E00C0-0x009E0150 
			State IEnumerator<SimpleAnimation.State>.Current { get => default; } // 0x009E0150-0x009E01E0 

			// Constructors
			public StateEnumerator() {} // Dummy constructor
			public StateEnumerator(SimpleAnimation owner, uint layerId) {} // 0x009DFDC0-0x009DFEE0

			// Methods
			private State GetCurrent() => default; // 0x009E0030-0x009E00C0
			public void Dispose() {} // 0x009E01E0-0x009E01F0
			public bool MoveNext() => default; // 0x009E01F0-0x009E0250
			public void Reset() {} // 0x009DFFD0-0x009E0030
		}

		// Constructors
		public StateEnumerable() {} // Dummy constructor
		public StateEnumerable(SimpleAnimation owner, uint layerId) {} // 0x009DEDB0-0x009DEDF0

		// Methods
		public IEnumerator<State> GetEnumerator() => default; // 0x009DFD40-0x009DFDC0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x009DFEE0-0x009DFF60
	}

	private class StateImpl : State // TypeDefIndex: 6063
	{
		// Fields
		private SimpleAnimationPlayable.IState m_StateHandle; // 0x10
		private SimpleAnimation m_Component; // 0x18

		// Properties
		bool State.enabled { get => default; set {} } // 0x009E0250-0x009E02B0 0x009E02B0-0x009E0350
		bool State.isValid { get => default; } // 0x009E0350-0x009E03B0 
		float State.time { get => default; set {} } // 0x009E03B0-0x009E0410 0x009E0410-0x009E04B0
		float State.normalizedTime { get => default; set {} } // 0x009E04B0-0x009E0510 0x009E0510-0x009E05B0
		float State.speed { get => default; set {} } // 0x009E05B0-0x009E0610 0x009E0610-0x009E06B0
		string State.name { get => default; set {} } // 0x009E06B0-0x009E0710 0x009E0710-0x009E0780
		float State.weight { get => default; set {} } // 0x009E0780-0x009E07E0 0x009E07E0-0x009E0880
		float State.length { get => default; } // 0x009E0880-0x009E08E0 
		AnimationClip State.clip { get => default; } // 0x009E08E0-0x009E0940 
		WrapMode State.wrapMode { get => default; set {} } // 0x009E0940-0x009E09A0 0x009E09A0-0x009E0A10

		// Constructors
		public StateImpl() {} // Dummy constructor
		public StateImpl(SimpleAnimationPlayable.IState handle, SimpleAnimation component) {} // 0x009DECF0-0x009DED30
	}

	[Serializable]
	public class EditorState // TypeDefIndex: 6064
	{
		// Fields
		public AnimationClip clip; // 0x10
		public string name; // 0x18
		public bool defaultState; // 0x20

		// Constructors
		public EditorState() {} // 0x009DF080-0x009DF090
	}

	// Constructors
	public SimpleAnimation() {} // 0x009DFCC0-0x009DFD40

	// Methods
	public void SetupAnimator(Animator animator) {} // 0x009DC610-0x009DC620
	public void CreateLayer(uint layerId) {} // 0x009DC960-0x009DCB30
	private AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount) => default; // 0x009DCC40-0x009DCCF0
	public void SetupAnimationLayerMixerForNowPlayable() {} // 0x009DCCF0-0x009DCF10
	public void AddClip(uint layerId, AnimationClip clip, string newName) {} // 0x009DCF80-0x009DCFD0
	public void Blend(uint layerId, string stateName, float targetWeight, float fadeLength) {} // 0x009DD0A0-0x009DD150
	public void BlendCheckStop(uint layerId, string stateName, float targetWeight, float fadeLength) {} // 0x009DD270-0x009DD320
	public void CrossFade(uint layerId, string stateName, float fadeLength) {} // 0x009DD400-0x009DD4B0
	public void CrossFadeQueued(uint layerId, string stateName, float fadeLength, QueueMode queueMode) {} // 0x009DD590-0x009DD650
	public int GetClipCount(uint layerId) => default; // 0x009DD730-0x009DD830
	public bool IsPlaying(uint layerId, string stateName) => default; // 0x009DD8F0-0x009DD960
	public void Stop(uint layerId) {} // 0x009DDA50-0x009DDAD0
	public void Stop(uint layerId, string stateName) {} // 0x009DDBE0-0x009DDC70
	public void Sample() {} // 0x009DDDB0-0x009DDDC0
	public bool Play(uint layerId) => default; // 0x009DDDC0-0x009DDED0
	public void AddState(uint layerId, AnimationClip clip, string name) {} // 0x009DCFD0-0x009DD0A0
	public void RemoveState(uint layerId, string name) {} // 0x009DE2F0-0x009DE380
	public bool Play(uint layerId, string stateName) => default; // 0x009DE470-0x009DE530
	public void PlayQueued(uint layerId, string stateName, QueueMode queueMode) {} // 0x009DE530-0x009DE600
	public void RemoveClip(uint layerId, AnimationClip clip) {} // 0x009DE6D0-0x009DE7F0
	public void Rewind(uint layerId) {} // 0x009DE810-0x009DE930
	public void Rewind(uint layerId, string stateName) {} // 0x009DE9F0-0x009DEA80
	public State GetState(uint layerId, string stateName) => default; // 0x009DEB40-0x009DEC50
	public IEnumerable<State> GetStates(uint layerId) => default; // 0x009DED30-0x009DEDB0
	private void Update() {} // 0x009DEDF0-0x009DEF00
	protected void Kick() {} // 0x009DD150-0x009DD190
	protected virtual void OnEnable() {} // 0x009DEF00-0x009DEFB0
	protected virtual void OnDisable() {} // 0x009DEFB0-0x009DF040
	private void Reset() {} // 0x009DF040-0x009DF080
	private void Initialize() {} // 0x009DC620-0x009DC960
	private void EnsureDefaultStateExists(uint layerId) {} // 0x009DF090-0x009DF1F0
	protected virtual void Awake() {} // 0x009DF1F0-0x009DF200
	protected void OnDestroy() {} // 0x009DF200-0x009DF240
	private void OnPlayableDone() {} // 0x009DF240-0x009DF3A0
	private void RebuildStates(uint layerId) {} // 0x009DE090-0x009DE2F0
	private EditorState CreateDefaultEditorState() => default; // 0x009DF3A0-0x009DF420
	private static void LegacyClipCheck(AnimationClip clip) {} // 0x009DC500-0x009DC5F0
	private void InvalidLegacyClipError(string clipName, string stateName) {} // 0x009DF420-0x009DF580
	private void OnValidate() {} // 0x009DF580-0x009DFCC0
}

