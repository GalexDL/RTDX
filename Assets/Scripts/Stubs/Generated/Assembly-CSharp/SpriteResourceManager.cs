/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SpriteResourceManager : Singleton<SpriteResourceManager> // TypeDefIndex: 6079
{
	// Fields
	private Dictionary<string, bool> aLoadBundleRequest_; // 0x10
	private Dictionary<string, Sprite> generalSprites_; // 0x18
	private Dictionary<string, Sprite> faceSprites_; // 0x20
	private Dictionary<string, Sprite> mapIconSprites_; // 0x28
	private Dictionary<string, BndleParameter> bundleDic_; // 0x30

	// Nested types
	public enum GroupId // TypeDefIndex: 6080
	{
		NONE = 0,
		DRAMA = 1
	}

	protected class BndleParameter // TypeDefIndex: 6081
	{
		// Fields
		public int refCount; // 0x10
		public GroupId groupId; // 0x14

		// Constructors
		public BndleParameter() {} // 0x0090FCE0-0x0090FCF0
	}

	// Constructors
	public SpriteResourceManager() {} // 0x00910460-0x00910580

	// Methods
	public void LoadBundle(string bundleFile, ISpriteResourceBundle infa) {} // 0x0090FAF0-0x0090FCD0
	public void DestroyGroupBundle(GroupId groupId) {} // 0x0090FCF0-0x009100E0
	public bool IsBusyLoadBundle() => default; // 0x009100E0-0x00910140
	// [IteratorStateMachine] // 0x00624040-0x006240B0
	public IEnumerator AllWaitLoadBundle() => default; // 0x00910140-0x009101B0
	private Sprite LoadSprite(Dictionary<string, Sprite> dic, string basePath, string filename) => default; // 0x009101E0-0x009102E0
	public Sprite LoadFaceSprite(string filename) => default; // 0x009102E0-0x00910340
	public Sprite LoadWindowSprite(string filename) => default; // 0x00910340-0x009103A0
	public Sprite LoadMapIconSprite(string filename) => default; // 0x009103A0-0x00910400
	public Sprite LoadGeneralSprite(string filename) => default; // 0x00910400-0x00910460
}

