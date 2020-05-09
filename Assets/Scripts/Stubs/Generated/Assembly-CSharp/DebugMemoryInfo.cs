/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DebugMemoryInfo : MonoBehaviour // TypeDefIndex: 4615
{
	// Fields
	private long m_peakUsedHeapSize; // 0x18

	// Constructors
	public DebugMemoryInfo() {} // 0x00990490-0x009904A0

	// Methods
	private void Awake() {} // 0x0098FF30-0x0098FF40
	public long GetTotalMemory() => default; // 0x0098FF40-0x0098FF50
	public long GetPeakMemory() => default; // 0x0098FF50-0x0098FF60
	public long GetMonoHeapSize() => default; // 0x0098FF60-0x0098FF70
	public long GetMonoUsedSize() => default; // 0x0098FF70-0x0098FF80
	public long GetObjectMemory<T>()
		where T : UnityEngine.Object => default;
	public string GetString() => default; // 0x0098FF80-0x00990480
	public void DumpConsole() {} // 0x00990480-0x00990490
	private T[] GetObjects<T>()
		where T : UnityEngine.Object => default;
}

