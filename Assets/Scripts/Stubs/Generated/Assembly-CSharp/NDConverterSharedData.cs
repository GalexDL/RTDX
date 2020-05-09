/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NDConverterSharedData // TypeDefIndex: 5163
{
	// Nested types
	public enum NatureType // TypeDefIndex: 5164
	{
		Hardly = 0,
		Docile = 1,
		Brave = 2,
		Jolly = 3,
		Implish = 4,
		Naive = 5,
		Timid = 6,
		Hasty = 7,
		Sassy = 8,
		Clam = 9,
		Relaxed = 10,
		Lonely = 11,
		Quirky = 12,
		End = 13
	}

	[Serializable]
	public class DataStore // TypeDefIndex: 5165
	{
		// Fields
		public List<DiagnosisStrage> m_diagnosisStrageList; // 0x10
		public List<PokemonStrage> m_pokemonNatureAndTypeList; // 0x18

		// Constructors
		public DataStore() {} // 0x00E36730-0x00E367D0
	}

	[Serializable]
	public class DiagnosisStrage // TypeDefIndex: 5166
	{
		// Fields
		public List<AnswerStrage> m_answerStrageList; // 0x10
		public string m_question; // 0x18
		public string m_questionType; // 0x20

		// Constructors
		public DiagnosisStrage() {} // 0x00E367D0-0x00E36860
	}

	[Serializable]
	public class AnswerStrage // TypeDefIndex: 5167
	{
		// Fields
		public string m_answer; // 0x10
		public List<NaturePoint> m_addNatureList; // 0x18

		// Constructors
		public AnswerStrage() {} // 0x00E366A0-0x00E36730
	}

	[Serializable]
	public class NaturePoint // TypeDefIndex: 5168
	{
		// Fields
		public string m_nature; // 0x10
		public int m_addPoint; // 0x18

		// Constructors
		public NaturePoint() {} // 0x00E36860-0x00E368C0
	}

	[Serializable]
	public class PokemonStrage // TypeDefIndex: 5169
	{
		// Fields
		public string m_name; // 0x10
		public string m_nameLabel; // 0x18
		public string m_maleNature; // 0x20
		public string m_femaleNature; // 0x28
		public string m_typeA; // 0x30
		public string m_symbolName; // 0x38
		public string m_symbolNameFemale; // 0x40
		public int m_defaultPos; // 0x48
		public int m_pos1; // 0x4C
		public int m_pos2; // 0x50
		public int m_pos3; // 0x54

		// Constructors
		public PokemonStrage() {} // 0x00E368C0-0x00E36930
		public PokemonStrage(PokemonStrage strage) {} // 0x00E36930-0x00E369B0
	}

	// Constructors
	public NDConverterSharedData() {} // 0x00E36690-0x00E366A0
}

