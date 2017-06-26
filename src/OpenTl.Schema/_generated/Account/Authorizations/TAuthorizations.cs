﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1250abde)]
	public class TAuthorizations : IAuthorizations
	{
       [SerializationOrder(0)]
       public TVector<IAuthorization> Authorizations {get; set;}

	}
}
