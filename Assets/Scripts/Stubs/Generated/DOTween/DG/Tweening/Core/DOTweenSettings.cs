/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 37: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3552-3637

namespace DG.Tweening.Core
{
	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 3623
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x0060FA56
		public bool useSafeMode; // 0x18
		public float timeScale; // 0x1C
		public bool useSmoothDeltaTime; // 0x20
		public float maxSmoothUnscaledTime; // 0x24
		public bool showUnityEditorReport; // 0x28
		public LogBehaviour logBehaviour; // 0x2C
		public bool drawGizmos; // 0x30
		public bool defaultRecyclable; // 0x31
		public AutoPlay defaultAutoPlay; // 0x34
		public UpdateType defaultUpdateType; // 0x38
		public bool defaultTimeScaleIndependent; // 0x3C
		public Ease defaultEaseType; // 0x40
		public float defaultEaseOvershootOrAmplitude; // 0x44
		public float defaultEasePeriod; // 0x48
		public bool defaultAutoKill; // 0x4C
		public LoopType defaultLoopType; // 0x50
		public SettingsLocation storeSettingsLocation; // 0x54
	
		// Nested types
		public enum SettingsLocation // TypeDefIndex: 3624
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		// Constructors
		public DOTweenSettings() {} // 0x004C89E0-0x004C8A30
	}
}
