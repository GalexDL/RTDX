/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AutoMapConst;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class AutoMap : SingletonMonoBehaviour<AutoMap> // TypeDefIndex: 5941
{
	// Fields
	private static uint UNIQUE_ID_NONE; // 0x00
	private const int MAX_MONSTER = 64; // Metadata: 0x0061225D
	private const int MAX_ITEM = 256; // Metadata: 0x00612261
	private const int MAX_TRAP = 128; // Metadata: 0x00612265
	private const int MAX_STAIR = 8; // Metadata: 0x00612269
	private const int OFFSET_X = 32; // Metadata: 0x0061226D
	private const int OFFSET_Y = 32; // Metadata: 0x00612271
	private const int ICON_OFFSET_X = 32; // Metadata: 0x00612275
	private const int ICON_OFFSET_Y = 32; // Metadata: 0x00612279
	private List<IconObject> monsterIcons_; // 0x18
	private List<IconObject> itemIcons_; // 0x20
	private List<Sprite> monsterResourceIcons_; // 0x28
	private List<Sprite> itemResourceIcons_; // 0x30
	private RequestObject[] aMonsterRequestCoords_; // 0x38
	private RequestObject[] aItemRequestCoords_; // 0x40
	private int nMonsterRequestCoordsCount_; // 0x48
	private int nItemRequestCoordsCount_; // 0x4C
	private Color32[] pixelBuffer; // 0x50
	private const int MAP_PATTERN_SIZE = 4; // Metadata: 0x0061227D
	private PixelPatternType[] mapPatternBuffer_; // 0x58
	public GameObject objectCtrl_; // 0x60
	public GameObject mapIconPrefab_; // 0x68
	public GameObject imageObject_; // 0x70
	private Image image_; // 0x78
	public bool IsIconZoom_; // 0x80
	private Texture2D mapTexture_; // 0x88
	private Sprite mapSprite_; // 0x90
	private bool bVisible_; // 0x98
	private bool bMessageForceVisibleOff_; // 0x99
	private bool bEventForceVisibleOff_; // 0x9A
	private bool bDutyVisible_; // 0x9B
	[NonSerialized]
	public byte[,,] s_aPattern; // 0xA0
	[NonSerialized]
	public Color32[] s_aPatternPixel; // 0xA8
	private ViewMode viewMode_; // 0xB0
	private string[] sTokenViewMode; // 0xB8

	// Nested types
	public class RequestObject // TypeDefIndex: 5942
	{
		// Fields
		public Vector2 v; // 0x10
		public int type; // 0x18
		public uint uniqueId; // 0x1C
		public bool bRequest; // 0x20
		public bool bOngoing; // 0x21

		// Constructors
		public RequestObject() {} // 0x00868CE0-0x00868D90
	}

	public class IconObject // TypeDefIndex: 5943
	{
		// Fields
		public GameObject obj; // 0x10
		public Image image; // 0x18
		public int type; // 0x20
		private bool bAnimePlaying_; // 0x24
		private string sAnimePlaying_; // 0x28
		private string sAnimeRequest_; // 0x30

		// Constructors
		public IconObject() {} // Dummy constructor
		public IconObject(GameObject _obj, Image _image) {} // 0x00868D90-0x00868DE0

		// Methods
		public void StopAnimation() {} // 0x0086A400-0x0086A440
		public void PlayAnimation(string animName) {} // 0x0086A2D0-0x0086A400
		// [IteratorStateMachine] // 0x00646D70-0x00646DE0
		private IEnumerator _playAnimation() => default; // 0x0086B010-0x0086B080
		private void _resetView() {} // 0x0086AF20-0x0086B010
	}

	public enum ViewMode // TypeDefIndex: 5945
	{
		Normal = 0,
		Small = 1,
		Hide = 2
	}

	// Constructors
	public AutoMap() {} // 0x0086A9F0-0x0086AEC0
	static AutoMap() {} // 0x0086AEC0-0x0086AF20

	// Methods
	public static void Startup() {} // 0x008678F0-0x00867980
	public void Clear() {} // 0x00868500-0x00868660
	public void SetPixel(int x, int y, Color32 color) {} // 0x008686A0-0x00868750
	public void SetPattern(int x, int y, PixelPatternType ePattern) {} // 0x00868750-0x00868CE0
	public void Apply() {} // 0x00868660-0x008686A0
	public void Initialize() {} // 0x00867980-0x00868500
	private void Start() {} // 0x00869140-0x00869150
	private void OnDestroy() {} // 0x00869150-0x00869210
	public void SetVisible(bool bVisible) {} // 0x00869210-0x00869240
	public bool IsVisible() => default; // 0x00869240-0x00869250
	public void SetMessageVisibleOff(bool bEnable) {} // 0x00869250-0x00869270
	public void SetEventVisibleOff(bool bEnable) {} // 0x00869270-0x00869290
	private void UpdteVisible() {} // 0x00869290-0x008692F0
	public void SetViewMode(ViewMode mode) {} // 0x00868DE0-0x00868F80
	public ViewMode GetViewMode() => default; // 0x008692F0-0x00869300
	public void SetFilter(bool bEnable) {} // 0x00868F80-0x00869140
	public void SetGuideFrame(int x, int y, bool bEnable) {} // 0x00869300-0x00869610
	public void SetRequestMoster(int x, int y, int type, uint uniqueId) {} // 0x00869610-0x008697E0
	public void SetRequestItem(int x, int y, int type, uint uniqueId) {} // 0x008697E0-0x008699B0
	public void ClearRequestMonster() {} // 0x008699B0-0x008699C0
	public void ClearRequestItem() {} // 0x008699C0-0x008699D0
	private void Update() {} // 0x008699D0-0x0086A2D0
	public void SetIconAlpha(float icon_alpha) {} // 0x0086A440-0x0086A710
	public void SetIconScale(float icon_scale) {} // 0x0086A710-0x0086A9F0
}

