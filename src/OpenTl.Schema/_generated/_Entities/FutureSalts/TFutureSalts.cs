﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xae500895)]
	public class TFutureSalts : IFutureSalts
	{
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

       [SerializationOrder(1)]
       public int Now {get; set;}

       [SerializationOrder(2)]
       public TVector<OpenTl.Schema.TFutureSalt> Salts {get; set;}

	}
}
