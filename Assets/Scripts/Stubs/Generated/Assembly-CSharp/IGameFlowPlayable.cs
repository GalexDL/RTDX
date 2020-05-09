/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IGameFlowPlayable // TypeDefIndex: 4662
{
	// Properties
	string FlowId { get; set; }

	// Methods
	bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob);
	IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit);
	IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc);
	void Foreach(Action<IGameFlowPlayable> action);
	void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action);
	IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl();
}

