/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;
using Const.tutorial;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UITrainingBanner : UIManagerBase // TypeDefIndex: 7677
{
	// Fields
	private GameObject mainObj_; // 0x20
	private DungeonBanner dungeonBanner_; // 0x28
	private TutorialBanner tutorialBanner_; // 0x30
	private TicketInfoWindow_Banner ticketInfo_; // 0x38
	private BgWindow bgWindow_; // 0x40

	// Nested types
	private class DungeonBanner : UIWindowBase // TypeDefIndex: 7678
	{
		// Constructors
		public DungeonBanner() {} // 0x00A4D7C0-0x00A4D7D0

		// Methods
		public void Init(GameObject root, Const.dungeon.Index dungeonIndex) {} // 0x00A4D7D0-0x00A4D920
	}

	private class TutorialBanner : UIWindowBase // TypeDefIndex: 7679
	{
		// Constructors
		public TutorialBanner() {} // 0x00A4D650-0x00A4D660

		// Methods
		public void Init(GameObject root, Const.tutorial.Index tutorialIndex) {} // 0x00A4D660-0x00A4D7B0
		// [IteratorStateMachine] // 0x00651150-0x006511C0
		public IEnumerator OpenManabi(Action<bool> cb) => default; // 0x00A4E3D0-0x00A4E450
	}

	private class TicketInfoWindow_Banner : UITraining.TicketInfoWindow // TypeDefIndex: 7682
	{
		// Constructors
		public TicketInfoWindow_Banner() {} // 0x00A4D920-0x00A4D980

		// Methods
		public void Init(GameObject root, magType type) {} // 0x00A4D980-0x00A4D9B0
	}

	private class BgWindow : UIWindowBase // TypeDefIndex: 7683
	{
		// Constructors
		public BgWindow() {} // 0x00A4D7B0-0x00A4D7C0
	}

	// Constructors
	public UITrainingBanner() {} // 0x00A4D9B0-0x00A4D9C0

	// Methods
	public static UITrainingBanner OpenTutorialBanner(Const.tutorial.Index tutorialIndex) => default; // 0x00A4CC90-0x00A4CCC0
	public static UITrainingBanner OpenTrainingBanner(Const.dungeon.Index dungeonIndex, UITraining.TicketInfoWindow.magType type) => default; // 0x00A4D0C0-0x00A4D100
	// [IteratorStateMachine] // 0x0062DEF0-0x0062DF60
	public IEnumerator Close(bool bTutorial) => default; // 0x00A4D4F0-0x00A4D570
	// [IteratorStateMachine] // 0x0062DF60-0x0062DFD0
	public IEnumerator Open(bool bTutorial) => default; // 0x00A4D5A0-0x00A4D620
	public static UITrainingBanner CreateBase() => default; // 0x00A4CCC0-0x00A4CE20
	public void Init(Const.tutorial.Index tutorialIndex) {} // 0x00A4CE20-0x00A4D0C0
	public void Init(Const.dungeon.Index dungeonIndex, UITraining.TicketInfoWindow.magType type) {} // 0x00A4D100-0x00A4D4F0
}

