﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2049d70c)]
	public class TGeoPoint : IGeoPoint
	{
       [SerializationOrder(0)]
       public double Long {get; set;}

       [SerializationOrder(1)]
       public double Lat {get; set;}

	}
}
