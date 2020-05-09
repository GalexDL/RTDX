/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.account;
using nn.fs;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FileSystemManager : SingletonMonoBehaviour<FileSystemManager> // TypeDefIndex: 5506
{
	// Fields
	protected static bool initialized_; // 0x00
	private const string mountName_ = "PEGASUS"; // Metadata: 0x00611A6A
	private const string mountNameTrial_ = "PEGASUS_TRIAL"; // Metadata: 0x00611A75
	private const ulong trialApplicationID_ = 72128512801456128; // Metadata: 0x00611A86
	private bool bMountTrial_; // 0x18
	public UserHandle userHandle; // 0x20
	private Uid userId_; // 0x38
	private FileHandle fileHandle_; // 0x48

	// Properties
	public static bool Initialized { get => default; } // 0x0080F640-0x0080F6B0 
	public static bool SavingBinary { get; protected set; } // 0x0080F6B0-0x0080F720 0x0080F720-0x0080F790

	// Constructors
	public FileSystemManager() {} // 0x00810590-0x00810600
	static FileSystemManager() {} // 0x00810600-0x00810610

	// Methods
	public bool IsMountTrial() => default; // 0x0080F790-0x0080F7A0
	public void MountTrial() {} // 0x0080F7A0-0x0080F860
	public void UnmountTrial() {} // 0x0080F860-0x0080F8C0
	private void Awake() {} // 0x0080F8C0-0x0080FA60
	private void OnDestroy() {} // 0x0080FA60-0x0080FB10
	protected string GetFilepath(string filename, bool bTrial) => default; // 0x0080FB10-0x0080FB90
	public bool IsExist(string filename, bool bTrial = false /* Metadata: 0x00611A66 */) => default; // 0x0080FB90-0x0080FC70
	public bool Delete(string filename, bool bTrial = false /* Metadata: 0x00611A67 */) => default; // 0x0080FC70-0x0080FD60
	public byte[] LoadBinary(string filename, bool bTrial = false /* Metadata: 0x00611A68 */) => default; // 0x0080FD60-0x0080FF10
	public int LoadBinaryFromBuffer(string filename, byte[] buffer, bool bTrial = false /* Metadata: 0x00611A69 */) => default; // 0x0080FF10-0x008100A0
	public void BeginSaveBinary() {} // 0x008100A0-0x00810160
	public void EndSaveBinary() {} // 0x00810160-0x00810220
	public bool SaveBinary(string filename, byte[] data, int count, bool bCommit) => default; // 0x00810220-0x00810530
	public void SaveBinaryCommit() {} // 0x00810530-0x00810590
}

