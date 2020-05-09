/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class RenketsuWazaShowWindow : RenketsuWazaListWindow // TypeDefIndex: 8003
{
	// Fields
	private static int[,] aRenketsuSelectorTokenId; // 0x00
	private static int[,] aRenketsuItemTokenId; // 0x08

	// Constructors
	public RenketsuWazaShowWindow() {} // 0x00A01D40-0x00A01DB0
	static RenketsuWazaShowWindow() {} // 0x00A01DB0-0x00A01E90

	// Methods
	protected override int _getRenketsuSelectorTokenId(int row) => default; // 0x00A01380-0x00A01460
	protected override int _getRenketsuItemTokenId(int row) => default; // 0x00A01460-0x00A01540
	public void ShowList(GameObject objRoot, IPokemonStatus pokemonStatus, List<int> renketsuList) {} // 0x00A01540-0x00A01B80
	protected override void _setupItemFaceIcon(int itemCount) {} // 0x00A01B80-0x00A01D40
}

