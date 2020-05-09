/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class VibrationFile // TypeDefIndex: 9063
	{
		// Properties
		public static ErrorRange ResultInvalid { get; } // 0x01143E60-0x01143EA0 
	
		// Methods
		public static extern Result Parse(ref VibrationFileInfo pOutInfo, ref VibrationFileParserContext pOutContext, byte[] address, long fileSize); // 0x01143EA0-0x01143ED0
		public static extern void RetrieveValue(ref VibrationValue pOutValue, int position, ref VibrationFileParserContext pContext); // 0x01143ED0-0x01143EE0
		private static extern void Generate(ref long pOutSize, byte[] outBuffer, long bufferSize, VibrationValueArrayInfo info, VibrationValue[] pValues); // 0x01143EE0-0x01143F30
		public static void Generate(ref long pOutSize, byte[] outBuffer, VibrationValueArrayInfo info, VibrationValue[] pValues) {} // 0x01143F30-0x01143F90
		public static extern long CalculateSize(VibrationValueArrayInfo info); // 0x01143F90-0x01144450
	}
}
