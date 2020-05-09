/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.news;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Post : Singleton<Post>, IPost // TypeDefIndex: 5206
{
	// Properties
	public int Max { get => default; } // 0x009EF530-0x009EF5A0 

	// Constructors
	public Post() {} // 0x009EF5A0-0x009EF610

	// Methods
	public List<IQuestTicket> GetTicketList() => default; // 0x009EF610-0x009EF850
	public List<IQuestTicket> GetQuestTicketList() => default; // 0x009EF8D0-0x009EFA60
	public List<IQuestTicket> GetNewsTicketList() => default; // 0x009EFA60-0x009EFBF0
	public bool UpdateNewsAndQuest() => default; // 0x009EFBF0-0x009EFC60
	public bool HasLetter() => default; // 0x009EFC60-0x009EFDD0
	public void ForceShowNews(Index newsIndex) {} // 0x009EFDD0-0x009EFE40
	public void ForceAddNews(Index newsIndex) {} // 0x009EFE40-0x009EFEB0
}

