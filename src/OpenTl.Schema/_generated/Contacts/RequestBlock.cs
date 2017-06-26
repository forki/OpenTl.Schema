﻿// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x332b49fc)]
    public class RequestBlock : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputUser Id {get; set;}

    }
}
