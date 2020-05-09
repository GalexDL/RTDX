/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonBulletinBoard : UICommonBulletinBoard // TypeDefIndex: 6482
{
	// Fields
	private TrustQuestSelectType trustQuestSelect_; // 0x38
	private bool bCommonClose; // 0x3C

	// Nested types
	public enum TrustQuestSelectType // TypeDefIndex: 6483
	{
		Cancel = -1,
		None = 0
	}

	// Constructors
	public UIDungeonBulletinBoard() {} // 0x00B1E330-0x00B1E340

	// Methods
	public static UIDungeonBulletinBoard Create() => default; // 0x00B1D690-0x00B1D860
	public virtual void Construct() {} // 0x00B1D860-0x00B1DA60
	public virtual void Destruct() {} // 0x00B1DA60-0x00B1DAE0
	private static int TicketCompare(TicketListInfo a, TicketListInfo b) => default; // 0x00B1DAE0-0x00B1DB20
	public void InitTrustQuest() {} // 0x00B1DB20-0x00B1E040
	public void SetCommonClose() {} // 0x00B1E040-0x00B1E050
	// [IteratorStateMachine] // 0x00626FC0-0x00627030
	public IEnumerator TrustQuestMainFlow(Action<TrustQuestSelectType> cb = null) => default; // 0x00B1E050-0x00B1E0D0
	public void ContinueTrustQuest() {} // 0x00B1E100-0x00B1E110
	public void EndTrustQuest() {} // 0x00B1E110-0x00B1E120
	private void _cbFromTrustQuestList(ListWindowBase.ActionType act) {} // 0x00B1E120-0x00B1E300
	protected virtual void Start() {} // 0x00B1E300-0x00B1E310
	protected virtual void Update() {} // 0x00B1E310-0x00B1E330
}

