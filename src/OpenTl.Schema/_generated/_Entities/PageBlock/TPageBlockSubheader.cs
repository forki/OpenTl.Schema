﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf12bb6e1)]
	public class TPageBlockSubheader : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
