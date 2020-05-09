/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UISelectorBase // TypeDefIndex: 7544
{
	// Fields
	protected int nId_; // 0x10
	protected bool bFocus_; // 0x14
	protected bool bForceFaceDisable_; // 0x15
	protected bool bForceFaceSelect_; // 0x16
	protected UISelectItem item_; // 0x18
	protected GameObject face_; // 0x20
	private bool dirty_; // 0x28
	public static string[] faceTokens; // 0x00

	// Properties
	public int Id { get => default; set {} } // 0x00DF8840-0x00DF8850 0x00DF8830-0x00DF8840
	public bool Focus { get => default; set {} } // 0x00DF8880-0x00DF8890 0x00DF8850-0x00DF8870
	public UISelectItem Item { get => default; set {} } // 0x00DF88A0-0x00DF88B0 0x00DF8890-0x00DF88A0
	public GameObject Face { get => default; set {} } // 0x00DF88C0-0x00DF88D0 0x00DF88B0-0x00DF88C0
	public bool Dirty { get => default; set {} } // 0x00DF88D0-0x00DF88E0 0x00DF8870-0x00DF8880

	// Nested types
	public enum FaceType // TypeDefIndex: 7545
	{
		Normal = 0,
		Select = 1,
		Disable = 2,
		Focus = 3
	}

	// Constructors
	public UISelectorBase() {} // 0x00DF93C0-0x00DF93D0
	static UISelectorBase() {} // 0x00DF93D0-0x00DF95D0

	// Methods
	protected static void _showFace(GameObject obj, bool bShow) {} // 0x00DF88E0-0x00DF8A10
	protected virtual void SetupFace() {} // 0x00DF8A10-0x00DF8A20
	public virtual void UpdateFace() {} // 0x00DF8A20-0x00DF8B00
	protected virtual void SetupFaceBase() {} // 0x00DF8B00-0x00DF8D20
	protected virtual void FaceNormal() {} // 0x00DF8D20-0x00DF8E80
	protected virtual bool FaceFocus() => default; // 0x00DF8E80-0x00DF8FD0
	protected virtual bool FaceSelect() => default; // 0x00DF8FD0-0x00DF9120
	protected virtual bool FaceDisable() => default; // 0x00DF9120-0x00DF9270
	protected virtual void TMPStatusColor(GameObject obj) {} // 0x00DF9270-0x00DF93A0
	public virtual float GetPrefferdWidth() => default; // 0x00DF93A0-0x00DF93B0
	public virtual void ChangeWidth(float width) {} // 0x00DF93B0-0x00DF93C0
}

