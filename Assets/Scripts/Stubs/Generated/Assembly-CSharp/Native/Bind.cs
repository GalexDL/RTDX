/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Const;
using Const.creature;
using CreatureConst;
using Language;
using SLua;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace Native
{
	public class Bind // TypeDefIndex: 8432
	{
		// Fields
		private const string DllName = "__Internal"; // Metadata: 0x00614B1B
		private static string lastNativeAssert_; // 0x00
		private static List<GCHandle> nativeCallbackGchLst_; // 0x08
	
		// Nested types
		public delegate void Delegate_DebugError(string message); // TypeDefIndex: 8433; 0x00899320-0x008998E0
	
		public enum EventKind // TypeDefIndex: 8434
		{
			EFFECT = 0
		}
	
		public enum EffectEventType // TypeDefIndex: 8435
		{
			EFFECT__FINISHED = 0
		}
	
		// Constructors
		public Bind() {} // 0x00E43EA0-0x00E43EB0
		static Bind() {} // 0x00E43EB0-0x00E43F40
	
		// Methods
		public static void Startup() {} // 0x00E3F890-0x00E3F900
		// [MonoPInvokeCallback] // 0x0063BC30-0x0063BCA0
		private static void NativeException(string message) {} // 0x00E3F6A0-0x00E3F800
		// [MonoPInvokeCallback] // 0x0063BCA0-0x0063BD10
		private static void NativeAssert(string message) {} // 0x00E3F800-0x00E3F890
		public static void UpdateNativeAssert() {} // 0x00E3F910-0x00E3F9C0
		private static void SetupNativeCallback() {} // 0x00E3F900-0x00E3F910
		public static extern void SaveBitStream_SetVersion(int nativeDataVersion); // 0x00E3F9C0-0x00E3F9D0
		public static extern void Debug_SetExceptionThrow(IntPtr func); // 0x00E3F9D0-0x00E3F9E0
		public static extern void Debug_SetAssert_NoThrow(IntPtr func); // 0x00E3F9E0-0x00E3F9F0
		public static extern void Debug_NNLOG(byte[] message); // 0x00E3F9F0-0x00E3FA00
		public static extern void Debug_Print(byte[] message); // 0x00E3FA00-0x00E3FA10
		public static extern void Debug_Panic(byte[] message); // 0x00E3FA10-0x00E3FA20
		public static extern void MainFiber_SetMode(int mode); // 0x00E3FA20-0x00E3FA30
		public static extern void MainFiber_SetModeUnityWait(); // 0x00E3FA30-0x00E3FA40
		public static extern bool MainFiber_IsStartedFiber(); // 0x00E3FA40-0x00E3FA60
		public static extern bool MainFiber_IsUnityWait(); // 0x00E3FA60-0x00E3FA80
		public static extern void MainFiber_FiberSwitch_GeneralBuffer_Read(byte[] aBuffer, int length); // 0x00E3FA80-0x00E3FA90
		public static extern void MainFiber_FiberSwitch_GeneralBuffer_Write(byte[] aBuffer, int length); // 0x00E3FA90-0x00E3FAA0
		public static extern bool Input_IsTouchEdge(); // 0x00E3FAA0-0x00E3FAC0
		public static extern bool Input_IsTouchRelease(); // 0x00E3FAC0-0x00E3FAE0
		public static extern bool Input_TouchCountToNative(int count); // 0x00E3FAE0-0x00E3FB00
		public static extern bool Input_TouchInfoToNative(int id, int fingerId, int phase, float deltaTime, float x, float y); // 0x00E3FB00-0x00E3FB20
		public static extern void Input_MouseInfoToNative(bool bButton, bool bUpEdge, bool bDownEdge, float fPosX, float fPosY, float fWheel); // 0x00E3FB20-0x00E3FB30
		public static extern void Input_RightMouseInfoToNative(bool bButton, bool bUpEdge, bool bDownEdge, float fPosX, float fPosY); // 0x00E3FB30-0x00E3FB40
		protected static extern void Input_SetPushButtonSymbol(byte[] aBuffer, int count); // 0x00E3FB40-0x00E3FB50
		public static void Input_SetPushButtonDebugSymbol(string symbol) {} // 0x00E3FB50-0x00E3FC30
		public static extern void Input_UpdatePadAndKeyboard(int value); // 0x00E3FC30-0x00E3FC40
		public static extern void Input_UpdateStickL(float x, float y); // 0x00E3FC40-0x00E3FC50
		public static extern void Input_UpdateStickR(float x, float y); // 0x00E3FC50-0x00E3FC60
		public static extern void Input_BackKeyToNative(bool bButton); // 0x00E3FC60-0x00E3FC70
		public static extern void MainCamera_UpdateUnityFrustum(byte[] buffer, int length); // 0x00E3FC70-0x00E3FC80
		public static extern uint CharacterGraphicsDatabase_IndexToGfxSymbol(int index, int form); // 0x00E3FC80-0x00E3FC90
		public static extern void CharacterGraphicsDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FC90-0x00E3FCA0
		public static extern void CharacterGraphicsDatabase_GetShaderStatusParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FCA0-0x00E3FCB0
		public static extern void CharacterGraphicsDatabase_GetShaderStatusList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FCB0-0x00E3FCC0
		public static extern void CharacterGraphicsDatabase_GetList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FCC0-0x00E3FCD0
		public static extern void CharacterMotionDatabase_Load(byte[] outputBuffer, int outputBufferLength); // 0x00E3FCD0-0x00E3FCE0
		public static extern void MapGraphicsDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FCE0-0x00E3FCF0
		public static extern void MapGraphicsDatabase_GetList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FCF0-0x00E3FD00
		public static extern void GimmickGraphicsDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FD00-0x00E3FD10
		public static extern void GimmickGraphicsDatabase_GetDungeonGimmickList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FD10-0x00E3FD20
		public static extern bool EffectDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FD20-0x00E3FD50
		public static extern void EffectDatabase_GetList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FD50-0x00E3FD60
		public static extern void ManpuGraphicsDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FD60-0x00E3FD70
		public static extern void ManpuGraphicsDatabase_GetList(byte[] outputBuffer, int outputBufferLength); // 0x00E3FD70-0x00E3FD80
		public static extern void CameraGraphicsDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FD80-0x00E3FD90
		public static extern void CameraGraphicsDatabase_GetAnimationParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FD90-0x00E3FDA0
		public static extern void HintDatabase_GetParameter(byte[] outputBuffer, int outputBufferLength, int hash); // 0x00E3FDA0-0x00E3FDB0
		public static extern void HintManager_GetHashSymbolForMenu(byte[] outputBuffer, int outputBufferLength); // 0x00E3FDB0-0x00E3FDC0
		public static extern bool HintManager_CanDisplayMenu(int hash); // 0x00E3FDC0-0x00E3FDE0
		public static extern bool HintManager_CanExecute(int hash, bool bNoneCountCheck); // 0x00E3FDE0-0x00E3FE00
		public static extern bool HintManager_IsOpenFlag(int hash); // 0x00E3FE00-0x00E3FE20
		public static extern bool HintManager_GetKidokuFlag(int hash); // 0x00E3FE20-0x00E3FE40
		public static extern void HintManager_SetKidokuFlag(int hash, bool bEnable); // 0x00E3FE40-0x00E3FE50
		public static extern void HintManager_AllClearFlag(); // 0x00E3FE50-0x00E3FE60
		public static extern void HintManager_AllOpenFlag(); // 0x00E3FE60-0x00E3FE70
		public static extern void HintManager_SetSkipWindowProcess(bool bEnable); // 0x00E3FE70-0x00E3FE80
		public static extern bool HintManager_UpdateFlag(int hash); // 0x00E3FE80-0x00E3FEA0
		public static extern void NativeController_EventCallback(int controlId, int eventKind, int eventType); // 0x00E3FEA0-0x00E3FEB0
		public static void NativeController_EffectEventCallback(int controlId, EffectEventType eventType) {} // 0x00E3FEB0-0x00E3FF30
		public static extern void Fader_UpdateCallback(int pattern, float fNowSec, float fEndSec, float r, float g, float b, float a); // 0x00E3FF30-0x00E3FF40
		public static extern int GL_SendBuffer(byte[] outputBuffer, int outputBufferLength, byte[] outputVertexBuffer, int outputBufferVertexLength, byte[] outputIndexBuffer, int outputBufferIndexLength); // 0x00E3FF40-0x00E3FF70
		public static extern void DataCommand_BeginToManagedCommandBuffer(uint[] outputBuffer, int outputBufferLength); // 0x00E3FF70-0x00E3FF80
		public static extern int DataCommand_EndToManagedCommandBuffer(); // 0x00E3FF80-0x00E3FF90
		public static extern void DataCommand_ManagedToNativeData(byte[] buffer, int bufferLength); // 0x00E3FF90-0x00E3FFA0
		public static extern void KaminaGraphics_CopyTextureImage(int controlId, byte[] aBuffer); // 0x00E3FFA0-0x00E3FFB0
		public static extern void KaminaGraphics_CallbackCreateNodeRenderMap(int controlId, byte[] aBuffer, int bufferLength); // 0x00E3FFB0-0x00E3FFC0
		public static extern void KaminaGraphics_CallbackCreateModelAnimation(int controlId, byte[] aBuffer, int bufferLength); // 0x00E3FFC0-0x00E3FFD0
		public static extern void Graphics_CallbackCalcBone(int controlId, byte[] aBuffer, int bufferLength); // 0x00E3FFD0-0x00E3FFE0
		public static extern void Graphics_CallbackUpdateAnimation(int controlId, byte[] aBuffer, int bufferLength); // 0x00E3FFE0-0x00E3FFF0
		public static extern void Graphics_CallbackIsEffectChangeLightColor(bool end); // 0x00E3FFF0-0x00E40000
		public static extern bool Time_CanGetNetworkDate(); // 0x00E40000-0x00E40020
		public static extern void Time_Update(float fDeltaSecMain, float fDeltaSecGraphics); // 0x00E40020-0x00E40030
		public static extern long Time_GetNowUTC(); // 0x00E40030-0x00E40040
		public static extern int Time_GetNowUTC32(); // 0x00E40040-0x00E40050
		public static extern long Time_AddDayForPOSIX(long posix, long day); // 0x00E40050-0x00E40060
		public static extern void Time_ConvertCalendarTimeFromPOSIX32(byte[] buffer, int length); // 0x00E40060-0x00E40070
		public static extern int Time_ConvertPOSIX32FromCalendar(int year, int month, int day, int hour, int minute, int second); // 0x00E40070-0x00E40080
		public static extern int Time_ConvertPOSIX32FromTimeZoneCalendar(int year, int month, int day, int hour, int minute, int second); // 0x00E40080-0x00E40090
		public static extern long Time_GetRemainSecondFromCurrentTime(int posix32Value, int afterDay); // 0x00E40090-0x00E400A0
		public static extern void Time_Test(); // 0x00E400A0-0x00E400B0
		public static extern void ChangeLanguage(int eType); // 0x00E400B0-0x00E400C0
		public static void ChangeLanguage(Language.Type eType) {} // 0x00E400C0-0x00E40140
		public static extern int GetLanguage(); // 0x00E40140-0x00E40150
		public static extern void InitializeWithChangeLanguage(); // 0x00E40150-0x00E40160
		public static extern void Dungeon_LockUI(bool bEnable); // 0x00E40160-0x00E40170
		public static extern bool Dungeon_IsInterruptSaveForFloor(); // 0x00E40170-0x00E40190
		public static extern void Dungeon_DisableInterruptSaveForFloor(); // 0x00E40190-0x00E401A0
		public static extern void PlayerCommand_SetCommand(int playerCommand, byte[] buffer, int length); // 0x00E401A0-0x00E401B0
		public static extern void Dungeon_SetCameraForcus(int memberId); // 0x00E401B0-0x00E401C0
		public static extern void Dungeon_SetCameraForcusByStatus(ulong statusId, uint nativeUniqueId); // 0x00E401C0-0x00E401D0
		public static extern void Dungeon_NaviGuideErase(); // 0x00E401D0-0x00E401E0
		public static extern int Dungeon_CanChangeLeader(int memberId); // 0x00E401E0-0x00E401F0
		public static extern void Dungeon_SetSaveDungeonInfo(); // 0x00E401F0-0x00E40200
		public static extern bool Dungeon_GetACKPlayerCommand(byte[] buffer, int length); // 0x00E40200-0x00E40230
		public static extern bool Dungeon_CalcCheckThinkAutoWalk(); // 0x00E40230-0x00E40250
		public static extern void Dungeon_SetThinkType(int eThinkType); // 0x00E40250-0x00E40260
		public static extern int Dungeon_GetThinkType(); // 0x00E40260-0x00E40270
		public static extern void Dungeon_ChangeCountenance(int type); // 0x00E40270-0x00E40280
		public static extern bool Dungeon_IsCountenance(); // 0x00E40280-0x00E402A0
		public static extern void DungeonInput_SetLock(bool bLock); // 0x00E402A0-0x00E402B0
		public static extern bool Dungeon_CanRemoveMember(); // 0x00E402B0-0x00E402D0
		public static extern int GameData_GetTextRevision(); // 0x00E402D0-0x00E402E0
		public static extern void GameData_SetStatueLevelForDungeon(int level); // 0x00E402E0-0x00E402F0
		public static extern bool GameData_CanTakeOverTrial(); // 0x00E402F0-0x00E40310
		public static extern void GameData_ChangeNormalMode(); // 0x00E40310-0x00E40320
		public static extern void GameData_ChangePerippaaMode(); // 0x00E40320-0x00E40330
		public static extern void GameData_ChangeKunrenMode(); // 0x00E40330-0x00E40340
		public static extern int GameData_GetDungeonArrivalFloor(int dgIndex); // 0x00E40340-0x00E40350
		public static extern void GameData_SetDungeonArrivalFloor(int dgIndex, int floor); // 0x00E40350-0x00E40360
		public static extern bool GameData_IsDungeonClearFlag(int dgIndex); // 0x00E40360-0x00E40380
		public static extern void GameData_SetDungeonClearFlag(int dgIndex, bool bClear); // 0x00E40380-0x00E40390
		public static extern bool GameData_IsNormalMode(); // 0x00E40390-0x00E403B0
		public static extern bool GameData_IsPerippaaMode(); // 0x00E403B0-0x00E403D0
		public static extern bool GameData_IsKunrenMode(); // 0x00E403D0-0x00E403F0
		public static extern int GameData_GetRescueCount(); // 0x00E403F0-0x00E40400
		public static extern void GameData_ResetPlayTime(); // 0x00E40400-0x00E40410
		public static extern ulong GameData_GetPlayStartTimeSec(); // 0x00E40410-0x00E40420
		public static extern ulong GameData_GetPlayStartTimeMilliSec(); // 0x00E40420-0x00E40430
		public static extern void GameData_AddSleepPlayTimeForMilliSec(ulong milliSec); // 0x00E40430-0x00E40440
		public static extern ulong GameData_GetElapsedTimeMilliSec(); // 0x00E40440-0x00E40450
		public static extern void GameData_SetUnlockOldDLCDungeon(bool bEnable); // 0x00E40450-0x00E40460
		public static extern int GameData_GetKyoutekiPokemon(int dungeonIndex); // 0x00E40460-0x00E40470
		public static extern void GameData_UpdateKyoutekiPokemon(); // 0x00E40470-0x00E40480
		public static extern bool GameData_CanAppearKyouteki(int dungeonIndex, int pokemonIndex, bool bIgnoreRare); // 0x00E40480-0x00E404A0
		public static extern int GameData_GetBounusDungeonIndex(); // 0x00E404A0-0x00E404B0
		public static extern void GameData_UpdateBounusDungeon(); // 0x00E404B0-0x00E404C0
		public static extern int GameData_UpdateOpenReliefDungeon(); // 0x00E404C0-0x00E404D0
		public static extern int GameData_GetReliefDungeonOpenDaysLeft(); // 0x00E404D0-0x00E404E0
		public static extern bool GameData_CheckStatueUnlockRankPoint(uint statueHash); // 0x00E404E0-0x00E40500
		public static extern void GameData_GetDungeonStatueLockPokemonList(byte[] outputBuffer, int outputBufferLength); // 0x00E40500-0x00E40510
		public static extern void GameData_GetInvtaionStatueLockPokemonList(byte[] outputBuffer, int outputBufferLength); // 0x00E40510-0x00E40520
		public static extern void GameSaveData_SetSaveMode(int eSaveMode); // 0x00E40520-0x00E40530
		public static extern int GameSaveData_GetSaveMode(); // 0x00E40530-0x00E40540
		public static extern bool GameSaveData_IsSaveStartMode(); // 0x00E40540-0x00E40560
		public static extern bool GameSaveData_IsDungeonSaveMode(); // 0x00E40560-0x00E40580
		public static extern void GameSaveData_SetSaveFreeOrRescueDungeon(bool bEnable); // 0x00E40580-0x00E40590
		public static extern bool GameSaveData_IsSaveFreeOrRescueDungeon(); // 0x00E40590-0x00E405B0
		public static extern bool GameSaveData_IsDungeonRescueWaiting(); // 0x00E405B0-0x00E405D0
		public static extern int GameSaveData_GetRescueCount(); // 0x00E405D0-0x00E405E0
		public static extern int GameSaveData_IncRescueCount(); // 0x00E405E0-0x00E405F0
		public static extern int GameSaveData_GetAdventureCount(); // 0x00E405F0-0x00E40600
		public static extern int GameSaveData_GetSaveDungeonIndex(); // 0x00E40600-0x00E40610
		public static extern int GameSaveData_GetSaveDungeonFloor(); // 0x00E40610-0x00E40620
		public static extern void GameSaveData_InitializeNativeData(); // 0x00E40620-0x00E40630
		public static extern int GameSaveData_SaveNative(byte[] buffer, int index, int length); // 0x00E40630-0x00E40640
		public static extern int GameSaveData_LoadNative(byte[] buffer, int index, int length); // 0x00E40640-0x00E40650
		public static extern int GameSaveData_SaveNativeDungeon(byte[] buffer, int index, int length); // 0x00E40650-0x00E40660
		public static extern uint GameSaveData_GetDugeonSaveCounter(); // 0x00E40660-0x00E40670
		public static extern int GameSaveData_LoadNativeDungeon(byte[] buffer, int index, int length); // 0x00E40670-0x00E40680
		public static extern void GameSaveData_SetPartnerType(int partnerType); // 0x00E40680-0x00E40690
		public static extern void Option_SetOptionValue(int kind, int value); // 0x00E40690-0x00E406A0
		public static extern int Rank_AddPoint(int point); // 0x00E406A0-0x00E406B0
		public static extern int Rank_GetNowRankPoint(); // 0x00E406B0-0x00E406C0
		public static extern int Rank_SetRankPoint(int point); // 0x00E406C0-0x00E406D0
		public static extern int Rank_GetRankPoint(int rank); // 0x00E406D0-0x00E406E0
		public static extern int Rank_GetNextRankPoint(); // 0x00E406E0-0x00E406F0
		public static extern int Rank_GetNowRankIndex(); // 0x00E406F0-0x00E40700
		public static extern int Rank_GetNowName(ushort[] pDst, int length); // 0x00E40700-0x00E40710
		public static extern int Rank_GetNowPrisetNum(); // 0x00E40710-0x00E40720
		public static extern int Rank_GetNowGeneralCampEntryNum(); // 0x00E40720-0x00E40730
		public static extern int Rank_GetItemBagNum(int rank); // 0x00E40730-0x00E40740
		public static extern int Rank_GetPrisetNum(int rank); // 0x00E40740-0x00E40750
		public static extern int Rank_GetQuestTicketListNum(int rank); // 0x00E40750-0x00E40760
		public static extern int Rank_GetGeneralCampEntryNum(int rank); // 0x00E40760-0x00E40770
		public static extern int Rank_GetSekizouSymbol(int rank, byte[] buffer, int length); // 0x00E40770-0x00E40780
		public static extern int Rank_GetFixedRewardIndex(int rank); // 0x00E40780-0x00E40790
		public static extern int Rank_GetFixedAchievedRewardIndex0(int rank); // 0x00E40790-0x00E407A0
		public static extern int Rank_GetFixedAchievedRewardIndex1(int rank); // 0x00E407A0-0x00E407B0
		public static extern int Creature_GetThinkTypeN(int creatureUniqueId); // 0x00E407B0-0x00E407C0
		public static ThinkType Creature_GetThinkType(int creatureUniqueId) => default; // 0x00E407C0-0x00E40840
		public static extern void Creature_GetTypeN(int creatureUniqueId); // 0x00E40840-0x00E40850
		public static extern ulong Creature_GetControlCreatureId(); // 0x00E40850-0x00E40860
		public static extern int Creature_GetList(byte[] buffer, int length); // 0x00E40860-0x00E40870
		public static extern ulong Creature_GetCreatureIdFromCoord(int x, int y); // 0x00E40870-0x00E40880
		public static extern ulong Creature_GetCreatureIdFromStatus(ulong statusId, uint nativeUniqueId); // 0x00E40880-0x00E40890
		public static extern int Creature_GetPokemonIndex(ulong creatureId); // 0x00E40890-0x00E408A0
		public static extern int Creature_GetAppearanceIndex(ulong creatureId); // 0x00E408A0-0x00E408B0
		public static extern bool Creature_GetCreatureCoord(ulong craetureId, int[] coord); // 0x00E408B0-0x00E408E0
		public static extern bool Creature_GetCreatureFloorPosition(ulong craetureId, float[] position3); // 0x00E408E0-0x00E40910
		public static extern bool Creature_IsSpotPosition(ulong craetureId); // 0x00E40910-0x00E40930
		public static extern int Creature_GetCreatureDirection(ulong craetureId); // 0x00E40930-0x00E40940
		public static extern int Creature_FindCreatures(ulong creatureId, int x, int y, int direction, int distance, bool narrowOnly, byte[] buffer, int length); // 0x00E40940-0x00E40960
		public static extern int Creature_FindEnemies(ulong creatureId, int x, int y, int direction, int distance, bool narrowOnly, bool ignoreLook, byte[] buffer, int length); // 0x00E40960-0x00E40980
		public static extern void Creature_SetDeath(ulong creatureId); // 0x00E40980-0x00E40990
		public static extern ulong Creature_GetCreatureStatus(ulong craetureId, uint[] pDst); // 0x00E40990-0x00E409A0
		public static extern void Creature_GetName(ulong craetureId, ushort[] pDst, int length); // 0x00E409A0-0x00E409B0
		public static extern bool Creature_IsPlayer(ulong craetureId); // 0x00E409B0-0x00E409D0
		public static extern bool Creature_IsParty(ulong craetureId); // 0x00E409D0-0x00E409F0
		public static extern bool Creature_IsGuest(ulong craetureId); // 0x00E409F0-0x00E40A10
		public static extern bool Creature_IsGuestParty(ulong craetureId); // 0x00E40A10-0x00E40A30
		public static extern bool Creature_IsQuestGuest(ulong craetureId); // 0x00E40A30-0x00E40A50
		public static extern bool Creature_IsMonster(ulong craetureId); // 0x00E40A50-0x00E40A70
		public static extern bool Creature_IsAlive(ulong craetureId); // 0x00E40A70-0x00E40A90
		public static extern bool Creature_IsPinch(ulong craetureId); // 0x00E40A90-0x00E40AB0
		public static extern bool Creature_IsBigBody(ulong craetureId); // 0x00E40AB0-0x00E40AD0
		public static extern bool Creature_HasBadStatus(ulong craetureId, int statusIndex); // 0x00E40AD0-0x00E40AF0
		public static extern bool Creature_HasNoUseItemBadStatus(ulong craetureId); // 0x00E40AF0-0x00E40B10
		public static extern bool Creature_HasNoTargetItemBadStatus(ulong craetureId); // 0x00E40B10-0x00E40B30
		public static extern bool Creature_HasNoUseWazaBadStatus(ulong craetureId); // 0x00E40B30-0x00E40B50
		public static extern bool Creature_HasNoUseStairsBadStatus(ulong craetureId); // 0x00E40B50-0x00E40B70
		public static extern bool Creature_HasNoUseMenuBadStatus(ulong craetureId); // 0x00E40B70-0x00E40B90
		public static extern bool Creature_SetBadStatus(ulong craetureId, int statusIndex, int turn); // 0x00E40B90-0x00E40BB0
		public static extern bool Creature_ClearBadStatus(ulong craetureId, int statusIndex); // 0x00E40BB0-0x00E40BD0
		public static extern void Creature_ClearBadStatusAll(ulong craetureId); // 0x00E40BD0-0x00E40BE0
		public static extern bool Creature_AddItem(ulong craetureId, uint nativeUniqueId); // 0x00E40BE0-0x00E40C00
		public static extern bool Creature_RemoveItem(ulong craetureId, uint nativeUniqueId); // 0x00E40C00-0x00E40C20
		public static extern int Creature_GetMoraibiStage(ulong craetureId); // 0x00E40C20-0x00E40C30
		public static extern void Creature_CheckWazaAffinity(ulong craetureId, ulong targetId, uint[] pDst); // 0x00E40C30-0x00E40C40
		public static extern int Creature_GetPokemonType(ulong creatureId, int typeIndex); // 0x00E40C40-0x00E40C50
		public static extern uint Creature_SetEquippedItem(ulong creatureId, uint nativeUniqueId); // 0x00E40C50-0x00E40C60
		public static extern int Creature_GetWaza(ulong creatureId, int index, bool original); // 0x00E40C60-0x00E40C70
		public static extern int Creature_GetWazaCount(ulong creatureId, bool original); // 0x00E40C70-0x00E40C80
		public static extern int Creature_GetWazaPP(ulong creatureId, int index, bool original); // 0x00E40C80-0x00E40C90
		public static extern int Creature_GetWazaPPMax(ulong creatureId, int wazaIndex); // 0x00E40C90-0x00E40CA0
		public static extern int Creature_GetWazaName(ulong creatureId, int wazaIndex, bool original, bool bGrade, bool bColor, ushort[] pDst_, int dstMaxCount); // 0x00E40CA0-0x00E40CC0
		public static extern bool Creature_IsEnableWaza(ulong creatureId, int index, bool original); // 0x00E40CC0-0x00E40CE0
		public static extern bool Creature_IsTemporaryWaza(ulong creatureId, int index); // 0x00E40CE0-0x00E40D00
		public static extern void Creature_SetEnableWaza(ulong creatureId, int index, bool set); // 0x00E40D00-0x00E40D10
		public static extern bool Creature_IsLearnedWaza(ulong creatureId, int wazaIndex, bool original); // 0x00E40D10-0x00E40D30
		public static extern bool Creature_IsPossibleUseWaza(ulong creatureId, int index); // 0x00E40D30-0x00E40D50
		public static extern void Creature_ClearTemporaryWaza(ulong creatureId, int index); // 0x00E40D50-0x00E40D60
		public static extern void Creature_SwapWaza(ulong creatureId, int indexA, int indexB); // 0x00E40D60-0x00E40D70
		public static extern int Creature_GetRenketsuList(ulong creatureId, int wazaStatusId, byte[] buffer, int length); // 0x00E40D70-0x00E40D80
		public static extern bool Creature_IsWazaRenketsuParent(ulong creatureId, int index); // 0x00E40D80-0x00E40DA0
		public static extern bool Creature_IsWazaRenketsuChild(ulong creatureId, int index); // 0x00E40DA0-0x00E40DC0
		public static extern int Creature_GetWazaRenketsuParent(ulong creatureId, int index); // 0x00E40DC0-0x00E40DD0
		public static extern int Creature_GetWazaRenketsuChild(ulong creatureId, int index); // 0x00E40DD0-0x00E40DE0
		public static extern void Creature_UpdateSupportNpcUsed(ulong creatureId); // 0x00E40DE0-0x00E40DF0
		public static extern int Creature_GetCharacterModelControlId(ulong creatureId); // 0x00E40DF0-0x00E40E00
		public static extern void WindowText_Startup(byte[] a); // 0x00E40E00-0x00E40E10
		public static extern void WindowText_Shutdown(byte[] a); // 0x00E40E10-0x00E40E20
		public static extern int WindowText_ReplaceValue(ushort[] pDst_, string pSrc_, int dstMaxCount, bool talkOffset, int eFontType); // 0x00E40E20-0x00E40E40
		public static extern int WindowText_ConvertCharNumber(ushort code); // 0x00E40E40-0x00E40E50
		public static extern int WindowText_GetTextWidth_NotReplace(ushort[] pText_, int eFontType, bool bAutoReturnEnd, bool bCharNumber, bool bMultiLine); // 0x00E40E50-0x00E40E70
		public static extern void WindowText_GetRectTableBuffer(byte[] outData_, int outLength, int index); // 0x00E40E70-0x00E40E80
		public static extern int WindowText_GetOffsetWidthTable(int index); // 0x00E40E80-0x00E40E90
		public static extern bool WindowText_GetMarkFrameColorFlagTable(int index); // 0x00E40E90-0x00E40EB0
		public static extern void WindowText_SetForcePlural(bool bForcePlural); // 0x00E40EB0-0x00E40EC0
		public static extern void WindowText_SetTagBufferType_ForUI(); // 0x00E40EC0-0x00E40ED0
		public static extern void WindowText_ResetTagBufferType_ForUI(); // 0x00E40ED0-0x00E40EE0
		public static extern void WindowText_ClearTagBuffer(); // 0x00E40EE0-0x00E40EF0
		public static extern void WindowText_SetString(int index, string pText); // 0x00E40EF0-0x00E40F00
		public static extern void WindowText_SetCreatureString(int index, string pText); // 0x00E40F00-0x00E40F10
		public static extern void WindowText_SetCreatureIndex(int index, int pokemonIndex); // 0x00E40F10-0x00E40F20
		public static extern void WindowText_SetItemString(int index, string pText, string pTextPlural, int textBaseItemIndex); // 0x00E40F20-0x00E40F40
		public static extern void WindowText_SetItemIndex(int index, int itemIndex); // 0x00E40F40-0x00E40F50
		public static extern void WindowText_SetValue(int index, int value); // 0x00E40F50-0x00E40F60
		public static extern void WindowText_SetMoney(int index, int value); // 0x00E40F60-0x00E40F70
		public static extern void WindowText_SetMoneyNi(int index, int value); // 0x00E40F70-0x00E40F80
		public static extern void WindowText_SetDungeonIndex(int index, int dungeonIndex, int nameType); // 0x00E40F80-0x00E40F90
		public static extern void WindowText_SetDungeonIndexFromFloor(int index, int dungeonIndex, int floor, int nameType); // 0x00E40F90-0x00E40FA0
		public static extern void WindowText_SetFloor(int index, int value, int dungeonIndex); // 0x00E40FA0-0x00E40FB0
		public static extern void WindowText_SetFloorWithoutColor(int index, int value, int dungeonIndex); // 0x00E40FB0-0x00E40FC0
		public static extern int WindowText_GetFloorSymbol(ushort[] pDst_, int dstMaxCount, bool bDown); // 0x00E40FC0-0x00E40FE0
		public static extern bool WindowText_GetInfo(uint gfxSymbol, byte[] pDst_, int length); // 0x00E40FE0-0x00E41010
		public static extern bool WindowText_GetInfoList(byte[] pDst_, int length); // 0x00E41010-0x00E41040
		public static extern void TextPool_Reload(); // 0x00E41040-0x00E41050
		public static extern int TextPool_GetCommonText(int textId, ushort[] pDst_, int dstMaxCount, bool bForScriptHash); // 0x00E41050-0x00E41070
		public static extern uint TextPool_GetCommonTextType(int textId); // 0x00E41070-0x00E41080
		public static extern void TextPool_SetupSceneDugeonTextPool(); // 0x00E41080-0x00E41090
		public static extern void TextPool_ResetSceneTextPool(); // 0x00E41090-0x00E410A0
		public static extern int HashCommon_GetItemNameTextId(int itemIndex); // 0x00E410A0-0x00E410B0
		public static extern int HashCommon_GetItemExplainTextId(int itemIndex); // 0x00E410B0-0x00E410C0
		public static extern int HashCommon_GetWazaNameTextId(int wazaIndex); // 0x00E410C0-0x00E410D0
		public static extern int HashCommon_GetWazaExplainTextId(int wazaIndex); // 0x00E410D0-0x00E410E0
		public static extern int HashCommon_GetAbilityExplainTextId(int abilityIndex); // 0x00E410E0-0x00E410F0
		public static extern int HashCommon_GetSugowazaExplainTextId(int sugowazaIndex); // 0x00E410F0-0x00E41100
		public static extern int HashCommon_GetOrderExplainTextId(int sugowazaIndex); // 0x00E41100-0x00E41110
		public static extern int HashCommon_GetStatusExplainTextId(int statusIndex); // 0x00E41110-0x00E41120
		public static extern int HashCommon_GetCampNameTextId(int campIndex); // 0x00E41120-0x00E41130
		public static extern int HashCommon_GetCampExplainTextId(int campIndex); // 0x00E41130-0x00E41140
		public static extern bool PokemonManager_IsAffectSugowaza(int sugowazaIndex); // 0x00E41140-0x00E41160
		public static extern int PokemonManager_GetMegaFormParty(int memberId); // 0x00E41160-0x00E41170
		public static extern int PokemonManager_GetMegaFormGuest(int memberId); // 0x00E41170-0x00E41180
		public static extern bool PokemonStatusUility_IsPinch(int hp, int maxHp); // 0x00E41180-0x00E411A0
		public static extern void PokemonStatus_SetTemporary(ulong baseStatusId, uint baseNativeUniqueId); // 0x00E411A0-0x00E411B0
		public static extern ulong PokemonStatus_GetTemporaryNativeStatusId(); // 0x00E411B0-0x00E411C0
		public static extern uint PokemonStatus_GetUniqueId(ulong statusId); // 0x00E411C0-0x00E411D0
		public static extern bool PokemonStatus_IsEnable(ulong statusId, uint nativeUniqueId); // 0x00E411D0-0x00E411F0
		public static extern int PokemonStatus_GetWarehouseId(ulong statusId, uint nativeUniqueId); // 0x00E411F0-0x00E41200
		public static extern void PokemonStatus_SetWarehouseId(ulong statusId, uint nativeUniqueId, int warehouseId); // 0x00E41200-0x00E41210
		public static extern int PokemonStatus_GetPokemonIndex(ulong statusId, uint nativeUniqueId); // 0x00E41210-0x00E41220
		public static extern void PokemonStatus_SetPokemonIndex(ulong statusId, uint nativeUniqueId, int index); // 0x00E41220-0x00E41230
		public static extern int PokemonStatus_GetHp(ulong statusId, uint nativeUniqueId); // 0x00E41230-0x00E41240
		public static extern int PokemonStatus_SetHpMax(ulong statusId, uint nativeUniqueId); // 0x00E41240-0x00E41250
		public static extern int PokemonStatus_GetMaxHp(ulong statusId, uint nativeUniqueId); // 0x00E41250-0x00E41260
		public static extern int PokemonStatus_SetMaxHp(ulong statusId, uint nativeUniqueId, int value); // 0x00E41260-0x00E41270
		public static extern int PokemonStatus_GetPureMaxHp(ulong statusId, uint nativeUniqueId); // 0x00E41270-0x00E41280
		public static extern int PokemonStatus_GetAddMaxHpValue(ulong statusId, uint nativeUniqueId, int index); // 0x00E41280-0x00E41290
		public static extern int PokemonStatus_GetBelly(ulong statusId, uint nativeUniqueId); // 0x00E41290-0x00E412A0
		public static extern void PokemonStatus_SetMaxBelly(ulong statusId, uint nativeUniqueId, int maxBelly); // 0x00E412A0-0x00E412B0
		public static extern int PokemonStatus_GetMaxBelly(ulong statusId, uint nativeUniqueId); // 0x00E412B0-0x00E412C0
		public static extern int PokemonStatus_GetLevel(ulong statusId, uint nativeUniqueId); // 0x00E412C0-0x00E412D0
		public static extern void PokemonStatus_ChangeLevel(ulong statusId, uint nativeUniqueId, int level); // 0x00E412D0-0x00E412E0
		public static extern int PokemonStatus_GetExperience(ulong statusId, uint nativeUniqueId); // 0x00E412E0-0x00E412F0
		public static extern int PokemonStatus_AddExperience(ulong statusId, uint nativeUniqueId, int addExp); // 0x00E412F0-0x00E41300
		public static extern int PokemonStatus_GetExperienceNextLevel(ulong statusId, uint nativeUniqueId); // 0x00E41300-0x00E41310
		public static extern int PokemonStatus_GetWaza(ulong statusId, uint nativeUniqueId, int id); // 0x00E41310-0x00E41320
		public static extern int PokemonStatus_GetWazaCount(ulong statusId, uint nativeUniqueId); // 0x00E41320-0x00E41330
		public static extern int PokemonStatus_GetGender(ulong statusId, uint nativeUniqueId); // 0x00E41330-0x00E41340
		public static extern int PokemonStatus_SetGender(ulong statusId, uint nativeUniqueId, int gender); // 0x00E41340-0x00E41350
		public static extern void PokemonStatus_GetName(ulong statusId, uint nativeUniqueId, ushort[] pDst, int length); // 0x00E41350-0x00E41360
		public static extern void PokemonStatus_SetName(ulong statusId, uint nativeUniqueId, string pText); // 0x00E41360-0x00E41370
		public static extern int PokemonStatus_GetAttack(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E41370-0x00E41380
		public static extern int PokemonStatus_SetAttack(ulong statusId, uint nativeUniqueId, int value, bool bOriginal); // 0x00E41380-0x00E41390
		public static extern int PokemonStatus_GetDefense(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E41390-0x00E413A0
		public static extern int PokemonStatus_SetDefense(ulong statusId, uint nativeUniqueId, int value, bool bOriginal); // 0x00E413A0-0x00E413B0
		public static extern int PokemonStatus_GetExAttack(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E413B0-0x00E413C0
		public static extern int PokemonStatus_SetExAttack(ulong statusId, uint nativeUniqueId, int value, bool bOriginal); // 0x00E413C0-0x00E413D0
		public static extern int PokemonStatus_GetExDefense(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E413D0-0x00E413E0
		public static extern int PokemonStatus_SetExDefense(ulong statusId, uint nativeUniqueId, int value, bool bOriginal); // 0x00E413E0-0x00E413F0
		public static extern int PokemonStatus_GetSubayasa(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E413F0-0x00E41400
		public static extern int PokemonStatus_SetSubayasa(ulong statusId, uint nativeUniqueId, int value, bool bOriginal); // 0x00E41400-0x00E41410
		public static extern int PokemonStatus_GetNajimi(ulong statusId, uint nativeUniqueId); // 0x00E41410-0x00E41420
		public static extern int PokemonStatus_GetAttackLevel(ulong statusId, uint nativeUniqueId); // 0x00E41420-0x00E41430
		public static extern int PokemonStatus_GetExAttackLevel(ulong statusId, uint nativeUniqueId); // 0x00E41430-0x00E41440
		public static extern int PokemonStatus_GetDefenseLevel(ulong statusId, uint nativeUniqueId); // 0x00E41440-0x00E41450
		public static extern int PokemonStatus_GetExDefenseLevel(ulong statusId, uint nativeUniqueId); // 0x00E41450-0x00E41460
		public static extern int PokemonStatus_GetHitLevel(ulong statusId, uint nativeUniqueId); // 0x00E41460-0x00E41470
		public static extern int PokemonStatus_GetDodgeLevel(ulong statusId, uint nativeUniqueId); // 0x00E41470-0x00E41480
		public static extern float PokemonStatus_GetAttackMagnification(ulong statusId, uint nativeUniqueId); // 0x00E41480-0x00E41490
		public static extern float PokemonStatus_GetExAttackMagnification(ulong statusId, uint nativeUniqueId); // 0x00E41490-0x00E414A0
		public static extern float PokemonStatus_GetDefenseMagnification(ulong statusId, uint nativeUniqueId); // 0x00E414A0-0x00E414B0
		public static extern float PokemonStatus_GetExDefenseMagnification(ulong statusId, uint nativeUniqueId); // 0x00E414B0-0x00E414C0
		public static extern void PokemonStatus_SetWazaPP(ulong statusId, uint nativeUniqueId, int wazaIndex, int value); // 0x00E414C0-0x00E414D0
		public static extern int PokemonStatus_GetWazaPP(ulong statusId, uint nativeUniqueId, int wazaIndex); // 0x00E414D0-0x00E414E0
		public static extern int PokemonStatus_GetWazaPPMax(ulong statusId, uint nativeUniqueId, int wazaIndex); // 0x00E414E0-0x00E414F0
		public static extern int PokemonStatus_GetType(ulong statusId, uint nativeUniqueId, int typeIndex); // 0x00E414F0-0x00E41500
		public static extern int PokemonStatus_GetAbility(ulong statusId, uint nativeUniqueId, bool bOriginal); // 0x00E41500-0x00E41510
		public static extern void PokemonStatus_SetAbility(ulong statusId, uint nativeUniqueId, int abilityIndex, bool bOriginal); // 0x00E41510-0x00E41520
		public static extern int PokemonStatus_GetAbilityIndex(ulong statusId, uint nativeUniqueId); // 0x00E41520-0x00E41530
		public static extern int PokemonStatus_GetSugowaza(ulong statusId, uint nativeUniqueId); // 0x00E41530-0x00E41540
		public static extern void PokemonStatus_SetSugowaza(ulong statusId, uint nativeUniqueId, int abilityIndex); // 0x00E41540-0x00E41550
		public static extern bool PokemonStatus_IsFavor(ulong statusId, uint nativeUniqueId); // 0x00E41550-0x00E41570
		public static extern bool PokemonStatus_IsEnableWaza(ulong statusId, uint nativeUniqueId, int id); // 0x00E41570-0x00E41590
		public static extern void PokemonStatus_SetEnableWaza(ulong statusId, uint nativeUniqueId, int id, bool bSet); // 0x00E41590-0x00E415A0
		public static extern void PokemonStatus_UpdateSupportNpcUsed(ulong statusId, uint nativeUniqueId); // 0x00E415A0-0x00E415B0
		public static extern bool PokemonStatus_IsWazaRenketsuParent(ulong statusId, uint nativeUniqueId, int wazaStatusId); // 0x00E415B0-0x00E415D0
		public static extern bool PokemonStatus_IsWazaRenketsuChild(ulong statusId, uint nativeUniqueId, int wazaStatusId); // 0x00E415D0-0x00E415F0
		public static extern int PokemonStatus_GetWazaRenketsuParentValue(ulong statusId, uint nativeUniqueId, int wazaStatusId); // 0x00E415F0-0x00E41600
		public static extern int PokemonStatus_GetWazaRenketsuChildValue(ulong statusId, uint nativeUniqueId, int wazaStatusId); // 0x00E41600-0x00E41610
		public static extern int PokemonStatus_GetWazaRenketsuList(ulong statusId, uint nativeUniqueId, int wazaStatusId, byte[] buffer, int length); // 0x00E41610-0x00E41620
		public static extern void PokemonStatus_SetWazaRenketsu(ulong statusId, uint nativeUniqueId, int wazaStatusIdParent, int wazaStatusIdChild); // 0x00E41620-0x00E41630
		public static extern void PokemonStatus_RemoveWazaRenketsu(ulong statusId, uint nativeUniqueId, int wazaStatusId); // 0x00E41630-0x00E41640
		public static extern int PokemonStatus_GetWazaRememberList(ulong statusId, uint nativeUniqueId, byte[] buffer, int length); // 0x00E41640-0x00E41650
		public static extern int PokemonDatabase_GetWazaRememberList(Index pokemonIndex, int level, byte[] buffer, int length); // 0x00E41650-0x00E41660
		public static extern int PokemonStatus_GetWazaRememberListWithLevelFilter(ulong statusId, uint nativeUniqueId, byte[] buffer, int length); // 0x00E41660-0x00E41670
		public static extern int PokemonStatus_GetWazaForgetList(ulong statusId, uint nativeUniqueId, byte[] buffer, int length); // 0x00E41670-0x00E41680
		public static extern int PokemonStatus_GetWazaOshieList(ulong statusId, uint nativeUniqueId, byte[] buffer, int length); // 0x00E41680-0x00E41690
		public static extern int PokemonDatabase_GetWazaOshieList(Index pokemonIndex, byte[] buffer, int length); // 0x00E41690-0x00E416A0
		public static extern void PokemonStatus_SetWaza(ulong statusId, uint nativeUniqueId, int wazaListIndex, int wazaIndex); // 0x00E416A0-0x00E416B0
		public static extern void PokemonStatus_ClearWaza(ulong statusId, uint nativeUniqueId, int wazaListIndex); // 0x00E416B0-0x00E416C0
		public static extern void PokemonStatus_SwapWaza(ulong statusId, uint nativeUniqueId, int wazaStatusIdA, int wazaStatusIdB); // 0x00E416C0-0x00E416D0
		public static extern bool PokemonStatus_AddWaza(ulong statusId, uint nativeUniqueId, int wazaIndex); // 0x00E416D0-0x00E416F0
		public static extern int PokemonStatus_GetEquippedItem(ulong statusId, uint nativeUniqueId); // 0x00E416F0-0x00E41700
		public static extern int PokemonStatus_GetOrderIndex(ulong statusId, uint nativeUniqueId); // 0x00E41700-0x00E41710
		public static extern void PokemonStatus_SetOrderIndex(ulong statusId, uint nativeUniqueId, int orderIndex); // 0x00E41710-0x00E41720
		public static extern bool PokemonStatus_CanAddParty(ulong statusId, uint nativeUniqueId); // 0x00E41720-0x00E41740
		public static extern bool PokemonStatus_IsStandBy(ulong statusId, uint nativeUniqueId); // 0x00E41740-0x00E41760
		public static extern int PokemonStatus_GetHistoryEvolutionPokemonLevel(ulong statusId, uint nativeUniqueId, int historyId); // 0x00E41760-0x00E41770
		public static extern int PokemonStatus_GetHistoryEvolutionPokemonIndex(ulong statusId, uint nativeUniqueId, int historyId); // 0x00E41770-0x00E41780
		public static extern void PokemonStatus_SetEvolutionInfo(ulong statusId, uint nativeUniqueId, int index, int creatureIndex, int level); // 0x00E41780-0x00E41790
		public static extern void PokemonStatus_SetPokemonTypeToStatus(ulong statusId, uint nativeUniqueId, int typeIndex, int type); // 0x00E41790-0x00E417A0
		public static extern int PokemonStatus_GetPokemonTalkMessage(ulong statusId, uint nativeUniqueId, uint sceneType, bool bBossScene); // 0x00E417A0-0x00E417B0
		public static extern void PokemonStatus_UpdateMyuuStatus(ulong dstStatusId, uint dstNativeUniqueId, ulong srcStatusId, uint srcNativeUniqueId); // 0x00E417B0-0x00E417C0
		public static extern int PokemonWarehouse_GetEnableList(byte[] buffer, int length); // 0x00E417C0-0x00E417D0
		public static extern bool PokemonWarehouse_GetStatus(int whId, byte[] buffer, int length); // 0x00E417D0-0x00E41800
		public static extern void PokemonWarehouse_InitializeHero(int pokemonIndex, int genderType); // 0x00E41800-0x00E41810
		public static extern bool PokemonWarehouse_InitializePartner(int pokemonIndex, int genderType); // 0x00E41810-0x00E41830
		public static extern bool PokemonWarehouse_SetForce(int whId, int pokemonIndex); // 0x00E41830-0x00E41850
		public static extern int PokemonWarehouse_Add(int pokemonIndex); // 0x00E41850-0x00E41860
		public static extern int PokemonWarehouse_AddFromStatus(ulong statusId, uint nativeUniqueId); // 0x00E41860-0x00E41870
		public static extern bool PokemonWarehouse_Remove(int whId); // 0x00E41870-0x00E41890
		public static extern int PokemonWarehouse_CalcNumBelongingToCamp(int campIndex); // 0x00E41890-0x00E418A0
		public static extern int PokemonWarehouse_GetMaxNumBelongingToCamp(int campIndex); // 0x00E418A0-0x00E418B0
		public static extern int PokemonWarehouse_FindFixedCreatureParameterIndex(int whId); // 0x00E418B0-0x00E418C0
		public static extern int PokemonWarehouseStatus_GetFriendSortId(int whId, uint nativeUniqueId); // 0x00E418C0-0x00E418D0
		public static extern void PokemonWarehouseStatus_UpdateFriendSortId(int whId, uint nativeUniqueId); // 0x00E418D0-0x00E418E0
		public static extern int PokemonWarehouseStatus_GetSallyType(int whId, uint nativeUniqueId); // 0x00E418E0-0x00E418F0
		public static extern void PokemonWarehouseStatus_SetSallyType(int whId, uint nativeUniqueId, int sally); // 0x00E418F0-0x00E41900
		public static extern bool PokemonWarehouseStatus_IsSallyOtherMode(int whId, uint nativeUniqueId); // 0x00E41900-0x00E41920
		public static extern bool PokemonWarehouseStatus_IsVisible(int whId, uint nativeUniqueId); // 0x00E41920-0x00E41940
		public static extern bool PokemonWarehouseStatus_SetVisible(int whId, uint nativeUniqueId, bool bEnable); // 0x00E41940-0x00E41960
		public static extern bool PokemonWarehouseStatus_IsFavor(int whId, uint nativeUniqueId); // 0x00E41960-0x00E41980
		public static extern bool PokemonWarehouseStatus_SetFavor(int whId, uint nativeUniqueId, bool bEnable); // 0x00E41980-0x00E419A0
		public static extern int PokemonWarehouse_GetExistList_HonkeNo(byte[] buffer, int length); // 0x00E419A0-0x00E419B0
		public static extern int PokemonWarehouse_GetExistList_Index(byte[] buffer, int length); // 0x00E419B0-0x00E419C0
		public static extern int FixedCreatureParameter_GetWazaList(int fixedIndex, byte[] buffer, int length); // 0x00E419C0-0x00E419D0
		public static extern void Party_SetName(string text); // 0x00E419D0-0x00E419E0
		public static extern void Party_GetName(ushort[] pDst_, int dstMaxCount); // 0x00E419E0-0x00E419F0
		public static extern int PartyMember_GetPlayerMemberId(); // 0x00E419F0-0x00E41A00
		public static extern int PartyMember_GetCount(); // 0x00E41A00-0x00E41A10
		public static extern void PartyMember_AllRemovePartyMember(bool bFeedbackWarehouse); // 0x00E41A10-0x00E41A20
		public static extern int PartyMember_AddPartyMember(int wId, bool bSetPlayer); // 0x00E41A20-0x00E41A30
		public static extern int PartyMember_GetList(byte[] buffer, int length); // 0x00E41A30-0x00E41A40
		public static extern int PartyMember_GetListModeNormal(byte[] buffer, int length); // 0x00E41A40-0x00E41A50
		public static extern int PartyMember_GetListModePerippaa(byte[] buffer, int length); // 0x00E41A50-0x00E41A60
		public static extern void PartyMember_UpdatePartyPokemonStatusFromWarehouseStatus(); // 0x00E41A60-0x00E41A70
		public static extern bool PokemonDatabase_IsEnable(int pokemonIndex); // 0x00E41A70-0x00E41A90
		public static extern bool PokemonDatabase_IsEnableFromGfxSymbol(int gfxSymbol); // 0x00E41A90-0x00E41AB0
		public static extern bool PokemonDatabase_IsOrganization(int pokemonIndex); // 0x00E41AB0-0x00E41AD0
		public static extern bool PokemonDatabase_IsJiraachiNegaigoto(int pokemonIndex); // 0x00E41AD0-0x00E41AF0
		public static extern int PokemonDatabase_GetBookId(int pokemonIndex); // 0x00E41AF0-0x00E41B00
		public static extern int PokemonDatabase_GetBookSortId(int pokemonIndex, bool bFemale); // 0x00E41B00-0x00E41B10
		public static extern int PokemonDatabase_GetHonkeKindNo(int pokemonIndex); // 0x00E41B10-0x00E41B20
		public static extern int PokemonDatabase_GetName(int pokemonIndex, ushort[] pDst_, int dstMaxCount); // 0x00E41B20-0x00E41B30
		public static extern int PokemonDatabase_GetType(int pokemonType, int id); // 0x00E41B30-0x00E41B40
		public static extern int PokemonDatabase_GetTypeName(int pokemonType, ushort[] pDst_, int dstMaxCount); // 0x00E41B40-0x00E41B50
		public static extern int PokemonDatabase_GetTypeIconTag(int pokemonType, ushort[] pDst_, int dstMaxCount); // 0x00E41B50-0x00E41B60
		public static extern int PokemonDatabase_GetBookKindName(int pokemonIndex, ushort[] pDst_, int dstMaxCount); // 0x00E41B60-0x00E41B70
		public static extern int PokemonDatabase_GetAbilityName(int pokemonAbility, bool bColor, ushort[] pDst_, int dstMaxCount); // 0x00E41B70-0x00E41B90
		public static extern int PokemonDatabase_GetSugowazaName(int pokemonSugowaza, bool bColor, bool bIcon, ushort[] pDst_, int dstMaxCount); // 0x00E41B90-0x00E41BB0
		public static extern int PokemonDatabase_GetOrderName(int pokemonOrder, ushort[] pDst_, int dstMaxCount); // 0x00E41BB0-0x00E41BC0
		public static extern int PokemonDatabase_GetCampIndex(int pokemonIndex); // 0x00E41BC0-0x00E41BD0
		public static extern bool PokemonDatabase_IsScenarioProgress(int pokemonIndex); // 0x00E41BD0-0x00E41BF0
		public static extern bool PokemonDatabase_CanAddParty(int pokemonIndex); // 0x00E41BF0-0x00E41C10
		public static extern bool PokemonDatabase_CanAddPartyForShop(int pokemonIndex); // 0x00E41C10-0x00E41C30
		public static extern int PokemonDatabase_GetRetrogradeIndex(int index); // 0x00E41C30-0x00E41C40
		public static extern int PokemonDatabase_GetMinLevel(int index); // 0x00E41C40-0x00E41C50
		public static extern int PokemonDatabase_GetMinLevelForFriend(int index); // 0x00E41C50-0x00E41C60
		public static extern bool PokemonDatabase_CheckFindFormFemaleFromGraphicIndex(int gfxSymbol); // 0x00E41C60-0x00E41C80
		public static extern int PokemonDatabase_DrawingSugowaza(int index, float adjustRate); // 0x00E41C80-0x00E41C90
		public static extern int PokemonDatabase_GetHeroAndPartner_InitIndex(int index); // 0x00E41C90-0x00E41CA0
		public static extern bool PokemonDatabase_IsRareColor(int index); // 0x00E41CA0-0x00E41CC0
		public static extern bool PokemonDatabase_IsIgnoreBaisokuMotion(int index); // 0x00E41CC0-0x00E41CE0
		public static extern float PokemonDatabase_GetWalkSpeed(int index, int eForm); // 0x00E41CE0-0x00E41CF0
		public static extern float PokemonDatabase_GetRunRateGround(int index, int eForm); // 0x00E41CF0-0x00E41D00
		public static extern bool PokemonDatabase_HasWazamachine(int index, int wazaMachine); // 0x00E41D00-0x00E41D20
		public static extern int PokemonDatabase_GetKyoutekiWeak(int index, byte[] buffer, int length); // 0x00E41D20-0x00E41D30
		public static extern int PokemonDatabase_GetAbility(Index index, int abilityIndex); // 0x00E41D30-0x00E41D40
		public static extern int PokemonDatabase_GetOrganizationId(Index index); // 0x00E41D40-0x00E41D50
		public static extern int StatusDatabase_GetName(int statusIndex, ushort[] pDst_, int dstMaxCount); // 0x00E41D50-0x00E41D60
		public static extern bool StatusDatabase_IsHiddenStatus(int statusIndex); // 0x00E41D60-0x00E41D80
		public static extern int ActDatabase_GetWazaType(int act); // 0x00E41D80-0x00E41D90
		public static extern int ActDatabase_GetWazaAttribute(int act); // 0x00E41D90-0x00E41DA0
		public static extern int ActDatabase_GetMaxRange(int act); // 0x00E41DA0-0x00E41DB0
		public static extern int ActDatabase_GetSurfaceRange(int act); // 0x00E41DB0-0x00E41DC0
		public static extern int ActDatabase_GetSurfaceTarget(int act); // 0x00E41DC0-0x00E41DD0
		public static extern int ActDatabase_GetPower(int act); // 0x00E41DD0-0x00E41DE0
		public static extern int ActDatabase_GetPowerLimit(int act); // 0x00E41DE0-0x00E41DF0
		public static extern int ActDatabase_GetPP(int act); // 0x00E41DF0-0x00E41E00
		public static extern int ActDatabase_GetPPLimit(int act); // 0x00E41E00-0x00E41E10
		public static extern int ActDatabase_GetHitRate(int act); // 0x00E41E10-0x00E41E20
		public static extern int ActDatabase_GetHitRateLimit(int act); // 0x00E41E20-0x00E41E30
		public static extern bool ActDatabase_IsHitchuu(int act); // 0x00E41E30-0x00E41E50
		public static extern int PokemonStatus_GetWazaName(int wazaIndex, ulong statusId, uint nativeUniqueId, bool bGrade, bool bColor, ushort[] pDst_, int dstMaxCount); // 0x00E41E50-0x00E41E70
		public static extern int WazaDatabase_GetName(int wazaIndex, bool bGrade, bool bColor, ushort[] pDst_, int dstMaxCount); // 0x00E41E70-0x00E41E90
		public static extern int WazaDatabase_GetPureName(int wazaIndex, ushort[] pDst_, int dstMaxCount); // 0x00E41E90-0x00E41EA0
		public static extern int WazaDatabase_GetActIndex(int wazaIndex); // 0x00E41EA0-0x00E41EB0
		public static extern int WazaDatabase_GetActIndexFromCreature(int wazaIndex, ulong creatureId); // 0x00E41EB0-0x00E41EC0
		public static extern int WazaDatabase_GetActIndexFromStatus(int wazaIndex, ulong statusId, uint nativeUniqueId, int weather, bool bSleep); // 0x00E41EC0-0x00E41ED0
		public static extern bool WazaDatabase_CheckForbiddenRenketsu(int wazaIndex); // 0x00E41ED0-0x00E41EF0
		public static extern int WazaDatabase_GetGrade(int wazaIndex); // 0x00E41EF0-0x00E41F00
		public static extern int WazaDatabase_GetExperience(int wazaIndex); // 0x00E41F00-0x00E41F10
		public static extern int WazaDatabase_GetPower(int wazaIndex, bool defaultValue, bool tameSupport); // 0x00E41F10-0x00E41F20
		public static extern int WazaDatabase_GetHitRate(int wazaIndex, bool defaultValue, bool tameSupport); // 0x00E41F20-0x00E41F30
		public static extern int WazaDatabase_GetPP(int wazaIndex, bool defaultValue, bool tameSupport); // 0x00E41F30-0x00E41F40
		public static extern void WazaDatabase_SetGrade(int wazaIndex, int grade); // 0x00E41F40-0x00E41F50
		public static extern void WazaDatabase_SetExperience(int wazaIndex, int value); // 0x00E41F50-0x00E41F60
		public static extern void WazaDatabase_SetPower(int wazaIndex, int value); // 0x00E41F60-0x00E41F70
		public static extern void WazaDatabase_SetHitRate(int wazaIndex, int value); // 0x00E41F70-0x00E41F80
		public static extern void WazaDatabase_SetPP(int wazaIndex, int value); // 0x00E41F80-0x00E41F90
		public static extern int WazaDatabase_AddPower(int wazaIndex, int value); // 0x00E41F90-0x00E41FA0
		public static extern int WazaDatabase_AddHitRate(int wazaIndex, int value); // 0x00E41FA0-0x00E41FB0
		public static extern int WazaDatabase_AddPP(int wazaIndex, int value); // 0x00E41FB0-0x00E41FC0
		public static extern int WazaDatabase_GetPowerLimit(int wazaIndex); // 0x00E41FC0-0x00E41FD0
		public static extern int WazaDatabase_GetHitRateLimit(int wazaIndex); // 0x00E41FD0-0x00E41FE0
		public static extern int WazaDatabase_GetPPLimit(int wazaIndex); // 0x00E41FE0-0x00E41FF0
		public static extern int ItemDatabase_GetItemPrice(int itemIndex, int type); // 0x00E41FF0-0x00E42000
		public static extern int ItemDatabase_GetItemCategory(int itemIndex); // 0x00E42000-0x00E42010
		public static extern int ItemDatabase_GetItemSortID(int itemIndex); // 0x00E42010-0x00E42020
		public static extern bool ItemDatabase_IsEnableItem(int itemIndex); // 0x00E42020-0x00E42040
		public static extern int ItemDatabase_GetKind(int itemIndex); // 0x00E42040-0x00E42050
		public static extern int ItemDatabase_GetRiseParameterStatus(int itemIndex, ushort[] pDst_, int length); // 0x00E42050-0x00E42060
		public static extern bool ItemDatabase_IsNumberItem(int itemIndex); // 0x00E42060-0x00E42080
		public static extern bool ItemDatabase_IsShootingKind(int itemIndex); // 0x00E42080-0x00E420A0
		public static extern int ItemDatabase_GetName(int itemIndex, ushort[] pDst_, int dstMaxCount, bool bPlural); // 0x00E420A0-0x00E420C0
		public static extern bool ItemDatabase_IsHighClassChest(int itemIndex); // 0x00E420C0-0x00E420E0
		public static extern bool ItemDatabase_IsSecureItem(int itemIndex); // 0x00E420E0-0x00E42100
		public static extern int ItemDatabase_GetCommandType(int itemIndex); // 0x00E42100-0x00E42110
		public static extern int ItemDatabase_GetLearningWazaIndex(int itemIndex); // 0x00E42110-0x00E42120
		public static extern int ItemDatabase_GetThumbnailFileName(int itemIndex, byte[] buffer, int length); // 0x00E42120-0x00E42130
		public static extern int ItemDatabase_GetItemFileName(int itemIndex, byte[] buffer, int length); // 0x00E42130-0x00E42140
		public static extern void ItemDatabase_GetColor(int itemIndex, byte[] buffer, int length); // 0x00E42140-0x00E42150
		public static extern int ItemWarehouse_GetCount(); // 0x00E42150-0x00E42160
		public static extern int ItemWarehouse_GetMax(); // 0x00E42160-0x00E42170
		public static extern int ItemWarehouse_GetItemCount(int itemIndex); // 0x00E42170-0x00E42180
		public static extern int ItemWarehouse_GetItemMax(int itemIndex); // 0x00E42180-0x00E42190
		public static extern void ItemWarehouse_AllClear(); // 0x00E42190-0x00E421A0
		public static extern bool ItemWarehouse_DepositItemWarehouse(uint nativeUniqueId); // 0x00E421A0-0x00E421C0
		public static extern uint ItemWarehouse_DrawOutItemWarehouse(byte[] buffer, int length, int itemIndex, int count); // 0x00E421C0-0x00E421D0
		public static extern int ItemWarehouse_GetItemList(byte[] buffer, int length); // 0x00E421D0-0x00E421E0
		public static extern void Bank_SetMoney(int money); // 0x00E421E0-0x00E421F0
		public static extern void Bank_AddMoney(int money); // 0x00E421F0-0x00E42200
		public static extern int Bank_GetMoney(); // 0x00E42200-0x00E42210
		public static extern int ItemBag_GetBagMode(); // 0x00E42210-0x00E42220
		public static extern void ItemBag_GetItemList(int type, byte[] buffer, int length); // 0x00E42220-0x00E42230
		public static extern uint ItemBag_GetItem(int type, int id); // 0x00E42230-0x00E42240
		public static extern int ItemBag_GetItemNum(int type, int itemIndex); // 0x00E42240-0x00E42250
		public static extern int ItemBag_GetNum(int type); // 0x00E42250-0x00E42260
		public static extern int ItemBag_GetMax(int type); // 0x00E42260-0x00E42270
		public static extern int ItemBag_GetCapacity(int type); // 0x00E42270-0x00E42280
		public static extern bool ItemBag_AddItem(int type, uint nativeUniqueId); // 0x00E42280-0x00E422A0
		public static extern bool ItemBag_DeleteItem(int type, uint nativeUniqueId); // 0x00E422A0-0x00E422C0
		public static extern bool ItemBag_Sort(int type); // 0x00E422C0-0x00E422E0
		public static extern bool ItemBag_ReduceItem(int type); // 0x00E422E0-0x00E42300
		public static extern int ItemBag_GetMoney(); // 0x00E42300-0x00E42310
		public static extern void ItemBag_AddMoney(int add); // 0x00E42310-0x00E42320
		public static extern void ItemBag_SetMoney(int money); // 0x00E42320-0x00E42330
		public static extern uint ItemBag_GetRegisterdItem(int type); // 0x00E42330-0x00E42340
		public static extern bool Foot_ExistItem(ulong creatureId); // 0x00E42340-0x00E42360
		public static extern uint Foot_GetItem(ulong creatureId); // 0x00E42360-0x00E42370
		public static extern uint Item_CreateFromManaged(int index, int count); // 0x00E42370-0x00E42380
		public static extern void Item_DestroyFromManaged(uint nativeUniqueId); // 0x00E42380-0x00E42390
		public static extern void Item_DestroyImmidiateFromManaged(uint nativeUniqueId); // 0x00E42390-0x00E423A0
		public static extern int Item_GetIndex(uint nativeUniqueId); // 0x00E423A0-0x00E423B0
		public static extern int Item_GetKind(uint nativeUniqueId); // 0x00E423B0-0x00E423C0
		public static extern int Item_GetCount(uint nativeUniqueId); // 0x00E423C0-0x00E423D0
		public static extern void Item_SetCount(uint nativeUniqueId, int value); // 0x00E423D0-0x00E423E0
		public static extern void Item_SetShopGoods(uint nativeUniqueId, bool bEnable); // 0x00E423E0-0x00E423F0
		public static extern bool Item_IsShopGoods(uint nativeUniqueId); // 0x00E423F0-0x00E42410
		public static extern void Item_GetName(uint nativeUniqueId, ushort[] pDst, int length, bool bPlural); // 0x00E42410-0x00E42430
		public static extern void Item_GetNameNoCount(uint nativeUniqueId, ushort[] pDst, int length, bool bPlural); // 0x00E42430-0x00E42450
		public static extern int Item_GetPrice(uint nativeUniqueId, int type); // 0x00E42450-0x00E42460
		public static extern int Item_GetPurePrice(uint nativeUniqueId, int type); // 0x00E42460-0x00E42470
		public static extern void Item_SetSticky(uint nativeUniqueId, bool set); // 0x00E42470-0x00E42480
		public static extern bool Item_IsSticky(uint nativeUniqueId); // 0x00E42480-0x00E424A0
		public static extern bool Item_IsGrouped(uint nativeUniqueId); // 0x00E424A0-0x00E424C0
		public static extern bool Item_IsPlaced(uint nativeUniqueId); // 0x00E424C0-0x00E424E0
		public static extern bool Item_IsEquipped(uint nativeUniqueId); // 0x00E424E0-0x00E42500
		public static extern bool Item_IsRegistered(uint nativeUniqueId); // 0x00E42500-0x00E42520
		public static extern bool Item_Fall(uint nativeUniqueId, ulong creatureNativeId, int x, int y, bool curve, bool flat); // 0x00E42520-0x00E42550
		public static extern int Item_GetContentItemIndex(uint nativeUniqueId); // 0x00E42550-0x00E42560
		public static extern void Item_SetHidden(uint nativeUniqueId, bool set); // 0x00E42560-0x00E42570
		public static extern bool Item_IsHidden(uint nativeUniqueId); // 0x00E42570-0x00E42590
		public static extern ulong QuestReward_SetupTemporaryPokemonStatus(int index, int lv); // 0x00E42590-0x00E425A0
		public static extern ulong QuestReward_SetupTemporaryPokemonStatusFromFixedCreatureParameter(int index, int fixedCreatureIndex); // 0x00E425A0-0x00E425B0
		public static extern ulong QuestTicket_CreateDebug(int variation, int dungeon, int floor); // 0x00E425B0-0x00E425C0
		public static extern ulong QuestBulletinBoardTicket_CreateFixedVariation(int variation, int dungeon, int floor); // 0x00E425C0-0x00E425D0
		public static extern int QuestTicket_Destroy(ulong nativePointerId); // 0x00E425D0-0x00E425E0
		public static extern bool QuestTicket_IsGround(ulong nativePointerId); // 0x00E425E0-0x00E42600
		public static extern bool QuestTicket_IsDungeon(ulong nativePointerId); // 0x00E42600-0x00E42620
		public static extern int QuestTicket_GetQuestKind(ulong nativePointerId); // 0x00E42620-0x00E42630
		public static extern int QuestTicket_GetExecuteVariation(ulong nativePointerId); // 0x00E42630-0x00E42640
		public static extern bool QuestTicket_IsRequest(ulong nativePointerId); // 0x00E42640-0x00E42660
		public static extern bool QuestTicket_IsExecution(ulong nativePointerId); // 0x00E42660-0x00E42680
		public static extern bool QuestTicket_IsCompleteReward(ulong nativePointerId); // 0x00E42680-0x00E426A0
		public static extern bool QuestTicket_IsCompleteFailed(ulong nativePointerId); // 0x00E426A0-0x00E426C0
		public static extern bool QuestTicket_IsFinish(ulong nativePointerId); // 0x00E426C0-0x00E426E0
		public static extern void QuestTicket_SetStatusRequest(ulong nativePointerId); // 0x00E426E0-0x00E426F0
		public static extern void QuestTicket_SetStatusExecution(ulong nativePointerId); // 0x00E426F0-0x00E42700
		public static extern void QuestTicket_SetStatusCompleteReward(ulong nativePointerId); // 0x00E42700-0x00E42710
		public static extern void QuestTicket_SetStatusCompleteFailed(ulong nativePointerId); // 0x00E42710-0x00E42720
		public static extern void QuestTicket_SetStatusFinish(ulong nativePointerId); // 0x00E42720-0x00E42730
		public static extern bool QuestTicket_IsPoolBulletinBoard(ulong nativePointerId); // 0x00E42730-0x00E42750
		public static extern bool QuestTicket_IsPoolQuestTicketList(ulong nativePointerId); // 0x00E42750-0x00E42770
		public static extern int QuestTicketList_PenaltyQuestTicketForDungeonTerminate(int dungeonIndex); // 0x00E42770-0x00E42780
		public static extern uint QuestTicket_GetBurnId(ulong nativePointerId); // 0x00E42780-0x00E42790
		public static extern int QuestTicket_GetClientIndex(ulong nativePointerId); // 0x00E42790-0x00E427A0
		public static extern int QuestTicket_GetTargetDungeonIndex(ulong nativePointerId); // 0x00E427A0-0x00E427B0
		public static extern int QuestTicket_GetTargetDungeonFloor(ulong nativePointerId); // 0x00E427B0-0x00E427C0
		public static extern int QuestTicket_GetTargetItem(ulong nativePointerId); // 0x00E427C0-0x00E427D0
		public static extern int QuestTicket_GetTargetPokemon(ulong nativePointerId); // 0x00E427D0-0x00E427E0
		public static extern int QuestTicket_GetTitleTextId(ulong nativePointerId); // 0x00E427E0-0x00E427F0
		public static extern int QuestTicket_GetExplanation0TextId(ulong nativePointerId); // 0x00E427F0-0x00E42800
		public static extern int QuestTicket_GetExplanation1TextId(ulong nativePointerId); // 0x00E42800-0x00E42810
		public static extern int QuestTicket_GetTextPurpose(ulong nativePointerId); // 0x00E42810-0x00E42820
		public static extern int QuestTicket_GetRank(ulong nativePointerId); // 0x00E42820-0x00E42830
		public static extern int QuestTicket_GetRankTextId(ulong nativePointerId); // 0x00E42830-0x00E42840
		public static extern int QuestTicket_GetRewardItems(ulong nativePointerId, byte[] buffer, int length); // 0x00E42840-0x00E42850
		public static extern bool QuestTicket_GetRewardPokemon(ulong nativePointerId, byte[] buffer, int length); // 0x00E42850-0x00E42880
		public static extern int QuestTicket_GetRewardMoney(ulong nativePointerId); // 0x00E42880-0x00E42890
		public static extern int QuestTicket_GetRewardRankPoint(ulong nativePointerId); // 0x00E42890-0x00E428A0
		public static extern int QuestTicket_SetWindowTextTag(ulong nativePointerId); // 0x00E428A0-0x00E428B0
		public static extern bool QuestTicket_IsMissionImpossible(ulong nativePointerId); // 0x00E428B0-0x00E428D0
		public static extern bool QuestTicket_IsMenuHidden(ulong nativePointerId); // 0x00E428D0-0x00E428F0
		public static extern int QuestWonderMailTicket_CanCreateFixed(uint hash); // 0x00E428F0-0x00E42900
		public static extern ulong QuestWonderMailTicket_CreateFixed(uint hash); // 0x00E42900-0x00E42910
		public static extern uint QuestWonderMailTicket_GetFixedHash(ulong nativePointerId); // 0x00E42910-0x00E42920
		public static extern int QuestTicketList_GetList(byte[] buffer, int length); // 0x00E42920-0x00E42930
		public static extern int QuestBulletinBoard_GetList(byte[] buffer, int length); // 0x00E42930-0x00E42940
		public static extern bool QuestTicketList_IsFull(); // 0x00E42940-0x00E42960
		public static extern bool QuestTicketList_Add(ulong nativePointerId); // 0x00E42960-0x00E42980
		public static extern bool QuestTicket_IsWonderMail(ulong nativePointerId); // 0x00E42980-0x00E429A0
		public static extern void QuestBulletinBoard_UpdateQuest(); // 0x00E429A0-0x00E429B0
		public static extern void QuestBulletinBoard_Debug_ClearAll(); // 0x00E429B0-0x00E429C0
		public static extern void QuestDebug_QuestRequestAndExecutionToComplete(); // 0x00E429C0-0x00E429D0
		public static extern bool QuestDebug_IsRewardJoinPokemon(); // 0x00E429D0-0x00E429F0
		public static extern void QuestDebug_SetRewardJoinPokemon(bool bEnable); // 0x00E429F0-0x00E42A00
		public static extern int Post_GetMax(); // 0x00E42A00-0x00E42A10
		public static extern int Post_GetList(byte[] buffer, int length); // 0x00E42A10-0x00E42A20
		public static extern bool Post_UpdateNewsAndQuest(); // 0x00E42A20-0x00E42A40
		public static extern void Post_ShowNews(int newsIndex); // 0x00E42A40-0x00E42A50
		public static extern void Post_AddNews(int newsIndex); // 0x00E42A50-0x00E42A60
		public static extern void Post_EraseNewsAll(); // 0x00E42A60-0x00E42A70
		public static extern void Post_ShowNewsAll(); // 0x00E42A70-0x00E42A80
		public static extern void Post_PresentNewsNextDay(); // 0x00E42A80-0x00E42A90
		public static extern int NewsTicket_GetNewsIndex(ulong nativePointerId); // 0x00E42A90-0x00E42AA0
		public static extern int News_GetTitleTextId(int index); // 0x00E42AA0-0x00E42AB0
		public static extern int News_GetNewsTextId(int index); // 0x00E42AB0-0x00E42AC0
		public static extern int News_GetPresentItem(int index); // 0x00E42AC0-0x00E42AD0
		public static extern int News_GetPresentNum(int index); // 0x00E42AD0-0x00E42AE0
		public static extern int News_GetSortKey(int index); // 0x00E42AE0-0x00E42AF0
		public static extern bool News_IsLotteryNews(int index); // 0x00E42AF0-0x00E42B10
		public static extern int News_GetNo(int index); // 0x00E42B10-0x00E42B20
		public static extern int FriendRescueTicketList_GetList(byte[] buffer, int length); // 0x00E42B20-0x00E42B30
		public static extern ulong FriendRescueTicket_CreateSOS(int dungeonIndex, int floor); // 0x00E42B30-0x00E42B40
		public static extern ulong FriendRescueTicket_CreateBlank(); // 0x00E42B40-0x00E42B50
		public static extern void FriendRescueTicket_GetTicketData(ulong nativePointerId, byte[] buffer, int bufferLength); // 0x00E42B50-0x00E42B60
		public static extern void FriendRescueTicket_SetTicketData(ulong nativePointerId, byte[] buffer, int bufferLength); // 0x00E42B60-0x00E42B70
		public static extern void FriendRescueTicket_Destroy(ulong nativePointerId); // 0x00E42B70-0x00E42B80
		public static extern void FriendRescueTicket_SetTemporary(ulong nativePointerId, bool bEnable); // 0x00E42B80-0x00E42B90
		public static extern bool FriendRescueTicket_IsTemporary(ulong nativePointerId); // 0x00E42B90-0x00E42BB0
		public static extern bool FriendRescueTicket_IsRequest(ulong nativePointerId); // 0x00E42BB0-0x00E42BD0
		public static extern bool FriendRescueTicket_IsExecution(ulong nativePointerId); // 0x00E42BD0-0x00E42BF0
		public static extern bool FriendRescueTicket_IsCompleteReward(ulong nativePointerId); // 0x00E42BF0-0x00E42C10
		public static extern void FriendRescueTicket_SetStatusExecution(ulong nativePointerId); // 0x00E42C10-0x00E42C20
		public static extern void FriendRescueTicket_SetStatusCompleteReward(ulong nativePointerId); // 0x00E42C20-0x00E42C30
		public static extern int FriendRescueTicket_GetClientIndex(ulong nativePointerId); // 0x00E42C30-0x00E42C40
		public static extern uint FriendRescueTicket_GetUniqueSosKey(ulong nativePointerId); // 0x00E42C40-0x00E42C50
		public static extern void FriendRescueTicket_SetMailType(ulong nativePointerId, int type); // 0x00E42C50-0x00E42C60
		public static extern int FriendRescueTicket_GetMailType(ulong nativePointerId); // 0x00E42C60-0x00E42C70
		public static extern bool FriendRescueTicket_IsMyMail(ulong nativePointerId); // 0x00E42C70-0x00E42C90
		public static extern void FriendRescueTicket_SetMyMail(ulong nativePointerId, bool bEnable); // 0x00E42C90-0x00E42CA0
		public static extern int FriendRescueTicket_GetRescuedNo(ulong nativePointerId); // 0x00E42CA0-0x00E42CB0
		public static extern bool FriendRescueTicket_IsValidRescuedNo(ulong nativePointerId); // 0x00E42CB0-0x00E42CD0
		public static extern uint FriendRescueTicket_GetTimeOriginal(ulong nativePointerId); // 0x00E42CD0-0x00E42CE0
		public static extern bool FriendRescueTicket_CheckInternetTime(); // 0x00E42CE0-0x00E42D00
		public static extern void FriendRescueTicket_SetTime(ulong nativePointerId, uint time); // 0x00E42D00-0x00E42D10
		public static extern void FriendRescueTicket_SetSOSMailSendPlayerName(ulong nativePointerId, string pText); // 0x00E42D10-0x00E42D20
		public static extern void FriendRescueTicket_NGWordCheck(string pText, ushort[] pDst, int length); // 0x00E38B30-0x00E38B50
		public static extern bool NGWord_IsNGWord(string pText); // 0x00E38B00-0x00E38B30
		public static extern int FriendRescueTicket_GetNGWordVersion(); // 0x00E42D20-0x00E42D30
		public static extern void FriendRescueTicket_SetSOSMailSendTeamName(ulong nativePointerId, string pText); // 0x00E42D30-0x00E42D40
		public static extern int FriendRescueTicket_GetSOSMailSendPlayerName(ulong nativePointerId, ushort[] pDst, int length); // 0x00E42D40-0x00E42D50
		public static extern int FriendRescueTicket_GetSOSMailSendTeamName(ulong nativePointerId, ushort[] pDst, int length); // 0x00E42D50-0x00E42D60
		public static extern void FriendRescueTicket_SetReviveMailSendPlayerName(ulong nativePointerId, string pText); // 0x00E42D60-0x00E42D70
		public static extern void FriendRescueTicket_SetReviveMailSendTeamName(ulong nativePointerId, string pText); // 0x00E42D70-0x00E42D80
		public static extern int FriendRescueTicket_GetReviveMailSendPlayerName(ulong nativePointerId, ushort[] pDst, int length); // 0x00E42D80-0x00E42D90
		public static extern int FriendRescueTicket_GetReviveMailSendTeamName(ulong nativePointerId, ushort[] pDst, int length); // 0x00E42D90-0x00E42DA0
		public static extern void FriendRescueTicket_SetPresentType(ulong nativePointerId, int type); // 0x00E42DA0-0x00E42DB0
		public static extern int FriendRescueTicket_GetPresentType(ulong nativePointerId); // 0x00E42DB0-0x00E42DC0
		public static extern void FriendRescueTicket_SetRemainCount(ulong nativePointerId, int count); // 0x00E42DC0-0x00E42DD0
		public static extern int FriendRescueTicket_GetSOSDungeon(ulong nativePointerId); // 0x00E42DD0-0x00E42DE0
		public static extern int FriendRescueTicket_GetSOSFloor(ulong nativePointerId); // 0x00E42DE0-0x00E42DF0
		public static extern int FriendRescueTicket_GetSOSCreature(ulong nativePointerId); // 0x00E42DF0-0x00E42E00
		public static extern int FriendRescueTicket_GetSOSGenderType(ulong nativePointerId); // 0x00E42E00-0x00E42E10
		public static extern void FriendRescueTicket_SetPasswordSOSSended(ulong nativePointerId, bool bEnable); // 0x00E42E10-0x00E42E20
		public static extern void FriendRescueTicket_SetInternetSOSSended(ulong nativePointerId, bool bEnable); // 0x00E42E20-0x00E42E30
		public static extern bool FriendRescueTicket_IsPasswordSOSSended(ulong nativePointerId); // 0x00E42E30-0x00E42E50
		public static extern bool FriendRescueTicket_IsInternetSOSSended(ulong nativePointerId); // 0x00E42E50-0x00E42E70
		public static extern void FriendRescueTicket_SetInternetUniqueId(ulong nativePointerId, uint uniqueId); // 0x00E42E70-0x00E42E80
		public static extern uint FriendRescueTicket_GetInternetUniqueId(ulong nativePointerId); // 0x00E42E80-0x00E42E90
		public static extern int FriendRescueTicket_GetDifficulty(ulong nativePointerId); // 0x00E42E90-0x00E42EA0
		public static extern bool FriendRescueTicket_EncodePassword(ulong nativePointerId, ushort[] pDst, int length, bool bUpdateSOSUniqueId); // 0x00E42EA0-0x00E42ED0
		public static extern bool FriendRescueTicket_DecodePassword(ulong nativePointerId, string password); // 0x00E42ED0-0x00E42F00
		public static extern uint FriendRescueTicket_CalcUniqueKey(string password); // 0x00E42F00-0x00E42F10
		public static extern bool FriendRescueTicket_IsMissionImpossible(ulong nativePointerId); // 0x00E42F10-0x00E42F30
		public static extern bool FriendRescueTicket_CheckDataValue(ulong nativePointerId); // 0x00E42F30-0x00E42F50
		public static extern void FriendRescueTicket_SetDepopulationDummy(ulong nativePointerId, bool bEnable); // 0x00E42F50-0x00E42F60
		public static extern bool FriendRescueTicket_IsDepopulationDummy(ulong nativePointerId); // 0x00E42F60-0x00E42F80
		public static extern void RewardDatabase_GetDataInfo(byte[] buffer, int length, int rewardIndex); // 0x00E42F80-0x00E42F90
		public static extern void RewardDatabase_GetCommonDataInfo(byte[] buffer, int length, int rewardIndex); // 0x00E42F90-0x00E42FA0
		public static extern int RewardDatabase_GetRandomItem(int type, int tableNo, int rate); // 0x00E42FA0-0x00E42FB0
		public static extern int RewardDatabase_GetRandomMoney(int type, int difficulty); // 0x00E42FB0-0x00E42FC0
		public static extern int ShopManager_GetMerchantList(byte[] buffer, int length, int kind); // 0x00E42FC0-0x00E42FD0
		public static extern void ShopManager_NextDay(); // 0x00E42FD0-0x00E42FE0
		public static extern bool ShopMerchantList_RemoveItem(int shopId, uint nativeUniqueId); // 0x00E42FE0-0x00E43000
		public static extern bool DungeonLog_GetText(ushort[] pDst_, int dstMaxCoun); // 0x00E43000-0x00E43030
		public static extern bool DungeonLog_IsDraw(); // 0x00E43030-0x00E43050
		public static extern void DungeonLog_Close(); // 0x00E311B0-0x00E311C0
		public static extern bool DungeonLog_IsNeedFastScroll(); // 0x00E43050-0x00E43070
		public static extern void Dungeon_StressTest(); // 0x00E43070-0x00E43080
		public static extern int Dungeon_GetCurrentFloor(); // 0x00E43080-0x00E43090
		public static extern int Dungeon_GetLastFloor(); // 0x00E43090-0x00E430A0
		public static extern int Dungeon_GetIndex(); // 0x00E430A0-0x00E430B0
		public static extern bool Dungeon_HasStatus(int statusIndex); // 0x00E430B0-0x00E430D0
		public static extern int Dungeon_GetWeather(); // 0x00E430D0-0x00E430E0
		public static extern bool Dungeon_IsFriendRescueRequest(); // 0x00E430E0-0x00E43100
		public static extern bool Dungeon_IsDungeonGiveup(); // 0x00E43100-0x00E43120
		public static extern void Dungeon_Giveup(); // 0x00E43120-0x00E43130
		public static extern bool Dungeon_IsEnteringShop(); // 0x00E43130-0x00E43150
		public static extern void DungeonParameter_Clear(); // 0x00E43150-0x00E43160
		public static extern void DungeonParameter_DataExchangeImport(byte[] buffer, int length, bool bFromBackup); // 0x00E43160-0x00E43180
		public static extern void DungeonParameter_DataExchangeExport(byte[] buffer, int length); // 0x00E43180-0x00E43190
		public static extern bool DungeonParameter_IsIgnoreQuest(int dungeonIndex); // 0x00E43190-0x00E431B0
		public static extern void Dungeon_SetOptionGrid(bool bEnable); // 0x00E431B0-0x00E431C0
		public static extern void Dungeon_UpdateOptionGrid(); // 0x00E431C0-0x00E431D0
		public static extern int MenuFuncItem_GroundActions(uint nativeUniqueId, bool bMultiSelected, byte[] buffer, int length); // 0x00E431D0-0x00E431F0
		public static extern int MenuFuncItem_DungeonActions(uint nativeUniqueId, byte[] buffer, int length); // 0x00E431F0-0x00E43200
		public static extern int MenuFuncItem_WazaDetail(uint wazaIndex, bool bOriginal, byte[] buffer, int length); // 0x00E43200-0x00E43220
		public static extern int MenuFuncItem_WazaDetailByStatus(ulong statusId, uint nativeUniqueId, int wazaSlot, uint wazaIndex, bool bOriginal, byte[] buffer, int length); // 0x00E43220-0x00E43240
		public static extern bool MenuFuncItem_IsLearnWazamachine(ulong statusId, uint nativeUniqueId, int itemIndex); // 0x00E43240-0x00E43260
		public static extern int MenuFuncPokemonStatus_GetParameter(ulong statusId, uint nativeUniqueId, byte[] buffer, int length); // 0x00E43260-0x00E43270
		public static extern int Organization_GetCurrentPresetIndex(); // 0x00E43270-0x00E43280
		public static extern void Organization_SetCurrentPresetIndex(int presetIndex); // 0x00E43280-0x00E43290
		public static extern bool Organization_GetPresetMember(int presetIndex, byte[] buffer, int length); // 0x00E43290-0x00E432C0
		public static extern void Organization_SetPresetMember(int presetIndex, int memberId, int warehouseId, int formIndex); // 0x00E432C0-0x00E432D0
		public static extern int Organization_GetPresetMemberWarehouseId(int presetIndex, int memberId); // 0x00E432D0-0x00E432E0
		public static extern int Organization_GetPresetMemberFormChangeIndex(int presetIndex, int memberId); // 0x00E432E0-0x00E432F0
		public static extern void Organization_UpdateEquippedItem(); // 0x00E432F0-0x00E43300
		public static extern uint Organization_GetEquippedItem(int equipId); // 0x00E43300-0x00E43310
		public static extern void Organization_SetEquippedItem(int equipId, uint nativeUniqueId); // 0x00E43310-0x00E43320
		public static extern void Organization_RemoveEquippedItem(int equipId); // 0x00E43320-0x00E43330
		public static extern int Organization_GetEquippedItemIndex(int equipId); // 0x00E43330-0x00E43340
		public static extern int Organization_GetEquippedBagIndex(int equipId); // 0x00E43340-0x00E43350
		public static extern void Organization_GetEquippedParameterForBackup(int equipId, int bagInIndex, int itemIndex); // 0x00E43350-0x00E43360
		public static extern void Organization_SetParty(int presetIndex, int dgIndex); // 0x00E43360-0x00E43370
		public static extern void Organization_SetOrganizationMemberLocked(int memberId, bool bLock); // 0x00E43370-0x00E43380
		public static extern bool Organization_IsOrganizationMemberLocked(int memberId); // 0x00E43380-0x00E433A0
		public static extern bool Organization_IsPartyMemberLocked(int partyIndex); // 0x00E433A0-0x00E433C0
		public static extern int DungeonDatabase_GetDungeonName(int dungeonIndex, int nameType, ushort[] pDst, int length); // 0x00E433C0-0x00E433D0
		public static extern bool DungeonDatabase_IsAscend(int dungeonIndex); // 0x00E433D0-0x00E433F0
		public static extern bool DungeonDatabase_IsJoining(int dungeonIndex); // 0x00E433F0-0x00E43410
		public static extern bool DungeonDatabase_IsOpenNotice(int dungeonIndex); // 0x00E43410-0x00E43430
		public static extern bool DungeonDatabase_IsBossFloor(int dungeonIndex, int floor); // 0x00E43430-0x00E43450
		public static extern bool DungeonDatabase_IsSenrigan(int dungeonIndex); // 0x00E43450-0x00E43470
		public static extern int DungeonDatabase_GetItemCount(int dungeonIndex); // 0x00E43470-0x00E43480
		public static extern void DungeonDatabase_DestroyPokemonAppearList(); // 0x00E43480-0x00E43490
		public static extern void DungeonDatabase_LoadPokemonAppearList(); // 0x00E43490-0x00E434A0
		public static extern void DungeonDatabase_GetAppearPokemonListFromDungeon(byte[] aBuffer, int count, int dungeon); // 0x00E434A0-0x00E434B0
		public static extern void DungeonDatabase_GetAppearPokemonDungeonListFromPokemon(byte[] aBuffer, int count, int pokemon); // 0x00E434B0-0x00E434C0
		public static extern void DungeonDatabase_GetAppearPokemonListFromInvitation(byte[] aBuffer, int count); // 0x00E434C0-0x00E434D0
		public static extern void DungeonDatabase_GetAppearPokemonListFromOutbreak(byte[] aBuffer, int count); // 0x00E434D0-0x00E434E0
		public static extern void DungeonDatabase_GetAreaInfo(int dungeonIndex, byte[] buffer, int length); // 0x00E434E0-0x00E434F0
		public static extern int DungeonDatabase_GetObstacleDataSymbolList(byte[] buffer, int length); // 0x00E434F0-0x00E43500
		public static extern uint NGWord_Load(byte[] buffer, int length); // 0x00E43500-0x00E43510
		public static extern bool NGWord_SearchWhiteList(string pName); // 0x00E38970-0x00E389A0
		public static extern int NameSort_Compare(string pNameA, string pNameB); // 0x00E43510-0x00E43530
		public static extern bool NameSort_ExistCode(ushort code); // 0x00E43530-0x00E43550
		public static extern ushort NameSort_CodeToRefineCode(ushort code); // 0x00E43550-0x00E43560
		public static extern int GuestMember_GetCount(); // 0x00E43560-0x00E43570
		public static extern int GuestMember_GetList(byte[] buffer, int length); // 0x00E43570-0x00E43580
		public static extern int GuestMember_GetBonusCash(int memberId); // 0x00E43580-0x00E43590
		public static extern void GuestMember_AllRemove(); // 0x00E43590-0x00E435A0
		public static extern void AdventureLog_SetAttackedPokemon(int pokemon); // 0x00E435A0-0x00E435B0
		public static extern bool AdventureLog_GetAttackedPokemon(int pokemon); // 0x00E435B0-0x00E435D0
		public static extern void AdventureLog_AllSetAttackedPokemon(); // 0x00E435D0-0x00E435E0
		public static extern void AdventureLog_HalfSetAttackedPokemon(); // 0x00E435E0-0x00E435F0
		public static extern void AdventureLog_ClearAttackedPokemon(); // 0x00E435F0-0x00E43600
		public static extern void AdventureLog_SetMetPokemon(int pokemon); // 0x00E43600-0x00E43610
		public static extern bool AdventureLog_GetMetPokemon(int pokemon); // 0x00E43610-0x00E43630
		public static extern void AdventureLog_AllSetMetPokemon(); // 0x00E43630-0x00E43640
		public static extern void AdventureLog_ClearMetPokemon(); // 0x00E43640-0x00E43650
		public static extern void DungeonDatabase_GetName(int dungeonIndex, int nameType, ushort[] pDst, int length); // 0x00E43650-0x00E43660
		public static extern void DungeonDatabase_GetStatusName(int dungeonStatusIndex, ushort[] pDst, int length); // 0x00E43660-0x00E43670
		public static extern void DungeonDatabase_GetStatusExplanation(int dungeonStatusIndex, ushort[] pDst, int length); // 0x00E43670-0x00E43680
		public static extern int DungeonDatabase_GetMaxFloor(int dungeonIndex); // 0x00E43680-0x00E43690
		public static extern int DungeonDatabase_GetSortKey(int dungeonIndex); // 0x00E43690-0x00E436A0
		public static extern int DungeonDatabase_GetRescueCount(int dungeonIndex); // 0x00E436A0-0x00E436B0
		public static extern bool Camp_GetCampShopDisplayFlag(int index); // 0x00E436B0-0x00E436D0
		public static extern bool Camp_GetCampShopSellFlag(int index); // 0x00E436D0-0x00E436F0
		public static extern bool Camp_GetCampShopGetWithPokemonFlag(int index); // 0x00E436F0-0x00E43710
		public static extern int Camp_GetCampPrice(int index); // 0x00E43710-0x00E43720
		public static extern int Camp_GetCampWarehouseIncreaseNum(int index); // 0x00E43720-0x00E43730
		public static extern int Camp_GetCampSortNum(int index); // 0x00E43730-0x00E43740
		public static extern int Camp_GetCampIndex(int index); // 0x00E43740-0x00E43750
		public static extern IntPtr Camp_GetCampPokemonList(int index); // 0x00E43750-0x00E43760
		public static extern int Camp_GetCampPokemonListCount(int index); // 0x00E43760-0x00E43770
		public static extern bool Camp_GetCampBuyFlag(int index); // 0x00E43770-0x00E43790
		public static extern void Camp_SetCampBuyFlag(int index, bool b); // 0x00E43790-0x00E437A0
		public static extern bool Camp_GetCampNewFlag(int index); // 0x00E437A0-0x00E437C0
		public static extern void Camp_SetCampNewFlag(int index, bool b); // 0x00E437C0-0x00E437D0
		public static extern IntPtr Camp_GetShopProgress(int index); // 0x00E437D0-0x00E437E0
		public static extern IntPtr Camp_GetEventProgress(int index); // 0x00E437E0-0x00E437F0
		public static extern IntPtr Camp_GetFileName(int index); // 0x00E437F0-0x00E43800
		public static extern IntPtr Camp_GetBgmName(int index); // 0x00E43800-0x00E43810
		public static extern int Camp_GetOpenDungeonIndex(int index); // 0x00E43810-0x00E43820
		public static extern bool Camp_IsCampEntryNumFromKyuujotaiRank(int index); // 0x00E43820-0x00E43840
		public static extern int Training_GetSuccessCount(int index); // 0x00E43840-0x00E43850
		public static extern int Training_GetFirstCompensation(int index); // 0x00E43850-0x00E43860
		public static extern int Training_GetFirstItemCount(int index); // 0x00E43860-0x00E43870
		public static extern int Training_GetSecondCompensationTable(int index); // 0x00E43870-0x00E43880
		public static extern int Training_GetSecondItemCountLottery(int index); // 0x00E43880-0x00E43890
		public static extern int Training_GetSortKey(int index); // 0x00E43890-0x00E438A0
		public static extern bool Training_GetClearFlag(int index); // 0x00E438A0-0x00E438C0
		public static extern void Training_SetClearFlag(int index, bool b); // 0x00E438C0-0x00E438D0
		public static extern int Training_GetDungeonIndex(int index); // 0x00E438D0-0x00E438E0
		public static extern int Training_GetFloorNum(int index); // 0x00E438E0-0x00E438F0
		public static extern int Training_GetTrainingDungeonIndex(int typeIndex); // 0x00E438F0-0x00E43900
		public static extern int Training_SetTrainingDungeonTimeup(); // 0x00E43900-0x00E43910
		public static extern bool DungeonTutorialSequence_Event(int ev); // 0x00E43910-0x00E43930
		public static extern bool DungeonTutorialSequence_IsDisableTutorialAutoWalk(); // 0x00E43930-0x00E43950
		public static extern ushort Evolution_GetEvolutionPokemonIndex(int index, int infoNum); // 0x00E43950-0x00E43960
		public static extern ushort Evolution_GetEvolutionLevel(int index, int infoNum); // 0x00E43960-0x00E43970
		public static extern bool Evolution_IsUsedEvolutionItem(int index, int infoNum); // 0x00E43970-0x00E43990
		public static extern int Evolution_GetEvolutionInfoNum(int index); // 0x00E43990-0x00E439A0
		public static extern bool Evolution_CanEvolution(ulong statusId, uint nativeUniqueId); // 0x00E439A0-0x00E439C0
		public static extern bool Evolution_CanEvolution_infoNum(ulong statusId, uint nativeUniqueId, int infoNum); // 0x00E439C0-0x00E439E0
		public static extern int Evolution_EvolutionDecision(ulong statusId, uint nativeUniqueId, ushort wId, int evoIndex); // 0x00E439E0-0x00E439F0
		public static extern bool Evolution_SetLevel(ulong statusId, uint nativeUniqueId, int level); // 0x00E439F0-0x00E43A10
		public static extern int Evolution_GetEvolutionItem(int index, int infoNum); // 0x00E43A10-0x00E43A20
		public static extern int Evolution_GetEvolutionItemNum(int index, int infoNum); // 0x00E43A20-0x00E43A30
		public static extern uint Dictionary_GetLinkIndex(int index); // 0x00E43A30-0x00E43A40
		public static extern uint Dictionary_GetCategoryIndex(int index); // 0x00E43A40-0x00E43A50
		public static extern uint Dictionary_GetItemIndex(int index); // 0x00E43A50-0x00E43A60
		public static extern uint Dictionary_GetSortKey(int index); // 0x00E43A60-0x00E43A70
		public static extern IntPtr Dictionary_GetDisplayProgress(int index); // 0x00E43A70-0x00E43A80
		public static extern uint Dictionary_GetCategoryIndex_Hash(uint hash); // 0x00E43A80-0x00E43A90
		public static extern uint Dictionary_GetItemIndex_Hash(uint hash); // 0x00E43A90-0x00E43AA0
		public static extern uint Dictionary_GetSortKey_Hash(uint hash); // 0x00E43AA0-0x00E43AB0
		public static extern IntPtr Dictionary_GetDisplayProgress_Hash(uint hash); // 0x00E43AB0-0x00E43AC0
		public static extern uint GetLinkHash_ForExplainHash(uint hash); // 0x00E43AC0-0x00E43AD0
		public static extern void ScenarioManager_Init(); // 0x00E43AD0-0x00E43AE0
		public static extern void ScenarioManager_SetProgressNo(ScenarioProgressType type, int no); // 0x00E43AE0-0x00E43AF0
		public static extern int ScenarioManager_GetProgressNo(ScenarioProgressType type); // 0x00E43AF0-0x00E43B00
		public static extern bool ScenarioManager_CheckProgressCondition(char[] pLabel); // 0x00E43B00-0x00E43BE0
		public static extern bool ScenarioManager_CheckProgressCondition(string pLabel); // 0x00E43BE0-0x00E43C10
		public static extern bool FriendRescueTicket_ShowUserDetailInfo(ulong Uid_data0, ulong Uid_data1, ulong networkServiceAccountId, string myName, string targetName); // 0x00E43C10-0x00E43C50
		public static extern void FriendRescueTicket_ShowFriendList(ulong Uid_data0, ulong Uid_data1); // 0x00E43C50-0x00E43C60
		public static extern void ScenarioManager_EnumProgressConditionLabel(byte[] outputBuffer, int outputBufferLength); // 0x00E43C60-0x00E43C70
		public static extern void ScenarioManager_EnumCurrentOpenDungeonCondition(byte[] outputBuffer, int outputBufferLength); // 0x00E43C70-0x00E43C80
		public static extern uint System_GetFreeMemorySize(); // 0x00E43C80-0x00E43C90
		public static extern void SwitchUtility_GetFriendList(byte[] buffer, int length, ulong data0, ulong data1, ulong _context, uint filterFlag); // 0x00E43C90-0x00E43CA0
		public static extern void SwitchUtility_SetCpuBoostMode(bool is_boost); // 0x00E43CA0-0x00E43CB0
		public static extern void SwitchUtility_SetUserInactivityDetectionTimeExtended(bool bEnable); // 0x00E43CB0-0x00E43CC0
		public static extern int SwitchUtility_GetFriendCount(); // 0x00E43CC0-0x00E43CD0
		public static extern int SwitchUtility_GetLanguageType(); // 0x00E43CD0-0x00E43CE0
		public static extern void SwitchUtility_FinishStartupLogo(); // 0x00E43CE0-0x00E43CF0
		public static extern bool SwitchUtility_IsConsoleOperationMode(); // 0x00E43CF0-0x00E43D10
		public static extern bool SwitchUtility_IsBlockListUser(ulong data0, ulong data1, ulong _context, ulong id); // 0x00E43D10-0x00E43D30
		public static extern int BankDatabase_GetRewardIndex(int index); // 0x00E43D30-0x00E43D40
		public static extern int WonderMail_GetWonderMailRewardItem(int index, ushort[] pDst_, int dstMaxCount); // 0x00E43D40-0x00E43D50
		public static extern int WonderMail_GetWonderMailCaptionHash(int index); // 0x00E43D50-0x00E43D60
		public static extern uint WonderMail_GetWonderMailQuestHash(int index); // 0x00E43D60-0x00E43D70
		public static extern int WonderMail_GetWonderMailPassword(int index, ushort[] pDst_, int dstMaxCount); // 0x00E43D70-0x00E43D80
		public static extern int WonderMail_GetWonderMailIndexFromPasswordString(char[] pSrc); // 0x00E43D80-0x00E43E50
		public static extern int WonderMail_GetWonderMailIndexFromPasswordString(string pSrc); // 0x00E43E50-0x00E43E60
		public static extern bool WonderMail_IsReceivedWonderMail(int mailNo); // 0x00E43E60-0x00E43E80
		public static extern void WonderMail_SetWonderMailReceivedFlag(int mailNo); // 0x00E43E80-0x00E43E90
		public static extern void WonderMail_SetWonderMailReceivedFlagByQuestHash(uint questHash); // 0x00E43E90-0x00E43EA0
	}
}
