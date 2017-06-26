﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x14637196)]
	public class TInputFileLocation : IInputFileLocation
	{
       [SerializationOrder(0)]
       public long VolumeId {get; set;}

       [SerializationOrder(1)]
       public int LocalId {get; set;}

       [SerializationOrder(2)]
       public long Secret {get; set;}

	}
}
