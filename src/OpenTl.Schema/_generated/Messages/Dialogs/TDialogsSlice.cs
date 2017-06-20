﻿namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x71e094f3)]
	public class TDialogsSlice : IDialogs
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

       [SerializationOrder(1)]
       public TVector<IDialog> Dialogs {get; set;}

       [SerializationOrder(2)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(3)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(4)]
       public TVector<IUser> Users {get; set;}

	}
}
