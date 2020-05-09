/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonRescueBoard : UICommonRescueBoard // TypeDefIndex: 7472
{
	// Fields
	private TrustQuestSelectType trustQuestSelect_; // 0x38
	protected bool bCommonClose; // 0x3C

	// Nested types
	public enum TrustQuestSelectType // TypeDefIndex: 7473
	{
		Cancel = -1,
		None = 0
	}

	// Constructors
	public UIDungeonRescueBoard() {} // 0x00B20BD0-0x00B20BE0

	// Methods
	public static UIDungeonRescueBoard Create() => default; // 0x00B1FF10-0x00B200F0
	public virtual void Construct() {} // 0x00B200F0-0x00B202E0
	public virtual void Destruct() {} // 0x00B202E0-0x00B20360
	private static int TicketCompare(TicketListInfo a, TicketListInfo b) => default; // 0x00B20360-0x00B203A0
	public void SetCommonClose() {} // 0x00B203A0-0x00B203B0
	public void InitTrustRescue() {} // 0x00B203B0-0x00B208F0
	// [IteratorStateMachine] // 0x0062C4B0-0x0062C520
	public IEnumerator TrustRescueMainFlow(Action<TrustQuestSelectType> cb = null) => default; // 0x00B208F0-0x00B20970
	public void ContinueTrustRescue() {} // 0x00B209A0-0x00B209B0
	public void EndTrustRescue() {} // 0x00B209B0-0x00B209C0
	private void _cbFromTrustRescueList(ListWindowBase.ActionType act) {} // 0x00B209C0-0x00B20BA0
	protected virtual void Start() {} // 0x00B20BA0-0x00B20BB0
	protected virtual void Update() {} // 0x00B20BB0-0x00B20BD0
}

