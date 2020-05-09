/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GridLine // TypeDefIndex: 5422
{
	// Fields
	public Vector2 m_startPos; // 0x10
	public Vector2 m_endPos; // 0x18
	private const string m_gridLineName = "GridLine"; // Metadata: 0x006113B7
	private const string m_gridNameV = "VerticalGridLine"; // Metadata: 0x006113C3
	private const string m_gridNameH = "HorizontalGridLine"; // Metadata: 0x006113D7
	[NonSerialized]
	public float m_lineInterval; // 0x20
	private static GridLine m_grid; // 0x00

	// Properties
	public static GridLine Instance { get => default; } // 0x0072F300-0x0072F350 

	// Nested types
	[Serializable]
	public class GridSaveData // TypeDefIndex: 5423
	{
		// Fields
		public Vector2 m_startPosV; // 0x10
		public Vector2 m_endPosV; // 0x18
		public int m_gridNumV; // 0x20
		public Vector2 m_startPosH; // 0x24
		public Vector2 m_endPosH; // 0x2C
		public int m_gridNumH; // 0x34

		// Constructors
		public GridSaveData() {} // 0x0072FDD0-0x0072FDE0
	}

	// Constructors
	public GridLine() {} // 0x0072F2F0-0x0072F300

	// Methods
	public static void CreateInstance() {} // 0x0072F260-0x0072F2F0
	public void Uninit() {} // 0x0072F350-0x0072F3A0
	public void CreateGrid(Vector2 windowSize) {} // 0x0072F3A0-0x0072F610
	public void Update(Rect windowSize) {} // 0x0072F610-0x0072F990
	public void Draw() {} // 0x0072F990-0x0072FA30
	public void AllMove(Vector2 moveValue) {} // 0x0072FA30-0x0072FCA0
	public string GetJsonData() => default; // 0x0072FCA0-0x0072FDD0
	public void Load(string jsonData) {} // 0x0072FDE0-0x0072FF20
	public void LoadString(string data) {} // 0x0072FF20-0x00730000
	public void CreateGridLoadTimng(GridSaveData data) {} // 0x00730000-0x007304C0
	public int GetMinGridH() => default; // 0x007304C0-0x00730630
	public int GetMaxGridH() => default; // 0x00730630-0x007307A0
	public int GetMinGridV() => default; // 0x007307A0-0x00730910
	public int GetMaxGridV() => default; // 0x00730910-0x00730A80
}

