/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class BishamonRender // TypeDefIndex: 4364
{
	// Fields
	private const CameraEvent k_depth_render_pass = CameraEvent.AfterDepthTexture; // Metadata: 0x00610794
	private long m_nativeDepthTexture; // 0x10
	private RenderTexture m_depthTexture; // 0x18
	private CommandBuffer m_depthCommand; // 0x20
	private static bool m_depthValidity; // 0x00
	private static RenderTextureFormat m_depthFormat; // 0x04
	private static readonly RenderTextureFormat[] s_depthFormatTable; // 0x08
	private const CameraEvent k_color_render_pass = CameraEvent.AfterForwardAlpha; // Metadata: 0x00610798
	private long m_nativeColorTexture; // 0x28
	private RenderTexture m_colorTexture; // 0x30
	private CommandBuffer m_colorCommand; // 0x38
	private static bool m_colorValidity; // 0x10

	// Constructors
	public BishamonRender() {} // 0x008BEEF0-0x008BEF00
	static BishamonRender() {} // 0x008C0820-0x008C08C0

	// Methods
	public static void SetupDepth() {} // 0x008BDE80-0x008BE010
	public bool IsEnableDepth() => default; // 0x008BE6E0-0x008BE6F0
	public RenderTexture GetDepthTexture() => default; // 0x008BDBA0-0x008BDBB0
	public CommandBuffer GetCommandDepth() => default; // 0x008C0470-0x008C0480
	public long GetNativeDepthTextureInt64() => default; // 0x008BDCB0-0x008BDD90
	public void DestroyCommandDepth(Camera renderCamera) {} // 0x008C0480-0x008C04C0
	public void ReleaeDepth(Camera renderCamera) {} // 0x008BE1E0-0x008BE2A0
	public int GetDepthWidth() => default; // 0x008BE8D0-0x008BE970
	public int GetDepthHeight() => default; // 0x008BE970-0x008BEA10
	public bool CreateDepth(Camera renderCamera, int width, int height) => default; // 0x008BE6F0-0x008BE8D0
	public bool ResizeDepth(Camera renderCamera, int width, int height) => default; // 0x008BEA10-0x008BEC00
	public static void SetupColor() {} // 0x008BE010-0x008BE080
	public RenderTexture GetColorTexture() => default; // 0x008BDB80-0x008BDB90
	public bool IsEnableColor() => default; // 0x008BEC00-0x008BEC10
	public int GetColorWidth() => default; // 0x008C04C0-0x008C0560
	public int GetColorHeight() => default; // 0x008C0560-0x008C0600
	public CommandBuffer GetCommandColor() => default; // 0x008C0600-0x008C0610
	public long GetNativeColorTextureInt64() => default; // 0x008BDBC0-0x008BDCA0
	public void DestroyCommandColor(Camera renderCamera) {} // 0x008C0610-0x008C0650
	public void ReleaeColor(Camera renderCamera) {} // 0x008BE2A0-0x008BE360
	public bool CreateColor(Camera renderCamera, int width, int height) => default; // 0x008BEC10-0x008BEDD0
	public bool ResizeColor(Camera renderCamera, int width, int height) => default; // 0x008C0650-0x008C0820
}

