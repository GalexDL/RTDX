/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.status;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface ICreature // TypeDefIndex: 5066
{
	// Properties
	ulong NativePointerId { get; }

	// Methods
	DungeonCoord GetCoord();
	DungeonDirection GetDirection();
	List<ICreature> FindEnemies(int distance, bool narrowOnly, bool ignoreLook, DungeonCoord overwriteCoord, DungeonDirection overwriteDir);
	string GetName();
	bool IsPlayer();
	bool IsParty();
	bool IsGuest();
	bool IsGuestParty();
	bool IsQuestGuest();
	bool IsMonster();
	bool IsAlive();
	bool IsPinch();
	IPokemonStatus GetStatus();
	Const.creature.Index GetIndex();
	Const.creature.Index GetAppearanceIndex();
	bool AddItem(IItem item);
	bool RemoveItem(IItem item);
	bool HasBadStatus(Const.status.Index statusIndex);
	void CheckWazaAffinity(Creature target, Affinity[] affinity);
	bool IsPossibleUseWaza(int index);
	Const.waza.Index GetWaza(int index, bool original);
	int GetWazaCount(bool original);
	int GetWazaPP(int index, bool original);
	int GetWazaPPMax(Const.waza.Index wazaIndex);
	string GetWazaName(Const.waza.Index wazaIndex, bool original, bool grade, bool color);
	bool IsEnableWaza(int index, bool original);
	void SetEnableWaza(int index, bool set);
	bool IsTemporaryWaza(int index);
	bool IsLearnedWaza(Const.waza.Index wazaIndex, bool original);
	bool IsWazaRenketsuParent(int index);
	bool IsWazaRenketsuChild(int index);
	int GetWazaRenketsuParentValue(int index);
	int GetWazaRenketsuChildValue(int index);
	void SwapWaza(int indexA, int indexB);
	List<int> GetRenketsuList(int wazaStatusId);
	int GetCharacterModelNativeControlId();
	Vector3 GetCharacterFloorPosition();
	Vector3 GetCharacterFloorScreenPosition();
	bool IsSpotPosition();
	bool HasNoUseItemBadStatus();
	bool HasNoUseWazaBadStatus();
}

