﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbf9459b7)]
    public class RequestInvokeWithoutUpdates : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public IObject Query {get; set;}

    }
}
