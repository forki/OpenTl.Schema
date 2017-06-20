﻿namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7d885289)]
    public class RequestExportChatInvite : IRequest<IExportedChatInvite>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}