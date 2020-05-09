/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class FreeCameraCtrl : MonoBehaviour // TypeDefIndex: 8466
	{
		// Fields
		private CtrlInfo padInfo; // 0x18
		[SerializeField] // 0x00617210-0x00617260
		// [Tooltip] // 0x00617210-0x00617260
		private Camera[] targetCamera; // 0x20
		[SerializeField] // 0x00617260-0x006172B0
		// [Tooltip] // 0x00617260-0x006172B0
		private Transform cameraPosition; // 0x28
		[SerializeField] // 0x006172B0-0x00617300
		// [Tooltip] // 0x006172B0-0x00617300
		private float initialLatitude; // 0x30
		[SerializeField] // 0x00617300-0x00617350
		// [Tooltip] // 0x00617300-0x00617350
		private float initialLongitude; // 0x34
		[SerializeField] // 0x00617350-0x006173A0
		// [Tooltip] // 0x00617350-0x006173A0
		private float initialRadius; // 0x38
		[SerializeField] // 0x006173A0-0x006173F0
		// [Tooltip] // 0x006173A0-0x006173F0
		private float near; // 0x3C
		[SerializeField] // 0x006173F0-0x00617440
		// [Tooltip] // 0x006173F0-0x00617440
		private float far; // 0x40
		[SerializeField] // 0x00617440-0x00617490
		// [Tooltip] // 0x00617440-0x00617490
		private int selectedCamera; // 0x44
		private float latitude; // 0x48
		private float longitude; // 0x4C
		private float radius; // 0x50
		private Camera oldCamera; // 0x58
	
		// Nested types
		public enum CameraMode // TypeDefIndex: 8467
		{
			GROUND = 0,
			DUNGEON = 1,
			FREE = 2
		}
	
		// Constructors
		public FreeCameraCtrl() {} // 0x0074CE40-0x0074CE60
	
		// Methods
		public void SetPadInfo(CtrlInfo padInfo) {} // 0x0074BC90-0x0074BCA0
		public void SetCameraActive(bool isActive) {} // 0x0074BCA0-0x0074BE80
		public void SetCameraMode(int num) {} // 0x0074BE80-0x0074BF10
		public void ResetPosition() {} // 0x0074BF10-0x0074BF50
		public void SetCameraPosition(Camera source) {} // 0x0074BF50-0x0074C1D0
		private void Start() {} // 0x0074C1D0-0x0074C210
		private void OnDestroy() {} // 0x0074C210-0x0074C220
		private void Update() {} // 0x0074C220-0x0074C250
		private void MoveByController() {} // 0x0074C250-0x0074C430
		public void CameraReset() {} // 0x0074C8D0-0x0074C950
		private void MoveOnScreen(Vector2 axisL) {} // 0x0074CC00-0x0074CE20
		private void MoveAxisXZ(Vector2 axisL) {} // 0x0074CA40-0x0074CC00
		private void MoveAxisY(Vector2 axisL) {} // 0x0074C950-0x0074CA40
		private void RotateLatitudeAndLongitude(Vector2 axisL) {} // 0x0074CE20-0x0074CE40
		private void MoveByPanel() {} // 0x0074C430-0x0074C620
		private void SetCameraPosition() {} // 0x0074C620-0x0074C8D0
	}
}
