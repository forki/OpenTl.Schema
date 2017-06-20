﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfdb19008)]
	public class TMessageMediaGame : IMessageMedia
	{
       [SerializationOrder(0)]
       public IGame Game {get; set;}

	}
}
