/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SoundSystem : SingletonMonoBehaviour<SoundSystem>, ISound // TypeDefIndex: 5486
{
	// Fields
	private const float DEFAULT_FADEIN_SEC = 0f; // Metadata: 0x00611A26
	private const float DEFAULT_FADEOUT_SEC = 0.25f; // Metadata: 0x00611A2A
	private const int MAX_POOL_BGM = 7; // Metadata: 0x00611A2E
	private const int MAX_POOL_SE = 64; // Metadata: 0x00611A32
	private const int SE_CHANNEL = 8; // Metadata: 0x00611A36
	private const int VOICE_CHANNEL = 4; // Metadata: 0x00611A3A
	private float ME_CHANGE_SEC; // 0x18
	private AudioPlayer[] _aSourceBgm; // 0x20
	private AudioPlayer[] _aSourceEnv; // 0x28
	private AudioPlayer _sourceMe; // 0x30
	private AudioPlayer[] _sourceSeArray; // 0x38
	private AudioPlayer _sourceVoiceDefault; // 0x40
	private AudioPlayer[] _sourceVoiceArray; // 0x48
	private MoveFloat _AllVolume; // 0x50
	private MoveFloat[] _aAdjustVolume; // 0x58
	private MoveFloat[] _aMasterAdjustVolume; // 0x60
	private List<AudioPlayer> _aPlayer; // 0x68
	private ILog _log; // 0x70
	private bool _bPlayMe; // 0x78
	private Dictionary<string, _Data> _poolBgmMusic; // 0x80
	private int _poolBgmMusicLoadingCount; // 0x88
	private Dictionary<string, _Data> _poolSe; // 0x90
	private Dictionary<string, _Data> _poolVoice; // 0x98
	private Dictionary<int, string> _nativePool; // 0xA0
	private List<uint> _aCheckRemoveSe; // 0xA8
	private Dictionary<uint, float> _aCheckUpdateSe; // 0xB0
	private Dictionary<uint, float> _aCheckSe; // 0xB8
	private int _voiceCounter; // 0xC0

	// Properties
	public float AllVolume { get => default; } // 0x00907A50-0x00907A60 

	// Nested types
	public interface ILog // TypeDefIndex: 5487
	{
		// Methods
		void AddLog(string log);
	}

	private enum Kind // TypeDefIndex: 5488
	{
		BGM = 0,
		ENV = 1,
		ME = 2,
		SE = 3,
		VOICE = 4
	}

	private class _Data // TypeDefIndex: 5489
	{
		// Fields
		public string Key; // 0x10
		public string ResName; // 0x18
		public string BundleName; // 0x20
		public AudioClip Clip; // 0x28
		public float LastTime; // 0x30
		public List<AudioPlayer> RefAudioPlayerList; // 0x38
		public bool bCacheBundle; // 0x40

		// Properties
		public bool IsLoop { get => default; } // 0x0090C4C0-0x0090C570 

		// Constructors
		public _Data() {} // Dummy constructor
		public _Data(string key, string bundleName, string res) {} // 0x0090BFD0-0x0090C110

		// Methods
		public void UpdateLastTime() {} // 0x0090A4F0-0x0090A520
		public void Release() {} // 0x0090A530-0x0090A610
	}

	// Constructors
	public SoundSystem() {} // 0x00907C60-0x00907E40

	// Methods
	public float GetAdjustVolume(AudioPlayer.Type type) => default; // 0x00907A60-0x00907B00
	public void SetMasterAdjustVolume(AudioPlayer.Type type, float vol) {} // 0x00907B00-0x00907B60
	public float GetMasterAdjustVolume(AudioPlayer.Type type) => default; // 0x00907B60-0x00907BB0
	public static bool IsLoopSe(string key) => default; // 0x00907BB0-0x00907C60
	private void Start() {} // 0x00907E40-0x00908760
	private void Update() {} // 0x00908760-0x00908E20
	public void SetLogInterface(ILog log) {} // 0x00908E30-0x00908E40
	public void AddLog(string log) {} // 0x00908E40-0x00908EC0
	public void Register(AudioPlayer player) {} // 0x00908EC0-0x00908F20
	public void Unregister(AudioPlayer player) {} // 0x00908F20-0x00908F80
	private AudioPlayer _GetAudioPlayer(Kind type, int channel = -1 /* Metadata: 0x00611A12 */) => default; // 0x00908F80-0x00909450
	public void Load(string key) {} // 0x00909450-0x00909460
	public void LoadFromNative(string key) {} // 0x00909460-0x00909470
	public bool IsBgmSymbol(string key) => default; // 0x00909470-0x009094E0
	public bool IsSeSymbol(string key) => default; // 0x009094E0-0x00909550
	public bool IsMeSymbol(string key) => default; // 0x00909550-0x009095C0
	public bool IsVoiceSymbol(string key) => default; // 0x009095C0-0x00909630
	public void PreLoadBgm(string key, Action endCb) {} // 0x00909630-0x009096E0
	public bool PlayBgm(string key, BGMChannel channel, float fSec = 0f /* Metadata: 0x00611A16 */) => default; // 0x00909F20-0x00909FD0
	public bool PlayBgm(string key, BGMChannel channel, float fVolume, float fSec = 0f /* Metadata: 0x00611A1A */) => default; // 0x00909FD0-0x0090A000
	public bool PlayBgmLoopNone(string key, BGMChannel channel, float fVolume, float fSec = 0f /* Metadata: 0x00611A1E */) => default; // 0x0090A160-0x0090A190
	public void PreLoadEnv(string key, Action endCb) {} // 0x0090A190-0x0090A240
	public bool PlayEnv(string key, ENVChannel channel, float fVolume, float fSec) => default; // 0x0090A250-0x0090A280
	public bool PlayEnv(string key, ENVChannel channel, float fSec) => default; // 0x0090A280-0x0090A330
	public void PreLoadMe(string key, Action endCb) {} // 0x0090A330-0x0090A3E0
	public bool PlayMe(string key) => default; // 0x0090A3F0-0x0090A490
	public bool PlayMe(string key, float fVolume) => default; // 0x0090A490-0x0090A4C0
	public bool PlayVoice(string key) => default; // 0x0090A4C0-0x0090A4D0
	public bool PlayVoice(string key, float fVolume) => default; // 0x0090A4D0-0x0090A4E0
	private bool _PlayBgmCore(Kind kind, string key, int channel, float fVolume, float fSec, bool bLoop) => default; // 0x0090A000-0x0090A160
	private void _LoadBgm(Kind kind, string key, Action endCb) {} // 0x009096F0-0x00909F20
	public string GetPlayBgmKey(BGMChannel channel) => default; // 0x0090A610-0x0090A730
	public string GetPlayEnvKey(ENVChannel channel) => default; // 0x0090A7D0-0x0090A8F0
	public string GetPlayMeKey() => default; // 0x0090A8F0-0x0090A960
	private string _GetPlayBgmKey(Kind kind, int channel) => default; // 0x0090A730-0x0090A7D0
	public bool IsPlayBgm(BGMChannel channel) => default; // 0x0090A960-0x0090A9D0
	public bool IsAllPlayBgm() => default; // 0x0090A9D0-0x0090AA60
	public bool IsPlayEnv(ENVChannel channel) => default; // 0x0090AA60-0x0090AAD0
	public bool IsAllPlayEnv() => default; // 0x0090AAD0-0x0090AB60
	public bool IsAllPlayMe() => default; // 0x00908E20-0x00908E30
	private void _ChangeAllVolume(Kind kind, int channel, float fVolume, float fSec) {} // 0x0090AB60-0x0090AB90
	public void ChangeAllBgmVolume(float fVolume, float fSec) {} // 0x0090AB90-0x0090AC20
	public void ChangeAllEnvVolume(float fVolume, float fSec) {} // 0x0090AC20-0x0090ACB0
	public void ChangeBgmVolume(BGMChannel channel, float fVolume, float fSec) {} // 0x0090ACB0-0x0090AD40
	public bool IsChangingBgmVolume(BGMChannel channel) => default; // 0x0090AD40-0x0090ADB0
	public void ChangeEnvVolume(ENVChannel channel, float fVolume, float fSec) {} // 0x0090ADB0-0x0090AE40
	public bool IsChangingEnvVolume(ENVChannel channel) => default; // 0x0090AE40-0x0090AEB0
	public void ChangeSeVolume(string key, float fVolume, float fSec) {} // 0x0090AEB0-0x0090B210
	public void StopBgmFromNative(BGMChannel channel, float fSec) {} // 0x0090B210-0x0090B220
	public void StopBgm(BGMChannel channel, float fSec = 0.25f /* Metadata: 0x00611A22 */) {} // 0x0090B220-0x0090B2D0
	public bool IsStopFadeoutBgm(BGMChannel channel) => default; // 0x0090B310-0x0090B380
	public void StopEnv(ENVChannel channel, float fSec) {} // 0x0090B380-0x0090B430
	public bool IsStopFadeoutEnv(ENVChannel channel) => default; // 0x0090B430-0x0090B4A0
	public void StopMe() {} // 0x0090B4A0-0x0090B4B0
	public void StopVoice() {} // 0x0090B4B0-0x0090B4C0
	private void _Stop(Kind kind, int channel, float fSec) {} // 0x0090B2D0-0x0090B310
	public void ClearPoolSe() {} // 0x0090B4C0-0x0090B610
	public bool LoadSe(string key) => default; // 0x0090B610-0x0090B6C0
	private bool LoadSeCore(string key, string bundle) => default; // 0x0090B6C0-0x0090B9C0
	public bool PlaySe(string key) => default; // 0x0090C110-0x0090C1A0
	public bool PlaySe(string key, float fVolume, float fSec) => default; // 0x0090C420-0x0090C430
	public bool PlaySe_withoutMeFade(string key) => default; // 0x0090C430-0x0090C4C0
	private bool _PlaySe(string key, int channel, float fVolume, float fSec, bool bIgnoreAdjustVolume) => default; // 0x0090C1A0-0x0090C420
	public bool IsPlaySe(string key) => default; // 0x0090C570-0x0090C7D0
	public void StopSe(string key, float fSec) {} // 0x0090B9C0-0x0090BFD0
	// [IteratorStateMachine] // 0x00620390-0x00620400
	public IEnumerator PlaySe_Sync(string key, Action<bool> cb) => default; // 0x0090C7D0-0x0090C850
	private string GetVoiceKeyToBundleName(string key) => default; // 0x0090C880-0x0090C930
	private bool _PlayVoice(string key, float fVolume, float fSec) => default; // 0x0090C930-0x0090CA40
	public bool IsPlayVoice(string key) => default; // 0x0090CA40-0x0090CB90
	public void StopVoice(string key, float fSec) {} // 0x0090CB90-0x0090CEB0
	public void ChannelSwapBgm(BGMChannel a, BGMChannel b) {} // 0x0090CEB0-0x0090D020
	public void ChannelSwapEnv(ENVChannel a, ENVChannel b) {} // 0x0090D020-0x0090D190
	public void AllStop() {} // 0x0090D190-0x0090D390
	public void AllFadeout(float fSec) {} // 0x0090D390-0x0090D5B0
}

