/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina.graphics
{
	public interface IAnimationCallback // TypeDefIndex: 8394
	{
		// Methods
		void PlayParts_Pre(string parts, string key, float fStartBlendSec, float fSpeed, bool bLoop);
		void PlayPartsEnd_Pre(string parts, string key);
		void ChangeCurrentSpeed(string parts, string key, float fSpeed);
		void ChangeCurrentLoop(string parts, string key, bool bLoop);
		void UpdateParts_Pre(string parts, string key);
	}
}
