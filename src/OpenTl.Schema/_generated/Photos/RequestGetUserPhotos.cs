﻿namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x91cd32a8)]
    public class RequestGetUserPhotos : IRequest<Photos.IPhotos>
    {
       [SerializationOrder(0)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public long MaxId {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

    }
}
