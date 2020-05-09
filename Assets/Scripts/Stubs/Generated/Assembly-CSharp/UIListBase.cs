/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class UIListBase : MonoBehaviour // TypeDefIndex: 7047
{
	// Fields
	public GameObject UIItemSrc; // 0x18
	private List<GameObject> UIItemTable_; // 0x20
	private int nCount_; // 0x28

	// Constructors
	protected UIListBase() {} // 0x00944850-0x00944860

	// Methods
	private void Awake() {} // 0x00943FF0-0x00944080
	private void OnEnable() {} // 0x00944080-0x00944090
	private void OnDisable() {} // 0x00944090-0x00944210
	protected virtual void DoEnable() {} // 0x00944210-0x00944220
	protected virtual void DoDisable() {} // 0x00944220-0x00944230
	protected virtual void DoAddMenu(GameObject container) {} // 0x00944230-0x00944240
	public void ResetMenu(bool bDestory = false /* Metadata: 0x00613285 */) {} // 0x00944240-0x009444F0
	public GameObject AddMenu(bool bVisible = true /* Metadata: 0x00613286 */) => default; // 0x009444F0-0x00944740
	public int GetMenuCount() => default; // 0x00944740-0x00944750
	public int GetMenuObjectCount() => default; // 0x00944750-0x009447A0
	public GameObject GetMenuGameObject(int index) => default; // 0x009447A0-0x00944840
	public int GetColumnCount() => default; // 0x00944840-0x00944850
	protected abstract int _getColumnCount();
}

