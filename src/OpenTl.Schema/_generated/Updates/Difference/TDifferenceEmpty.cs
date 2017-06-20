﻿namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d75a138)]
	public class TDifferenceEmpty : IDifference
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

       [SerializationOrder(1)]
       public int Seq {get; set;}

	}
}
