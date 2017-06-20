﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb8d0afdf)]
	public class TAccountDaysTTL : IAccountDaysTTL
	{
       [SerializationOrder(0)]
       public int Days {get; set;}

	}
}