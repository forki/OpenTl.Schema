﻿// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IConfig : IObject
    {
       BitArray Flags {get; set;}

       bool PhonecallsEnabled {get; set;}

       bool DefaultP2pContacts {get; set;}

       int Date {get; set;}

       int Expires {get; set;}

       bool TestMode {get; set;}

       int ThisDc {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDcOption> DcOptions {get; set;}

       int ChatSizeMax {get; set;}

       int MegagroupSizeMax {get; set;}

       int ForwardedCountMax {get; set;}

       int OnlineUpdatePeriodMs {get; set;}

       int OfflineBlurTimeoutMs {get; set;}

       int OfflineIdleTimeoutMs {get; set;}

       int OnlineCloudTimeoutMs {get; set;}

       int NotifyCloudDelayMs {get; set;}

       int NotifyDefaultDelayMs {get; set;}

       int ChatBigSize {get; set;}

       int PushChatPeriodMs {get; set;}

       int PushChatLimit {get; set;}

       int SavedGifsLimit {get; set;}

       int EditTimeLimit {get; set;}

       int RatingEDecay {get; set;}

       int StickersRecentLimit {get; set;}

       int StickersFavedLimit {get; set;}

       int ChannelsReadMediaPeriod {get; set;}

       int TmpSessions {get; set;}

       int PinnedDialogsCountMax {get; set;}

       int CallReceiveTimeoutMs {get; set;}

       int CallRingTimeoutMs {get; set;}

       int CallConnectTimeoutMs {get; set;}

       int CallPacketTimeoutMs {get; set;}

       byte[] MeUrlPrefixAsBinary {get; set;}
       string MeUrlPrefix {get; set;}

       byte[] SuggestedLangCodeAsBinary {get; set;}
       string SuggestedLangCode {get; set;}

       int LangPackVersion {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDisabledFeature> DisabledFeatures {get; set;}

    }
}
