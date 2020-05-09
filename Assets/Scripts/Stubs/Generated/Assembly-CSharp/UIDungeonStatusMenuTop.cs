/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonStatusMenuTop : UIManagerBase // TypeDefIndex: 6846
{
	// Fields
	private SelectPartyMenuWindow partySelectMenu_; // 0x20
	private SelectCompanionMenuWindow guestSelectMenu_; // 0x28
	private SideChanger sideChanger_; // 0x30
	private CommonScreen commonScreen_; // 0x38
	private bool bCommonClose; // 0x40
	private ActionType act_; // 0x44
	private List<IPokemonStatus> listParty_; // 0x48
	private List<IPokemonStatus> listGuests_; // 0x50
	private IPokemonStatus selectCreature_; // 0x58
	protected static GameObject regidentObj_; // 0x00

	// Nested types
	public class SelectPartyStatusFace : UIWindowBase // TypeDefIndex: 6847
	{
		// Fields
		protected UIFaceWindow faceWindow_; // 0x30
		protected RenketsuWazaListWindow wazaListWindow_; // 0x38

		// Constructors
		public SelectPartyStatusFace() {} // 0x00D6A540-0x00D6A550

		// Methods
		public override void Init(GameObject root) {} // 0x00D6A870-0x00D6AA20
		protected void setFaceIcon_(Const.creature.Index pokemonIndex, bool bFemale, Const.sugowaza.Index sugowazaIndex, UIFaceWindow.StateIconType stateIcon) {} // 0x00D6AA20-0x00D6ABC0
		protected void activeFaceIcon_(bool bActive) {} // 0x00D6ABC0-0x00D6AC80
		public virtual void UpdateFace(IPokemonStatus status) {} // 0x00D6AC80-0x00D6B730
	}

	private class SelectPartyMenuWindow : BasicMenuWindow // TypeDefIndex: 6848
	{
		// Fields
		private static string[] sSelectToken; // 0x00
		private static string[] sOrganizationNoToken; // 0x08
		private int focusId_; // 0x44

		// Constructors
		public SelectPartyMenuWindow() {} // 0x00D67850-0x00D67860
		static SelectPartyMenuWindow() {} // 0x00D6A580-0x00D6A870

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D69F70-0x00D6A000
		public static void OnConstruct(GameObject root) {} // 0x00D67470-0x00D675E0
		public virtual void Init(GameObject root, List<IPokemonStatus> list) {} // 0x00D6A000-0x00D6A540
		protected override bool _doLeft() => default; // 0x00D6A550-0x00D6A560
		protected override bool _doRight() => default; // 0x00D6A560-0x00D6A580
	}

	public class SelectCompanionStatusFace : UIWindowBase // TypeDefIndex: 6849
	{
		// Fields
		protected UIFaceWindow faceWindow_; // 0x30

		// Constructors
		public SelectCompanionStatusFace() {} // 0x00D68DB0-0x00D68DC0

		// Methods
		public override void Init(GameObject root) {} // 0x00D68DC0-0x00D68F50
		protected void setFaceIcon_(Const.creature.Index pokemonIndex, bool bFemale, Const.sugowaza.Index sugowazaIndex, UIFaceWindow.StateIconType stateIcon, bool bCompanion) {} // 0x00D68F50-0x00D69180
		protected void activeFaceIcon_(bool bActive) {} // 0x00D69180-0x00D69240
		public virtual void UpdateFace(IPokemonStatus status) {} // 0x00D69280-0x00D69F70
	}

	private class SelectCompanionMenuWindow : BasicMenuWindow // TypeDefIndex: 6850
	{
		// Fields
		private string[] sSelectToken; // 0x48
		private int focusId_; // 0x50

		// Constructors
		public SelectCompanionMenuWindow() {} // 0x00D67860-0x00D67C10

		// Methods
		protected override bool _setEnable(bool bEnable) => default; // 0x00D68930-0x00D689C0
		protected override bool _doLeft() => default; // 0x00D689C0-0x00D68A30
		protected override bool _doRight() => default; // 0x00D68A30-0x00D68A90
		public override bool IsValid() => default; // 0x00D68A90-0x00D68AF0
		public virtual void Init(GameObject root, List<IPokemonStatus> list) {} // 0x00D68AF0-0x00D68DB0
	}

	public class SideChanger : UIWindowBase // TypeDefIndex: 6851
	{
		// Fields
		private UIWindowBase leftSide_; // 0x30
		private UIWindowBase rightSide_; // 0x38
		private BasicPageControlWindow pageControl_; // 0x40
		private bool bLeftSide_; // 0x48

		// Constructors
		public SideChanger() {} // 0x00D67C10-0x00D67C20

		// Methods
		public bool IsLeftSide() => default; // 0x00D67C30-0x00D67C40
		public virtual void Init(GameObject root, UIWindowBase leftSide, UIWindowBase rightSide) {} // 0x00D6B730-0x00D6B940
		public virtual void OnStart() {} // 0x00D6B940-0x00D6B9C0
		protected virtual bool _doRButton() => default; // 0x00D6B9C0-0x00D6BB10
		protected virtual bool _doLButton() => default; // 0x00D6BB10-0x00D6BC30
		public bool ChangeRightPage() => default; // 0x00D68150-0x00D681D0
		public bool ChangeLeftPage() => default; // 0x00D684D0-0x00D68530
	}

	public enum ActionType // TypeDefIndex: 6852
	{
		None = 0,
		Cancel = 1,
		Decide = 2
	}

	// Constructors
	public UIDungeonStatusMenuTop() {} // 0x00D685A0-0x00D685B0
	static UIDungeonStatusMenuTop() {} // 0x00D685B0-0x00D685C0

	// Methods
	public static GameObject CreateRegident() => default; // 0x00D672C0-0x00D67470
	public static void DestroyRegident() {} // 0x00D675E0-0x00D67770
	public static UIDungeonStatusMenuTop Create() => default; // 0x00D665C0-0x00D666E0
	public void Construct() {} // 0x00D67770-0x00D67850
	public void Destruct() {} // 0x00D663D0-0x00D66470
	public IPokemonStatus GetSelectStatus() => default; // 0x00D671E0-0x00D671F0
	public bool IsSelectParty() => default; // 0x00D67C20-0x00D67C30
	public bool IsSelectGuest() => default; // 0x00D671F0-0x00D67210
	public static bool IsCompanion(ICreature creature) => default; // 0x00D632B0-0x00D63370
	public void Init() {} // 0x00D66760-0x00D66DC0
	public void SetCommonClose() {} // 0x00D66DC0-0x00D66DD0
	// [IteratorStateMachine] // 0x00628640-0x006286B0
	public virtual IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00D67C40-0x00D67CC0
	public virtual void Continue() {} // 0x00D67CF0-0x00D67D30
	private void _cbFromSelectPartyMenu(ListWindowBase.ActionType act) {} // 0x00D67D30-0x00D68150
	private void _cbFromSelectGuestMenu(ListWindowBase.ActionType act) {} // 0x00D681D0-0x00D684D0
	private void Start() {} // 0x00D68530-0x00D68540
	private void Update() {} // 0x00D68540-0x00D685A0
}

