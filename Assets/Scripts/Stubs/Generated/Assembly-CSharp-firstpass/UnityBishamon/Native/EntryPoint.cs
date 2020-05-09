/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4233-4338

namespace UnityBishamon.Native
{
	public class EntryPoint // TypeDefIndex: 4338
	{
		// Fields
		private const string DLLName = "__Internal"; // Metadata: 0x00610768
	
		// Constructors
		public EntryPoint() {} // 0x00351890-0x00351A00
	
		// Methods
		public static extern void bmCameraClean(); // 0x003514E0-0x003514F0
		public static extern void bmCameraFree(int cameraID); // 0x003514F0-0x00351500
		public static extern uint bmInit(ref InitArgument arg); // 0x00351500-0x00351510
		public static extern uint bmIsDeviceEnable(); // 0x00351510-0x00351520
		public static extern uint bmIsRenderingPeriod(); // 0x00351520-0x00351530
		public static extern long bmCreateEffect(ref CreateArgument arg); // 0x00351530-0x00351540
		public static extern int bmDestroyEffect(long anim); // 0x00351540-0x00351550
		public static extern void bmSetCameraEventMode(long anim, int cameraEvent); // 0x00351550-0x00351560
		public static extern void bmStartEffect(long anim); // 0x00351560-0x00351570
		public static extern void bmPauseEffect(long anim); // 0x00351570-0x00351580
		public static extern void bmPauseWithEnableUpdateEffect(long anim, int enableUpdateOnPause); // 0x00351580-0x00351590
		public static extern void bmResumEffect(long anim); // 0x00351590-0x003515A0
		public static extern void bmStopEffect(long anim, int forceFinish); // 0x003515A0-0x003515B0
		public static extern void bmSetActive(long anim, int active); // 0x003515B0-0x003515C0
		public static extern int bmGetEffectPhase(long anim); // 0x003515C0-0x003515D0
		public static extern int bmHasFinished(long anim); // 0x003515D0-0x003515E0
		public static extern int bmIsEnableUpdateOnPause(long anim); // 0x003515E0-0x003515F0
		public static extern void bmSetGenerateChildScale(long anim, int emitterType, float scale); // 0x003515F0-0x00351600
		public static extern int bmHasTexture(ref HasTextureArgument arg); // 0x00351600-0x00351610
		public static extern void bmRegisterTexture(ref RegisterTextureArgument arg); // 0x00351610-0x00351620
		public static extern void bmRegisterModel(ref RegisterModelArgument arg); // 0x00351620-0x00351630
		public static extern void bmRegisterBMB(ref RegisterBMBArgument arg); // 0x00351630-0x00351640
		public static extern void bmSetPriorityFromCamera(long anim, ref PriorityFromCameraArgument arg); // 0x00351640-0x00351650
		public static extern void bmUpdate(long anim, ref UpdateArgument arg); // 0x00351650-0x00351660
		public static extern void bmUpdateWithMakeVertex(long anim, ref UpdateArgument arg); // 0x00351660-0x00351670
		public static extern void bmMakeVertex(long anim, ref MakeVertexArgument arg); // 0x00351670-0x00351680
		public static extern int bmIsDeltaTimeZeroRequiresMakeVertex(long anim); // 0x00351680-0x00351690
		public static extern uint bmResourceSetupComplete(long anim); // 0x00351690-0x003516A0
		public static extern int bmSetCameraParam(ref CameraArgument arg); // 0x003516A0-0x003516B0
		public static extern void bmDirectInitializeEvent(int eventID); // 0x003516B0-0x003516C0
		public static extern void bmDirectUpdateEvent(int eventID); // 0x003516C0-0x003516D0
		public static extern void bmDirectDestroyEvent(int eventID); // 0x003516D0-0x003516E0
		public static extern void bmDirectDestroyAllEvent(int eventID); // 0x003516E0-0x003516F0
		public static extern void bmDirectCleanUpPluginEvent(int eventID); // 0x003516F0-0x00351700
		public static extern IntPtr bmGetInitializeEventFunc(); // 0x00351700-0x00351710
		public static extern IntPtr bmGetUpdateEventFunc(); // 0x00351710-0x00351720
		public static extern IntPtr bmGetRenderEventFunc(); // 0x00351720-0x00351730
		public static extern IntPtr bmGetBeforeImageEffectsRenderEventFunc(); // 0x00351730-0x00351740
		public static extern IntPtr bmGetDestroyEventFunc(); // 0x00351740-0x00351750
		public static extern IntPtr bmGetDestroyAllEventFunc(); // 0x00351750-0x00351760
		public static extern IntPtr bmGetRenderEditorEventFunc(); // 0x00351760-0x00351770
		public static extern IntPtr bmGetCleanUpPluginEventFunc(); // 0x00351770-0x00351780
		public static extern int bmGetRootUserDataSize(long anim); // 0x00351780-0x00351790
		public static extern IntPtr bmGetRootUserDataName(long anim, int index); // 0x00351790-0x003517A0
		public static extern int bmGetRootUserDataType(long anim, int index); // 0x003517A0-0x003517B0
		public static extern int bmGetRootUserDataMemberAsInt(long anim, int index); // 0x003517B0-0x003517C0
		public static extern float bmGetRootUserDataMemberAsFloat(long anim, int index); // 0x003517C0-0x003517D0
		public static extern uint bmGetRootUserDataMemberAsBool(long anim, int index); // 0x003517D0-0x003517E0
		public static extern IntPtr bmGetRootUserDataMemberAsString(long anim, int index); // 0x003517E0-0x003517F0
		public static extern IntPtr bmGetRootUserDataMemberAsVector(long anim, int index); // 0x003517F0-0x00351800
		public static extern IntPtr bmGetRootUserDataMemberAsColor(long anim, int index); // 0x00351800-0x00351810
		public static extern void bmGetRuntimeStats(ref RuntimeStatsArgument arg); // 0x00351810-0x00351820
		public static extern void bmGetErrorStats(long anim, ref ErrorStatusArgument arg); // 0x00351820-0x00351830
		public static extern void bmFrameFinishedEvent(); // 0x00351830-0x00351840
		public static extern void bmUpdateThreadStart(); // 0x00351840-0x00351850
		public static extern void bmUpdateThreadEnd(); // 0x00351850-0x00351860
		public static extern void bmUpdateWithDrawOnCPUThreadStart(); // 0x00351860-0x00351870
		public static extern void bmUpdateWithDrawOnCPUThreadEnd(); // 0x00351870-0x00351880
		public static extern void bmRegisterPlugin(); // 0x00351880-0x00351890
	}
}
