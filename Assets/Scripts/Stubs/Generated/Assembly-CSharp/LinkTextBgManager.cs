/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class LinkTextBgManager : Singleton<LinkTextBgManager> // TypeDefIndex: 6250
{
	// Fields
	private Pool pool_; // 0x10

	// Properties
	public Pool Pool_ { get => default; } // 0x00904560-0x00904570 

	// Nested types
	public class Pool // TypeDefIndex: 6251
	{
		// Fields
		private GameObject poolObj_; // 0x10
		private const int PoolSize = 50; // Metadata: 0x00612AFD
		public readonly Queue<PoolableObject> _pool; // 0x18

		// Constructors
		public Pool() {} // 0x009043B0-0x00904460

		// Methods
		public void EnqueueAndMoveObj(PoolableObject obj) {} // 0x009045E0-0x00904710
		public void Destroy() {} // 0x009044E0-0x00904560
	}

	// Constructors
	public LinkTextBgManager() {} // 0x00904570-0x009045E0

	// Methods
	protected override void Startup() {} // 0x009042C0-0x009043B0
	protected override void Shutdown() {} // 0x00904460-0x009044E0
}

