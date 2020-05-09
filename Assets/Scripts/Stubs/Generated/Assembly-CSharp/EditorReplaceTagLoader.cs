/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class EditorReplaceTagLoader // TypeDefIndex: 5245
{
	// Fields
	private static EditorReplaceTagLoader m_instance; // 0x00
	[NonSerialized]
	private List<ReplaceTagData> m_replaceTagDataList; // 0x10

	// Properties
	public static EditorReplaceTagLoader Instance { get => default; } // 0x00BC4CA0-0x00BC4CF0 
	public List<ReplaceTagData> ReplaceTagDataList { get => default; } // 0x00BC4D40-0x00BC4D50 

	// Nested types
	[Serializable]
	public class ReplaceTagData // TypeDefIndex: 5246
	{
		// Fields
		[SerializeField] // 0x00618540-0x00618550
		public string[] m_dataArray; // 0x10

		// Nested types
		public enum DATA_TYPE // TypeDefIndex: 5247
		{
			ATTRIBUTE = 0,
			ITEM = 1,
			USED = 2,
			TAG_TYPE = 3,
			BUF_NUM = 4,
			TAG = 5,
			COMMENT = 6,
			MAX = 7
		}

		// Constructors
		public ReplaceTagData() {} // 0x00BC4D60-0x00BC4DC0
	}

	// Constructors
	private EditorReplaceTagLoader() {} // 0x00BC4C10-0x00BC4C20

	// Methods
	public static void Create() {} // 0x00BC4C20-0x00BC4CA0
	public void Uninit() {} // 0x00BC4CF0-0x00BC4D40
	public void Load() {} // 0x00BC4D50-0x00BC4D60
}

