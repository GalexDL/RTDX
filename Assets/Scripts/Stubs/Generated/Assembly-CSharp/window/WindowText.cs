/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.dungeon;
using window_text;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace window
{
	public class WindowText // TypeDefIndex: 8338
	{
		// Fields
		private static ushort[] replaceTmpBuff_; // 0x00
		private static byte[] streamTmpBuff_; // 0x08
		public const ushort FLAG_DIGIT = 1; // Metadata: 0x0061452C
		public const ushort FLAG_DIGIT2 = 2; // Metadata: 0x0061452E
		public const ushort FLAG_ALPHABET = 4; // Metadata: 0x00614530
		public const ushort FLAG_LABEL = 8; // Metadata: 0x00614532
		public const ushort CODE_RETURN = 10; // Metadata: 0x00614534
		public const ushort CODE_TALK_UNKNOWN = 65290; // Metadata: 0x00614536
		public const ushort CODE_COLOR_CHAR = 40960; // Metadata: 0x00614538
		public const ushort CODE_COLOR_CHAR2 = 41216; // Metadata: 0x0061453A
		public const ushort CODE_QUEST_PB = 41472; // Metadata: 0x0061453C
		public const ushort CODE_EPSODE_PB = 41473; // Metadata: 0x0061453E
		public const ushort CODE_QUEST_IB = 41728; // Metadata: 0x00614540
		public const ushort CODE_QUEST_TITLE = 41984; // Metadata: 0x00614542
		public const ushort CODE_QUEST_TEXT = 41985; // Metadata: 0x00614544
		public const ushort CODE_QUEST_MEMO = 41986; // Metadata: 0x00614546
		public const ushort CODE_QUEST_LIST = 41987; // Metadata: 0x00614548
		public const ushort CODE_QUEST_REWARD = 41988; // Metadata: 0x0061454A
		public const ushort CODE_QUEST_DIFFICULTY = 41989; // Metadata: 0x0061454C
		public const ushort CODE_QUEST_LIMIT = 41990; // Metadata: 0x0061454E
		public const ushort CODE_REWARD_POINT = 41991; // Metadata: 0x00614550
		public const ushort CODE_QUEST_MONEY = 41992; // Metadata: 0x00614552
		public const ushort CODE_WAZA_KINSHI = 41993; // Metadata: 0x00614554
		public const ushort CODE_OTHER_TEAM = 41994; // Metadata: 0x00614556
		public const ushort CODE_OTHER_NICKNAME = 41995; // Metadata: 0x00614558
		public const ushort CODE_CHOSADAN = 41996; // Metadata: 0x0061455A
		public const ushort CODE_VALUE_M_P_S_B = 42240; // Metadata: 0x0061455C
		public const ushort CODE_REWARD_IB = 42496; // Metadata: 0x0061455E
		public const ushort CODE_NO_COLOR_PB = 42752; // Metadata: 0x00614560
		public const ushort CODE_FONT_SIZE = 49152; // Metadata: 0x00614562
		public const ushort CODE_COLOR_SET = 49408; // Metadata: 0x00614564
		public const ushort CODE_COLOR_RET = 49423; // Metadata: 0x00614566
		public const ushort CODE_CENTER = 49664; // Metadata: 0x00614568
		public const ushort CODE_RIGHT_ALIGN = 49920; // Metadata: 0x0061456A
		public const ushort CODE_SPACE_X = 50176; // Metadata: 0x0061456C
		public const ushort CODE_OFFSET_X = 50432; // Metadata: 0x0061456E
		public const ushort CODE_OFFSET_Y = 50688; // Metadata: 0x00614570
		public const ushort CODE_AUTO_RETURN = 50944; // Metadata: 0x00614572
		public const ushort CODE_FONT_SET = 51200; // Metadata: 0x00614574
		public const ushort CODE_FONT_RET = 51208; // Metadata: 0x00614576
		public const ushort CODE_LINE = 51456; // Metadata: 0x00614578
		public const ushort CODE_LINK_BEGIN = 51712; // Metadata: 0x0061457A
		public const ushort CODE_LINK_END = 51968; // Metadata: 0x0061457C
		public const ushort CODE_HEAD = 52224; // Metadata: 0x0061457E
		public const ushort CODE_PREV = 52480; // Metadata: 0x00614580
		public const ushort CODE_NEXT = 52736; // Metadata: 0x00614582
		public const ushort CODE_RUBY = 52992; // Metadata: 0x00614584
		public const ushort CODE_MY_TEAM = 53248; // Metadata: 0x00614586
		public const ushort CODE_HERO = 53504; // Metadata: 0x00614588
		public const ushort CODE_PARTNER = 53760; // Metadata: 0x0061458A
		public const ushort CODE_C_KIND = 54016; // Metadata: 0x0061458C
		public const ushort CODE_C_NAME = 54272; // Metadata: 0x0061458E
		public const ushort CODE_C_STAMMER = 54528; // Metadata: 0x00614590
		public const ushort CODE_PLAYER = 54784; // Metadata: 0x00614592
		public const ushort CODE_ITEM = 55040; // Metadata: 0x00614594
		public const ushort CODE_KIND = 55296; // Metadata: 0x00614596
		public const ushort CODE_WAZA = 55552; // Metadata: 0x00614598
		public const ushort CODE_TYPE = 55808; // Metadata: 0x0061459A
		public const ushort CODE_CATEGORY = 56064; // Metadata: 0x0061459C
		public const ushort CODE_RANGE = 56320; // Metadata: 0x0061459E
		public const ushort CODE_WEATHER = 56576; // Metadata: 0x006145A0
		public const ushort CODE_STATUS = 56832; // Metadata: 0x006145A2
		public const ushort CODE_ABILITY = 57088; // Metadata: 0x006145A4
		public const ushort CODE_SKILL = 57344; // Metadata: 0x006145A6
		public const ushort CODE_TACTICS = 57600; // Metadata: 0x006145A8
		public const ushort CODE_PLACE = 57856; // Metadata: 0x006145AA
		public const ushort CODE_RANK = 58112; // Metadata: 0x006145AC
		public const ushort CODE_VALUE = 58368; // Metadata: 0x006145AE
		public const ushort CODE_VALUE_S_B = 58624; // Metadata: 0x006145B0
		public const ushort CODE_VALUE_Z_B = 58880; // Metadata: 0x006145B2
		public const ushort CODE_MONEY = 59136; // Metadata: 0x006145B4
		public const ushort CODE_MY_MONEY = 59392; // Metadata: 0x006145B6
		public const ushort CODE_BANK = 59648; // Metadata: 0x006145B8
		public const ushort CODE_BAG = 59904; // Metadata: 0x006145BA
		public const ushort CODE_WAIT_KEY = 60160; // Metadata: 0x006145BC
		public const ushort CODE_WAIT_FRAME = 60416; // Metadata: 0x006145BE
		public const ushort CODE_PAGE_FEED = 60672; // Metadata: 0x006145C0
		public const ushort CODE_PAGE_CLEAR = 60928; // Metadata: 0x006145C2
		public const ushort CODE_SPEED = 61184; // Metadata: 0x006145C4
		public const ushort CODE_BLOCK_START = 61440; // Metadata: 0x006145C6
		public const ushort CODE_BLOCK_END = 61696; // Metadata: 0x006145C8
		public const ushort CODE_PLAY_SE = 61952; // Metadata: 0x006145CA
		public const ushort CODE_PLAY_ME = 62208; // Metadata: 0x006145CC
		public const ushort CODE_MAX = 62463; // Metadata: 0x006145CE
		public const ushort CODE_ITEM_B = 62464; // Metadata: 0x006145D0
		public const ushort CODE_IB = 62720; // Metadata: 0x006145D2
		public const ushort CODE_PB = 62976; // Metadata: 0x006145D4
		public const ushort CODE_DB = 63232; // Metadata: 0x006145D6
		public const ushort CODE_STRING = 63488; // Metadata: 0x006145D8
		public const ushort CODE_MONEY_B = 63744; // Metadata: 0x006145DA
		public const ushort CODE_MY_MONEY_B = 64000; // Metadata: 0x006145DC
		public const ushort CODE_BANK_B = 64256; // Metadata: 0x006145DE
		public const ushort CODE_SPACE_Y = 64512; // Metadata: 0x006145E0
		public const ushort CODE_VALUE_B = 64768; // Metadata: 0x006145E2
		public const ushort CODE_VALUE_D_B = 65024; // Metadata: 0x006145E4
		public const ushort CODE_STATUS_A = 45056; // Metadata: 0x006145E6
		public const ushort CODE_LFPITCH_SET = 45312; // Metadata: 0x006145E8
		public const ushort CODE_LFPITCH_RET = 45313; // Metadata: 0x006145EA
		public const ushort CODE_FACE_CHANGE = 45568; // Metadata: 0x006145EC
		public const ushort CODE_MESSAGE_LINK = 45824; // Metadata: 0x006145EE
		public const ushort CODE_NUMBER_BEGIN = 46080; // Metadata: 0x006145F0
		public const ushort CODE_NUMBER_END = 46081; // Metadata: 0x006145F2
		public const ushort CODE_VALUE_P = 46336; // Metadata: 0x006145F4
		public const ushort CODE_VALUE_P_B = 46592; // Metadata: 0x006145F6
		public const ushort CODE_VALUE_P_D_B = 46848; // Metadata: 0x006145F8
		public const ushort CODE_VALUE_P_S_B = 47104; // Metadata: 0x006145FA
		public const ushort CODE_VALUE_P_Z_B = 47360; // Metadata: 0x006145FC
		public const ushort CODE_NUMBER_HANSPACE = 47616; // Metadata: 0x006145FE
		public const ushort CODE_NUMBER_ZENSPACE = 47617; // Metadata: 0x00614600
		public const ushort CODE_NUMBER_QTRSPACE = 47618; // Metadata: 0x00614602
		public const ushort CODE_VT_LINK_BEGIN = 47872; // Metadata: 0x00614604
		public const ushort CODE_VT_LINK_END = 48128; // Metadata: 0x00614606
		public const ushort CODE_H_SELF = 48384; // Metadata: 0x00614608
		public const ushort CODE_WEATHER_A = 48640; // Metadata: 0x0061460A
		public const ushort CODE_UNIQUE_COLOR_SET = 48896; // Metadata: 0x0061460C
		public const ushort CODE_UNIQUE_COLOR_RET = 48911; // Metadata: 0x0061460E
		public const ushort CODE_EU_CONTROL = 43008; // Metadata: 0x00614610
		public const ushort CODE_UPPER_E = 43009; // Metadata: 0x00614612
		public const ushort CODE_UPPER_ER = 43010; // Metadata: 0x00614614
		public const ushort CODE_UPPER_RE = 43011; // Metadata: 0x00614616
		public const ushort CODE_UPPER_ST = 43012; // Metadata: 0x00614618
		public const ushort CODE_UPPER_ND = 43013; // Metadata: 0x0061461A
		public const ushort CODE_UPPER_RD = 43014; // Metadata: 0x0061461C
		public const ushort CODE_UPPER_TH = 43015; // Metadata: 0x0061461E
		public const ushort CODE_BRACKET_L = 43016; // Metadata: 0x00614620
		public const ushort CODE_BRACKET_R = 43017; // Metadata: 0x00614622
		public const ushort CODE_PERCENT = 43018; // Metadata: 0x00614624
		public const ushort CODE_GEN_HERO = 43019; // Metadata: 0x00614626
		public const ushort CODE_GEN_PARTNER = 43020; // Metadata: 0x00614628
		public const ushort CODE_DEF_ART = 43021; // Metadata: 0x0061462A
		public const ushort CODE_DEF_ART_CAP = 43022; // Metadata: 0x0061462C
		public const ushort CODE_IND_ART = 43023; // Metadata: 0x0061462E
		public const ushort CODE_IND_ART_CAP = 43024; // Metadata: 0x00614630
		public const ushort CODE_FORCE_SINGULAR = 43025; // Metadata: 0x00614632
		public const ushort CODE_FORCE_PLURAL = 43026; // Metadata: 0x00614634
		public const ushort CODE_SEP_NONE = 43027; // Metadata: 0x00614636
		public const ushort CODE_SEP_COMMA = 43028; // Metadata: 0x00614638
		public const ushort CODE_SEP_PERIOD = 43029; // Metadata: 0x0061463A
		public const ushort CODE_SEP_HALF_SPACE = 43030; // Metadata: 0x0061463C
		public const ushort CODE_SEP_QUARTER_SPACE = 43031; // Metadata: 0x0061463E
		public const ushort CODE_SEP_END = 43032; // Metadata: 0x00614640
		public const byte HI_CODE_RETURN = 0; // Metadata: 0x00614642
		public const byte HI_CODE_TALK_UNKNOWN = 255; // Metadata: 0x00614643
		public const byte HI_CODE_COLOR_CHAR = 160; // Metadata: 0x00614644
		public const byte HI_CODE_COLOR_CHAR2 = 161; // Metadata: 0x00614645
		public const byte HI_CODE_QUEST_PB = 162; // Metadata: 0x00614646
		public const byte HI_CODE_EPSODE_PB = 162; // Metadata: 0x00614647
		public const byte HI_CODE_QUEST_IB = 163; // Metadata: 0x00614648
		public const byte HI_CODE_QUEST_TITLE = 164; // Metadata: 0x00614649
		public const byte HI_CODE_QUEST_TEXT = 164; // Metadata: 0x0061464A
		public const byte HI_CODE_QUEST_MEMO = 164; // Metadata: 0x0061464B
		public const byte HI_CODE_QUEST_LIST = 164; // Metadata: 0x0061464C
		public const byte HI_CODE_QUEST_REWARD = 164; // Metadata: 0x0061464D
		public const byte HI_CODE_QUEST_DIFFICULTY = 164; // Metadata: 0x0061464E
		public const byte HI_CODE_QUEST_LIMIT = 164; // Metadata: 0x0061464F
		public const byte HI_CODE_REWARD_POINT = 164; // Metadata: 0x00614650
		public const byte HI_CODE_QUEST_MONEY = 164; // Metadata: 0x00614651
		public const byte HI_CODE_WAZA_KINSHI = 164; // Metadata: 0x00614652
		public const byte HI_CODE_OTHER_TEAM = 164; // Metadata: 0x00614653
		public const byte HI_CODE_OTHER_NICKNAME = 164; // Metadata: 0x00614654
		public const byte HI_CODE_CHOSADAN = 164; // Metadata: 0x00614655
		public const byte HI_CODE_VALUE_M_P_S_B = 165; // Metadata: 0x00614656
		public const byte HI_CODE_REWARD_IB = 166; // Metadata: 0x00614657
		public const byte HI_CODE_NO_COLOR_PB = 167; // Metadata: 0x00614658
		public const byte HI_CODE_FONT_SIZE = 192; // Metadata: 0x00614659
		public const byte HI_CODE_COLOR_SET = 193; // Metadata: 0x0061465A
		public const byte HI_CODE_COLOR_RET = 193; // Metadata: 0x0061465B
		public const byte HI_CODE_CENTER = 194; // Metadata: 0x0061465C
		public const byte HI_CODE_RIGHT_ALIGN = 195; // Metadata: 0x0061465D
		public const byte HI_CODE_SPACE_X = 196; // Metadata: 0x0061465E
		public const byte HI_CODE_OFFSET_X = 197; // Metadata: 0x0061465F
		public const byte HI_CODE_OFFSET_Y = 198; // Metadata: 0x00614660
		public const byte HI_CODE_AUTO_RETURN = 199; // Metadata: 0x00614661
		public const byte HI_CODE_FONT_SET = 200; // Metadata: 0x00614662
		public const byte HI_CODE_FONT_RET = 200; // Metadata: 0x00614663
		public const byte HI_CODE_LINE = 201; // Metadata: 0x00614664
		public const byte HI_CODE_LINK_BEGIN = 202; // Metadata: 0x00614665
		public const byte HI_CODE_LINK_END = 203; // Metadata: 0x00614666
		public const byte HI_CODE_HEAD = 204; // Metadata: 0x00614667
		public const byte HI_CODE_PREV = 205; // Metadata: 0x00614668
		public const byte HI_CODE_NEXT = 206; // Metadata: 0x00614669
		public const byte HI_CODE_RUBY = 207; // Metadata: 0x0061466A
		public const byte HI_CODE_MY_TEAM = 208; // Metadata: 0x0061466B
		public const byte HI_CODE_HERO = 209; // Metadata: 0x0061466C
		public const byte HI_CODE_PARTNER = 210; // Metadata: 0x0061466D
		public const byte HI_CODE_C_KIND = 211; // Metadata: 0x0061466E
		public const byte HI_CODE_C_NAME = 212; // Metadata: 0x0061466F
		public const byte HI_CODE_C_STAMMER = 213; // Metadata: 0x00614670
		public const byte HI_CODE_PLAYER = 214; // Metadata: 0x00614671
		public const byte HI_CODE_ITEM = 215; // Metadata: 0x00614672
		public const byte HI_CODE_KIND = 216; // Metadata: 0x00614673
		public const byte HI_CODE_WAZA = 217; // Metadata: 0x00614674
		public const byte HI_CODE_TYPE = 218; // Metadata: 0x00614675
		public const byte HI_CODE_CATEGORY = 219; // Metadata: 0x00614676
		public const byte HI_CODE_RANGE = 220; // Metadata: 0x00614677
		public const byte HI_CODE_WEATHER = 221; // Metadata: 0x00614678
		public const byte HI_CODE_STATUS = 222; // Metadata: 0x00614679
		public const byte HI_CODE_ABILITY = 223; // Metadata: 0x0061467A
		public const byte HI_CODE_SKILL = 224; // Metadata: 0x0061467B
		public const byte HI_CODE_TACTICS = 225; // Metadata: 0x0061467C
		public const byte HI_CODE_PLACE = 226; // Metadata: 0x0061467D
		public const byte HI_CODE_RANK = 227; // Metadata: 0x0061467E
		public const byte HI_CODE_VALUE = 228; // Metadata: 0x0061467F
		public const byte HI_CODE_VALUE_S_B = 229; // Metadata: 0x00614680
		public const byte HI_CODE_VALUE_Z_B = 230; // Metadata: 0x00614681
		public const byte HI_CODE_MONEY = 231; // Metadata: 0x00614682
		public const byte HI_CODE_MY_MONEY = 232; // Metadata: 0x00614683
		public const byte HI_CODE_BANK = 233; // Metadata: 0x00614684
		public const byte HI_CODE_BAG = 234; // Metadata: 0x00614685
		public const byte HI_CODE_WAIT_KEY = 235; // Metadata: 0x00614686
		public const byte HI_CODE_WAIT_FRAME = 236; // Metadata: 0x00614687
		public const byte HI_CODE_PAGE_FEED = 237; // Metadata: 0x00614688
		public const byte HI_CODE_PAGE_CLEAR = 238; // Metadata: 0x00614689
		public const byte HI_CODE_SPEED = 239; // Metadata: 0x0061468A
		public const byte HI_CODE_BLOCK_START = 240; // Metadata: 0x0061468B
		public const byte HI_CODE_BLOCK_END = 241; // Metadata: 0x0061468C
		public const byte HI_CODE_PLAY_SE = 242; // Metadata: 0x0061468D
		public const byte HI_CODE_PLAY_ME = 243; // Metadata: 0x0061468E
		public const byte HI_CODE_MAX = 243; // Metadata: 0x0061468F
		public const byte HI_CODE_ITEM_B = 244; // Metadata: 0x00614690
		public const byte HI_CODE_IB = 245; // Metadata: 0x00614691
		public const byte HI_CODE_PB = 246; // Metadata: 0x00614692
		public const byte HI_CODE_DB = 247; // Metadata: 0x00614693
		public const byte HI_CODE_STRING = 248; // Metadata: 0x00614694
		public const byte HI_CODE_MONEY_B = 249; // Metadata: 0x00614695
		public const byte HI_CODE_MY_MONEY_B = 250; // Metadata: 0x00614696
		public const byte HI_CODE_BANK_B = 251; // Metadata: 0x00614697
		public const byte HI_CODE_SPACE_Y = 252; // Metadata: 0x00614698
		public const byte HI_CODE_VALUE_B = 253; // Metadata: 0x00614699
		public const byte HI_CODE_VALUE_D_B = 254; // Metadata: 0x0061469A
		public const byte HI_CODE_STATUS_A = 176; // Metadata: 0x0061469B
		public const byte HI_CODE_LFPITCH_SET = 177; // Metadata: 0x0061469C
		public const byte HI_CODE_LFPITCH_RET = 177; // Metadata: 0x0061469D
		public const byte HI_CODE_FACE_CHANGE = 178; // Metadata: 0x0061469E
		public const byte HI_CODE_MESSAGE_LINK = 179; // Metadata: 0x0061469F
		public const byte HI_CODE_NUMBER_BEGIN = 180; // Metadata: 0x006146A0
		public const byte HI_CODE_NUMBER_END = 180; // Metadata: 0x006146A1
		public const byte HI_CODE_VALUE_P = 181; // Metadata: 0x006146A2
		public const byte HI_CODE_VALUE_P_B = 182; // Metadata: 0x006146A3
		public const byte HI_CODE_VALUE_P_D_B = 183; // Metadata: 0x006146A4
		public const byte HI_CODE_VALUE_P_S_B = 184; // Metadata: 0x006146A5
		public const byte HI_CODE_VALUE_P_Z_B = 185; // Metadata: 0x006146A6
		public const byte HI_CODE_NUMBER_HANSPACE = 186; // Metadata: 0x006146A7
		public const byte HI_CODE_NUMBER_ZENSPACE = 186; // Metadata: 0x006146A8
		public const byte HI_CODE_VT_LINK_BEGIN = 187; // Metadata: 0x006146A9
		public const byte HI_CODE_VT_LINK_END = 188; // Metadata: 0x006146AA
		public const byte HI_CODE_H_SELF = 189; // Metadata: 0x006146AB
		public const byte HI_CODE_WEATHER_A = 190; // Metadata: 0x006146AC
		public const byte HI_CODE_UNIQUE_COLOR_SET = 191; // Metadata: 0x006146AD
		public const byte HI_CODE_UNIQUE_COLOR_RET = 191; // Metadata: 0x006146AE
		public const byte HI_CODE_EU_CONTROL = 168; // Metadata: 0x006146AF
	
		// Nested types
		public enum Number // TypeDefIndex: 8339
		{
			NUMBER_V0 = 0,
			NUMBER_V1 = 1,
			NUMBER_V2 = 2,
			NUMBER_V3 = 3,
			NUMBER_V4 = 4,
			NUMBER_V5 = 5,
			NUMBER_V6 = 6,
			NUMBER_V7 = 7,
			NUMBER_V8 = 8,
			NUMBER_V9 = 9,
			NUMBER_VPL = 10,
			NUMBER_VMN = 11,
			NUMBER_VSL = 12,
			NUMBER_VHS = 13,
			NUMBER_VZS = 14,
			NUMBER_VPR = 15,
			NUMBER_VCN = 16,
			NUMBER_VAS = 17,
			NUMBER_VBRS = 18,
			NUMBER_VBRE = 19
		}
	
		// Constructors
		public WindowText() {} // 0x01623B30-0x01623B40
		static WindowText() {} // 0x01623B40-0x01623BD0
	
		// Methods
		public static int ConvertCharNumber(ushort code) => default; // 0x01622E90-0x01622F90
		public static void ReplaceValue(out ushort[] pDst, string pSrc, bool talkOffset, FontType eFontType) {
			pDst = default;
		} // 0x01622F90-0x016231E0
		public static string ReplaceValue(string pSrc, bool talkOffset) => default; // 0x016231E0-0x016232A0
		public static int GetTextWidth(string pText, FontType eFontType, bool bCharNumber = false /* Metadata: 0x00614527 */, bool bMultiLine = false /* Metadata: 0x00614528 */) => default; // 0x016232A0-0x016233A0
		public static int GetTextWidth_NotReplace(ushort[] pText, FontType eFontType, bool bAutoReturnEnd = false /* Metadata: 0x00614529 */, bool bCharNumber = false /* Metadata: 0x0061452A */, bool bMultiLine = false /* Metadata: 0x0061452B */) => default; // 0x016233A0-0x01623440
		public static RectangleS32 GetRectTableBuffer(int index) => default; // 0x01623440-0x01623580
		public static short GetOffsetWidthTable(int index) => default; // 0x01623580-0x016235F0
		public static bool GetMarkFrameColorFlagTable(int index) => default; // 0x016235F0-0x01623660
		public static string GetFloorSymbol(Index index) => default; // 0x01623660-0x01623780
		public static TextSizeParameter GetTextInfo(TextIDHash hashId) => default; // 0x01623780-0x01623830
		public static TextSizeParameter GetTextInfoFromTypeSymbol(uint typeSymbol) => default; // 0x01623830-0x016239B0
		public static List<uint> GetTextInfoList() => default; // 0x016239C0-0x01623B30
	}
}
