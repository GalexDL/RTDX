/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class WeakDictionary<K, V> // TypeDefIndex: 8283
	{
		// Fields
		private Dictionary<K, WeakReference> _dict; // 0x00
	
		// Properties
		public V this[K key] { get => default; set {} }
		private ICollection<K> Keys { get => default; }
		private ICollection<V> Values { get => default; }
	
		// Constructors
		public WeakDictionary() {}
	
		// Methods
		private void Add(K key, V value) {}
		private bool ContainsKey(K key) => default;
		private bool Remove(K key) => default;
		private bool TryGetValue(K key, out V value) {
			value = default;
			return default;
		}
	}
}
