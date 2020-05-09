/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ToNativeController : Singleton<ToNativeController> // TypeDefIndex: 6028
{
	// Fields
	private byte[] aCommandTempBuffer_; // 0x10
	private byte[] aCommandBuffer_; // 0x18
	private int commandTransSize; // 0x20
	private DataExchangeByteMemoryStream stream; // 0x28

	// Properties
	public bool IsOpen { get => default; } // 0x007DDE70-0x007DDE80 

	// Nested types
	public enum Command : uint // TypeDefIndex: 6029
	{
		OPTION__SET_DATA = 16777216,
		CUTSCENE__LOAD_FINISHED = 16781312,
		CUTSCENE__PLAY_FINISHED = 16781313,
		CUTIN__FINISHED = 16781568,
		DRAMA__FINISHED = 16785408,
		MENU__DUNGEON_SYSTEM_MESSAGE_FINISHED = 16789504,
		SYSTEM__PAUSE_FINISHED = 16793600,
		SOUND__LOAD_FINISHED = 16797696,
		MODEL__LOAD_RESOURCE_CACHE_FINISHED = 16842752,
		TOUCH__RESULT_SCREEN_POSITION_TO_PLANE_WORLD_POSITION = 33619968,
		CHARACTER__CALC_BONE_POINT = 50331648,
		CAMERA__FINISHED_ANIMATION = 50331649,
		HINT__FINISHED_DIALOG = 50331650,
		GUIDE__FINISHED = 50331651,
		WINDOW__FINISHED_MSG = 50331652,
		ANIM__ACCIDENT_FINISHED = 50331653,
		ANIM__MESSED_UP_FINISHED = 50331654,
		ANIM__BOSS_BATTLE_FINISHED = 50331655,
		ANIM__BANNER_FINISHED = 50331656,
		GUIDE_WINDOW__FINISHED = 50331657,
		BEGIN = 4079096064,
		END = 4293844428
	}

	// Constructors
	public ToNativeController() {} // 0x007DDE80-0x007DDF50

	// Methods
	public void Execute() {} // 0x007DDF50-0x007DDFE0
	public void Begin() {} // 0x007DDFE0-0x007DE020
	public void End() {} // 0x007DE030-0x007DE0A0
	private void MakeCommand_Command(Command command) {} // 0x007DE020-0x007DE030
	public void MakeCommand_OptionData(int walkSpeed) {} // 0x007DE0A0-0x007DE0E0
	public void MakeCommand_DramaFinished(int result) {} // 0x007DE0E0-0x007DE120
	public void MakeCommand_DungeonSystemMessageFinished() {} // 0x007DE120-0x007DE140
	public void MakeCommand_CutsceneLoadFinished() {} // 0x007DE140-0x007DE160
	public void MakeCommand_CutscenePlayFinished() {} // 0x007DE160-0x007DE180
	public void MakeCommand_CutInPlayFinished(int nativeControlId) {} // 0x007DE180-0x007DE1C0
	public void MakeCommand_SoundLoadFinished(string bankName) {} // 0x007DE1C0-0x007DE260
	public void MakeCommand_ModelLoadResourceCacheFinished(uint nativeHandleId) {} // 0x007DE260-0x007DE2A0
	public void MakeCommand_SystemPauseFinished() {} // 0x007DE2A0-0x007DE2C0
	public void MakeCommand_ScreenPositionToPlaneWorldPosition(bool bHit, float x, float y, float z) {} // 0x007DE2C0-0x007DE350
	public void MakeCommand_CharacterCalcBodyPoint(CharacterModel character) {} // 0x007DE350-0x007DE390
	public void MakeCommand_FinishedCameraAnimation(int nativeControlId) {} // 0x007DE390-0x007DE3D0
	public void MakeCommand_FinishedHintDialog(int nativeControlId) {} // 0x007DE3D0-0x007DE410
	public void MakeCommand_FinishedGuide(int nativeControlId) {} // 0x007DE410-0x007DE450
	public void MakeCommand_FinishedWindowMsg(int nativeControlId) {} // 0x007DE450-0x007DE4A0
	public void MakeCommand_FinishedWindowMsg(int nativeControlId, int result) {} // 0x007DE4A0-0x007DE500
	public void MakeCommand_FinishedAnimAccident() {} // 0x007DE500-0x007DE520
	public void MakeCommand_FinishedAnimMessedUp() {} // 0x007DE520-0x007DE540
	public void MakeCommand_FinishedBossBattle() {} // 0x007DE540-0x007DE560
	public void MakeCommand_FinishedBanner() {} // 0x007DE560-0x007DE580
	public void MakeCommand_FinishedGuideWindow() {} // 0x007DE580-0x007DE5A0
}

