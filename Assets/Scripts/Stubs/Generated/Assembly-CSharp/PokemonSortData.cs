/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonSortData // TypeDefIndex: 6322
{
	// Fields
	private BeingAllNameTypes[] beingNames_JP; // 0x10
	private BeingAllNameTypes[] beingNames_Overseas; // 0x18
	private BeingAllNameTypes[] beingkinds_JP; // 0x20
	private BeingAllNameTypes[] beingkinds_Overseas; // 0x28
	private Regex[] kindPattarns_JP; // 0x30
	private Regex[] kindPattarns_Overseas; // 0x38
	private Regex[] namePattarns_JP; // 0x40
	private Regex[] namePattarns_Overseas; // 0x48
	private SubMenuSelectItem[] refineFirstSelectItemArray_; // 0x50
	private SubMenuSelectItem[] kindNameSelectArray_JP; // 0x58
	private SubMenuSelectItem[] kindNameSelectArray_Overseas; // 0x60
	private SubMenuSelectItem[] nickNameSelectArray_JP; // 0x68
	private SubMenuSelectItem[] nickNameSelectArray_Overseas; // 0x70
	private SubMenuSelectItem[] sortSelectArray; // 0x78

	// Properties
	public Regex[] kindPattarns { get => default; } // 0x00C44540-0x00C445D0 
	public Regex[] namePattarns { get => default; } // 0x00C44020-0x00C440B0 
	public SubMenuSelectItem[] refineFirstSelectItemArray { get => default; } // 0x00C46D60-0x00C46D70 
	public SubMenuSelectItem[] kindNameSelectArray { get => default; } // 0x00C43260-0x00C432F0 
	public SubMenuSelectItem[] nickNameSelectArray { get => default; } // 0x00C431D0-0x00C43260 
	public SubMenuSelectItem[] SortSelectArray { get => default; } // 0x00C46E50-0x00C46E60 

	// Nested types
	public enum BeingAllNameTypes // TypeDefIndex: 6323
	{
		a = 0,
		k = 1,
		s = 2,
		t = 3,
		n = 4,
		h = 5,
		m = 6,
		y = 7,
		r = 8,
		w = 9,
		ABCDEFG = 10,
		HIJKLMN = 11,
		OPQRSTU = 12,
		VWXYZ = 13,
		NUMBER = 14,
		Other = 15,
		MAX = 16
	}

	public class SubMenuSelectItem // TypeDefIndex: 6324
	{
		// Fields
		public CommonSortRefineWindow.ListItem.Label label; // 0x10

		// Constructors
		public SubMenuSelectItem() {} // 0x00C4BB30-0x00C4BB40
	}

	public enum PageState // TypeDefIndex: 6325
	{
		TOP = 0,
		REFINE_FIRST_SELECT = 1,
		REFINE_SECOND_NAMES_SELECT = 2,
		REFINE_SECOND_TYPES_SELECT = 3,
		SORT_ITEM_SELECT = 4,
		END = 5
	}

	// Constructors
	public PokemonSortData() {} // 0x00C47060-0x00C49610

	// Methods
	public int GetNameTypesMax(bool kind) => default; // 0x00C43F70-0x00C44020
	public BeingAllNameTypes GetBeingAllNameTypes(int select, bool kind) => default; // 0x00C46D70-0x00C46E50
	public int GetBeingAllNameTypes_Reverse(BeingAllNameTypes type, bool kind) => default; // 0x00C432F0-0x00C433F0
	public BeingAllNameTypes[] GetBeingAllNameTypesArray(bool kind) => default; // 0x00C4BA80-0x00C4BB30
}

