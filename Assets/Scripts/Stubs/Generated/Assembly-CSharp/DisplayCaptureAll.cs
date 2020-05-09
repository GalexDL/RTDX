/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DisplayCaptureAll : MonoBehaviour // TypeDefIndex: 5976
{
	// Fields
	private Texture2D m_frameBufferCapture; // 0x18
	private int m_nRequestFrameBufferCaptureGUIDepth; // 0x20
	private bool m_bRequestFrameBufferCapture; // 0x24

	// Properties
	public Texture2D CaptureTexture { get => default; } // 0x00996220-0x00996230 

	// Constructors
	public DisplayCaptureAll() {} // 0x00996590-0x009965A0

	// Methods
	private void Start() {} // 0x00996230-0x00996240
	private void OnDestroy() {} // 0x009963E0-0x009964A0
	public void Request(int guiDepth) {} // 0x009964A0-0x009964B0
	public void RefleshCaptureTexture(bool bForce) {} // 0x00996240-0x009963E0
	private void OnGUI() {} // 0x009964B0-0x00996590
}

