﻿namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x548a30f5)]
    public class RequestGetPassword : IRequest<Account.IPassword>
    {

    }
}
