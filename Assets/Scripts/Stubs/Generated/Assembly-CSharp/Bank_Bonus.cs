/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.fixed_reward;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Bank_Bonus : Singleton<Bank_Bonus> // TypeDefIndex: 4603
{
	// Fields
	private bool bonus_; // 0x10
	private int count_; // 0x14

	// Properties
	public bool Bonus { get => default; set {} } // 0x008B86D0-0x008B86E0 0x008B86E0-0x008B86F0
	private int Count { get => default; set {} } // 0x008B8700-0x008B8710 0x008B8710-0x008B8720

	// Nested types
	[Serializable]
	public class SaveData // TypeDefIndex: 4604
	{
		// Fields
		[SerializeField] // 0x006184B0-0x006184C0
		private int count_; // 0x10
		[SerializeField] // 0x006184C0-0x006184D0
		private bool bonus_; // 0x14

		// Constructors
		public SaveData() {} // 0x008B8720-0x008B8730

		// Methods
		public void OnPreSave() {} // 0x008B8730-0x008B87C0
		public void OnAfterLoad() {} // 0x008B87C0-0x008B8850
		public void Reset() {} // 0x008B8850-0x008B8860
	}

	// Constructors
	public Bank_Bonus() {} // 0x008B8590-0x008B8600

	// Methods
	public Index GetRewardIndex() => default; // 0x008B8600-0x008B86D0
	public void ResetBonusFlag() {} // 0x008B86F0-0x008B8700
}

