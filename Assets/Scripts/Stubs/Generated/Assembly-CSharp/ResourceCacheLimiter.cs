/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ResourceCacheLimiter // TypeDefIndex: 6892
{
	// Fields
	private node root_; // 0x10
	private node[] nodes_; // 0x18

	// Nested types
	private class node // TypeDefIndex: 6893
	{
		// Fields
		private node prev_; // 0x10
		private node next_; // 0x18
		private string name_; // 0x20
		private ResourceCache.Resource res_; // 0x28
		private int id_; // 0x30
		private int refCnt_; // 0x34

		// Properties
		public int Id { get => default; set {} } // 0x00835FB0-0x00835FC0 0x008361D0-0x008361E0

		// Constructors
		public node() {} // Dummy constructor
		public node(int id) {} // 0x00835930-0x00835970

		// Methods
		public void Add(node node) {} // 0x00835970-0x00835990
		public void Remove() {} // 0x00835EB0-0x00835ED0
		public node Next() => default; // 0x008361E0-0x008361F0
		public node Prev() => default; // 0x00835EA0-0x00835EB0
		public string GetInfo() => default; // 0x008361F0-0x008363A0
		public bool IsMatch(string name) => default; // 0x00835CB0-0x00835D80
		public void UnLoad() {} // 0x00835AE0-0x00835B80
		public void Load(string name, ResourceCache.Resource res) {} // 0x00835ED0-0x00835FA0
		public ResourceCache.Resource Get() => default; // 0x00836130-0x00836140
		public void IncRef() {} // 0x00835FA0-0x00835FB0
		public void DecRef() {} // 0x00836080-0x008360A0
		public bool IsRef() => default; // 0x008360A0-0x008360B0
	}

	// Constructors
	public ResourceCacheLimiter() {} // 0x008361C0-0x008361D0

	// Methods
	public void Init(int nAlloc) {} // 0x008357D0-0x00835930
	public void Release() {} // 0x00835990-0x00835AE0
	private node _find(string name) => default; // 0x00835B80-0x00835CB0
	public int Alloc(string name, ResourceCache.Resource res) => default; // 0x00835D80-0x00835EA0
	public void Free(int id) {} // 0x00835FC0-0x00836080
	public void Check() {} // 0x008360B0-0x00836110
	public ResourceCache.Resource Get(string name) => default; // 0x00836110-0x00836130
	public ResourceCache.Resource Get(int id) => default; // 0x00836140-0x008361C0
}

