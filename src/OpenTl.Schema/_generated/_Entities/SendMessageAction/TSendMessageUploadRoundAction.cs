﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x243e1c66)]
	public class TSendMessageUploadRoundAction : ISendMessageAction
	{
       [SerializationOrder(0)]
       public int Progress {get; set;}

	}
}