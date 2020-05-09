/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using SLua;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NLuaTest.Mock
{
	public class TestClass : IFoo1, IFoo2 // TypeDefIndex: 8182
	{
		// Fields
		public int val; // 0x10
		private string strVal; // 0x18
		private TestStruct s; // 0x20
	
		// Properties
		public TestStruct Struct { get => default; set {} } // 0x00E38E00-0x00E38E10 0x00E38E10-0x00E38E20
		public int testval { get => default; set {} } // 0x00E38E20-0x00E38E30 0x00E38E30-0x00E38E40
		public string teststrval { get => default; set {} } // 0x00E38E40-0x00E38E50 0x00E38E50-0x00E38E60
		public int this[int index] { get => default; set {} } // 0x00E38E60-0x00E38E70 0x00E38E70-0x00E38E80
		public int this[string index] { get => default; set {} } // 0x00E38E80-0x00E38E90 0x00E38E90-0x00E38EA0
	
		// Constructors
		public TestClass() {} // 0x00E38D00-0x00E38D30
		public TestClass(int val) {} // 0x00E38D30-0x00E38D60
		public TestClass(string val) {} // 0x00E38D60-0x00E38D90
	
		// Methods
		public static TestClass makeFromString(string str) => default; // 0x00E38D90-0x00E38E00
		public object TestLuaFunction(LuaFunction func) => default; // 0x00E38EA0-0x00E38F50
		public int sum(int x, int y) => default; // 0x00E38F50-0x00E38F60
		public void setVal(int newVal) {} // 0x00E38F60-0x00E38F70
		public void setVal(string newVal) {} // 0x00E38F70-0x00E38F80
		public int getVal() => default; // 0x00E38F80-0x00E38F90
		public string getStrVal() => default; // 0x00E38F90-0x00E38FA0
		public int outVal(out int val) {
			val = default;
			return default;
		} // 0x00E38FA0-0x00E38FB0
		public int outVal(out int val, int val2) {
			val = default;
			return default;
		} // 0x00E38FB0-0x00E38FC0
		public int outVal(int val, ref int val2) => default; // 0x00E38FC0-0x00E38FE0
		public int outValMutiple(int arg, out string arg2, out string arg3) {
			arg2 = default;
			arg3 = default;
			return default;
		} // 0x00E38FE0-0x00E390A0
		public int callDelegate1(TestDelegate1 del) => default; // 0x00E390A0-0x00E390B0
		public int callDelegate2(TestDelegate2 del) => default; // 0x00E39480-0x00E394C0
		public int callDelegate3(TestDelegate3 del) => default; // 0x00E39890-0x00E398D0
		public int callDelegate4(TestDelegate4 del) => default; // 0x00E39CC0-0x00E39CF0
		public int callDelegate5(TestDelegate5 del) => default; // 0x00E3A0C0-0x00E3A160
		public int callDelegate6(TestDelegate6 del) => default; // 0x00E3A740-0x00E3A7D0
		public int callDelegate7(TestDelegate7 del) => default; // 0x00E3ABA0-0x00E3AC30
		public int callInterface1(ITest itest) => default; // 0x00E3B020-0x00E3B080
		public int callInterface2(ITest itest) => default; // 0x00E3B080-0x00E3B270
		public int callInterface3(ITest itest) => default; // 0x00E3B270-0x00E3B460
		public int callInterface4(ITest itest) => default; // 0x00E3B460-0x00E3B640
		public int callInterface5(ITest itest) => default; // 0x00E3B640-0x00E3B860
		public int callInterface6(ITest itest) => default; // 0x00E3B860-0x00E3BA70
		public int callInterface7(ITest itest) => default; // 0x00E3BA70-0x00E3BC80
		public int callInterface8(ITest itest) => default; // 0x00E3BC80-0x00E3BCF0
		public int callInterface9(ITest itest) => default; // 0x00E3BCF0-0x00E3C040
		public void exceptionMethod() {} // 0x00E3C040-0x00E3C0C0
		public virtual int overridableMethod(int x, int y) => default; // 0x00E3C0C0-0x00E3C0D0
		public static int callOverridable(TestClass test, int x, int y) => default; // 0x00E3C0D0-0x00E3C0E0
		int IFoo1.foo() => default; // 0x00E3C0E0-0x00E3C0F0
		public int foo() => default; // 0x00E3C0F0-0x00E3C100
		private void _PrivateMethod() {} // 0x00E3C100-0x00E3C170
		public int MethodOverload() => default; // 0x00E3C170-0x00E3C1F0
		public int MethodOverload(TestClass testClass) => default; // 0x00E3C1F0-0x00E3C270
		public int MethodOverload(Type type) => default; // 0x00E3C270-0x00E3C2F0
		public int MethodOverload(int i, int j, int k) => default; // 0x00E3C2F0-0x00E3C620
		public int MethodOverload(int i, int j, out int k) {
			k = default;
			return default;
		} // 0x00E3C620-0x00E3C880
		public void Print(object format, params /* 0x0065AC90-0x0065ACA0 */ object[] args) {} // 0x00E3C880-0x00E3C990
		public static int MethodWithParams(int a, params /* 0x0065ACA0-0x0065ACB0 */ int[] others) => default; // 0x00E3C990-0x00E3CAC0
		public bool TestType(Type t) => default; // 0x00E3CAC0-0x00E3CB50
	}
}
