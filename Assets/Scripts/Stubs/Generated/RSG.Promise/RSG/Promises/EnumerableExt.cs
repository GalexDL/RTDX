/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: RSG.Promise.dll - Assembly: RSG.Promise, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null - Types 4068-4089

namespace RSG.Promises
{
	public static class EnumerableExt // TypeDefIndex: 4069
	{
		// Methods
		public static IEnumerable<T> Empty<T>() => default;
	
		// Extension methods
		public static void Each<T>(this IEnumerable<T> source, Action<T> fn) {}
		public static void Each<T>(this IEnumerable<T> source, Action<T, int> fn) {}
	}
}
