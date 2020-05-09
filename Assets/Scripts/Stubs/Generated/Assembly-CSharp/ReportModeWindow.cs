/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ReportModeWindow : UIWindowBase // TypeDefIndex: 6357
{
	// Fields
	private UIState uiState_; // 0x30
	private UIPelipper manager_; // 0x38
	private Mail mail_; // 0x40

	// Nested types
	private enum UIState // TypeDefIndex: 6358
	{
		In_Mail = 0,
		Message = 1,
		Done = 2
	}

	private class Mail // TypeDefIndex: 6359
	{
		// Fields
		private string[] actionName_; // 0x10
		private Anim<ViewState> anim; // 0x18

		// Nested types
		public enum ViewState // TypeDefIndex: 6360
		{
			NONE = 0,
			MAILOPEN = 1,
			MAILCLOSE = 2,
			MAILIN = 3
		}

		// Constructors
		public Mail() {} // Dummy constructor
		public Mail(GameObject obj) {} // 0x00A04350-0x00A04590

		// Methods
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x00A04680-0x00A04780
	}

	// Constructors
	public ReportModeWindow() {} // 0x00A04780-0x00A04790

	// Methods
	private static void PlaySe_Letter_Success() {} // 0x00A03D50-0x00A03DD0
	public virtual void Init(GameObject objRoot, UIPelipper manager) {} // 0x00A03DD0-0x00A04350
	public new void Update() {} // 0x00A04590-0x00A04680
}

