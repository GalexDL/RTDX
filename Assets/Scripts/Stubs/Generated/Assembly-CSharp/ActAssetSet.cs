/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActAssetSet // TypeDefIndex: 4369
{
	// Fields
	[NonSerialized]
	public List<ActAsset_Base> assetList; // 0x10
	[NonSerialized]
	public MiscInfo miscInfo; // 0x18
	private static Regex match_Asset; // 0x00
	private static Regex match_Misc; // 0x08
	private static Regex match_Empty; // 0x10

	// Nested types
	[Serializable]
	public class MiscInfo // TypeDefIndex: 4370
	{
		// Fields
		public string groundMapId; // 0x10
		public string comment; // 0x18
		public bool isAssetAddLoadAndContinue; // 0x20
		public bool isAssetAddOnlyLoad; // 0x21
		public List<string> appendAssetSetSymbols; // 0x28

		// Constructors
		public MiscInfo() {} // 0x008D5460-0x008D54E0
	}

	// Constructors
	public ActAssetSet() {} // 0x008D3F80-0x008D4080
	static ActAssetSet() {} // 0x008D5D60-0x008D5E40

	// Methods
	public ActAsset_Base FindAsset(string symbolName) => default; // 0x008D5390-0x008D5450
	public T FindAsset<T>(string symbolName)
		where T : ActAsset_Base => default;
	public bool Deserialize(string serializeString_, out string errorMsg) {
		errorMsg = default;
		return default;
	} // 0x008D3A00-0x008D3C20
	public string Serialize() => default; // 0x008D3950-0x008D3960
	public bool Deserialize_HumanText(string deserializeString_, out string errorMsg) {
		errorMsg = default;
		return default;
	} // 0x008D54E0-0x008D5AB0
	public string Serialize_HumanText() => default; // 0x008D5AB0-0x008D5D60
}

