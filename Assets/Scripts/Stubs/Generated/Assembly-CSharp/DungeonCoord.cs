/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonCoord // TypeDefIndex: 4624
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public const int MAX_AROUND_9 = 9; // Metadata: 0x00610A84
	public static readonly DungeonCoord[] aAround9; // 0x00
	private static readonly DungeonCoord[] aAround8_Direction; // 0x08
	private static readonly int[][] aDirections; // 0x10
	private static readonly int[][] aDirections5x5; // 0x18

	// Constructors
	public DungeonCoord() {} // 0x007B6CE0-0x007B6D10
	public DungeonCoord(int _x, int _y) {} // 0x007B6D10-0x007B6D50
	public DungeonCoord(DungeonDirection dir) {} // 0x007B6D50-0x007B6E80
	static DungeonCoord() {} // 0x007B79F0-0x007B8700

	// Methods
	public static bool operator ==(DungeonCoord c1, DungeonCoord c2) => default; // 0x007B6E90-0x007B6EE0
	public static bool operator !=(DungeonCoord c1, DungeonCoord c2) => default; // 0x007B6EE0-0x007B6FB0
	public static DungeonCoord operator +(DungeonCoord c1, DungeonCoord c2) => default; // 0x007B6FB0-0x007B7040
	public static DungeonCoord operator -(DungeonCoord c1, DungeonCoord c2) => default; // 0x007B7040-0x007B70D0
	public static DungeonCoord operator *(DungeonCoord c1, DungeonCoord c2) => default; // 0x007B70D0-0x007B7160
	public static DungeonCoord operator +(DungeonCoord c1, int v) => default; // 0x007B7160-0x007B71E0
	public static DungeonCoord operator -(DungeonCoord c1, int v) => default; // 0x007B71E0-0x007B7260
	public static DungeonCoord operator *(DungeonCoord c1, int v) => default; // 0x007B7260-0x007B72E0
	public static DungeonCoord operator /(DungeonCoord c1, int v) => default; // 0x007B72E0-0x007B7360
	public static DungeonCoord operator <<(DungeonCoord c1, int v) => default; // 0x007B7360-0x007B73E0
	public static DungeonCoord operator >>(DungeonCoord c1, int v) => default; // 0x007B73E0-0x007B7460
	public static DungeonCoord operator +(DungeonCoord c1, DungeonDirection dir) => default; // 0x007B7460-0x007B75A0
	public void Clear() {} // 0x007B75A0-0x007B75B0
	public DungeonCoord Transpose() => default; // 0x007B75B0-0x007B75C0
	public DungeonDirection GetDirection(DungeonCoord dstCoord, int nSize) => default; // 0x007B75C0-0x007B78D0
	public int GetDistance(DungeonCoord dstCoord) => default; // 0x007B7960-0x007B79F0
}

