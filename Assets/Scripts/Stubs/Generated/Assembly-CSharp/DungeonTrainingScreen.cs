/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonTrainingScreen : UIManagerBase // TypeDefIndex: 6217
{
	// Fields
	private State state_; // 0x1C
	private float counter_; // 0x20
	private int nCount_; // 0x24
	private UIControlTMP textCount_; // 0x28

	// Nested types
	public enum State // TypeDefIndex: 6218
	{
		None = 0,
		Running = 1,
		Suspend = 2,
		Stop = 3,
		End = 4
	}

	// Constructors
	public DungeonTrainingScreen() {} // 0x00BC4250-0x00BC4260

	// Methods
	private void Start() {} // 0x00BC3800-0x00BC3810
	private void Update() {} // 0x00BC3810-0x00BC38D0
	public void TimerSuspend(bool is_disp_pause = false /* Metadata: 0x00612AA8 */) {} // 0x00BC39A0-0x00BC3A70
	public void TimerResume(bool is_disp_pause = false /* Metadata: 0x00612AA9 */) {} // 0x00BC3A70-0x00BC3B40
	public static DungeonTrainingScreen Create(Index ticket) => default; // 0x00BC3B40-0x00BC3CC0
	public virtual void Construct(Index ticket) {} // 0x00BC3CC0-0x00BC3E70
	public virtual void Destruct() {} // 0x00BC3E70-0x00BC3EF0
	private void _updateCount() {} // 0x00BC38E0-0x00BC39A0
	private void _SeWhistle() {} // 0x00BC3EF0-0x00BC3FB0
	// [IteratorStateMachine] // 0x00625330-0x006253A0
	public IEnumerator StartFlow(int count) => default; // 0x00BC3FB0-0x00BC4030
	public bool IsRunning() => default; // 0x00BC4060-0x00BC4070
	public void TimerStop() {} // 0x00BC38D0-0x00BC38E0
	// [IteratorStateMachine] // 0x006253A0-0x00625410
	public IEnumerator EndFlow(bool bSuccess) => default; // 0x00BC4070-0x00BC40E0
	// [IteratorStateMachine] // 0x00625410-0x00625480
	public IEnumerator EffectNice() => default; // 0x00BC4110-0x00BC4180
	// [IteratorStateMachine] // 0x00625480-0x006254F0
	public IEnumerator EffectCongratulations() => default; // 0x00BC41B0-0x00BC4220
}

