/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class RenketsuWazaListWindow : BasicMenuWindow // TypeDefIndex: 8002
{
	// Fields
	protected List<List<int>> renketsuList_; // 0x48
	protected static string[] aSelectorToken; // 0x00
	protected static string[] aCursorToken; // 0x08
	protected static string[] aIconToken; // 0x10
	protected int renketsuType_; // 0x50
	private static int[,] aRenketsuSelectorTokenId; // 0x18
	private static int[,] aRenketsuItemTokenId; // 0x20
	private static int[,] aRenketsuTokenId; // 0x28
	protected bool bGuest_; // 0x54
	protected UIToken.UITokenCache objRootCache_; // 0x58

	// Constructors
	public RenketsuWazaListWindow() {} // 0x00A00570-0x00A00580
	static RenketsuWazaListWindow() {} // 0x00A00580-0x00A01380

	// Methods
	protected override bool _doLeft() => default; // 0x009FCB10-0x009FCB20
	protected override bool _doRight() => default; // 0x009FCB20-0x009FCB30
	protected virtual int _getRenketsuSelectorTokenId(int row) => default; // 0x009FCB30-0x009FCC10
	protected virtual int _getRenketsuItemTokenId(int row) => default; // 0x009FCC10-0x009FCCF0
	protected virtual int _getRenketsuCursorTokenId(int row) => default; // 0x009FCCF0-0x009FCDD0
	protected virtual int _getRenketsuIconTokenId(int row) => default; // 0x009FCDD0-0x009FCEB0
	public static void InitPrefab(GameObject objRoot, ref UIToken.UITokenCache objRootCache) {} // 0x009FCEB0-0x009FD370
	protected virtual void _init(GameObject objRoot, IPokemonStatus pokemonStatus, bool bOriginal) {} // 0x009FD370-0x009FD600
	protected virtual void _initMenu(IPokemonStatus pokemonStatus, bool bOriginal) {} // 0x009FD600-0x009FE030
	public int GetRowCount() => default; // 0x009FE2D0-0x009FE320
	public int GetItemCount() => default; // 0x009FE320-0x009FE450
	public void Init(GameObject objRoot, IPokemonStatus pokemonStatus, bool bOriginal, int defaultIndex = 0 /* Metadata: 0x00613C17 */) {} // 0x009FE450-0x009FE520
	public void InitNoFocus(GameObject objRoot, IPokemonStatus pokemonStatus, bool bOriginal, int defaultIndex = 0 /* Metadata: 0x00613C1B */) {} // 0x009FE900-0x009FE9B0
	public void ShowList(GameObject objRoot, IPokemonStatus pokemonStatus, bool bOriginal) {} // 0x009FE520-0x009FE900
	public static Index GetWaza(int index, IPokemonStatus status, bool bOriginal) => default; // 0x009FED70-0x009FEDF0
	protected static Index getWaza(int index, IPokemonStatus status, bool bOriginal) => default; // 0x009FE030-0x009FE180
	protected bool isWazaRenketsuChild(int index, IPokemonStatus status, bool bOriginal) => default; // 0x009FEC30-0x009FED70
	protected bool isWazaRenketsuParent(int index, IPokemonStatus status, bool bOriginal) => default; // 0x009FE9B0-0x009FEAF0
	protected List<int> getWazaRenketsuList(int index, IPokemonStatus status, bool bOriginal) => default; // 0x009FEAF0-0x009FEC30
	protected string getName(Index index, IPokemonStatus status, bool bOriginal) => default; // 0x009FEDF0-0x009FF0D0
	protected int getPP(Index index, IPokemonStatus status, bool bOriginal) => default; // 0x009FF0D0-0x009FF2C0
	protected int getPPMax(Index index, IPokemonStatus status) => default; // 0x009FF2C0-0x009FF3F0
	protected bool isEnableWaza(int index, IPokemonStatus status, bool original) => default; // 0x009FE180-0x009FE2D0
	public virtual int GetFocusWazaStatusId() => default; // 0x009FF3F0-0x009FF470
	protected override bool _setEnable(bool bEnable) => default; // 0x009FF470-0x009FF4B0
	protected virtual void _cursorVisible(bool bVisible) {} // 0x009FF4B0-0x009FF710
	private void _cbCursorChange(ActionType act) {} // 0x009FF710-0x009FF730
	protected virtual void _setupItemFaceIcon(int itemCount) {} // 0x009FF730-0x009FF920
	protected virtual void _setupItemFace(IPokemonStatus pokemonStatus, bool bOriginal, Index wazaIndex, bool bOn, bool bNew, GameObject faceObj) {} // 0x009FF920-0x00A00030
	public void RedrawOnOff(IPokemonStatus pokemonStatus, int wazaId) {} // 0x00A00030-0x00A00570
}

