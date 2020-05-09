/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class LanguageSelectDialog : MonoBehaviour // TypeDefIndex: 6092
{
	// Fields
	public Animator m_animator; // 0x18
	public GameObject m_jp; // 0x20
	public GameObject m_en; // 0x28
	public GameObject m_fr; // 0x30
	public GameObject m_ge; // 0x38
	public GameObject m_it; // 0x40
	public GameObject m_sp; // 0x48
	private List<GameObject> listButton; // 0x50
	private bool m_bClose; // 0x58
	private int m_selectNo; // 0x5C
	private int m_prevNo; // 0x60

	// Constructors
	public LanguageSelectDialog() {} // 0x00902D70-0x00902DF0

	// Methods
	private void Awake() {} // 0x009025A0-0x00902640
	public void PlayOpen() {} // 0x00902640-0x009026A0
	public void PlayClose() {} // 0x009026A0-0x00902700
	// [IteratorStateMachine] // 0x00624200-0x00624270
	public IEnumerator Select() => default; // 0x00902220-0x00902290
	// [IteratorStateMachine] // 0x00624270-0x006242E0
	public IEnumerator WaitAnimation() => default; // 0x00902730-0x009027A0
	public bool IsClosed() => default; // 0x009027D0-0x00902880
	private void Close() {} // 0x00902880-0x009028F0
	public void OnButtonRelease_JP() {} // 0x009028F0-0x009029B0
	public void OnButtonRelease_EN() {} // 0x009029B0-0x00902A70
	public void OnButtonRelease_FR() {} // 0x00902A70-0x00902B30
	public void OnButtonRelease_GE() {} // 0x00902B30-0x00902BF0
	public void OnButtonRelease_IT() {} // 0x00902BF0-0x00902CB0
	public void OnButtonRelease_SP() {} // 0x00902CB0-0x00902D70
}

