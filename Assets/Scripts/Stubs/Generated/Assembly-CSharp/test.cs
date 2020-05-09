/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class test : MonoBehaviour // TypeDefIndex: 8125
{
	// Fields
	private LuaSvr l; // 0x18

	// Nested types
	public class LuaTests // TypeDefIndex: 8126
	{
		// Fields
		public LuaState lua; // 0x10

		// Constructors
		public LuaTests() {} // 0x00AF3330-0x00AF3340

		// Methods
		public void ThrowException() {} // 0x00AF3340-0x00AF3410
		public void CallLuaFunction() {} // 0x00AF3410-0x00AF3520
		public void TestStructs() {} // 0x00AF3520-0x00AF3660
		public void TestStructHashesEqual() {} // 0x00AF3660-0x00AF3780
		public void TestEnumEqual() {} // 0x00AF3780-0x00AF38F0
		public void TestMethodOverloads() {} // 0x00AF38F0-0x00AF3C30
		public void TestDispose() {} // 0x00AF3C30-0x00AF3FB0
		private void _Calc(LuaState lua, int i) {} // 0x00AF3FB0-0x00AF40A0
		private float _TestException(float val, float val2) => default; // 0x00AF40A0-0x00AF40B0
		public void TestExceptionWithChunkOverload() {} // 0x00AF40B0-0x00AF4210
		public void TestMultipleOutParameters() {} // 0x00AF4210-0x00AF4350
		public void DoString() {} // 0x00AF4350-0x00AF44F0
		public void GetGlobalNumber() {} // 0x00AF44F0-0x00AF45B0
		public void SetGlobalNumber() {} // 0x00AF45B0-0x00AF46A0
		public void GetNumberInTable() {} // 0x00AF46A0-0x00AF4760
		public void SetNumberInTable() {} // 0x00AF4760-0x00AF4850
		public void GetGlobalString() {} // 0x00AF4850-0x00AF48E0
		public void SetGlobalString() {} // 0x00AF48E0-0x00AF4990
		public void GetStringInTable() {} // 0x00AF4990-0x00AF4A20
		public void SetStringInTable() {} // 0x00AF4A20-0x00AF4AD0
		public void GetAndSetTable() {} // 0x00AF4AD0-0x00AF4BC0
		public void GetTableNumericField1() {} // 0x00AF4BC0-0x00AF4CB0
		public void GetTableNumericField2() {} // 0x00AF4CB0-0x00AF4DA0
		public void SetTableNumericField1() {} // 0x00AF4DA0-0x00AF4EB0
		public void SetTableNumericField2() {} // 0x00AF4EB0-0x00AF4FB0
		public void GetTableStringField1() {} // 0x00AF4FB0-0x00AF50E0
		public void GetTableStringField2() {} // 0x00AF50E0-0x00AF5210
		public void SetTableStringField1() {} // 0x00AF5210-0x00AF52D0
		public void SetTableStringField2() {} // 0x00AF52D0-0x00AF5390
		public void CallGlobalFunctionNoArgs() {} // 0x00AF5390-0x00AF5470
		public void CallGlobalFunctionOneArg() {} // 0x00AF5470-0x00AF5570
		public void CallGlobalFunctionTwoArgs() {} // 0x00AF5570-0x00AF5690
		public void CallGlobalFunctionOneReturn() {} // 0x00AF5690-0x00AF5770
		public void CallGlobalFunctionTwoReturns() {} // 0x00AF5770-0x00AF59F0
		public void CallTableFunctionTwoReturns() {} // 0x00AF59F0-0x00AF5C70
		public void SetGlobalObject() {} // 0x00AF5C70-0x00AF5EC0
		public void GarbageCollection() {} // 0x00AF5EC0-0x00AF60E0
		public void SetTableObjectField1() {} // 0x00AF60E0-0x00AF62D0
		public void AccessObjectField() {} // 0x00AF62D0-0x00AF6450
		public void AccessObjectProperty() {} // 0x00AF6450-0x00AF65E0
		public void AccessObjectStringProperty() {} // 0x00AF65E0-0x00AF6790
		public void CallObjectMethod() {} // 0x00AF6790-0x00AF6900
		public void CallObjectMethodByType() {} // 0x00AF6900-0x00AF69C0
		public void CallObjectMethodOutParam() {} // 0x00AF69C0-0x00AF6B00
		public void CallObjectMethodOverloadedOutParam() {} // 0x00AF6B00-0x00AF6C40
		public void CallObjectMethodByRefParam() {} // 0x00AF6C40-0x00AF6D80
		public void CreateNetObjectNoArgsCons() {} // 0x00AF6D80-0x00AF6F10
		public void CreateNetObjectOneArgCons() {} // 0x00AF6F10-0x00AF7090
		public void CreateNetObjectOverloadedCons() {} // 0x00AF7090-0x00AF71D0
		public void ReadArrayField() {} // 0x00AF71D0-0x00AF73D0
		public void WriteArrayField() {} // 0x00AF73D0-0x00AF75D0
		public void LuaDelegateValueTypes() {} // 0x00AF75D0-0x00AF76D0
		public void LuaDelegateValueTypesOutParam() {} // 0x00AF76D0-0x00AF77D0
		public void LuaDelegateValueTypesByRefParam() {} // 0x00AF77D0-0x00AF78D0
		public void LuaDelegateValueTypesReturnReferenceType() {} // 0x00AF78D0-0x00AF79D0
		public void LuaDelegateReferenceTypes() {} // 0x00AF79D0-0x00AF7AC0
		public void LuaDelegateReferenceTypesOutParam() {} // 0x00AF7AC0-0x00AF7BC0
		public void LuaDelegateReferenceTypesByRefParam() {} // 0x00AF7BC0-0x00AF7CB0
		public void TestVarargs() {} // 0x00AF7CB0-0x00AF7D40
		public void TestPrintChars() {} // 0x00AF7D40-0x00AF7DA0
		public void TestUnicodeChars() {} // 0x00AF7DA0-0x00AF7F00
		public void TestCaseFields() {} // 0x00AF7F00-0x00AF8020
		public void TestStaticOperators() {} // 0x00AF8020-0x00AF81E0
		public void TestOverloadedMethods() {} // 0x00AF81E0-0x00AF8330
		public void TestOverloadedMethodCallOnBase() {} // 0x00AF8330-0x00AF8470
		public void TestCallMethodWithParams2() {} // 0x00AF8470-0x00AF8520
		public void TestPassType() {} // 0x00AF8520-0x00AF86D0
	}

	// Constructors
	public test() {} // 0x00AF2C70-0x00AF2C80

	// Methods
	private void Start() {} // 0x00AF2BC0-0x00AF2C70
}

