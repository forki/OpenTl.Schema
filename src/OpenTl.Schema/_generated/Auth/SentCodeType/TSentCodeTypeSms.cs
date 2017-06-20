﻿namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc000bba2)]
	public class TSentCodeTypeSms : ISentCodeType
	{
       [SerializationOrder(0)]
       public int Length {get; set;}

	}
}
