/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public static class GameFlowData_TypeDatabase // TypeDefIndex: 4694
{
	// Fields
	private static Dictionary<Type, BlobTypeInfo> blobTypesTbl_; // 0x00

	// Nested types
	public class BlobTypeInfo // TypeDefIndex: 4695
	{
		// Fields
		public string uniqName; // 0x10
		public Type type; // 0x18

		// Constructors
		public BlobTypeInfo() {} // 0x00A633A0-0x00A633B0
	}

	// Constructors
	static GameFlowData_TypeDatabase() {} // 0x00A630A0-0x00A63120

	// Methods
	private static void RegistAuto_() {} // 0x00A63120-0x00A633A0
	public static GameFlowBlobBase CreateBlobByName(string uniqName) => default; // 0x00A633B0-0x00A63580
	public static BlobTypeInfo GetBlobTypeInfo(Type t) => default; // 0x00A63580-0x00A63620
	public static List<BlobTypeInfo> EnumBlobTypeInfo() => default; // 0x00A63620-0x00A637B0
}

