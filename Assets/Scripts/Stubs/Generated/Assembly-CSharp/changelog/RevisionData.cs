/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace changelog
{
	public class RevisionData // TypeDefIndex: 8489
	{
		// Fields
		private XDocument document; // 0x10
		private XElement root; // 0x18
		public List<Item> Items; // 0x30
	
		// Properties
		public string Revision { get; private set; } // 0x0074A4E0-0x0074A4F0 0x0074A4F0-0x0074A500
		public string BuildNum { get; private set; } // 0x0074A500-0x0074A510 0x0074A510-0x0074A520
	
		// Nested types
		public class Item // TypeDefIndex: 8490
		{
			// Fields
			public LinkedListNode<GameObject> node; // 0x38
	
			// Properties
			public string date { get; private set; } // 0x00748430-0x00748440 0x0074A620-0x0074A630
			public string user { get; private set; } // 0x00748440-0x00748450 0x0074A630-0x0074A640
			public string revision { get; private set; } // 0x00748420-0x00748430 0x0074A640-0x0074A650
			public string message { get; private set; } // 0x00748450-0x00748460 0x0074A650-0x0074A660
			public bool IsBugFix { get; private set; } // 0x00749A90-0x00749AA0 0x0074A660-0x0074A670
			public bool IsNew { get; private set; } // 0x00749AA0-0x00749AB0 0x0074A670-0x0074A680
	
			// Constructors
			public Item() {} // Dummy constructor
			public Item(string date, string user, string revision, string message) {} // 0x0074A520-0x0074A620
		}
	
		// Constructors
		public RevisionData() {} // Dummy constructor
		public RevisionData(string xmlText) {} // 0x00748A90-0x00748EB0
	}
}
