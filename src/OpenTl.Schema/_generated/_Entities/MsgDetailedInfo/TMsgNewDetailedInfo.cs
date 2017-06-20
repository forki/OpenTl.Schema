﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x809db6df)]
	public class TMsgNewDetailedInfo : IMsgDetailedInfo
	{
       [SerializationOrder(0)]
       public long AnswerMsgId {get; set;}

       [SerializationOrder(1)]
       public int Bytes {get; set;}

       [SerializationOrder(2)]
       public int Status {get; set;}

	}
}
