/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Language;
using TMPro;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIControlTMPBase<TextMeshProClass> : MonoBehaviour // TypeDefIndex: 6701
{
	// Fields
	private GenericPool genericPool_; // 0x00
	[TMPLabelEdit] // 0x00616AD0-0x00616AE0
	public string message; // 0x00
	public bool isLabel; // 0x00
	private TMP_Text TextComponent_; // 0x00
	public TMP_FontAsset rubiFontAsset; // 0x00
	public int rubiFontSize; // 0x00
	public Material rubiFontOptMaterial; // 0x00
	private GameObject rubiObj_; // 0x00
	private TMP_Text TextComponentRubi_; // 0x00
	private List<LinkSizeInfo> listLinkSizeInfo_; // 0x00
	private List<RubiInfo> listRubiInfo_; // 0x00
	private string rubiText_; // 0x00
	private bool rubiDirty_; // 0x00
	private float rubiCheckValue_; // 0x00
	private int visibleCharacters_; // 0x00
	private List<int> listLinkInfo_; // 0x00
	private bool bLinkGray_; // 0x00
	private string[] aJpFont_; // 0x00
	private string[] aOtherFont_; // 0x00
	private string[] aJpMaterial_; // 0x00
	private string[] aOtherMaterial_; // 0x00
	private static Language.Type currentLanguage_; // 0x00
	private Language.Type language_; // 0x00
	private string defaultFontName_; // 0x00
	private string defaultFontMaterial_; // 0x00
	private Func<ushort[], string> uint16ArrayToString; // 0x00
	private UIDictionary.TangoListWindow.WordItem linkitem_; // 0x00
	private LinkDrawType linkDrawType_; // 0x00
	private UIScrollView scrollView_; // 0x00
	private Vector2 sizeAdjust_JP; // 0x00
	private Vector2 sizeAdjust_Overseas; // 0x00
	private Vector2 posAdjust; // 0x00
	private LinkBgState linkBgState_; // 0x00
	private Dictionary<int, GameObject> objDictionary_; // 0x00

	// Properties
	public GenericPool GenericPool { get => default; }
	public bool bTextComplate { get => default; }
	private Vector2 sizeAdjust { get => default; }

	// Nested types
	private struct LinkSizeInfo // TypeDefIndex: 6702
	{
		// Fields
		public int startLinkIndex; // 0x00
		public int endLinkIndex; // 0x00
	}

	private class RubiInfo // TypeDefIndex: 6703
	{
		// Fields
		public int rubiWordIndex; // 0x00
		public int startKanjiIndex; // 0x00
		public int endKanjiIndex; // 0x00

		// Constructors
		public RubiInfo() {}
	}

	public enum LinkDrawType // TypeDefIndex: 6704
	{
		NONE = 0,
		MARK = 1,
		NONEMARK = 2
	}

	private enum FieldOverType // TypeDefIndex: 6705
	{
		none = 0,
		up = 1,
		down = 2
	}

	private enum LinkBgState // TypeDefIndex: 6706
	{
		None = 0,
		SetParent = 1,
		Draw = 2,
		Max = 3
	}

	// Constructors
	public UIControlTMPBase() {}
	static UIControlTMPBase() {}

	// Methods
	private void OnDestroy() {}
	public static void UpdateLanguage() {}
	protected bool CheckLanguage() => default;
	protected void Awake() {}
	private void Start() {}
	private void Update() {}
	private void LateUpdate() {}
	public void DrawUpdate() {}
	private static int HICODE(int x) => default;
	private static int LOCODE(int x) => default;
	private string ConvertText(string text) => default;
	public static ushort[] ReplaceNewLink(ushort[] szText, bool bRemoveTag) => default;
	public static string RemoveColorTag(string text) => default;
	public int DrawText(int textId) => default;
	public int DrawText(TextIDHash textIDHash) => default;
	public int DrawText_Dictionary(UIDictionary.TangoListWindow.WordItem item) => default;
	public int DrawText(string text, LinkDrawType type) => default;
	public int DrawText(string text) => default;
	public void ClearText() {}
	public Vector2 GetPrefferdValues() => default;
	public Vector2 GetPrefferdValues(uint textId) => default;
	public Vector2 GetPrefferdValues(string text) => default;
	public int GetTextLineCount(string text) => default;
	public TMP_Text GetTMP_Tex(string text) => default;
	public void SetVisibleCharacers(int count) {}
	public Vector3 GetLastCharacterPosition() => default;
	public float GetCharacterLeftPos(string text, int index) => default;
	public float GetCharacterRightPos(string text, int index) => default;
	public float GetCharacterCenterPos(string text, int index) => default;
	public void SetPermeability(int nPermeability) {}
	private void _rubiInitialize() {}
	private void _rubiUpdate() {}
	private void _rubiItemClear() {}
	private void _rubiItemAdd(RubiInfo item) {}
	private void _rubiItemRelocation(RubiInfo item) {}
	private float _getRubiCheckValue(RubiInfo item) => default;
	private List<LinkSizeInfo> GetViewLinkSizeInfo(List<LinkSizeInfo> originalList) => default;
	private FieldOverType IsFieldOfView(LinkSizeInfo sizeInfo) => default;
	private List<int> GetViewLinkMessageInfo(List<LinkSizeInfo> originalSizeList, List<int> originalMessageList) => default;
	public UILinkFocus.LinkFocusData GetLinkVector(int index, bool focus, bool bFieldOfViewOnly = false /* Metadata: 0x00612FA3 */) => default;
	private UILinkFocus.LinkFocusData GetLinkFocusSize(LinkSizeInfo linkSizeInfo, bool focus) => default;
	private void ResetLinkBgState() {}
	private void LinkBgUpdate() {}
	public bool CheckLinkDraw() => default;
	public void SetLinkGrayFlag(bool flag) {}
	public bool GetLinkGrayFlag() => default;
	public int GetLinkCount() => default;
	public int GetAllLinkCount() => default;
	private bool IsFieldOfView(int index) => default;
	public void ScAdjust(int index) {}
	public int GetLinkedMessage(int index) => default;
	public Rect GetLinkedRect(int index) => default;
	public void SetScrollInstance(UIScrollView scrollview) {}
}

