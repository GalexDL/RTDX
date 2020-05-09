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

public class iTween : MonoBehaviour // TypeDefIndex: 6095
{
	// Fields
	public static List<Hashtable> tweens; // 0x00
	private static GameObject cameraFade; // 0x08
	public string id; // 0x18
	public string type; // 0x20
	public string method; // 0x28
	public EaseType easeType; // 0x30
	public float time; // 0x34
	public float delay; // 0x38
	public LoopType loopType; // 0x3C
	public bool isRunning; // 0x40
	public bool isPaused; // 0x41
	public string _name; // 0x48
	private float runningTime; // 0x50
	private float percentage; // 0x54
	private float delayStarted; // 0x58
	private bool kinematic; // 0x5C
	private bool isLocal; // 0x5D
	private bool loop; // 0x5E
	private bool reverse; // 0x5F
	private bool wasPaused; // 0x60
	private bool physics; // 0x61
	private Hashtable tweenArguments; // 0x68
	private Space space; // 0x70
	private EasingFunction ease; // 0x78
	private ApplyTween apply; // 0x80
	private AudioSource audioSource; // 0x88
	private Vector3[] vector3s; // 0x90
	private Vector2[] vector2s; // 0x98
	private Color[,] colors; // 0xA0
	private float[] floats; // 0xA8
	private Rect[] rects; // 0xB0
	private CRSpline path; // 0xB8
	private Vector3 preUpdate; // 0xC0
	private Vector3 postUpdate; // 0xCC
	private NamedValueColor namedcolorvalue; // 0xD8
	private float lastRealTime; // 0xDC
	private bool useRealTime; // 0xE0
	private Transform thisTransform; // 0xE8

	// Nested types
	private delegate float EasingFunction(float start, float end, float Value); // TypeDefIndex: 6096; 0x00B7BA20-0x00B7C110

	private delegate void ApplyTween(); // TypeDefIndex: 6097; 0x00B7AFF0-0x00B7B360

	public enum EaseType // TypeDefIndex: 6098
	{
		easeInQuad = 0,
		easeOutQuad = 1,
		easeInOutQuad = 2,
		easeInCubic = 3,
		easeOutCubic = 4,
		easeInOutCubic = 5,
		easeInQuart = 6,
		easeOutQuart = 7,
		easeInOutQuart = 8,
		easeInQuint = 9,
		easeOutQuint = 10,
		easeInOutQuint = 11,
		easeInSine = 12,
		easeOutSine = 13,
		easeInOutSine = 14,
		easeInExpo = 15,
		easeOutExpo = 16,
		easeInOutExpo = 17,
		easeInCirc = 18,
		easeOutCirc = 19,
		easeInOutCirc = 20,
		linear = 21,
		spring = 22,
		easeInBounce = 23,
		easeOutBounce = 24,
		easeInOutBounce = 25,
		easeInBack = 26,
		easeOutBack = 27,
		easeInOutBack = 28,
		easeInElastic = 29,
		easeOutElastic = 30,
		easeInOutElastic = 31,
		punch = 32
	}

	public enum LoopType // TypeDefIndex: 6099
	{
		none = 0,
		loop = 1,
		pingPong = 2
	}

	public enum NamedValueColor // TypeDefIndex: 6100
	{
		_Color = 0,
		_SpecColor = 1,
		_Emission = 2,
		_ReflectColor = 3
	}

	public static class Defaults // TypeDefIndex: 6101
	{
		// Fields
		public static float time; // 0x00
		public static float delay; // 0x04
		public static NamedValueColor namedColorValue; // 0x08
		public static LoopType loopType; // 0x0C
		public static EaseType easeType; // 0x10
		public static float lookSpeed; // 0x14
		public static bool isLocal; // 0x18
		public static Space space; // 0x1C
		public static bool orientToPath; // 0x20
		public static Color color; // 0x24
		public static float updateTimePercentage; // 0x34
		public static float updateTime; // 0x38
		public static int cameraFadeDepth; // 0x3C
		public static float lookAhead; // 0x40
		public static bool useRealTime; // 0x44
		public static Vector3 up; // 0x48

		// Constructors
		static Defaults() {} // 0x00B7B8C0-0x00B7BA10
	}

	private class CRSpline // TypeDefIndex: 6102
	{
		// Fields
		public Vector3[] pts; // 0x10

		// Constructors
		public CRSpline() {} // Dummy constructor
		public CRSpline(params /* 0x0065AD50-0x0065AD60 */ Vector3[] pts) {} // 0x00B7B3A0-0x00B7B420

		// Methods
		public Vector3 Interp(float t) => default; // 0x00B7B420-0x00B7B8C0
	}

	// Constructors
	public iTween() {} // Dummy constructor
	private iTween(Hashtable h) {} // 0x00779F10-0x00779F40
	static iTween() {} // 0x0077EEB0-0x0077EF30

	// Methods
	public static void Init(GameObject target) {} // 0x007554F0-0x007555B0
	public static void CameraFadeFrom(float amount, float time) {} // 0x00755820-0x00755B20
	public static void CameraFadeFrom(Hashtable args) {} // 0x00755C70-0x00755D90
	public static void CameraFadeTo(float amount, float time) {} // 0x00756750-0x00756A50
	public static void CameraFadeTo(Hashtable args) {} // 0x00756A50-0x00756B70
	public static void ValueTo(GameObject target, Hashtable args) {} // 0x00756FE0-0x00757490
	public static void FadeFrom(GameObject target, float alpha, float time) {} // 0x00757C20-0x00757EC0
	public static void FadeFrom(GameObject target, Hashtable args) {} // 0x00757EC0-0x00757F40
	public static void FadeTo(GameObject target, float alpha, float time) {} // 0x00757F40-0x007581E0
	public static void FadeTo(GameObject target, Hashtable args) {} // 0x007581E0-0x00758260
	public static void ColorFrom(GameObject target, Color color, float time) {} // 0x00758260-0x007584E0
	public static void ColorFrom(GameObject target, Hashtable args) {} // 0x00755D90-0x00756750
	public static void ColorTo(GameObject target, Color color, float time) {} // 0x007584E0-0x00758760
	public static void ColorTo(GameObject target, Hashtable args) {} // 0x00756B70-0x00756FE0
	public static void AudioFrom(GameObject target, float volume, float pitch, float time) {} // 0x00758760-0x00758AA0
	public static void AudioFrom(GameObject target, Hashtable args) {} // 0x00758AA0-0x00758ED0
	public static void AudioTo(GameObject target, float volume, float pitch, float time) {} // 0x00758ED0-0x00759210
	public static void AudioTo(GameObject target, Hashtable args) {} // 0x00759210-0x00759370
	public static void Stab(GameObject target, AudioClip audioclip, float delay) {} // 0x00759370-0x00759630
	public static void Stab(GameObject target, Hashtable args) {} // 0x00759630-0x007596E0
	public static void LookFrom(GameObject target, Vector3 looktarget, float time) {} // 0x007596E0-0x00759950
	public static void LookFrom(GameObject target, Hashtable args) {} // 0x00759950-0x0075A180
	public static void LookTo(GameObject target, Vector3 looktarget, float time) {} // 0x0075A180-0x0075A3F0
	public static void LookTo(GameObject target, Hashtable args) {} // 0x0075A3F0-0x0075A760
	public static void MoveTo(GameObject target, Vector3 position, float time) {} // 0x0075A760-0x0075A9D0
	public static void MoveTo(GameObject target, Hashtable args) {} // 0x0075A9D0-0x0075ADC0
	public static void MoveFrom(GameObject target, Vector3 position, float time) {} // 0x0075ADC0-0x0075B030
	public static void MoveFrom(GameObject target, Hashtable args) {} // 0x0075B030-0x0075BA40
	public static void MoveAdd(GameObject target, Vector3 amount, float time) {} // 0x0075BA40-0x0075BCB0
	public static void MoveAdd(GameObject target, Hashtable args) {} // 0x0075BCB0-0x0075BD90
	public static void MoveBy(GameObject target, Vector3 amount, float time) {} // 0x007555B0-0x00755820
	public static void MoveBy(GameObject target, Hashtable args) {} // 0x0075BD90-0x0075BE70
	public static void ScaleTo(GameObject target, Vector3 scale, float time) {} // 0x0075BE70-0x0075C0E0
	public static void ScaleTo(GameObject target, Hashtable args) {} // 0x0075C0E0-0x0075C4D0
	public static void ScaleFrom(GameObject target, Vector3 scale, float time) {} // 0x0075C4D0-0x0075C740
	public static void ScaleFrom(GameObject target, Hashtable args) {} // 0x0075C740-0x0075CBD0
	public static void ScaleAdd(GameObject target, Vector3 amount, float time) {} // 0x0075CBD0-0x0075CE40
	public static void ScaleAdd(GameObject target, Hashtable args) {} // 0x0075CE40-0x0075CF20
	public static void ScaleBy(GameObject target, Vector3 amount, float time) {} // 0x0075CF20-0x0075D190
	public static void ScaleBy(GameObject target, Hashtable args) {} // 0x0075D190-0x0075D270
	public static void RotateTo(GameObject target, Vector3 rotation, float time) {} // 0x0075D270-0x0075D4E0
	public static void RotateTo(GameObject target, Hashtable args) {} // 0x0075D4E0-0x0075D8D0
	public static void RotateFrom(GameObject target, Vector3 rotation, float time) {} // 0x0075D8D0-0x0075DB40
	public static void RotateFrom(GameObject target, Hashtable args) {} // 0x0075DB40-0x0075E080
	public static void RotateAdd(GameObject target, Vector3 amount, float time) {} // 0x0075E080-0x0075E2F0
	public static void RotateAdd(GameObject target, Hashtable args) {} // 0x0075E2F0-0x0075E3D0
	public static void RotateBy(GameObject target, Vector3 amount, float time) {} // 0x0075E3D0-0x0075E640
	public static void RotateBy(GameObject target, Hashtable args) {} // 0x0075E640-0x0075E720
	public static void ShakePosition(GameObject target, Vector3 amount, float time) {} // 0x0075E720-0x0075E990
	public static void ShakePosition(GameObject target, Hashtable args) {} // 0x0075E990-0x0075EA70
	public static void ShakeScale(GameObject target, Vector3 amount, float time) {} // 0x0075EA70-0x0075ECE0
	public static void ShakeScale(GameObject target, Hashtable args) {} // 0x0075ECE0-0x0075EDC0
	public static void ShakeRotation(GameObject target, Vector3 amount, float time) {} // 0x0075EDC0-0x0075F030
	public static void ShakeRotation(GameObject target, Hashtable args) {} // 0x0075F030-0x0075F110
	public static void PunchPosition(GameObject target, Vector3 amount, float time) {} // 0x0075F110-0x0075F380
	public static void PunchPosition(GameObject target, Hashtable args) {} // 0x0075F380-0x0075F4A0
	public static void PunchRotation(GameObject target, Vector3 amount, float time) {} // 0x0075F4A0-0x0075F710
	public static void PunchRotation(GameObject target, Hashtable args) {} // 0x0075F710-0x0075F830
	public static void PunchScale(GameObject target, Vector3 amount, float time) {} // 0x0075F830-0x0075FAA0
	public static void PunchScale(GameObject target, Hashtable args) {} // 0x0075FAA0-0x0075FBC0
	private void GenerateTargets() {} // 0x0075FBC0-0x007603D0
	private void GenerateRectTargets() {} // 0x00760C70-0x00760DA0
	private void GenerateColorTargets() {} // 0x00760AD0-0x00760C70
	private void GenerateVector3Targets() {} // 0x00760880-0x00760AD0
	private void GenerateVector2Targets() {} // 0x007605B0-0x00760880
	private void GenerateFloatTargets() {} // 0x007603D0-0x007605B0
	private void GenerateColorToTargets() {} // 0x00760DA0-0x00761840
	private void GenerateAudioToTargets() {} // 0x00761840-0x00761B90
	private void GenerateStabTargets() {} // 0x007672A0-0x00767600
	private void GenerateLookToTargets() {} // 0x00766500-0x007672A0
	private void GenerateMoveToPathTargets() {} // 0x00761B90-0x00762540
	private void GenerateMoveToTargets() {} // 0x00762540-0x00762BD0
	private void GenerateMoveByTargets() {} // 0x00762BD0-0x00763280
	private void GenerateScaleToTargets() {} // 0x00763280-0x00763840
	private void GenerateScaleByTargets() {} // 0x00763840-0x00763CA0
	private void GenerateScaleAddTargets() {} // 0x00763CA0-0x007640D0
	private void GenerateRotateToTargets() {} // 0x007640D0-0x00764A10
	private void GenerateRotateAddTargets() {} // 0x00764A10-0x00764E90
	private void GenerateRotateByTargets() {} // 0x00764E90-0x00765370
	private void GenerateShakePositionTargets() {} // 0x00765370-0x00765650
	private void GenerateShakeScaleTargets() {} // 0x00765650-0x007658F0
	private void GenerateShakeRotationTargets() {} // 0x007658F0-0x00765B90
	private void GeneratePunchPositionTargets() {} // 0x00765B90-0x00765EF0
	private void GeneratePunchRotationTargets() {} // 0x00765EF0-0x00766210
	private void GeneratePunchScaleTargets() {} // 0x00766210-0x00766500
	private void ApplyRectTargets() {} // 0x00767A60-0x00767E20
	private void ApplyColorTargets() {} // 0x00767E20-0x007683F0
	private void ApplyVector3Targets() {} // 0x007683F0-0x007686E0
	private void ApplyVector2Targets() {} // 0x007686E0-0x00768920
	private void ApplyFloatTargets() {} // 0x00768920-0x00768AD0
	private void ApplyColorToTargets() {} // 0x00768AD0-0x00769420
	private void ApplyAudioToTargets() {} // 0x00769420-0x00769670
	private void ApplyStabTargets() {} // 0x00769670-0x00769680
	private void ApplyMoveToPathTargets() {} // 0x00769680-0x00769990
	private void ApplyMoveToTargets() {} // 0x00769990-0x00769CD0
	private void ApplyMoveByTargets() {} // 0x00769CD0-0x0076A150
	private void ApplyScaleToTargets() {} // 0x0076A150-0x0076A3D0
	private void ApplyLookToTargets() {} // 0x0076A3D0-0x0076A6A0
	private void ApplyRotateToTargets() {} // 0x0076A6A0-0x0076AAE0
	private void ApplyRotateAddTargets() {} // 0x0076AAE0-0x0076AEC0
	private void ApplyShakePositionTargets() {} // 0x0076AEC0-0x0076B3F0
	private void ApplyShakeScaleTargets() {} // 0x0076B3F0-0x0076B720
	private void ApplyShakeRotationTargets() {} // 0x0076B720-0x0076BAB0
	private void ApplyPunchPositionTargets() {} // 0x0076BAB0-0x0076C410
	private void ApplyPunchRotationTargets() {} // 0x0076C4D0-0x0076CDA0
	private void ApplyPunchScaleTargets() {} // 0x0076CDA0-0x0076D560
	// [IteratorStateMachine] // 0x006242E0-0x00624350
	private IEnumerator TweenDelay() => default; // 0x0076D560-0x0076D5D0
	private void TweenStart() {} // 0x0076D5D0-0x0076D740
	// [IteratorStateMachine] // 0x00624350-0x006243C0
	private IEnumerator TweenRestart() => default; // 0x0076DF50-0x0076DFC0
	private void TweenUpdate() {} // 0x0076DFC0-0x0076E080
	private void TweenComplete() {} // 0x0076E100-0x0076E240
	private void TweenLoop() {} // 0x0076E240-0x0076E2E0
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed) => default; // 0x0076E2F0-0x0076E480
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed) => default; // 0x0076E4C0-0x0076E5D0
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed) => default; // 0x0076E5D0-0x0076E6C0
	public static float FloatUpdate(float currentValue, float targetValue, float speed) => default; // 0x0076E480-0x0076E4C0
	public static void FadeUpdate(GameObject target, Hashtable args) {} // 0x0076E6C0-0x0076E780
	public static void FadeUpdate(GameObject target, float alpha, float time) {} // 0x0076F2A0-0x0076F570
	public static void ColorUpdate(GameObject target, Hashtable args) {} // 0x0076E780-0x0076F2A0
	public static void ColorUpdate(GameObject target, Color color, float time) {} // 0x0076F570-0x0076F7F0
	public static void AudioUpdate(GameObject target, Hashtable args) {} // 0x0076F7F0-0x0076FE30
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time) {} // 0x0076FE30-0x00770170
	public static void RotateUpdate(GameObject target, Hashtable args) {} // 0x00770170-0x007709A0
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time) {} // 0x007709A0-0x00770C10
	public static void ScaleUpdate(GameObject target, Hashtable args) {} // 0x00770C10-0x00771410
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time) {} // 0x00771410-0x00771680
	public static void MoveUpdate(GameObject target, Hashtable args) {} // 0x00771680-0x00772140
	public static void MoveUpdate(GameObject target, Vector3 position, float time) {} // 0x00772EF0-0x00773160
	public static void LookUpdate(GameObject target, Hashtable args) {} // 0x00772140-0x00772EF0
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time) {} // 0x00773160-0x007733D0
	public static float PathLength(Transform[] path) => default; // 0x007733D0-0x007735E0
	public static float PathLength(Vector3[] path) => default; // 0x007678F0-0x00767A60
	public static Texture2D CameraTexture(Color color) => default; // 0x00773ED0-0x00774020
	public static void PutOnPath(GameObject target, Vector3[] path, float percent) {} // 0x00774020-0x007740C0
	public static void PutOnPath(Transform target, Vector3[] path, float percent) {} // 0x007740C0-0x00774150
	public static void PutOnPath(GameObject target, Transform[] path, float percent) {} // 0x00774150-0x007742A0
	public static void PutOnPath(Transform target, Transform[] path, float percent) {} // 0x007742A0-0x007743E0
	public static Vector3 PointOnPath(Transform[] path, float percent) => default; // 0x007743E0-0x00774510
	public static void DrawLine(Vector3[] line) {} // 0x00774510-0x007745F0
	public static void DrawLine(Vector3[] line, Color color) {} // 0x00774790-0x00774850
	public static void DrawLine(Transform[] line) {} // 0x00774850-0x007749E0
	public static void DrawLine(Transform[] line, Color color) {} // 0x007749E0-0x00774B70
	public static void DrawLineGizmos(Vector3[] line) {} // 0x00774B70-0x00774C50
	public static void DrawLineGizmos(Vector3[] line, Color color) {} // 0x00774C50-0x00774D10
	public static void DrawLineGizmos(Transform[] line) {} // 0x00774D10-0x00774EA0
	public static void DrawLineGizmos(Transform[] line, Color color) {} // 0x00774EA0-0x00775030
	public static void DrawLineHandles(Vector3[] line) {} // 0x00775030-0x00775110
	public static void DrawLineHandles(Vector3[] line, Color color) {} // 0x00775110-0x007751D0
	public static void DrawLineHandles(Transform[] line) {} // 0x007751D0-0x00775360
	public static void DrawLineHandles(Transform[] line, Color color) {} // 0x00775360-0x007754F0
	public static Vector3 PointOnPath(Vector3[] path, float percent) => default; // 0x007754F0-0x00775570
	public static void DrawPath(Vector3[] path) {} // 0x00775570-0x00775650
	public static void DrawPath(Vector3[] path, Color color) {} // 0x00775850-0x00775910
	public static void DrawPath(Transform[] path) {} // 0x00775910-0x00775AA0
	public static void DrawPath(Transform[] path, Color color) {} // 0x00775AA0-0x00775C30
	public static void DrawPathGizmos(Vector3[] path) {} // 0x00775C30-0x00775D10
	public static void DrawPathGizmos(Vector3[] path, Color color) {} // 0x00775D10-0x00775DD0
	public static void DrawPathGizmos(Transform[] path) {} // 0x00775DD0-0x00775F60
	public static void DrawPathGizmos(Transform[] path, Color color) {} // 0x00775F60-0x007760F0
	public static void DrawPathHandles(Vector3[] path) {} // 0x007760F0-0x007761D0
	public static void DrawPathHandles(Vector3[] path, Color color) {} // 0x007761D0-0x00776290
	public static void DrawPathHandles(Transform[] path) {} // 0x00776290-0x00776420
	public static void DrawPathHandles(Transform[] path, Color color) {} // 0x00776420-0x007765B0
	public static void CameraFadeDepth(int depth) {} // 0x007765B0-0x00776720
	public static void CameraFadeDestroy() {} // 0x00776720-0x00776830
	public static void Resume(GameObject target) {} // 0x00776830-0x00776990
	public static void Resume(GameObject target, bool includechildren) {} // 0x00776990-0x00776BF0
	public static void Resume(GameObject target, string type) {} // 0x00776BF0-0x00776DB0
	public static void Resume(GameObject target, string type, bool includechildren) {} // 0x00776DB0-0x00777130
	public static void Resume() {} // 0x00777130-0x007772D0
	public static void Resume(string type) {} // 0x007772D0-0x007775C0
	public static void Pause(GameObject target) {} // 0x007775C0-0x00777780
	public static void Pause(GameObject target, bool includechildren) {} // 0x00777780-0x007779E0
	public static void Pause(GameObject target, string type) {} // 0x007779E0-0x00777C00
	public static void Pause(GameObject target, string type, bool includechildren) {} // 0x00777C00-0x00777FE0
	public static void Pause() {} // 0x00777FE0-0x00778180
	public static void Pause(string type) {} // 0x00778180-0x00778470
	public static int Count() => default; // 0x00778470-0x007784F0
	public static int Count(string type) => default; // 0x007784F0-0x00778790
	public static int Count(GameObject target) => default; // 0x00778790-0x007787F0
	public static int Count(GameObject target, string type) => default; // 0x007787F0-0x007789C0
	public static void Stop() {} // 0x007789C0-0x00778B90
	public static void Stop(string type) {} // 0x00778CF0-0x00778FE0
	public static void StopByName(string name) {} // 0x007791A0-0x00779490
	public static void Stop(GameObject target) {} // 0x00778B90-0x00778CF0
	public static void Stop(GameObject target, bool includechildren) {} // 0x00779600-0x00779860
	public static void Stop(GameObject target, string type) {} // 0x00778FE0-0x007791A0
	public static void StopByName(GameObject target, string name) {} // 0x00779490-0x00779600
	public static void Stop(GameObject target, string type, bool includechildren) {} // 0x00779860-0x00779BE0
	public static void StopByName(GameObject target, string name, bool includechildren) {} // 0x00779BE0-0x00779F10
	public static Hashtable Hash(params /* 0x0065AC50-0x0065AC60 */ object[] args) => default; // 0x00755B20-0x00755C70
	private void Awake() {} // 0x00779F40-0x00779F80
	// [IteratorStateMachine] // 0x006243C0-0x00624430
	private IEnumerator Start() => default; // 0x0077B130-0x0077B1A0
	private void Update() {} // 0x0077B1A0-0x0077B1E0
	private void FixedUpdate() {} // 0x0077B1E0-0x0077B220
	private void LateUpdate() {} // 0x0077B220-0x0077B330
	private void OnEnable() {} // 0x0077B330-0x0077B3C0
	private void OnDisable() {} // 0x0077B420-0x0077B430
	private static void DrawLineHelper(Vector3[] line, Color color, string method) {} // 0x007745F0-0x00774790
	private static void DrawPathHelper(Vector3[] path, Color color, string method) {} // 0x00775650-0x00775850
	private static Vector3[] PathControlPointGenerator(Vector3[] path) => default; // 0x007735E0-0x00773A60
	private static Vector3 Interp(Vector3[] pts, float t) => default; // 0x00773A60-0x00773ED0
	private static void Launch(GameObject target, Hashtable args) {} // 0x00757AC0-0x00757C20
	private static Hashtable CleanArgs(Hashtable args) => default; // 0x00757490-0x00757AC0
	private static string GenerateID() => default; // 0x0077B430-0x0077B460
	private void RetrieveArgs() {} // 0x00779F80-0x0077B130
	private void GetEasingFunction() {} // 0x0077B460-0x0077B860
	private void UpdatePercentage() {} // 0x0076E080-0x0076E100
	private void CallBack(string callbackType) {} // 0x0076D740-0x0076DA90
	private void Dispose() {} // 0x00767600-0x00767810
	private void ConflictCheck() {} // 0x0076DA90-0x0076DF40
	private void EnableKinematic() {} // 0x0076DF40-0x0076DF50
	private void DisableKinematic() {} // 0x0076E2E0-0x0076E2F0
	private void ResumeDelay() {} // 0x0077B3C0-0x0077B420
	private float linear(float start, float end, float value) => default; // 0x0077B860-0x0077B8F0
	private float clerp(float start, float end, float value) => default; // 0x00767810-0x007678F0
	private float spring(float start, float end, float value) => default; // 0x0077B8F0-0x0077BA00
	private float easeInQuad(float start, float end, float value) => default; // 0x0077BA00-0x0077BA20
	private float easeOutQuad(float start, float end, float value) => default; // 0x0077BA20-0x0077BA40
	private float easeInOutQuad(float start, float end, float value) => default; // 0x0077BA40-0x0077BA90
	private float easeInCubic(float start, float end, float value) => default; // 0x0077BA90-0x0077BAB0
	private float easeOutCubic(float start, float end, float value) => default; // 0x0077BAB0-0x0077BAE0
	private float easeInOutCubic(float start, float end, float value) => default; // 0x0077BAE0-0x0077BB30
	private float easeInQuart(float start, float end, float value) => default; // 0x0077BB30-0x0077BB50
	private float easeOutQuart(float start, float end, float value) => default; // 0x0077BB50-0x0077BB80
	private float easeInOutQuart(float start, float end, float value) => default; // 0x0077BB80-0x0077BBE0
	private float easeInQuint(float start, float end, float value) => default; // 0x0077BBE0-0x0077BC00
	private float easeOutQuint(float start, float end, float value) => default; // 0x0077BC00-0x0077BC30
	private float easeInOutQuint(float start, float end, float value) => default; // 0x0077BC30-0x0077BC90
	private float easeInSine(float start, float end, float value) => default; // 0x0077BC90-0x0077BD30
	private float easeOutSine(float start, float end, float value) => default; // 0x0077BD30-0x0077BDD0
	private float easeInOutSine(float start, float end, float value) => default; // 0x0077BDD0-0x0077BE80
	private float easeInExpo(float start, float end, float value) => default; // 0x0077BE80-0x0077BF20
	private float easeOutExpo(float start, float end, float value) => default; // 0x0077BF20-0x0077BFC0
	private float easeInOutExpo(float start, float end, float value) => default; // 0x0077BFC0-0x0077C0C0
	private float easeInCirc(float start, float end, float value) => default; // 0x0077C0C0-0x0077C170
	private float easeOutCirc(float start, float end, float value) => default; // 0x0077C170-0x0077C220
	private float easeInOutCirc(float start, float end, float value) => default; // 0x0077C220-0x0077C320
	private float easeInBounce(float start, float end, float value) => default; // 0x0077C320-0x0077C400
	private float easeOutBounce(float start, float end, float value) => default; // 0x0077C400-0x0077C4F0
	private float easeInOutBounce(float start, float end, float value) => default; // 0x0077C4F0-0x0077C6D0
	private float easeInBack(float start, float end, float value) => default; // 0x0077C6D0-0x0077C700
	private float easeOutBack(float start, float end, float value) => default; // 0x0077C700-0x0077C740
	private float easeInOutBack(float start, float end, float value) => default; // 0x0077C740-0x0077C7D0
	private float punch(float amplitude, float value) => default; // 0x0076C410-0x0076C4D0
	private float easeInElastic(float start, float end, float value) => default; // 0x0077C7D0-0x0077C8C0
	private float easeOutElastic(float start, float end, float value) => default; // 0x0077C8C0-0x0077C9B0
	private float easeInOutElastic(float start, float end, float value) => default; // 0x0077C9B0-0x0077CB20
	public static void UIColorTo(GameObject target, Hashtable h) {} // 0x0077CB20-0x0077CCE0
	public static void UIColorTo(GameObject target, Color color, float time) {} // 0x0077CCE0-0x0077D200
	public void TweenUIColor(Color v) {} // 0x0077D200-0x0077D290
	public static void AlphaTo(GameObject target, Hashtable h) {} // 0x0077D290-0x0077D4D0
	public static void AlphaTo(GameObject target, float alpha, float time, float delay = 0f /* Metadata: 0x00612533 */) {} // 0x0077D4D0-0x0077DB00
	public static void AlphaFrom(GameObject target, float alpha, float time, float delay = 0f /* Metadata: 0x00612537 */) {} // 0x0077DB00-0x0077E110
	public void TweenAlpha(float v) {} // 0x0077E110-0x0077E270
	public static void ImageAlphaTo(GameObject target, float alpha, float time, float delay = 0f /* Metadata: 0x0061253B */) {} // 0x0077E270-0x0077E820
	public static void ImageAlphaFrom(GameObject target, float alpha, float time, float delay = 0f /* Metadata: 0x0061253F */) {} // 0x0077E820-0x0077EDD0
	public void TweenImageAlpha(float v) {} // 0x0077EDD0-0x0077EEB0
}

