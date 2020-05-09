/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dungeon;
using pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IMainFiberUnityDungeonEngineInterrupt // TypeDefIndex: 5544
{
	// Methods
	IEnumerator OnPlayerTurnInput(NormalInputInParameter inParameter);
	IEnumerator OnPlayerTurnInput_WazaShortcutMenu();
	IEnumerator OnPlayerTurnInput_ACKCommand();
	IEnumerator OnPlayerTurnInput_DebugMenu();
	IEnumerator OnAutoSave();
	IEnumerator OnInterruptSaveWriteBuffer();
	IEnumerator OnInterruptSaveWriteBufferWait();
	void OnCheckInitFloorForScriptEvent();
	IEnumerator OnInitFloorForScriptEvent();
	IEnumerator OnInitFloorResourceCacheClear();
	IEnumerator OnInitializeFloor_CheckQuest();
	IEnumerator OnPokemonWazaLearn_OpenSelectMenu(WazaLearnSelectMenuOutParameter outParameter, WazaLearnSelectMenuInParameter inParameter);
	IEnumerator OnDungeonSuccessProduction(EventSuccessEventInParameter inParameter);
	IEnumerator OnStagingPostResultProcess();
	IEnumerator OnEndFloor_Dead();
	IEnumerator OnEndFloor_GiveUp();
	IEnumerator OnEndFloor_Wind();
	IEnumerator OnEndFloor_DungeonRescueRequest(RescueRequestOutParameter outParameter, RescueRequestInParameter inParameter);
	IEnumerator OnActBank_OpenSelectMenu(BankMenuOutParameter outParameter, BankMenuInParameter inParameter);
	IEnumerator OnActRescueSociety_OpenSelectMenu(RescueSocietyMenuOutParameter outParameter, RescueSocietyMenuInParameter inParameter);
	IEnumerator OnAutoFootMenu(AutoFootMenuOutParameter outParameter, AutoFootMenuInParameter inParameter);
	IEnumerator OnOpenTextInputWindow(WindowTextInputOutParameter outParameter, WindowTextInputInParameter inParameter);
	IEnumerator OnSelectSecessionMember(SelectSecessionMemberOutParameter outParameter, SelectSecessionMemberInParameter inParameter);
	IEnumerator OnStartTraining();
	IEnumerator OnEndTraining();
	IEnumerator OnEffectNice();
	IEnumerator OnEffectCongratulations();
	IEnumerator OnShowLevelUpDialog(LevelUpDialogInParameter inParameter);
	IEnumerator OnDirectionMove(DirectionMoveInputOutParameter outParameter, DirectionMoveInputInParameter inParameter);
	IEnumerator OnLookAround(LookAroundInputOutParameter outParameter, LookAroundInputInParameter inParameter);
	IEnumerator OnTutorialJyoban(TutorialJyobanInParameter inParameter);
	IEnumerator OnOpenTempFriendWindow(TempPokemonWindowInParameter inParameter);
	IEnumerator OnCloseTempFriendWindow();
}

