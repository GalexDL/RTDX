/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class FlowGameSaveData // TypeDefIndex: 5398
{
	// Nested types
	[Serializable]
	public class NodeData // TypeDefIndex: 5399
	{
		// Fields
		public int m_ID; // 0x10
		public string m_messageLabel; // 0x18
		public string[] m_rootLabel; // 0x20
		public int[] m_nextNodeID; // 0x28
		public ShopFlowNode.NodeType m_type; // 0x30
		public int m_defaultRootNo; // 0x34
		public bool m_bCancel; // 0x38
		public int m_cancelNextNodeID; // 0x3C
		public string m_anotherMessageLabel; // 0x40
		public int m_selectIndex; // 0x48
		public int m_anotherSelectIndex; // 0x4C
		public bool m_bSystem; // 0x50
		public string m_cursorDataName; // 0x58
		public string m_messagelabelGraduateCsv; // 0x60
		public string[] m_rootLabelGraduateCsv; // 0x68
		public string m_anotherMessagelabelGraduateCsv; // 0x70
		public string m_targetTagType; // 0x78
		public string m_targetBufNum; // 0x80
		public string m_jumpLabel; // 0x88
		public string m_scriptFileName; // 0x90
		public string m_scriptExecuteName; // 0x98
		public string m_scriptFileName_another; // 0xA0
		public string m_scriptExecuteName_another; // 0xA8
		public string m_cameraTargetName; // 0xB0

		// Constructors
		public NodeData() {} // 0x0081B100-0x0081B110
	}

	public enum SaveTitleType // TypeDefIndex: 5400
	{
		NodeDatabase = 0,
		OutputOne_NodeBase = 1,
		OutputMultiple_NodeBase = 2,
		OutputNone_NodeBase = 3,
		MenuTypeNode = 4,
		TagSetTypeNode = 5,
		CallFlowTypeNode = 6,
		CallScriptTypeNode = 7,
		CallScript_AnotherNode = 8,
		MessageTypeNode = 9,
		Message_AnotherNode = 10,
		AskNode = 11,
		Ask_AnotherNode = 12,
		TwoWayCheckNode = 13,
		ConfirmTypeNode = 14
	}

	public class NodeDataBase // TypeDefIndex: 5401
	{
		// Fields
		public int ID; // 0x10
		public ShopFlowNode.NodeType type; // 0x14

		// Constructors
		public NodeDataBase() {} // Dummy constructor
		public NodeDataBase(ShopFlowNode node) {} // 0x0081AE70-0x0081AEB0

		// Methods
		public string GetJsonData() => default; // 0x0081ABD0-0x0081ABE0
	}

	public class OutputOne_NodeBase : NodeDataBase // TypeDefIndex: 5402
	{
		// Fields
		public int nextId; // 0x18

		// Constructors
		public OutputOne_NodeBase() {} // Dummy constructor
		public OutputOne_NodeBase(ShopFlowNode node) {} // 0x0081AF80-0x0081AFC0
	}

	public class OutputMultiple_NodeBase : NodeDataBase // TypeDefIndex: 5403
	{
		// Fields
		public int[] nextNodeID; // 0x18

		// Constructors
		public OutputMultiple_NodeBase() {} // Dummy constructor
		public OutputMultiple_NodeBase(ShopFlowNode node) {} // 0x0081AEB0-0x0081AF40
	}

	public class OutputNone_NodeBase : NodeDataBase // TypeDefIndex: 5404
	{
		// Constructors
		public OutputNone_NodeBase() {} // Dummy constructor
		public OutputNone_NodeBase(ShopFlowNode node) {} // 0x0081AF40-0x0081AF80
	}

	public class MenuTypeNode : OutputMultiple_NodeBase // TypeDefIndex: 5405
	{
		// Fields
		public string cursorDataName; // 0x20
		public int cancelNextNodeID; // 0x28

		// Constructors
		public MenuTypeNode() {} // Dummy constructor
		public MenuTypeNode(ShopFlowNode node) {} // 0x0081AD10-0x0081ADB0
	}

	public class TagSetTypeNode : OutputOne_NodeBase // TypeDefIndex: 5406
	{
		// Fields
		public int selectIndex; // 0x1C
		public string targetTagTypeName; // 0x20
		public string targetBufNum; // 0x28

		// Constructors
		public TagSetTypeNode() {} // Dummy constructor
		public TagSetTypeNode(ShopFlowNode node) {} // 0x0081AFC0-0x0081B010
	}

	public class CallFlowTypeNode : OutputOne_NodeBase // TypeDefIndex: 5407
	{
		// Fields
		public int selectIndex; // 0x1C

		// Constructors
		public CallFlowTypeNode() {} // Dummy constructor
		public CallFlowTypeNode(ShopFlowNode node) {} // 0x0081AC20-0x0081AC60
	}

	public class JumpTypeNode // TypeDefIndex: 5408
	{
		// Fields
		public string jumpLabel; // 0x10

		// Constructors
		public JumpTypeNode() {} // 0x0081B0F0-0x0081B100
	}

	public class CallScriptTypeNode : OutputOne_NodeBase // TypeDefIndex: 5409
	{
		// Fields
		public string scriptFileName; // 0x20
		public string scriptExecuteName; // 0x28

		// Constructors
		public CallScriptTypeNode() {} // Dummy constructor
		public CallScriptTypeNode(ShopFlowNode node) {} // 0x0081AC60-0x0081ACB0
	}

	public class CallScript_AnotherNode : CallScriptTypeNode // TypeDefIndex: 5410
	{
		// Fields
		public string scriptFileName_Another; // 0x30
		public string scriptExecuteName_Another; // 0x38

		// Constructors
		public CallScript_AnotherNode() {} // Dummy constructor
		public CallScript_AnotherNode(ShopFlowNode node) {} // 0x0081ACB0-0x0081AD10
	}

	public class MessageTypeNode : OutputOne_NodeBase // TypeDefIndex: 5411
	{
		// Fields
		public string messageLabel; // 0x20
		public string messagelabelGraduateCsv; // 0x28
		public bool bSystem; // 0x30

		// Constructors
		public MessageTypeNode() {} // Dummy constructor
		public MessageTypeNode(ShopFlowNode node) {} // 0x0081ADB0-0x0081AE00
	}

	public class Message_AnotherNode : MessageTypeNode // TypeDefIndex: 5412
	{
		// Fields
		public string messageLabel_Another; // 0x38
		public string messagelabelGraduateCsv_Another; // 0x40

		// Constructors
		public Message_AnotherNode() {} // Dummy constructor
		public Message_AnotherNode(ShopFlowNode node) {} // 0x0081AE00-0x0081AE70
	}

	public class AskNode : OutputMultiple_NodeBase // TypeDefIndex: 5413
	{
		// Fields
		public string messageLabel; // 0x20
		public string messagelabelGraduateCsv; // 0x28
		public bool bSystem; // 0x30
		public string[] rootLabel; // 0x38
		public string[] rootLabelGraduateCsv; // 0x40
		public int defaultRootIndex; // 0x48
		public int cancelNextNodeID; // 0x4C

		// Constructors
		public AskNode() {} // Dummy constructor
		public AskNode(ShopFlowNode node) {} // 0x0081AAC0-0x0081ABD0
	}

	public class Ask_AnotherNode : AskNode // TypeDefIndex: 5414
	{
		// Fields
		public string messageLabel_Another; // 0x50
		public string messagelabelGraduateCsv_Another; // 0x58

		// Constructors
		public Ask_AnotherNode() {} // Dummy constructor
		public Ask_AnotherNode(ShopFlowNode node) {} // 0x0081ABE0-0x0081AC20
	}

	public class TwoWayCheckNode : OutputMultiple_NodeBase // TypeDefIndex: 5415
	{
		// Constructors
		public TwoWayCheckNode() {} // Dummy constructor
		public TwoWayCheckNode(ShopFlowNode node) {} // 0x0081B010-0x0081B0A0
	}

	public class ConfirmTypeNode : OutputOne_NodeBase // TypeDefIndex: 5416
	{
		// Constructors
		public ConfirmTypeNode() {} // Dummy constructor
		public ConfirmTypeNode(ShopFlowNode node) {} // 0x0081B0A0-0x0081B0E0
	}

	// Constructors
	public FlowGameSaveData() {} // 0x0081B0E0-0x0081B0F0
}

