using System;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000477 RID: 1143
[Token(Token = "0x200032A")]
internal class NetworkingPeer : LoadbalancingPeer, IPhotonPeerListener
{
	// Token: 0x06001DF4 RID: 7668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x756BF8", Offset = "0x756BF8", VA = "0x756BF8")]
	public NetworkingPeer(IPhotonPeerListener listener, string playername, ConnectionProtocol connectionProtocol)
	{
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003EE")]
	protected internal string mAppVersionPun
	{
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x7573C4", Offset = "0x7573C4", VA = "0x7573C4")]
		get
		{
			return null;
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EF")]
	public AuthenticationValues CustomAuthenticationValues
	{
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x757478", Offset = "0x757478", VA = "0x757478")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC2FC", Offset = "0x4BC2FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x757480", Offset = "0x757480", VA = "0x757480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC30C", Offset = "0x4BC30C")]
		set
		{
		}
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003F0")]
	public string NameServerAddress
	{
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x757488", Offset = "0x757488", VA = "0x757488")]
		get
		{
			return null;
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F1")]
	public string MasterServerAddress
	{
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x757600", Offset = "0x757600", VA = "0x757600")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC31C", Offset = "0x4BC31C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x757608", Offset = "0x757608", VA = "0x757608")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC32C", Offset = "0x4BC32C")]
		protected internal set
		{
		}
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F2")]
	public string mGameserver
	{
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x757610", Offset = "0x757610", VA = "0x757610")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC33C", Offset = "0x4BC33C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x757618", Offset = "0x757618", VA = "0x757618")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC34C", Offset = "0x4BC34C")]
		internal set
		{
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00009120 File Offset: 0x00007320
	// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F3")]
	protected internal ServerConnection server
	{
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x757620", Offset = "0x757620", VA = "0x757620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC35C", Offset = "0x4BC35C")]
		get
		{
			return ServerConnection.MasterServer;
		}
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x757628", Offset = "0x757628", VA = "0x757628")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC36C", Offset = "0x4BC36C")]
		private set
		{
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00009138 File Offset: 0x00007338
	// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F4")]
	public PeerState State
	{
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x757630", Offset = "0x757630", VA = "0x757630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC37C", Offset = "0x4BC37C")]
		get
		{
			return global::PeerState.Uninitialized;
		}
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x7573BC", Offset = "0x7573BC", VA = "0x7573BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC38C", Offset = "0x4BC38C")]
		internal set
		{
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00009150 File Offset: 0x00007350
	// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F5")]
	public bool IsUsingNameServer
	{
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x757638", Offset = "0x757638", VA = "0x757638")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC39C", Offset = "0x4BC39C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x757640", Offset = "0x757640", VA = "0x757640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3AC", Offset = "0x4BC3AC")]
		protected internal set
		{
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x170003F6")]
	public bool IsAuthorizeSecretAvailable
	{
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x75764C", Offset = "0x75764C", VA = "0x75764C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F7")]
	public List<Region> AvailableRegions
	{
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x7576D8", Offset = "0x7576D8", VA = "0x7576D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3BC", Offset = "0x4BC3BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x7576E0", Offset = "0x7576E0", VA = "0x7576E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3CC", Offset = "0x4BC3CC")]
		protected internal set
		{
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00009180 File Offset: 0x00007380
	// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F8")]
	public CloudRegionCode CloudRegion
	{
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x7576E8", Offset = "0x7576E8", VA = "0x7576E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3DC", Offset = "0x4BC3DC")]
		get
		{
			return CloudRegionCode.eu;
		}
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x7576F0", Offset = "0x7576F0", VA = "0x7576F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3EC", Offset = "0x4BC3EC")]
		protected internal set
		{
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00009198 File Offset: 0x00007398
	[Token(Token = "0x170003F9")]
	private bool requestLobbyStatistics
	{
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x7576F8", Offset = "0x7576F8", VA = "0x7576F8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E0A RID: 7690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FA")]
	public TypedLobby lobby
	{
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x75777C", Offset = "0x75777C", VA = "0x75777C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC3FC", Offset = "0x4BC3FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x757150", Offset = "0x757150", VA = "0x757150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC40C", Offset = "0x4BC40C")]
		set
		{
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000091B0 File Offset: 0x000073B0
	// (set) Token: 0x06001E0C RID: 7692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FB")]
	public int mPlayersOnMasterCount
	{
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x757784", Offset = "0x757784", VA = "0x757784")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC41C", Offset = "0x4BC41C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x75778C", Offset = "0x75778C", VA = "0x75778C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC42C", Offset = "0x4BC42C")]
		internal set
		{
		}
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000091C8 File Offset: 0x000073C8
	// (set) Token: 0x06001E0E RID: 7694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FC")]
	public int mGameCount
	{
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x757794", Offset = "0x757794", VA = "0x757794")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC43C", Offset = "0x4BC43C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x75779C", Offset = "0x75779C", VA = "0x75779C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC44C", Offset = "0x4BC44C")]
		internal set
		{
		}
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000091E0 File Offset: 0x000073E0
	// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FD")]
	public int mPlayersInRoomsCount
	{
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x7577A4", Offset = "0x7577A4", VA = "0x7577A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC45C", Offset = "0x4BC45C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x7577AC", Offset = "0x7577AC", VA = "0x7577AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC46C", Offset = "0x4BC46C")]
		internal set
		{
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001E11 RID: 7697 RVA: 0x000091F8 File Offset: 0x000073F8
	[Token(Token = "0x170003FE")]
	protected internal int FriendsListAge
	{
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x7577B4", Offset = "0x7577B4", VA = "0x7577B4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FF")]
	public string PlayerName
	{
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x7577FC", Offset = "0x7577FC", VA = "0x7577FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x757158", Offset = "0x757158", VA = "0x757158")]
		set
		{
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000400")]
	public Room mCurrentGame
	{
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x757804", Offset = "0x757804", VA = "0x757804")]
		get
		{
			return null;
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000401")]
	internal Room mRoomToGetInto
	{
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x757988", Offset = "0x757988", VA = "0x757988")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC47C", Offset = "0x4BC47C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x757990", Offset = "0x757990", VA = "0x757990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC48C", Offset = "0x4BC48C")]
		set
		{
		}
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000402")]
	internal RoomOptions mRoomOptionsForCreate
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x757998", Offset = "0x757998", VA = "0x757998")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC49C", Offset = "0x4BC49C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x7579A0", Offset = "0x7579A0", VA = "0x7579A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC4AC", Offset = "0x4BC4AC")]
		set
		{
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06001E19 RID: 7705 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000403")]
	internal TypedLobby mRoomToEnterLobby
	{
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x7579A8", Offset = "0x7579A8", VA = "0x7579A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC4BC", Offset = "0x4BC4BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x7579B0", Offset = "0x7579B0", VA = "0x7579B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC4CC", Offset = "0x4BC4CC")]
		set
		{
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000404")]
	public PhotonPlayer mLocalActor
	{
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x757254", Offset = "0x757254", VA = "0x757254")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC4DC", Offset = "0x4BC4DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x75724C", Offset = "0x75724C", VA = "0x75724C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC4EC", Offset = "0x4BC4EC")]
		internal set
		{
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00009210 File Offset: 0x00007410
	// (set) Token: 0x06001E1E RID: 7710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000405")]
	public int mMasterClientId
	{
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x7579B8", Offset = "0x7579B8", VA = "0x7579B8")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x757A9C", Offset = "0x757A9C", VA = "0x757A9C")]
		private set
		{
		}
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x75748C", Offset = "0x75748C", VA = "0x75748C")]
	private string GetNameServerAddress()
	{
		return null;
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x00009228 File Offset: 0x00007428
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x757B0C", Offset = "0x757B0C", VA = "0x757B0C", Slot = "6")]
	public override bool Connect(string serverAddress, string applicationName)
	{
		return default(bool);
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x00009240 File Offset: 0x00007440
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x757B84", Offset = "0x757B84", VA = "0x757B84")]
	public bool Connect(string serverAddress, ServerConnection type)
	{
		return default(bool);
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x00009258 File Offset: 0x00007458
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x757DB4", Offset = "0x757DB4", VA = "0x757DB4")]
	public bool ConnectToNameServer()
	{
		return default(bool);
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x00009270 File Offset: 0x00007470
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x757EB4", Offset = "0x757EB4", VA = "0x757EB4")]
	public bool ConnectToRegionMaster(CloudRegionCode region)
	{
		return default(bool);
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x00009288 File Offset: 0x00007488
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x7580B0", Offset = "0x7580B0", VA = "0x7580B0")]
	public bool GetRegions()
	{
		return default(bool);
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x758104", Offset = "0x758104", VA = "0x758104", Slot = "7")]
	public override void Disconnect()
	{
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x758248", Offset = "0x758248", VA = "0x758248")]
	private void DisconnectToReconnect()
	{
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x758284", Offset = "0x758284", VA = "0x758284")]
	private void LeftLobbyCleanup()
	{
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x75859C", Offset = "0x75859C", VA = "0x75859C")]
	private void LeftRoomCleanup()
	{
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x758A38", Offset = "0x758A38", VA = "0x758A38")]
	protected internal void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects)
	{
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x759180", Offset = "0x759180", VA = "0x759180")]
	private void ReadoutProperties(Hashtable gameProperties, Hashtable pActorProperties, int targetActorNr)
	{
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x75725C", Offset = "0x75725C", VA = "0x75725C")]
	private void AddNewPlayer(int ID, PhotonPlayer player)
	{
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x759FB0", Offset = "0x759FB0", VA = "0x759FB0")]
	private void RemovePlayer(int ID, PhotonPlayer player)
	{
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x759DF0", Offset = "0x759DF0", VA = "0x759DF0")]
	private void RebuildPlayerListCopies()
	{
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x75A050", Offset = "0x75A050", VA = "0x75A050")]
	private void ResetPhotonViewsOnSerialize()
	{
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x75A188", Offset = "0x75A188", VA = "0x75A188")]
	private void HandleEventLeave(int actorID, EventData evLeave)
	{
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x75A7F4", Offset = "0x75A7F4", VA = "0x75A7F4")]
	private void CheckMasterClient(int leavingPlayerId)
	{
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x75A6E8", Offset = "0x75A6E8", VA = "0x75A6E8")]
	protected internal void UpdateMasterClient()
	{
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x000092A0 File Offset: 0x000074A0
	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x75AEA4", Offset = "0x75AEA4", VA = "0x75AEA4")]
	private static int ReturnLowestPlayerId(PhotonPlayer[] players, int playerIdToIgnore)
	{
		return 0;
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x000092B8 File Offset: 0x000074B8
	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x75AF90", Offset = "0x75AF90", VA = "0x75AF90")]
	protected internal bool SetMasterClient(int playerId, bool sync)
	{
		return default(bool);
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x000092D0 File Offset: 0x000074D0
	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x75B1D4", Offset = "0x75B1D4", VA = "0x75B1D4")]
	public bool SetMasterClient(int nextMasterId)
	{
		return default(bool);
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x7598C8", Offset = "0x7598C8", VA = "0x7598C8")]
	private Hashtable GetActorPropertiesForActorNr(Hashtable actorProperties, int actorNr)
	{
		return null;
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x759840", Offset = "0x759840", VA = "0x759840")]
	protected internal PhotonPlayer GetPlayerWithId(int number)
	{
		return null;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x757848", Offset = "0x757848", VA = "0x757848")]
	private void SendPlayerName()
	{
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x75B34C", Offset = "0x75B34C", VA = "0x75B34C")]
	private void GameEnteredOnGameServer(OperationResponse operationResponse)
	{
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x75BEF0", Offset = "0x75BEF0", VA = "0x75BEF0")]
	private Hashtable GetLocalActorProperties()
	{
		return null;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x758808", Offset = "0x758808", VA = "0x758808")]
	public void ChangeLocalID(int newID)
	{
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000092E8 File Offset: 0x000074E8
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x75C024", Offset = "0x75C024", VA = "0x75C024")]
	public bool OpCreateGame(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return default(bool);
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x00009300 File Offset: 0x00007500
	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x75C10C", Offset = "0x75C10C", VA = "0x75C10C")]
	public bool OpJoinRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, bool createIfNotExists)
	{
		return default(bool);
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x00009318 File Offset: 0x00007518
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x75C218", Offset = "0x75C218", VA = "0x75C218", Slot = "22")]
	public override bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, Hashtable playerProperties, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter)
	{
		return default(bool);
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x00009330 File Offset: 0x00007530
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x75C2DC", Offset = "0x75C2DC", VA = "0x75C2DC", Slot = "31")]
	public virtual bool OpLeave()
	{
		return default(bool);
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x00009348 File Offset: 0x00007548
	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x75C3F8", Offset = "0x75C3F8", VA = "0x75C3F8", Slot = "26")]
	public override bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
	{
		return default(bool);
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x75C4BC", Offset = "0x75C4BC", VA = "0x75C4BC", Slot = "27")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x75C588", Offset = "0x75C588", VA = "0x75C588", Slot = "28")]
	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x00009360 File Offset: 0x00007560
	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x75EFE0", Offset = "0x75EFE0", VA = "0x75EFE0", Slot = "23")]
	public override bool OpFindFriends(string[] friendsToFind)
	{
		return default(bool);
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x75F004", Offset = "0x75F004", VA = "0x75F004", Slot = "29")]
	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x760278", Offset = "0x760278", VA = "0x760278", Slot = "30")]
	public void OnEvent(EventData photonEvent)
	{
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x75BD88", Offset = "0x75BD88", VA = "0x75BD88")]
	protected internal void UpdatedActorList(int[] actorsInRoom)
	{
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x767AD0", Offset = "0x767AD0", VA = "0x767AD0")]
	private void SendVacantViewIds()
	{
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x758378", Offset = "0x758378", VA = "0x758378")]
	public static void SendMonoMessage(PhotonNetworkingMessage methodString, params object[] parameters)
	{
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x763404", Offset = "0x763404", VA = "0x763404")]
	protected internal void ExecuteRpc(Hashtable rpcData, PhotonPlayer sender)
	{
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x00009378 File Offset: 0x00007578
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x767FF0", Offset = "0x767FF0", VA = "0x767FF0")]
	private bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes)
	{
		return default(bool);
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x768144", Offset = "0x768144", VA = "0x768144")]
	internal Hashtable SendInstantiate(string prefabName, Vector3 position, Quaternion rotation, int group, int[] viewIDs, object[] data, bool isGlobalObject)
	{
		return null;
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x766B04", Offset = "0x766B04", VA = "0x766B04")]
	internal GameObject DoInstantiate(Hashtable evData, PhotonPlayer photonPlayer, GameObject resourceGameObject)
	{
		return null;
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x768634", Offset = "0x768634", VA = "0x768634")]
	private void StoreInstantiationData(int instantiationId, object[] instantiationData)
	{
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x76871C", Offset = "0x76871C", VA = "0x76871C")]
	public object[] FetchInstantiationData(int instantiationId)
	{
		return null;
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x7686AC", Offset = "0x7686AC", VA = "0x7686AC")]
	private void RemoveInstantiationData(int instantiationId)
	{
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x75AA64", Offset = "0x75AA64", VA = "0x75AA64")]
	public void DestroyPlayerObjects(int playerId, bool localOnly)
	{
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x767A94", Offset = "0x767A94", VA = "0x767A94")]
	public void DestroyAll(bool localOnly)
	{
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F0")]
	[Address(RVA = "0x758D60", Offset = "0x758D60", VA = "0x758D60")]
	protected internal void RemoveInstantiatedGO(GameObject go, bool localOnly)
	{
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x00009390 File Offset: 0x00007590
	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x769100", Offset = "0x769100", VA = "0x769100")]
	public int GetInstantiatedObjectsId(GameObject go)
	{
		return 0;
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F2")]
	[Address(RVA = "0x768C2C", Offset = "0x768C2C", VA = "0x768C2C")]
	private void ServerCleanInstantiateAndDestroy(int instantiateId, int creatorId, bool isRuntimeInstantiated)
	{
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x76899C", Offset = "0x76899C", VA = "0x76899C")]
	private void SendDestroyOfPlayer(int actorNr)
	{
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x768B3C", Offset = "0x768B3C", VA = "0x768B3C")]
	private void SendDestroyOfAll()
	{
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x7687AC", Offset = "0x7687AC", VA = "0x7687AC")]
	private void OpRemoveFromServerInstantiationsOfPlayer(int actorNr)
	{
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x7692F0", Offset = "0x7692F0", VA = "0x7692F0")]
	protected internal void RequestOwnership(int viewID, int fromOwner)
	{
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x7696F0", Offset = "0x7696F0", VA = "0x7696F0")]
	protected internal void TransferOwnership(int viewID, int playerID)
	{
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x768F18", Offset = "0x768F18", VA = "0x768F18")]
	public void LocalCleanPhotonView(PhotonView view)
	{
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x767DB8", Offset = "0x767DB8", VA = "0x767DB8")]
	public PhotonView GetPhotonView(int viewID)
	{
		return null;
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FA")]
	[Address(RVA = "0x769AF0", Offset = "0x769AF0", VA = "0x769AF0")]
	public void RegisterPhotonView(PhotonView netView)
	{
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x7688A4", Offset = "0x7688A4", VA = "0x7688A4")]
	public void OpCleanRpcBuffer(int actorNumber)
	{
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x769F88", Offset = "0x769F88", VA = "0x769F88")]
	public void OpRemoveCompleteCacheOfPlayer(int actorNumber)
	{
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x768A8C", Offset = "0x768A8C", VA = "0x768A8C")]
	public void OpRemoveCompleteCache()
	{
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x76A080", Offset = "0x76A080", VA = "0x76A080")]
	private void RemoveCacheOfLeftPlayers()
	{
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x76A19C", Offset = "0x76A19C", VA = "0x76A19C")]
	public void CleanRpcBufferIfMine(PhotonView view)
	{
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x768FC8", Offset = "0x768FC8", VA = "0x768FC8")]
	public void OpCleanRpcBuffer(PhotonView view)
	{
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x76A488", Offset = "0x76A488", VA = "0x76A488")]
	public void RemoveRPCsInGroup(int group)
	{
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x76A5D8", Offset = "0x76A5D8", VA = "0x76A5D8")]
	public void SetLevelPrefix(short prefix)
	{
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x76A5E0", Offset = "0x76A5E0", VA = "0x76A5E0")]
	internal void RPC(PhotonView view, string methodName, PhotonPlayer player, bool encrypt, params object[] parameters)
	{
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x76AF78", Offset = "0x76AF78", VA = "0x76AF78")]
	internal void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x76BC68", Offset = "0x76BC68", VA = "0x76BC68")]
	public void SetReceivingEnabled(int group, bool enabled)
	{
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x76BED4", Offset = "0x76BED4", VA = "0x76BED4")]
	public void SetReceivingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x76C390", Offset = "0x76C390", VA = "0x76C390")]
	public void SetSendingEnabled(int group, bool enabled)
	{
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001908")]
	[Address(RVA = "0x76C430", Offset = "0x76C430", VA = "0x76C430")]
	public void SetSendingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x76C5CC", Offset = "0x76C5CC", VA = "0x76C5CC")]
	public void NewSceneLoaded()
	{
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x76C998", Offset = "0x76C998", VA = "0x76C998")]
	public void RunViewUpdate()
	{
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600190B")]
	[Address(RVA = "0x76D404", Offset = "0x76D404", VA = "0x76D404")]
	private Hashtable OnSerializeWrite(PhotonView view)
	{
		return null;
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600190C")]
	[Address(RVA = "0x765DCC", Offset = "0x765DCC", VA = "0x765DCC")]
	private void OnSerializeRead(Hashtable data, PhotonPlayer sender, int networkTime, short correctPrefix)
	{
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000093A8 File Offset: 0x000075A8
	[Token(Token = "0x600190D")]
	[Address(RVA = "0x76D67C", Offset = "0x76D67C", VA = "0x76D67C")]
	private bool AlmostEquals(object[] lastData, object[] currentContent)
	{
		return default(bool);
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x000093C0 File Offset: 0x000075C0
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x76D748", Offset = "0x76D748", VA = "0x76D748")]
	private bool DeltaCompressionWrite(PhotonView view, Hashtable data)
	{
		return default(bool);
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x000093D8 File Offset: 0x000075D8
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x76DAC4", Offset = "0x76DAC4", VA = "0x76DAC4")]
	private bool DeltaCompressionRead(PhotonView view, Hashtable data)
	{
		return default(bool);
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x000093F0 File Offset: 0x000075F0
	[Token(Token = "0x6001910")]
	[Address(RVA = "0x76DD6C", Offset = "0x76DD6C", VA = "0x76DD6C")]
	private bool ObjectIsSameWithInprecision(object one, object two)
	{
		return default(bool);
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x00009408 File Offset: 0x00007608
	[Token(Token = "0x6001911")]
	[Address(RVA = "0x76E190", Offset = "0x76E190", VA = "0x76E190")]
	protected internal static bool GetMethod(MonoBehaviour monob, string methodType, out MethodInfo mi)
	{
		return default(bool);
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x759A14", Offset = "0x759A14", VA = "0x759A14")]
	protected internal void LoadLevelIfSynced()
	{
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x76E368", Offset = "0x76E368", VA = "0x76E368")]
	protected internal void SetLevelInPropsIfSynced(object levelId)
	{
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x76E828", Offset = "0x76E828", VA = "0x76E828")]
	public void SetApp(string appId, string gameVersion)
	{
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00009420 File Offset: 0x00007620
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x76E928", Offset = "0x76E928", VA = "0x76E928")]
	public bool WebRpc(string uriPath, object parameters)
	{
		return default(bool);
	}

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x38")]
	protected internal string mAppId;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBF3C", Offset = "0x4BBF3C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBF3C", Offset = "0x4BBF3C")]
	private AuthenticationValues <CustomAuthenticationValues>k__BackingField;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x4000D0C")]
	public const string NameServerHost = "ns.exitgames.com";

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x4000D0D")]
	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBF78", Offset = "0x4BBF78")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBF78", Offset = "0x4BBF78")]
	private string <MasterServerAddress>k__BackingField;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBFB4", Offset = "0x4BBFB4")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBFB4", Offset = "0x4BBFB4")]
	private string <mGameserver>k__BackingField;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBFF0", Offset = "0x4BBFF0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBFF0", Offset = "0x4BBFF0")]
	private ServerConnection <server>k__BackingField;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC02C", Offset = "0x4BC02C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC02C", Offset = "0x4BC02C")]
	private PeerState <State>k__BackingField;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC068", Offset = "0x4BC068")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC068", Offset = "0x4BC068")]
	private bool <IsUsingNameServer>k__BackingField;

	// Token: 0x040010DB RID: 4315
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x61")]
	public bool IsInitialConnect;

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x62")]
	private bool didAuthenticate;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x63")]
	public bool requestSecurity;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC0A4", Offset = "0x4BC0A4")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC0A4", Offset = "0x4BC0A4")]
	private List<Region> <AvailableRegions>k__BackingField;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC0E0", Offset = "0x4BC0E0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC0E0", Offset = "0x4BC0E0")]
	private CloudRegionCode <CloudRegion>k__BackingField;

	// Token: 0x040010E0 RID: 4320
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x78")]
	protected internal List<TypedLobbyInfo> LobbyStatistics;

	// Token: 0x040010E1 RID: 4321
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC11C", Offset = "0x4BC11C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC11C", Offset = "0x4BC11C")]
	private TypedLobby <lobby>k__BackingField;

	// Token: 0x040010E2 RID: 4322
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x88")]
	public bool insideLobby;

	// Token: 0x040010E3 RID: 4323
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x90")]
	public Dictionary<string, RoomInfo> mGameList;

	// Token: 0x040010E4 RID: 4324
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x98")]
	public RoomInfo[] mGameListCopy;

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC158", Offset = "0x4BC158")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC158", Offset = "0x4BC158")]
	private int <mPlayersOnMasterCount>k__BackingField;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC194", Offset = "0x4BC194")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC194", Offset = "0x4BC194")]
	private int <mGameCount>k__BackingField;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC1D0", Offset = "0x4BC1D0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC1D0", Offset = "0x4BC1D0")]
	private int <mPlayersInRoomsCount>k__BackingField;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0xAC")]
	private bool isFetchingFriends;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0xB0")]
	private string[] friendListRequested;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0xB8")]
	private int friendListTimestamp;

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0xC0")]
	private string playername;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0xC8")]
	private bool mPlayernameHasToBeUpdated;

	// Token: 0x040010ED RID: 4333
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC20C", Offset = "0x4BC20C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC20C", Offset = "0x4BC20C")]
	private Room <mRoomToGetInto>k__BackingField;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC248", Offset = "0x4BC248")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC248", Offset = "0x4BC248")]
	private RoomOptions <mRoomOptionsForCreate>k__BackingField;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC284", Offset = "0x4BC284")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC284", Offset = "0x4BC284")]
	private TypedLobby <mRoomToEnterLobby>k__BackingField;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0xE8")]
	private JoinType mLastJoinType;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0xF0")]
	public Dictionary<int, PhotonPlayer> mActors;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0xF8")]
	public PhotonPlayer[] mOtherPlayerListCopy;

	// Token: 0x040010F3 RID: 4339
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x100")]
	public PhotonPlayer[] mPlayerListCopy;

	// Token: 0x040010F4 RID: 4340
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC2C0", Offset = "0x4BC2C0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC2C0", Offset = "0x4BC2C0")]
	private PhotonPlayer <mLocalActor>k__BackingField;

	// Token: 0x040010F5 RID: 4341
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x110")]
	public bool hasSwitchedMC;

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x118")]
	private HashSet<int> allowedReceivingGroups;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x120")]
	private HashSet<int> blockSendingGroups;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x128")]
	protected internal Dictionary<int, PhotonView> photonViewList;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x130")]
	private readonly Dictionary<int, Hashtable> dataPerGroupReliable;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x138")]
	private readonly Dictionary<int, Hashtable> dataPerGroupUnreliable;

	// Token: 0x040010FB RID: 4347
	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x140")]
	protected internal short currentLevelPrefix;

	// Token: 0x040010FC RID: 4348
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x142")]
	protected internal bool loadingLevelAndPausedNetwork;

	// Token: 0x040010FD RID: 4349
	[Token(Token = "0x4000D35")]
	protected internal const string CurrentSceneProperty = "curScn";

	// Token: 0x040010FE RID: 4350
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x8")]
	public static bool UsePrefabCache;

	// Token: 0x040010FF RID: 4351
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x10")]
	public static Dictionary<string, GameObject> PrefabCache;

	// Token: 0x04001100 RID: 4352
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x148")]
	private Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache;

	// Token: 0x04001101 RID: 4353
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x150")]
	private readonly Dictionary<string, int> rpcShortcuts;

	// Token: 0x04001102 RID: 4354
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x158")]
	private IPhotonPeerListener externalListener;

	// Token: 0x04001103 RID: 4355
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x160")]
	private Dictionary<int, object[]> tempInstantiationData;
}
