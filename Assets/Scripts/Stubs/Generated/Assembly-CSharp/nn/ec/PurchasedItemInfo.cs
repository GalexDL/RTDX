/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public struct PurchasedItemInfo // TypeDefIndex: 9157
	{
		// Fields
		public Type type; // 0x10
		public NetworkServiceAccountId nsaId; // 0x18
		internal CourseId _courseId; // 0x20
	
		// Nested types
		public enum Type // TypeDefIndex: 9158
		{
			Subscription = 0,
			Consumable = 1
		}
	
		// Methods
		public CourseId GetCourseId() => default; // 0x00A13ED0-0x00A13F40
		private static extern CourseId GetCourseId(PurchasedItemInfo info); // 0x00A13E50-0x00A13ED0
	}
}
