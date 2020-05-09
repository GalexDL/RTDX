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
	public class Promise : IPromise, IPendingPromise, IRejectable, IPromiseInfo // TypeDefIndex: 4076
	{
		// Fields
		public static bool EnablePromiseTracking; // 0x00
		private static EventHandler<ExceptionEventArgs> unhandlerException; // 0x08
		internal static int nextPromiseId; // 0x10
		internal static HashSet<IPromiseInfo> pendingPromises; // 0x18
		private Exception rejectionException; // 0x10
		private List<RejectHandler> rejectHandlers; // 0x18
		private List<ResolveHandler> resolveHandlers; // 0x20
	
		// Properties
		public PromiseState CurState { get; private set; } // 0x00525120-0x00525130 0x00525130-0x00525140
	
		// Nested types
		public struct ResolveHandler // TypeDefIndex: 4077
		{
			// Fields
			public Action callback; // 0x10
			public IRejectable rejectable; // 0x18
		}
	
		// Constructors
		public Promise() {} // Dummy constructor
		static Promise() {} // 0x00525770-0x00525800
	
		// Methods
		private void InvokeRejectHandler(Action<Exception> callback, IRejectable rejectable, Exception value) {} // 0x00525140-0x00525240
		private void ClearHandlers() {} // 0x00525240-0x00525250
		private void InvokeRejectHandlers(Exception ex) {} // 0x00525250-0x00525320
		public void Reject(Exception ex) {} // 0x00525330-0x00525620
		internal static void PropagateUnhandledException(object sender, Exception ex) {} // 0x00525620-0x00525770
	}
}
