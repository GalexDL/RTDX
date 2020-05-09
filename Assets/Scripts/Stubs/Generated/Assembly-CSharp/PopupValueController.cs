/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using kamina.graphics;
using popup;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PopupValueController : SingletonMonoBehaviour<PopupValueController> // TypeDefIndex: 6056
{
	// Fields
	public GameObject experience1ketaPrefab; // 0x18
	public GameObject experience2ketaPrefab; // 0x20
	public GameObject experience3ketaPrefab; // 0x28
	public GameObject experience4ketaPrefab; // 0x30
	public GameObject experience5ketaPrefab; // 0x38
	public GameObject damageRed1ketaPrefab; // 0x40
	public GameObject damageRed2ketaPrefab; // 0x48
	public GameObject damageRed3ketaPrefab; // 0x50
	public GameObject damageRed4ketaPrefab; // 0x58
	public GameObject damageRed5ketaPrefab; // 0x60
	public GameObject damageYellow1ketaPrefab; // 0x68
	public GameObject damageYellow2ketaPrefab; // 0x70
	public GameObject damageYellow3ketaPrefab; // 0x78
	public GameObject damageYellow4ketaPrefab; // 0x80
	public GameObject damageYellow5ketaPrefab; // 0x88
	public GameObject heal1ketaPrefab; // 0x90
	public GameObject heal2ketaPrefab; // 0x98
	public GameObject heal3ketaPrefab; // 0xA0
	public GameObject heal4ketaPrefab; // 0xA8
	public GameObject heal5ketaPrefab; // 0xB0
	public GameObject missPrefab; // 0xB8
	public GameObject levelupPrefab; // 0xC0
	public GameObject levelupEnemyPrefab; // 0xC8
	public GameObject criticalPrefab; // 0xD0
	public GameObject greatePrefab; // 0xD8
	public GameObject experienceValuePrefab; // 0xE0
	public GameObject damageValuePrefab; // 0xE8
	public GameObject damageBigValuePrefab; // 0xF0
	public GameObject healValuePrefab; // 0xF8
	public GameObject countDownValuePrefab; // 0x100
	public GameObject kunrenjoExSmallPrefab; // 0x108
	public GameObject kunrenjoExBigPrefab; // 0x110
	public GameObject restTimerPrefab; // 0x118
	private GameObject rootObj_; // 0x120
	public float CharacterNodeOffsetY; // 0x128
	public float NumberOffsetY; // 0x12C
	public const float DefaultContinueOffsetY = 10f; // Metadata: 0x0061250B
	private List<PopupValue> aPopupValueList_; // 0x130
	private List<PopupValue> aPopupValueDestroyList_; // 0x138
	private Queue<GameObject> queDamageTrash_; // 0x140
	private Queue<GameObject> queMissTrash_; // 0x148
	private PopupRestTimer restTimer_; // 0x150

	// Properties
	public Transform Root { get => default; } // 0x009EDD00-0x009EDD10 

	// Constructors
	public PopupValueController() {} // 0x009EF430-0x009EF530

	// Methods
	public GameObject GetPrefab(popup.ValueType valueType, int value, int keta) => default; // 0x009ECB30-0x009ECBE0
	public GameObject GetDamageObjectFromTrash() => default; // 0x009EDA90-0x009EDB10
	public void AddDamageObjectToTrash(GameObject p) {} // 0x009EE0D0-0x009EE130
	public GameObject GetMissObjectFromTrash() => default; // 0x009EDB10-0x009EDB90
	public void AddMissObjectToTrash(GameObject p) {} // 0x009EE130-0x009EE190
	public bool IsOffsetNumberType(popup.ValueType type) => default; // 0x009EDA50-0x009EDA80
	public bool IsAutoOffset(popup.ValueType valueType) => default; // 0x009EDA80-0x009EDA90
	public float GetScale(popup.ValueType valueType) => default; // 0x009EDB90-0x009EDBB0
	public void CreatePopup(int value, popup.ValueType type, Vector3 v, float fDelay, float fContinueOffsetY) {} // 0x009EEE00-0x009EEED0
	public void CreatePopup(int value, popup.ValueType type, ModelBase parent, bool bAttach, float fDelay, float fContinueOffsetY) {} // 0x009EEED0-0x009EEF90
	public IPopupValue FindNewObject(ulong positionId) => default; // 0x009EDBB0-0x009EDD00
	public void PlayOpenRestTimer() {} // 0x009EEF90-0x009EEFF0
	public void PlayCloseRestTimer() {} // 0x009EEFF0-0x009EF050
	private void Start() {} // 0x009EF050-0x009EF130
	private void OnDestroy() {} // 0x009EF130-0x009EF1B0
	private void Update() {} // 0x009EF1B0-0x009EF430
}

