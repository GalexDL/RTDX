/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Const;
using Const.creature;
using Const.dungeon;
using Const.quest;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GroundPlayer // TypeDefIndex: 4905
{
	// Fields
	private PlayMode_ playMode_; // 0x10
	private string logText_; // 0x18
	private ManualCoroutineTaskSet taskSet_; // 0x20
	private GroundPlayContext currentContext_; // 0x28
	private bool bSuspend_; // 0x30
	private SuspendVisibleInfo_ suspendInfo_; // 0x38
	private static Regex match_op; // 0x00
	private const string SpecialFlag_EARLY_MORNING_ = "EARLY_MORNING"; // Metadata: 0x00610CA5
	private const string SpecialFlag_GAISEN_ = "GAISEN"; // Metadata: 0x00610CB6
	private const string SpecialFlag_POST_LETTER_ON_ = "POST_LETTER_ON"; // Metadata: 0x00610CC0
	private const string SpecialFlag_HINT_POPUP_PARTNER_SPEAK_ = "HINT_POPUP_PARTNER_SPEAK"; // Metadata: 0x00610CD2
	private GroundMode_ groundMode_; // 0x40
	private const float MoveCharaAddRadius = 0.4f; // Metadata: 0x00610CEE
	private List<ContanctInfo_> contactListCache_; // 0x48
	private List<ActAsset_BgmArea> UpdateMapBgm_hitBgmAssetList; // 0x50
	private List<ActAsset_BgmArea> UpdateMapBgm_hitEnvAssetList; // 0x58
	private HashSet<string> UpdateMapBgm_nowPlaySet; // 0x60
	private HashSet<string> UpdateMapBgm_nextPlaySet; // 0x68
	private List<SubscenarioPartneTalkInfo_> partnerTalkInfo_; // 0x70

	// Properties
	public bool IsPlaying { get => default; } // 0x00736860-0x00736880 
	public string LogText { get => default; } // 0x00736990-0x007369A0 
	private ActObjCharactor actCh_Player_ { get => default; } // 0x00737330-0x007373C0 
	private ActObjCharactor actCh_Follow_ { get => default; } // 0x007373C0-0x00737450 
	private ActObjCamera actCamera_ { get => default; } // 0x007368A0-0x00736910 
	private bool isFollowEnable_ { get => default; } // 0x00737450-0x00737590 

	// Nested types
	private enum PlayMode_ // TypeDefIndex: 4906
	{
		None = 0,
		Playing = 1,
		PlayStopping = 2
	}

	public enum GeneralDgFlowType // TypeDefIndex: 4907
	{
		Story_Normal = 0,
		Story_Igaguri = 1,
		AfterEnding = 2
	}

	public enum EndBgmType // TypeDefIndex: 4908
	{
		Continue = 0,
		FadeNormal = 1,
		FadeFast = 2,
		FadeSlow = 3
	}

	public class GroundParam // TypeDefIndex: 4909
	{
		// Fields
		public GroundLocalSaveData resumeData; // 0x10
		public Action<GroundLocalSaveData> groundSaveFunc; // 0x18
		public List<string> actAssetSetSymbols; // 0x20
		public string nextFlowCondition; // 0x28
		public string specialOptionData; // 0x30
		public string stopperScriptPath; // 0x38
		public bool isContinuePos; // 0x40
		public bool isSeamlessEnd; // 0x41
		public EndBgmType endBgmType; // 0x44
		public string townNpcStepId; // 0x48
		public GeneralDgFlowType generalDgFlow; // 0x50
		public string generalDgFlow_OhayouScriptPath; // 0x58
		public Organization.OrganizationType henseiType; // 0x60
		public bool hasStartPostEvent; // 0x64
		public GameFlow_SubScenarioManager subScenarioManager; // 0x68
		public NamedGameFlowBlobListTbl subGameFlowTbl; // 0x70
		public bool isAgingMode; // 0x78
		public bool isGroundBgTestMode; // 0x79
		public ActAssetSet debugActAssetSet; // 0x80
		private List<string> specialOptionDataTbl_; // 0x88

		// Constructors
		public GroundParam() {} // 0x007FC610-0x007FC6B0

		// Methods
		public bool CheckSpecialOption(string checkOption) => default; // 0x007FC520-0x007FC610
	}

	public class GroundResult // TypeDefIndex: 4910
	{
		// Fields
		public GroundLocalSaveData suspendData; // 0x10

		// Constructors
		public GroundResult() {} // 0x007F6160-0x007F61D0
	}

	private class GroundPlayContext // TypeDefIndex: 4911
	{
		// Fields
		public GroundParam argParam; // 0x10
		public Action stepCb; // 0x18
		public Action<string> errorCb; // 0x20
		public bool isNeedSuspend; // 0x28
		public GroundLocalSaveData localSaveData; // 0x30
		public TownNpcWorkSet_ townNpcWorkSet; // 0x38
		public PartyNpcWork_ partyNpcWork_; // 0x40
		public GonbeWork_ gonbeWork; // 0x48
		public TalkManpu_ talkManpu; // 0x50
		public CollisionCharaSet_ collisionCharaSet_; // 0x58
		public ActPlayerSyncTarget actPlayerSyncTarget; // 0x60

		// Constructors
		public GroundPlayContext() {} // 0x007F60E0-0x007F6160
	}

	[Serializable]
	public class SerializableDictionary_String_String : SerializableDictionary<string, string> // TypeDefIndex: 4912
	{
		// Constructors
		public SerializableDictionary_String_String() {} // 0x007FCA10-0x007FCA60
	}

	[Serializable]
	public class GroundSaveData // TypeDefIndex: 4913
	{
		// Fields
		public DungeonBossBattleState[] bossBattleState_RegiSeriesTbl; // 0x10
		public DeokisisuRugiaBossState deokisisuBossState; // 0x18
		public DeokisisuRugiaBossState rugiaBossState; // 0x1C
		public SerializableDictionary_String_String shopTalkStepTbl; // 0x20
		public List<string> shopTalkCheck_af01_020; // 0x28
		public ScenarioManager.TeamFlagIndex teamFlagIndex; // 0x30
		public bool tutorialFlag_kyujyotaiCircle; // 0x34
		public DagutorioData dagutorioData; // 0x38
		public int GonbeCount; // 0x40
		public bool firstGonbeReward; // 0x44
		public ScenarioManager.StatueLevel statueLevel; // 0x48
		public bool isStagingPost; // 0x4C
		public bool suspendFlag_PerippaaFromTop; // 0x4D

		// Nested types
		public enum BossState // TypeDefIndex: 4914
		{
			BATTLE_0 = 0,
			BATTLE_1 = 1,
			FRIEND = 2
		}

		public enum DeokisisuRugiaBossState // TypeDefIndex: 4915
		{
			PRE_BATTLE = 0,
			BATTLE_LOSE = 1,
			BATTLE_WIN = 2
		}

		[Serializable]
		public class DagutorioData // TypeDefIndex: 4916
		{
			// Fields
			public string dagutorio_lastStep; // 0x10
			public bool dagutorio_firstTalk; // 0x18

			// Constructors
			public DagutorioData() {} // 0x007FCA60-0x007FCAC0

			// Methods
			public void UpdateDagutorioStep(string step) {} // 0x007FCAC0-0x007FCB10
			public bool IsDagutroioSpecialEvent_af01_030() => default; // 0x007FCB10-0x007FCB90
			public bool IsDagutroioForceVisibleOff() => default; // 0x007FCB90-0x007FCC40
			public void DagutroioReset() {} // 0x007FC7D0-0x007FC830
		}

		// Constructors
		public GroundSaveData() {} // 0x007FC8B0-0x007FCA10

		// Methods
		public void Reset() {} // 0x007FC6B0-0x007FC7D0
		public void ResetSubScenario() {} // 0x007FC830-0x007FC8B0
	}

	[Serializable]
	public class GroundLocalSaveData // TypeDefIndex: 4917
	{
		// Fields
		public int dayCount; // 0x10
		public int mankiiCount; // 0x14
		public DayStartWork dayStartWork; // 0x18
		public SuspendMode suspendMode; // 0x20
		public SuspendGroundLoop suspendGroundLoopMode; // 0x24
		public GameFlowLocalSaveData suspendSubFlowLocalSaveData; // 0x28
		public string suspendNextSubFlowId; // 0x30
		public DungeonStartMode suspendDungeonStartMode; // 0x38
		public Const.dungeon.Index suspendDungeonIndex; // 0x3C
		public SuspendMap suspendMapData; // 0x40
		public SuspendGonbe suspendGonbeData; // 0x48

		// Properties
		public bool IsNeedSuspendOrResume { get => default; } // 0x007F5B00-0x007F5B10 

		// Nested types
		[Serializable]
		public class DayStartWork // TypeDefIndex: 4918
		{
			// Fields
			public bool isFirstDay; // 0x10
			public bool isNeedOhayou; // 0x11
			public string ohayouFlowId; // 0x18

			// Constructors
			public DayStartWork() {} // 0x007FC180-0x007FC1E0
		}

		public enum SuspendMode // TypeDefIndex: 4919
		{
			None = 0,
			GroundLoop = 100,
			DungeonNormal = 200,
			DungeonSubScenarioFlow = 300,
			HanyouAsaFlow = 400,
			PerippaaDungeon = 500,
			PerippaaShop = 510
		}

		public enum SuspendGroundLoop // TypeDefIndex: 4920
		{
			None = 0,
			Shop_Peripper = 100,
			Shop_Makunoshita = 200
		}

		[Serializable]
		public class SuspendMap // TypeDefIndex: 4921
		{
			// Fields
			public string currentMapId; // 0x10
			public PosRot_ heroPosRot; // 0x18
			public PosRot_ partnerPosRot; // 0x20
			public bool partnerVisible; // 0x28
			public List<NpcPosRot_> npcPosRotList; // 0x30

			// Nested types
			[Serializable]
			public class PosRot_ // TypeDefIndex: 4922
			{
				// Fields
				public Vector2 pos2d; // 0x10
				public float rotateY; // 0x18
				public float rotateX; // 0x1C

				// Constructors
				public PosRot_() {} // 0x007FC4A0-0x007FC4B0
			}

			[Serializable]
			public class NpcPosRot_ // TypeDefIndex: 4923
			{
				// Fields
				public string symbol; // 0x10
				public PosRot_ posRot; // 0x18

				// Constructors
				public NpcPosRot_() {} // 0x007FC4B0-0x007FC520
			}

			// Constructors
			public SuspendMap() {} // 0x007FC2A0-0x007FC370
		}

		[Serializable]
		public class SuspendGonbe // TypeDefIndex: 4924
		{
			// Fields
			public int gonbeEventType; // 0x10
			public int gonbeStep; // 0x14
			public Vector3 lastPos; // 0x18

			// Constructors
			public SuspendGonbe() {} // 0x007FC370-0x007FC380
		}

		// Constructors
		public GroundLocalSaveData() {} // 0x007FC380-0x007FC4A0

		// Methods
		public void Reset() {} // 0x007F5740-0x007F5810
		public void SetSuspend(SuspendMode mode) {} // 0x007FC1E0-0x007FC1F0
		public void ClearSuspend() {} // 0x007FC1F0-0x007FC2A0
	}

	private class SuspendVisibleInfo_ // TypeDefIndex: 4925
	{
		// Fields
		public List<ActObjBase> suspendActObjList_; // 0x10
		public Vector3 camPos; // 0x18
		public Quaternion camRot; // 0x24
		public float camFov; // 0x34
		public float camNear; // 0x38
		public float camFar; // 0x3C

		// Constructors
		public SuspendVisibleInfo_() {} // 0x007FDD60-0x007FDEC0

		// Methods
		public void Clear() {} // 0x007FDD00-0x007FDD60
	}

	private class MapInfo_ // TypeDefIndex: 4926
	{
		// Fields
		public string mapId; // 0x10
		public List<ActAssetSet> actAssetSetList; // 0x18

		// Constructors
		public MapInfo_() {} // 0x007FCC40-0x007FCCC0
	}

	private enum GroundMode_ // TypeDefIndex: 4927
	{
		Wait = 0,
		PlayerControl = 1
	}

	private struct ContanctInfo_ // TypeDefIndex: 4928
	{
		// Fields
		public ActObjCharactor ch0; // 0x10
		public ActObjCharactor ch1; // 0x18
	}

	private class CollisionCharaSet_ // TypeDefIndex: 4929
	{
		// Fields
		public ActObjCharactor player; // 0x10
		public ActObjCharactor follow; // 0x18
		public List<ActObjCharactor> playerLst; // 0x20
		public List<ActObjCharactor> followLst; // 0x28
		public List<ActObjCharactor> fixCharaLst; // 0x30
		public List<ActObjCharactor> moveCharaLst; // 0x38

		// Constructors
		public CollisionCharaSet_() {} // 0x007F7A60-0x007F7B90

		// Methods
		public void Clear() {} // 0x007F6260-0x007F62E0
		public bool CheckHit(Vector3 checkPos, ActObjCharactor checkCh) => default; // 0x007F62E0-0x007F6A70
		public bool CheckHit(Vector3 checkPos, Vector3 toPos, ActObjCharactor checkCh) => default; // 0x007F6A70-0x007F7160
		public bool CheckHit_FixedCharaOnly(Vector3 checkPos, ActObjCharactor checkCh) => default; // 0x007F73E0-0x007F7710
		public bool CheckHit_FixedCharaOnly(Vector3 checkPos, Vector3 toPos, ActObjCharactor checkCh) => default; // 0x007F7710-0x007F7A50
		private bool CheckHit_CircleLine_(Vector2 lineS, Vector2 lineE, Vector2 circleP, float circleRadius) => default; // 0x007F7160-0x007F73E0
		private float Vector2Cross(Vector2 v1, Vector2 v2) => default; // 0x007F7A50-0x007F7A60
	}

	private struct TalkInfo_ // TypeDefIndex: 4930
	{
		// Fields
		public string symbol; // 0x10
		public float score; // 0x18
		public Vector3 manpuPos; // 0x1C
		public bool isChara; // 0x28

		// Methods
		public bool IsValid() => default; // 0x007FDEC0-0x007FDED0
	}

	private class TalkWork_ // TypeDefIndex: 4931
	{
		// Fields
		private ActObjCharactor actCh_Player_; // 0x10
		private List<ActAsset_Base> enumAssetLst_; // 0x18
		private List<ActObjBase> enumActObjList_; // 0x20
		private List<TalkInfo_> resultCache_; // 0x28

		// Constructors
		public TalkWork_() {} // 0x00800E30-0x00800EB0

		// Methods
		public void Setup(ActObjCharactor actCh_Player) {} // 0x007FFB00-0x007FFBA0
		public List<TalkInfo_> processTalkListup_(GroundParam param, out TalkInfo_ manpuTarget) {
			manpuTarget = default;
			return default;
		} // 0x007FFBA0-0x00800850
		public TalkInfo_ FindTalkInfoBySymbol_(string symbol) => default; // 0x00800850-0x00800E30
	}

	private class TalkManpu_ // TypeDefIndex: 4933
	{
		// Fields
		private Canvas makerCanvas_; // 0x10
		private GameObject Marker_Info_; // 0x18
		private GameObject Marker_Talk_; // 0x20
		private GameObject Marker_Talk_important_; // 0x28
		private Vector3 talkMarkPos_; // 0x30
		private string lastTalkSymbol_; // 0x40
		private float fadeTime_; // 0x48
		private float fadeNow_; // 0x4C
		private Dictionary<string, GameObject> Marker_Talk_Important_mark_; // 0x50
		private Dictionary<string, Vector3> importantMarkPos_; // 0x58
		private Dictionary<string, bool> importantMarkFlag_; // 0x60
		private bool bTerminate_; // 0x68

		// Constructors
		public TalkManpu_() {} // 0x007FF3A0-0x007FF470

		// Methods
		public void Setup() {} // 0x007FDED0-0x007FE210
		private void SetActiveRenderer_(GameObject go, bool bActive) {} // 0x007FE480-0x007FE600
		private bool IsActiveRenderer_(GameObject go) => default; // 0x007FE670-0x007FE6F0
		public void Terminate() {} // 0x007FE210-0x007FE480
		public void SetTalkManpu(string symbol, Vector3 pos, bool bChara) {} // 0x007FE8A0-0x007FEBA0
		public void ResetTalkManpu() {} // 0x007FB0B0-0x007FB0F0
		public void SetImportantManpu(string name, Vector3 pos) {} // 0x007FEBA0-0x007FED90
		public void ClearImportantManpu(string name) {} // 0x007FED90-0x007FEEA0
		public void UnvisibleImportantManpu() {} // 0x007FEEA0-0x007FF030
		public void SuspendImportantManpu() {} // 0x007FF030-0x007FF1D0
		public void ResumeImportantManpu() {} // 0x007FF1D0-0x007FF370
		public void ClearImportantManpu() {} // 0x007FE6F0-0x007FE8A0
		// [IteratorStateMachine] // 0x00640B10-0x00640B80
		private IEnumerator LateUpdateTask_() => default; // 0x007FE600-0x007FE670
	}

	private class SubscenarioPartneTalkInfo_ // TypeDefIndex: 4935
	{
		// Fields
		public string stepSymbol; // 0x10
		public TextId textId; // 0x18

		// Constructors
		public SubscenarioPartneTalkInfo_() {} // 0x007FDCA0-0x007FDD00
	}

	private class TownNpcWork_ // TypeDefIndex: 4936
	{
		// Fields
		public GroundPlayer owner; // 0x10
		public GroundTownNpcDatabase.NpcData npcData; // 0x18
		public ActObjCharactor actCh; // 0x20
		public string refStepSymbolId; // 0x28
		public string talkScriptSymbol; // 0x30
		public ScriptData actScriptData; // 0x38
		public ScenePartitionBlob taikiActStartBlob; // 0x40
		public ScriptDataPlayer actScriptDataPlayer; // 0x48
		private Queue<ManualCoroutineTask> actionCoroutineQueue_; // 0x50
		private const float TurnWalkThresholdDeg_ = 10f; // Metadata: 0x00610D62
		private Vector2 initPos2d_; // 0x58
		private Mode_ curMode_; // 0x60
		private Mode_ requestMode_; // 0x64
		private bool bNowTalkTurn_; // 0x68
		private float lastYawDeg_; // 0x6C
		private float lastPitchDeg_; // 0x70
		private string lastContactChara_; // 0x78

		// Properties
		private bool IsRequestModeChange_ { get => default; } // 0x00807010-0x00807020 
		public bool IsTalkReady { get => default; } // 0x00803320-0x00803330 

		// Nested types
		private enum Mode_ // TypeDefIndex: 4937
		{
			None = 0,
			TaikiAct = 100,
			SleepTaikiAct = 110,
			TalkStartAct = 200,
			TalkReady = 300,
			Stop = 400
		}

		// Constructors
		public TownNpcWork_() {} // 0x00804780-0x00804820

		// Methods
		private void AddActionQueue_(IEnumerator action) {} // 0x00806F80-0x00807010
		public void Setup(ScriptData townNpcActSetScriptData) {} // 0x00804820-0x008049B0
		// [IteratorStateMachine] // 0x00640B80-0x00640BF0
		public IEnumerator SetupAfterLoad() => default; // 0x008049B0-0x00804A10
		public void Terminate() {} // 0x00806200-0x00806210
		public GroundLocalSaveData.SuspendMap.PosRot_ Suspend() => default; // 0x00801690-0x00801780
		public void Resume(GroundLocalSaveData.SuspendMap.PosRot_ posRot) {} // 0x00801290-0x008013B0
		public void ResetInitPos() {} // 0x00801780-0x008017A0
		public void RequestTaikiAct() {} // 0x007F9680-0x007F9690
		public void RequestTalkStartAct() {} // 0x00805510-0x00805520
		public void RequestSleepTaikiAct() {} // 0x00805960-0x00805970
		public void StopAct() {} // 0x007F9D20-0x007F9D30
		public bool IsStopAct() => default; // 0x007F9D30-0x007F9D40
		public void OnContactChara(ActObjCharactor otherActCh) {} // 0x00807100-0x00807130
		public void UpdateAct() {} // 0x00806430-0x008066C0
		// [IteratorStateMachine] // 0x00640BF0-0x00640C60
		private IEnumerator taikiAct_() => default; // 0x00807130-0x008071A0
		// [IteratorStateMachine] // 0x00640C60-0x00640CD0
		private IEnumerator sleepTaikiAct_() => default; // 0x008071A0-0x00807210
		// [IteratorStateMachine] // 0x00640CD0-0x00640D40
		private IEnumerator talkStartAct_() => default; // 0x00807210-0x00807280
		// [IteratorStateMachine] // 0x00640D40-0x00640DB0
		private IEnumerator DirReset_(float yawDeg, float pitchDeg) => default; // 0x00807310-0x00807390
		// [IteratorStateMachine] // 0x00640DB0-0x00640E20
		private IEnumerator DirTo_(Vector2 toPos2d) => default; // 0x008073C0-0x00807440
		// [IteratorStateMachine] // 0x00640E20-0x00640E90
		public IEnumerator RandomWalkAct(Func<bool> needExit) => default; // 0x00802C70-0x00802CF0
	}

	private class TownNpcWorkSet_ // TypeDefIndex: 4947
	{
		// Fields
		private GroundPlayer owner_; // 0x10
		private Dictionary<string, TownNpcWork_> townNpcWorkTbl_; // 0x18
		private bool bLoopRequestEnd_; // 0x20

		// Properties
		public Dictionary<string, TownNpcWork_> TownNpcWorkTbl { get => default; } // 0x007F9670-0x007F9680 

		// Constructors
		public TownNpcWorkSet_() {} // Dummy constructor
		public TownNpcWorkSet_(GroundPlayer owner) {} // 0x007F5810-0x007F58A0

		// Methods
		public bool HasPartnerTalkAction() => default; // 0x00800F40-0x00800FE0
		public void Resume(GroundLocalSaveData localSaveData) {} // 0x00801110-0x00801290
		public void Suspend(GroundLocalSaveData localSaveData) {} // 0x008013B0-0x00801690
		public void ResetInitPos() {} // 0x007F5B10-0x007F5C60
		public void Startup() {} // 0x007F58D0-0x007F59B0
		// [IteratorStateMachine] // 0x00640EB0-0x00640F20
		public IEnumerator Terminate() => default; // 0x007F5CD0-0x007F5D40
		// [IteratorStateMachine] // 0x00640F20-0x00640F90
		private IEnumerator UpdateLoop_() => default; // 0x008017A0-0x00801810
		private void ActObjUnloadEventHandler_(ActObjBase actObj) {} // 0x00801870-0x00801A90
		public bool CheckExistPartnerFollow(List<string> townNpcStepIdList) => default; // 0x00801A90-0x00801AC0
		public GroundTownNpcDatabase.NpcData FindPartnerNpcData(List<string> townNpcStepIdList) => default; // 0x00801AC0-0x00801E20
		// [IteratorStateMachine] // 0x00640F90-0x00641000
		public IEnumerator SetupNpcAct(string currentMapId, List<string> townNpcStepIdList) => default; // 0x00802200-0x00802280
		// [IteratorStateMachine] // 0x00641000-0x00641070
		public IEnumerator TerminateNpcAct() => default; // 0x008022B0-0x00802320
		// [IteratorStateMachine] // 0x00641070-0x006410E0
		public IEnumerator SetUseScriptMode(List<string> actSymbols) => default; // 0x00802350-0x008023D0
		// [IteratorStateMachine] // 0x006410E0-0x00641150
		public IEnumerator TalkBegin(GroundPlayContext context, GroundParam param, string talkActSymbol, Action talkOk) => default; // 0x00802400-0x00802490
		// [IteratorStateMachine] // 0x00641150-0x006411C0
		public IEnumerator TalkEnd(GroundPlayContext context, GroundParam param, ActObjCharactor actCh_Player, string talkActSymbol) => default; // 0x008024C0-0x00802540
		public void SetCurrentStepTalkOff(string talkActSymbol) {} // 0x00802570-0x00802730
		public string GetStepId(string talkActSymbol) => default; // 0x00802730-0x00802800
		// [IteratorStateMachine] // 0x006411C0-0x00641230
		private IEnumerator partnerTalk_(GroundPlayContext context, GroundParam param, List<string> scriptPathLst) => default; // 0x00802800-0x00802890
		// [IteratorStateMachine] // 0x00641230-0x006412A0
		public IEnumerator RandomWalkAct(string actSymbol, Func<bool> needExit) => default; // 0x007F3580-0x007F3600
		public bool IsGonbeAct() => default; // 0x008028F0-0x008029F0
	}

	private class PartyNpcWork_ // TypeDefIndex: 4961
	{
		// Fields
		public Dictionary<string, ActObjCharactor> partyNpcTbl; // 0x10

		// Constructors
		public PartyNpcWork_() {} // 0x007F5A90-0x007F5B00

		// Methods
		// [IteratorStateMachine] // 0x006412A0-0x00641310
		public IEnumerator Startup() => default; // 0x007FCCC0-0x007FCD30
		// [IteratorStateMachine] // 0x00641310-0x00641380
		public IEnumerator Talk(Vector2 tgtPos2d, string symbol) => default; // 0x007FCD60-0x007FCDF0
	}

	private class GonbeWork_ // TypeDefIndex: 4965
	{
		// Fields
		private GroundPlayer owner_; // 0x10
		private bool bLoopRequestEnd_; // 0x18
		private GonbeStep gonbeStep_; // 0x1C
		private GonbeEventType gonbeEventType_; // 0x20
		private Vector2 gonbeLastPos_; // 0x24
		private ActObjCharactor actChGonbe_; // 0x30
		private ActObjGimmick actObjApple_; // 0x38
		private ActAsset_Point point_start_; // 0x40
		private ActAsset_Point point_event_; // 0x48
		private ActAsset_Point point_end_; // 0x50
		private ActAsset_Point point_leaveLeft_; // 0x58
		private ActAsset_Point point_leaveRight_; // 0x60
		private ActAsset_Point point_dropItem_; // 0x68
		private ActAsset_MoveArea gonbe_event_area_; // 0x70
		private bool bTalkRequest_; // 0x78
		private bool bTalking_; // 0x79

		// Nested types
		public enum GonbeStep // TypeDefIndex: 4966
		{
			PreStart = 0,
			ReadyStart = 1,
			WalkToEvent = 2,
			Event = 3,
			Kokeru_ItemPickup = 4,
			Haraheri_Walk = 5,
			EventAfterWalk_Good = 6,
			EventAfterWalk_Bad = 7,
			EventAfterWalk_None = 8,
			LeaveWalkLeft = 9,
			LeaveWalkRight = 10,
			End = 11
		}

		public enum GonbeEventType // TypeDefIndex: 4967
		{
			Haraheri = 0,
			Kokeru = 1
		}

		public enum GonbeWalkType // TypeDefIndex: 4968
		{
			Normal = 0,
			Sad = 1,
			GoPickUp = 2
		}

		// Constructors
		public GonbeWork_() {} // Dummy constructor
		public GonbeWork_(GroundPlayer owner) {} // 0x007F58A0-0x007F58D0

		// Methods
		public bool IsRun() => default; // 0x007F7B90-0x007F7BB0
		public void Startup() {} // 0x007F59B0-0x007F5A90
		// [IteratorStateMachine] // 0x00641380-0x006413F0
		public IEnumerator Terminate() => default; // 0x007F5C60-0x007F5CD0
		public void Resume(GroundLocalSaveData localSaveData) {} // 0x007F7C50-0x007F7D20
		public void Suspend(GroundLocalSaveData localSaveData) {} // 0x007F7D20-0x007F7DE0
		private void GonbeLottery_() {} // 0x007F7DE0-0x007F8100
		// [IteratorStateMachine] // 0x006413F0-0x00641460
		public IEnumerator SetupNpc(Dictionary<string, List<string>> nextFlowCondTbl, bool bGonbeAct, bool bNeedRingLoad) => default; // 0x007F8100-0x007F81A0
		private void SetupPoints_() {} // 0x007F81D0-0x007F8330
		// [IteratorStateMachine] // 0x00641460-0x006414D0
		public IEnumerator PlayGonbeScript(string scene, GroundPlayContext context, bool bSetGroundMode = true /* Metadata: 0x00610D7E */) => default; // 0x007F8330-0x007F83C0
		public void OnDayStart() {} // 0x007F83F0-0x007F8400
		public void OnJumpMap() {} // 0x007F8400-0x007F8420
		public void OnWorldMap() {} // 0x007F8560-0x007F8580
		public void ForceStop(bool bForce = false /* Metadata: 0x00610D7F */) {} // 0x007F8420-0x007F8560
		// [IteratorStateMachine] // 0x006414D0-0x00641540
		public IEnumerator OnTalkNpc(Action talkOk, GroundPlayContext context) => default; // 0x007F8580-0x007F8600
		// [IteratorStateMachine] // 0x00641540-0x006415B0
		private IEnumerator AllNpcFurimuki_(GroundPlayContext context) => default; // 0x007F8630-0x007F86B0
		// [IteratorStateMachine] // 0x006415B0-0x00641620
		private IEnumerator AllNpcFurimukiReturn_(GroundPlayContext context) => default; // 0x007F86E0-0x007F8750
		// [IteratorStateMachine] // 0x00641620-0x00641690
		public IEnumerator OnUpdateFreeMove(GroundPlayContext context, TalkManpu_ talkManpu, Action endCb) => default; // 0x007F8780-0x007F8810
		// [IteratorStateMachine] // 0x00641690-0x00641700
		private IEnumerator UpdateLoop_() => default; // 0x007F7BB0-0x007F7C20
		// [IteratorStateMachine] // 0x00641700-0x00641770
		private IEnumerator Act_GonbeMove_(ActAsset_Point toPoint, Vector2 offset, float speedPerSec, GonbeWalkType walkType, Action toGoalCb, Action loopCb) => default; // 0x007F8870-0x007F8930
		private bool CheckGonbeCamearaIn_() => default; // 0x007F8960-0x007F8A90
		private bool CheckGonbeEventAreaIn_() => default; // 0x007F8A90-0x007F8B50
		// [IteratorStateMachine] // 0x00641770-0x006417E0
		private IEnumerator Furimuki_(bool bGonbeFurimuki) => default; // 0x007F8B50-0x007F8BD0
	}

	// Constructors
	public GroundPlayer() {} // 0x0073E0C0-0x0073EDE0
	static GroundPlayer() {} // 0x0073EDE0-0x0073EE60

	// Methods
	private void logCallback_(string str) {} // 0x00736160-0x007361E0
	private void logErrorCallback_(string str) {} // 0x007361E0-0x00736260
	// [IteratorStateMachine] // 0x0061C340-0x0061C3B0
	private IEnumerator playerExecute_(GroundParam param, Action stepCb, Action<GroundResult> endCb) => default; // 0x00736260-0x007362F0
	private static void startCoroutine_(IEnumerator co) {} // 0x007362F0-0x00736370
	public static bool CalcHeroMapCameraState(out Vector3 pos, out Quaternion rot, out float nearClipPlane, out float farClipPlane, out float fieldOfView) {
		pos = default;
		rot = default;
		nearClipPlane = default;
		farClipPlane = default;
		fieldOfView = default;
		return default;
	} // 0x00736370-0x007364E0
	public static bool FindPlayerSyncTargetAndMixier(out ActPlayerSyncTarget syncTarget, out PegaCM_GroundMixingCamera groundMixer) {
		syncTarget = default;
		groundMixer = default;
		return default;
	} // 0x007364E0-0x00736700
	public void Play(GroundParam param, Action stepCb, Action<GroundResult> endCb) {} // 0x00736700-0x00736860
	public void Stop() {} // 0x00736880-0x007368A0
	public void SuspendVisible() {} // 0x00732060-0x00732480
	public void ResumeVisible() {} // 0x00732500-0x00732890
	// [IteratorStateMachine] // 0x0061C3B0-0x0061C420
	public IEnumerator SetActChara_UseScriptMode(List<string> actSymbol) => default; // 0x00736910-0x00736990
	public void ClearLog() {} // 0x007369A0-0x007369F0
	public static Dictionary<string, List<string>> ParseFlowCondition(string nextFlowCond) => default; // 0x007369F0-0x00736C30
	public void SetTalkManpuVisible(bool bVisible) {} // 0x00736C30-0x00736C50
	public void TownNpc_ResetInitPos() {} // 0x00736C50-0x00736C60
	// [IteratorStateMachine] // 0x0061C420-0x0061C490
	private IEnumerator groundMain_(GroundPlayContext context, GroundParam param, Func<bool> isNeedExit) => default; // 0x00736C60-0x00736CF0
	// [IteratorStateMachine] // 0x0061C490-0x0061C500
	private IEnumerator BuildMapInfoTable_(GroundParam param, Action<Dictionary<string, MapInfo_>> result) => default; // 0x00736CF0-0x00736D70
	// [IteratorStateMachine] // 0x0061C500-0x0061C570
	private IEnumerator UpdateBuildMapInfoTable_(GroundParam param, Dictionary<string, MapInfo_> mapInfoTbl) => default; // 0x00736D70-0x00736DF0
	// [IteratorStateMachine] // 0x0061C570-0x0061C5E0
	private IEnumerator OneDayHalfFlow_(GroundPlayContext context, GroundParam param, Dictionary<string, List<string>> nextFlowCondTbl, bool bContinueAssetInDayHalf, Func<bool> isExitFlowLoop, Action<bool> exitFlowLoop, Action<Const.dungeon.Index> resultDgIndexCb) => default; // 0x00736DF0-0x00736EB0
	// [IteratorStateMachine] // 0x0061C5E0-0x0061C650
	private IEnumerator OneDayHalfFlow_SubScenarioEndDay_(GroundPlayContext context) => default; // 0x00736EB0-0x00736F30
	// [IteratorStateMachine] // 0x0061C650-0x0061C6C0
	private IEnumerator Shop_Perippaa_(GroundPlayContext context, GroundParam param, FlowPlay.FlowPlayParam shopFlowParam) => default; // 0x00736F30-0x00736FC0
	// [IteratorStateMachine] // 0x0061C6C0-0x0061C730
	private IEnumerator Shop_Makunoshita_(GroundPlayContext context, FlowPlay.FlowPlayParam shopFlowParam) => default; // 0x00736FC0-0x00737030
	// [IteratorStateMachine] // 0x0061C730-0x0061C7A0
	private IEnumerator HanyouNextDayWithDgFlow_(GroundPlayContext context, Const.dungeon.Index dgIndex, GroundParam param, Dictionary<string, List<string>> nextFlowCondTbl, Action setNotContinueAsset, Action<bool> resultIsExitFlow) => default; // 0x00737030-0x007370E0
	// [IteratorStateMachine] // 0x0061C7A0-0x0061C810
	private IEnumerator DayStartFlow_(GroundPlayContext context, GroundParam param, Action<string> needContinue) => default; // 0x007370E0-0x00737170
	// [IteratorStateMachine] // 0x0061C810-0x0061C880
	private IEnumerator HanyouHaitatsu_(Action<string> needContinue) => default; // 0x00737170-0x007371E0
	// [IteratorStateMachine] // 0x0061C880-0x0061C8F0
	private IEnumerator DungeonNormal_(Const.dungeon.Index dgIndex, DungeonStartMode startMode, Action<Const.DungeonResult> resultCb) => default; // 0x007371E0-0x00737260
	private void UpdatePostLetterVisible_(GroundParam param) {} // 0x00737260-0x00737330
	private void SetGroundMode_(GroundMode_ groundMode, GroundPlayContext context, bool bResetCamHero = true /* Metadata: 0x00610CA0 */) {} // 0x007375B0-0x00737C90
	private void SetupFollowCamera_() {} // 0x00738090-0x00738670
	private void ResetCamToHero_() {} // 0x00737C90-0x00738090
	private void SetHeroPartnerPos_(GroundPlayContext context, Vector2 tgtCenterPos, float yawRot) {} // 0x00738670-0x00738E60
	private void JumpToPlayerPartnerPos_(GroundPlayContext context, ActAsset_Trigger JumpToTrigger) {} // 0x00738E60-0x00738F30
	private void WalkToPlayerPartnerPos_(GroundPlayContext context, ActAsset_Trigger WalkToTrigger) {} // 0x00738F30-0x00739000
	// [IteratorStateMachine] // 0x0061C8F0-0x0061C960
	private IEnumerator TrigStopAutoWalk_(GroundPlayContext context, ActAsset_Trigger actTrig, float fadeOutTime, bool bWithBgm) => default; // 0x00739000-0x007390A0
	// [IteratorStateMachine] // 0x0061C960-0x0061C9D0
	private IEnumerator TrigStartAutoWalk_(GroundPlayContext context, ActAsset_Trigger actTrig) => default; // 0x007390A0-0x00739120
	private void CharaCollExtrudeMove_(ActObjCharactor reActionCh, List<ActObjCharactor> collisionList, int start, int end, int retryCount, ref List<ContanctInfo_> contactList, float addRadious = 0f /* Metadata: 0x00610CA1 */) {} // 0x00739120-0x007394F0
	private void CharaCollExtrudeMove_(ActObjCharactor reActionCh, ActObjCharactor collision, int retryCount, ref List<ContanctInfo_> contactList) {} // 0x007394F0-0x00739800
	private void Setup_Update_CharaCollision_(GroundPlayContext context) {} // 0x00739800-0x0073A1D0
	private void Update_CharaCollision_(GroundPlayContext context) {} // 0x0073A1D0-0x0073B540
	private void ForceExtrusion_PlayerCharaCollision_(GroundPlayContext context) {} // 0x0073BA30-0x0073C1C0
	public void NextDay() {} // 0x00731FC0-0x00731FE0
	public int GetMankiiCount() => default; // 0x0073C1C0-0x0073C1E0
	public void IncMankiiCount() {} // 0x0073C1E0-0x0073C200
	public bool HasPartnerTalkAction() => default; // 0x00737590-0x007375B0
	// [IteratorStateMachine] // 0x0061C9D0-0x0061CA40
	public IEnumerator TownNpcRandomWalkAct(string actSymbol, Func<bool> needExit) => default; // 0x0073C200-0x0073C280
	public void PlayGroundBgm(string bgmSymbol, BGMChannel channel, float fSec) {} // 0x0073C280-0x0073C3A0
	public bool CheckHit_CharaCollision(Vector3 checkPos, ActObjCharactor checkHit) => default; // 0x0073C520-0x0073C540
	public bool CheckHit_CharaCollision(Vector3 checkPos, Vector3 toPos, ActObjCharactor checkHit) => default; // 0x0073C540-0x0073C560
	public bool CheckHit_CharaCollision_FixedCharaOnly(Vector3 checkPos, ActObjCharactor checkHit) => default; // 0x0073C560-0x0073C580
	public bool CheckHit_CharaCollision_FixedCharaOnly(Vector3 checkPos, Vector3 toPos, ActObjCharactor checkHit) => default; // 0x00734220-0x00734240
	private void ToScript_BgmChannelSwap_() {} // 0x0073C3A0-0x0073C520
	private void PlayBgm_(string bgmSymbol, float volume, float fadeoutTime) {} // 0x0073C580-0x0073C920
	// [IteratorStateMachine] // 0x0061CA40-0x0061CAB0
	private IEnumerator StopBgmAndWait_(float fadeTime) => default; // 0x0073C920-0x0073C990
	private void StopBgm_(float fadeTime) {} // 0x0073C990-0x0073CA60
	// [IteratorStateMachine] // 0x0061CAB0-0x0061CB20
	private IEnumerator StopBgmWait_() => default; // 0x0073CA60-0x0073CAC0
	private string FilterBgmSymbol_(GroundParam param, string bgm) => default; // 0x0073CAC0-0x0073CB90
	private void UpdateMapBgm_(MapInfo_ currentMapInfo, GroundParam param) {} // 0x0073CB90-0x0073DBA0
	// [IteratorStateMachine] // 0x0061CB20-0x0061CB90
	private IEnumerator DispDebugMessage_(TextId textId) => default; // 0x0073DBA0-0x0073DC10
	// [IteratorStateMachine] // 0x0061CB90-0x0061CC00
	private IEnumerator DispErrorMessage_(TextId textId) => default; // 0x0073DC10-0x0073DC80
	// [IteratorStateMachine] // 0x0061CC00-0x0061CC70
	private IEnumerator HeroPartnerFurimuki_(GroundPlayContext context, Vector2 pos, bool bWait) => default; // 0x0073DC80-0x0073DD10
	// [IteratorStateMachine] // 0x0061CC70-0x0061CCE0
	private IEnumerator PlaySimpleSubFlow_(GroundParam param, string subFlowName, Action playSubflowEndCb) => default; // 0x0073DD10-0x0073DD90
	// [IteratorStateMachine] // 0x0061CCE0-0x0061CD50
	private IEnumerator PlayMessageScript_(GroundPlayContext context, string scriptPath, string scenePartitionLabel) => default; // 0x0073DD90-0x0073DE20
	// [IteratorStateMachine] // 0x0061CD50-0x0061CDC0
	private IEnumerator PlayMessageScript_(GroundPlayContext context, List<string> scriptPathLst, string scenePartitionLabel) => default; // 0x0073DE20-0x0073DEB0
	// [IteratorStateMachine] // 0x0061CDC0-0x0061CE30
	private static IEnumerator PlayScript_(string relPath, string sceneName) => default; // 0x0073DEB0-0x0073DF30
	// [IteratorStateMachine] // 0x0061CE30-0x0061CEA0
	private static IEnumerator PlayScriptWithStartSceneName_(string relPath, string sceneName) => default; // 0x0073DF30-0x0073DFB0
	// [IteratorStateMachine] // 0x0061CEA0-0x0061CF10
	private static IEnumerator PlayScript_(string relPath, string sceneName, bool sceneNameIsStartBlob, Func<bool> needExit) => default; // 0x0073DFB0-0x0073E050
	// [IteratorStateMachine] // 0x0061CF10-0x0061CF80
	public IEnumerator OnPlayerTurnInput_Shortcut(int shortcut_no) => default; // 0x0073E050-0x0073E0C0
}

