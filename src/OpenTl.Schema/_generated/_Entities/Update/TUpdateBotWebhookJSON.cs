﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8317c0c3)]
	public class TUpdateBotWebhookJSON : IUpdate
	{
       [SerializationOrder(0)]
       public IDataJSON Data {get; set;}

	}
}
