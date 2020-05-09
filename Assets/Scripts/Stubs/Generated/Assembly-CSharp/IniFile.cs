/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class IniFile // TypeDefIndex: 5801
{
	// Fields
	private SectionList m_aData; // 0x10
	private List<string> m_aSectionList; // 0x18

	// Properties
	public virtual string[] this[string sectionSymbol, string variableSymbol] { get => default; } // 0x008F3230-0x008F32B0 
	public virtual DefinitionList this[string sectionSymbol] { get => default; } // 0x008F32C0-0x008F3360 
	public SectionList Sections { get => default; } // 0x008F32B0-0x008F32C0 

	// Nested types
	public class DefinitionList : NameValueCollection // TypeDefIndex: 5802
	{
		// Constructors
		public DefinitionList() {} // 0x008F3360-0x008F3370
	}

	public class SectionList : Dictionary<string, DefinitionList> // TypeDefIndex: 5803
	{
		// Constructors
		public SectionList() {} // 0x008F3900-0x008F3950
	}

	// Constructors
	public IniFile() {} // 0x008F3830-0x008F3900

	// Methods
	public bool LoadFromFile(string stInputFileName) => default; // 0x008F2A30-0x008F2AA0
	public void LoadFromResource(string stResourceName) {} // 0x008F2F00-0x008F3030
	public void Load(string[] aString) {} // 0x008F2AA0-0x008F2F00
	public void AddSection(string stSection) {} // 0x008F3030-0x008F30D0
	public void AddValue(string stSection, string stVariable, string stValue) {} // 0x008F30D0-0x008F3230
	public string GetString(string stSection, string stVariable, string stDefault = null) => default; // 0x008F3370-0x008F3410
	public bool GetBool(string stSection, string stVariable, bool bDefault = false /* Metadata: 0x00611F5C */) => default; // 0x008F3410-0x008F34F0
	public int GetInt(string stSection, string stVariable, int nDefault = 0 /* Metadata: 0x00611F5D */) => default; // 0x008F34F0-0x008F35A0
	public T GetEnum<T>(string stSection, string stVariable, T tDefault = default) => default;
	public void Save(string stFileName) {} // 0x008F35A0-0x008F3830
}

