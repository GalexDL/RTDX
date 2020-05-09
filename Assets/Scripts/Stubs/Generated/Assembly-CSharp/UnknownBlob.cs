/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UnknownBlob : ScriptDataBlobBase // TypeDefIndex: 4507
{
	// Fields
	public string originalType; // 0x30
	public string unknownData; // 0x38

	// Constructors
	public UnknownBlob() {} // 0x00B44100-0x00B44160

	// Methods
	public override void ForceSerialize() {} // 0x00B44060-0x00B44070
	public override void OnBlobSerialize(out string serializeType, out string serializeData) {
		serializeType = default;
		serializeData = default;
	} // 0x00B44070-0x00B44090
	public override void OnBlobDeserialize(string serializeData) {} // 0x00B44090-0x00B440A0
	// [IteratorStateMachine] // 0x00619340-0x006193B0
	public override IEnumerator Play(ScriptDataPlayer.PlayerContext playerContext) => default; // 0x00B440A0-0x00B44100
}

