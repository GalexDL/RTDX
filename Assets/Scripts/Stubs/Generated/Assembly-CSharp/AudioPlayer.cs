/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class AudioPlayer // TypeDefIndex: 8045
{
	// Fields
	public static float DEFAULT_VOLUME; // 0x00
	private AudioSource sourceAudio; // 0x10
	public bool IsFade; // 0x18
	public float FadeInSeconds; // 0x1C
	private bool IsFadeInPlaying; // 0x20
	private bool IsFadeOutPlaying; // 0x21
	private double FadeOutSeconds; // 0x28
	private double FadeDeltaTime; // 0x30
	private string symbol_; // 0x38
	private MoveFloat moveBaseVolume_; // 0x40
	public bool IgnoreAdjustVolume; // 0x48
	private Type eType_; // 0x4C

	// Properties
	public Type AudioType { get => default; } // 0x00866160-0x00866170 
	public bool IsStopFadeOut { get => default; } // 0x00866C80-0x00866C90 

	// Nested types
	public enum Type // TypeDefIndex: 8046
	{
		BGM = 0,
		ENV = 1,
		ME = 2,
		SE = 3,
		VOICE = 4,
		MAX = 5
	}

	// Constructors
	public AudioPlayer() {} // Dummy constructor
	public AudioPlayer(Type eType) {} // 0x00866170-0x00866220
	static AudioPlayer() {} // 0x00866CA0-0x00866D00

	// Methods
	public void Initialize(AudioSource source) {} // 0x00866220-0x008662F0
	public void ChangeVolume(float fVolume, float fSec) {} // 0x008662F0-0x00866300
	public bool IsChangingVolume() => default; // 0x00866300-0x00866310
	public float GetVolume() => default; // 0x00866310-0x00866320
	public float GetVolumeRawForDebug() => default; // 0x00866320-0x008663C0
	public void Update() {} // 0x008663C0-0x008665C0
	private float CalcCurrentVolume_() => default; // 0x008665C0-0x00866670
	public void Play(string symbol, AudioClip clip, float fVolume, bool bLoop) {} // 0x00866670-0x00866810
	public void PlayFadeIn(string symbol, AudioClip clip, float fVolume, float fSec, bool bLoop) {} // 0x00866830-0x00866990
	public void PlayOneShot(string symbol, AudioClip clip, float fVolume) {} // 0x00866990-0x00866B00
	public bool IsPlaying() => default; // 0x00866820-0x00866830
	public string GetSymbol() => default; // 0x00866B00-0x00866B10
	public void Stop() {} // 0x00866810-0x00866820
	public void StopFadeOut(float fSec) {} // 0x00866B10-0x00866C80
	public void Pause() {} // 0x00866C90-0x00866CA0
}

