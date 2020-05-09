/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GenericPool : MonoBehaviour // TypeDefIndex: 6231
{
	// Fields
	private List<PoolableObject> useObjList_; // 0x18
	private PoolableObject pooledObject; // 0x20
	private static readonly Quaternion NoRotation; // 0x00

	// Properties
	public PoolableObject PooledObject { set {} } // 0x007287F0-0x00728800

	// Constructors
	public GenericPool() {} // 0x00728D00-0x00728D10
	static GenericPool() {} // 0x00728D10-0x00728DA0

	// Methods
	public T Place<T>(Vector2 position, Transform parent)
		where T : PoolableObject => default;
	public PoolableObject Place(Vector2 position, Transform parent) => default; // 0x00728800-0x00728B20
	public void Return(PoolableObject obj) {} // 0x00728B20-0x00728BA0
	public void AllReturn() {} // 0x00728BA0-0x00728D00
}

