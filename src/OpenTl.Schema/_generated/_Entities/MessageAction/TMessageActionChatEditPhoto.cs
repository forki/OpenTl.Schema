﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7fcb13a8)]
	public class TMessageActionChatEditPhoto : IMessageAction
	{
       [SerializationOrder(0)]
       public IPhoto Photo {get; set;}

	}
}