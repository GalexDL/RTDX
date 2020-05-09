/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIToken : MonoBehaviour // TypeDefIndex: 7627
{
	// Fields
	public string token; // 0x18
	private static TokenString_ gccache_tokenString_; // 0x00

	// Nested types
	private class TokenString_ // TypeDefIndex: 7628
	{
		// Fields
		private char[] tokenBuff; // 0x10
		public int curPos; // 0x18
		private int len; // 0x1C

		// Constructors
		public TokenString_() {} // 0x00A41400-0x00A41460

		// Methods
		public void Set(string token) {} // 0x00A3FF20-0x00A40040
		public int FindNextDot() => default; // 0x00A40910-0x00A409A0
		public bool CheckCurrentMatch(string token) => default; // 0x00A41210-0x00A41340
	}

	public class UITokenCache // TypeDefIndex: 7629
	{
		// Fields
		private Dictionary<string, List<UIToken>> uiTokenTbl_; // 0x10
		private List<TokenTreeNode_> uiTokenTreeRootLst_; // 0x18

		// Nested types
		private class TokenTreeNode_ // TypeDefIndex: 7630
		{
			// Fields
			public UIToken tokenRef; // 0x10
			public bool bOriginalRoot; // 0x18
			public TokenTreeNode_ parent; // 0x20
			public List<TokenTreeNode_> child; // 0x28

			// Constructors
			public TokenTreeNode_() {} // 0x00A419F0-0x00A41A60
		}

		// Constructors
		public UITokenCache() {} // 0x00A41E70-0x00A41F10

		// Methods
		public void Clear() {} // 0x00A41460-0x00A414D0
		public void Rebuild(Transform parent) {} // 0x00A414D0-0x00A419F0
		public GameObject FindHierarchyToken(string sToken, bool bIncludeOwn = false /* Metadata: 0x00613923 */) => default; // 0x00A40700-0x00A40910
		private GameObject FindTree_(TokenTreeNode_ parent, TokenString_ sToken, bool includeOriginalRoot) => default; // 0x00A41A60-0x00A41E70
	}

	// Constructors
	public UIToken() {} // 0x00A41340-0x00A41350
	static UIToken() {} // 0x00A41350-0x00A41400

	// Methods
	public static GameObject FindHierarchyToken(Transform parent, string sToken, bool bIncludeOwn = false /* Metadata: 0x0061391D */) => default; // 0x00A3FC90-0x00A3FD30
	public static GameObject FindHierarchyToken(UITokenCache parentCache, string sToken, bool bIncludeOwn = false /* Metadata: 0x0061391E */) => default; // 0x00A406F0-0x00A40700
	public static T FindHierarchyToken<T>(Transform parent, string sToken, bool bIncludeOwn = false /* Metadata: 0x0061391F */)
		where T : Component => default;
	public static T FindHierarchyToken<T>(UITokenCache parent, string sToken, bool bIncludeOwn = false /* Metadata: 0x00613920 */)
		where T : Component => default;
	private static GameObject FindHierarchyToken_Recv_(Transform parent, TokenString_ sToken, bool bIncludeOwn = false /* Metadata: 0x00613921 */) => default; // 0x00A40040-0x00A406F0
	private static GameObject FindHierarchyToken_Recv_(UITokenRootCache.Cache parent, TokenString_ sToken, bool bIncludeOwn = false /* Metadata: 0x00613922 */) => default; // 0x00A40A40-0x00A41210
	public static void ApplyHierarchyToken<T>(Transform parent, string sToken, Action<T> act)
		where T : Component {}
	public static void ApplyHierarchyToken<T>(UITokenCache parent, string sToken, Action<T> act)
		where T : Component {}
}

