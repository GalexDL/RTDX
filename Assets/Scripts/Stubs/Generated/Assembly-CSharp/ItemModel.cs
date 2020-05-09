/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemModel : NormalModel, IModelAcquiredMode // TypeDefIndex: 6027
{
	// Fields
	private static Color NORMAL_CONDITION_COLOR; // 0x00
	private static Color ACQUIRED_CONDITION_COLOR; // 0x10
	private Color m_itemColor; // 0x204
	private ManpuModel manpu_; // 0x218
	protected Dictionary<string, Material> m_dicBaseShaderMaterialStair; // 0x220
	protected Dictionary<string, ShaderData> m_dicBaseShaderStair; // 0x228
	private Vector3 m_vSpotJudgePosition; // 0x230
	private bool m_bStair; // 0x23C
	private bool m_bTrap; // 0x23D
	private bool m_bAcquiredMode; // 0x23E
	private bool m_bDirtyItemColor; // 0x23F
	private bool m_bDirtyAcquiredMode; // 0x240

	// Constructors
	public ItemModel() {} // Dummy constructor
	protected ItemModel(int nativeControlId, string symbol, string bundlePath, string resourcePath) {} // 0x008FF5D0-0x008FFC40
	static ItemModel() {} // 0x009009F0-0x00900AC0

	// Methods
	public static ItemModel CreateFromNative(int nativeControlId, string symbol, string bundlePath, string resourcePath) => default; // 0x008FF440-0x008FF5D0
	private void SetItemMarker(bool bEnable) {} // 0x008FFC40-0x008FFCA0
	public void SetItemColor(Color color) {} // 0x008FFCA0-0x008FFD20
	public virtual void SetAcquiredMode(bool bEnable) {} // 0x008FFD20-0x008FFD50
	public void SetManpu(uint gfxSymbol, Vector3 offset) {} // 0x008FFD50-0x008FFE60
	public void DestroyManpu() {} // 0x008FFE60-0x008FFEE0
	public override void SetVisible(bool bVisible) {} // 0x008FFEE0-0x008FFF30
	public override Vector3 GetSpotCalcPosition() => default; // 0x008FFF30-0x008FFF40
	public void SetSpotJudgePosition(Vector3 position) {} // 0x008FFF40-0x008FFF50
	public override void Update() {} // 0x008FFF50-0x00900360
	public override void OnMaterialShaderChange(GraphicsSystem.LayerId layerId) {} // 0x00900360-0x009007F0
	protected override void OnUpdateShaderMaterialVisibleColor(Color color) {} // 0x009007F0-0x00900960
	public override void LastUpdate() {} // 0x00900960-0x00900970
	protected override void OnTerminate() {} // 0x00900970-0x009009F0
}

