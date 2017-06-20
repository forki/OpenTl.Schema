﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8ffa9a1f)]
	public class TPageBlockSubtitle : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
