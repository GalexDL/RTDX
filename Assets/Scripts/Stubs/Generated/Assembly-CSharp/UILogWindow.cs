/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A640-0x0060A650
public class UILogWindow : UIManagerBase // TypeDefIndex: 7048
{
	// Fields
	public FiniteStateMachine<UILogWindow, States> FSM; // 0x20
	private const int MAX_BUFFERS = 8; // Metadata: 0x00613289
	private const int MAX_LINES = 4; // Metadata: 0x0061328D
	private const int MESSAGE_SHOW_WAIT = 100; // Metadata: 0x00613291
	private UIPrefabLoader pl_; // 0x28
	private bool bUpdateFromNative_; // 0x30
	private Mode mode_; // 0x34
	private int read_; // 0x38
	private int write_; // 0x3C
	private string[] buffers_; // 0x40
	private string[] lines_; // 0x48
	private int showCount_; // 0x50
	private int waitCount_; // 0x54
	private bool bWait_; // 0x58
	private bool bVisible_; // 0x59
	private bool bVisibleDuty_; // 0x5A
	private bool bViewingLog_; // 0x5B
	private string readLine_; // 0x60
	private string read2ndLine_; // 0x68
	private GameObject[] messageObjIn_; // 0x70
	private GameObject[] messageObjOut_; // 0x78
	private UIControlTMP[] messageIn_; // 0x80
	private UIControlTMP[] messageOut_; // 0x88
	private readonly string[] FadeInObjectNames; // 0x90
	private readonly string[] FadeOutObjectNames; // 0x98

	// Properties
	public bool UpdateNative { get => default; set {} } // 0x00945250-0x00945260 0x00944960-0x00944970

	// Nested types
	public enum States // TypeDefIndex: 7049
	{
		Init = 0,
		Run = 1,
		End = 2
	}

	public class StateInit : FSMState<UILogWindow, States> // TypeDefIndex: 7050
	{
		// Properties
		public override States StateID { get => default; } // 0x00946B80-0x00946B90 

		// Constructors
		public StateInit() {} // 0x009450B0-0x00945100

		// Methods
		public override void Enter() {} // 0x00946B90-0x00946BA0
		public override void Execute() {} // 0x00946BA0-0x00946BB0
		public override void Exit() {} // 0x00946BB0-0x00946BC0
	}

	public class StateRun : FSMState<UILogWindow, States> // TypeDefIndex: 7051
	{
		// Properties
		public override States StateID { get => default; } // 0x00946BC0-0x00946BD0 

		// Constructors
		public StateRun() {} // 0x00945100-0x00945150

		// Methods
		public override void Enter() {} // 0x00946BD0-0x00946BE0
		public override void Execute() {} // 0x00946BE0-0x00946BF0
		public override void Exit() {} // 0x00946BF0-0x00946C00
	}

	public class StateEnd : FSMState<UILogWindow, States> // TypeDefIndex: 7052
	{
		// Properties
		public override States StateID { get => default; } // 0x00946B40-0x00946B50 

		// Constructors
		public StateEnd() {} // 0x00945150-0x009451A0

		// Methods
		public override void Enter() {} // 0x00946B50-0x00946B60
		public override void Execute() {} // 0x00946B60-0x00946B70
		public override void Exit() {} // 0x00946B70-0x00946B80
	}

	public enum Mode // TypeDefIndex: 7053
	{
		Normal = 0,
		Scroll = 1,
		Wait = 2
	}

	// Constructors
	public UILogWindow() {} // 0x00946780-0x00946B40

	// Methods
	public static UILogWindow Create(bool bUpdateFromNative = true /* Metadata: 0x00613287 */) => default; // 0x00944860-0x00944960
	private void Awake() {} // 0x00944970-0x00944BE0
	private void Start() {} // 0x009451A0-0x009451B0
	private void Update() {} // 0x009451B0-0x00945250
	public void Clear() {} // 0x00944BE0-0x009450B0
	public void SetVisible(bool bVisible) {} // 0x00945260-0x00945290
	public bool IsBufferFull() => default; // 0x00945290-0x009452C0
	public void WriteBuffer(string sLine) {} // 0x009452C0-0x00945370
	private bool _readBuffer() => default; // 0x00945370-0x009454C0
	public bool ProcessAutoReturn(ushort[] stringSrcBuff, out string s1, out string s2, bool bHistory = false /* Metadata: 0x00613288 */) {
		s1 = default;
		s2 = default;
		return default;
	} // 0x009454C0-0x00945820
	private bool _isVisible() => default; // 0x00945820-0x009458B0
	private void _setTextFadeIn(bool bQuick) {} // 0x009458B0-0x00945BB0
	private void _cbAnimeFadeIn(UIAnimationBase.ActionType act) {} // 0x00945BB0-0x00945BF0
	private void _setTextFadeOut(bool bQuick) {} // 0x00945BF0-0x00945EC0
	public void DoInitialize() {} // 0x00945EC0-0x00946400
	public void DoExecute() {} // 0x00946400-0x00946780
}

