/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MoveRotateYaw // TypeDefIndex: 5812
{
	// Fields
	private MoveFloatVer2 m_fYaw; // 0x10
	private RotationType m_eRotate; // 0x18

	// Nested types
	public enum RotationType // TypeDefIndex: 5813
	{
		NEAR = 0,
		LEFT = 100,
		RIGHT = 200
	}

	// Constructors
	public MoveRotateYaw() {} // 0x00E34DB0-0x00E34E70

	// Methods
	private MoveFloatVer2 GetMove() => default; // 0x00E34E70-0x00E34E80
	public bool IsMove() => default; // 0x00E34E80-0x00E34ED0
	public void Set(float fRad, RotationType eType = RotationType.NEAR /* Metadata: 0x00611F85 */) {} // 0x00E34ED0-0x00E34F50
	public void MoveTo(float fToYawRad, float fSec, float fAtSec, float fDtSec, RotationType eType = RotationType.NEAR /* Metadata: 0x00611F89 */) {} // 0x00E34F50-0x00E35120
	public void MoveToFromSpeed(float fToYawRad, float fRadianPerSec, float fAtRatio, float fDtRatio, RotationType eType = RotationType.NEAR /* Metadata: 0x00611F8D */) {} // 0x00E352B0-0x00E35430
	public void MoveToOffs(float fYaw, float fSec, float fAtSec, float fDtSec) {} // 0x00E35650-0x00E35790
	public void MoveToOffsFromSpeed(float fYaw, float fRadianPerSec, float fAtRatio, float fDtRatio) {} // 0x00E357F0-0x00E358E0
	public float Get() => default; // 0x00E358E0-0x00E35930
	public void UpdateToYaw(float fToYaw) {} // 0x00E35930-0x00E359C0
	public void Tick() {} // 0x00E359C0-0x00E35A10
	private float _GetDist(float fStart, float fEnd, RotationType eType) => default; // 0x00E35120-0x00E35200
	private void _SetFromTime(float fTarget, float fStart, float fSec, float fAtSec, float fDtSec) {} // 0x00E35200-0x00E352B0
	private void _SetFromSpeed(float fTarget, float fStart, float fRadianPerSec, float fAtRatio, float fDtRatio) {} // 0x00E35430-0x00E35650
	private int CalcRadModulo2PI(out float pOut, float a) {
		pOut = default;
		return default;
	} // 0x00E35790-0x00E357F0
	private float MoveValiable_CalcAccelTimeFromDistance(float fSpeed, float fAtDistance) => default; // 0x00E35A10-0x00E35AE0
}

