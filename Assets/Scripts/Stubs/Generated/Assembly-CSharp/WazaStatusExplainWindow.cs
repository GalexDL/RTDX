/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class WazaStatusExplainWindow : WazaStatusWindowBase // TypeDefIndex: 8009
{
	// Fields
	private ExplainView explainView_; // 0x30

	// Properties
	protected UIScrollView ScrollView { get => default; } // 0x00745000-0x00745010 

	// Nested types
	private class ExplainView : DetailWindowBase // TypeDefIndex: 8010
	{
		// Constructors
		public ExplainView() {} // 0x00745150-0x00745160
	}

	// Constructors
	public WazaStatusExplainWindow() {} // 0x00746420-0x00746430

	// Methods
	public override void Init(GameObject root) {} // 0x00745010-0x00745150
	protected override void _doUpdate() {} // 0x00745160-0x007451A0
	private void _setStatusGage(GameObject obj, int power, int addPower, bool bPowerMax, bool bFit = true /* Metadata: 0x00613C20 */) {} // 0x007451A0-0x00745640
	public void UpdateWindow(IPokemonStatus status, bool bOriginal, int wazaId, Index forceWazaIndex = Index.NONE /* Metadata: 0x00613C21 */, bool bForce = false /* Metadata: 0x00613C25 */) {} // 0x00745640-0x007458E0
	public void UpdateWindow(Index wazaIndex) {} // 0x00746310-0x00746410
	private void WazaDrawUpdate(byte[] buffer) {} // 0x007458E0-0x00746310
	public bool IsScroll() => default; // 0x00746410-0x00746420
}

