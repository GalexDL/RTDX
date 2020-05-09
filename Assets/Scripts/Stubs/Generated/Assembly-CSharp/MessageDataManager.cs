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
public class MessageDataManager : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 5483
{
	// Fields
	public bool m_bChange; // 0x18
	[NonSerialized]
	public List<FileData> m_fileDataList; // 0x20
	[SerializeField] // 0x00616750-0x00616760
	public List<FileData> m_oldDataList; // 0x28
	private bool m_change; // 0x30

	// Nested types
	[Serializable]
	public class FileData // TypeDefIndex: 5484
	{
		// Fields
		[SerializeField] // 0x00618560-0x00618570
		public string[] m_dataArray; // 0x10
		[NonSerialized]
		public int m_ID; // 0x18
		[NonSerialized]
		public bool m_used; // 0x1C

		// Nested types
		public enum DATA_TYPE // TypeDefIndex: 5485
		{
			LABEL = 0,
			MESSAGE = 1,
			SIZE = 2,
			TYPE = 3,
			COMMENT = 4,
			REFLABEL = 5,
			REFSERIES = 6,
			MAX = 7
		}

		// Constructors
		public FileData() {} // 0x00896F40-0x00896FA0
	}

	// Constructors
	public MessageDataManager() {} // 0x00896EB0-0x00896F40

	// Methods
	public void OnBeforeSerialize() {} // 0x00896E80-0x00896E90
	public void OnAfterDeserialize() {} // 0x00896E90-0x00896EB0
}

