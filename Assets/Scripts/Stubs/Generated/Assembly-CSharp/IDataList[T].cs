/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IDataList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 5067
{
	// Methods
	T GetFromListId(int id);
	int GetNum();
	int GetMax();
	bool Add(T data);
	void Clear();
	List<T> GetCoreList();
}

