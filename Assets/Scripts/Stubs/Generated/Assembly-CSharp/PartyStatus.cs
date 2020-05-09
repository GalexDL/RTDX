/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PartyStatus : IPartyStatus // TypeDefIndex: 5193
{
	// Fields
	private PartyMemberId m_memberId; // 0x10
	private PokemonStatus m_status; // 0x18

	// Constructors
	public PartyStatus() {} // Dummy constructor
	public PartyStatus(PartyMemberId memberId, ulong statusId, uint uniqueId) {} // 0x00788E60-0x00788F00

	// Methods
	public bool IsPlayer() => default; // 0x00788F00-0x00788F90
	public IPokemonStatus GetStatus() => default; // 0x00788F90-0x00788FA0
	public PartyMemberId GetPartyMemberId() => default; // 0x00788FA0-0x00788FB0
}

