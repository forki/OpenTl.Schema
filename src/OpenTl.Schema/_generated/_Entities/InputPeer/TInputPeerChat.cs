﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x179be863)]
	public class TInputPeerChat : IInputPeer
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

	}
}
