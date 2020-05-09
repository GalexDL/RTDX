/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace RSG
{
	public static class PromiseExtension // TypeDefIndex: 8421
	{
		// Methods
		// [IteratorStateMachine] // 0x0063BA20-0x0063BA90
		private static IEnumerator asPromiseCoroutine(Promise<object> promise, YieldInstruction coro) => default; // 0x009F8FB0-0x009F9030
		// [IteratorStateMachine] // 0x0063BAA0-0x0063BB10
		private static IEnumerator asPromiseCoroutine(Promise<object> promise, IEnumerator coro) => default; // 0x009F9130-0x009F91B0
		// [IteratorStateMachine] // 0x0063BB20-0x0063BB90
		private static IEnumerator wwwAsPromiseCoroutine(Promise<WWW> promise, WWW www) => default; // 0x009F92B0-0x009F9330
		// [IteratorStateMachine] // 0x0063BBC0-0x0063BC30
		private static IEnumerator watiForFinishCoroutine(Promise<object> promise, Animator animator) => default; // 0x009F9430-0x009F94B0
	
		// Extension methods
		// [IteratorStateMachine] // 0x0063B980-0x0063BA00
		public static IEnumerator AsCoroutine<T>(this IPromise<T> promise) => default;
		public static IPromise<T> Finally<T>(this IPromise<T> promise, Action<T> func) => default;
		public static Promise<object> AsPromise(this YieldInstruction coro) => default; // 0x009F8DD0-0x009F8EA0
		public static IPromise<object> AsPromise(this IEnumerator coro) => default; // 0x009F9060-0x009F9130
		public static IPromise<WWW> AsPromise(this WWW www) => default; // 0x009F91E0-0x009F92B0
		public static IPromise<T> Delay<T>(this IPromise<T> _this, float sec) => default;
		public static IPromise<T> WithScreenLock<T>(this IPromise<T> promise) => default;
		public static IPromise<object> WaitForFinish(this Animator animator) => default; // 0x009F9360-0x009F9430
	}
}
