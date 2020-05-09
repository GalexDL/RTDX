/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.dungeon;
using Const.dungeon.status;
using Const.pokemon;
using Const.waza;
using dungeon;
using kamina.graphics;
using pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonEngine : MonoBehaviour, IMainFiberUnityDungeonEngineInterrupt // TypeDefIndex: 5861
{
	// Fields
	private static DungeonEngine s_insntance; // 0x00
	private DungeonParameter m_dungeonParameter; // 0x18
	private DungeonTopScreen m_dungeonTopScreen; // 0x20
	private GameSystem m_gameSystem; // 0x28
	private GameData m_gameData; // 0x30
	private GameObject m_myObject; // 0x38
	private GameObject m_bannerObject; // 0x40
	private GameObject m_fpsDispObject; // 0x48
	private GameObject m_TargetEnemyObject; // 0x50
	private GameObject m_diagonalArrow; // 0x58
	private DungeonTrainingScreen m_dungeonTrainingScreen; // 0x60
	private SampleTopUI m_sampleUI; // 0x68
	private int m_sampleTopType; // 0x70
	private int m_sampleTopPrevType; // 0x74
	private float m_fBannerSec; // 0x78
	private float m_fBannerSecBase; // 0x7C
	private BootMode m_bootMode; // 0x80
	private bool m_bDungeonEnd; // 0x84
	private bool m_bPrevAutoMapVisible; // 0x85
	private Vector3 m_savePrevCameraLocalPosition; // 0x88
	private Quaternion m_savePrevCameraLocalRotation; // 0x94
	private List<string> m_listDungeonResidentResource; // 0xA8
	public bool isUpdateGridOption; // 0xB0
	private bool isDisplayTypeIcon; // 0xB1
	private Dictionary<ulong, TypeIconInfo> typeIcons; // 0xB8
	private LookAroundDisplayMode aroundDisplayMode; // 0xC0
	private bool isShortcutAutoMode; // 0xC4

	// Properties
	public static bool IsValid { get => default; } // 0x007BA190-0x007BA210 
	public static DungeonEngine Instance { get => default; } // 0x007BA210-0x007BA260 
	public BootMode NowBootMode { get => default; } // 0x007BA260-0x007BA270 
	public GameObject BannerObject { get => default; } // 0x007BA270-0x007BA280 
	public DungeonTopScreen TopScreen { get => default; } // 0x007BA280-0x007BA290 
	public DungeonTrainingScreen TrainingScreen { get => default; } // 0x007BA290-0x007BA2A0 
	public DiagonalArrow Diagonal { get => default; } // 0x007BA2A0-0x007BA2F0 

	// Nested types
	public enum BootMode // TypeDefIndex: 5862
	{
		NORMAL = 0,
		DEBUG = 1,
		WAZA_VIEWER = 2
	}

	private struct TypeIconInfo // TypeDefIndex: 5863
	{
		// Fields
		public GameObject obj; // 0x10
		public Const.pokemon.Type type1; // 0x18
		public Const.pokemon.Type type2; // 0x1C
	}

	[Serializable]
	public class ResultProcessParameter // TypeDefIndex: 5864
	{
		// Fields
		public bool bItemAndMoneyPenalty; // 0x10
		public bool bQuestPenaltyExecuted; // 0x11
		public DungeonResultParameter resultParameter; // 0x18

		// Constructors
		public ResultProcessParameter() {} // 0x007C2B50-0x007C2BC0

		// Methods
		public void Clear() {} // 0x007C2BC0-0x007C2BD0
		public bool IsNeedResultProcess() => default; // 0x007CD990-0x007CDA10
	}

	// Constructors
	public DungeonEngine() {} // 0x007BEB70-0x007BEC70

	// Methods
	// [IteratorStateMachine] // 0x006222B0-0x00622320
	public static IEnumerator Execute(DungeonParameter dungeonParameter) => default; // 0x007BA2F0-0x007BA360
	// [IteratorStateMachine] // 0x00622320-0x00622390
	public static IEnumerator ExecuteWazaViewer() => default; // 0x007BA390-0x007BA3F0
	// [IteratorStateMachine] // 0x00622390-0x00622400
	private IEnumerator LoadResident() => default; // 0x007BA420-0x007BA490
	private void DestroyResident() {} // 0x007BA4C0-0x007BA630
	private static void Startup(BootMode bootMode) {} // 0x007BA630-0x007BA800
	private static void Shutdown() {} // 0x007BA800-0x007BA9A0
	private static void Destroy(ref DungeonEngine dungeon) {} // 0x007BA9A0-0x007BAA20
	private void SafeDestroyCanvasObject(ref GameObject obj) {} // 0x007BAA20-0x007BAB50
	private void OnDestroy() {} // 0x007BAB50-0x007BAC80
	public void OnApplicationQuit() {} // 0x007BAC80-0x007BAC90
	// [IteratorStateMachine] // 0x00622400-0x00622470
	private IEnumerator Initialize_() => default; // 0x007BAC90-0x007BAD00
	// [IteratorStateMachine] // 0x00622470-0x006224E0
	private IEnumerator Finalize_(Color prevBackGroundColor) => default; // 0x007BAD30-0x007BADD0
	// [IteratorStateMachine] // 0x006224E0-0x00622550
	public IEnumerator WaitNativeIdle() => default; // 0x007BAE00-0x007BAE60
	public bool IsDungeonEnd() => default; // 0x007BAE90-0x007BAEA0
	public void EnableGraphicsSetting() {} // 0x007BAEA0-0x007BAFD0
	public void DisableGraphicsSetting() {} // 0x007BAFD0-0x007BB100
	private bool IsPlayerAutoWalk() => default; // 0x007BB100-0x007BB170
	// [IteratorStateMachine] // 0x00622550-0x006225C0
	private IEnumerator ExecuteLanguageSelect() => default; // 0x007BB170-0x007BB1D0
	// [IteratorStateMachine] // 0x006225C0-0x00622630
	public IEnumerator OnPlayerTurnInput(NormalInputInParameter inParameter) => default; // 0x007BB200-0x007BB280
	// [IteratorStateMachine] // 0x00622630-0x006226A0
	public IEnumerator OnPlayerTurnInput_WazaShortcutMenu() => default; // 0x007BB2B0-0x007BB310
	// [IteratorStateMachine] // 0x006226A0-0x00622710
	public IEnumerator OnPlayerTurnInput_ACKCommand() => default; // 0x007BB340-0x007BB3A0
	// [IteratorStateMachine] // 0x00622710-0x00622780
	public IEnumerator OnPlayerTurnInput_DebugMenu() => default; // 0x007BB3D0-0x007BB430
	// [IteratorStateMachine] // 0x00622780-0x006227F0
	public IEnumerator OnPlayerTurnInput_Pause() => default; // 0x007BB460-0x007BB4C0
	// [IteratorStateMachine] // 0x006227F0-0x00622860
	private IEnumerator ExecuteItemMenu(Action<UIBasicItemBagMenu.Result> cb = null, bool singleCall = false /* Metadata: 0x00612250 */) => default; // 0x007BB4F0-0x007BB570
	// [IteratorStateMachine] // 0x00622860-0x006228D0
	public IEnumerator OnPlayerTurnInput_MainMenu() => default; // 0x007BB5A0-0x007BB610
	// [IteratorStateMachine] // 0x006228D0-0x00622940
	public IEnumerator OnPlayerTurnInput_CustomShortcutMenu() => default; // 0x007BB640-0x007BB6B0
	// [IteratorStateMachine] // 0x00622940-0x006229B0
	public IEnumerator OnPlayerTurnInput_Shortcut(int shortcut_no, Action<bool> resultCb) => default; // 0x007BB6E0-0x007BB760
	// [IteratorStateMachine] // 0x006229B0-0x00622A20
	public IEnumerator OnAutoSave() => default; // 0x007BB790-0x007BB7F0
	// [IteratorStateMachine] // 0x00622A20-0x00622A90
	public IEnumerator OnInterruptSaveWriteBuffer() => default; // 0x007BB820-0x007BB880
	// [IteratorStateMachine] // 0x00622A90-0x00622B00
	public IEnumerator OnInterruptSaveWriteBufferWait() => default; // 0x007BB8B0-0x007BB910
	public void OnCheckInitFloorForScriptEvent() {} // 0x007BB940-0x007BB960
	// [IteratorStateMachine] // 0x00622B00-0x00622B70
	public IEnumerator OnInitFloorForScriptEvent() => default; // 0x007BB960-0x007BB9D0
	// [IteratorStateMachine] // 0x00622B70-0x00622BE0
	public IEnumerator OnInitFloorResourceCacheClear() => default; // 0x007BBA00-0x007BBA60
	// [IteratorStateMachine] // 0x00622BE0-0x00622C50
	public IEnumerator SysMsg(TextIDHash hash) => default; // 0x007BBA90-0x007BBAF0
	// [IteratorStateMachine] // 0x00622C50-0x00622CC0
	public IEnumerator OnInitializeFloor_CheckQuest() => default; // 0x007BBB20-0x007BBB80
	// [IteratorStateMachine] // 0x00622CC0-0x00622D30
	public IEnumerator OnPokemonWazaLearn_OpenSelectMenu(WazaLearnSelectMenuOutParameter outParameter, WazaLearnSelectMenuInParameter inParameter) => default; // 0x007BBBB0-0x007BBC30
	public Const.dungeon.Index GetIndex() => default; // 0x007BBC60-0x007BBCD0
	public int GetCurrentFloor() => default; // 0x007BBCD0-0x007BBD40
	public uint GetCurrentSeed() => default; // 0x007BBD40-0x007BBD60
	public bool HasStatus(Const.dungeon.status.Index statusIndex) => default; // 0x007BBD60-0x007BBDD0
	public Const.dungeon.status.Index GetWeather() => default; // 0x007BBDD0-0x007BBE40
	public bool IsFriendRescueRequest() => default; // 0x007BBE40-0x007BBEB0
	public bool IsItemBring() => default; // 0x007BBEB0-0x007BBF70
	public bool IsDungeonGiveup() => default; // 0x007BBF70-0x007BBFE0
	public void Giveup(bool command) {} // 0x007BBFE0-0x007BC090
	public bool IsHonkiTrainingDungeon() => default; // 0x007BC090-0x007BC0A0
	// [IteratorStateMachine] // 0x00622D30-0x00622DA0
	public IEnumerator OnDungeonSuccessProduction(EventSuccessEventInParameter inParameter) => default; // 0x007BC0A0-0x007BC120
	// [IteratorStateMachine] // 0x00622DA0-0x00622E10
	public IEnumerator OnStagingPostResultProcess() => default; // 0x007BC150-0x007BC1C0
	// [IteratorStateMachine] // 0x00622E10-0x00622E80
	public IEnumerator OnEndFloor_Dead() => default; // 0x007BC1F0-0x007BC250
	// [IteratorStateMachine] // 0x00622E80-0x00622EF0
	public IEnumerator OnEndFloor_GiveUp() => default; // 0x007BC280-0x007BC2E0
	// [IteratorStateMachine] // 0x00622EF0-0x00622F60
	public IEnumerator OnEndFloor_Wind() => default; // 0x007BC310-0x007BC370
	// [IteratorStateMachine] // 0x00622F60-0x00622FD0
	public IEnumerator OnEndFloor_DungeonRescueRequest(RescueRequestOutParameter outParameter, RescueRequestInParameter inParameter) => default; // 0x007BC3A0-0x007BC420
	// [IteratorStateMachine] // 0x00622FD0-0x00623040
	public IEnumerator OnActBank_OpenSelectMenu(BankMenuOutParameter outParameter, BankMenuInParameter inParameter) => default; // 0x007BC450-0x007BC4D0
	// [IteratorStateMachine] // 0x00623040-0x006230B0
	public IEnumerator OnActRescueSociety_OpenSelectMenu(RescueSocietyMenuOutParameter outParameter, RescueSocietyMenuInParameter inParameter) => default; // 0x007BC500-0x007BC580
	// [IteratorStateMachine] // 0x006230B0-0x00623120
	public IEnumerator OnAutoFootMenu(AutoFootMenuOutParameter outParameter, AutoFootMenuInParameter inParameter) => default; // 0x007BC5B0-0x007BC630
	// [IteratorStateMachine] // 0x00623120-0x00623190
	public IEnumerator OnOpenTextInputWindow(WindowTextInputOutParameter outParameter, WindowTextInputInParameter inParameter) => default; // 0x007BC660-0x007BC6E0
	// [IteratorStateMachine] // 0x00623190-0x00623200
	public IEnumerator OnSelectSecessionMember(SelectSecessionMemberOutParameter outParameter, SelectSecessionMemberInParameter inParameter) => default; // 0x007BC710-0x007BC790
	// [IteratorStateMachine] // 0x00623200-0x00623270
	public IEnumerator OnOpenTempFriendWindow(TempPokemonWindowInParameter inParameter) => default; // 0x007BC7C0-0x007BC840
	// [IteratorStateMachine] // 0x00623270-0x006232E0
	public IEnumerator OnCloseTempFriendWindow() => default; // 0x007BC870-0x007BC8E0
	// [IteratorStateMachine] // 0x006232E0-0x00623350
	public IEnumerator OnStartTraining() => default; // 0x007BC910-0x007BC980
	// [IteratorStateMachine] // 0x00623350-0x006233C0
	public IEnumerator OnEndTraining() => default; // 0x007BC9B0-0x007BCA20
	// [IteratorStateMachine] // 0x006233C0-0x00623430
	public IEnumerator OnEffectNice() => default; // 0x007BCA50-0x007BCAC0
	// [IteratorStateMachine] // 0x00623430-0x006234A0
	public IEnumerator OnEffectCongratulations() => default; // 0x007BCAF0-0x007BCB60
	// [IteratorStateMachine] // 0x006234A0-0x00623510
	public IEnumerator OnShowLevelUpDialog(LevelUpDialogInParameter inParameter) => default; // 0x007BCB90-0x007BCC10
	public void SetAroundDislplayMode(LookAroundDisplayMode arg_mode) {} // 0x007BCC40-0x007BCC50
	private void clearTypeIcons() {} // 0x007BCC50-0x007BCE30
	// [IteratorStateMachine] // 0x00623510-0x00623580
	public IEnumerator OnDirectionMove(DirectionMoveInputOutParameter outParameter, DirectionMoveInputInParameter inParameter) => default; // 0x007BCE30-0x007BCEB0
	// [IteratorStateMachine] // 0x00623580-0x006235F0
	public IEnumerator OnLookAround(LookAroundInputOutParameter outParameter, LookAroundInputInParameter inParameter) => default; // 0x007BCEE0-0x007BCF60
	private void updateAroundViewTypeIcon() {} // 0x007BCF90-0x007BDB90
	private void hideAroundViewTypeIcon() {} // 0x007BDB90-0x007BDD60
	// [IteratorStateMachine] // 0x006235F0-0x00623660
	public IEnumerator OnTutorialJyoban(TutorialJyobanInParameter inParameter) => default; // 0x007BDD60-0x007BDDE0
	private void _animePlay(PegasusAnimationController ac, string motion, bool bLoop) {} // 0x007BDE10-0x007BDEB0
	// [IteratorStateMachine] // 0x00623660-0x006236D0
	private IEnumerator _moveNeck(CharacterModel cm, float pitchDeg, float startRatio, float endRatio, bool isWait, bool isReset) => default; // 0x007BDEB0-0x007BDF60
	// [IteratorStateMachine] // 0x006236D0-0x00623740
	public IEnumerator OnPlayBeginBanner(Action endCb, float fSec) => default; // 0x007BDF90-0x007BE020
	// [IteratorStateMachine] // 0x00623740-0x006237B0
	public IEnumerator OnPlayFadeBGBanner(Action endCb, float fSec) => default; // 0x007BE050-0x007BE0E0
	// [IteratorStateMachine] // 0x006237B0-0x00623820
	public IEnumerator OnPlayEndBanner(Action endCb, float fSec) => default; // 0x007BE110-0x007BE1A0
	private void UpdateDungeonParameterFromNative(DungeonParameter dungeonParameter) {} // 0x007BE1D0-0x007BE1E0
	private void GetDungeonParameterBackup(DungeonParameter dungeonParameter) {} // 0x007BE1E0-0x007BE1F0
	// [IteratorStateMachine] // 0x00623820-0x00623890
	public static IEnumerator ExecuteResultProcess(ResultProcessParameter param) => default; // 0x007BE1F0-0x007BE260
	// [IteratorStateMachine] // 0x00623890-0x00623900
	public IEnumerator MainLoop(DungeonParameter dungeonParameter) => default; // 0x007BE290-0x007BE310
	private void doInput() {} // 0x007BE340-0x007BE410
	private bool doTopMenu() => default; // 0x007BE410-0x007BE420
	public bool IsKunrenMode() => default; // 0x007BE420-0x007BE490
	public bool IsHonkinoKunrenMode() => default; // 0x007BE490-0x007BE530
	public bool IsManabinoKunrenMode() => default; // 0x007BE530-0x007BE5D0
	public bool IsIgnoreQuestMode() => default; // 0x007BE5D0-0x007BE680
	private void Update() {} // 0x007BE680-0x007BE6D0
	private void LateUpdate() {} // 0x007BE6D0-0x007BE780
	public bool CheckShortcutAutoMode() => default; // 0x007BE780-0x007BE790
	public void ClearShortcutAutoMode() {} // 0x007BE790-0x007BE7A0
	public bool checkLeaderChangeAvailable() => default; // 0x007BE7A0-0x007BE9B0
	public bool IsEnableLeaderChange() => default; // 0x007BE9B0-0x007BEB00
	public void NaviGuideErase() {} // 0x007BEB00-0x007BEB70
}

