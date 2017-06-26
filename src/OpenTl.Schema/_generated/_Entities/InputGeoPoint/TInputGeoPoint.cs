﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf3b7acc9)]
	public class TInputGeoPoint : IInputGeoPoint
	{
       [SerializationOrder(0)]
       public double Lat {get; set;}

       [SerializationOrder(1)]
       public double Long {get; set;}

	}
}
