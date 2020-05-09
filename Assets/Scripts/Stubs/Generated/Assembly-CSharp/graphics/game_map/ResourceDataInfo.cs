/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace graphics.game_map
{
	public class ResourceDataInfo // TypeDefIndex: 8557
	{
		// Fields
		public string mapSymbol; // 0x10
		public string fileName; // 0x18
		public string partsVariation; // 0x20
		public string projectionSymbol; // 0x28
		public float waterHeight; // 0x30
		public float waterR; // 0x34
		public float waterG; // 0x38
		public float waterB; // 0x3C
		public float stairR; // 0x40
		public float stairG; // 0x44
		public float stairB; // 0x48
		public float originX; // 0x4C
		public float originY; // 0x50
		public float projectionHeight; // 0x54
		public float projectionSeed; // 0x58
		public float projectionWidth; // 0x5C
		public float projectionSec; // 0x60
		public float projectionPeriod; // 0x64
		public uint gfxSymbol; // 0x68
		public uint allEffectGfxSymbol; // 0x6C
		public uint waterGfxSymbol; // 0x70
		public int cliefType; // 0x74
		public int eResourceKind; // 0x78
		public bool bWaterFloor; // 0x7C
		public bool bProjectionShadowDependWeather; // 0x7D
	
		// Constructors
		public ResourceDataInfo() {} // 0x00754BD0-0x00754BE0
	
		// Methods
		public void ReadStream(IBinaryDataByteStream stream) {} // 0x00754710-0x00754970
		public void WriteStream(IBinaryDataByteStream stream) {} // 0x00754970-0x00754BD0
	}
}
