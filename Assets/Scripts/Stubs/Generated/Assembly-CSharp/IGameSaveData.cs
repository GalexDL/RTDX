/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IGameSaveData // TypeDefIndex: 5541
{
	// Methods
	void SetBoolFlag(string symbol, bool bSwitch);
	bool GetBoolFlag(string symbol);
	SaveMode GetSaveMode();
	bool IsSaveStartMode();
	bool IsGroundSaveMode();
	bool IsDungeonSaveMode();
	int GetAdventureCount();
	Index GetSaveDungeonIndex();
	int GetSaveDungeonFloor();
}

