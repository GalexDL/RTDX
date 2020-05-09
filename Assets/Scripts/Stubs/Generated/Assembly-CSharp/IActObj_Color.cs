/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IActObj_Color // TypeDefIndex: 4411
{
	// Properties
	bool IsMoveColor { get; }

	// Methods
	void ApplyColorToMaterial(Color toMulColor, Color toAddColor, Color toOverlayColor);
	void SetMulColor(Color color);
	void SetAddColor(Color color);
	void SetOverlayColor(Color color);
	void MoveColorToByTime(Color toMulColor, Color toAddColor, Color toOverlayColor, float timeSec);
}

