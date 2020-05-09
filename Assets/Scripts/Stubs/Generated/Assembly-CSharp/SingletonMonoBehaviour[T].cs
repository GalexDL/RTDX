/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SingletonMonoBehaviour<T> : MonoBehaviour // TypeDefIndex: 5850
	where T : class, new()
{
	// Fields
	protected static T instance_; // 0x00
	protected static bool bDontSceneChangeDelete_; // 0x00

	// Properties
	public static T Instance { get => default; }
	public static bool IsValid { get => default; }

	// Constructors
	public SingletonMonoBehaviour() {}
	static SingletonMonoBehaviour() {}

	// Methods
	public static bool CheckAlreadyExistInstance() => default;
	public static void CreateInstance(bool bDontSceneChangeDelete) {}
	public static void CreateInstanceFromPrefabPath(string bundlePath, string prefabPath, bool bDontSceneChangeDelete) {}
	public static void CreateInstance(string resourcesPath, bool bDontSceneChangeDelete) {}
	public static void DeleteInstance(bool destroy = false /* Metadata: 0x00612062 */) {}
	private void Awake() {}
	private void OnDestroy() {}
	private void Start() {}
	private void Update() {}
}

