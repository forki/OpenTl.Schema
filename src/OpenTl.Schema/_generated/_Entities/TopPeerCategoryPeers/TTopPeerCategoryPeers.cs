﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfb834291)]
	public class TTopPeerCategoryPeers : ITopPeerCategoryPeers
	{
       [SerializationOrder(0)]
       public ITopPeerCategory Category {get; set;}

       [SerializationOrder(1)]
       public int Count {get; set;}

       [SerializationOrder(2)]
       public TVector<ITopPeer> Peers {get; set;}

	}
}
