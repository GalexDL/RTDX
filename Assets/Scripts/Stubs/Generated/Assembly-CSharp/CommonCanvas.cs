/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A050-0x0060A060
public class CommonCanvas : SingletonMonoBehaviour<CommonCanvas> // TypeDefIndex: 5780
{
	// Fields
	private GameObject commonCanvas_; // 0x18
	private List<UiSortInfo_> sortedUiList_; // 0x20

	// Nested types
	public enum UIPriority // TypeDefIndex: 5781
	{
		DungeonAutoObject = 127,
		DungeonFukidashi = 128,
		PopupRoot = 160,
		DungeonTopScreen = 256,
		DungeonAutoMap = 256,
		DungeonWazaShortcut = 257,
		DotCharacter = 258,
		MostBack = 384,
		Back = 512,
		DungeonResult = 513,
		Default = 1024,
		MessageWindow = 1280,
		Front = 1536,
		RankupProduction = 1537,
		LinkMenu = 1538,
		Banner = 1539,
		DebugUI = 2560
	}

	private class UiSortInfo_ // TypeDefIndex: 5782
	{
		// Fields
		public UIPriority prio; // 0x10
		public GameObject gameObject; // 0x18

		// Constructors
		public UiSortInfo_() {} // 0x009C3620-0x009C3630
	}

	// Constructors
	public CommonCanvas() {} // 0x009C38F0-0x009C3990

	// Methods
	private void OnEnable() {} // 0x009C2F30-0x009C2FC0
	private void OnDisable() {} // 0x009C2FF0-0x009C3000
	private void SetupCommonCanvas_() {} // 0x009C2FC0-0x009C2FF0
	private void RefreshList_() {} // 0x009C3000-0x009C32A0
	private void CheckList_(GameObject obj) {} // 0x009C32A0-0x009C32B0
	public Transform FindTransform(string name) => default; // 0x009C32B0-0x009C32E0
	public void Attach(GameObject obj) {} // 0x009C32E0-0x009C32F0
	public void Attach(UIPriority prio, GameObject obj) {} // 0x009C32F0-0x009C3510
	public GameObject InstantiateAttach(UIPriority prio, GameObject original) => default; // 0x009C3630-0x009C3870
	public void Detach(GameObject obj) {} // 0x009C3510-0x009C3620
	public void SetGraphicRaycaster(bool bEnable) {} // 0x009C3880-0x009C38F0
}

