/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using effect;
using kamina.graphics;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GimmickModel : NormalModel // TypeDefIndex: 6006
{
	// Fields
	private GraphicsSystem.GimmickDatabaseParameter baseParameter_; // 0x208
	private static float TIME_BANNER_ANIMATION; // 0x00
	private List<Texture2D> aListTextureSlot_; // 0x210
	private MoveFloat moveBannerCurrentAnimationTime_; // 0x218
	private ManpuModel manpu_; // 0x220
	private Transform attachRoot_; // 0x228
	private NormalModel attachModel_; // 0x230
	private Vector3 attachOffset_; // 0x238

	// Constructors
	public GimmickModel() {} // Dummy constructor
	protected GimmickModel(int nativeControlId, GraphicsSystem.GimmickDatabaseParameter baseParameter, string bundlePath) {} // 0x0072B290-0x0072B660
	static GimmickModel() {} // 0x0072BCC0-0x0072BD20

	// Methods
	public static new void RequestLoadResource(string gimmickSymbol, Action loadedCb = null) {} // 0x0072AB00-0x0072ABA0
	public static void RequestLoadResourceFromGfxSymbol(uint gfxSymbol, Action loadedCb = null) {} // 0x0072ACD0-0x0072ADE0
	public static new bool IsLoadedResource(string gimmickSymbol) => default; // 0x0072AFF0-0x0072B090
	public static bool IsLoadedResource(uint gfxSymbol) => default; // 0x0072B090-0x0072B140
	public static GimmickModel Create(string gimmickSymbol) => default; // 0x0072B140-0x0072B1E0
	public static GimmickModel Create(uint gfxSymbol) => default; // 0x0072B1E0-0x0072B290
	public static GimmickModel CreateDungeonGimmick(int nativeCntrolId, uint gfxSymbol) => default; // 0x0072B660-0x0072B720
	protected override void OnTerminate() {} // 0x0072B720-0x0072B7B0
	public PlacementType GetAttachPlacementType() => default; // 0x0072B830-0x0072B840
	public override void AnalyzeBaseAnimation(string resourcePath) {} // 0x0072B840-0x0072BA30
	public void Attach(Transform root, NormalModel model) {} // 0x0072BA30-0x0072BA40
	public override Vector3 GetSpotCalcPosition() => default; // 0x0072BA40-0x0072BA80
	public void SetManpu(uint gfxSymbol, Vector3 offset) {} // 0x0072BA80-0x0072BB90
	public void DestroyManpu() {} // 0x0072B7B0-0x0072B830
	public override void Update() {} // 0x0072BB90-0x0072BCC0
}

