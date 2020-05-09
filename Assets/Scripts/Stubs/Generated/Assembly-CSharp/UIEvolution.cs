/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIEvolution : UIManagerBase // TypeDefIndex: 6863
{
	// Fields
	private FlowEvolution flowInstance_; // 0x20
	public FiniteStateMachine<UIEvolution, States> FSM; // 0x28
	public bool bCancel_; // 0x30
	private GameObject mainObj_; // 0x38
	private CommonScreen common_; // 0x40
	private bool bInit_; // 0x48
	private Evo_PokemonSelectWindow pokemonSelectWindow_; // 0x50
	private EvolutionSelectWindow evolutionSelectWindow_; // 0x58
	private PokemonStatusTabWindow statusTabWindow_; // 0x60
	private Evo_Effect effect_; // 0x68
	private Evo_Ok okWindow_; // 0x70
	private EvolutionMultipleWindow evolutionMultipleWindow_; // 0x78

	// Properties
	public FlowEvolution FlowInstance { get => default; } // 0x00D6BC70-0x00D6BC80 
	public Evo_PokemonSelectWindow PokemonSelectWindow_ { get => default; } // 0x00D6C8D0-0x00D6C8E0 
	public EvolutionSelectWindow EvolutionSelectWindow_ { get => default; } // 0x00D6C8E0-0x00D6C8F0 
	public PokemonStatusTabWindow StatusTabWindow_ { get => default; } // 0x00D6C8F0-0x00D6C900 

	// Nested types
	public enum States // TypeDefIndex: 6864
	{
		PokemonSelect = 0,
		EvolutionSelect = 1,
		NickName = 2,
		End = 3
	}

	public class Evo_PokemonSelectWindow : PokemonWarehouseListWindow // TypeDefIndex: 6865
	{
		// Fields
		private UIEvolution manager_; // 0xC8
		private GameObject obj_; // 0xD0
		private List<IPokemonWarehouseStatus> nowList; // 0xD8
		private int closeCount_; // 0xE0

		// Nested types
		public class UIPokemonBasicSelector_Evo : PokemonListWindowBase.UIPokemonBasicSelector // TypeDefIndex: 6866
		{
			// Constructors
			public UIPokemonBasicSelector_Evo() {} // 0x00D71730-0x00D71740

			// Methods
			protected override void SetupFace() {} // 0x00D71B20-0x00D71D90
		}

		// Constructors
		public Evo_PokemonSelectWindow() {} // 0x00D6C370-0x00D6C380

		// Methods
		public virtual void Init(GameObject objRoot, UIEvolution manager, IPokemonWarehouseStatus status = null) {} // 0x00D6F6C0-0x00D6FA80
		public void UpdateFace() {} // 0x00D6FA80-0x00D6FCC0
		protected override void _changeFocus() {} // 0x00D6FCC0-0x00D6FCD0
		private void changeFocus_Local() {} // 0x00D6FCD0-0x00D6FE30
		protected override bool _doUp() => default; // 0x00D6FEB0-0x00D6FF20
		protected override bool _doDown() => default; // 0x00D6FF20-0x00D6FFA0
		protected override bool _doLeft() => default; // 0x00D6FFA0-0x00D70030
		protected override bool _doRight() => default; // 0x00D70030-0x00D700C0
		private void effectSetVisible(IPokemonStatus status) {} // 0x00D6FE30-0x00D6FEB0
		protected override bool _doDecide() => default; // 0x00D700C0-0x00D70350
		// [IteratorStateMachine] // 0x0064BD90-0x0064BE00
		public IEnumerator CloseAnim(Action cb) => default; // 0x00D70350-0x00D703D0
		protected override bool _doCancel() => default; // 0x00D70400-0x00D70540
		protected override bool _onXButton() => default; // 0x00D70540-0x00D70750
		protected override bool _onYButton() => default; // 0x00D70BA0-0x00D70C50
		public void SetButtonGuide() {} // 0x00D70C50-0x00D70D40
		protected override void ListUpdate() {} // 0x00D70D40-0x00D70D90
		public override List<IPokemonWarehouseStatus> SetDefaultList(int presetIndex = -1 /* Metadata: 0x006130F9 */) => default; // 0x00D70D90-0x00D71020
		public int GetListCount(bool bDefault) => default; // 0x00D6C850-0x00D6C8D0
		public override List<IPokemonWarehouseStatus> UniqueFilter(List<IPokemonWarehouseStatus> defaultList) => default; // 0x00D71020-0x00D71160
		protected override void FavorChange() {} // 0x00D71160-0x00D71220
		protected override int ComparePokemonWarehouseStatus(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x00D71220-0x00D71280
		public int CompareEvolution(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x00D71280-0x00D713B0
	}

	public class EvolutionSelectWindow : BasicListWindow // TypeDefIndex: 6869
	{
		// Fields
		private UIEvolution manager_; // 0x88

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6870
		{
			// Fields
			private PokemonInfo pokemon_; // 0x18

			// Properties
			public PokemonInfo Item { get => default; set {} } // 0x00D73B60-0x00D73B70 0x00D73B50-0x00D73B60

			// Constructors
			public UILocalSelectItem() {} // 0x00D73B30-0x00D73B40
		}

		public class PokemonInfo // TypeDefIndex: 6871
		{
			// Fields
			public Const.creature.Index index; // 0x10

			// Constructors
			public PokemonInfo() {} // 0x00D73B40-0x00D73B50
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6872
		{
			// Fields
			protected UIFixedFaceWindow faceWindow_; // 0x30

			// Constructors
			public UILocalSelector() {} // 0x00D739A0-0x00D73A10

			// Methods
			protected override void SetupFace() {} // 0x00D73B70-0x00D74620
		}

		// Constructors
		public EvolutionSelectWindow() {} // 0x00D6C380-0x00D6C390

		// Methods
		public virtual void Init(GameObject objRoot, UIEvolution manager) {} // 0x00D72DD0-0x00D73080
		protected override bool _doDecide() => default; // 0x00D73090-0x00D732D0
		protected override bool _doCancel() => default; // 0x00D732D0-0x00D733E0
		public void AllAlphaOff() {} // 0x00D733E0-0x00D736D0
	}

	private class Evo_Effect : UIWindowBase // TypeDefIndex: 6875
	{
		// Fields
		private GameObject obj_; // 0x30

		// Constructors
		public Evo_Effect() {} // 0x00D6C390-0x00D6C3A0

		// Methods
		public override void Init(GameObject root) {} // 0x00D6F330-0x00D6F340
		public void SetActive(bool b) {} // 0x00D6F340-0x00D6F350
		public void SetVisible(bool b) {} // 0x00D6F350-0x00D6F360
	}

	private class Evo_Ok : UIWindowBase // TypeDefIndex: 6876
	{
		// Fields
		private GameObject obj_; // 0x30

		// Constructors
		public Evo_Ok() {} // 0x00D6C3A0-0x00D6C3B0

		// Methods
		public void Init(GameObject root, UIEvolution manager) {} // 0x00D6F360-0x00D6F610
		public void NotVisible() {} // 0x00D6F610-0x00D6F6C0
	}

	private class EvolutionMultipleWindow : UIWindowBase // TypeDefIndex: 6877
	{
		// Fields
		private UIScrollView scScrollView_; // 0x30
		private GameObject objScrollContents_; // 0x38
		private float scrollContentsBasePosition_; // 0x40
		private float scrollContentsOffsetPosition_; // 0x44
		private float scrollContentsScale_; // 0x48
		private BasicListWindow listDetail_; // 0x50
		private UIEvolution manager_; // 0x58
		private GameObject obj_; // 0x60
		private List<PokemonItem> pokemonList; // 0x68
		private IPokemonStatus pokemon_; // 0x70
		private bool scrollPosSet; // 0x78

		// Nested types
		public class PokemonItem // TypeDefIndex: 6878
		{
			// Fields
			public int slotID; // 0x10
			public Const.creature.Index pokemonIndex; // 0x14
			public Const.item.Index itemIndex; // 0x18
			public int itemNum; // 0x1C
			public int level; // 0x20
			public bool canEvo; // 0x24

			// Constructors
			public PokemonItem() {} // 0x00D71D90-0x00D71DA0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6879
		{
			// Fields
			private PokemonItem item_; // 0x18

			// Properties
			public PokemonItem Item { get => default; set {} } // 0x00D72760-0x00D72770 0x00D72520-0x00D72530

			// Constructors
			public UILocalSelectItem() {} // 0x00D72510-0x00D72520
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 6880
		{
			// Fields
			public int level; // 0x2C
			public bool canEvo; // 0x30
			public Const.item.Index itemIndex; // 0x34
			public int itemNum; // 0x38

			// Constructors
			public UILocalSelector() {} // 0x00D72690-0x00D72700

			// Methods
			protected override void SetupFace() {} // 0x00D72770-0x00D72DD0
		}

		// Constructors
		public EvolutionMultipleWindow() {} // 0x00D6C3B0-0x00D6C420

		// Methods
		public void Init(GameObject obj, UIEvolution manager, IPokemonStatus pokemon, int defaultIndex = 0 /* Metadata: 0x006130FD */) {} // 0x00D70750-0x00D70BA0
		public void setTextPositionTop() {} // 0x00D71FE0-0x00D71FF0
		private void ScrollInit(int count) {} // 0x00D71DA0-0x00D71FE0
		private void _updateTextPosition(float pos) {} // 0x00D71FF0-0x00D720E0
		public override void Update() {} // 0x00D720E0-0x00D72140
		public void updateScrollView() {} // 0x00D72140-0x00D72210
		public void SetScrollActive(bool b) {} // 0x00D722E0-0x00D722F0
		protected void _doInput() {} // 0x00D72210-0x00D722E0
		protected bool _onXButton() => default; // 0x00D722F0-0x00D72440
	}

	public class StatePokemonSelect : FSMState<UIEvolution, States> // TypeDefIndex: 6882
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D74E50-0x00D74E60 

		// Constructors
		public StatePokemonSelect() {} // 0x00D6C420-0x00D6C470

		// Methods
		public override void Enter() {} // 0x00D74E60-0x00D754F0
		private void OpenCb() {} // 0x00D754F0-0x00D75620
		public override void Execute() {} // 0x00D75620-0x00D75680
	}

	public class StateEvolutionSelect : FSMState<UIEvolution, States> // TypeDefIndex: 6883
	{
		// Properties
		public override States StateID { get => default; } // 0x00D74660-0x00D74670 

		// Constructors
		public StateEvolutionSelect() {} // 0x00D6C470-0x00D6C4C0

		// Methods
		public override void Enter() {} // 0x00D74670-0x00D74920
		public override void Execute() {} // 0x00D74920-0x00D74960
		public override void Exit() {} // 0x00D74960-0x00D74970
	}

	public class StateNickNameMode : FSMState<UIEvolution, States> // TypeDefIndex: 6884
	{
		// Properties
		public override States StateID { get => default; } // 0x00D74990-0x00D749A0 

		// Constructors
		public StateNickNameMode() {} // 0x00D6C4C0-0x00D6C510

		// Methods
		public override void Enter() {} // 0x00D749A0-0x00D74CB0
		private void Temp(string s, bool result) {} // 0x00D74CC0-0x00D74D80
	}

	public class StateEnd : FSMState<UIEvolution, States> // TypeDefIndex: 6886
	{
		// Properties
		public override States StateID { get => default; } // 0x00D74620-0x00D74630 

		// Constructors
		public StateEnd() {} // 0x00D6C510-0x00D6C560

		// Methods
		public override void Enter() {} // 0x00D74630-0x00D74640
		public override void Execute() {} // 0x00D74640-0x00D74650
		public override void Exit() {} // 0x00D74650-0x00D74660
	}

	// Constructors
	public UIEvolution() {} // 0x00D6CB60-0x00D6CB70

	// Methods
	public static UIEvolution Create() => default; // 0x00D6BC80-0x00D6BF80
	public void Construct() {} // 0x00D6BF80-0x00D6C370
	public void Init(FlowEvolution instance, bool init) {} // 0x00D6C560-0x00D6C580
	// [IteratorStateMachine] // 0x00628770-0x006287E0
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00D6C580-0x00D6C600
	// [IteratorStateMachine] // 0x006287E0-0x00628850
	public override IEnumerator MainFlow() => default; // 0x00D6C630-0x00D6C6A0
	private void Update() {} // 0x00D6C6D0-0x00D6C730
	public void Continue() {} // 0x00D6C730-0x00D6C7A0
	public void PokemonList_SetDefaultList() {} // 0x00D6C7A0-0x00D6C7C0
	public void PokemonSelectWindow_ResetFilter() {} // 0x00D6C7C0-0x00D6C7D0
	public int PokemonListCount(bool bDefault) => default; // 0x00D6C7D0-0x00D6C850
	public void Update_StatusTabWidnow() {} // 0x00D6C900-0x00D6C9F0
	// [IteratorStateMachine] // 0x00628850-0x006288C0
	public IEnumerator OpenEvolutionParamInfo(IPokemonStatus status, Const.creature.Index afterIndex) => default; // 0x00D6C9F0-0x00D6CA70
	// [IteratorStateMachine] // 0x006288C0-0x00628930
	public IEnumerator CloseEvolutionParamInfo() => default; // 0x00D6CAA0-0x00D6CB10
	public int GetUpValue(int nowStatus, int upValue, bool hp = false /* Metadata: 0x006130E8 */) => default; // 0x00D6CB40-0x00D6CB60
}

