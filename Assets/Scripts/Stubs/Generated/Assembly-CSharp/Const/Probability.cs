/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;
using Const.status;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace Const
{
	public class Probability // TypeDefIndex: 8620
	{
		// Fields
		public const int RATE_HIT_ITEM_THROW = 94; // Metadata: 0x0062A82D
		public const int VALUE_BELLY_DECREASE_IN_WALL = 1000; // Metadata: 0x0062A831
		public const int RATE_DAMAGE_IN_WALL = 5; // Metadata: 0x0062A835
		public const int VALUE_HP_RECOVER_CYCLE = 50; // Metadata: 0x0062A839
		public static readonly int[] VALUE_HOUSE_ITEM_COUNT_MAX; // 0x00
		public static readonly int[] VALUE_HOUSE_TRAP_COUNT_MAX; // 0x08
		public const int VALUE_HOUSE_POKEMON_COUNT = 12; // Metadata: 0x0062A83D
		public const int VALUE_HOUSE_POKEMON_ARRIVE_COUNT = 5; // Metadata: 0x0062A841
		public const int TURN_APPEAR_TENSYU = 5; // Metadata: 0x0062A845
		public const int DAMAGE_THROW_ITEM = 2; // Metadata: 0x0062A849
		public const int VALUE_BELLY_DECREASE_BASE = 30; // Metadata: 0x0062A84D
		public const float VALUE_BELLY_DECREASE_PUSH_RATE = 3.75f; // Metadata: 0x0062A851
		public const int VALUE_DAMAGE_HUNGRY = 3; // Metadata: 0x0062A855
		public const int VALUE_THROW_DISTANCE = 10; // Metadata: 0x0062A859
		public const int VALUE_BLOW_DISTANCE = 10; // Metadata: 0x0062A85D
		public const int DAMAGE_BLOW = 5; // Metadata: 0x0062A861
		public const int VALUE_MAX_MAXHP = 500; // Metadata: 0x0062A865
		public const int VALUE_MIN_MAXHP = 1; // Metadata: 0x0062A869
		public const int VALUE_BELLY_BASE = 200; // Metadata: 0x0062A86D
		public const int VALUE_MAX_BELLY = 200; // Metadata: 0x0062A871
		public const int VALUE_MIN_BELLY = 1; // Metadata: 0x0062A875
		public const int VALUE_BANK_MAX = 9999999; // Metadata: 0x0062A879
		public const int VALUE_BAG_CAPACITY_PER_PAGE = 8; // Metadata: 0x0062A87D
		public const int VALUE_BAG_INITIAL_CAPACITY = 3; // Metadata: 0x0062A881
		public const int VALUE_BAG_CAPACITY_INCREASE_AFTER_TEAM = 1; // Metadata: 0x0062A885
		public const int RATE_BAG_PENALTY = 100; // Metadata: 0x0062A889
		public const int RATE_MONEY_PENALTY = 100; // Metadata: 0x0062A88D
		public const int VALUE_UPDATE_NAJIMI = 2; // Metadata: 0x0062A891
		public const int VALUE_MAX_NAJIMI = 999; // Metadata: 0x0062A895
		public static readonly int[] RATE_EXECUTE_TRAP_HIDDEN; // 0x10
		public static readonly int[] RATE_EXECUTE_TRAP; // 0x18
		public const int TURN_WIND_LEVEL_1 = 300; // Metadata: 0x0062A899
		public const int TURN_WIND_LEVEL_2 = 200; // Metadata: 0x0062A89D
		public const int TURN_WIND_LEVEL_3 = 100; // Metadata: 0x0062A8A1
		public const int RATE_QUEST_WIND = 0; // Metadata: 0x0062A8A5
		public static readonly float[] RENKETSU_EXPERIENCE_BONUS; // 0x20
		public static readonly float[] RENKETSU_WAZA_EXP_BONUS; // 0x28
		public static readonly int[] RENKETSU_WAZA_BELLY; // 0x30
		public static readonly Const.waza.Index[] RENKETSU_FORBIDDEN_WAZA; // 0x38
		public const int VALUE_WAZA_HEAL_HP_THRESHOLD = 49; // Metadata: 0x0062A8A9
		public const float RATE_SOREPOINT = 1.4f; // Metadata: 0x0062A8AD
		public const float RATE_SAME_TYPE_WAZA = 1.2f; // Metadata: 0x0062A8B1
		public static readonly int[] RATE_JOIN_PARTY_1; // 0x40
		public static readonly int[] RATE_JOIN_PARTY_11; // 0x48
		public static readonly int[] RATE_JOIN_PARTY_21; // 0x50
		public static readonly int[] RATE_JOIN_PARTY_31; // 0x58
		public static readonly int[] RATE_JOIN_PARTY_41; // 0x60
		public static readonly int[] RATE_JOIN_PARTY_51; // 0x68
		public static readonly int[] RATE_JOIN_PARTY_61; // 0x70
		public static readonly int[] RATE_JOIN_PARTY_71; // 0x78
		public static readonly int[] RATE_JOIN_PARTY_81; // 0x80
		public static readonly int[] RATE_JOIN_PARTY_91; // 0x88
		public const int JOIN_ENEMY_LEVEL_BORDER = 51; // Metadata: 0x0062A8B5
		public const int MAX_ADD_JOIN_RATE = 550; // Metadata: 0x0062A8B9
		public const float VALUE_CALC_A = 1.33f; // Metadata: 0x0062A8BD
		public const float VALUE_CALC_B = 50f; // Metadata: 0x0062A8C1
		public const float VALUE_CALC_C = 2f; // Metadata: 0x0062A8C5
		public const float VALUE_CALC_D = 0.6f; // Metadata: 0x0062A8C9
		public const float VALUE_CALC_E = 0f; // Metadata: 0x0062A8CD
		public const float VALUE_CALC_F = 0.5f; // Metadata: 0x0062A8D1
		public const float VALUE_CALC_G = 8f; // Metadata: 0x0062A8D5
		public const float VALUE_CALC_H = -311f; // Metadata: 0x0062A8D9
		public const int RATE_AVOID_STAIRS_ROOM = 50; // Metadata: 0x0062A8DD
		public const int VALUE_BARRICADE_PARTY_DISTANCE = 3; // Metadata: 0x0062A8E1
		public static readonly int[] RATE_CAN_PICKUP_ITEM; // 0x90
		public const float RATE_EXP_TO_WHEREHOUSE = 1f; // Metadata: 0x0062A8E5
		public const int SEAL_COUNT_NORMALROOM = 5; // Metadata: 0x0062A8E9
		public const int SEAL_COUNT_BIGROOM = 12; // Metadata: 0x0062A8ED
		public const int SEAL_COUNT_AMPLITUDE_NORMALROOM = 3; // Metadata: 0x0062A8F1
		public const int SEAL_COUNT_AMPLITUDE_BIGROOM = 4; // Metadata: 0x0062A8F5
		public const float SEALPANEL_KNOWN_FLOOR_RATE = 1f; // Metadata: 0x0062A8F9
		public const int SEALPANEL_BONUS_COUNT = 20; // Metadata: 0x0062A8FD
		public const int SEALBREAK_BONUS_MIN = 3; // Metadata: 0x0062A901
		public const int SEALBREAK_BONUS_MAX = 5; // Metadata: 0x0062A905
		public const int DUNGEON_1x1BUILDER_SMALLFLOOR_RATE = 15; // Metadata: 0x0062A909
		public const int RINGLE_APPEAR_WITH_SEAL_RATE = 50; // Metadata: 0x0062A90D
		public const int RELIEF_DUNGEON_PARTY_DEAD_COUNT = 1; // Metadata: 0x0062A911
		public static readonly int[] RELIEF_DUNGEON_FUKKATSU_SEED_COUNT; // 0x98
		public const int RELIEF_DUNGEON_FUKKATSU_SEED_COUNT_CLOSE = 14; // Metadata: 0x0062A915
		public const int RELIEF_DUNGEON_OPEN_DAYS = 2; // Metadata: 0x0062A919
		public const float OSUSUME_POKEMON_SELF_BONUS = 3f; // Metadata: 0x0062A91D
		public const float OSUSUME_POKEMON_TRIO_BONUS = 1.3f; // Metadata: 0x0062A921
		public const float OSUSUME_POKEMON_ANNOON_BONUS = 2f; // Metadata: 0x0062A925
		public const float KABAI_KOKYUUWOAWASERU_BONUS = 1.3f; // Metadata: 0x0062A929
		public const int ENEMY_ROOM_ATTACK_LIMIT_RANGE = 5; // Metadata: 0x0062A92D
		public static readonly float[] KABAI_NAKAMAWOKABAU_MUKOUKA_RATE; // 0xA0
		public static readonly float[] KABAI_NAKAMAWOKABAU_LEVELSA_RATE; // 0xA8
		public static readonly float[] KABAI_NAKAMANOCHIRYOU_BONUS_RATE; // 0xB0
		public const int WISDOM_WAZA_LEARN_SPECIAL_DRAWING = 101; // Metadata: 0x0062A931
		public static readonly float[] RATE_ATTACK_DAMAGE_LEVEL; // 0xB8
		public static readonly float[] RATE_DEFEND_DAMAGE_LEVEL; // 0xC0
		public static readonly float[] RATE_MORAIBI_DAMAGE_LEVEL; // 0xC8
		public static readonly float[] RATE_HIT_LEVEL; // 0xD0
		public static readonly float[] RATE_DODGE_LEVEL; // 0xD8
		public static readonly float[] SUBAYASA_RATIO_FOR_DAMAGE_RATE; // 0xE0
		public static readonly float[] DAMAGE_RATE_BY_SUBAYASA_RATIO; // 0xE8
		public static readonly float[] SUBAYASA_RATIO_FOR_HIT_RATE; // 0xF0
		public static readonly int[] HIT_RATE_BY_SUBAYASA_RATIO; // 0xF8
		public static readonly int[] SUBAYASA_VALUE_TO_LEVEL; // 0x100
		public static readonly int[] SUBAYASA_CONSECUTIVE_ATTACK_RATE; // 0x108
		public static readonly int[] SUBAYASA_CONSECUTIVE_ATTACK_RATE_ENEMY; // 0x110
		public static readonly int[] SUBAYASA_CONSECUTIVE_ATTACK_RATE_BOSS; // 0x118
		public static readonly float[] DAMAGE_RATE_AFFINITY_RATIO; // 0x120
		public static readonly float[] DAMAGE_RATE_AFFINITY_RATIO_KYOUTEKI; // 0x128
		public static readonly float[] LEVEL_REVISE_RATE_FOR_DAMAGE; // 0x130
		public const int TURN_LIMIT_WEATHER = 66; // Metadata: 0x0062A935
		public const int TURN_LIMIT_MEGAWEATHER = 33; // Metadata: 0x0062A939
		public const int TURN_LIMIT_START_WEATHER = 5; // Metadata: 0x0062A93D
		public const int TURN_LIMIT_START_MEGAWEATHER = 3; // Metadata: 0x0062A941
		public const int TURN_LIMIT_NIJIIROWEATHER = 5; // Metadata: 0x0062A945
		public const int TURN_LIMIT_TENKIKOTEI = -1; // Metadata: 0x0062A949
		public const int TURN_BAD_WEATHER = 10; // Metadata: 0x0062A94D
		public const int TURN_HEAL_WEATHER = 5; // Metadata: 0x0062A951
		public const int DAMAGE_BAD_WEATHER = 3; // Metadata: 0x0062A955
		public const float RATE_POWER_WATER_RAIN = 1.5f; // Metadata: 0x0062A959
		public const float RATE_POWER_FIRE_RAIN = 0.75f; // Metadata: 0x0062A95D
		public const float OOAME_WATER_POWER = 1.5f; // Metadata: 0x0062A961
		public const float OOAME_FIRE_POWER = 0.1f; // Metadata: 0x0062A965
		public const float RATE_POWER_WATER_SUN = 0.75f; // Metadata: 0x0062A969
		public const float RATE_POWER_FIRE_SUN = 1.5f; // Metadata: 0x0062A96D
		public const float OOHIDERI_WATER_POWER = 0.1f; // Metadata: 0x0062A971
		public const float OOHIDERI_FIRE_POWER = 1.5f; // Metadata: 0x0062A975
		public const int VALUE_EXDEF_UP_ROCK_SANDSTORM = 2; // Metadata: 0x0062A979
		public const int DAMAGE_JIBAKU = 40; // Metadata: 0x0062A97D
		public const int DAMAGE_DAIBAKUHATSU = 80; // Metadata: 0x0062A981
		public const int DOROASOBI_TURN_LIMIT = 20; // Metadata: 0x0062A985
		public const float DOROASOBI_RATE = 0.75f; // Metadata: 0x0062A989
		public const int MIZUASOBI_TURN_LIMIT = 20; // Metadata: 0x0062A98D
		public const float MIZUASOBI_RATE = 0.75f; // Metadata: 0x0062A991
		public const int MAGICROOM_TURN_LIMIT = 20; // Metadata: 0x0062A995
		public const int TRICKROOM_TURN_LIMIT = -1; // Metadata: 0x0062A999
		public const int JUURYOKU_TURN_LIMIT = 20; // Metadata: 0x0062A99D
		public const int WONDERROOM_TURN_LIMIT = 20; // Metadata: 0x0062A9A1
		public const int JUURYOKU_EVADE_RANK = 1; // Metadata: 0x0062A9A5
		public const int PLASMASHOWER_TURN_LIMIT = 10; // Metadata: 0x0062A9A9
		public const int GRASSFIELD_TURN_LIMIT = 10; // Metadata: 0x0062A9AD
		public const float GRASSFIELD_GRASS_DAMAGE_RATE = 1.5f; // Metadata: 0x0062A9B1
		public const float GRASSFIELD_HP_HEAL_RATE = 3f; // Metadata: 0x0062A9B5
		public const int MISTFIELD_TURN_LIMIT = 10; // Metadata: 0x0062A9B9
		public const float MISTFIELD_DRAGON_DAMAGE_RATE = 0.5f; // Metadata: 0x0062A9BD
		public const int EREKIFIELD_TURN_LIMIT = 10; // Metadata: 0x0062A9C1
		public const float EREKIFIELD_ELECTRICK_DAMAGE_RATE = 1.5f; // Metadata: 0x0062A9C5
		public const int VALUE_TAKUWAERU_LIMIT = 3; // Metadata: 0x0062A9C9
		public const int MIGAWARI_HP_RATE = 50; // Metadata: 0x0062A9CD
		public const int DEFENCE_RATE = 50; // Metadata: 0x0062A9D1
		public static readonly int[] MAGNITUDE_VALUE; // 0x138
		public static readonly int[] MAGNITUDE_DAMAGE; // 0x140
		public static readonly int[] MAGNITUDE_DAMAGE_RATE; // 0x148
		public static readonly int[] MAGNITUDE_RATE; // 0x150
		public const float WAZA_MAGNIFICATION_MIN_RATE = 0.01f; // Metadata: 0x0062A9D5
		public const float WAZA_MAGNIFICATION_MAX_RATE = 2f; // Metadata: 0x0062A9D9
		public static readonly Const.item.Index[] WAZA_RECYCLE_CHOICE; // 0x158
		public static readonly int[] WAZA_RECYCLE_RATE; // 0x160
		public static readonly int[] KETAGURI_WEIGHT; // 0x168
		public static readonly float[] KETAGURI_DAMAGE_RATE; // 0x170
		public static readonly int[] KETAGURI_POWER; // 0x178
		public static readonly int[] HEAVYBOMBER_HP; // 0x180
		public static readonly float[] HEAVYBOMBER_DAMAGE_RATE; // 0x188
		public static readonly int[] HEAVYBOMBER_POWER; // 0x190
		public const int VALUE_KATAKIUCHI = 2; // Metadata: 0x0062A9DD
		public static readonly int[] PRESENT_RATE; // 0x198
		public static readonly int[] PRESENT_POWER; // 0x1A0
		public const int PRESENT_HEAL = 25; // Metadata: 0x0062A9E1
		public static readonly Const.status.Index[] WAZA_DARKMATTER_STATUS; // 0x1A8
		public static readonly int[] WAZA_DARKMATTER_INVOKE_RATE; // 0x1B0
		public const int ABSORB_HP_RATE = 20; // Metadata: 0x0062A9E5
		public const float RATE_PINCH_DAMAGE = 1.5f; // Metadata: 0x0062A9E9
		public const float WEATHER_HEAL_RATE = 1.5f; // Metadata: 0x0062A9ED
		public const int AKUSHUU_RATE = 9; // Metadata: 0x0062A9F1
		public const int AKUSHUU_TURN = 4; // Metadata: 0x0062A9F5
		public const int RATE_SEIDENKI = 18; // Metadata: 0x0062A9F9
		public const int RATE_DOKUNOTOGE = 18; // Metadata: 0x0062A9FD
		public const int RATE_HONOONOKARADA = 18; // Metadata: 0x0062AA01
		public const int RATE_MEROMEROBODY = 18; // Metadata: 0x0062AA05
		public const int RATE_HOUSHI = 18; // Metadata: 0x0062AA09
		public const float RATE_ATSUISHIBOU = 0.7f; // Metadata: 0x0062AA0D
		public const float RATE_IKAKU = 0.85f; // Metadata: 0x0062AA11
		public const int RATE_IYASHINOKOKORO = 20; // Metadata: 0x0062AA15
		public const float KANSOUHADA_FIRE_RATE = 1.2f; // Metadata: 0x0062AA19
		public const float KIKENYOCHI_RATE = 18f; // Metadata: 0x0062AA1D
		public const float RATE_KONJOU = 1.5f; // Metadata: 0x0062AA21
		public const int RATE_SAISEIRYOKU = 20; // Metadata: 0x0062AA25
		public const int SAMEHADA_RATE = 10; // Metadata: 0x0062AA29
		public const int RATE_DOKUSHU = 15; // Metadata: 0x0062AA2D
		public const int JISHINKAJOU_RATE = 18; // Metadata: 0x0062AA31
		public const int SHOURINOHOSHI_RANK = 2; // Metadata: 0x0062AA35
		public const float RATE_SUNANOCHIKARA = 2f; // Metadata: 0x0062AA39
		public const int RATE_DAPPI = 25; // Metadata: 0x0062AA3D
		public const int RATE_CHIKARAMOCHI_ACTIVATE = 20; // Metadata: 0x0062AA41
		public const float RATE_CHIKARAMOCHI_DAMAGE = 1.5f; // Metadata: 0x0062AA45
		public const float RATE_TEKIOURYOKU = 1.2f; // Metadata: 0x0062AA49
		public const int VALUE_TECHNICIAN_THRESHOLD = 5; // Metadata: 0x0062AA4D
		public const float RATE_TECHNICIAN_DAMAGE = 1.2f; // Metadata: 0x0062AA51
		public const float RATE_TETSUNOKOBUSHI = 1.2f; // Metadata: 0x0062AA55
		public const float RATE_TENNOMEGUMI = 2f; // Metadata: 0x0062AA59
		public const float RATE_TOUSOUSHIN = 1.2f; // Metadata: 0x0062AA5D
		public const float RATE_CHIKARAZUKU = 1.2f; // Metadata: 0x0062AA61
		public const float RATE_HARDROCK = 0.85f; // Metadata: 0x0062AA65
		public const int VALUE_HARIKIRI_ATTACK = 3; // Metadata: 0x0062AA69
		public const int VALUE_HARIKIRI_HIT = 1; // Metadata: 0x0062AA6D
		public const int VALUE_FUKUGAN_HIT = 2; // Metadata: 0x0062AA71
		public const int PLUS_MINUS_RANK = 2; // Metadata: 0x0062AA75
		public const int MONOHIROI_RATE = 20; // Metadata: 0x0062AA79
		public const int YUKIGAKURE_RANK = 2; // Metadata: 0x0062AA7D
		public const int RATE_YOWAKI = 50; // Metadata: 0x0062AA81
		public const float RATE_YOWAKI_DAMAGE = 0.7f; // Metadata: 0x0062AA85
		public const int KUISHINBOU_HP = 25; // Metadata: 0x0062AA89
		public const int ABILITY_IKARINOTSUBO_RANK = 3; // Metadata: 0x0062AA8D
		public const float ABILITY_IROMEGANE_RATE = 1.4f; // Metadata: 0x0062AA91
		public const int ABILITY_KYOUUN_RATE = 15; // Metadata: 0x0062AA95
		public const float ABILITY_SUNPOWER_RATE = 1.5f; // Metadata: 0x0062AA99
		public const float ABILITY_SUTEMI_RATE = 1.2f; // Metadata: 0x0062AA9D
		public const int ABILITY_YUUBAKU_ACTIVATE_HP_RATE = 30; // Metadata: 0x0062AAA1
		public const int ABILITY_YUUBAKU_COUNTER_DAMAGE_RATE = 25; // Metadata: 0x0062AAA5
		public const float ABILITY_GANJOUAGO_RATE = 1.2f; // Metadata: 0x0062AAA9
		public const float ABILITY_MEGALAUNCHER_RATE = 1.2f; // Metadata: 0x0062AAAD
		public const float ABILITY_KATAITSUME_RATE = 1.2f; // Metadata: 0x0062AAB1
		public const float ABILITY_SNIPER_RATE = 1.2f; // Metadata: 0x0062AAB5
		public const float ABILITY_FREEZESKIN_RATE = 1.2f; // Metadata: 0x0062AAB9
		public const int ABILITY_DOWNLOAD_RANK = 2; // Metadata: 0x0062AABD
		public const int ABILITY_DOWNLOAD_RATE = 15; // Metadata: 0x0062AAC1
		public const int ABILITY_CHIDORIASHI_RANK = 2; // Metadata: 0x0062AAC5
		public const int ABILITY_NOROWAREBODY_RATE = 5; // Metadata: 0x0062AAC9
		public const int ABILITY_FLOWERGIFT_RANK_ATTACK = 2; // Metadata: 0x0062AACD
		public const int ABILITY_FLOWERGIFT_RANK_SP_DEFENCE = 2; // Metadata: 0x0062AAD1
		public const int ABILITY_MIRACLESKIN_RATE = 50; // Metadata: 0x0062AAD5
		public const float ABILITY_FURCOAT_RATE = 0.8f; // Metadata: 0x0062AAD9
		public const float ABILITY_DARKAURA_RATE = 1.5f; // Metadata: 0x0062AADD
		public const float ABILITY_AURABREAK_RATE = 0.75f; // Metadata: 0x0062AAE1
		public const float ABILITY_ILLUSION_ATTACK_RATE = 1.5f; // Metadata: 0x0062AAE5
		public const float ABILITY_ILLUSION_DEFENSE_RATE = 0.75f; // Metadata: 0x0062AAE9
		public const float ABILITY_NAMAKE_RATE = 23f; // Metadata: 0x0062AAED
		public const float ABILITY_MITSUATSUME_RATE = 20f; // Metadata: 0x0062AAF1
		public const float ABILITY_FUSHIGINAUROKO_RANK = 2f; // Metadata: 0x0062AAF5
		public const float ABILITY_NIGHTMARE_DANAGE = 15f; // Metadata: 0x0062AAF9
		public const float ABILITY_KASOKU_TURN = 15f; // Metadata: 0x0062AAFD
		public const int ABILITY_SHADOW_OF_NIHIL_LIMIT = 10; // Metadata: 0x0062AB01
		public static readonly int[] ABILITY_SHADOW_OF_NIHIL_RATE; // 0x1B8
		public static readonly int[] ABILITY_SHADOW_OF_NIHIL_HP_BORDER; // 0x1C0
		public const float ABILITY_MAGICIAN_RATE = 50f; // Metadata: 0x0062AB05
		public static readonly int[] AYATSURARE_TYPE_RATE; // 0x1C8
		public static readonly int[] CHIKYUNAGE_LEVEL; // 0x1D0
		public static readonly int[] CHIKYUNAGE_DISTANCE; // 0x1D8
		public const int CHIKYUNAGE_DAMAGE = 10; // Metadata: 0x0062AB09
		public static readonly int[] RYUUNOIKARI_RATE; // 0x1E0
		public static readonly int[] RYUUNOIKARI_LV; // 0x1E8
		public const int TAMANAGE_RATE = 50; // Metadata: 0x0062AB0D
		public const int SAIMINJUTSU_LV = 1; // Metadata: 0x0062AB11
		public const float WAZA_USE_RATE_LOW_MODIFY = 0.5f; // Metadata: 0x0062AB15
		public const float WAZA_USE_RATE_HIGH_MODIFY = 1f; // Metadata: 0x0062AB19
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_FRIEND_MOVE_TABLE; // 0x1F0
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_ENEMY_MOVE_TABLE; // 0x1F8
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_FRIEND_WAZA_TABLE; // 0x200
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_ENEMY_WAZA_TABLE; // 0x208
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_FRIEND_DAMAGE_TABLE; // 0x210
		public static readonly int[] VALUE_MEGA_BOUSOU_POINT_ENEMY_DAMAGE_TABLE; // 0x218
		public const int VALUE_MEGA_BOUSOU_POINT_MOVE_SUB = 0; // Metadata: 0x0062AB1D
		public const int VALUE_MEGA_BOUSOU_LIMIT = 600; // Metadata: 0x0062AB21
		public const int VALUE_MEGA_KIRAKIRA_RATE = 7; // Metadata: 0x0062AB25
		public const int RATE_WANAKOWASHI = 30; // Metadata: 0x0062AB29
		public const int RATE_BATSUGUN_SKILL = 15; // Metadata: 0x0062AB2D
		public const float RATE_KAIFUKU = 1.3f; // Metadata: 0x0062AB31
		public const int RATE_NIDOME = 50; // Metadata: 0x0062AB35
		public const int RATE_DOTANBA = 25; // Metadata: 0x0062AB39
		public const float RATE_TAKARA = 1.25f; // Metadata: 0x0062AB3D
		public const int VALUE_PP_IYASHI = 2; // Metadata: 0x0062AB41
		public const int RATE_PP_IYASHI = 25; // Metadata: 0x0062AB45
		public const int RATE_KAIDAN = 25; // Metadata: 0x0062AB49
		public static readonly int[] RATE_FUNBARI; // 0x220
		public const int RATE_SHOKUJI = 20; // Metadata: 0x0062AB4D
		public const int VALUE_SHOKUJI_HP = 20; // Metadata: 0x0062AB51
		public const int VALUE_SHOKUJI_PP = 1; // Metadata: 0x0062AB55
		public const int RATE_GOEI = 5; // Metadata: 0x0062AB59
		public const int VALUE_IKARI_ATTACK = 5; // Metadata: 0x0062AB5D
		public const int VALUE_IKARI_EXATTACK = 5; // Metadata: 0x0062AB61
		public const int VALUE_IKARI_HIT = 3; // Metadata: 0x0062AB65
		public const int VALUE_KAKUNIN_LIMIT = 2; // Metadata: 0x0062AB69
		public const int VALUE_POWER_BAND = 10; // Metadata: 0x0062AB6D
		public const int VALUE_GUARD_SCARF = 15; // Metadata: 0x0062AB71
		public const int VALUE_SPECIAL_RIBBON = 10; // Metadata: 0x0062AB75
		public const int VALUE_KITOSAN_BAND = 15; // Metadata: 0x0062AB79
		public const int VALUE_SUBAYASA_EQUIP = 20; // Metadata: 0x0062AB7D
		public const int RATE_PINTO_LENS = 33; // Metadata: 0x0062AB81
		public const int RATE_HITOSUJI_RIBBON = 50; // Metadata: 0x0062AB85
		public const int RATE_MEUTSURI_GLASS = 35; // Metadata: 0x0062AB89
		public const float RATE_HEAL_RIBBON = 1.25f; // Metadata: 0x0062AB8D
		public const int RATE_WARP_SCARF = 15; // Metadata: 0x0062AB91
		public const float EXP_HAPPY_RIBBON = 0.2f; // Metadata: 0x0062AB95
		public const int VALUE_MIKIRI_HACHIMAKI = 2; // Metadata: 0x0062AB99
		public const int RATE_GOURYUU_SCARF = 75; // Metadata: 0x0062AB9D
		public const int BELLY_ASHIRAI_EQUIP = 1000; // Metadata: 0x0062ABA1
		public const int EQUIP_POKE_HP_VALUE = 5; // Metadata: 0x0062ABA5
		public const int EQUIP_KIKEN_RATE = 50; // Metadata: 0x0062ABA9
		public const int EQUIP_SETSUYAKU_RATE = 30; // Metadata: 0x0062ABAD
		public const int EQUIP_IRYOKU_VALUE = 15; // Metadata: 0x0062ABB1
		public const int EQUIP_DOKOMADE_VALUE = 200; // Metadata: 0x0062ABB5
		public const int EQUIP_GONBE_ADD_VALUE = 30; // Metadata: 0x0062ABB9
		public const float EQUIP_GONBE_BELLY_RATE = 1.5f; // Metadata: 0x0062ABBD
		public const int EQUIP_GONBE_BELLY_VALUE_NPC = 15; // Metadata: 0x0062ABC1
		public const int EQUIP_FRIEND_RATE = 128; // Metadata: 0x0062ABC5
		public const int SEAL_IRYOKU_UP_X_RANK = 1; // Metadata: 0x0062ABC9
		public const int SEAL_IRYOKU_UP_Y_RANK = 1; // Metadata: 0x0062ABCD
		public const int SEAL_IRYOKU_UP_HIT_RANK = 2; // Metadata: 0x0062ABD1
		public const int SEAL_BOUGYO_UP_RANK = 1; // Metadata: 0x0062ABD5
		public static readonly int[] SEAL_NAGATSUZUKI_TURN; // 0x228
		public static readonly int[] SEAL_SEKKINSEN_RATE; // 0x230
		public const int SEAL_RENKEIJOUZU_RANK = 5; // Metadata: 0x0062ABD9
		public static readonly int[] SEAL_WAZARENPATSU_RATE; // 0x238
		public static readonly int[] SEAL_BATSUGUN_RATE; // 0x240
		public static readonly int[] SEAL_KONDOKOSO_RATE; // 0x248
		public static readonly float[] SEAL_OMAKE_UP_RATE; // 0x250
		public static readonly int[] SEAL_BETOBETOPOWER_RATE; // 0x258
		public static readonly int[] SEAL_BETOBETOPOWER_RATE_ADD; // 0x260
		public static readonly int[] SEAL_FURAFURA_RATE; // 0x268
		public static readonly int[] SEAL_NEMURASE_RATE; // 0x270
		public static readonly float[] SEAL_RENDAMAMORI_2ND_HIT; // 0x278
		public static readonly float[] SEAL_RENDAMAMORI_3RD_HIT; // 0x280
		public static readonly float[] SEAL_RENDAMAMORI_4TH_HIT; // 0x288
		public static readonly float[] SEAL_RENDAMAMORI_5TH_HIT; // 0x290
		public static readonly int[] SEAL_FURAFURAGAESHI_RATE; // 0x298
		public static readonly int[] SEAL_NEMURIAGAESHI_RATE; // 0x2A0
		public static readonly int[] SEAL_TOBASHIKAESHI_RATE; // 0x2A8
		public static readonly int[] SEAL_YOWARASEGAESHI_RATE; // 0x2B0
		public static readonly float[] SEAL_BAKUHATSUMAMORI_RATE; // 0x2B8
		public static readonly int[] SEAL_FUKOUUTSUSHI_RATE; // 0x2C0
		public static readonly int[] SEAL_IATSUKAN_RATE; // 0x2C8
		public static readonly int[] SEAL_DOTANBA_RATE; // 0x2D0
		public static readonly int[] SEAL_FUNBARI_RATE; // 0x2D8
		public static readonly int[] SEAL_KINOMINOCHIKARA_RATE; // 0x2E0
		public static readonly int[] SEAL_TSUEFURIJOUZU_RATE; // 0x2E8
		public const int SEAL_KESSHINOKAKUGO_ATTACK_RANK = 3; // Metadata: 0x0062ABDD
		public const int SEAL_KESSHINOKAKUGO_HIT_RANK = 5; // Metadata: 0x0062ABE1
		public const int SEAL_KESSHINOKAKUGO_EVADE_RANK = 5; // Metadata: 0x0062ABE5
		public static readonly float[] SEAL_DAIKAIFUKU_RATE; // 0x2F0
		public static readonly float[] SEAL_HARAMOCHI_RATE; // 0x2F8
		public static readonly int[] SEAL_LIFELINE_RATE1000; // 0x300
		public static readonly int[] SEAL_SEALSEARCH_RATE1000; // 0x308
		public const int SEAL_KABEHORI_BELLY = 200; // Metadata: 0x0062ABE9
		public static readonly float[] SEAL_TAKARASAGASHI_RATE; // 0x310
		public static readonly int[] SEAL_PP_IYASHI_PP; // 0x318
		public const int SEAL_KAZENONASAKE_TURN = 100; // Metadata: 0x0062ABED
		public static readonly float[] SEAL_GURAADON_KAIOOGA_OFFENCE_RATE; // 0x320
		public static readonly float[] SEAL_GURAADON_KAIOOGA_DEFFENCE_RATE; // 0x328
		public static readonly float[] SEAL_ZERUNEASU_RATE; // 0x330
		public static readonly int[] SEAL_IBERUTAL_RATE; // 0x338
		public static readonly int[] SEAL_JOUTAIYOBOU_PREVENT; // 0x340
		public const int VALUE_ARROW_REDUCE = 40; // Metadata: 0x0062ABF1
		public const int VALUE_STONE_REDUCE = 40; // Metadata: 0x0062ABF5
		public static readonly Const.status.Index[] BETOBETA_STATUS; // 0x348
		public const int SEED_FUKKATSU_HP = 100; // Metadata: 0x0062ABF9
		public static readonly int[] SWEETS_PARAMETER_UP; // 0x350
		public static readonly int[] DOUNUT_L_RATE; // 0x358
		public static readonly int[] CHOCOLATE_3_RATE; // 0x360
		public static readonly int[] COOKIE_3_RATE; // 0x368
		public static readonly int[] GUMMY_TARGET_PARAMETER_CHOICE; // 0x370
		public const int GUMMY_BIG_HIT_RATE = 15; // Metadata: 0x0062ABFD
		public static readonly int[] GUMMY_PARAMETER_UP; // 0x378
		public static readonly int[] GUMMY_PARAMETER_BIG_UP; // 0x380
		public static readonly int[] TURN_ORB_MUTEKI; // 0x388
		public const float ORB_SUGOWAZA_RATE = 0.5f; // Metadata: 0x0062AC01
		public const int ORB_INVITATION_VALUE = 250; // Metadata: 0x0062AC05
		public const int VALUE_WAND_REDUCE = 40; // Metadata: 0x0062AC09
		public const int RATE_KIRAKIRA_ENEMY = 5; // Metadata: 0x0062AC0D
		public const int VALUE_KAWASHI_PANEL = 2; // Metadata: 0x0062AC11
		public const int VALUE_CHOUHATSU_PANEL = 2; // Metadata: 0x0062AC15
		public static readonly int[] VALUE_TAIJUU_PANEL; // 0x390
		public static readonly int[] RATE_TAIJUU_PANEL; // 0x398
		public const int VALUE_WAZA_CHAIN_BELLY_DECREASE = 3; // Metadata: 0x0062AC19
		public const int VALUE_PUSH_FRIEND_NUMBER = 15; // Metadata: 0x0062AC1D
		public const int VALUE_PUSH_LOTTERY_RATE = 60; // Metadata: 0x0062AC21
		public const int VALUE_ORG_TUTORIAL_SHUTTER_PRISET_NUMBER = 5; // Metadata: 0x0062AC25
		public const int MAX_QUEST_LIST = 64; // Metadata: 0x0062AC29
		public const int MAX_QUEST_BULLETIN_BOARD = 8; // Metadata: 0x0062AC2D
		public const int MAX_POST_REQUEST_LIST = 4; // Metadata: 0x0062AC31
		public const int MAX_FRIEND_LIST = 16; // Metadata: 0x0062AC35
		public const int MAX_FRIEND_RESCUE_SOS_LIST = 12; // Metadata: 0x0062AC39
		public const int MAX_FRIEND_RESCUE_RESCUED_LIST = 100; // Metadata: 0x0062AC3D
		public const int MAX_FRIEND_RESCUE_TEMPORARY_LIST = 100; // Metadata: 0x0062AC41
		public static readonly int[] RESCUE_REWARD_PRICE; // 0x3A0
		public static readonly Const.item.Index[] RESCUE_SUPPLY_ITEM; // 0x3A8
		public static readonly int[] RESCUE_SUPPLY_ITEM_COUNT; // 0x3B0
		public const int FRIEND_TICKET_HISTORY_MAX = 10; // Metadata: 0x0062AC45
		public const int RESCUE_COUNT_MAX = 999; // Metadata: 0x0062AC49
		public const int INTERNET_ACCESS_INTERVAL = 10; // Metadata: 0x0062AC4D
		public const int INTERNET_TICKET_LOWEST = 70; // Metadata: 0x0062AC51
		public const int VALUE_POWER_UP = 2; // Metadata: 0x0062AC55
		public const int VALUE_MINNADE_POINT_MAX = 4000; // Metadata: 0x0062AC59
		public const int DMAGE_MINNDADE_MIN = 30; // Metadata: 0x0062AC5D
		public static readonly int[] VALUE_MINNADE_ATTACK_LEVEL; // 0x3B8
		public static readonly int[] VALUE_MINNADE_ATTACK_POWER; // 0x3C0
		public const int VALUE_JUKUSUI_DROP_FLOOR_ITEM = 30; // Metadata: 0x0062AC61
		public const int VALUE_JUKUSUI_DROP_SHOP_ITEM = 30; // Metadata: 0x0062AC65
		public const int VALUE_JUKUSUI_DROP_TREASURE_ITEM = 30; // Metadata: 0x0062AC69
		public const float RATE_MYSTERY_LEVEL_DOWN = 0.8f; // Metadata: 0x0062AC6D
		public const float RATE_MYSTERY_LEVEL_UP = 1.2f; // Metadata: 0x0062AC71
		public static readonly int[] RATE_MYSTERY_DUNGEON_JUMP; // 0x3C8
		public static readonly int[] RATE_ITEM_DROP; // 0x3D0
		public static readonly int[] RATE_ITEM_DROP_BONUS; // 0x3D8
		public static readonly int[] RATE_ITEM_DROP_DLC; // 0x3E0
		public static readonly int[] RATE_ITEM_DROP_KYOUTEKI; // 0x3E8
		public static readonly int[] BOSS_MENNEKI_CLEAR_STATUS_RATE; // 0x3F0
		public const int BOSS_MENNEKI_CLEAR_STATUS_RATE_INF = 70; // Metadata: 0x0062AC75
		public static readonly int[] AR_RATE_DATA_FLOOR_MAX_CLEAR; // 0x3F8
		public static readonly int[] AR_RATE_DATA_FLOOR_MAX; // 0x400
		public static readonly int[] AR_RATE_DATA_BUDDY_NUM; // 0x408
		public static readonly int[] AR_RATE_DATA_BUDDY_RATE; // 0x410
		public static readonly int[] VALUE_SHOP_CHEST_COST; // 0x418
		public const int VALUE_DEFAULT_POKEMON_WAREHOUSE_COUNT = 64; // Metadata: 0x0062AC79
		public const int VALUE_SHOP_WAZA_LEARN_MONEY_FIRST = 1000; // Metadata: 0x0062AC7D
		public const int VALUE_SHOP_WAZA_LEARN_MONEY = 1000; // Metadata: 0x0062AC81
		public const int VALUE_FRIEND_GRATITUDE_MAX = 100; // Metadata: 0x0062AC85
		public static readonly int[] VALUE_REST_BY_LEVEL_TABLE; // 0x420
		public static readonly int[] VALUE_REST_BY_NUM_TABLE; // 0x428
		public static readonly int[] VALUE_REST_FRIEND_NUM_TABLE; // 0x430
		public static readonly int[] VALUE_REST_RATE_FRIEND_NUM; // 0x438
		public const int VALUE_REST_NUM_BY_FRIEND_NUM = 1; // Metadata: 0x0062AC89
		public const int VALUE_SHOP_NAKAMA_COUNT_GARUURA = 200; // Metadata: 0x0062AC8D
		public const int VALUE_SHOP_NAKAMA_COUNT_RUCHABURU = 400; // Metadata: 0x0062AC91
		public const int VALUE_SHOP_NAKAMA_COUNT_KUREFFI = 500; // Metadata: 0x0062AC95
		public const int VALUE_SHOP_NAKAMA_COUNT_DESUKAAN = 250; // Metadata: 0x0062AC99
		public const int VALUE_SHOP_NAKAMA_COUNT_PERIPPAA = 550; // Metadata: 0x0062AC9D
		public const int VALUE_SHOP_NAKAMA_COUNT_NYAASU = 300; // Metadata: 0x0062ACA1
		public const int VALUE_SHOP_NAKAMA_COUNT_ZERUNEASU = 600; // Metadata: 0x0062ACA5
		public const int VALUE_SHOP_NAKAMA_COUNT_KAKUREON = 750; // Metadata: 0x0062ACA9
		public const int VALUE_QUEST_GREET_APPEAR_AFTER_SCENARIO_RATIO = 20; // Metadata: 0x0062ACAD
		public const int VALUE_CYCLE_LIMIT_RELEASE_NAKAMA_POKEMON = 390; // Metadata: 0x0062ACB1
		public const int VALUE_GONBE_INIT_COUNT_FIRST = 7; // Metadata: 0x0062ACB5
		public const int VALUE_GONBE_INIT_COUNT = 25; // Metadata: 0x0062ACB9
		public static readonly int[] VALUE_GONBE_ADVANCE_COUNT; // 0x440
		public static readonly int[] VALUE_GONBE_ADVANCE_COUNT_WEIGHT; // 0x448
		public const int VALUE_JIRAACHI_REWARD_MONEY = 20000; // Metadata: 0x0062ACBD
		public const int VALUE_BASE_AZUKARIBOX_CHANGE_INGOT_NUM = 1; // Metadata: 0x0062ACC1
		public const int VALUE_BASE_AZUKARIBOX_CHANGE_INGOT_ITEM_NUM = 100; // Metadata: 0x0062ACC5
		public static readonly int[] VALUE_DIFFICULITY_CONVERT_TABLE; // 0x450
		public static readonly int[] VALUE_BASE_RANK_POINT_TABLE; // 0x458
		public static readonly int[] VALUE_QUEST_RANK_POINT_TABLE; // 0x460
		public const float VALUE_QUEST_RANK_MAG = 1f; // Metadata: 0x0062ACC9
		public static readonly int[] VALUE_DUNGEON_DIFFICULITY_GUIDE; // 0x468
		public const int VALUE_PERIPPAA_ITEM_SELECT_COLLECT_MAX = 10; // Metadata: 0x0062ACCD
		public const int VALUE_PERIPPAA_FRIEND_INITIAL_LEVEL = 15; // Metadata: 0x0062ACD1
		public const int VALUE_PERIPPAA_TICKET_TIME_LIMIT = 8; // Metadata: 0x0062ACD5
		public const int VALUE_ITEM_DEGRADATION = 100; // Metadata: 0x0062ACD9
		public const int VALUE_ITEM_DEGRADATION_PERIPPAA = 100; // Metadata: 0x0062ACDD
		public const int VALUE_MESSAGE_BSKIP_SPEED = 2; // Metadata: 0x0062ACE1
		public const int VALUE_FORMCHANGE_DEOKISHISU_A_KOUGEKI = 3; // Metadata: 0x0062ACE5
		public const int VALUE_FORMCHANGE_DEOKISHISU_A_BOUGYO = -2; // Metadata: 0x0062ACE9
		public const int VALUE_FORMCHANGE_DEOKISHISU_D_KOUGEKI = -2; // Metadata: 0x0062ACED
		public const int VALUE_FORMCHANGE_DEOKISHISU_D_BOUGYO = 3; // Metadata: 0x0062ACF1
		public const int VALUE_FORMCHANGE_DEOKISHISU_S_KAIHI = 4; // Metadata: 0x0062ACF5
		public const int VALUE_FORMCHANGE_DEOKISHISU_S_BOUGYO = -2; // Metadata: 0x0062ACF9
		public const int VALUE_FORMCHANGE_GIRATYNA_KOUGEKI = 3; // Metadata: 0x0062ACFD
		public const int VALUE_FORMCHANGE_GIRATYNA_BOUGYO = -2; // Metadata: 0x0062AD01
		public const int VALUE_FORMCHANGE_SHEIMI_BOUGYO = -2; // Metadata: 0x0062AD05
		public const int VALUE_FORMCHANGE_SHEIMI_KAIHI = 4; // Metadata: 0x0062AD09
		public const int VALUE_FORMCHANGE_TORUNEROSU_KOUGEKI = -1; // Metadata: 0x0062AD0D
		public const int VALUE_FORMCHANGE_TORUNEROSU_TOKUKOU = -1; // Metadata: 0x0062AD11
		public const int VALUE_FORMCHANGE_TORUNEROSU_BOUGYO = 3; // Metadata: 0x0062AD15
		public const int VALUE_FORMCHANGE_TORUNEROSU_TOKUBOU = 3; // Metadata: 0x0062AD19
		public const int VALUE_FORMCHANGE_BORUTOROSU_KOUGEKI = -1; // Metadata: 0x0062AD1D
		public const int VALUE_FORMCHANGE_BORUTOROSU_TOKUKOU = 3; // Metadata: 0x0062AD21
		public const int VALUE_FORMCHANGE_RANDOROSU_KOUGEKI = 3; // Metadata: 0x0062AD25
		public const int VALUE_FORMCHANGE_RANDOROSU_TOKUKOU = -1; // Metadata: 0x0062AD29
		public const int VALUE_FORMCHANGE_KYUREMU_B_KOUGEKI = 2; // Metadata: 0x0062AD2D
		public const int VALUE_FORMCHANGE_KYUREMU_W_TOKUKOU = 2; // Metadata: 0x0062AD31
		public const int FORMCHANGE_MEROETTA_KOUGEKI = 2; // Metadata: 0x0062AD35
		public const int FORMCHANGE_MEROETTA_TOKUKOU = -2; // Metadata: 0x0062AD39
		public const int VALUE_FORMCHANGE_GIRUGARUDO_KOUGEKI = -2; // Metadata: 0x0062AD3D
		public const int VALUE_FORMCHANGE_GIRUGARUDO_TOKUKOU = -2; // Metadata: 0x0062AD41
		public const int VALUE_FORMCHANGE_GIRUGARUDO_BOUGYO = 2; // Metadata: 0x0062AD45
		public const int VALUE_FORMCHANGE_GIRUGARUDO_TOKUBOU = 2; // Metadata: 0x0062AD49
		public const int VALUE_FORMCHANGE_FUUPA_MEGA_KOUGEKI = 3; // Metadata: 0x0062AD4D
		public const int VALUE_FORMCHANGE_FUUPA_MEGA_BOUGYO = 3; // Metadata: 0x0062AD51
		public const int VALUE_FORMCHANGE_FUUPA_MEGA_TOKUKOU = 3; // Metadata: 0x0062AD55
		public const int VALUE_FORMCHANGE_FUUPA_MEGA_TOKUBOU = 3; // Metadata: 0x0062AD59
		public const int VALUE_FORMCHANGE_FUUPA_MEGA_KAIHI = 3; // Metadata: 0x0062AD5D
		public static readonly int[] SEAL_COUNT_NANAME_TBL; // 0x470
		public const int RAREITEM_STONE_MAX = 40; // Metadata: 0x0062AD61
		public const int RAREITEM_ARROW_MAX = 40; // Metadata: 0x0062AD65
		public const int THEATER_CLEAR_PRESENT_COUNT = 3; // Metadata: 0x0062AD69
		public static readonly float[] SUGOWAZA_RENKETSU_MAG; // 0x478
		public static readonly float[] SUGOWAZA_OOTACHIMAWARI_MAG; // 0x480
		public const float SUGOWAZA_HANDOU_UP_MAG = 2f; // Metadata: 0x0062AD6D
		public const float SUGOWAZA_PUNCH_JIMAN_MAG = 1.5f; // Metadata: 0x0062AD71
		public const int SUGOWAZA_MAKEZUGIRAI_RANK = 1; // Metadata: 0x0062AD75
		public const int SUGOWAZA_ISSHI_RANK = 1; // Metadata: 0x0062AD79
		public static readonly int[] SUGOWAZA_KOGUN_RANK; // 0x488
		public static readonly int[] SUGOWAZA_MAMORI_RHYTHM_RANK; // 0x490
		public static readonly int[] SUGOWAZA_KAIHI_RHYTHM_RANK; // 0x498
		public static readonly float[] SUGOWAZA_MISSHUU_MAG; // 0x4A0
		public const float SUGOWAZA_BAKUHATSU_MAG = 0.5f; // Metadata: 0x0062AD7D
		public const float SUGOWAZA_KAIFUKU_HP_MAG = 1.5f; // Metadata: 0x0062AD81
		public const float SUGOWAZA_KAIFUKU_PP_MAG = 1.5f; // Metadata: 0x0062AD85
		public const float SUGOWAZA_KAIFUKU_BELLY_MAG = 1.5f; // Metadata: 0x0062AD89
		public const float SUGOWAZA_CHIYURYOKU_MAG = 2f; // Metadata: 0x0062AD8D
		public const float SUGOWAZA_SEMAITOKORO_MAG = 4f; // Metadata: 0x0062AD91
		public const int SUGOWAZA_SHIBORI_WALK_VALUE = 30; // Metadata: 0x0062AD95
		public const int SUGOWAZA_SHIBORI_PP_VALUE = 2; // Metadata: 0x0062AD99
		public const float SUGOWAZA_NEBIKI_MAG = 0.8f; // Metadata: 0x0062AD9D
		public const float SUGOWAZA_URITSUKE_MAG = 1.5f; // Metadata: 0x0062ADA1
		public const int SUGOWAZA_SHITASHIMI_VALUE = 150; // Metadata: 0x0062ADA5
		public static readonly int[] SUGOWAZA_WAKIAIAI_VALUE; // 0x4A8
		public const int SUGOWAZA_PP_HIKETSU_RATE = 12; // Metadata: 0x0062ADA9
		public const int SUGOWAZA_PP_HIKETSU_VALUE = 5; // Metadata: 0x0062ADAD
		public const int SUGOWAZA_SOSHAKU_VALUE = 40000; // Metadata: 0x0062ADB1
		public const float SUGOWAZA_TOUTEKI_STONE_MAG = 1.5f; // Metadata: 0x0062ADB5
		public const float SUGOWAZA_TOUTEKI_ARROW_MAG = 1.5f; // Metadata: 0x0062ADB9
		public const float SUGOWAZA_TOUTEKI_FIXED_MAG = 2.5f; // Metadata: 0x0062ADBD
		public const float SUGOWAZA_EXP_SEICHOU_MAG = 2f; // Metadata: 0x0062ADC1
		public const float SUGOWAZA_WAZA_SEICHOU_MAG = 2f; // Metadata: 0x0062ADC5
		public const int SUGOWAZA_MICHI_VALUE = 200; // Metadata: 0x0062ADC9
		public const int SUGOWAZA_KEIKAI_WANA_RATE = 50; // Metadata: 0x0062ADCD
		public const int NEWS_PRESENT_LOTTERY_RATE = 15; // Metadata: 0x0062ADD1
		public static readonly int[] TRAINING_TICKET_TIME; // 0x4B0
		public static readonly float[] TRAINING_TICKET_EXP_MAG; // 0x4B8
		public static readonly float[] TRAINING_TICKET_WAZA_EXP_MAG; // 0x4C0
		public static readonly float[] TRAINING_TICKET_BATSUGUN_EXP_MAG; // 0x4C8
		public static readonly float[] TRAINING_TICKET_BATSUGUN_WAZA_EXP_MAG; // 0x4D0
		public static readonly float[] TRAINING_TICKET_EXP_NORMAL_MAG; // 0x4D8
		public static readonly float[] TRAINING_TICKET_WAZA_EXP_NORMAL_MAG; // 0x4E0
		public static readonly float[] TRAINING_TICKET_BATSUGUN_EXP_NORMAL_MAG; // 0x4E8
		public static readonly float[] TRAINING_TICKET_BATSUGUN_WAZA_EXP_NORMAL_MAG; // 0x4F0
		public static readonly int[] DISASTER_GURAADON_ACTIVATE_RATE_FIRST; // 0x4F8
		public static readonly int[] DISASTER_GURAADON_ACTIVATE_RATE; // 0x500
		public static readonly int[] DISASTER_GURAADON_INTERVAL_TURN; // 0x508
		public const int DISASTER_GURAADON_DAMAGE = 5; // Metadata: 0x0062ADD5
		public const float DISASTER_REKKUUZA_FIRST_HP_RATIO = 0.8f; // Metadata: 0x0062ADD9
		public const int DISASTER_REKKUUZA_FIRST_TURN = 10; // Metadata: 0x0062ADDD
		public static readonly int[] DISASTER_REKKUUZA_ACTIVATE_RATE; // 0x510
		public const int DISASTER_REKKUUZA_INTERVAL_TURN = 1; // Metadata: 0x0062ADE1
		public static readonly int[] DISASTER_REKKUUZA_SUCTION_RATE; // 0x518
		public const int DISASTER_HOUOU_HEAL_POINT = 50; // Metadata: 0x0062ADE5
		public const int DISASTER_KAIOOGA_BLANK_TURN = 2; // Metadata: 0x0062ADE9
		public const int DISASTER_KAIOOGA_INUNDATION_TURN = 5; // Metadata: 0x0062ADED
		public const int DISASTER_KAIOOGA_DRIED_UP_TURN = 10; // Metadata: 0x0062ADF1
		public static readonly int[] DISASTER_RUGIA_ACTIVATE_RATE; // 0x520
		public const int ENABLE_CHOICE_GUNNER_THINK = 50; // Metadata: 0x0062ADF5
		public const int BOUNUS_DUNGEON_RATE = 66; // Metadata: 0x0062ADF9
		public const float BONUS_DUNGEON_MONEY_MAG = 2f; // Metadata: 0x0062ADFD
		public const int GUEST_PARTY_DEFAULT_BONUS_CASH = 100; // Metadata: 0x0062AE01
		public static readonly int[] QUEST_REWARD_ITEM_NUM_BONUS_MAG; // 0x528
		public static readonly int[] QUEST_REWARD_MONEY_BONUS; // 0x530
		public static readonly int[] QUEST_REWARD_POINT_BONUS; // 0x538
		public static readonly int[] EVOLUTION_PARAMETER_BONUS_NUM_ARRAY; // 0x540
	
		// Constructors
		public Probability() {} // 0x00981B80-0x00981B90
		static Probability() {} // 0x00981B90-0x00983F40
	}
}
