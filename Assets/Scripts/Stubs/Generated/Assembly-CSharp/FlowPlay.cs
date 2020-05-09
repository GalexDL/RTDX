/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.dungeon;
using Const.item;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class FlowPlay : MonoBehaviour // TypeDefIndex: 5334
{
	// Fields
	public bool IsCallFlow; // 0x18
	protected ShopFlowTagSetManager tagSetManager; // 0x20
	private bool m_init; // 0x28
	public Result m_result; // 0x2C
	private bool bDeposit; // 0x30
	public FlowToolBox m_toolBox; // 0x38
	private static FlowPlay m_gamePlay; // 0x00
	protected CommonScreen commonScreen_; // 0x40
	private Const.waza.Index selectWazaIndex; // 0x48
	private Const.waza.Index selectForgetWazaIndex; // 0x4C
	private int selectLocalWazaIndex; // 0x50
	private IPokemonStatus selectPokemonStatus; // 0x58
	private int selectCursorIndex; // 0x60
	private List<FlowGameSaveData.NodeData> m_gsdnList; // 0x68
	private FlowGameSaveData.NodeData m_currentNode; // 0x70
	public List<GameObject> m_tglList; // 0x78
	protected List<IItem> m_selectItemList; // 0x80
	protected string message_; // 0x88

	// Properties
	public bool Initialize { get; set; } // 0x009990F0-0x00999100 0x009990E0-0x009990F0
	public bool Deposit { get; set; } // 0x00999100-0x00999110 0x00999110-0x00999120
	public static FlowPlay Instance { get; } // 0x00999120-0x00999190 
	public FlowToolBox ToolBox { get; } // 0x00999190-0x009991A0 
	public Const.waza.Index SelectWazaIndex { get; set; } // 0x00999260-0x00999270 0x00999250-0x00999260
	public Const.waza.Index SelectForgetWazaIndex { get; set; } // 0x00999280-0x00999290 0x00999270-0x00999280
	public int SelectLocalWazaId { get; set; } // 0x00999290-0x009992A0 0x009992A0-0x009992B0
	public IPokemonStatus SelectPokemonStatus { get; set; } // 0x009992C0-0x009992D0 0x009992B0-0x009992C0
	public int SelectCursorIndex { get; set; } // 0x009992D0-0x009992E0 0x009992E0-0x009992F0
	public List<FlowGameSaveData.NodeData> GSDNList { get; } // 0x00999580-0x00999590 
	public FlowGameSaveData.NodeData CurrentNode { get; set; } // 0x00997670-0x00997680 0x00999590-0x009995A0
	public List<IItem> SelectItemList { get; } // 0x009995A0-0x009995B0 

	// Nested types
	public delegate string func(string label); // TypeDefIndex: 5335; 0x009A0250-0x009A07D0

	public enum Result // TypeDefIndex: 5336
	{
		None = 0,
		Escape = 1,
		MenuReset = 2
	}

	public class FlowPlayParam // TypeDefIndex: 5337
	{
		// Fields
		public FlowPlayType playType; // 0x10
		public bool bFromTop; // 0x14
		public float discountRate; // 0x18
		public FlowPlayManager.ShopType shopType; // 0x1C

		// Constructors
		public FlowPlayParam() {} // 0x0099E560-0x0099E570
	}

	public enum FlowPlayType // TypeDefIndex: 5338
	{
		NORMAL = 0,
		SLEEP = 1
	}

	// Constructors
	protected FlowPlay() {} // 0x00998F90-0x009990D0
	static FlowPlay() {} // 0x0099D8D0-0x0099D8E0

	// Methods
	protected string GetDebugMessage(string label) => default; // 0x009976B0-0x009977C0
	// [IteratorStateMachine] // 0x0061F500-0x0061F570
	protected virtual IEnumerator CloseCommon(Action cb = null) => default; // 0x009991A0-0x00999220
	private string GetLabel(string label, string csvFileName) => default; // 0x009992F0-0x009994F0
	public string GetMessage(string label, string csvFileName) => default; // 0x009977C0-0x00997A20
	protected string GetMessage_FlowPlayType(FlowPlayType type) => default; // 0x009994F0-0x00999580
	private void Start() {} // 0x009995B0-0x009995C0
	private void OnDestroy() {} // 0x009995C0-0x009995D0
	public abstract IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param);
	private void Update() {} // 0x009995D0-0x009995E0
	public void Load(string path) {} // 0x009995E0-0x009996C0
	public FlowGameSaveData.NodeData SearchNode(int ID) => default; // 0x009996C0-0x009997B0
	// [IteratorStateMachine] // 0x0061F570-0x0061F5E0
	protected IEnumerator MoveNext_default(FlowPlayType playType, ShopFlowNode.NodeType type) => default; // 0x009997B0-0x00999830
	private void MoveNext_DisappearCommon() {} // 0x00999860-0x009998E0
	private void MoveNext_IsDungeonMode(FlowPlayType playType) {} // 0x009998E0-0x009999C0
	private void MoveNext_IsSleep(FlowPlayType playType) {} // 0x009999C0-0x00999A60
	private void MoveNext_PlayME() {} // 0x00999A60-0x00999B20
	private void MoveNext_PlaySE() {} // 0x00999B20-0x00999BE0
	private void MoveNext_PlayBGM() {} // 0x00999BE0-0x00999CA0
	// [IteratorStateMachine] // 0x0061F5E0-0x0061F650
	private IEnumerator MoveNext_PopUp() => default; // 0x00999CA0-0x00999D10
	private void MoveNext_CaptionSetNode() {} // 0x00999D40-0x00999EE0
	private void MoveNext_GuideButtonSetNode() {} // 0x00999EE0-0x0099A010
	// [IteratorStateMachine] // 0x0061F650-0x0061F6C0
	private IEnumerator MoveNext_FadeIn() => default; // 0x0099A010-0x0099A080
	// [IteratorStateMachine] // 0x0061F6C0-0x0061F730
	private IEnumerator MoveNext_FadeIn_Long() => default; // 0x0099A0B0-0x0099A120
	// [IteratorStateMachine] // 0x0061F730-0x0061F7A0
	private IEnumerator MoveNext_FadeIn_Short() => default; // 0x0099A150-0x0099A1C0
	// [IteratorStateMachine] // 0x0061F7A0-0x0061F810
	private IEnumerator MoveNext_FadeOut() => default; // 0x0099A1F0-0x0099A260
	private void MoveNext_BGM_FadeOut() {} // 0x0099A290-0x0099A350
	// [IteratorStateMachine] // 0x0061F810-0x0061F880
	private IEnumerator MoveNext_FadeOut_Short() => default; // 0x0099A350-0x0099A3C0
	// [IteratorStateMachine] // 0x0061F880-0x0061F8F0
	private IEnumerator MoveNext_WhiteFadeOut() => default; // 0x0099A3F0-0x0099A460
	protected virtual void End() {} // 0x0099A490-0x0099A5A0
	// [IteratorStateMachine] // 0x0061F8F0-0x0061F960
	protected virtual IEnumerator CallFlow() => default; // 0x0099A5A0-0x0099A610
	public void MoveNext(int rootNo = 0 /* Metadata: 0x006112E0 */) {} // 0x00997A20-0x00997AB0
	public void MoveEnd() {} // 0x0099A640-0x0099A710
	protected bool CheckNextBeing(int rootNo) => default; // 0x00997680-0x009976B0
	protected virtual Vector2Int GetFaceWindowPos() => default; // 0x0099A710-0x0099A750
	protected virtual Const.creature.Index GetMasterIndex() => default; // 0x0099A750-0x0099A760
	public virtual void OpenFaceWindow(FlowPlayType type) {} // 0x0099A760-0x0099A8C0
	// [IteratorStateMachine] // 0x0061F960-0x0061F9D0
	private IEnumerator MessageWindow_TagSetOpen(FlowPlayType playType, bool backUI = false /* Metadata: 0x006112E4 */) => default; // 0x0099A8C0-0x0099A950
	// [IteratorStateMachine] // 0x0061F9D0-0x0061FA40
	private IEnumerator ChoiceWindow_TagSetOpen(FlowPlayType playType, bool backUI = false /* Metadata: 0x006112E5 */) => default; // 0x0099A980-0x0099AA10
	// [IteratorStateMachine] // 0x0061FA40-0x0061FAB0
	private IEnumerator ChoiceOnlyWindow_TagSetOpen(FlowPlayType playType, bool backUI = false /* Metadata: 0x006112E6 */) => default; // 0x0099AA40-0x0099AAC0
	protected void MoveNextTagDataSet() {} // 0x0099AAF0-0x0099B180
	protected void SwitchTagSet() {} // 0x00996EF0-0x00997670
	public void SwitchTagSet_Lua(TagSetLazyBuffer LazyTagBuffer) {} // 0x0099B180-0x0099B880
	protected virtual Const.creature.Index GetPokemonData() => default; // 0x0099B880-0x0099B890
	protected virtual string GetPokemonData_String() => default; // 0x0099B890-0x0099B8E0
	protected virtual Const.item.Index GetItemData() => default; // 0x0099B8E0-0x0099B8F0
	protected virtual IItem GetSelectTrueItemData() => default; // 0x0099B8F0-0x0099B900
	protected virtual int GetMoneyData() => default; // 0x0099B900-0x0099B910
	protected virtual string GetValueData() => default; // 0x0099B910-0x0099B960
	protected virtual string GetWazaData() => default; // 0x0099B960-0x0099B9B0
	protected virtual Const.camp.Index GetCampData() => default; // 0x0099B9B0-0x0099B9C0
	protected virtual Const.creature.Index GetKindData() => default; // 0x0099B9C0-0x0099B9D0
	protected virtual string GetTutorialData() => default; // 0x0099B9D0-0x0099BA20
	protected virtual Const.dungeon.Index GetDungeonData() => default; // 0x0099BA20-0x0099BA30
	protected virtual string GetTeamData() => default; // 0x0099BA30-0x0099BA80
	// [IteratorStateMachine] // 0x0061FAB0-0x0061FB20
	protected virtual IEnumerator CallFlow_MoveNext() => default; // 0x0099BA80-0x0099BAE0
	public void MoveNextCheckItemBag() {} // 0x0099BB10-0x0099BBF0
	public void MoveNextCheckMoney() {} // 0x0099BC00-0x0099BCA0
	public void MoveNextCheckSellAfter() {} // 0x0099BCA0-0x0099BE10
	public void MoveNextCheckBuyResult() {} // 0x0099BE10-0x0099C000
	public void MoveNextCheckDepositItem() {} // 0x0099C000-0x0099C240
	public void MoveNextCheckDrawItem(UIWarehouse menu) {} // 0x0099C240-0x0099C350
	public void MoveNextBagItemZeroCheck() {} // 0x0099C360-0x0099C430
	public void MoveNextTagSet(int num) {} // 0x0099C430-0x0099C830
	// [IteratorStateMachine] // 0x0061FB20-0x0061FB90
	public IEnumerator MoveNextMessageAndChoice(string windowMessage, func getMessage) => default; // 0x0099C840-0x0099C8C0
	public void MoveNextCheckSellPossible() {} // 0x0099C8F0-0x0099C950
	public void MoveNextCheckBankMoneyZeroCheck() {} // 0x0099C950-0x0099CA20
	public void MoveNextCheckBagMoneyMaxCheck() {} // 0x0099CA30-0x0099CB20
	public void MoveNextCheckBankMoneyMaxCheck() {} // 0x0099CB20-0x0099CBF0
	public void MoveNextBagMoneyZeroCheck() {} // 0x0099CBF0-0x0099CCC0
	public void MoveNextShopItemListZeroCheck() {} // 0x0099CCC0-0x0099CDA0
	public void MoveNextWarehouseItemMaxCheck() {} // 0x0099CDB0-0x0099CE80
	protected void MoveNextCheckWaza4(IPokemonStatus status) {} // 0x0099CE80-0x0099CF60
	protected void MoveNextConfirmForget(IPokemonStatus status, Const.waza.Index wazaIndex) {} // 0x0099CF60-0x0099D4C0
	protected void MoveNext_Jump() {} // 0x0099D4C0-0x0099D5D0
	protected void MoveNext_DeleteCursorData() {} // 0x0099D5D0-0x0099D630
	// [IteratorStateMachine] // 0x0061FB90-0x0061FC00
	protected IEnumerator MoveNext_ScriptCall(FlowPlayType type) => default; // 0x0099D630-0x0099D6B0
	protected void MessageAndFaceClose() {} // 0x0099D6E0-0x0099D770
	public int GetBagAndWarehouseCount(Const.item.Index index) => default; // 0x0099D770-0x0099D8D0
}

