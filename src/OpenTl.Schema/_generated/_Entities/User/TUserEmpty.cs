﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x200250ba)]
	public class TUserEmpty : IUser
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}