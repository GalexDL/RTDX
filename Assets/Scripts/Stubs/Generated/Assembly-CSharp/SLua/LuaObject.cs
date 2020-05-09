/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class LuaObject // TypeDefIndex: 8238
	{
		// Fields
		protected static LuaCSFunction lua_gc; // 0x00
		protected static LuaCSFunction lua_add; // 0x08
		protected static LuaCSFunction lua_sub; // 0x10
		protected static LuaCSFunction lua_mul; // 0x18
		protected static LuaCSFunction lua_div; // 0x20
		protected static LuaCSFunction lua_unm; // 0x28
		protected static LuaCSFunction lua_eq; // 0x30
		protected static LuaCSFunction lua_lt; // 0x38
		protected static LuaCSFunction lua_le; // 0x40
		protected static LuaCSFunction lua_tostring; // 0x48
		private const string DelgateTable = "__LuaDelegate"; // Metadata: 0x00613F14
		protected static LuaFunction newindex_func; // 0x50
		protected static LuaFunction index_func; // 0x58
		internal const int VersionNumber = 4609; // Metadata: 0x00613F25
		private static Type MonoType; // 0x60
	
		// Constructors
		public LuaObject() {} // 0x00840100-0x00840110
		static LuaObject() {} // 0x00855310-0x00855560
	
		// Methods
		public static void init(IntPtr l) {} // 0x0084DE40-0x0084E270
		// [MonoPInvokeCallback] // 0x0063A920-0x0063A990
		public static int ToString(IntPtr l) => default; // 0x0084C500-0x0084C760
		// [MonoPInvokeCallback] // 0x0063A990-0x0063AA00
		public static int GetHashCode(IntPtr l) => default; // 0x0084C760-0x0084C970
		// [MonoPInvokeCallback] // 0x0063AA00-0x0063AA70
		public static int Equals(IntPtr l) => default; // 0x0084C970-0x0084CBF0
		// [MonoPInvokeCallback] // 0x0063AA70-0x0063AAE0
		public static int GetType(IntPtr l) => default; // 0x0084CBF0-0x0084CE50
		private static int getOpFunction(IntPtr l, string f, string tip) => default; // 0x0084E410-0x0084E7C0
		private static int luaOp(IntPtr l, string f, string tip) => default; // 0x0084E950-0x0084EB40
		private static int luaUnaryOp(IntPtr l, string f, string tip) => default; // 0x0084EB40-0x0084ED30
		// [MonoPInvokeCallback] // 0x0063AAE0-0x0063AB50
		public static int luaAdd(IntPtr l) => default; // 0x0084CE50-0x0084CFE0
		// [MonoPInvokeCallback] // 0x0063AB50-0x0063ABC0
		public static int luaSub(IntPtr l) => default; // 0x0084CFE0-0x0084D170
		// [MonoPInvokeCallback] // 0x0063ABC0-0x0063AC30
		public static int luaMul(IntPtr l) => default; // 0x0084D170-0x0084D300
		// [MonoPInvokeCallback] // 0x0063AC30-0x0063ACA0
		public static int luaDiv(IntPtr l) => default; // 0x0084D300-0x0084D490
		// [MonoPInvokeCallback] // 0x0063ACA0-0x0063AD10
		public static int luaUnm(IntPtr l) => default; // 0x0084D490-0x0084D620
		// [MonoPInvokeCallback] // 0x0063AD10-0x0063AD80
		public static int luaEq(IntPtr l) => default; // 0x0084D620-0x0084D7B0
		// [MonoPInvokeCallback] // 0x0063AD80-0x0063ADF0
		public static int luaLt(IntPtr l) => default; // 0x0084D7B0-0x0084D940
		// [MonoPInvokeCallback] // 0x0063ADF0-0x0063AE60
		public static int luaLe(IntPtr l) => default; // 0x0084D940-0x0084DAD0
		public static void getEnumTable(IntPtr l, string t) {} // 0x0084ED30-0x0084EDB0
		public static void getTypeTable(IntPtr l, string t) {} // 0x0083FAC0-0x0083FC00
		public static void newTypeTable(IntPtr l, string name) {} // 0x0084EDB0-0x0084F100
		public static void createTypeMetatable(IntPtr l, Type self) {} // 0x0084F100-0x0084F180
		public static void createTypeMetatable(IntPtr l, LuaCSFunction con, Type self) {} // 0x00840010-0x00840090
		private static void checkMethodValid(LuaCSFunction f) {} // 0x0084F5B0-0x0084F5C0
		public static void createTypeMetatable(IntPtr l, LuaCSFunction con, Type self, Type parent) {} // 0x0084F180-0x0084F5B0
		private static void completeTypeMeta(IntPtr l, LuaCSFunction con, Type self) {} // 0x0084FD30-0x008500A0
		private static void completeInstanceMeta(IntPtr l, Type self) {} // 0x0084F5C0-0x0084FD30
		public static bool isImplByLua(Type t) => default; // 0x008500A0-0x00850250
		public static void reg(IntPtr l, LuaCSFunction func, string ns) {} // 0x00844640-0x008447C0
		protected static void addMember(IntPtr l, LuaCSFunction func) {} // 0x0084E270-0x0084E410
		protected static void addMember(IntPtr l, LuaCSFunction func, bool instance) {} // 0x0083FC00-0x0083FD40
		protected static void addMember(IntPtr l, string name, LuaCSFunction get, LuaCSFunction set, bool instance) {} // 0x0083FD40-0x0083FFC0
		protected static void addMember(IntPtr l, int v, string name) {} // 0x00850250-0x00850350
		// [MonoPInvokeCallback] // 0x0063AE60-0x0063AED0
		public static int luaGC(IntPtr l) => default; // 0x0084DAD0-0x0084DBE0
		internal static void gc(IntPtr l, int p, UnityEngine.Object o) {} // 0x00850350-0x00850410
		public static void checkLuaObject(IntPtr l, int p) {} // 0x0084E7C0-0x0084E950
		public static void pushObject(IntPtr l, object o) {} // 0x0083E250-0x0083E2E0
		public static void pushObject(IntPtr l, Array o) {} // 0x0083E3A0-0x0083E430
		public static void pushLightObject(IntPtr l, object t) {} // 0x0083CF80-0x0083D010
		public static int pushTry(IntPtr l) => default; // 0x0084A5B0-0x0084A660
		public static bool matchType(IntPtr l, int p, LuaTypes lt, Type t) => default; // 0x00850410-0x00850930
		public static bool isTypeTable(IntPtr l, int p) => default; // 0x0083F120-0x0083F2C0
		public static bool isLuaClass(IntPtr l, int p) => default; // 0x0083F510-0x0083F5B0
		private static bool isLuaValueType(IntPtr l, int p) => default; // 0x00850930-0x008509D0
		public static bool matchType(IntPtr l, int p, Type t1) => default; // 0x008509D0-0x00850A80
		public static bool matchType(IntPtr l, int total, int from, Type t1) => default; // 0x00850A80-0x00850B30
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2) => default; // 0x00850B30-0x00850C10
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3) => default; // 0x00850C10-0x00850D30
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4) => default; // 0x00850D30-0x00850E80
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5) => default; // 0x00850E80-0x00851010
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5, Type t6) => default; // 0x00851010-0x008511D0
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5, Type t6, Type t7) => default; // 0x008511D0-0x008513D0
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5, Type t6, Type t7, Type t8) => default; // 0x008513D0-0x00851600
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5, Type t6, Type t7, Type t8, Type t9) => default; // 0x00851600-0x00851860
		public static bool matchType(IntPtr l, int total, int from, Type t1, Type t2, Type t3, Type t4, Type t5, Type t6, Type t7, Type t8, Type t9, Type t10) => default; // 0x00851860-0x00851AF0
		public static bool matchType(IntPtr l, int total, int from, params /* 0x0065ACC0-0x0065ACD0 */ Type[] t) => default; // 0x00851AF0-0x00851BF0
		public static bool matchType(IntPtr l, int total, int from, ParameterInfo[] pars) => default; // 0x0083D6D0-0x0083D820
		public static bool luaTypeCheck(IntPtr l, int p, string t) => default; // 0x00851BF0-0x00851C90
		private static LuaDelegate newDelegate(IntPtr l, int p) => default; // 0x00851C90-0x00851E30
		public static void removeDelgate(IntPtr l, int r) {} // 0x00846640-0x00846790
		public static object checkObj(IntPtr l, int p) => default; // 0x0083CB00-0x0083CB90
		public static bool checkArray<T>(IntPtr l, int p, out T[] ta) {
			ta = default;
			return default;
		}
		public static bool checkParams<T>(IntPtr l, int p, out T[] pars)
			where T : class {
			pars = default;
			return default;
		}
		public static bool checkValueParams<T>(IntPtr l, int p, out T[] pars)
			where T : struct {
			pars = default;
			return default;
		}
		public static bool checkParams(IntPtr l, int p, out float[] pars) {
			pars = default;
			return default;
		} // 0x00851E30-0x00851FA0
		public static bool checkParams(IntPtr l, int p, out int[] pars) {
			pars = default;
			return default;
		} // 0x00852090-0x00852200
		public static bool checkParams(IntPtr l, int p, out string[] pars) {
			pars = default;
			return default;
		} // 0x00852200-0x00852370
		public static bool checkParams(IntPtr l, int p, out char[] pars) {
			pars = default;
			return default;
		} // 0x00852370-0x00852440
		public static object checkVar(IntPtr l, int p, Type t) => default; // 0x00852440-0x008528F0
		public static object checkVar(IntPtr l, int p) => default; // 0x0083D820-0x0083DFD0
		public static void pushValue(IntPtr l, object o) {} // 0x0084B190-0x0084B210
		public static void pushValue(IntPtr l, Array a) {} // 0x0083F040-0x0083F120
		public static void pushVar(IntPtr l, object o) {} // 0x0083CB90-0x0083CEE0
		public static T checkSelf<T>(IntPtr l) => default;
		public static object checkSelf(IntPtr l) => default; // 0x00842140-0x00842270
		public static void setBack(IntPtr l, object o) {} // 0x00853430-0x008534C0
		public static void setBack(IntPtr l, Vector3 v) {} // 0x008534C0-0x00853560
		public static void setBack(IntPtr l, Vector2 v) {} // 0x00853560-0x008535F0
		public static void setBack(IntPtr l, Vector4 v) {} // 0x008535F0-0x00853690
		public static void setBack(IntPtr l, Quaternion v) {} // 0x00853690-0x00853730
		public static void setBack(IntPtr l, Color v) {} // 0x00853730-0x008537D0
		public static int extractFunction(IntPtr l, int p) => default; // 0x00846C80-0x00846E80
		// [MonoPInvokeCallback] // 0x0063AED0-0x0063AF40
		public static int noConstructor(IntPtr l) => default; // 0x0084DBE0-0x0084DDA0
		// [MonoPInvokeCallback] // 0x0063AF40-0x0063AFB0
		public static int typeToString(IntPtr l) => default; // 0x0084DDA0-0x0084DE40
		public static int error(IntPtr l, Exception e) => default; // 0x0083D320-0x0083D3D0
		public static int error(IntPtr l, string err) => default; // 0x0083D0E0-0x0083D180
		public static int error(IntPtr l, string err, params /* 0x0065ACD0-0x0065ACE0 */ object[] args) => default; // 0x0083E160-0x0083E220
		public static int ok(IntPtr l) => default; // 0x008427D0-0x00842840
		public static int ok(IntPtr l, int retCount) => default; // 0x008537D0-0x00853860
		public static void assert(bool cond, string err) {} // 0x00842730-0x008427D0
		public static object changeType(object obj, Type t) => default; // 0x0083DFD0-0x0083E160
		public static bool checkEnum<T>(IntPtr l, int p, out T o)
			where T : struct {
			o = default;
			return default;
		}
		public static void pushEnum(IntPtr l, int e) {} // 0x008533B0-0x00853430
		public static bool checkType(IntPtr l, int p, out sbyte v) {
			v = default;
			return default;
		} // 0x00853860-0x00853950
		public static void pushValue(IntPtr l, sbyte v) {} // 0x00853950-0x00853A30
		public static bool checkType(IntPtr l, int p, out byte v) {
			v = default;
			return default;
		} // 0x00853A30-0x00853B20
		public static void pushValue(IntPtr l, byte i) {} // 0x00853B20-0x00853C00
		public static bool checkType(IntPtr l, int p, out char c) {
			c = default;
			return default;
		} // 0x00853C00-0x00853CF0
		public static void pushValue(IntPtr l, char v) {} // 0x00853CF0-0x00853DD0
		public static bool checkArray(IntPtr l, int p, out char[] pars) {
			pars = default;
			return default;
		} // 0x00853DD0-0x00853EA0
		public static bool checkType(IntPtr l, int p, out short v) {
			v = default;
			return default;
		} // 0x00853EA0-0x00853F90
		public static void pushValue(IntPtr l, short i) {} // 0x00853F90-0x00854070
		public static bool checkType(IntPtr l, int p, out ushort v) {
			v = default;
			return default;
		} // 0x00854070-0x00854160
		public static void pushValue(IntPtr l, ushort v) {} // 0x00854160-0x00854240
		public static bool checkType(IntPtr l, int p, out int v) {
			v = default;
			return default;
		} // 0x00842640-0x00842730
		public static void pushValue(IntPtr l, int i) {} // 0x0083F5B0-0x0083F680
		public static bool checkType(IntPtr l, int p, out uint v) {
			v = default;
			return default;
		} // 0x00854240-0x00854330
		public static void pushValue(IntPtr l, uint o) {} // 0x00854330-0x008543B0
		public static bool checkType(IntPtr l, int p, out long v) {
			v = default;
			return default;
		} // 0x008543B0-0x008544A0
		public static void pushValue(IntPtr l, long i) {} // 0x008544A0-0x00854520
		public static bool checkType(IntPtr l, int p, out ulong v) {
			v = default;
			return default;
		} // 0x00854520-0x00854610
		public static void pushValue(IntPtr l, ulong o) {} // 0x00854610-0x00854690
		public static bool checkType(IntPtr l, int p, out float v) {
			v = default;
			return default;
		} // 0x00851FA0-0x00852090
		public static void pushValue(IntPtr l, float o) {} // 0x00854690-0x00854710
		public static bool checkType(IntPtr l, int p, out double v) {
			v = default;
			return default;
		} // 0x00854710-0x00854800
		public static void pushValue(IntPtr l, double d) {} // 0x00854800-0x00854880
		public static bool checkType(IntPtr l, int p, out bool v) {
			v = default;
			return default;
		} // 0x0084A980-0x0084AA20
		public static void pushValue(IntPtr l, bool b) {} // 0x0083CEE0-0x0083CF80
		public static bool checkType(IntPtr l, int p, out string v) {
			v = default;
			return default;
		} // 0x0083D3D0-0x0083D560
		public static bool checkBinaryString(IntPtr l, int p, out byte[] bytes) {
			bytes = default;
			return default;
		} // 0x0083E2E0-0x0083E3A0
		public static void pushValue(IntPtr l, string s) {} // 0x0083E450-0x0083E4E0
		public static bool checkType(IntPtr l, int p, out IntPtr v) {
			v = default;
			return default;
		} // 0x00854880-0x00854910
		public static bool checkType(IntPtr l, int p, out LuaDelegate f) {
			f = default;
			return default;
		} // 0x00846E80-0x008471D0
		public static bool checkType(IntPtr l, int p, out LuaThread lt) {
			lt = default;
			return default;
		} // 0x00853220-0x008533B0
		public static bool checkType(IntPtr l, int p, out LuaFunction f) {
			f = default;
			return default;
		} // 0x0083D190-0x0083D320
		public static bool checkType(IntPtr l, int p, out LuaTable t) {
			t = default;
			return default;
		} // 0x00853090-0x00853220
		public static void pushValue(IntPtr l, LuaCSFunction f) {} // 0x00842C50-0x00842CD0
		public static void pushValue(IntPtr l, LuaTable t) {} // 0x00854910-0x008549B0
		public static Type FindType(string qualifiedTypeName) => default; // 0x0083D560-0x0083D6C0
		public static bool checkType(IntPtr l, int p, out Type t) {
			t = default;
			return default;
		} // 0x0083E4E0-0x0083ED70
		public static bool checkValueType<T>(IntPtr l, int p, out T v)
			where T : struct {
			v = default;
			return default;
		}
		public static bool checkNullable<T>(IntPtr l, int p, out T? v)
			where T : struct {
			v = default;
			return default;
		}
		public static bool checkType<T>(IntPtr l, int p, out T o)
			where T : class {
			o = default;
			return default;
		}
		public static bool checkType(IntPtr l, int p, out Vector4 v) {
			v = default;
			return default;
		} // 0x00852B60-0x00852CA0
		public static bool checkType(IntPtr l, int p, out Vector3 v) {
			v = default;
			return default;
		} // 0x00852A20-0x00852B60
		public static bool checkType(IntPtr l, int p, out Vector2 v) {
			v = default;
			return default;
		} // 0x008528F0-0x00852A20
		public static bool checkType(IntPtr l, int p, out Quaternion q) {
			q = default;
			return default;
		} // 0x00852CA0-0x00852DE0
		public static bool checkType(IntPtr l, int p, out Color c) {
			c = default;
			return default;
		} // 0x00852DE0-0x00853090
		public static bool checkType(IntPtr l, int p, out LayerMask lm) {
			lm = default;
			return default;
		} // 0x008549B0-0x00854A50
		public static bool checkParams(IntPtr l, int p, out Vector2[] pars) {
			pars = default;
			return default;
		} // 0x00854A50-0x00854BC0
		public static void pushValue(IntPtr l, RaycastHit2D r) {} // 0x00854BC0-0x00854CE0
		public static void pushValue(IntPtr l, RaycastHit r) {} // 0x00854CE0-0x00854E00
		public static void pushValue(IntPtr l, AnimationState o) {} // 0x00854E00-0x00854F20
		public static void pushValue(IntPtr l, UnityEngine.Object o) {} // 0x0084AC90-0x0084ADD0
		public static void pushValue(IntPtr l, Quaternion o) {} // 0x00854F20-0x00854FC0
		public static void pushValue(IntPtr l, Vector2 o) {} // 0x00854FC0-0x00855040
		public static void pushValue(IntPtr l, Vector3 o) {} // 0x00855040-0x008550D0
		public static void pushValue(IntPtr l, Vector4 o) {} // 0x008550D0-0x00855170
		public static void pushValue(IntPtr l, Color o) {} // 0x00855170-0x00855210
		public static void pushValue(IntPtr l, Color32 c32) {} // 0x00855210-0x00855310
	}
}
