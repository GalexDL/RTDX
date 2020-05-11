/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572
[CreateAssetMenu]
public class GroundTownNpcDatabase : ScriptableObject // TypeDefIndex: 5057
{
	// Fields
	private const string TownNpcTalkScriptGrBasePath = "event/usual/talk_action_gr/"; // Metadata: 0x00610DF4
	private const string TownNpcTalkScriptDgBasePath = "event/usual/talk_action_dg/"; // Metadata: 0x00610E13
	[SerializeField] // 0x00616490-0x006164A0
	private List<StepData> stepDataList_; // 0x18

	// Properties
	public List<StepData> StepDataList { get => default; } // 0x0080A010-0x0080A020 

	// Nested types
	[Serializable]
	public class NpcData // TypeDefIndex: 5058
	{
		// Fields
		public string actSymbol; // 0x10
		public string refStepSymbol; // 0x18
		public ActParam_Pos pos; // 0x20
		public ActParam_Rot rot; // 0x28
		public string mapId; // 0x30
		public string redirectActSymbol; // 0x38
		private ActType cache_actType_; // 0x40
		private string cache_actTypeString_; // 0x48
		public string actType; // 0x50
		public string actGroupId; // 0x58
		public string actAreaSymbol; // 0x60
		public string actSymbolSubNpc1; // 0x68
		public string actSymbolSubNpc2; // 0x70
		public TalkTurnType talkTurnType; // 0x78
		public bool isNoTalkNPC; // 0x7C

		// Properties
		public bool IsReferenceData { get => default; } // 0x0080A0F0-0x0080A120 
		public bool IsEmptyActType { get => default; } // 0x00800FE0-0x00801110 
		public bool IsVisibleOff { get => default; } // 0x00807020-0x008070D0 
		public ActType ActTypeId { get => default; } // 0x00801E20-0x00802090 

		// Nested types
		public enum ActType // TypeDefIndex: 5059
		{
			NONE = 0,
			STAND = 1,
			RUNRUN = 2,
			OROORO = 3,
			NAYAMI = 4,
			ENDURE = 5,
			WALK = 6,
			WALK_HAPPY = 7,
			SERIOUS_2P = 8,
			LAUGH_2P = 9,
			WAIWAI_2P = 10,
			OBIE_2P = 11,
			SERIOUS_3P = 12,
			WAIWAI_3P = 13,
			STAND_W02 = 14,
			STAND_NZ = 15,
			SLEEP_NZ = 16,
			ASOBU = 17,
			OYAKO = 18,
			SOONANO = 19,
			SOONANSU = 20,
			KYATAPII = 21,
			MANKII = 22,
			CHAAREMU = 23,
			AABO = 24,
			SLEEP_KEEP = 25,
			SLEEP_KEEP2 = 26,
			SHOP = 27,
			VISIBLE_OFF = 28
		}

		public enum TalkTurnType // TypeDefIndex: 5060
		{
			NoTurn = 0,
			TurnAndReturn = 100,
			TurnAndNoReturn = 200,
			TurnAndWaitReturn = 300,
			NoTurnAndReturn = 400
		}

		// Constructors
		public NpcData() {} // 0x0080A8E0-0x0080A9B0
	}

	[Serializable]
	public class StepData // TypeDefIndex: 5061
	{
		// Fields
		public string stepSymbol; // 0x10
		public List<NpcData> npcDataList; // 0x18
		public List<string> addStepScriptPathList; // 0x20

		// Constructors
		public StepData() {} // 0x0080A9C0-0x0080AA60

		// Methods
		public NpcData FindNpcData(string actSymbol) => default; // 0x0080A030-0x0080A0F0
	}

	// Constructors
	public GroundTownNpcDatabase() {} // 0x0080A850-0x0080A8C0

	// Methods
	public StepData FindStepData(string stepSymbol) => default; // 0x00802090-0x00802150
	public NpcData FindNpcData(string stepSymbol, string actSymbol, out string refStepSymbol) {
		refStepSymbol = default;
		return default;
	} // 0x00802150-0x00802200
	public string MakeTownTalkScriptPath(string stepSymbol) => default; // 0x00805470-0x00805510
	public NpcData ReferenceNpcData(NpcData srcNpcData) => default; // 0x0080A120-0x0080A180
	public List<ActAssetSet> CreateActAssetSet(string stepSymbol) => default; // 0x0080A180-0x0080A850
}

