/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TitleFlowToolBox // TypeDefIndex: 5729
{
	// Fields
	public Index[] RelayDungeons; // 0x10
	public CommonScreen.WallPapr[] wallPaperList; // 0x18
	private IPokemonWarehouse m_pokemonWarehouse; // 0x20

	// Properties
	public IPokemonWarehouse pokemonWarehouse { get => default; } // 0x007D4260-0x007D42F0 

	// Nested types
	public enum ClearIcons // TypeDefIndex: 5730
	{
		SANDAA = 0,
		FAIYAA = 1,
		FURIIZAA = 2,
		GURAADON = 3,
		REKKUUZA = 4,
		DOOBURU = 5,
		KAIOOGA = 6,
		MYUU = 7,
		HOUOU = 8,
		MYUUTUU = 9,
		RATHIOSU_RATHIASU = 10,
		JIRAACHI = 11,
		GENGAA = 12,
		RUGIA = 13,
		DEOKISHISU = 14,
		SEREBII = 15,
		GONBE = 16,
		RUKARIO = 17,
		MusicBox = 18,
		MAX = 19
	}

	// Constructors
	public TitleFlowToolBox() {} // 0x007D5160-0x007D5210

	// Methods
	public CommonScreen.WallPapr GetRandomWallPepaer() => default; // 0x007D3F90-0x007D4020
	public IPokemonStatus GetSaveInfoHeroStatus() => default; // 0x007D1910-0x007D1B10
	public void ChangeHeroName(string name) {} // 0x007D1B10-0x007D1D70
	public IPokemonStatus GetSaveInfoPartnerStatus() => default; // 0x007D1D70-0x007D1E00
	public void ChangePartnerName(string name) {} // 0x007D1E00-0x007D2060
	public string GetSaveInfoTeamName() => default; // 0x007D2060-0x007D20D0
	public void ChangeTeamName(string name) {} // 0x007D20D0-0x007D2150
	public bool GetSaveInfoClearIcon(ClearIcons clearIcon) => default; // 0x007D42F0-0x007D47E0
	public bool CheckGetMusicBox() => default; // 0x007D47E0-0x007D48D0
	public ulong GetSaveInfoPlayTime() => default; // 0x007D48D0-0x007D4940
	public Index GetSaveInfoDungeonIndex() => default; // 0x007D4940-0x007D4A00
	public int GetSaveInfoDungeonFloor() => default; // 0x007D4A00-0x007D4AC0
	// [IteratorStateMachine] // 0x00621650-0x006216C0
	public IEnumerator DeleteSaveData() => default; // 0x007D4020-0x007D41D0
	// [IteratorStateMachine] // 0x006216C0-0x00621730
	public IEnumerator OpeningAnimationPlay() => default; // 0x007D0C00-0x007D0C70
	// [IteratorStateMachine] // 0x00621730-0x006217A0
	private IEnumerator FadeOutBGM(float beforeVolume, float FadeOutSeconds = 0.5f /* Metadata: 0x00611DB0 */) => default; // 0x007D4B20-0x007D4BA0
	// [IteratorStateMachine] // 0x006217A0-0x00621810
	public IEnumerator InitialSaveExplain() => default; // 0x007D0BA0-0x007D0C00
	public int GetWonderMailIndex(string pass) => default; // 0x007D4C00-0x007D4CD0
	public bool GetWonderMailIsItem(int index) => default; // 0x007D4CD0-0x007D4D50
	public bool GetWonderMailUsed(int index) => default; // 0x007D4DC0-0x007D4E30
	public void SetWonderMailUsed(int index) {} // 0x007D4E30-0x007D4EA0
	public void SetWonderMailUsedFromQuest(uint questHash) {} // 0x007D4EA0-0x007D4F10
	public string GetWonderMailRewardItem(int index) => default; // 0x007D4F10-0x007D5020
	public int GetWonderMailCaptionHash(int index) => default; // 0x007D5020-0x007D5090
	public uint GetWonderMailQuestHash(int index) => default; // 0x007D4D50-0x007D4DC0
	public bool IsVisitedWonderMail() => default; // 0x007D5090-0x007D5160
}

