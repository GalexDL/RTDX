/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NLuaTest.Mock
{
	public interface ITest // TypeDefIndex: 8172
	{
		// Properties
		int intProp { get; set; }
		TestClass refProp { get; set; }
	
		// Methods
		int test1(int a, int b);
		int test2(int a, out int b);
		void test3(int a, ref int b);
		TestClass test4(int a, int b);
		int test5(TestClass a, TestClass b);
		int test6(int a, out TestClass b);
		void test7(int a, ref TestClass b);
	}
}
