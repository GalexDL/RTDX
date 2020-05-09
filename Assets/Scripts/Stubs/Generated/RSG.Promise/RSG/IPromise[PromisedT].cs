/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: RSG.Promise.dll - Assembly: RSG.Promise, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null - Types 4068-4089

namespace RSG
{
	public interface IPromise<PromisedT> // TypeDefIndex: 4079
	{
		// Methods
		void Done(Action<PromisedT> onResolved, Action<Exception> onRejected);
		void Done(Action<PromisedT> onResolved);
		void Done();
		IPromise<PromisedT> Catch(Action<Exception> onRejected);
		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved);
		IPromise<PromisedT> Then(Action<PromisedT> onResolved);
		IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected);
		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform);
	}
}
