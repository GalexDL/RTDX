/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

internal class BasicNumberSelectWindow : NumberSelectWindowBase // TypeDefIndex: 6389
{
	// Fields
	private bool focus; // 0x38
	protected bool bResumeClearSelect_; // 0x39
	private int numberCount_; // 0x3C
	private int digitNumber_; // 0x40
	private int maxCount_; // 0x44
	private UIControlTMP[] numbers_; // 0x48
	private UIControlTMPSetter[] setters_; // 0x50
	private int digit_; // 0x58
	private GameObject cursor_; // 0x60
	private UIControlTMP maxNumber_; // 0x68

	// Properties
	public int SelectCount { get => default; set {} } // 0x008BC080-0x008BC090 0x008BC090-0x008BC0A0
	public int DigitNumber { get => default; } // 0x008BC0A0-0x008BC0B0 
	protected int MaxCount { get => default; set {} } // 0x008BC650-0x008BC660 0x008BC640-0x008BC650
	protected UIControlTMP[] Numbers { get => default; set {} } // 0x008BCAC0-0x008BCAD0 0x008BCAB0-0x008BCAC0
	protected UIControlTMPSetter[] Setters { get => default; set {} } // 0x008BCAE0-0x008BCAF0 0x008BCAD0-0x008BCAE0
	protected int Dight { get => default; set {} } // 0x008BCB00-0x008BCB10 0x008BCAF0-0x008BCB00
	protected int Digit { get => default; set {} } // 0x008BCB20-0x008BCB30 0x008BCB10-0x008BCB20
	protected GameObject CursorObject { set {} } // 0x008BCB30-0x008BCB40

	// Constructors
	public BasicNumberSelectWindow() {} // 0x008BD040-0x008BD050

	// Methods
	protected override void _doInput() {} // 0x008BBCD0-0x008BBF60
	protected virtual bool _doSelectCountMax() => default; // 0x008BBF60-0x008BBFF0
	protected virtual bool _doSelectCountMin() => default; // 0x008BBFF0-0x008BC080
	protected override void _update() {} // 0x008BC0B0-0x008BC0D0
	protected virtual void FaceUpdate() {} // 0x008BC0D0-0x008BC420
	protected virtual void MoveCusor(bool se = true /* Metadata: 0x00612CF7 */) {} // 0x008BC480-0x008BC620
	protected virtual void CountReset() {} // 0x008BC620-0x008BC630
	protected virtual void DigitReset() {} // 0x008BC630-0x008BC640
	private int Work(int i) => default; // 0x008BC420-0x008BC480
	protected virtual bool _doUp() => default; // 0x008BC660-0x008BC830
	protected virtual bool _doDown() => default; // 0x008BC830-0x008BC970
	protected virtual bool _doLeft() => default; // 0x008BC970-0x008BC9B0
	protected virtual bool _doRight() => default; // 0x008BC9B0-0x008BC9F0
	protected virtual bool _doDecide() => default; // 0x008BC9F0-0x008BCA90
	protected virtual bool _doCancel() => default; // 0x008BCA90-0x008BCAB0
	public virtual void InitObjRoot(GameObject objRoot, int digit, int maxCount, Kind kindIndex) {} // 0x008BCB40-0x008BD040
}

