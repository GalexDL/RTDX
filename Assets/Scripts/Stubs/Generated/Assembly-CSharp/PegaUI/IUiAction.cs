/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace PegaUI
{
	public interface IUiAction : IEventSystemHandler // TypeDefIndex: 8342
	{
		// Properties
		string TargetActionName { get; }
	
		// Methods
		void On_UiActionCall(UnityAction endCallback);
	}
}
