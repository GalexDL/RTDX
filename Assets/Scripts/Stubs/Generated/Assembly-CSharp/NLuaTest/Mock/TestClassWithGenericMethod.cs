/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NLuaTest.Mock
{
	public class TestClassWithGenericMethod // TypeDefIndex: 8180
	{
		// Fields
		private object _PassedValue; // 0x10
		private bool _GenericMethodSuccess; // 0x18
	
		// Properties
		public object PassedValue { get => default; } // 0x00E3CB80-0x00E3CB90 
		public bool GenericMethodSuccess { get => default; } // 0x00E3CB90-0x00E3CBA0 
	
		// Constructors
		public TestClassWithGenericMethod() {} // 0x00E3CBA0-0x00E3CBB0
	
		// Methods
		public void GenericMethod<T>(T value) {}
		internal bool Validate<T>(T value) => default;
	}
}
