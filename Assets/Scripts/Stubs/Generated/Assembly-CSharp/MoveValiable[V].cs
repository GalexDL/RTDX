/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class MoveValiable<V> // TypeDefIndex: 5808
	where V : struct
{
	// Fields
	private const int TimeScale = 60; // Metadata: 0x00611F75
	protected MoveMode Mode; // 0x00
	protected V Now; // 0x00
	protected V Start; // 0x00
	protected V Goal; // 0x00
	protected V Step; // 0x00
	protected float SplineStep; // 0x00
	protected float SplineStepNow; // 0x00
	protected V Control; // 0x00
	protected V Accel0; // 0x00
	protected V Accel1; // 0x00
	protected float AccelTime0; // 0x00
	protected float AccelTime1; // 0x00
	protected float AccelTime2; // 0x00
	protected float TotalTime; // 0x00
	protected int TimeTick; // 0x00
	protected float TimeSec; // 0x00

	// Properties
	public bool IsMove { get; }

	// Nested types
	protected enum MoveMode // TypeDefIndex: 5809
	{
		NONE = 0,
		LINEAR = 1,
		SPLINE = 2
	}

	// Constructors
	public MoveValiable() {}
	public MoveValiable(V v) {}
	public MoveValiable(V v, V g, float s) {}

	// Methods
	protected abstract float Distance_(V a, V b);
	protected abstract float Length_(V a);
	protected abstract void SetZero_(out V a);
	protected abstract V Mul_(V a, float b);
	protected abstract V Add_(V a, V b);
	protected abstract V Sub_(V a, V b);
	protected void Initialize() {}
	public void Set(V v) {}
	public bool SetGoalLinear(V v, float swSec, float atSec = 0f /* Metadata: 0x00611F6D */, float dtSec = 0f /* Metadata: 0x00611F71 */) => default;
	public void SetGoalSpline(V v0, V v1, float sw) {}
	public void Add(V x) {}
	public bool MoveTick() => default;
	public V Get() => default;
	public V GetStart() => default;
	public V GetGoal() => default;
	public static float CalcAccelTimeFromDistance(float fSpeed, float fAtDistance) => default;
	public static void CalcSecFromDistance(float fSpeed, float fDistance, float fAtRatio, float fDtRatio, out float fSec, out float fAtSec, out float fDtSec) {
		fSec = default;
		fAtSec = default;
		fDtSec = default;
	}
}

