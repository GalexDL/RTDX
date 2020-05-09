/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonDirection // TypeDefIndex: 4626
{
	// Fields
	public static int DOWN; // 0x00
	public static int DOWN_RIGHT; // 0x04
	public static int RIGHT_DOWN; // 0x08
	public static int RIGHT; // 0x0C
	public static int RIGHT_UP; // 0x10
	public static int UP_RIGHT; // 0x14
	public static int UP; // 0x18
	public static int UP_LEFT; // 0x1C
	public static int LEFT_UP; // 0x20
	public static int LEFT; // 0x24
	public static int LEFT_DOWN; // 0x28
	public static int DOWN_LEFT; // 0x2C
	public static int MAX; // 0x30
	public static int MASK; // 0x34
	protected int dir_; // 0x10

	// Constructors
	public DungeonDirection() {} // 0x007B9680-0x007B96B0
	public DungeonDirection(int dir) {} // 0x007B78D0-0x007B7960
	static DungeonDirection() {} // 0x007BA0A0-0x007BA190

	// Methods
	public static implicit operator DungeonDirection(int d) => default; // 0x007B96B0-0x007B9770
	public static implicit operator int(DungeonDirection d) => default; // 0x007B6E80-0x007B6E90
	public static DungeonDirection operator +(DungeonDirection d1, DungeonDirection d2) => default; // 0x007B9770-0x007B9850
	public static DungeonDirection operator +(DungeonDirection d1, int d2) => default; // 0x007B9850-0x007B9920
	public static DungeonDirection operator +(int d1, DungeonDirection d2) => default; // 0x007B9920-0x007B99F0
	public static DungeonDirection operator -(DungeonDirection d1, DungeonDirection d2) => default; // 0x007B99F0-0x007B9AD0
	public static DungeonDirection operator -(DungeonDirection d1, int d2) => default; // 0x007B9AD0-0x007B9BA0
	public static DungeonDirection operator -(int d1, DungeonDirection d2) => default; // 0x007B9BA0-0x007B9C70
	public static DungeonDirection operator -(DungeonDirection d) => default; // 0x007B9C70-0x007B9D70
	public static DungeonDirection operator ++(DungeonDirection d) => default; // 0x007B9D70-0x007B9E40
	public static DungeonDirection operator --(DungeonDirection d) => default; // 0x007B9E40-0x007B9F10
	public static bool operator ==(DungeonDirection d1, DungeonDirection d2) => default; // 0x007B9F10-0x007B9F50
	public static bool operator !=(DungeonDirection d1, DungeonDirection d2) => default; // 0x007B9F50-0x007BA000
	public DungeonDirection Reverse() => default; // 0x007BA000-0x007BA090
	public bool IsDiag() => default; // 0x007BA090-0x007BA0A0
}

