/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonEnemyType : UIManagerBase // TypeDefIndex: 6777
{
	// Fields
	public UIFaceWindow faceWindow_; // 0x20
	private GameObject objEnemyTarget_; // 0x28
	private GameObject objPokeName_; // 0x30
	private GameObject objType1Icon_; // 0x38
	private GameObject objType1Text_; // 0x40
	private GameObject objType2Icon_; // 0x48
	private GameObject objType2Text_; // 0x50
	private GameObject objAbilityText_; // 0x58

	// Constructors
	public UIDungeonEnemyType() {} // 0x00B1FF00-0x00B1FF10

	// Methods
	public void Init(GameObject root) {} // 0x00B1F290-0x00B1F580
	protected void setFaceIcon_(Const.creature.Index pokemonIndex, bool bFemale, Const.sugowaza.Index sugowazaIndex) {} // 0x00B1F580-0x00B1F680
	protected void activeFaceIcon_(bool bActive) {} // 0x00B1F680-0x00B1F730
	public void UpdateWindow(IPokemonStatus status) {} // 0x00B1F730-0x00B1FF00
}

