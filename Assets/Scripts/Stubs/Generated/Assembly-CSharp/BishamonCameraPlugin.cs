/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x006086A0-0x00608740
[DisallowMultipleComponent] // 0x006086A0-0x00608740
// [RequireComponent] // 0x006086A0-0x00608740
public class BishamonCameraPlugin : MonoBehaviour // TypeDefIndex: 4361
{
	// Fields
	[SerializeField] // 0x00615D10-0x00615D60
	// [Tooltip] // 0x00615D10-0x00615D60
	public bool ignore; // 0x18
	[SerializeField] // 0x00615D60-0x00615DB0
	// [Tooltip] // 0x00615D60-0x00615DB0
	public bool hasPostEffect; // 0x19
	[SerializeField] // 0x00615DB0-0x00615E00
	// [Tooltip] // 0x00615DB0-0x00615E00
	public bool enableDepthTexture; // 0x1A
	[SerializeField] // 0x00615E00-0x00615E50
	// [Tooltip] // 0x00615E00-0x00615E50
	public bool enableRenderTexture; // 0x1B
	[SerializeField] // 0x00615E50-0x00615EA0
	// [Tooltip] // 0x00615E50-0x00615EA0
	public Light renderingLight; // 0x20
	private Camera m_attachedCamera; // 0x28
	private BishamonRender m_render; // 0x30

	// Constructors
	public BishamonCameraPlugin() {} // 0x008BEE80-0x008BEEF0

	// Methods
	public bool IsPostEffect() => default; // 0x008BDB50-0x008BDB60
	public BishamonRender GetRender() => default; // 0x008BDB60-0x008BDB70
	public RenderTexture GetColorTexture() => default; // 0x008BDB70-0x008BDB80
	public RenderTexture GetDepthTexture() => default; // 0x008BDB90-0x008BDBA0
	public long GetNativeColorTextureInt64() => default; // 0x008BDBB0-0x008BDBC0
	public long GetNativeDepthTextureInt64() => default; // 0x008BDCA0-0x008BDCB0
	private void Awake() {} // 0x008BDD90-0x008BDE80
	private void Start() {} // 0x008BE080-0x008BE090
	private void OnEnable() {} // 0x008BE090-0x008BE0A0
	private void OnDisable() {} // 0x008BE0A0-0x008BE1E0
	private void OnPreCull() {} // 0x008BE360-0x008BE440
	private void OnPreRender() {} // 0x008BE440-0x008BE6E0
	private void Releae() {} // 0x008BEDD0-0x008BEE60
	private void OnApplicationQuit() {} // 0x008BEE60-0x008BEE70
	private void OnDestroy() {} // 0x008BEE70-0x008BEE80
}

