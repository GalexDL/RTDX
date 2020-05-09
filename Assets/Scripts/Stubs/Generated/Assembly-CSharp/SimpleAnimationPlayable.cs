/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SimpleAnimationPlayable : PlayableBehaviour // TypeDefIndex: 6065
{
	// Fields
	private LinkedList<QueuedState> m_StateQueue; // 0x10
	private StateManagement m_States; // 0x18
	private bool m_Initialized; // 0x20
	private bool m_KeepStoppedPlayablesConnected; // 0x21
	protected Playable m_ActualPlayable; // 0x28
	private AnimationMixerPlayable m_Mixer; // 0x38
	private bool m_bMixer; // 0x48
	public Action onDone; // 0x50
	private int m_StatesVersion; // 0x58

	// Properties
	public bool keepStoppedPlayablesConnected { get => default; set {} } // 0x009E0A10-0x009E0A20 0x009E0A20-0x009E0A40
	protected Playable self { get => default; } // 0x009E0DF0-0x009E0E00 
	public Playable playable { get => default; } // 0x009DCC30-0x009DCC40 
	protected PlayableGraph graph { get => default; } // 0x009E0E00-0x009E0E50 
	public Playable mixerPlayable { get => default; } // 0x009DCF10-0x009DCF80 

	// Nested types
	private class StateEnumerable : IEnumerable<IState>, IEnumerable // TypeDefIndex: 6066
	{
		// Fields
		private SimpleAnimationPlayable m_Owner; // 0x10

		// Nested types
		private class StateEnumerator : IEnumerator<IState>, IEnumerator, IDisposable // TypeDefIndex: 6067
		{
			// Fields
			private int m_Index; // 0x10
			private int m_Version; // 0x14
			private SimpleAnimationPlayable m_Owner; // 0x18

			// Properties
			object IEnumerator.Current { get => default; } // 0x009E4320-0x009E4330 
			IState IEnumerator<SimpleAnimationPlayable.IState>.Current { get => default; } // 0x009E4330-0x009E4340 

			// Constructors
			public StateEnumerator() {} // Dummy constructor
			public StateEnumerator(SimpleAnimationPlayable owner) {} // 0x009E3F20-0x009E3FF0

			// Methods
			private bool IsValid() => default; // 0x009E4110-0x009E4140
			private IState GetCurrentHandle(int index) => default; // 0x009E4140-0x009E4320
			public void Dispose() {} // 0x009E4340-0x009E4350
			public bool MoveNext() => default; // 0x009E4350-0x009E4480
			public void Reset() {} // 0x009E4060-0x009E4110
		}

		// Constructors
		public StateEnumerable() {} // Dummy constructor
		public StateEnumerable(SimpleAnimationPlayable owner) {} // 0x009E11C0-0x009E11F0

		// Methods
		public IEnumerator<IState> GetEnumerator() => default; // 0x009E3EB0-0x009E3F20
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x009E3FF0-0x009E4060
	}

	public interface IState // TypeDefIndex: 6068
	{
		// Properties
		bool enabled { get; set; }
		float time { get; set; }
		float normalizedTime { get; set; }
		float speed { get; set; }
		string name { get; set; }
		float weight { get; set; }
		float length { get; }
		AnimationClip clip { get; }
		WrapMode wrapMode { get; }

		// Methods
		bool IsValid();
	}

	public class StateHandle : IState // TypeDefIndex: 6069
	{
		// Fields
		private SimpleAnimationPlayable m_Parent; // 0x10
		private int m_Index; // 0x18
		private Playable m_Target; // 0x20
		private StateInfo state; // 0x30

		// Properties
		public bool enabled { get => default; set {} } // 0x009E44A0-0x009E4590 0x009E4590-0x009E4710
		public float time { get => default; set {} } // 0x009E4710-0x009E4840 0x009E4840-0x009E4900
		public float normalizedTime { get => default; set {} } // 0x009E4900-0x009E4AD0 0x009E4B90-0x009E4CF0
		public float speed { get => default; set {} } // 0x009E4CF0-0x009E4E00 0x009E4E00-0x009E4F10
		public string name { get => default; set {} } // 0x009E4FA0-0x009E5090 0x009E5100-0x009E5240
		public float weight { get => default; set {} } // 0x009E52B0-0x009E53A0 0x009E53A0-0x009E54F0
		public float length { get => default; } // 0x009E54F0-0x009E5630 
		public AnimationClip clip { get => default; } // 0x009E5630-0x009E5760 
		public WrapMode wrapMode { get => default; } // 0x009E5800-0x009E58F0 
		public int index { get => default; } // 0x009E2210-0x009E2220 

		// Constructors
		public StateHandle() {} // Dummy constructor
		public StateHandle(SimpleAnimationPlayable s, int index, Playable target) {} // 0x009E12E0-0x009E1330

		// Methods
		public bool IsValid() => default; // 0x009E4480-0x009E44A0
	}

	private class StateInfo // TypeDefIndex: 6070
	{
		// Fields
		public bool enabled; // 0x10
		public int index; // 0x14
		public string stateName; // 0x18
		public bool fading; // 0x20
		public float time; // 0x24
		public float targetWeight; // 0x28
		public float weight; // 0x2C
		public float fadeSpeed; // 0x30
		public float speed; // 0x34
		public AnimationClip clip; // 0x38
		public Playable playable; // 0x40
		public WrapMode wrapMode; // 0x50
		public bool isClone; // 0x54
		public StateHandle parentState; // 0x58
		public bool weightZeroStop; // 0x60
		public bool weightDirty; // 0x61
		public bool enabledDirty; // 0x62
		public bool timeIsUpToDate; // 0x63

		// Constructors
		public StateInfo() {} // 0x009E5960-0x009E5970
	}

	private class StateManagement // TypeDefIndex: 6071
	{
		// Fields
		private List<StateInfo> m_States; // 0x10
		private int m_Count; // 0x18

		// Properties
		public int Count { get => default; } // 0x009E0DE0-0x009E0DF0 
		public StateInfo this[int i] { get => default; } // 0x009E0B10-0x009E0B70 

		// Constructors
		public StateManagement() {} // 0x009E0E50-0x009E0ED0

		// Methods
		public StateInfo InsertState() => default; // 0x009E14C0-0x009E1660
		public bool AnyStatePlaying() => default; // 0x009E2310-0x009E2420
		public bool IsStateDone(int index) => default; // 0x009E5970-0x009E5A00
		public void RemoveAtIndex(int index) {} // 0x009E18B0-0x009E19A0
		public bool RemoveClip(AnimationClip clip) => default; // 0x009E19A0-0x009E1AB0
		public StateInfo FindState(string name) => default; // 0x009E11F0-0x009E12E0
		public void EnableState(int index) {} // 0x009E1C70-0x009E1D00
		public void DisableState(int index) {} // 0x009E33D0-0x009E3450
		public void SetInputWeight(int index, float weight) {} // 0x009E1D00-0x009E1D90
		public void SetStateTime(int index, float time) {} // 0x009E2140-0x009E2210
		public bool IsCloneOf(int potentialCloneIndex, int originalIndex) => default; // 0x009E5A10-0x009E5AB0
		public float GetStateTime(int index) => default; // 0x009E3260-0x009E3310
		public float GetStateSpeed(int index) => default; // 0x009E31E0-0x009E3260
		public void SetStateSpeed(int index, float value) {} // 0x009E4F10-0x009E4FA0
		public float GetInputWeight(int index) => default; // 0x009E5AB0-0x009E5B20
		public float GetStateLength(int index) => default; // 0x009E4AD0-0x009E4B90
		public float GetStatePlayableDuration(int index) => default; // 0x009E3310-0x009E33D0
		public AnimationClip GetStateClip(int index) => default; // 0x009E5760-0x009E5800
		public WrapMode GetStateWrapMode(int index) => default; // 0x009E58F0-0x009E5960
		public string GetStateName(int index) => default; // 0x009E5090-0x009E5100
		public void SetStateName(int index, string name) {} // 0x009E5240-0x009E52B0
		public void StopState(int index, bool cleanup) {} // 0x009E2220-0x009E2300
	}

	private class QueuedState // TypeDefIndex: 6074
	{
		// Fields
		public StateHandle state; // 0x10
		public float fadeTime; // 0x18

		// Constructors
		public QueuedState() {} // Dummy constructor
		public QueuedState(StateHandle s, float t) {} // 0x009E20F0-0x009E2130
	}

	// Constructors
	public SimpleAnimationPlayable() {} // 0x009DCB30-0x009DCC30
	public SimpleAnimationPlayable(bool bEnableMixer) {} // 0x009E0ED0-0x009E0FD0

	// Methods
	private void UpdateStoppedPlayablesConnections() {} // 0x009E0A40-0x009E0B10
	public Playable GetInput(int index) => default; // 0x009E0FD0-0x009E10B0
	public override void OnPlayableCreate(Playable playable) {} // 0x009E10B0-0x009E11C0
	public IEnumerable<IState> GetStates() => default; // 0x009DFF60-0x009DFFD0
	public IState GetState(string name) => default; // 0x009DEC50-0x009DECF0
	private StateInfo DoAddClip(string name, AnimationClip clip) => default; // 0x009E1330-0x009E14C0
	public bool AddClip(AnimationClip clip, string name) => default; // 0x009DDFA0-0x009DE090
	public bool RemoveClip(string name) => default; // 0x009DE380-0x009DE470
	public bool RemoveClip(AnimationClip clip) => default; // 0x009DE7F0-0x009DE810
	public bool Play(string name) => default; // 0x009DDED0-0x009DDFA0
	private bool Play(int index) => default; // 0x009E1AB0-0x009E1C70
	public bool PlayQueued(string name, QueueMode queueMode) => default; // 0x009DE600-0x009DE6D0
	private bool PlayQueued(int index, QueueMode queueMode) => default; // 0x009E1E30-0x009E1F50
	public void Rewind(string name) {} // 0x009DEA80-0x009DEB40
	private void Rewind(int index) {} // 0x009E2130-0x009E2140
	public void Rewind() {} // 0x009DE930-0x009DE9F0
	private void RemoveClones(StateInfo state) {} // 0x009E1710-0x009E18B0
	public bool Stop(string name) => default; // 0x009DDC70-0x009DDDB0
	private void DoStop(int index) {} // 0x009E1D90-0x009E1E30
	public bool StopAll() => default; // 0x009DDAD0-0x009DDBE0
	public bool IsPlaying() => default; // 0x009E2300-0x009E2310
	public bool IsPlaying(string stateName) => default; // 0x009DD960-0x009DDA50
	private bool IsClonePlaying(StateInfo state) => default; // 0x009E2420-0x009E24F0
	public int GetClipCount() => default; // 0x009DD830-0x009DD8F0
	private void SetupLerp(StateInfo state, float targetWeight, float time) {} // 0x009E24F0-0x009E25B0
	private bool Crossfade(int index, float time) => default; // 0x009E25B0-0x009E27F0
	private StateInfo CloneState(int index) => default; // 0x009E1F50-0x009E2060
	public bool Crossfade(string name, float time) => default; // 0x009DD4B0-0x009DD590
	public bool CrossfadeQueued(string name, float time, QueueMode queueMode) => default; // 0x009DD650-0x009DD730
	private bool CrossfadeQueued(int index, float time, QueueMode queueMode) => default; // 0x009E27F0-0x009E2920
	private bool Blend(int index, float targetWeight, float time) => default; // 0x009E2920-0x009E2A90
	public bool Blend(string name, float targetWeight, float time) => default; // 0x009DD190-0x009DD270
	public bool BlendCheckStop(string name, float targetWeight, float time) => default; // 0x009DD320-0x009DD400
	public override void OnGraphStop(Playable playable) {} // 0x009E2A90-0x009E2C60
	private void UpdateDoneStatus() {} // 0x009E1660-0x009E1700
	private void DisconnectInput(int index) {} // 0x009E0CA0-0x009E0DE0
	private void ConnectInput(int index) {} // 0x009E0B70-0x009E0CA0
	private void UpdateStates(float deltaTime) {} // 0x009E2C60-0x009E31E0
	private float CalculateQueueTimes() => default; // 0x009E3450-0x009E3660
	private void ClearQueuedStates() {} // 0x009E3660-0x009E3910
	private void UpdateQueuedStates() {} // 0x009E3910-0x009E3A00
	private void UpdateStateTimes() {} // 0x009E3A00-0x009E3AB0
	private void UpdateFrame(float deltaTime) {} // 0x009E3AB0-0x009E3B80
	public override void PrepareFrame(Playable owner, FrameData data) {} // 0x009E3B80-0x009E3C60
	public bool ValidateInput(int index, Playable input) => default; // 0x009E3C60-0x009E3DA0
	public bool ValidateIndex(int index) => default; // 0x009E3DA0-0x009E3DC0
	private void SetInputWeight(int index, float weight) {} // 0x009E3DC0-0x009E3E40
	private float GetInputWeight(int index) => default; // 0x009E3E40-0x009E3EB0
	private void InvalidateStates() {} // 0x009E1700-0x009E1710
	private StateHandle StateInfoToHandle(StateInfo info) => default; // 0x009E2060-0x009E20F0
}

