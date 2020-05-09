/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowPlayManager : SingletonMonoBehaviour<FlowPlayManager> // TypeDefIndex: 5363
{
	// Fields
	private ShopType shopType_; // 0x18
	private FlowPlay.FlowPlayParam param_; // 0x20
	private FlowPlay flow; // 0x28
	public FlowPlay callFlowInstance_; // 0x30

	// Properties
	public ShopType ShopType_ { get => default; } // 0x0099C830-0x0099C840 
	public FlowPlay FlowInstance_ { get => default; } // 0x009A33A0-0x009A33C0 

	// Nested types
	public enum ShopType // TypeDefIndex: 5364
	{
		Kakureon = 0,
		Azuki = 1,
		Waza = 2,
		Ginkou = 3,
		Souko = 4,
		Kunrenjo = 5,
		WarehouseSystem = 6,
		BankSystem = 7,
		Camp = 8,
		CampShop = 9,
		Garuura_Image = 10,
		Evolution = 11,
		Rescue_Top = 12,
		Rescue_Gate = 13,
		Rescue_Get = 14,
		Rescue_Go = 15,
		Rescue_Get_Normal = 16,
		Rescue_Get_Confirm = 17,
		Rescue_return = 18,
		Max = 19
	}

	// Constructors
	public FlowPlayManager() {} // 0x009A3530-0x009A35A0

	// Methods
	private void OnEnable() {} // 0x009A2DF0-0x009A2E60
	private void AllSet(FlowPlay flow) {} // 0x009A2E60-0x009A3000
	// [IteratorStateMachine] // 0x0061FC00-0x0061FC70
	public IEnumerator MainFlow(int result) => default; // 0x009A3010-0x009A3090
	public IEnumerator Shop(ShopType shopType, FlowPlay.FlowPlayParam param) => default; // 0x009A30C0-0x009A3130
	public static void SwitchCreate(ShopType shopType, out UIManagerBase ui, out FlowPlay flow, out bool system, FlowPlay.FlowPlayParam param = null) {
		ui = default;
		flow = default;
		system = default;
	} // 0x0099E080-0x0099E440
	// [IteratorStateMachine] // 0x0061FC70-0x0061FCE0
	public IEnumerator SwitchFlowPlay() => default; // 0x009A3130-0x009A31A0
	// [IteratorStateMachine] // 0x0061FCE0-0x0061FD50
	public IEnumerator HenseiWarehouse() => default; // 0x009A33F0-0x009A3460
	// [IteratorStateMachine] // 0x0061FD50-0x0061FDC0
	public IEnumerator HenseiBank() => default; // 0x009A3490-0x009A3500
	public static string GetJsonName(ShopType type, bool system) => default; // 0x0099E4F0-0x0099E560
}

