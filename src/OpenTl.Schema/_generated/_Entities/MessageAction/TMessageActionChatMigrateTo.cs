﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x51bdb021)]
	public class TMessageActionChatMigrateTo : IMessageAction
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

	}
}
