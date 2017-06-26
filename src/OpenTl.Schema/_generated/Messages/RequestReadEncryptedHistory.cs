﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7f4b690a)]
    public class RequestReadEncryptedHistory : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public int MaxDate {get; set;}

    }
}
