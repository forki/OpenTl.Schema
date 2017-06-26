﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x450a1c0a)]
	public class TFoundGifs : IFoundGifs
	{
       [SerializationOrder(0)]
       public int NextOffset {get; set;}

       [SerializationOrder(1)]
       public TVector<IFoundGif> Results {get; set;}

	}
}
