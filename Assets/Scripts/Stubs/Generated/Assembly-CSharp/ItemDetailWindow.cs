/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemDetailWindow : DetailWindowBase // TypeDefIndex: 6991
{
	// Fields
	private GameObject objItemThumb_; // 0x50
	private Image faceImageRef_; // 0x58
	private Image faceImageChangeRef_; // 0x60
	private UIFaceWindow faceWindow_; // 0x68
	private UIPokemonListMenu pokemonListMenu_; // 0x70
	private WazaStatusExplainWindow wazaDetailWindow_; // 0x78
	private string[] sAnimeToken; // 0x80
	private ThumbnailAnimeType thumbnailAnimeType_; // 0x88
	protected static ResourceCacheLimiter limitRes_; // 0x00
	private bool bRunning_; // 0x8C
	private bool bUpdateRequest_; // 0x8D
	private bool bUpdating_; // 0x8E
	private Index itemRequest_; // 0x90
	private ThumbnailAnimeType animeRequest_; // 0x94
	private bool bModeItemDetail_; // 0x98

	// Nested types
	private enum ThumbnailAnimeType // TypeDefIndex: 6992
	{
		Open = 0,
		Up = 1,
		Down = 2,
		Change = 3
	}

	// Constructors
	public ItemDetailWindow() {} // 0x008FC220-0x008FC430
	static ItemDetailWindow() {} // 0x008FC430-0x008FC440

	// Methods
	public static void CreateRes() {} // 0x008FB150-0x008FB230
	public static void ReleaseRes() {} // 0x008FB230-0x008FB2E0
	public override void Init(GameObject detail) {} // 0x008FB2E0-0x008FB680
	// [IteratorStateMachine] // 0x006291C0-0x00629230
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x008FB680-0x008FB700
	// [IteratorStateMachine] // 0x00629230-0x006292A0
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x008FB730-0x008FB7B0
	protected override void _doUpdate() {} // 0x008FB7E0-0x008FB840
	public void SetThumbnailAnimeType(ListWindowBase.ActionType act) {} // 0x008FB840-0x008FB890
	private void _updateFace(Index itemIndex, IPokemonStatus status = null) {} // 0x008FB890-0x008FBB90
	public void UpdateFace(Index itemIndex, IPokemonStatus status = null) {} // 0x008FBBA0-0x008FBCC0
	public void UpdateFace(IItem item, IPokemonStatus status = null) {} // 0x008FBCC0-0x008FBD40
	public void Start() {} // 0x008FBD40-0x008FBE40
	// [IteratorStateMachine] // 0x006292A0-0x00629310
	public IEnumerator WaitEnd() => default; // 0x008FBEB0-0x008FBF20
	private void _updateItemThumbnail(Index itemIndex, ThumbnailAnimeType animeType) {} // 0x008FBB90-0x008FBBA0
	// [IteratorStateMachine] // 0x00629310-0x00629380
	private IEnumerator SwitchImage(Sprite icon) => default; // 0x008FBF50-0x008FBFD0
	// [IteratorStateMachine] // 0x00629380-0x006293F0
	private IEnumerator MainLoop() => default; // 0x008FBE40-0x008FBEB0
	protected bool _getItemDetailMode() => default; // 0x008FC030-0x008FC040
	protected bool _setDetailMode(bool bReqMode, Kind kind = Kind.NONE /* Metadata: 0x00613235 */) => default; // 0x008FC040-0x008FC140
	public bool UpdateDetailMode(Kind kind) => default; // 0x008FC140-0x008FC150
	public bool ChangeDetailMode(Kind kind) => default; // 0x008FC150-0x008FC170
	// [IteratorStateMachine] // 0x006293F0-0x00629460
	public IEnumerator SwitchDetailView(Action cb = null) => default; // 0x008FC170-0x008FC1F0
}

