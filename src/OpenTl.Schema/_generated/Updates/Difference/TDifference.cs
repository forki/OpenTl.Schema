﻿namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf49ca0)]
	public class TDifference : IDifference
	{
       [SerializationOrder(0)]
       public TVector<IMessage> NewMessages {get; set;}

       [SerializationOrder(1)]
       public TVector<IEncryptedMessage> NewEncryptedMessages {get; set;}

       [SerializationOrder(2)]
       public TVector<IUpdate> OtherUpdates {get; set;}

       [SerializationOrder(3)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(4)]
       public TVector<IUser> Users {get; set;}

       [SerializationOrder(5)]
       public Updates.IState State {get; set;}

	}
}