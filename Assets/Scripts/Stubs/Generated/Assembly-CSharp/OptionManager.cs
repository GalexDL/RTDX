/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class OptionManager : Singleton<OptionManager> // TypeDefIndex: 5816
{
	// Fields
	public static int[] VolumeTableBGM; // 0x00
	public static int[] VolumeTableSE; // 0x08
	private int[] optionValue; // 0x10
	public readonly int[] defaultValue; // 0x18
	private int nOptWalkSpeed; // 0x20
	private int nOptAutoDash; // 0x24

	// Nested types
	public enum Kind // TypeDefIndex: 5817
	{
		None = -1,
		VolumeBGM = 0,
		VolumeSE = 1,
		GridDisp = 2,
		WalkSpeed = 3,
		CameraEffect = 4,
		DamageRotation = 5,
		ItemAuto = 6,
		AutoDash = 7,
		HungryDash = 8,
		ShortcutL = 9,
		ShortcutR = 10,
		ShortcutUp = 11,
		ShortcutDown = 12,
		ShortcutLeft = 13,
		ShortcutRight = 14,
		DungeonMap = 15,
		ActionButtonRole = 16,
		AI_StairDiscovery = 17,
		NumKind = 18
	}

	public enum Shortcut // TypeDefIndex: 5818
	{
		None = 0,
		AutoMode = 1,
		Item = 2,
		Status = 3,
		Quest = 4,
		Waza = 5,
		Order = 6,
		Leader = 7,
		Log = 8,
		Look = 9,
		Foot = 10,
		Manual = 11,
		MapView = 12,
		DungeonStatus = 13,
		RemovePartyMember = 14,
		NumShortcut = 15
	}

	[Serializable]
	public class SaveData // TypeDefIndex: 5819
	{
		// Fields
		public int[] saveOptionValue; // 0x10

		// Constructors
		public SaveData() {} // 0x00785C20-0x00785CA0

		// Methods
		public void OnPreSave() {} // 0x00785CA0-0x00785DB0
		public void OnAfterLoad() {} // 0x00785DB0-0x00785FD0
	}

	// Constructors
	public OptionManager() {} // 0x00785A80-0x00785B60
	static OptionManager() {} // 0x00785B60-0x00785C20

	// Methods
	public static float GetVolumeBGM(int no) => default; // 0x007852C0-0x00785370
	public static float GetVolumeSE(int no) => default; // 0x00785370-0x00785420
	public int GetValue(Kind kind) => default; // 0x00785420-0x00785470
	public void SetValue(Kind kind, int val) {} // 0x00785470-0x00785850
	public void SetDefaultValue() {} // 0x007858D0-0x00785990
	private void UpdateNativeValue(Kind kind, int val) {} // 0x00785850-0x007858D0
	public void PushTrainingOption() {} // 0x00785990-0x00785A20
	public void SetTrainingOption(Kind kind, int nValue) {} // 0x00785A20-0x00785A40
	public void PopTrainingOption() {} // 0x00785A40-0x00785A80
}

