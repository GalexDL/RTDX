/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CommonScreen : UIWindowBase // TypeDefIndex: 6162
{
	// Fields
	public static TextIDHash[] IdGuideCaption; // 0x00
	public static TextIDHash[] IdGuideButton; // 0x08
	private string[] tokenWp_; // 0x30
	private WallPapr currentWp_; // 0x38
	private bool bVisibleFooter_; // 0x3C
	private bool bVisibleDgFooter_; // 0x3D
	private bool bVisibleFilter_; // 0x3E
	private bool bVisibleCaption_; // 0x3F
	private bool bDoingAnimationCaption_; // 0x40
	private string requestCaption_; // 0x48
	private const int HISOTRY_SIZE = 32; // Metadata: 0x00612678
	private TextIDHash[] aCaptionHistory_; // 0x50
	private int captionIndex_; // 0x58
	private bool bVisibleButtonGuide_; // 0x5C
	private bool bDoingAnimationButton_; // 0x5D
	private string requestButton_; // 0x60
	private TextIDHash[] aButtonHistory_; // 0x68
	private int buttonIndex_; // 0x70

	// Properties
	public bool bDoingAnimationButton { get => default; } // 0x009CAAE0-0x009CAAF0 

	// Nested types
	public enum GuideCaption // TypeDefIndex: 6163
	{
		HENSEI__TEAM_SELECT = 0,
		HENSEI__TEAM_SORTIE = 1,
		HENSEI__TEAM_EDIT = 2,
		HENSEI__CHANGE_REGULAR = 3,
		HENSEI__SELECT_MEMBER = 4,
		HENSEI__CHANGE_EQUIP = 5,
		HENSEI__SELECT_ITEM = 6,
		HENSEI__BAGGAGE = 7,
		COMMON_ITEM_NORMAL = 8,
		MERCHANT__BUY = 9,
		MERCHANT__SELL = 10,
		SP_MERCHANT__BUY = 11,
		SP_MERCHANT__SELL = 12,
		WAZA__OSHIE_POKEMON = 13,
		WAZA__OSHIE_WAZA = 14,
		WAZA__OMOIDASHI_POKEMON = 15,
		WAZA__OMOIDASHI_WAZA = 16,
		WAZA__WASURE_POKEMON = 17,
		WAZA__WASURE_WAZA = 18,
		WAZA__WAZA_CHANGE = 19,
		WAZA__RENKETSU_TOP = 20,
		WAZA__RENKETSU_MODE_SELECT = 21,
		WAZA__RENKETSU = 22,
		WAZA__BUNKAI = 23,
		WAZA__KEYBIND = 24,
		RESCUE_SOCIETY__CONSTRUCT = 25,
		RESCUE_SOCIETY__POKEMON_LIST = 26,
		RESCUE_SOCIETY__CALL_CONSTRUCT = 27,
		NAMING_DEFAULT = 28,
		NAMING_NICKNAME = 29,
		NAMING_TEAM = 30,
		NAMING_HERO = 31,
		NAMING_PASSWORD = 32,
		NAMING_WONDER_MAIL = 33,
		NAME_CHANGE_MENU = 34,
		MENU_TITLE__GROUND = 35,
		MENU_TITLE__DUNGEON = 36,
		MENU_TITLE__TOP = 37,
		BILLBOARD__QUEST_TOP = 38,
		BILLBOARD__QUEST_LIST = 39,
		QUEST__LIST = 40,
		POST__POST_LIST = 41,
		POST__NEWS = 42,
		CAMP__CAPTION_AREA_SELECT = 43,
		CAMP__CAPTION_CAMP_SELECT_POKEMON_MODE = 44,
		CAMP__CAPTION_CAMPSITE = 45,
		CAMP__CAPTION_CAMPSITE_POKEMON = 46,
		CAMP__CAPTION_GUMI = 47,
		CAMP__CAPTION_LEAVE = 48,
		BANK__CAPTION_DEPOSIT = 49,
		BANK__CAPTION_DRAW = 50,
		DUNGEON_ITEM_FOOT = 51,
		DUNGEON_ORDER = 52,
		DUNGEON_RESULT = 53,
		DUNGEON_RESULT__TREASURE = 54,
		DUNGEON_RESULT__TREASURE_LIST = 55,
		DUNGEON_RESULT__JOIN = 56,
		DUNGEON_RESULT__LEAVE_SELECT = 57,
		DUNGEON_RESULT__LEAVE = 58,
		EVOLUTION__CAPTION = 59,
		DUNGEON_PARTY__TITLE = 60,
		DUNGEON_PARTY__TSUYOSA_TITLE = 61,
		DUNGEON_PARTY__WAZA_TITLE = 62,
		DUNGEON_PARTY__TOKUTYO_TITLE = 63,
		DUNGEON_PARTY__JOTAI_TITLE = 64,
		SOUKO_SELECT_DRAW = 65,
		SOUKO_SELECT_DEPOSIT = 66,
		RESCUE_OFFICE_CAPTION_DEBUG = 67,
		RESCUE_OFFICE_CAPTION_TOP = 68,
		RESCUE_OFFICE_CAPTION_RESCUE = 69,
		RESCUE_OFFICE_CAPTION_RESCUE_ME = 70,
		RESCUE_OFFICE_CAPTION_FRIEND_RESCUE = 71,
		RESCUE_OFFICE_CAPTION_RECORD_LIST = 72,
		RESCUE_OFFICE_CAPTION_HELP = 73,
		RESCUE_OFFICE_CAPTION_CREATE_ORDER = 74,
		RESCUE_OFFICE_CAPTION_COMPLETE_PASSWORD_ORDER = 75,
		RESCUE_OFFICE_CAPTION_QUEST_BOARD = 76,
		RESUCE_CAPTION_REVIVE_PASSWORD = 77,
		RESUCE_CAPTION_REVIVE_INTERNET = 78,
		RESCUE_OFFICE_CAPTION_QUEST_LIST = 79,
		RESCUE_OFFICE_CAPTION_QUEST_DETAIL = 80,
		RESCUE_OFFICE_CAPTION_QUEST_DETAIL_OTHER = 81,
		RESCUE_GATE_CAPTION_TOP = 82,
		NAME_INPUT_CAPTION_REVIVE_PASSWORD = 83,
		NAME_INPUT_CAPTION_USER_ID = 84,
		TRAINING_CAPTION_TUTORIAL = 85,
		TRAINING_CAPTION_TICKET = 86,
		TRAINING_CAPTION_POKEMON = 87,
		TEAM_FLAG_CAPTION_LIST = 88,
		TOP_SAVE_DELETE = 89,
		TOP_GIVE_UP = 90,
		WONDER_MAIL_CAPTION_TOP = 91,
		WONDER_MAIL_REWARD_QUEST = 92,
		WONDER_MAIL_QUEST_CANCEL = 93,
		WONDER_MAIL_QUEST_TRASH_CONFLICT = 94,
		WONDER_MAIL_QUEST_TRASH = 95,
		END = 96
	}

	public enum GuideButton // TypeDefIndex: 6164
	{
		HENSEI__TEAM_SELECT = 0,
		HENSEI__TEAM_SORTIE = 1,
		HENSEI__TEAM_EDIT = 2,
		HENSEI__CHANGE_REGULAR = 3,
		HENSEI__SELECT_MEMBER = 4,
		HENSEI__CHANGE_EQUIP = 5,
		HENSEI__SELECT_ITEM = 6,
		HENSEI__BAGGAGE = 7,
		MERCHANT__TOP = 8,
		WAZA__OSHIE_POKEMON = 9,
		WAZA__OSHIE_WAZA = 10,
		WAZA__OSHIE_WAZA_CHANGE = 11,
		WAZA__OMOIDASHI_POKEMON = 12,
		WAZA__OMOIDASHI_WAZA = 13,
		WAZA__OMOIDASHI_WAZA_CHANGE = 14,
		WAZA__WASURE_POKEMON = 15,
		WAZA__WASURE_WAZA = 16,
		WAZA__RENKETSU_TOP = 17,
		WAZA__RENKETSU_MODE_SELECT = 18,
		WAZA__RENKETSU = 19,
		WAZA__BUNKAI = 20,
		WAZA__KEYBIND = 21,
		WAZA__KEYBIND_GO = 22,
		RESCUE_SOCIETY__CONSTRUCT = 23,
		RESCUE_SOCIETY__POKEMON_LIST = 24,
		RESCUE_SOCIETY__CALL_CONSTRUCT = 25,
		NAMING_DEFAULT = 26,
		NAMING_PASSWORD = 27,
		NAMING_CANT_RETURN = 28,
		NAMING_WONDERMAIL = 29,
		NAME_CHANGE_MENU = 30,
		MENU_TITLE__TOP = 31,
		MENU_TITLE__TOP_NEWGAME = 32,
		DUNGEON_MENU___HELP_OPERATION = 33,
		BILLBOARD__QUEST_TOP = 34,
		BILLBOARD__QUEST_LIST = 35,
		QUEST__LIST = 36,
		QUEST__ = 37,
		POST__TOP = 38,
		POST__POST_LIST = 39,
		POST__NEWS_LIST = 40,
		POST__VIEW_NEWS = 41,
		CAMP__BUTTON_CAMP_SELECT = 42,
		CAMP__BUTTON_CAMP_SELECT_FROM_POKEMON = 43,
		CAMP__BUTTON_STANDBY = 44,
		CAMP__BUTTON_CAMPSITE = 45,
		CAMP__BUTTON_CAMPSITE_POKEMON_FAVATITE_ON = 46,
		CAMP__BUTTON_CAMPSITE_POKEMON_FAVATITE_OFF = 47,
		BANK__BUTTON_DEPOSIT = 48,
		BANK__BUTTON_DRAW = 49,
		DUNGEON_RESULT__NEXT = 50,
		DUNGEON_RESULT__TREASURE = 51,
		DUNGEON_RESULT__TREASURE_LIST = 52,
		DUNGEON_RESULT__JOIN = 53,
		EVOLUTION__BUTTON_NORMAL = 54,
		EVOLUTION__BUTTON_MULTIPLE = 55,
		EVOLUTION__BUTTON_CLOSE = 56,
		DUNGEON_PARTY__TOP = 57,
		DUNGEON_PARTY__TSUYOSA = 58,
		DUNGEON_PARTY__WAZA = 59,
		DUNGEON_PARTY__WAZA_SELECT = 60,
		DUNGEON_PARTY__TOKUTYO = 61,
		DUNGEON_PARTY__TOKUTYO_SCROLL_EXTRA = 62,
		DUNGEON_PARTY__JOTAI = 63,
		DUNGEON_PARTY__JOTAI_SELECT = 64,
		SOUKO_BUTTON_DRAW_ITEM = 65,
		SOUKO_BUTTON_DEPOSIT_ITEM = 66,
		RESCUE_OFFICE_ORDER_BUTTON_DETAIL_INTERNET = 67,
		RESCUE_OFFICE_ORDER_BUTTON_DETAIL_BUTTON = 68,
		RESCUE_OFFICE_BUTTON_QUEST_LIST = 69,
		RESCUE_OFFICE_BUTTON_DETAIL = 70,
		RESCUE_OFFICE_BUTTON_QUEST_BOARD = 71,
		RESCUE_OFFICE_BUTTON_DEBUG = 72,
		TRAINING_BUTTON_TUTORIAL = 73,
		TRAINING_BUTTON_TICKET = 74,
		TRAINING_BUTTON_POKEMON = 75,
		TEAM_FLAG_BUTTON_LIST = 76,
		WAZA_BUTTON_RENKETSU_WAZADETAIL = 77,
		CAMP_BUTTON_CAMPSITE_NOBODY_HERE = 78,
		WONDER_MAIL_QUEST_TRASH = 79,
		DUNGEON_MAIN_GUIDE1 = 80,
		DUNGEON_MAIN_GUIDE2 = 81,
		DUNGEON_MAIN_LOOK = 82,
		END = 83
	}

	public enum WallPapr // TypeDefIndex: 6165
	{
		None = -1,
		Load = 0,
		Load2 = 1,
		Load3 = 2,
		Load4 = 3,
		Load5 = 4,
		Load6 = 5,
		Mail = 6,
		Request = 7,
		Result = 8,
		Camp = 9
	}

	// Constructors
	public CommonScreen() {} // 0x009C4C00-0x009C5080
	static CommonScreen() {} // 0x009CBDA0-0x009CBE60

	// Methods
	public override void Init(GameObject root) {} // 0x009C8750-0x009C8C30
	// [IteratorStateMachine] // 0x00624890-0x00624900
	public virtual IEnumerator SetWallPaper(WallPapr reqWp, Action cb = null) => default; // 0x009C9730-0x009C97B0
	private GameObject _getWallPaperFrontOfFilterRoot() => default; // 0x009C9580-0x009C9670
	private GameObject _getWallPaperBackOfFilterRoot() => default; // 0x009C9490-0x009C9580
	public void SetBgBlack(bool bVisible) {} // 0x009C9670-0x009C9730
	// [IteratorStateMachine] // 0x00624900-0x00624970
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x009C97B0-0x009C9830
	// [IteratorStateMachine] // 0x00624970-0x006249E0
	public IEnumerator OpenWindow_ExceptFooter(Action cb = null) => default; // 0x009C9830-0x009C98B0
	// [IteratorStateMachine] // 0x006249E0-0x00624A50
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x009C98B0-0x009C9930
	// [IteratorStateMachine] // 0x00624A50-0x00624AC0
	public IEnumerator CloseWindow_ExceptCaption(Action cb = null) => default; // 0x009C9930-0x009C99B0
	// [IteratorStateMachine] // 0x00624AC0-0x00624B30
	public IEnumerator CloseFooterAndGuide(Action cb = null) => default; // 0x009C99B0-0x009C9A30
	// [IteratorStateMachine] // 0x00624B30-0x00624BA0
	public IEnumerator OpenFooterAndGuide(Action cb = null) => default; // 0x009C9A60-0x009C9AE0
	private GameObject _getFooterRoot() => default; // 0x009C8C30-0x009C8CC0
	private void _VisibleFooter(bool bVisible) {} // 0x009C8CC0-0x009C8DF0
	// [IteratorStateMachine] // 0x00624BA0-0x00624C10
	public IEnumerator OpenFooter(Action cb = null) => default; // 0x009C9AE0-0x009C9B60
	// [IteratorStateMachine] // 0x00624C10-0x00624C80
	public IEnumerator CloseFooter(Action cb = null) => default; // 0x009C9B60-0x009C9BE0
	private GameObject _getDgFooterRoot() => default; // 0x009C9C10-0x009C9D00
	public void VisibleDgFooter(bool bVisible) {} // 0x009C9D00-0x009C9DC0
	private void _VisibleDgFooter(bool bVisible) {} // 0x009C9DC0-0x009C9E80
	private GameObject _getFilterRoot() => default; // 0x009C8DF0-0x009C8EE0
	private void _VisibleFilter(bool bVisible) {} // 0x009C8EE0-0x009C8FA0
	// [IteratorStateMachine] // 0x00624C80-0x00624CF0
	private IEnumerator _OpenFilter(Action cb = null) => default; // 0x009C9E80-0x009C9F00
	// [IteratorStateMachine] // 0x00624CF0-0x00624D60
	public IEnumerator CloseFilter(Action cb = null) => default; // 0x009C9F00-0x009C9F80
	private GameObject _getCaptionRoot() => default; // 0x009C8FA0-0x009C9090
	private void _VisibleCaption(bool bVisible) {} // 0x009C9090-0x009C9150
	// [IteratorStateMachine] // 0x00624D60-0x00624DD0
	public IEnumerator OpenCaption(Action cb = null) => default; // 0x009C9FB0-0x009CA030
	// [IteratorStateMachine] // 0x00624DD0-0x00624E40
	public IEnumerator CloseCaption(Action cb = null) => default; // 0x009CA030-0x009CA0B0
	protected virtual void _setCaption(string sText) {} // 0x009CA0E0-0x009CA240
	// [IteratorStateMachine] // 0x00624E40-0x00624EB0
	private IEnumerator _changeCaption(GameObject obj) => default; // 0x009CA240-0x009CA2C0
	private void _setCaption(TextIDHash caption, TextIDHash currentCaption) {} // 0x009CA2C0-0x009CA4C0
	private void _setCaptionHistory(TextIDHash textIDHash) {} // 0x009CA4C0-0x009CA5B0
	private TextIDHash _prevCaptionHistory() => default; // 0x009CA5B0-0x009CA630
	private TextIDHash _currentCaptionHistory() => default; // 0x009CA630-0x009CA690
	public TextIDHash GetCaption() => default; // 0x009CA690-0x009CA6F0
	public TextIDHash SetCaption(TextIDHash caption) => default; // 0x009CA6F0-0x009CA770
	public void SetCaption(GuideCaption eCaption) {} // 0x009CA770-0x009CA860
	public void PrevCaption() {} // 0x009CA860-0x009CA930
	public void ClearCaption() {} // 0x009C9150-0x009C91C0
	private GameObject _getButtonGuideRoot() => default; // 0x009C91C0-0x009C92B0
	public void VisibleDungeonFooter(bool bVisible) {} // 0x009CA930-0x009CAAE0
	private void _VisibleButtonGuide(bool bVisible) {} // 0x009C92B0-0x009C9370
	// [IteratorStateMachine] // 0x00624EB0-0x00624F20
	public IEnumerator OpenButtonGuide(Action cb = null) => default; // 0x009CAAF0-0x009CAB70
	// [IteratorStateMachine] // 0x00624F20-0x00624F90
	public IEnumerator CloseButtonGuide(Action cb = null) => default; // 0x009CAB70-0x009CABF0
	protected virtual void _setButtonGuide(string sText) {} // 0x009CAC20-0x009CAD80
	// [IteratorStateMachine] // 0x00624F90-0x00625000
	private IEnumerator _changeButton(GameObject obj) => default; // 0x009CAD80-0x009CAE00
	private void _setButtonGuide(TextIDHash button, TextIDHash currentButton) {} // 0x009CAE00-0x009CB000
	private void _quicksetButtonGuide(TextIDHash button, TextIDHash currentButton) {} // 0x009CB000-0x009CB160
	private void _setButtonHistory(TextIDHash button) {} // 0x009CB160-0x009CB230
	private TextIDHash _prevButtonHistory() => default; // 0x009CB230-0x009CB2B0
	private TextIDHash _currentButtonHistory() => default; // 0x009CB2B0-0x009CB310
	public TextIDHash GetButtonGuide() => default; // 0x009CB310-0x009CB370
	public TextIDHash SetButtonGuide(TextIDHash button) => default; // 0x009CB370-0x009CB490
	public void SetButtonGuide(GuideButton button) {} // 0x009CB490-0x009CB540
	public TextIDHash QuickSetButtonGuide(TextIDHash button) => default; // 0x009CB540-0x009CB660
	public void PrevButtonGuide() {} // 0x009CB660-0x009CB730
	public void ClearButtonGuide() {} // 0x009C9370-0x009C9490
	public void QuickDisappearCaptionSet() {} // 0x009CB730-0x009CB9C0
	public void QuickAppearCaptionSet() {} // 0x009CB9C0-0x009CBC50
	public void SetVisible_Footer(bool visible) {} // 0x009CBC50-0x009CBD00
	public void SetVisible_ButtonGuide(bool visible) {} // 0x009CBD00-0x009CBD30
	public bool IsVisibleCaptionSet() => default; // 0x009CBD30-0x009CBD70
	public void setViewState(ViewState state) {} // 0x009CBD70-0x009CBD80
	public void SetVisibleBool(bool visible) {} // 0x009CBD80-0x009CBDA0
}

