/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NativeMessageWindowCtrl : Singleton<NativeMessageWindowCtrl> // TypeDefIndex: 5098
{
	// Nested types
	public class MessageAskItem // TypeDefIndex: 5099
	{
		// Fields
		public int textHash; // 0x10
		public int result; // 0x14

		// Constructors
		public MessageAskItem() {} // 0x0089BD50-0x0089BD80
	}

	// Constructors
	public NativeMessageWindowCtrl() {} // 0x0089AF80-0x0089AFF0

	// Methods
	private MessageWindow.AskParam _MakeAskParam(List<MessageAskItem> ask, MessageWindow.AskParam.TalkType type, bool bEnableCancel, bool bAutoClose) => default; // 0x00899F70-0x0089A160
	// [IteratorStateMachine] // 0x0061D000-0x0061D070
	private IEnumerator _Ask(int nativeControlId, TextId textId, List<MessageAskItem> ask, MessageWindow.AskParam.TalkType type, int defaultPoint, bool bEnableCancel, bool bAutoClose) => default; // 0x0089A160-0x0089A230
	// [IteratorStateMachine] // 0x0061D070-0x0061D0E0
	private IEnumerator _Notice(int nativeControlId, TextId textId, bool bAutoClose) => default; // 0x0089A260-0x0089A300
	// [IteratorStateMachine] // 0x0061D0E0-0x0061D150
	private IEnumerator _Center(int nativeControlId, TextId textId, bool bAllOutput, bool bAutoClose) => default; // 0x0089A330-0x0089A3D0
	// [IteratorStateMachine] // 0x0061D150-0x0061D1C0
	private IEnumerator _Talk(int nativeControlId, string name, Index creatureIndex, GenderType genderType, FACE_TYPE eFace, string text, bool bAutoClose) => default; // 0x0089A400-0x0089A4C0
	// [IteratorStateMachine] // 0x0061D1C0-0x0061D230
	private IEnumerator _TalkAsk(int nativeControlId, string name, Index creatureIndex, GenderType gender, FACE_TYPE eFace, TextId textId, List<MessageAskItem> ask, int defaultPoint, bool bEnableCancel) => default; // 0x0089A4F0-0x0089A5D0
	private void _Close() {} // 0x0089A600-0x0089A6D0
	public void Notice(int nativeControlId, TextId textId, bool bAutoClose) {} // 0x0089A6D0-0x0089A7D0
	public void NoticeCenter(int nativeControlId, TextId textId, bool bAllOutput, bool bAutoClose) {} // 0x0089A7D0-0x0089A8E0
	public void NoticeAsk(int nativeControlId, TextId textId, List<MessageAskItem> ask, int defaultPoint, bool bEnableCancel = true /* Metadata: 0x00610EF0 */, bool bAutoClose = true /* Metadata: 0x00610EF1 */) {} // 0x0089A8E0-0x0089AA10
	public void Talk(int nativeControlId, IPokemonStatus status, FACE_TYPE eFace, TextId textId, bool bAutoClose) {} // 0x0089AA10-0x0089ABA0
	public void Talk(int nativeControlId, string name, Index creatureIndex, GenderType gender, FACE_TYPE eFace, string text, bool bAutoClose) {} // 0x0089ABA0-0x0089ACC0
	public void TalkAsk(int nativeControlId, IPokemonStatus status, FACE_TYPE eFace, TextId textId, List<MessageAskItem> ask, int defaultPoint, bool bEnableCancel = true /* Metadata: 0x00610EF2 */) {} // 0x0089ACC0-0x0089AE40
	public void TalkAsk(int nativeControlId, string name, Index creatureIndex, GenderType gender, FACE_TYPE eFace, TextId textId, List<MessageAskItem> ask, int defaultPoint, bool bEnableCancel) {} // 0x0089AE40-0x0089AF70
	public void Close() {} // 0x0089AF70-0x0089AF80
}

