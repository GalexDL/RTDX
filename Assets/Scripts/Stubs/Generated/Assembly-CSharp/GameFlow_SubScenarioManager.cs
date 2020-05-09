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
using Const.quest;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlow_SubScenarioManager // TypeDefIndex: 4784
{
	// Fields
	private Dictionary<ScenarioProgressType, GameFlowBlob_SubScenarioEvent> currentFlowBlobTbl_; // 0x10
	private static SubInfo_[] subInfoLst_; // 0x00
	private static ScenarioProgressType[] subTypes_; // 0x08
	private int updateFlowCacheId_; // 0x18
	private bool bIsInit_; // 0x1C
	private HashSet<GameFlowBlob_SubScenarioEvent> nextBlobSet_; // 0x20
	private List<string> cache_talkSymbols; // 0x28
	private int cacheId_talkSymbols; // 0x30

	// Nested types
	public class ScenarioProgressType_TypeComparer : IEqualityComparer<ScenarioProgressType> // TypeDefIndex: 4785
	{
		// Constructors
		public ScenarioProgressType_TypeComparer() {} // 0x00A69EF0-0x00A69F00

		// Methods
		public bool Equals(ScenarioProgressType x, ScenarioProgressType y) => default; // 0x00A70660-0x00A70670
		public int GetHashCode(ScenarioProgressType obj) => default; // 0x00A70670-0x00A70680
	}

	private class SubInfo_ // TypeDefIndex: 4786
	{
		// Fields
		public ScenarioProgressType subType; // 0x10
		public string entryName; // 0x18
		public string flowDataName; // 0x20

		// Constructors
		public SubInfo_() {} // 0x00A6ABE0-0x00A6ABF0
	}

	[Serializable]
	private class SerializeData_ // TypeDefIndex: 4787
	{
		// Fields
		public List<Data> dataList; // 0x10

		// Nested types
		[Serializable]
		public class Data // TypeDefIndex: 4788
		{
			// Fields
			public ScenarioProgressType progType; // 0x10
			public string flowId; // 0x18

			// Constructors
			public Data() {} // 0x00A67890-0x00A678A0
		}

		// Constructors
		public SerializeData_() {} // 0x00A67820-0x00A67890
	}

	private enum CallTimming_ // TypeDefIndex: 4789
	{
		PRE_NEXT_DAY = 0,
		POST_NEXT_DAY = 1,
		HANYOU_ASA_CAMP_MAE = 2
	}

	// Constructors
	public GameFlow_SubScenarioManager() {} // 0x00A69E00-0x00A69EF0
	static GameFlow_SubScenarioManager() {} // 0x00A69F00-0x00A6ABE0

	// Methods
	private void SetFlowBlob_(ScenarioProgressType subType, GameFlowBlob_SubScenarioEvent blob) {} // 0x00A674D0-0x00A67550
	public string Serialize() => default; // 0x00A67550-0x00A67820
	public bool Deserialize(string jsonData) => default; // 0x00A64550-0x00A64950
	public GameFlowBlob_SubScenarioEvent GetCurrentFlowBlob_ForDebug(ScenarioProgressType subType) => default; // 0x00A678A0-0x00A67940
	public void SetCurrentFlowBlob_ForDebug(ScenarioProgressType subType, GameFlowBlob_SubScenarioEvent blob) {} // 0x00A67940-0x00A67A00
	public List<GameFlowBlob_SubScenarioEvent> EnumSubScenarioEventBlob_ForDebug(ScenarioProgressType subType) => default; // 0x00A67A00-0x00A67BD0
	public void SetFlowByDebugEntryId_ForDebug(string debugEntryId) {} // 0x00A67BE0-0x00A67DC0
	public static List<GameFlowData> EnumGameFlowList_ForDebug() => default; // 0x00A67DE0-0x00A67F20
	// [IteratorStateMachine] // 0x0061BA90-0x0061BB00
	public IEnumerator SubScenarioAging(Action<bool, Index, bool> resultCb) => default; // 0x00A67F20-0x00A67FA0
	// [IteratorStateMachine] // 0x0061BB00-0x0061BB70
	public IEnumerator InitalizeAndStartSubFlow() => default; // 0x00A67110-0x00A67180
	public bool CheckNext(GameFlowBlob_SubScenarioEvent checkBlob) => default; // 0x00A5D070-0x00A5D0D0
	private void AddNext_(GameFlowBlob_SubScenarioEvent blob) {} // 0x00A68000-0x00A68060
	public void RemoveNext(GameFlowBlob_SubScenarioEvent blob) {} // 0x00A5D0D0-0x00A5D130
	// [IteratorStateMachine] // 0x0061BB70-0x0061BBE0
	private IEnumerator PlayToSubScnarioBlob_(GameFlowBlobBase flowBlob, Action<GameFlowBlob_SubScenarioEvent> resultCb, bool bAgingMode) => default; // 0x00A68060-0x00A680E0
	// [IteratorStateMachine] // 0x0061BBE0-0x0061BC50
	private IEnumerator PlayNextSubScnarioBlob_(ScenarioProgressType subType, Action beginCb, Action endCb, bool bAgingMode) => default; // 0x00A68110-0x00A681B0
	private bool CheckStartCondition_(ScenarioProgressType subType) => default; // 0x00A681E0-0x00A68420
	private Variation ParseQuestName_(string questName) => default; // 0x00A68420-0x00A684E0
	private bool CheckNextFlowCond_ByTimming_(ScenarioProgressType subType, CallTimming_ timming, Action setSkipOhayou) => default; // 0x00A684E0-0x00A686B0
	public List<string> EnumCurrent_TownNpcStepIdList() => default; // 0x00A686B0-0x00A68D10
	public List<string> EnumCurrent_ActAssetSetSymbolList() => default; // 0x00A68D20-0x00A68EC0
	public string Get_GetHenseiType() => default; // 0x00A68EC0-0x00A690C0
	// [IteratorStateMachine] // 0x0061BC50-0x0061BCC0
	private IEnumerator PlayNoneNext_(Action beginCb, Action endCb, bool bAgingMode) => default; // 0x00A690C0-0x00A69150
	// [IteratorStateMachine] // 0x0061BCC0-0x0061BD30
	public IEnumerator OnInterrupt_PlayNone(bool bAgingMode) => default; // 0x00A69180-0x00A69200
	// [IteratorStateMachine] // 0x0061BD30-0x0061BDA0
	public IEnumerator OnInterrupt_GroundPlayer_GroundDayStart(Action beginCb, Action endCb, bool bAgingMode) => default; // 0x00A69230-0x00A692C0
	private bool SymbolIntersectCheck_(List<string> setA, List<string> setB) => default; // 0x00A692F0-0x00A695B0
	private bool SymbolIntersectCheck_(string a, List<string> setB) => default; // 0x00A695B0-0x00A69700
	// [IteratorStateMachine] // 0x0061BDA0-0x0061BE10
	public IEnumerator OnInterrupt_GroundPlayer_TriggerProcess(List<string> talkSymbols, List<string> hitSymbols, Action<bool, bool> resultCb, Action beginCb, Action endCb, Func<IEnumerator> endDayCb, bool bAgingMode) => default; // 0x00A69700-0x00A697C0
	public List<string> EnumTalkTriggerSymbols() => default; // 0x00A697F0-0x00A69A00
	// [IteratorStateMachine] // 0x0061BE10-0x0061BE80
	public IEnumerator OnInterrupt_GroundPlayer_AfterTalkOrShop(Action beginCb, Action endCb, bool bAgingMode) => default; // 0x00A69A00-0x00A69A90
	// [IteratorStateMachine] // 0x0061BE80-0x0061BEF0
	public IEnumerator OnInterrupt_GroundPlayer_NextDay(Action beginCb, Action endCb, Action setSkipOhayouCb, bool bPreOrPost, bool bAgingMode) => default; // 0x00A69AC0-0x00A69B70
	// [IteratorStateMachine] // 0x0061BEF0-0x0061BF60
	public IEnumerator OnInterrupt_GroundPlayer_HanyouAsaBaseCampMae(Action beginCb, Action endCb, bool bAgingMode) => default; // 0x00A69BA0-0x00A69C30
	// [IteratorStateMachine] // 0x0061BF60-0x0061BFD0
	public IEnumerator OnInterrupt_GroundPlayer_EnterDungeon(Index dgIndex, GameFlowLocalSaveData subFlowResumeData, Action<GameFlowLocalSaveData> autosaveCb, Action<Const.DungeonResult, GameFlowLocalSaveData> result, bool bAgingMode) => default; // 0x00A69C60-0x00A69D10
	// [IteratorStateMachine] // 0x0061BFD0-0x0061C040
	public IEnumerator OnInterrupt_GroundPlayer_AfterDungeon(Index dgIndex, Const.DungeonResult dgRes, bool bAgingMode) => default; // 0x00A69D40-0x00A69DD0
}

