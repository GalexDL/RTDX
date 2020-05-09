/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pegasus;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x00609780-0x006097C0
[ExecuteInEditMode] // 0x00609780-0x006097C0
public class GameSystem : SingletonMonoBehaviour<GameSystem> // TypeDefIndex: 5524
{
	// Fields
	private const string DllName = "__Internal"; // Metadata: 0x00611B83
	private static bool s_bBootStrapInitialize; // 0x00
	private static bool s_bBootStrapInitializeAfterCopyAssets; // 0x01
	public static bool NativeInitialized; // 0x02
	[NonSerialized]
	public bool FpsDisp; // 0x18
	[NonSerialized]
	public bool MemoryDisp; // 0x19
	private Transform fpsTransform_; // 0x20
	private Transform memoryTransform_; // 0x28
	private static DebugRegisterLog debugRegisterLog_; // 0x08
	private DebugPerformanceCounter debugPerformanceCounter_; // 0x30
	private ResolutionLevel resolutionLevel_; // 0x3C
	private DartyFlag dartyFlag_; // 0x40
	[NonSerialized]
	private bool bTouched_; // 0x48
	[NonSerialized]
	private bool bStartedBootstrapMode_; // 0x49
	[NonSerialized]
	public bool bFiexdUpdate_; // 0x4A
	[NonSerialized]
	public bool bFiexdUpdate1_; // 0x4B
	[NonSerialized]
	public bool bFiexdUpdate2_; // 0x4C
	[NonSerialized]
	public bool bFiexdUpdate3_; // 0x4D
	[NonSerialized]
	public bool bFiexdUpdate4; // 0x4E
	private bool bInitializedGameMainMode_; // 0x4F
	private bool bInitializeFailed_; // 0x50
	private bool bStartedEditorMode_; // 0x51
	private bool bStartedGameMainMode_; // 0x52
	private int nativeFrameCount_; // 0x54
	private float nativeNextTime_; // 0x58
	private float nativePrevTime_; // 0x5C
	private float nativeNowTime_; // 0x60
	private int drawFrameCount_; // 0x64
	private float drawNextTime_; // 0x68
	private float drawPrevTime_; // 0x6C
	private float drawNowTime_; // 0x70
	public float fDungeonShadowDistance_; // 0x74
	private MoveFloat moveGroundShadowDistance_; // 0x78
	private bool bClearFlagUpdate_; // 0x80
	public ShadowResolution ShadowResolution_; // 0x84
	private NormalShadowSetting eNormalShadowSetting_; // 0x88
	private bool bPause_; // 0x8C
	private bool bPauseRequest_; // 0x8D
	private bool bPauseReleaseRequest_; // 0x8E
	private float fPauseTempReleaseSec_; // 0x90
	private float timeScaleDefault_; // 0x94
	private static bool s_bResolution3_4; // 0x10
	private int nBaseResolutionW_; // 0x98
	private int nBaseResolutionH_; // 0x9C
	private const int gameFrameRate_ = 30; // Metadata: 0x00611B91
	private List<Shader> resident_shaders_; // 0xA0
	private List<ShaderVariantCollection> resident_shaderVariantColls_; // 0xA8
	private static GameObject dontSaveRoot_; // 0x18
	public const int TASK_PRIO_DEFAULT = 1024; // Metadata: 0x00611B95
	private Dictionary<int, ManualCoroutineTaskSet> taskSetPrioTable_; // 0xB0
	public const long ManualGcLimitSize = 419430400; // Metadata: 0x00611B99
	private ManualGc_ manualGc_; // 0xB8

	// Properties
	public DebugPerformanceCounter DebugPerfCounter { get => default; } // 0x007219D0-0x007219E0 
	public GameModeType CurrentGameMode { get; private set; } // 0x00721B40-0x00721B50 0x00721B50-0x00721B60
	public bool IsPause { get => default; } // 0x00721B90-0x00721BA0 
	public bool RequestPause { set {} } // 0x00721BA0-0x00721BB0
	public bool RequestPauseRelease { set {} } // 0x00721BB0-0x00721BC0
	public static bool Resolution3_4 { get => default; } // 0x00721BD0-0x00721C40 
	public static bool Resolution16_9 { get => default; } // 0x00721C40-0x00721CB0 
	public bool StartedEditorMode { get => default; } // 0x00721CD0-0x00721CE0 
	public bool StartedGameMainMode { get => default; } // 0x00721CE0-0x00721CF0 

	// Nested types
	public enum GameModeType // TypeDefIndex: 5525
	{
		NONE = 0,
		TOP_MENU = 1,
		DUNGEON = 2,
		GROUND = 3
	}

	public enum ResolutionLevel // TypeDefIndex: 5526
	{
		LOW = 0,
		NORMAL = 1,
		HIGH = 2
	}

	public class DartyFlag // TypeDefIndex: 5527
	{
		// Fields
		public bool bResolutionLevel; // 0x10

		// Constructors
		public DartyFlag() {} // 0x00725190-0x007251A0

		// Methods
		public void AllSet() {} // 0x007287D0-0x007287E0
		public void Clear() {} // 0x007287E0-0x007287F0
	}

	public enum NormalShadowSetting // TypeDefIndex: 5528
	{
		Dungeon = 0,
		Ground = 1
	}

	private class ManualGc_ // TypeDefIndex: 5529
	{
		// Fields
		public bool bEnable; // 0x10
		public long startSize; // 0x18
		public long maxSize; // 0x20

		// Constructors
		public ManualGc_() {} // 0x007251A0-0x007251B0
	}

	// Constructors
	public GameSystem() {} // 0x00725010-0x00725190
	static GameSystem() {} // 0x007251B0-0x007251C0

	// Methods
	public static string BuildPlatform() => default; // 0x007219E0-0x00721A30
	public static string RuntimePlatform() => default; // 0x00721A30-0x00721B40
	public void SetGameMode(GameModeType mode) {} // 0x00721B60-0x00721B70
	public bool IsGameMode_Dungeon() => default; // 0x00721B70-0x00721B80
	public bool IsGameMode_Ground() => default; // 0x00721B80-0x00721B90
	public void SetPauseTempReleaseSec(float fSec) {} // 0x00721BC0-0x00721BD0
	public void SetGroundShadowDistance(float fTarget, float fTime) {} // 0x00721CB0-0x00721CC0
	public float GetGroundShadowDistance() => default; // 0x00721CC0-0x00721CD0
	private void Awake() {} // 0x00721CF0-0x00721E00
	private void OnEnable() {} // 0x00721E50-0x00721EC0
	private void OnDisable() {} // 0x00722090-0x007220A0
	public void OnApplicationPause(bool pauseStatus) {} // 0x00722170-0x00722190
	private void StartupGameAndEditor_() {} // 0x00721EC0-0x00722090
	// [IteratorStateMachine] // 0x00620720-0x00620790
	public IEnumerator StartGameSystem_ForPlayMode() => default; // 0x00722230-0x007222A0
	private void ShutdownGameAndEditor_() {} // 0x007220A0-0x00722170
	public void ShutdownGameSystem_ForPlayMode() {} // 0x007222D0-0x00722300
	// [IteratorStateMachine] // 0x00620790-0x00620800
	private IEnumerator LoadResidentResources_() => default; // 0x00722420-0x00722490
	private void LoadWindowDisplay_() {} // 0x007224C0-0x00722500
	private void EndBooting_() {} // 0x00722500-0x00722540
	// [IteratorStateMachine] // 0x00620800-0x00620870
	public IEnumerator KeyLock() => default; // 0x00722540-0x007225A0
	// [IteratorStateMachine] // 0x00620870-0x006208E0
	private IEnumerator StartupForBootstrapMode_() => default; // 0x007225D0-0x00722640
	private void ShutdownForBootstrapMode_() {} // 0x00722410-0x00722420
	// [IteratorStateMachine] // 0x006208E0-0x00620950
	private IEnumerator Setup_ForGameMainMode_() => default; // 0x00722670-0x007226E0
	private void Shutdown_ForGameMainMode_() {} // 0x00722300-0x00722410
	// [IteratorStateMachine] // 0x00620950-0x006209C0
	private IEnumerator InitializeForGameMainMode_() => default; // 0x00722B00-0x00722B70
	private void FinalizeForGameMainMode_() {} // 0x00722710-0x00722A50
	public static void SetFrameRate(int rate) {} // 0x00722BA0-0x00722C10
	public static int GetFrameRate() => default; // 0x00722C10-0x00722C20
	public static float GetVirtualResolutionW() => default; // 0x00721E00-0x00721E10
	public static float GetVirtualResolutionH() => default; // 0x00721E10-0x00721E20
	public static float GetResolutionRateH() => default; // 0x00722C20-0x00722CA0
	public static float GetResolutionRateW() => default; // 0x00722CA0-0x00722D20
	private void progress(float v, string msg) {} // 0x00722D20-0x00722D30
	private void SetupQuality() {} // 0x00722D30-0x00722D40
	private void _FixedUpdate() {} // 0x00722D40-0x00722E40
	private void _FixedUpdate_NativeUpdate() {} // 0x00722E40-0x00723220
	private void DrawFPSUpdate() {} // 0x00723240-0x00723310
	private void DrawMemoryUpdate() {} // 0x00723310-0x007233E0
	private void Update() {} // 0x007233E0-0x00723A70
	private void LateUpdate() {} // 0x00723E50-0x00723F90
	public void SetTouchScreen(bool is_touch) {} // 0x007242A0-0x007242B0
	public static GameObject GetDontSaveRoot() => default; // 0x007242B0-0x00724410
	public static void AttachDontSaveRoot(GameObject childObj) {} // 0x00724520-0x007245C0
	public static void StartDontSaveRoot() {} // 0x00724410-0x00724520
	public static void TerminateDontSaveRoot() {} // 0x00722A60-0x00722B00
	public void SetResolutionLevel(ResolutionLevel resolutionLevel, bool bForce = false /* Metadata: 0x00611B78 */) {} // 0x00721E20-0x00721E50
	public void UpdateResolutionLevel() {} // 0x00723BE0-0x00723CB0
	public NormalShadowSetting GetNormalShadowSetting() => default; // 0x007245C0-0x007245D0
	public void SetNormalShadowSetting(NormalShadowSetting setting) {} // 0x007245D0-0x007246A0
	private void SetNormalShadowSetting(NormalShadowSetting setting, bool bForce) {} // 0x007246A0-0x00724770
	public void UpdateNormalShadowSetting() {} // 0x00724770-0x00724830
	public void PlaySoundTest(string symbol) {} // 0x00724830-0x00724840
	private void ClearAllTask_() {} // 0x00724840-0x00724890
	private void UpdateTask_() {} // 0x00723CB0-0x00723E50
	public void StartTask(IEnumerator co, int prio = 1024 /* Metadata: 0x00611B79 */, bool bCallFirstFrameImmediately = false /* Metadata: 0x00611B7D */) {} // 0x00724890-0x00724970
	public void StartTask_ImmediateFirstFrame(IEnumerator co, int prio = 1024 /* Metadata: 0x00611B7E */) {} // 0x00724970-0x00724980
	// [IteratorStateMachine] // 0x006209C0-0x00620A30
	public static IEnumerator WaitCoroutine(float fWaitTime) => default; // 0x00720FA0-0x00721010
	// [IteratorStateMachine] // 0x00620A30-0x00620AA0
	public static IEnumerator KeyWaitCoroutine(Action<int> cb) => default; // 0x007249B0-0x00724A20
	public static void GameObject_Destory(UnityEngine.Object obj) {} // 0x00724A50-0x00724AF0
	public static void GameObject_Destory(GameObject obj) {} // 0x00724AF0-0x00724B90
	public void ManualGC_Begin(long gcSize, bool bWithGcCollect = true /* Metadata: 0x00611B82 */) {} // 0x00724B90-0x00724EB0
	public void ManualGC_End() {} // 0x00724EB0-0x00724F20
	private void ManualGC_Update_() {} // 0x00723A70-0x00723BE0
	public void ManualGC_GCCollectCpuBoost() {} // 0x00724F20-0x00724FB0
	private static extern void InitializeGameMainMode(); // 0x00724FB0-0x00724FC0
	private static extern void TerminateGameMainMode(); // 0x00722A50-0x00722A60
	private static extern void UpdateFromPlugin(bool bStarted, bool bResolution3_4, float w, float h); // 0x00723220-0x00723230
	private static extern void InitializeEditorMode(); // 0x00724FC0-0x00724FD0
	private static extern void TerminateEditorMode(); // 0x00724FD0-0x00724FE0
	private static extern void OnPostRenderFromPlugin(); // 0x00723230-0x00723240
	public static extern int UpdateMainFiberFromPlugin(); // 0x00724FE0-0x00724FF0
	public static extern void UpdateCameraParameterFromPlugin(int[] i, float[] f); // 0x00724FF0-0x00725010
}

