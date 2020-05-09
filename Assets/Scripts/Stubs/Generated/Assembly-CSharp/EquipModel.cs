/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class EquipModel : NormalModel // TypeDefIndex: 5977
{
	// Fields
	private GraphicsSystem.EquipGraphicsDatabaseParameter baseParam_; // 0x208
	private Shader normalShader_; // 0x210
	private BuildMode eBuildMode_; // 0x218
	private CharacterModel attachCharacter_; // 0x220

	// Nested types
	public enum BuildMode // TypeDefIndex: 5978
	{
		DEFAULT = 0,
		RENDER_TEXTURE = 1,
		RENDER_TEXTURE2 = 2,
		MAX = 3
	}

	// Constructors
	public EquipModel() {} // Dummy constructor
	protected EquipModel(string symbol, GraphicsSystem.EquipGraphicsDatabaseParameter param, BuildMode buildMode) {} // 0x00BDE6F0-0x00BDE840

	// Methods
	public static EquipModel Create(uint gfxSymbol, BuildMode buildMode) => default; // 0x00BDE630-0x00BDE6F0
	public void SetCharacterModelAttach(CharacterModel attach) {} // 0x00BDE9F0-0x00BDEA00
	private Shader GetFirstSetupNormalShader(BuildMode buildMode) => default; // 0x00BDE840-0x00BDE9F0
	public override void OnMaterialShaderChange(GraphicsSystem.LayerId layerId) {} // 0x00BDEA00-0x00BDEB50
	public override Vector3 GetSpotCalcPosition() => default; // 0x00BDEB50-0x00BDEB80
	public string GetMotionName() => default; // 0x00BDEB80-0x00BDEB90
	public string GetAttachBone() => default; // 0x00BDEB90-0x00BDEBA0
	public void SetLocalPosition(Vector3 localPosition) {} // 0x00BDEBA0-0x00BDEBF0
	public Vector3 GetEffectOffset() => default; // 0x00BDEBF0-0x00BDEC00
	protected override void OnTerminate() {} // 0x00BDEC00-0x00BDEC10
	public override void Update() {} // 0x00BDEC10-0x00BDEC20
}

