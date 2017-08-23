﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf288a275)]
    public class RequestSearch : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputUser FromId {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IMessagesFilter Filter {get; set;}

       [SerializationOrder(5)]
       public int MinDate {get; set;}

       [SerializationOrder(6)]
       public int MaxDate {get; set;}

       [SerializationOrder(7)]
       public int Offset {get; set;}

       [SerializationOrder(8)]
       public int MaxId {get; set;}

       [SerializationOrder(9)]
       public int Limit {get; set;}

    }
}
