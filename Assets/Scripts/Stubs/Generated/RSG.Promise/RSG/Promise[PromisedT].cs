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

namespace RSG
{
	public class Promise<PromisedT> : IPromise<PromisedT>, IPendingPromise<PromisedT>, IRejectable, IPromiseInfo // TypeDefIndex: 4082
	{
		// Fields
		private Exception rejectionException; // 0x00
		private PromisedT resolveValue; // 0x00
		private List<RejectHandler> rejectHandlers; // 0x00
		private List<Action<PromisedT>> resolveCallbacks; // 0x00
		private List<IRejectable> resolveRejectables; // 0x00
	
		// Properties
		private int Id { get; set; }
		public string Name { get; private set; }
		public PromiseState CurState { get; private set; }
	
		// Constructors
		public Promise() {}
	
		// Methods
		private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) {}
		private void AddResolveHandler(Action<PromisedT> onResolved, IRejectable rejectable) {}
		private void InvokeHandler<T>(Action<T> callback, IRejectable rejectable, T value) {}
		private void ClearHandlers() {}
		private void InvokeRejectHandlers(Exception ex) {}
		private void InvokeResolveHandlers(PromisedT value) {}
		public void Reject(Exception ex) {}
		public void Resolve(PromisedT value) {}
		public void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) {}
		public void Done(Action<PromisedT> onResolved) {}
		public void Done() {}
		public IPromise<PromisedT> WithName(string name) => default;
		public IPromise<PromisedT> Catch(Action<Exception> onRejected) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved) => default;
		public IPromise<PromisedT> Then(Action<PromisedT> onResolved) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Action<Exception> onRejected) => default;
		public IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform) => default;
		private void ActionHandlers(IRejectable resultPromise, Action<PromisedT> resolveHandler, Action<Exception> rejectHandler) {}
		public static IPromise<IEnumerable<PromisedT>> All(params /* 0x00604610-0x00604620 */ IPromise<PromisedT>[] promises) => default;
		public static IPromise<IEnumerable<PromisedT>> All(IEnumerable<IPromise<PromisedT>> promises) => default;
		public static IPromise<PromisedT> Resolved(PromisedT promisedValue) => default;
	}
}
