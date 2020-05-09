/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace RSG
{
	public class PromiseFactory // TypeDefIndex: 8420
	{
		// Constructors
		public PromiseFactory() {} // 0x009F9B50-0x009F9B60
	
		// Methods
		public static IPromise<T> StartNewDeferred<T>(Action<Promise<T>> func) => default;
		public static IPromise<T> StartNew<T>(Func<T> val) => default;
		public static IPromise<T> Resolved<T>(T val) => default;
		public static IPromise<object> StartDelay(float sec) => default; // 0x009F9A70-0x009F9AE0
		public static IPromise<object> StartDelayFrame() => default; // 0x009F9AE0-0x009F9B50
	}
}
