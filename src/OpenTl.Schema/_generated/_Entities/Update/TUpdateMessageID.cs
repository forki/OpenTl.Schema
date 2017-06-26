﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4e90bfd6)]
	public class TUpdateMessageID : IUpdate
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public long RandomId {get; set;}

	}
}
