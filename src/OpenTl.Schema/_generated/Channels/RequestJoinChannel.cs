﻿// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x24b524c5)]
    public class RequestJoinChannel : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

    }
}
