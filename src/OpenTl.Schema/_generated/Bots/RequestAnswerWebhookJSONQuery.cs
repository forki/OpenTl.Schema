﻿namespace OpenTl.Schema.Bots
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6213f4d)]
    public class RequestAnswerWebhookJSONQuery : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long QueryId {get; set;}

       [SerializationOrder(1)]
       public IDataJSON Data {get; set;}

    }
}
