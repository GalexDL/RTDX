/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FukidashiConst;
using kamina;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Fukidashi : Frame // TypeDefIndex: 5984
{
	// Fields
	private GameObject m_root; // 0x20
	private Transform m_parentPosition; // 0x28
	private Transform m_parentRotation; // 0x30
	private FukidashiCtrl2d m_ctrl; // 0x38
	private Vector3 m_vOffset; // 0x40
	private bool m_bAttach; // 0x4C
	private bool m_bPositionUpdate; // 0x4D
	private bool m_bFirstPositionUpdate; // 0x4E

	// Constructors
	private Fukidashi() {} // 0x00BA81F0-0x00BA8370

	// Methods
	public static Fukidashi CreateDirect() => default; // 0x00BA8190-0x00BA81F0
	protected override void OnTerminate() {} // 0x00BA83C0-0x00BA84F0
	public void Attach(Transform parentPosition, Transform parentRotation, string name) {} // 0x00BA8520-0x00BA85B0
	public void Detach() {} // 0x00BA85B0-0x00BA85C0
	private void AttachFukidashiRoot(Transform t) {} // 0x00BA8370-0x00BA83C0
	private void DetachFukidashiRoot(Transform t) {} // 0x00BA84F0-0x00BA8520
	public void Appear(FukidashiConst.Type type, ref string text, Vector3 appearPosition, float fOverwriteVisibleTimer) {} // 0x00BA85C0-0x00BA8730
	public void Clear(FukidashiConst.Type type) {} // 0x00BA8830-0x00BA8940
	public void SetVisibleMesh(bool bEnable) {} // 0x00BA8940-0x00BA8970
	public override void Update() {} // 0x00BA89A0-0x00BA89B0
	public override void LastUpdate() {} // 0x00BA89B0-0x00BA8C80
}

