﻿namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5b118126)]
    public class RequestReadFeaturedStickers : IRequest<bool>
    {
       [SerializationOrder(0)]
       public TVector<long> Id {get; set;}

    }
}
