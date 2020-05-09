/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;
using Const.waza;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWazaButtonSet : UIManagerBase // TypeDefIndex: 7762
{
	// Fields
	private CommonScreen commonScreen_; // 0x20
	private bool bCancel_; // 0x28
	private bool bDecide; // 0x29
	private bool bSelect; // 0x2A
	private bool bAnimation; // 0x2B
	private bool bChanged; // 0x2C
	private bool[] bWaza; // 0x30
	private bool bThrow; // 0x38
	private static bool bDispPPMax; // 0x00
	private int nowFocus; // 0x3C
	private int nowSelect; // 0x40
	private GameObject[] buttons; // 0x48
	private GameObject[] selects; // 0x50
	private GameObject[] focuses; // 0x58
	private GameObject regist_item; // 0x60
	private GameObject equip_item; // 0x68
	public IPokemonStatus pokemonStatus_; // 0x70
	public ICreature pokemonCreature_; // 0x78
	private string[] moveAnimationTable; // 0x80
	private string[] resetAnimationTable; // 0x88
	private string[] renketsuSetTable; // 0x90
	private string[] affinityIconTable; // 0x98
	private string[] flashAnimationTable; // 0xA0
	private string[] changeAnimationTable; // 0xA8
	private List<int[]> history; // 0xB0
	private static GameObject[] buttonSets; // 0x08
	private Image[] affinityIcons; // 0xB8
	private static Mode mode_; // 0x10
	private int[] nowWazaIndex; // 0xC0
	private int[] nowWazaPP; // 0xC8
	private int[] nowWazaPPMax; // 0xD0
	private int[] nowWazaParent; // 0xD8
	private int[] nowWazaRenketsu; // 0xE0
	private GameObject[] wazaPPTextObj; // 0xE8
	private GameObject[] wazaNameObj; // 0xF0
	private GameObject[] wazaBgObj; // 0xF8
	private string[] renketsuSet; // 0x100
	private bool[] nowWazaEnable; // 0x108
	private RenketsuWazaListWindow wazaListWindow_; // 0x110
	private GameObject mainObj_; // 0x118
	private bool is_exit; // 0x120

	// Nested types
	private enum Mode // TypeDefIndex: 7763
	{
		KeyChange = 0,
		Shortcut = 1
	}

	// Constructors
	public UIWazaButtonSet() {} // 0x00DCD960-0x00DCE570
	static UIWazaButtonSet() {} // 0x00DCE570-0x00DCE5E0

	// Methods
	public static UIWazaButtonSet Create() => default; // 0x00DC6A00-0x00DC6C30
	public static UIWazaButtonSet CreateInDungeon(GameObject obj) => default; // 0x00DC7180-0x00DC7350
	public static void PrepareInDungeon(GameObject obj) {} // 0x00DC7350-0x00DC7770
	public static UIWazaButtonSet GetInDungeon(ICreature player, ICreature enemy) => default; // 0x00DC7770-0x00DC7A30
	public static UIWazaButtonSet CreateInDungeonForButtonSet(IPokemonStatus status = null) => default; // 0x00DC8D20-0x00DC8F10
	public static UIWazaButtonSet CreateForWazaMain() => default; // 0x00DC8F10-0x00DC9190
	public void Reset(ICreature creature, IPokemonStatus status) {} // 0x00DC7A30-0x00DC80C0
	public void SetAffinity(ICreature player, ICreature enemy) {} // 0x00DC86F0-0x00DC8D20
	public void SetRegistItem() {} // 0x00DC80C0-0x00DC8460
	public void SetEquipItem(ICreature player) {} // 0x00DC8460-0x00DC86F0
	public void Construct(ICreature creature, IPokemonStatus status) {} // 0x00DC6C30-0x00DC7180
	private void updatePP() {} // 0x00DC94E0-0x00DC97D0
	private void updateWazaName() {} // 0x00DC97D0-0x00DC9A30
	private void updateDisable() {} // 0x00DC9A30-0x00DC9D50
	public void Destruct() {} // 0x00DCAFF0-0x00DCB3C0
	private void setWazaInfo(int index, GameObject button) {} // 0x00DC9DC0-0x00DCAC60
	private Index getWaza(int index) => default; // 0x00DC91B0-0x00DC9250
	private bool isWazaRenketsuChild(int index) => default; // 0x00DCB3C0-0x00DCB440
	private bool isWazaRenketsuParent(int index) => default; // 0x00DCB440-0x00DCB4C0
	private List<int> getWazaRenketsuList(int index) => default; // 0x00DCB4C0-0x00DCB540
	private string getName(int index) => default; // 0x00DCAE30-0x00DCAF10
	private int getWazaParent(int index) => default; // 0x00DC9250-0x00DC92D0
	private int getPP(int index) => default; // 0x00DC92D0-0x00DC9380
	private int getPPMax(int index) => default; // 0x00DC9380-0x00DC9440
	private bool isEnableWaza(int index) => default; // 0x00DC9440-0x00DC94E0
	private Const.pokemon.Type getType(int index) => default; // 0x00DCAF10-0x00DCAFF0
	private void setWazaItem(int index, GameObject root) {} // 0x00DCB540-0x00DCC170
	public void Init(FlowPlay instance, GameObject mainObj) {} // 0x00DCC170-0x00DCC180
	// [IteratorStateMachine] // 0x0062E610-0x0062E680
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00DCC180-0x00DCC200
	// [IteratorStateMachine] // 0x0062E680-0x0062E6F0
	public new IEnumerator MainFlow() => default; // 0x00DCC230-0x00DCC2A0
	public void Update() {} // 0x00DCC2D0-0x00DCC320
	private void redraw() {} // 0x00DCAC60-0x00DCAE30
	private void _doInput() {} // 0x00DCC320-0x00DCC7B0
	private bool _doUp() => default; // 0x00DCC7B0-0x00DCC870
	private bool _doDown() => default; // 0x00DCC870-0x00DCC930
	private bool _doLeft() => default; // 0x00DCC9F0-0x00DCCAB0
	private bool _doRight() => default; // 0x00DCC930-0x00DCC9F0
	private bool _doDecide() => default; // 0x00DCCAB0-0x00DCCD80
	private bool _doExit(bool silent = false /* Metadata: 0x00613A19 */) => default; // 0x00DCCD80-0x00DCCF00
	private bool isAnyPossibleWaza(int waza_no) => default; // 0x00DCD3B0-0x00DCD590
	private bool _doWazaExecute(int waza_no) => default; // 0x00DCCF00-0x00DCD180
	private bool _doItemThrow() => default; // 0x00DCD180-0x00DCD330
	// [IteratorStateMachine] // 0x0062E6F0-0x0062E760
	private IEnumerator changeAnimation(int from, int to) => default; // 0x00DCD330-0x00DCD3B0
	private void hideWazaShortcut() {} // 0x00DCD5C0-0x00DCD960
	private bool IsMAGICROOM() => default; // 0x00DC9D50-0x00DC9DC0
}

