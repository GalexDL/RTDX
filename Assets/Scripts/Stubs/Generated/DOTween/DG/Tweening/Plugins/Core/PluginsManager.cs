﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Plugins.Options;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Plugins.Core
{
	internal static class PluginsManager // TypeDefIndex: 3611
	{
		// Fields
		private static ITweenPlugin _floatPlugin; // 0x00
		private static ITweenPlugin _doublePlugin; // 0x08
		private static ITweenPlugin _intPlugin; // 0x10
		private static ITweenPlugin _uintPlugin; // 0x18
		private static ITweenPlugin _longPlugin; // 0x20
		private static ITweenPlugin _ulongPlugin; // 0x28
		private static ITweenPlugin _vector2Plugin; // 0x30
		private static ITweenPlugin _vector3Plugin; // 0x38
		private static ITweenPlugin _vector4Plugin; // 0x40
		private static ITweenPlugin _quaternionPlugin; // 0x48
		private static ITweenPlugin _colorPlugin; // 0x50
		private static ITweenPlugin _rectPlugin; // 0x58
		private static ITweenPlugin _rectOffsetPlugin; // 0x60
		private static ITweenPlugin _stringPlugin; // 0x68
		private static ITweenPlugin _vector3ArrayPlugin; // 0x70
		private static ITweenPlugin _color2Plugin; // 0x78
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
	}
}
