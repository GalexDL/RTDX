/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina
{
	public class NativeController : Singleton<kamina.NativeController> // TypeDefIndex: 8379
	{
		// Fields
		private const int MAX_FEEDBACK_BUFFER = 1048576; // Metadata: 0x00614AC7
		private const int MAX_UPADATE_BUFFER = 1048576; // Metadata: 0x00614ACB
		private const int MAX_UPADATE_GL_BUFFER = 131072; // Metadata: 0x00614ACF
		private const int MAX_UPADATE_GL_VERTEX_BUFFER = 1048576; // Metadata: 0x00614AD3
		private const int MAX_UPADATE_GL_INDEX_BUFFER = 131072; // Metadata: 0x00614AD7
		private byte[] aFeedbackBuffer_; // 0x10
		private uint[] aUpdateBuffer_; // 0x18
		private byte[] aUpdateGLBuffer_; // 0x20
		private byte[] aUpdateGLVertexBuffer_; // 0x28
		private byte[] aUpdateGLIndexBuffer_; // 0x30
		private int updateBufferSetCommandNum; // 0x38
		private bool bCommandBufferOpen; // 0x3C
		public int[] _hotCount; // 0x40
		public Color32[] s_aPixelTable; // 0x48
		private CommandStream m_commandStream; // 0x50
		private const int MATERIAL_DIRTY_FLAG_TEXTURE = 1; // Metadata: 0x00614ADB
		private const int MATERIAL_DIRTY_FLAG_ALPHA_BLEND = 2; // Metadata: 0x00614ADF
		private const int MATERIAL_DIRTY_FLAG_ALPHA_TEST = 4; // Metadata: 0x00614AE3
		private const int MATERIAL_DIRTY_FLAG_DEPTH_TEST = 8; // Metadata: 0x00614AE7
		private const int MATERIAL_DIRTY_FLAG_STENCIL_TEST = 16; // Metadata: 0x00614AEB
		private byte[] aGLCommandStreamTempraryBuffer_; // 0x58
		private byte[] aGLVertexStreamTempraryBuffer_; // 0x60
		private DataExchangeByteMemoryStream m_glCommandStream; // 0x68
		private DataExchangeByteMemoryStream m_glCommandVertexStream; // 0x70
	
		// Properties
		public bool OpenCommandBuffer { get => default; } // 0x00B82A70-0x00B82A80 
	
		// Constructors
		public NativeController() {} // 0x00B99F10-0x00B9A550
	
		// Methods
		public void FeedbackToNaitve() {} // 0x00B82A80-0x00B82B10
		public void BeginCommandBuffer() {} // 0x00B82B10-0x00B82BA0
		public void EndCommandBuffer() {} // 0x00B82BA0-0x00B82C20
		public void UpdateFromNaitve() {} // 0x00B82C20-0x00B99450
		public void UpdateGLFromNaitve() {} // 0x00B99F00-0x00B99F10
	}
}
