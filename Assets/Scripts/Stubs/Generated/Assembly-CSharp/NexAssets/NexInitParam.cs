/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class NexInitParam // TypeDefIndex: 9427
	{
		// Fields
		private const int KILOBYTE = 1024; // Metadata: 0x0063200B
		private const int MIN_TIMEOUT = 1000; // Metadata: 0x0063200F
		private const int MAX_TIMEOUT = 60000; // Metadata: 0x00632013
		private const int DEF_TIMEOUT = 30000; // Metadata: 0x00632017
		private const int MIN_MEMORY = 300; // Metadata: 0x0063201B
		private const int MAX_MEMORY = 10240; // Metadata: 0x0063201F
		private const int MIN_RESERVEMEMORY = 40; // Metadata: 0x00632023
		[SerializeField] // 0x00617F30-0x00617F40
		private string gameServerId; // 0x10
		[SerializeField] // 0x00617F40-0x00617F50
		private string accessKey; // 0x18
		// [Range] // 0x00617F50-0x00617FA0
		[SerializeField] // 0x00617F50-0x00617FA0
		private int timeOut; // 0x20
		// [Range] // 0x00617FA0-0x00617FF0
		[SerializeField] // 0x00617FA0-0x00617FF0
		private uint pluginMemSize; // 0x24
		// [Range] // 0x00617FF0-0x00618040
		[SerializeField] // 0x00617FF0-0x00618040
		private uint nexMemSize; // 0x28
		// [Range] // 0x00618040-0x00618090
		[SerializeField] // 0x00618040-0x00618090
		private uint reserveMemSize; // 0x2C
		//[SerializeField] // 0x00618090-0x006180A0
		//private Common.ThreadMode threadMode; // 0x30
		[SerializeField] // 0x006180A0-0x006180B0
		private Common.CALL_DISPATCH callDispatch; // 0x34
		// [Range] // 0x006180B0-0x00618100
		[SerializeField] // 0x006180B0-0x00618100
		private uint dispatchTimeOut; // 0x38
		//[SerializeField] // 0x00618100-0x00618110
		//private Common.DispachFlag dispatchFlag; // 0x3C
		[SerializeField] // 0x00618110-0x00618120
		private bool autoLogin; // 0x40
		[SerializeField] // 0x00618120-0x00618130
		private bool autoLogout; // 0x41
	
		// Constructors
		public NexInitParam() {} // 0x00DB2A10-0x00DB2AB0
	
		// Methods
		public Common.NEX_INIT_PARAM GetNexInitParam() => default; // 0x00DB2890-0x00DB2A10
	}
}
