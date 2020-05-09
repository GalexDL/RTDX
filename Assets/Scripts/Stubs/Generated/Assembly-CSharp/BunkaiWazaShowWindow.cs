/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class BunkaiWazaShowWindow : RenketsuWazaListWindow // TypeDefIndex: 8004
{
	// Fields
	private static int[,] aRenketsuSelectorTokenId; // 0x00
	private static int[,] aRenketsuItemTokenId; // 0x08

	// Constructors
	public BunkaiWazaShowWindow() {} // 0x008C2400-0x008C2470
	static BunkaiWazaShowWindow() {} // 0x008C2470-0x008C2550

	// Methods
	protected override int _getRenketsuSelectorTokenId(int row) => default; // 0x008C1B90-0x008C1C70
	protected override int _getRenketsuItemTokenId(int row) => default; // 0x008C1C70-0x008C1D50
	public void ShowList(GameObject objRoot, IPokemonStatus pokemonStatus, List<int> renketsuList) {} // 0x008C1D50-0x008C2400
}

