/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NatureDiagnosis : MonoBehaviour // TypeDefIndex: 5107
{
	// Fields
	private NatureDiagnosisToolBox m_toolBox; // 0x18
	private LayoutPattern presentLayout; // 0x20
	private SelectState heroSelect; // 0x24
	private SelectState partnerSelect; // 0x28
	private string[] Motions; // 0x30
	private int[] RandomMotionWaitRatio; // 0x38
	private bool[] bRondomMotionLoop; // 0x40
	private string[] Effects; // 0x48
	private int[] WaitFrames; // 0x50
	private static string[] DiagnosisMessage; // 0x00
	private Index[] TalkTypeMaleDefaultList; // 0x58
	private tempPokemonData m_hero; // 0x60
	private tempPokemonData m_partner; // 0x68
	private string m_partnerNickName; // 0x70
	private int m_numOfTimeButtonPressed; // 0x78
	private const int RepeatedHitsBorder = 30; // Metadata: 0x00610EFE
	private const int RepeatedHitsPoint = 3; // Metadata: 0x00610F02
	private int MaxDiagnosisNum; // 0x7C
	private Vector3[] constantPos; // 0x80
	private Quaternion[] constantRot; // 0x88
	private int targetNum; // 0x90
	private List<ActSymbol> actSymbolList; // 0x98
	private List<ActSymbol> actSymbolInvisibleList; // 0xA0
	private ActCharaParameter[] CharaParams; // 0xA8
	private bool bFinish; // 0xB0
	private bool bSceneLoaded; // 0xB1
	private bool enable; // 0xB2
	private bool bDeploy; // 0xB3
	private bool bDeployCursor; // 0xB4
	private bool bCount; // 0xB5
	private NDConverterSharedData.DataStore rootData; // 0xB8
	private List<NDConverterSharedData.DiagnosisStrage> diagnosisList; // 0xC0
	private List<NDConverterSharedData.PokemonStrage> candidatePartnerListData; // 0xC8
	private List<NDConverterSharedData.PokemonStrage> HeroListData; // 0xD0
	private int[] naturePointArray; // 0xD8
	private int cursorIndex; // 0xE0
	private NDHeroStatusDisplay heroStatusWindow; // 0xE8
	private GameObject root; // 0xF0
	private GameObject bg_default; // 0xF8
	private GameObject bg_flat; // 0x100
	private GameObject bg_bura; // 0x108
	private GameObject effectSet; // 0x110
	private GameObject bg_star; // 0x118
	private int xIndex; // 0x120
	private int yIndex; // 0x124
	private BMEffect liteEffectRef; // 0x128

	// Properties
	private NatureDiagnosisToolBox ToolBox { get => default; } // 0x0089C470-0x0089C480 

	// Nested types
	private class tempPokemonData // TypeDefIndex: 5108
	{
		// Fields
		public string symbolName; // 0x10
		public GenderType gender; // 0x18
		public NDConverterSharedData.PokemonStrage csvListData; // 0x20
		public NDConverterSharedData.NatureType natureType; // 0x28
		public Index index; // 0x2C

		// Constructors
		public tempPokemonData() {} // 0x0089C7C0-0x0089C840
	}

	private class OperateCharacter // TypeDefIndex: 5109
	{
		// Fields
		public string symbolName; // 0x10

		// Constructors
		public OperateCharacter(string symbol) {} // 0x008A5610-0x008A5640
		public OperateCharacter() {} // 0x008B1AA0-0x008B1AB0
	}

	private enum LayoutPattern // TypeDefIndex: 5110
	{
		NONE = 0,
		DEFAULT = 1,
		LACK_1 = 2,
		LACK_3 = 3,
		LACK_4 = 4
	}

	private enum SelectState // TypeDefIndex: 5111
	{
		NONE = 0,
		SELECT = 1,
		DECIDE = 2,
		MAX = 3
	}

	private enum PositionType // TypeDefIndex: 5112
	{
		STANDING_OUT = 0,
		STANDING_OUT_END_HERO = 1,
		STANDING_OUT_END_PARTNER = 2,
		DETERMINATE_HERO = 3,
		DETERMINATE_HERO_START = 4,
		DETERMINATE_HERO_END = 5,
		DETERMINATE_PARTNER = 6,
		DETERMINATE_PARTNER_START = 7,
		DETERMINATE_PARTNER_END = 8,
		CAMERA_POS = 9,
		MAX = 10
	}

	private enum MotionIndex // TypeDefIndex: 5113
	{
		WAIT02 = 0,
		WALK = 1,
		CONFIRMS = 2,
		SURPRIZE = 3,
		RUN = 4,
		RANDOM_MAX = 5,
		VICTORY = 6,
		LETSGO = 7,
		LANDING = 8,
		MAX = 9
	}

	private enum EffectIndex // TypeDefIndex: 5114
	{
		RING = 0,
		RING_ED = 1,
		RING_RAINBOW = 2,
		KIRAKIRA = 3,
		RAY_SELECT = 4,
		GLOW_BALL = 5,
		MAX = 6
	}

	private enum WaitIndex // TypeDefIndex: 5115
	{
		INTRODUCTION = 0,
		DIAGNOSIS_REACTION = 1,
		DIAGNOSIS_REACTION_LAST = 2,
		SELECT_RING = 3,
		SELECT_MOVE = 4,
		SELECT_DISPLAY = 5,
		AFTER_MOVE = 6,
		AFTER_END = 7
	}

	private enum DiagnosisEnum // TypeDefIndex: 5116
	{
		PKD1_COMMON_HEADER = 0,
		EXCEPTIONAL_QUESTION = 1,
		ADDITIONAL_QUESTION = 2,
		GENDER_QUESTION = 3,
		GENDER_ANS1 = 4,
		GENDER_ANS2 = 5,
		PATNER_NATURE_QUESTION = 6,
		PATNER_NATURE_ANS1 = 7,
		PATNER_NATURE_ANS3 = 8,
		DETERMINATE_QUESTION = 9,
		DETERMINATE_ANS1 = 10,
		DETERMINATE_ANS2 = 11,
		PARTNER_DETERMINATE_QUESTION = 12,
		PARTNER_DETERMINATE_ANS1 = 13,
		PARTNER_DETERMINATE_ANS2 = 14,
		PARTNER_CONFIRM_QUESTION1 = 15,
		PARTNER_CONFIRM_QUESTION2 = 16,
		PARTNER_CONFIRM_QUESTION3 = 17,
		PARTNER_CONFIRM_ANS1 = 18,
		PARTNER_CONFIRM_ANS2 = 19,
		PARTNER_NAME_DETERMINATE_QUESTION = 20,
		PARTNER_NAME_DETERMINATE_ANS1 = 21,
		PARTNER_NAME_DETERMINATE_ANS2 = 22,
		DIAGNOSIS_END = 23,
		DIAGNOSIS_RESULT = 24,
		PARTNER_SELECT = 25,
		PARTNER_NAMING = 26,
		COMPLETE = 27,
		DEBUG_PLEASE_WAIT = 28,
		HERO_SELECTING = 29,
		PARTNER_SELECTING = 30,
		PAIR_CONFIRM_QUESTION = 31,
		PAIR_CONFIRM_YES = 32,
		PAIR_CONFIRM_NO = 33
	}

	private class ActCharaParameter // TypeDefIndex: 5117
	{
		// Fields
		public GameObject centerPoint; // 0x10
		public GameObject footPoint; // 0x18
		public int playTime; // 0x20
		public int beforeIndex; // 0x24
		public float rot; // 0x28

		// Constructors
		public ActCharaParameter() {} // 0x008A55C0-0x008A5610
	}

	private class ActSymbol // TypeDefIndex: 5118
	{
		// Fields
		public string symbolName; // 0x10
		public int position; // 0x18

		// Constructors
		public ActSymbol() {} // 0x008A1220-0x008A1290
	}

	// Constructors
	public NatureDiagnosis() {} // 0x008A2F30-0x008A3700
	static NatureDiagnosis() {} // 0x008A3710-0x008A4550

	// Methods
	public static NatureDiagnosis Create() => default; // 0x0089C480-0x0089C500
	public void Construct() {} // 0x0089C500-0x0089C7C0
	private void SceneInit() {} // 0x0089CB10-0x0089CBE0
	private void SceneLoad() {} // 0x0089CBE0-0x0089CEA0
	private void JsonLoad() {} // 0x0089C840-0x0089C930
	// [IteratorStateMachine] // 0x0061D230-0x0061D2A0
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x0089D920-0x0089D9A0
	// [IteratorStateMachine] // 0x0061D2A0-0x0061D310
	public IEnumerator Play() => default; // 0x0089D9D0-0x0089DA40
	private void FinalSet() {} // 0x0089DA70-0x0089DC70
	private void ShuffleDiagnosis() {} // 0x0089C930-0x0089CB10
	// [IteratorStateMachine] // 0x0061D310-0x0061D380
	private IEnumerator DiagnosisFlow() => default; // 0x0089DE00-0x0089DE70
	// [IteratorStateMachine] // 0x0061D380-0x0061D3F0
	private IEnumerator HeroSelectFlow() => default; // 0x0089DEA0-0x0089DF10
	// [IteratorStateMachine] // 0x0061D3F0-0x0061D460
	private IEnumerator AskDiagnosis(NDConverterSharedData.DiagnosisStrage diagnosis) => default; // 0x0089DF40-0x0089DFC0
	public void DiagnosisDecideAnimation() {} // 0x0089DFF0-0x0089E2D0
	private void GetPoint(NDConverterSharedData.AnswerStrage ans) {} // 0x0089E450-0x0089E670
	// [IteratorStateMachine] // 0x0061D460-0x0061D4D0
	private IEnumerator ResultAnnouncement() => default; // 0x0089E670-0x0089E6E0
	private void ResultCalculation() {} // 0x0089E710-0x0089EE00
	// [IteratorStateMachine] // 0x0061D4D0-0x0061D540
	private IEnumerator HeroRedetermination(bool bReturn = false /* Metadata: 0x00610EF3 */) => default; // 0x0089EE00-0x0089EE80
	// [IteratorStateMachine] // 0x0061D540-0x0061D5B0
	private IEnumerator HeroSelect() => default; // 0x0089EEB0-0x0089EF20
	// [IteratorStateMachine] // 0x0061D5B0-0x0061D620
	private IEnumerator PartnerSelect() => default; // 0x0089EF50-0x0089EFC0
	private void SetPartnerList() {} // 0x0089EFF0-0x0089F1B0
	// [IteratorStateMachine] // 0x0061D620-0x0061D690
	private IEnumerator PartnerNaming() => default; // 0x0089F1B0-0x0089F220
	// [IteratorStateMachine] // 0x0061D690-0x0061D700
	private IEnumerator FinalDecision() => default; // 0x0089F250-0x0089F2C0
	// [IteratorStateMachine] // 0x0061D700-0x0061D770
	private IEnumerator ExAsk(string question, string[] ans, Action<int> iResult, bool bCancel, int waitFrame, bool bAskCenter = false /* Metadata: 0x00610EF4 */) => default; // 0x0089F2F0-0x0089F3B0
	private void Update() {} // 0x0089F3E0-0x0089F4B0
	private void DiagnosisUpdate() {} // 0x0089F4B0-0x0089F540
	private void SelectUpdate() {} // 0x0089F540-0x0089F6F0
	private void DeployUpdate() {} // 0x0089F6F0-0x0089F830
	private void AutoRotation(string symbolName, int index) {} // 0x008A0020-0x008A0350
	private void AutoMotion(string symbolName, int index) {} // 0x008A0350-0x008A0450
	private bool doUp() => default; // 0x0089FDA0-0x0089FE40
	private bool doUpperRight() => default; // 0x0089F9C0-0x0089FAB0
	private bool doUpperLeft() => default; // 0x0089FAB0-0x0089FBB0
	private bool doBottomRight() => default; // 0x0089FBB0-0x0089FCB0
	private bool doBottomLeft() => default; // 0x0089FCB0-0x0089FDA0
	private bool doDown() => default; // 0x0089FE40-0x0089FEE0
	private bool doRight() => default; // 0x0089FEE0-0x0089FF80
	private bool doLeft() => default; // 0x0089FF80-0x008A0020
	private bool doDecide() => default; // 0x0089F830-0x0089F9C0
	private void CulcXYIndex() {} // 0x008A0CA0-0x008A0D70
	private int CulcMovePoint(bool bmoveY) => default; // 0x008A0630-0x008A0BA0
	private void culcX(int max) {} // 0x008A0DB0-0x008A0DE0
	private void culcX2(int max) {} // 0x008A0D70-0x008A0DA0
	private int culcCursor(int offset) => default; // 0x008A0DA0-0x008A0DB0
	private void PositionLoad() {} // 0x0089CEA0-0x0089D920
	// [IteratorStateMachine] // 0x0061D770-0x0061D7E0
	private IEnumerator AllCharacterLoad() => default; // 0x008A0DE0-0x008A0E50
	// [IteratorStateMachine] // 0x0061D7E0-0x0061D850
	private IEnumerator CharacterLoad(List<NDConverterSharedData.PokemonStrage> list, LayoutPattern layout, GenderType gender) => default; // 0x008A0E80-0x008A0F10
	// [IteratorStateMachine] // 0x0061D850-0x0061D8C0
	private IEnumerator LoadHeroPartner() => default; // 0x008A0F40-0x008A0FB0
	private void HeroSelectInit() {} // 0x008A0FE0-0x008A1220
	private void CharacterInit() {} // 0x008A1290-0x008A1630
	private void ColoringInvisibleBlack() {} // 0x008A1630-0x008A17E0
	// [IteratorStateMachine] // 0x0061D8C0-0x0061D930
	private IEnumerator ColoringVisible(Action<bool> colorCb = null) => default; // 0x008A17E0-0x008A1860
	// [IteratorStateMachine] // 0x0061D930-0x0061D9A0
	private IEnumerator ColoringWhite_sync(ActObjCharactor heroSymbol, ActObjCharactor partnerSymbol) => default; // 0x008A1890-0x008A1910
	private void ColoringPureWhite(bool bDefault = false /* Metadata: 0x00610EF5 */) {} // 0x008A1940-0x008A1C70
	private void ColoringDefault(string symbolName) {} // 0x008A1C70-0x008A1D70
	private void Unload() {} // 0x008A1D70-0x008A1DF0
	private int PlayRandomMotion(string symbolName, int index) => default; // 0x008A0450-0x008A0630
	// [IteratorStateMachine] // 0x0061D9A0-0x0061DA10
	private IEnumerator DecideMotion(string symbolName, bool bHero) => default; // 0x008A1DF0-0x008A1E70
	// [IteratorStateMachine] // 0x0061DA10-0x0061DA80
	private IEnumerator StageOn() => default; // 0x008A1EA0-0x008A1F10
	// [IteratorStateMachine] // 0x0061DA80-0x0061DAF0
	private IEnumerator WaitMotionToPlayWait02(ActObjCharactor chara, Action cb) => default; // 0x008A1F40-0x008A1FC0
	// [IteratorStateMachine] // 0x0061DAF0-0x0061DB60
	private IEnumerator StageOut(Action CallFade) => default; // 0x008A1FF0-0x008A2070
	private void ListOrganize() {} // 0x008A20A0-0x008A24C0
	private void ChangeBgDefault() {} // 0x008A24C0-0x008A2500
	private void ChangeBgFlat() {} // 0x008A2500-0x008A2540
	private void SetBgStar(bool bVisible) {} // 0x008A2540-0x008A2550
	// [IteratorStateMachine] // 0x0061DB60-0x0061DBD0
	private IEnumerator ChangeBgBura(bool bOn) => default; // 0x008A2550-0x008A25D0
	// [IteratorStateMachine] // 0x0061DBD0-0x0061DC40
	private IEnumerator PlayEffect(string symbolName, Vector3 position, Vector3 scale, float alpha = 1f /* Metadata: 0x00610EF6 */) => default; // 0x0089E380-0x0089E450
	private void StartGlowBallEffect(Vector3 position, Vector3 scale, float alpha = 1f /* Metadata: 0x00610EFA */) {} // 0x008A2630-0x008A27D0
	private void EndGlowBallEffect() {} // 0x008A27D0-0x008A2820
	// [IteratorStateMachine] // 0x0061DC40-0x0061DCB0
	private IEnumerator SelectOn(string symbolName, int index, Action cb = null) => default; // 0x008A2820-0x008A28A0
	// [IteratorStateMachine] // 0x0061DCB0-0x0061DD20
	private IEnumerator SelectOut(string symbolName, TextId id, int index) => default; // 0x008A28D0-0x008A2960
	private void FocusOn(GameObject obj) {} // 0x008A2990-0x008A29D0
	// [IteratorStateMachine] // 0x0061DD20-0x0061DD90
	private IEnumerator StartFocus(Action cb = null) => default; // 0x008A29D0-0x008A2A50
	// [IteratorStateMachine] // 0x0061DD90-0x0061DE00
	private IEnumerator StartSelect(Action cb = null) => default; // 0x008A2A80-0x008A2B00
	// [IteratorStateMachine] // 0x0061DE00-0x0061DE70
	private IEnumerator SelectOn(Action cb = null) => default; // 0x008A0C20-0x008A0CA0
	// [IteratorStateMachine] // 0x0061DE70-0x0061DEE0
	private IEnumerator SelectOut(TextId textID, Action cb = null) => default; // 0x008A2B60-0x008A2BE0
	private void SelectOutHeroFirst() {} // 0x008A2C10-0x008A2DE0
	private void Focus(int movePoint) {} // 0x008A0BA0-0x008A0C20
	// [IteratorStateMachine] // 0x0061DEE0-0x0061DF50
	private IEnumerator SwitchGender(string afterSymbol) => default; // 0x008A2DE0-0x008A2E60
	// [IteratorStateMachine] // 0x0061DF50-0x0061DFC0
	private IEnumerator WaitFrame(int frame) => default; // 0x008A2E90-0x008A2F00
	private void PlaySE(string seName) {} // 0x0089E2D0-0x0089E380
}

