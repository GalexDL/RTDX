/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NLuaTest.Mock
{
	public class TestClassGeneric<T> // TypeDefIndex: 8179
	{
		// Fields
		private object _PassedValue; // 0x00
		private bool _RegularMethodSuccess; // 0x00
		private bool _GenericMethodSuccess; // 0x00
	
		// Properties
		public bool RegularMethodSuccess { get => default; }
		public bool GenericMethodSuccess { get => default; }
	
		// Constructors
		public TestClassGeneric() {}
	
		// Methods
		public void GenericMethod(T value) {}
		public void RegularMethod() {}
		public bool Validate(T value) => default;
	}
}
