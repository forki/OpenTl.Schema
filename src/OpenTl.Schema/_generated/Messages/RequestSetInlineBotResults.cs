﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb5ea206)]
    public class RequestSetInlineBotResults : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Gallery {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Private {get; set;}

       [SerializationOrder(3)]
       public long QueryId {get; set;}

       [SerializationOrder(4)]
       public TVector<IInputBotInlineResult> Results {get; set;}

       [SerializationOrder(5)]
       public int CacheTime {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public string NextOffset {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 3)]
       public IInlineBotSwitchPM SwitchPm {get; set;}

    }
}
