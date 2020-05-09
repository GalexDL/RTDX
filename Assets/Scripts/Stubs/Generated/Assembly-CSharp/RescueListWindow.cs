/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class RescueListWindow : BasicListWindow // TypeDefIndex: 7461
{
	// Nested types
	public enum CaptionType // TypeDefIndex: 7462
	{
		TRUST_QUEST = 0,
		BILLBOARD_QUEST = 1,
		NEWS = 2
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7463
	{
		// Fields
		private TicketListInfo item_; // 0x18

		// Properties
		public TicketListInfo Item { get => default; set {} } // 0x00828F00-0x00828F10 0x00828EF0-0x00828F00

		// Constructors
		public UILocalSelectItem() {} // 0x00828EE0-0x00828EF0
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 7464
	{
		// Constructors
		public UILocalSelector() {} // 0x00828DB0-0x00828E20

		// Methods
		protected override void SetupFace() {} // 0x00828F10-0x00828FB0
	}

	// Constructors
	public RescueListWindow() {} // 0x00828C60-0x00828C70

	// Methods
	public void Init(GameObject objRoot, List<TicketListInfo> list) {} // 0x00827450-0x008275E0
	public void SetCaption(CaptionType cap) {} // 0x008275F0-0x00827750
	protected override bool _doDecide() => default; // 0x00827750-0x00827760
	public static void DrawFaceRescue(GameObject face, TicketListInfo ticketInfo) {} // 0x00827760-0x00828BF0
}

