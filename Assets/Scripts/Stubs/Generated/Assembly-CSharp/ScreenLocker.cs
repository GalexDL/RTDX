/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RSG;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScreenLocker : SingletonMonoBehaviour<ScreenLocker> // TypeDefIndex: 5841
{
	// Fields
	public bool BackKeyDisabled; // 0x20
	public static bool LogEnabled; // 0x00
	private Stack<ModalInfo> modals_; // 0x28
	private List<Action> backKeyHandlers_; // 0x30
	private EventSystem eventSystem_; // 0x38

	// Properties
	public int lockCount_ { get; private set; } // 0x009CDB70-0x009CDB80 0x009CDB80-0x009CDB90
	public int lockCountTutorial_ { get; private set; } // 0x009CDB90-0x009CDBA0 0x009CDBA0-0x009CDBB0

	// Nested types
	public interface IModalEventHandler : IEventSystemHandler // TypeDefIndex: 5842
	{
		// Methods
		void OnModalOpen();
		void OnModalClose();
		void OnModalBackKeyPushed();
	}

	public class Option // TypeDefIndex: 5843
	{
		// Fields
		public bool FullModal; // 0x10
		public Color FilterColor; // 0x14
		public bool Animation; // 0x24
		public bool DestroyOnClose; // 0x25

		// Properties
		public static Option NONE { get => default; } // 0x009CF050-0x009CF0D0 
		public static Option FULL_MODAL { get => default; } // 0x009CF0D0-0x009CF170 
		public static Option ANIMATION_MODAL { get => default; } // 0x009CF8C0-0x009CF960 
		public static Option MODAL { get => default; } // 0x009CF960-0x009CFA00 

		// Constructors
		public Option() {} // 0x009CF8B0-0x009CF8C0
	}

	public class ModalInfo // TypeDefIndex: 5844
	{
		// Fields
		public Option Option; // 0x10
		public GameObject Obj; // 0x18
		public GameObject Target; // 0x20
		public Promise<ModalInfo> OnClose; // 0x28
		public object Result; // 0x30

		// Constructors
		public ModalInfo() {} // 0x009CE380-0x009CE390
	}

	// Constructors
	public ScreenLocker() {} // 0x009CF620-0x009CF6E0
	static ScreenLocker() {} // 0x009CF6E0-0x009CF6F0

	// Methods
	private void Awake() {} // 0x009CDBB0-0x009CDC30
	private void updateLock() {} // 0x009CDC30-0x009CE0D0
	private void DoLockForTutorial() {} // 0x009CE0D0-0x009CE0E0
	private void DoUnlockForTutorial() {} // 0x009CE0E0-0x009CE0F0
	private void DoLock() {} // 0x009CE0F0-0x009CE100
	private void DoUnlock() {} // 0x009CE100-0x009CE110
	public IPromise<ModalInfo> DoModal(GameObject target, Option opt) => default; // 0x009CE110-0x009CE380
	public void DoUnmodal() {} // 0x009CE390-0x009CE510
	public void DoUnlockAll() {} // 0x009CE510-0x009CE640
	private void doPushBackKeyHandler(Action callback) {} // 0x009CE640-0x009CE6A0
	private void doPopBackKeyHandler(Action callback) {} // 0x009CE6A0-0x009CE7B0
	private void Update() {} // 0x009CE7B0-0x009CE960
	public bool IsModaled() => default; // 0x009CEA30-0x009CEAB0
	public bool IsLocked() => default; // 0x009CE960-0x009CEA30
	public static void Lock() {} // 0x009CEAB0-0x009CEB30
	public static void Unlock() {} // 0x009CEB30-0x009CEBB0
	public static void LockForTutorial() {} // 0x009CEBB0-0x009CEC30
	public static void UnlockForTutorial(float delay = 0.2f /* Metadata: 0x00612049 */) {} // 0x009CEC30-0x009CEEB0
	public static IPromise<ModalInfo> Modal(GameObject obj = null, Option opt = null) => default; // 0x009CEEB0-0x009CF050
	public static void Unmodal(GameObject dummy = null) {} // 0x009CF170-0x009CF1E0
	public static void UnlockAll() {} // 0x009CF1E0-0x009CF250
	public static IPromise<ModalInfo> WaitForTap(string prefab = "system/WaitForTap" /* Metadata: 0x0061204D */) => default; // 0x009CF250-0x009CF4E0
	public static void PushBackKeyHandler(Action callback) {} // 0x009CF4E0-0x009CF5A0
	public static void PopBackKeyHandler(Action callback) {} // 0x009CF5A0-0x009CF620
}

