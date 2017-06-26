﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xccd3563d)]
	public class TBotResults : IBotResults
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Gallery {get; set;}

       [SerializationOrder(2)]
       public long QueryId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public string NextOffset {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public IInlineBotSwitchPM SwitchPm {get; set;}

       [SerializationOrder(5)]
       public TVector<IBotInlineResult> Results {get; set;}

       [SerializationOrder(6)]
       public int CacheTime {get; set;}

	}
}
