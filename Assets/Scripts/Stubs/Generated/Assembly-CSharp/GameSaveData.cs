/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using Const;
using Const.creature;
using Const.dungeon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameSaveData : Singleton<GameSaveData>, ISerializationCallbackReceiver // TypeDefIndex: 5507
{
	// Fields
	private const int MAX_NATIVE_SAVE_BUFFER = 524288; // Metadata: 0x00611A96
	private const int MAX_DUNGEON_SAVE_BUFFER = 262144; // Metadata: 0x00611A9A
	private const int MAX_JSON_INFO_SAVE_BUFFER = 1024; // Metadata: 0x00611A9E
	private const int MAX_JSON_BODY_SAVE_BUFFER = 260992; // Metadata: 0x00611AA2
	private const int MAX_FINGER_PRINTF_SAVE_BUFFER = 128; // Metadata: 0x00611AA6
	private const int MAX_MASTER_SAVE_BUFFER = 1310720; // Metadata: 0x00611AAA
	private const int ENCRYPT_TARGET_SIZE = 1310592; // Metadata: 0x00611AAE
	private const int ENCRYPT_POINT = 1310592; // Metadata: 0x00611AB2
	private static readonly byte[] FINGER_PRINTF; // 0x00
	private static int GameNativeDataSavePoint; // 0x08
	private static int DungeonDataSavePoint; // 0x0C
	private static int DungeonRescueDataSavePoint; // 0x10
	private static int JSONDataSavePoint; // 0x14
	[SerializeField] // 0x00616770-0x00616780
	private Header header_; // 0x10
	[SerializeField] // 0x00616780-0x00616790
	private byte[] nativeBinary_; // 0x18
	private const string SAVE_FILE_NAME = "pegasus_save_master_data.bin"; // Metadata: 0x00611AB6
	private const string SAVE_OLD_FILE_NAME = "pegasus_save_data.bin"; // Metadata: 0x00611AD6
	private const string SAVE_OLD_GAME_DATA_FILE_NAME = "pegasus_save_game_data.bin"; // Metadata: 0x00611AEF
	private const string SAVE_OLD_DUNGEN_FILE_NAME = "pegasus_save_dungeon.bin"; // Metadata: 0x00611B0D
	private const string SAVE_OLD_DUNGEN_RESCUE_FILE_NAME = "pegasus_save_dungeon_rescue.bin"; // Metadata: 0x00611B29
	private static NativeSaveBuffer nativeDataBinary_; // 0x18
	private static NativeSaveBuffer nativeDataBinaryTemporary_; // 0x20
	private static byte[] masterDataBuffer_; // 0x28
	private static byte[] masterDataLastBuffer_; // 0x30
	private static uint dungeonSaveCounter_; // 0x38
	private static SemaphoreSlim nativeWriteBufferThreadLockForTemporaryWrite; // 0x40
	private static bool enableSaveDungeonForInterrupt_; // 0x48
	private SaveDataError deserializeResult; // 0x20
	private bool bFromJsonManagedRecoveryMode_; // 0x24
	private static bool bThreadSaveEndFlag_; // 0x49
	private static bool bIsThreadSaveFlag_; // 0x4A
	private static SemaphoreSlim saveThreadLock_; // 0x50
	private static string[] s_aBoolFlagSymbols; // 0x58
	[NonSerialized]
	private Dictionary<string, bool> dicBoolFlag_; // 0x28
	[SerializeField] // 0x00616790-0x006167A0
	private List<PairBoolFlag> saveBoolFlag_; // 0x30
	[SerializeField] // 0x006167A0-0x006167B0
	private ScenarioManager.SaveData scenarioManager_SaveData_; // 0x38
	[SerializeField] // 0x006167B0-0x006167C0
	private OptionManager.SaveData optionManager_SaveData_; // 0x40
	[SerializeField] // 0x006167C0-0x006167D0
	private FriendRescueTicketHistory.SaveData friendRescueTicketHistory_SaveData_; // 0x48
	[SerializeField] // 0x006167D0-0x006167E0
	private int friendRescueRevivePresentType_; // 0x50
	[SerializeField] // 0x006167E0-0x006167F0
	private TrainingTool.SaveData trainingTool_SaveData_; // 0x58
	public bool IsDungeonFromTopMenuPerippaa; // 0x60
	private static bool bReqWriteBufferNativeDungeonAndGameData_; // 0x60
	private const float INTERRUPT_SAVE_SEC = 5f; // Metadata: 0x00611B4C
	private static float interruptSaveSecForDungeon_; // 0x64
	public KyaragekiSaveData KyaragekiData; // 0x68
	public Action OnPreSaveGameFlowCallback; // 0x70
	[SerializeField] // 0x006167F0-0x00616800
	private GameFlowLocalSaveData GameFlowSuspendData_; // 0x78
	[SerializeField] // 0x00616800-0x00616810
	private GameFlowDataManager.GameFlow_GlobalDungeonData GameFlow_GlobalDungeonData_; // 0x80
	[SerializeField] // 0x00616810-0x00616820
	private GroundPlayer.GroundSaveData GroundData_; // 0x88
	[SerializeField] // 0x00616820-0x00616830
	private DungeonResultSaveData dungeonResultSaveData; // 0x90
	[SerializeField] // 0x00616830-0x00616840
	private Bank_Bonus.SaveData bankBonusSaveData_; // 0x98
	[SerializeField] // 0x00616840-0x00616850
	private UIWorldMapMenu.SaveData WorldMapSaveData; // 0xA0
	[SerializeField] // 0x00616850-0x00616860
	private UIOrganizationMenu.SaveData OrganizationSaveData; // 0xA8

	// Properties
	public bool IsGameFlowSuspend { get => default; } // 0x00A75DC0-0x00A75DE0 

	// Nested types
	public enum TrialSwitch // TypeDefIndex: 5508
	{
		Off = 0,
		On = 1
	}

	[Serializable]
	public class Header // TypeDefIndex: 5509
	{
		// Fields
		public int dataVersion; // 0x10
		public int dungeonSaveVersion; // 0x14
		public int nativeVersion; // 0x18

		// Constructors
		public Header() {} // 0x00721530-0x00721550

		// Methods
		public void UpdateLatest() {} // 0x00720C60-0x00720C80
	}

	private class NativeSaveBuffer // TypeDefIndex: 5510
	{
		// Fields
		public byte[] gameDataBuffer; // 0x10
		public byte[] dungeonBuffer; // 0x18

		// Constructors
		public NativeSaveBuffer() {} // 0x00721910-0x00721980
	}

	private class SaveThreadParameter // TypeDefIndex: 5511
	{
		// Fields
		public DungeonSaveMode dungeonSaveMode; // 0x10
		public int frameCount; // 0x14
		public bool bInterrupt; // 0x18

		// Constructors
		public SaveThreadParameter() {} // 0x007219C0-0x007219D0
	}

	[Serializable]
	private class PairBoolFlag // TypeDefIndex: 5512
	{
		// Fields
		public string key; // 0x10
		public bool value; // 0x18

		// Constructors
		public PairBoolFlag() {} // Dummy constructor
		public PairBoolFlag(string _key, bool _value) {} // 0x00721980-0x007219C0
	}

	public enum SaveDungeonType // TypeDefIndex: 5513
	{
		Suspend = 0,
		RescueRequest = 1
	}

	public class DungeonInterruptSaveProhibitedScope : IDisposable // TypeDefIndex: 5514
	{
		// Fields
		private static int s_refCount; // 0x00

		// Constructors
		public DungeonInterruptSaveProhibitedScope() {} // 0x007212F0-0x00721370
		static DungeonInterruptSaveProhibitedScope() {} // 0x007213E0-0x007213F0

		// Methods
		public static int GetRefCount() => default; // 0x00721280-0x007212F0
		public void Dispose() {} // 0x00721370-0x007213E0
	}

	public enum PartnerType // TypeDefIndex: 5515
	{
		DEFAULT = 0,
		TYPE1 = 1,
		TYPE3 = 2
	}

	[Serializable]
	public class KyaragekiSaveData // TypeDefIndex: 5516
	{
		// Fields
		[SerializeField] // 0x00618570-0x00618580
		private string partnerType; // 0x10

		// Constructors
		public KyaragekiSaveData() {} // 0x007218B0-0x00721910

		// Methods
		public void SetPartnerType(string partnerType_) {} // 0x00721550-0x007216D0
		public string GetPartnerType_String() => default; // 0x00721820-0x00721830
		public PartnerType GetPartnerType_Enum() => default; // 0x007216D0-0x00721820
		public void OnAfterLoad() {} // 0x00721830-0x007218B0
	}

	[Serializable]
	public class DungeonResultSaveData // TypeDefIndex: 5517
	{
		// Fields
		public ResultMode currentResultMode; // 0x10
		public bool lastFadeWhite; // 0x14
		[SerializeField] // 0x00618580-0x00618590
		public DungeonResultParameter dungeonParameter_resultParameter; // 0x18
		[SerializeField] // 0x00618590-0x006185A0
		public DungeonEngine.ResultProcessParameter dungeonResultProcessParam; // 0x20
		public List<PokemonWarehouseId> lastPartyMemberId; // 0x28
		public Const.creature.Index lastLeaderIndex; // 0x30

		// Properties
		public bool IsCurrentResultEnable { get => default; } // 0x00721470-0x00721480 

		// Nested types
		public enum ResultMode // TypeDefIndex: 5518
		{
			NoResult = 0,
			NormalResult = 1,
			PeripperResult = 2
		}

		// Constructors
		public DungeonResultSaveData() {} // 0x00721480-0x00721530

		// Methods
		public void Clear() {} // 0x007213F0-0x00721470
	}

	// Constructors
	public GameSaveData() {} // 0x00A70F40-0x00A71200
	static GameSaveData() {} // 0x00A76460-0x00A771C0

	// Methods
	private static NativeSaveBuffer GetWriteNativeSaveBuffer(bool bInterrupt) => default; // 0x00A70680-0x00A70720
	private static NativeSaveBuffer GetReadNativeSaveBuffer(bool bInterrupt) => default; // 0x00A70720-0x00A707C0
	public void OnAfterDeserialize() {} // 0x00A707C0-0x00A70990
	public void OnBeforeSerialize() {} // 0x00A70B40-0x00A70D10
	public void BootInitailize() {} // 0x00A70D10-0x00A70D20
	private void OnInitializeData() {} // 0x00A70D20-0x00A70F40
	private void OnPreSave_MainThread() {} // 0x00A712E0-0x00A71300
	private void OnPreSave() {} // 0x00A71300-0x00A71360
	private void OnAfterLoad() {} // 0x00A71360-0x00A713C0
	public static void SetSaveMode(SaveMode eSaveMode) {} // 0x00A713C0-0x00A71430
	public static SaveMode GetSaveMode() => default; // 0x00A71430-0x00A714A0
	public static void SetSaveFreeOrRescueDungeon(bool bEnable) {} // 0x00A714A0-0x00A71510
	public static bool IsSaveFreeOrRescueDungeon() => default; // 0x00A71510-0x00A71580
	public static bool IsSaveStartMode() => default; // 0x00A71580-0x00A71640
	public static bool IsGroundSaveMode() => default; // 0x00A71640-0x00A71700
	public static bool IsDungeonSaveMode() => default; // 0x00A71700-0x00A717F0
	public static void Save() {} // 0x00A717F0-0x00A71900
	private static void _SaveDungeon(DungeonSaveMode dungeonSaveMode, bool bInterruptSave) {} // 0x00A71D50-0x00A71EB0
	private static void _Save(DungeonSaveMode dungeonSaveMode, bool bInterrupt) {} // 0x00A71A80-0x00A71D50
	private static void OnBeginSave_() {} // 0x00A72240-0x00A722B0
	private static void OnEndSave_() {} // 0x00A722B0-0x00A72320
	public static void UpdateFromMainThread() {} // 0x00A72320-0x00A72430
	private static void SaveThread_(object o) {} // 0x00A72430-0x00A73090
	private static AesManaged CreateAesManager(int keySize, int blockSize, string iv, string key) => default; // 0x00A73090-0x00A731D0
	// [Conditional] // 0x00620500-0x00620540
	private static void SyncThreadLock_() {} // 0x00A71900-0x00A71980
	// [IteratorStateMachine] // 0x00620540-0x006205B0
	public static IEnumerator Save_WithDebugMessage() => default; // 0x00A731D0-0x00A73230
	public static bool IsExistTrialSaveData() => default; // 0x00A73230-0x00A732B0
	// [IteratorStateMachine] // 0x006205B0-0x00620620
	public static IEnumerator Load(bool bErrorMessage, TrialSwitch trialSwitch = TrialSwitch.Off /* Metadata: 0x00611A8E */, bool bIsManagedRecoveryMode = false /* Metadata: 0x00611A92 */) => default; // 0x00A732B0-0x00A73340
	private static SaveDataError LoadCore_(TrialSwitch trialSwitch, bool bIsManagedRecoveryMode = false /* Metadata: 0x00611A93 */) => default; // 0x00A73340-0x00A73DC0
	private static SaveDataError LoadOldCore_(bool bIsManagedRecoveryMode = false /* Metadata: 0x00611A94 */) => default; // 0x00A73DC0-0x00A74340
	private static void NewFileUpdateOldDungeon_() {} // 0x00A74340-0x00A745E0
	// [IteratorStateMachine] // 0x00620620-0x00620690
	public static IEnumerator InitializeDataFlow(bool bErrorMessage) => default; // 0x00A745E0-0x00A74640
	private void InitalizeFlags_() {} // 0x00A70990-0x00A70B40
	public void SetBoolFlag(string symbol, bool bSwitch) {} // 0x00A74640-0x00A74780
	public bool GetBoolFlag(string symbol) => default; // 0x00A74780-0x00A74800
	public void AllClearFlags() {} // 0x00A74800-0x00A74980
	public ThunksPresentType GetFriendRescueRevivePresentType() => default; // 0x00A74980-0x00A74990
	public void SetFriendRescueRevivePresentType(ThunksPresentType type) {} // 0x00A74990-0x00A749A0
	private static string GetDungeonSaveFileName(DungeonSaveMode saveMode) => default; // 0x00A749A0-0x00A74A00
	public static void SetEnableSaveDungeonForInterrupt(bool bEnable) {} // 0x00A74A00-0x00A74A80
	public static bool CanSaveDungeonForInterrupt() => default; // 0x00A74A80-0x00A74C20
	public static bool SaveDungeonForInterrupt(SaveDungeonType saveDgType) => default; // 0x00A74C20-0x00A74DB0
	public static void SyncThreadLockForExitRequest() {} // 0x00A751C0-0x00A75290
	public static void WriteBufferNativeDungeonAndGameData(bool bInterrupt) {} // 0x00A71EB0-0x00A72240
	private static void WriteBufferNativeDungeonAndGameDataForThread(object state) {} // 0x00A75290-0x00A75300
	public static void ThreadStart_WriteBufferNativeDungeonAndGameData() {} // 0x00A75300-0x00A753B0
	// [IteratorStateMachine] // 0x00620690-0x00620700
	public static IEnumerator ThreadWait_WriteBufferNativeDungeonAndGameData() => default; // 0x00A753B0-0x00A75410
	public static void PollingInterruptSaveForDungeonEngine() {} // 0x00A75410-0x00A75500
	public static void WriteBufferNativeGameData() {} // 0x00A71980-0x00A71A80
	public static void SaveDungeon(SaveDungeonType saveDgType, bool bInterruptSave = false /* Metadata: 0x00611A95 */) {} // 0x00A74DB0-0x00A751C0
	public static SaveDataError LoadDungeon() => default; // 0x00A75570-0x00A756A0
	private static SaveDataError LoadDungeon(DungeonSaveMode saveMode) => default; // 0x00A756A0-0x00A758E0
	public ulong GetPlayTimeSecSinceSaved() => default; // 0x00A758E0-0x00A75950
	public ulong GetPlayTimeMilliSecSinceSaved() => default; // 0x00A75950-0x00A759C0
	public ulong GetPlayTimeMilliSec() => default; // 0x00A759C0-0x00A75A30
	public void AddSleepTimeForMilliSec(ulong sec) {} // 0x00A75A30-0x00A75AA0
	public int GetRescueCount() => default; // 0x00A75AA0-0x00A75B10
	public int IncRescueCount() => default; // 0x00A75500-0x00A75570
	public int GetAdventureCount() => default; // 0x00A75B10-0x00A75B80
	public Const.dungeon.Index GetSaveDungeonIndex() => default; // 0x00A75B80-0x00A75BF0
	public int GetSaveDungeonFloor() => default; // 0x00A75BF0-0x00A75C60
	public int GetDungeonArrivalFloor(Const.dungeon.Index index) => default; // 0x00A75C60-0x00A75CD0
	public void SetDungeonArrivalFloor(Const.dungeon.Index index, int floor) {} // 0x00A75CD0-0x00A75D50
	public bool IsDungeonClearFlag(Const.dungeon.Index index) => default; // 0x00A75D50-0x00A75DC0
	public void SetGameFlowSuspendData(GameFlowLocalSaveData suspendData) {} // 0x00A75DE0-0x00A75F80
	public void SaveGameFlowSaveFunc(GameFlowLocalSaveData suspendData) {} // 0x00A75F80-0x00A76070
	public void SetGameFlowResumeDungeonStartMode(DungeonStartMode startMode) {} // 0x00A76070-0x00A76160
	public GameFlowLocalSaveData GetGameFlowSuspendDataClone() => default; // 0x00A76160-0x00A761C0
	public GameFlowDataManager.GameFlow_GlobalDungeonData Access_GameFlow_GlobalDungeonData() => default; // 0x00A5EAA0-0x00A5EB80
	public GroundPlayer.GroundSaveData ReadOnly_GroundData() => default; // 0x00A68D10-0x00A68D20
	public GroundPlayer.GroundSaveData Access_GroundData() => default; // 0x00A71200-0x00A712E0
	public DungeonResultSaveData AccessDungeonResultSaveData() => default; // 0x00A761C0-0x00A762A0
	public UIWorldMapMenu.SaveData AccessWorldMapSaveData() => default; // 0x00A762A0-0x00A76380
	public UIOrganizationMenu.SaveData AccessOrganizationSaveData() => default; // 0x00A76380-0x00A76460
}

