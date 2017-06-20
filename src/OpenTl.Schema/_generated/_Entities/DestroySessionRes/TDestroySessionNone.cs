﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x62d350c9)]
	public class TDestroySessionNone : IDestroySessionRes
	{
       [SerializationOrder(0)]
       public long SessionId {get; set;}

	}
}
