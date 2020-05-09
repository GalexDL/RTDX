/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SpicaUI
{
	public class SingletonMonoBehaviour_DontSeneChangeDelete<T> : MonoBehaviour // TypeDefIndex: 8358
		where T : class, new()
	{
		// Fields
		protected static T instance_; // 0x00
	
		// Properties
		public static T Instance { get => default; }
		public static bool IsValid { get => default; }
	
		// Constructors
		public SingletonMonoBehaviour_DontSeneChangeDelete() {}
		static SingletonMonoBehaviour_DontSeneChangeDelete() {}
	
		// Methods
		public static void CreateInstance() {}
		public static void DeleteInstance() {}
		private void Awake() {}
		private void OnDestroy() {}
	}
}
