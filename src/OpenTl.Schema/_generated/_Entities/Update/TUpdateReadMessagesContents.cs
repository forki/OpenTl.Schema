﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x68c13933)]
	public class TUpdateReadMessagesContents : IUpdate
	{
       [SerializationOrder(0)]
       public TVector<int> Messages {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int PtsCount {get; set;}

	}
}
