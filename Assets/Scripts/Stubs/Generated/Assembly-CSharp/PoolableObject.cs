/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class PoolableObject : MonoBehaviour // TypeDefIndex: 6356
{
	// Properties
	public GenericPool Pool { private get; set; } // 0x009EC820-0x009EC830 0x009EC830-0x009EC840

	// Constructors
	protected PoolableObject() {} // 0x009EC870-0x009EC880

	// Methods
	public abstract void Init();
	protected new void Destroy(UnityEngine.Object obj) {} // 0x009EC840-0x009EC850
	protected void ReturnToPool() {} // 0x009EC850-0x009EC860
	protected PoolableObject GetPoolableObject(Vector2 position, Transform parent) => default; // 0x009EC860-0x009EC870
}

