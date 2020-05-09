/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Singleton<T> : ISingleton // TypeDefIndex: 5849
	where T : class, new()
{
	// Fields
	protected static T instance_; // 0x00

	// Properties
	public static T Instance { get => default; }
	public static bool IsValid { get => default; }

	// Constructors
	public Singleton() {}
	static Singleton() {}

	// Methods
	public static void CreateInstance() {}
	public static void DeleteInstance() {}
	public void SelfDeleteInstance() {}
	protected virtual void Startup() {}
	protected virtual void Shutdown() {}
}

