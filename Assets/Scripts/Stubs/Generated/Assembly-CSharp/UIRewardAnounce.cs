/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class UIRewardAnounce : UIManagerBase // TypeDefIndex: 7493
{
	// Fields
	private UIPokemonRewardWindow pokemon_; // 0x20
	private UIPokemonConfirmWindow pokemonConfirm_; // 0x28
	private UIRewardListWindow rewardList_; // 0x30

	// Nested types
	private class UIPokemonRewardWindow : UIWindowBase // TypeDefIndex: 7494
	{
		// Fields
		private UIFaceWindow pokemonFace_; // 0x30
		private IPokemonStatus status_; // 0x38
		private bool bHaveSugowaza_; // 0x40
		private bool bRareColor_; // 0x41

		// Constructors
		public UIPokemonRewardWindow() {} // 0x00B54FC0-0x00B54FD0

		// Methods
		public virtual void Init(GameObject root, IPokemonStatus status) {} // 0x00B55DF0-0x00B56460
		public void PlayOpenSe() {} // 0x00B54FD0-0x00B55070
		// [IteratorStateMachine] // 0x0064FCB0-0x0064FD20
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00B56460-0x00B564E0
	}

	public enum WindowType // TypeDefIndex: 7496
	{
		Request = 0,
		Regular = 1,
		Specal = 2,
		Deluxe = 3,
		Jiraachi = 4
	}

	public enum TitleType // TypeDefIndex: 7497
	{
		Request = 0,
		Rescue = 1,
		Rankup = 2,
		Rankup_Item = 3,
		JiraachiEvent = 4,
		WonderMail = 5,
		Rankmax = 6,
		Rankmax2 = 7
	}

	private class UIRewardListWindow : UIWindowBase // TypeDefIndex: 7498
	{
		// Fields
		private GameObject objRequest_; // 0x30
		private GameObject objRankup_; // 0x38
		private GameObject objMail_; // 0x40
		private GameObject objGuide_; // 0x48
		private bool bHide0MoneyPoint_; // 0x50
		private string[] sWindowToken; // 0x58
		private string[] tokenItemList; // 0x60
		private string[] tokenItemListMail; // 0x68

		// Constructors
		public UIRewardListWindow() {} // 0x00B53700-0x00B54140

		// Methods
		public virtual void Init(GameObject root, WindowType windowType, TitleType titleType, string clientName, string password = null) {} // 0x00B56670-0x00B57550
		// [IteratorStateMachine] // 0x0064FD20-0x0064FD90
		public virtual IEnumerator OpenReward(List<IItem> itemList, int money, int point, GameObject objCracker, Action cb = null) => default; // 0x00B57550-0x00B575F0
		// [IteratorStateMachine] // 0x0064FD90-0x0064FE00
		public virtual IEnumerator OpenRankup(int beforePrisetNum, int beforeBagNum, int beforeCampNum, int beforeQuestNum, int afterPrisetNum, int afterBagNum, int afterCampNum, int afterQuestNum, Action cb = null) => default; // 0x00B57620-0x00B576F0
		// [IteratorStateMachine] // 0x0064FE00-0x0064FE70
		public virtual IEnumerator OpenMail(List<IItem> itemList, Action cb = null) => default; // 0x00B57720-0x00B577A0
	}

	// Constructors
	public UIRewardAnounce() {} // 0x00B54770-0x00B54780

	// Methods
	public static UIRewardAnounce Create() => default; // 0x00B534C0-0x00B53610
	public void Construct() {} // 0x00B53610-0x00B53620
	public void Destruct() {} // 0x00B53620-0x00B536A0
	public void Init() {} // 0x00B536A0-0x00B53700
	// [IteratorStateMachine] // 0x0062C9A0-0x0062CA10
	public IEnumerator PokemonRewardOpenFlow(IPokemonStatus status, bool bPlayOpenSe, Action cb = null) => default; // 0x00B54140-0x00B541D0
	// [IteratorStateMachine] // 0x0062CA10-0x0062CA80
	public IEnumerator PokemonRewardCloseFlow(Action cb = null) => default; // 0x00B54200-0x00B54280
	// [IteratorStateMachine] // 0x0062CA80-0x0062CAF0
	public IEnumerator PokemonConfirmOpenFlow(IPokemonStatus status, Action cb = null) => default; // 0x00B542B0-0x00B54330
	// [IteratorStateMachine] // 0x0062CAF0-0x0062CB60
	public IEnumerator PokemonConfirmCloseFlow(bool bBreakUp, Action cb = null) => default; // 0x00B54360-0x00B543F0
	// [IteratorStateMachine] // 0x0062CB60-0x0062CBD0
	public IEnumerator RewardListMainFlow(List<IItem> itemLists, int money, int point, WindowType windowType, TitleType titleType, string clientName, Action cb = null) => default; // 0x00B54420-0x00B544E0
	// [IteratorStateMachine] // 0x0062CBD0-0x0062CC40
	public IEnumerator RankupBasicRewardMainFlow(int beforePrisetNum, int beforeBagNum, int beforeCampNum, int beforeQuestNum, int afterPrisetNum, int afterBagNum, int afterCampNum, int afterQuestNum, string captionName, Action cb = null) => default; // 0x00B54510-0x00B545E0
	// [IteratorStateMachine] // 0x0062CC40-0x0062CCB0
	public IEnumerator WonderMailRewardMainFlow(List<IItem> itemLists, string clientName, string password, Action cb = null) => default; // 0x00B54610-0x00B546A0
	// [IteratorStateMachine] // 0x0062CCB0-0x0062CD20
	public IEnumerator rewardListClose() => default; // 0x00B546D0-0x00B54740
}

