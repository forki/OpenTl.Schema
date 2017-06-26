﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb0467fb)]
	public class TUpdateChannelTooLong : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int ChannelId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int Pts {get; set;}

	}
}
