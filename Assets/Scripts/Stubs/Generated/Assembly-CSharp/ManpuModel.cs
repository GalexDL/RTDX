/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ManpuModel : NormalModel // TypeDefIndex: 6040
{
	// Fields
	private GraphicsSystem.ManpuDatabaseParameter baseParameter_; // 0x208
	private Vector3 worldOffset_; // 0x210
	private Transform attachRoot_; // 0x220
	private NormalModel attachModel_; // 0x228
	private CharacterModel attachCharaModel_; // 0x230
	private bool bPrevAutoCamera_; // 0x238

	// Constructors
	public ManpuModel() {} // Dummy constructor
	protected ManpuModel(int nativeControlId, uint gfxSymbol, string symbol, string resourcePath) {} // 0x00891F30-0x00892140

	// Methods
	public static ManpuModel Create(string gimmickSymbol) => default; // 0x00891DC0-0x00891E30
	public static ManpuModel Create(uint gfxSymbol) => default; // 0x00891E30-0x00891F30
	public override void AnalyzeBaseAnimation(string resourcePath) {} // 0x00892140-0x008921D0
	public void Attach(Transform root, NormalModel model) {} // 0x008921D0-0x00892270
	public override Vector3 GetSpotCalcPosition() => default; // 0x00892270-0x008922B0
	public override void ReturnRootActiveForceAnimationPlay() {} // 0x008922B0-0x008922C0
	public override void Update() {} // 0x008922C0-0x00892370
	public override void LastUpdate() {} // 0x00892370-0x00892580
	public void SetGhostGroundFadeRate(float fRate) {} // 0x00892580-0x00892590
	protected override void OnTerminate() {} // 0x00892590-0x008925D0
}

