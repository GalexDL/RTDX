/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class LoadMessageLabel // TypeDefIndex: 5426
{
	// Fields
	[SerializeField] // 0x00616570-0x00616580
	public List<FileData> m_fileDataList; // 0x10

	// Nested types
	[Serializable]
	public class FileData // TypeDefIndex: 5427
	{
		// Fields
		[SerializeField] // 0x00618550-0x00618560
		public string[] m_dataArray; // 0x10

		// Nested types
		public enum DATA_TYPE // TypeDefIndex: 5428
		{
			LABEL = 0,
			MESSAGE = 1,
			SIZE = 2,
			TYPE = 3,
			COMMENT = 4,
			MAX = 5
		}

		// Constructors
		public FileData() {} // 0x00BF9700-0x00BF9760
	}

	// Constructors
	public LoadMessageLabel() {} // 0x00BF9690-0x00BF9700

	// Methods
	public void LoadJson(string path) {} // 0x00BF94B0-0x00BF9550
	public string GetMessage(string label) => default; // 0x00BF9550-0x00BF9680
	public void Load(string path) {} // 0x00BF9680-0x00BF9690
}

