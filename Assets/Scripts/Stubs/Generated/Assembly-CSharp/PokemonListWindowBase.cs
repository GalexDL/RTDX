/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonListWindowBase : BasicListWindow // TypeDefIndex: 6293
{
	// Fields
	protected PokemonSortData pokemonSortData_; // 0x88
	protected List<IPokemonStatus> ignoreList_; // 0x90
	private bool bEnablePlusButtonCancel_; // 0x98

	// Nested types
	public class UIPokemonSelectItemBase : UISelectItem // TypeDefIndex: 6294
	{
		// Fields
		private bool bAttention_; // 0x20
		private bool bNew_; // 0x21
		private bool bookId; // 0x22

		// Properties
		public virtual IPokemonStatus PokemonStatus { get; set; } // 0x00C4B540-0x00C4B550 0x00C4B530-0x00C4B540
		public bool BookId { get => default; set {} } // 0x00C4B290-0x00C4B2A0 0x00C4B6E0-0x00C4B6F0

		// Constructors
		public UIPokemonSelectItemBase() {} // 0x00C47050-0x00C47060

		// Methods
		public override int GetSortKey(int mode) => default; // 0x00C4B550-0x00C4B560
		public virtual bool IsFavor() => default; // 0x00C4B560-0x00C4B5D0
		public virtual void SetFavor(bool bSet) {} // 0x00C4B5D0-0x00C4B5E0
		public virtual int GetOrganizationNo() => default; // 0x00C4B5E0-0x00C4B5F0
		public void SetAttention(bool bSet) {} // 0x00C4B5F0-0x00C4B600
		public virtual bool IsAttention() => default; // 0x00C4B600-0x00C4B610
		public void SetNew(bool bSet) {} // 0x00C4B610-0x00C4B620
		public virtual bool IsNew() => default; // 0x00C4B620-0x00C4B630
		public virtual int GetPokemonNameSetterId() => default; // 0x00C4B630-0x00C4B6D0
		public virtual Index GetFormChangeIndex() => default; // 0x00C4B6D0-0x00C4B6E0
		public virtual bool IsFormNameView() => default; // 0x00C4B6F0-0x00C4B700
		public virtual bool IsMega() => default; // 0x00C4B700-0x00C4B810
	}

	public class UIPokemonBasicSelector : UISelectorBase // TypeDefIndex: 6295
	{
		// Fields
		protected UIFixedFaceWindow faceWindow_; // 0x30
		private int currentItemId_; // 0x38
		private int nPlaying_; // 0x3C
		private bool bFavorite_; // 0x40
		private bool bSkipRequest_; // 0x41

		// Constructors
		public UIPokemonBasicSelector() {} // 0x00C45600-0x00C45670

		// Methods
		protected override void SetupFace() {} // 0x00C4A650-0x00C4B290
		public void VisibleIconFavorite(bool bVisible, bool bItemChange = false /* Metadata: 0x00612B85 */) {} // 0x00C499D0-0x00C49B00
		public void EffectFavoriteOn() {} // 0x00C497D0-0x00C499D0
		public void EffectFavoriteStop() {} // 0x00C4A590-0x00C4A5B0
		public bool IsEffectPlaying() => default; // 0x00C4A5B0-0x00C4A5C0
		private bool _IsSkip() => default; // 0x00C4B320-0x00C4B330
		// [IteratorStateMachine] // 0x006484F0-0x00648560
		private IEnumerator PlayEffectFavoriteOn(GameObject obj) => default; // 0x00C4B2A0-0x00C4B320
	}

	// Constructors
	public PokemonListWindowBase() {} // 0x00C45440-0x00C454B0

	// Methods
	protected void _checkIgnorePokemon(UIPokemonSelectItemBase item) {} // 0x00C45B40-0x00C45D80
	protected virtual bool _doFavorChange() => default; // 0x00C49620-0x00C497D0
	public void EnablePlusButtonCancel() {} // 0x00C49B00-0x00C49B10
	protected override bool _doDecide() => default; // 0x00C49B10-0x00C49B30
	protected override void _doInput() {} // 0x00C49B30-0x00C49C30
	protected virtual void FavorChange() {} // 0x00C49C30-0x00C49C40
	public IPokemonStatus GetCurrentStatus() => default; // 0x00C49C40-0x00C49CF0
	public Index GetCurrentFormChangeIndex() => default; // 0x00C49CF0-0x00C49DA0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00C49DA0-0x00C49FE0
	// [IteratorStateMachine] // 0x006258A0-0x00625910
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00C49FE0-0x00C4A060
}

