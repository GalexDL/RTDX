/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GraphVisualizerClient // TypeDefIndex: 4351
{
	// Fields
	private static GraphVisualizerClient s_Instance; // 0x00
	private Dictionary<PlayableGraph, string> m_Graphs; // 0x10

	// Properties
	public static GraphVisualizerClient instance { get => default; } // 0x0072BF90-0x0072C070 

	// Constructors
	public GraphVisualizerClient() {} // 0x0072C070-0x0072C0E0

	// Methods
	~GraphVisualizerClient() {} // 0x0072C0E0-0x0072C190
	public static void Show(PlayableGraph graph, string name) {} // 0x0072C190-0x0072C240
	public static void Hide(PlayableGraph graph) {} // 0x0072C240-0x0072C2E0
	public static IEnumerable<KeyValuePair<PlayableGraph, string>> GetGraphs() => default; // 0x0072C2E0-0x0072C300
}

