﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9b9240a6)]
	public class TUpdateBotWebhookJSONQuery : IUpdate
	{
       [SerializationOrder(0)]
       public long QueryId {get; set;}

       [SerializationOrder(1)]
       public IDataJSON Data {get; set;}

       [SerializationOrder(2)]
       public int Timeout {get; set;}

	}
}