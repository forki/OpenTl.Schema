﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x914fbf11)]
	public class TUpdateShortMessage : IUpdates
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Mentioned {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool MediaUnread {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Silent {get; set;}

       [SerializationOrder(5)]
       public int Id {get; set;}

       [SerializationOrder(6)]
       public int UserId {get; set;}

       [SerializationOrder(7)]
       public string Message {get; set;}

       [SerializationOrder(8)]
       public int Pts {get; set;}

       [SerializationOrder(9)]
       public int PtsCount {get; set;}

       [SerializationOrder(10)]
       public int Date {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 2)]
       public IMessageFwdHeader FwdFrom {get; set;}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 11)]
       public int ViaBotId {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 3)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 7)]
       public TVector<IMessageEntity> Entities {get; set;}

	}
}
