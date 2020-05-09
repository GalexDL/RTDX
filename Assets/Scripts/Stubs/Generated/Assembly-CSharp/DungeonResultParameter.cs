/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class DungeonResultParameter : ISerializationCallbackReceiver // TypeDefIndex: 4637
{
	// Fields
	[SerializeField] // 0x00615FB0-0x00615FC0
	private byte[] data_DungeonName; // 0x10
	[SerializeField] // 0x00615FC0-0x00615FD0
	private byte[] data_TargetName; // 0x18
	[SerializeField] // 0x00615FD0-0x00615FE0
	private byte[] data_AttackerName; // 0x20
	[SerializeField] // 0x00615FE0-0x00615FF0
	private byte[] data_ResultText; // 0x28
	[NonSerialized]
	public string DungeonName; // 0x30
	[NonSerialized]
	public string TargetName; // 0x38
	[NonSerialized]
	public string AttackerName; // 0x40
	[NonSerialized]
	public string ResultText; // 0x48
	public Const.DungeonResult Result; // 0x50
	public DungeonResultCause ResultCause; // 0x54
	public int ResultLv; // 0x58
	public int ResultExp; // 0x5C
	public int ResultHP; // 0x60
	public int ResultMaxHP; // 0x64
	public int ResultAtk; // 0x68
	public int ResultDfd; // 0x6C
	public int ResultExAtk; // 0x70
	public int ResultExDfd; // 0x74
	public int ResultSpeed; // 0x78
	public int ResultAddedChousadanPoint; // 0x7C
	public Const.item.Index EquipItem; // 0x80
	public PokemonWarehouseId PlayerId; // 0x88
	public Const.creature.Index BossIndex; // 0x90
	public int CauseValue; // 0x94
	public bool IsAlreadyDispResult; // 0x98
	public bool DungeonError; // 0x99
	public bool ExecutedPenaltyItemBag; // 0x9A
	public bool ExecutedPenaltyMoney; // 0x9B

	// Constructors
	public DungeonResultParameter() {} // 0x00BBD7E0-0x00BBD900

	// Methods
	public void OnBeforeSerialize() {} // 0x00BBF9F0-0x00BBFA90
	public void OnAfterDeserialize() {} // 0x00BBFA90-0x00BBFB30
	public bool IsValid() => default; // 0x00BBFB30-0x00BBFB40
	public void Clear() {} // 0x00BBDBC0-0x00BBDC50
	public void ExportStream(DataExchangeByteMemoryStream byteStream) {} // 0x00BBE140-0x00BBE2F0
	public void ImportStream(DataExchangeByteMemoryStream byteStream) {} // 0x00BBE6A0-0x00BBE8A0
	public bool IsQuestPenaltyResult() => default; // 0x00BBFB40-0x00BBFC30
	public bool IsItemAndMoneyPenaltyResult() => default; // 0x00BBFC30-0x00BBFC60
}

