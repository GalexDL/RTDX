/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SpicaUI
{
	// [RequireComponent] // 0x0060AFF0-0x0060B060
	public class UiToggleGraphic : MonoBehaviour // TypeDefIndex: 8359
	{
		// Fields
		public Graphic onGraphic; // 0x18
		public Graphic offGraphic; // 0x20
		public float tweenTime; // 0x28
	
		// Constructors
		public UiToggleGraphic() {} // 0x0090E4B0-0x0090E4D0
	
		// Methods
		private void Start() {} // 0x0090DB90-0x0090DEB0
		private void OnValueChanged(bool value) {} // 0x0090E130-0x0090E2D0
		private static void setAlpha_(Graphic graphic, float alpha) {} // 0x0090E2D0-0x0090E3C0
		private static float getAlpha_(Graphic graphic) => default; // 0x0090E3C0-0x0090E490
		private void SetOn_(Graphic graphic, bool bForInit) {} // 0x0090DEB0-0x0090DFF0
		private void SetOff_(Graphic graphic, bool bForInit) {} // 0x0090DFF0-0x0090E130
	}
}
