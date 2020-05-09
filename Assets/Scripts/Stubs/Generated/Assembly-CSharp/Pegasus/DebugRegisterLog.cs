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

namespace Pegasus
{
	public class DebugRegisterLog // TypeDefIndex: 8495
	{
		// Fields
		private HashSet<string> m_dumpPatternCache; // 0x10
		private static int m_ignoreChatworksSendCnt; // 0x00
		private static bool m_isDisableChatworkSend; // 0x04
	
		// Constructors
		public DebugRegisterLog() {} // 0x00B60120-0x00B60190
		static DebugRegisterLog() {} // 0x00B60AC0-0x00B60AD0
	
		// Methods
		public static void BeginIgnoreSendChatwork() {} // 0x00B60040-0x00B600B0
		public static void EndIgnoreSendChatwork() {} // 0x00B600B0-0x00B60120
		~DebugRegisterLog() {} // 0x00B60190-0x00B601A0
		private bool IsIgnoreLog(string condition) => default; // 0x00B601A0-0x00B60250
		private void HandleLog(string condition, string stackTrace, LogType type) {} // 0x00B60250-0x00B60450
		private void SendOutPut(string outlog) {} // 0x00B60850-0x00B609E0
		private string CreateDumpLog(string condition, string stackTrace) => default; // 0x00B607A0-0x00B60850
		private string CreateUserString() => default; // 0x00B60450-0x00B607A0
		public void DumpPatternClear() {} // 0x00B60A40-0x00B60A90
		// [IteratorStateMachine] // 0x0063BE40-0x0063BEB0
		private IEnumerator OutErrorInfo(string errorText) => default; // 0x00B609E0-0x00B60A40
	}
}
