using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000488 RID: 1160
[Token(Token = "0x200033A")]
public static class PhotonNetwork
{
	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06001F06 RID: 7942 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000417")]
	public static string gameVersion
	{
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x77CCAC", Offset = "0x77CCAC", VA = "0x77CCAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC828", Offset = "0x4BC828")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x77CD14", Offset = "0x77CD14", VA = "0x77CD14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC838", Offset = "0x4BC838")]
		set
		{
		}
	}

	// Token: 0x17000518 RID: 1304
	// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000418")]
	public static string ServerAddress
	{
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x77CD80", Offset = "0x77CD80", VA = "0x77CD80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00009570 File Offset: 0x00007770
	[Token(Token = "0x17000419")]
	public static bool connected
	{
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x77CE3C", Offset = "0x77CE3C", VA = "0x77CE3C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001F0A RID: 7946 RVA: 0x00009588 File Offset: 0x00007788
	[Token(Token = "0x1700041A")]
	public static bool connecting
	{
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x77D020", Offset = "0x77D020", VA = "0x77D020")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700051B RID: 1307
	// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000095A0 File Offset: 0x000077A0
	[Token(Token = "0x1700041B")]
	public static bool connectedAndReady
	{
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x77D0C8", Offset = "0x77D0C8", VA = "0x77D0C8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700051C RID: 1308
	// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000095B8 File Offset: 0x000077B8
	[Token(Token = "0x1700041C")]
	public static ConnectionState connectionState
	{
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x77D1D8", Offset = "0x77D1D8", VA = "0x77D1D8")]
		get
		{
			return ConnectionState.Disconnected;
		}
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000095D0 File Offset: 0x000077D0
	[Token(Token = "0x1700041D")]
	public static PeerState connectionStateDetailed
	{
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x779FC8", Offset = "0x779FC8", VA = "0x779FC8")]
		get
		{
			return PeerState.Uninitialized;
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000095E8 File Offset: 0x000077E8
	[Token(Token = "0x1700041E")]
	public static ServerConnection Server
	{
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x77B88C", Offset = "0x77B88C", VA = "0x77B88C")]
		get
		{
			return ServerConnection.MasterServer;
		}
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700041F")]
	public static AuthenticationValues AuthValues
	{
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x77D310", Offset = "0x77D310", VA = "0x77D310")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x77D3C4", Offset = "0x77D3C4", VA = "0x77D3C4")]
		set
		{
		}
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000420")]
	public static Room room
	{
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x77D47C", Offset = "0x77D47C", VA = "0x77D47C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06001F12 RID: 7954 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000421")]
	public static PhotonPlayer player
	{
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x77C5A0", Offset = "0x77C5A0", VA = "0x77C5A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000422")]
	public static PhotonPlayer masterClient
	{
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x77D554", Offset = "0x77D554", VA = "0x77D554")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000423")]
	public static string playerName
	{
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x77D68C", Offset = "0x77D68C", VA = "0x77D68C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x77D708", Offset = "0x77D708", VA = "0x77D708")]
		set
		{
		}
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000424")]
	public static PhotonPlayer[] playerList
	{
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x77D78C", Offset = "0x77D78C", VA = "0x77D78C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000425")]
	public static PhotonPlayer[] otherPlayers
	{
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x77D84C", Offset = "0x77D84C", VA = "0x77D84C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000426")]
	public static List<FriendInfo> Friends
	{
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x77D90C", Offset = "0x77D90C", VA = "0x77D90C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC848", Offset = "0x4BC848")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x77D974", Offset = "0x77D974", VA = "0x77D974")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC858", Offset = "0x4BC858")]
		internal set
		{
		}
	}

	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00009600 File Offset: 0x00007800
	[Token(Token = "0x17000427")]
	public static int FriendsListAge
	{
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x77D9E0", Offset = "0x77D9E0", VA = "0x77D9E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00009618 File Offset: 0x00007818
	// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000428")]
	public static bool offlineMode
	{
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x77A0E0", Offset = "0x77A0E0", VA = "0x77A0E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x77DA94", Offset = "0x77DA94", VA = "0x77DA94")]
		set
		{
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00009630 File Offset: 0x00007830
	// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000429")]
	public static bool automaticallySyncScene
	{
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x77DD3C", Offset = "0x77DD3C", VA = "0x77DD3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x77DDA4", Offset = "0x77DDA4", VA = "0x77DDA4")]
		set
		{
		}
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00009648 File Offset: 0x00007848
	// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042A")]
	public static bool autoCleanUpPlayerObjects
	{
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x77DE84", Offset = "0x77DE84", VA = "0x77DE84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x77DEEC", Offset = "0x77DEEC", VA = "0x77DEEC")]
		set
		{
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00009660 File Offset: 0x00007860
	// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042B")]
	public static bool autoJoinLobby
	{
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x77DFBC", Offset = "0x77DFBC", VA = "0x77DFBC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x77E034", Offset = "0x77E034", VA = "0x77E034")]
		set
		{
		}
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00009678 File Offset: 0x00007878
	// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042C")]
	public static bool EnableLobbyStatistics
	{
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x77E0B4", Offset = "0x77E0B4", VA = "0x77E0B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x77E12C", Offset = "0x77E12C", VA = "0x77E12C")]
		set
		{
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042D")]
	public static List<TypedLobbyInfo> LobbyStatistics
	{
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x77E1AC", Offset = "0x77E1AC", VA = "0x77E1AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x77E224", Offset = "0x77E224", VA = "0x77E224")]
		private set
		{
		}
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00009690 File Offset: 0x00007890
	[Token(Token = "0x1700042E")]
	public static bool insideLobby
	{
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x77E2A0", Offset = "0x77E2A0", VA = "0x77E2A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700042F")]
	public static TypedLobby lobby
	{
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x77E318", Offset = "0x77E318", VA = "0x77E318")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x77E394", Offset = "0x77E394", VA = "0x77E394")]
		set
		{
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06001F2A RID: 7978 RVA: 0x000096A8 File Offset: 0x000078A8
	// (set) Token: 0x06001F2B RID: 7979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000430")]
	public static int sendRate
	{
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x7797CC", Offset = "0x7797CC", VA = "0x7797CC")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x77E418", Offset = "0x77E418", VA = "0x77E418")]
		set
		{
		}
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000096C0 File Offset: 0x000078C0
	// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000431")]
	public static int sendRateOnSerialize
	{
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x77983C", Offset = "0x77983C", VA = "0x77983C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x77E560", Offset = "0x77E560", VA = "0x77E560")]
		set
		{
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06001F2E RID: 7982 RVA: 0x000096D8 File Offset: 0x000078D8
	// (set) Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000432")]
	public static bool isMessageQueueRunning
	{
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x77A148", Offset = "0x77A148", VA = "0x77A148")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x77E6CC", Offset = "0x77E6CC", VA = "0x77E6CC")]
		set
		{
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000096F0 File Offset: 0x000078F0
	// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000433")]
	public static int unreliableCommandsLimit
	{
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x77E798", Offset = "0x77E798", VA = "0x77E798")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x77E814", Offset = "0x77E814", VA = "0x77E814")]
		set
		{
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00009708 File Offset: 0x00007908
	[Token(Token = "0x17000434")]
	public static double time
	{
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x77C654", Offset = "0x77C654", VA = "0x77C654")]
		get
		{
			return 0.0;
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00009720 File Offset: 0x00007920
	[Token(Token = "0x17000435")]
	public static bool isMasterClient
	{
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x77E898", Offset = "0x77E898", VA = "0x77E898")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00009738 File Offset: 0x00007938
	[Token(Token = "0x17000436")]
	public static bool inRoom
	{
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x77E970", Offset = "0x77E970", VA = "0x77E970")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00009750 File Offset: 0x00007950
	[Token(Token = "0x17000437")]
	public static bool isNonMasterClientInRoom
	{
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x77E9D8", Offset = "0x77E9D8", VA = "0x77E9D8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00009768 File Offset: 0x00007968
	[Token(Token = "0x17000438")]
	public static int countOfPlayersOnMaster
	{
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x77EA6C", Offset = "0x77EA6C", VA = "0x77EA6C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00009780 File Offset: 0x00007980
	[Token(Token = "0x17000439")]
	public static int countOfPlayersInRooms
	{
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x77EAE8", Offset = "0x77EAE8", VA = "0x77EAE8")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00009798 File Offset: 0x00007998
	[Token(Token = "0x1700043A")]
	public static int countOfPlayers
	{
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x77EB64", Offset = "0x77EB64", VA = "0x77EB64")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000097B0 File Offset: 0x000079B0
	[Token(Token = "0x1700043B")]
	public static int countOfRooms
	{
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x77EC10", Offset = "0x77EC10", VA = "0x77EC10")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000097C8 File Offset: 0x000079C8
	// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043C")]
	public static bool NetworkStatisticsEnabled
	{
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x77EC8C", Offset = "0x77EC8C", VA = "0x77EC8C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x77ED08", Offset = "0x77ED08", VA = "0x77ED08")]
		set
		{
		}
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06001F3C RID: 7996 RVA: 0x000097E0 File Offset: 0x000079E0
	[Token(Token = "0x1700043D")]
	public static int ResentReliableCommands
	{
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x77ED8C", Offset = "0x77ED8C", VA = "0x77ED8C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000097F8 File Offset: 0x000079F8
	// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043E")]
	public static bool CrcCheckEnabled
	{
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x77EE08", Offset = "0x77EE08", VA = "0x77EE08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x77EE84", Offset = "0x77EE84", VA = "0x77EE84")]
		set
		{
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00009810 File Offset: 0x00007A10
	[Token(Token = "0x1700043F")]
	public static int PacketLossByCrcCheck
	{
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x77F040", Offset = "0x77F040", VA = "0x77F040")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00009828 File Offset: 0x00007A28
	// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000440")]
	public static int MaxResendsBeforeDisconnect
	{
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x77F0BC", Offset = "0x77F0BC", VA = "0x77F0BC")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0x77F138", Offset = "0x77F138", VA = "0x77F138")]
		set
		{
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00009840 File Offset: 0x00007A40
	// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000441")]
	public static int QuickResends
	{
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x77F1D4", Offset = "0x77F1D4", VA = "0x77F1D4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x77F258", Offset = "0x77F258", VA = "0x77F258")]
		set
		{
		}
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x77F2F0", Offset = "0x77F2F0", VA = "0x77F2F0")]
	public static void SwitchToProtocol(ConnectionProtocol cp)
	{
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x00009858 File Offset: 0x00007A58
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x77F858", Offset = "0x77F858", VA = "0x77F858")]
	public static bool ConnectUsingSettings(string gameVersion)
	{
		return default(bool);
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x00009870 File Offset: 0x00007A70
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x780384", Offset = "0x780384", VA = "0x780384")]
	public static bool ConnectToMaster(string masterServerAddress, int port, string appID, string gameVersion)
	{
		return default(bool);
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x00009888 File Offset: 0x00007A88
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x77FF30", Offset = "0x77FF30", VA = "0x77FF30")]
	public static bool ConnectToBestCloudServer(string gameVersion)
	{
		return default(bool);
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000098A0 File Offset: 0x00007AA0
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x7807A8", Offset = "0x7807A8", VA = "0x7807A8")]
	public static bool ConnectToRegion(CloudRegionCode region, string gameVersion)
	{
		return default(bool);
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x780B9C", Offset = "0x780B9C", VA = "0x780B9C")]
	public static void OverrideBestCloudServer(CloudRegionCode region)
	{
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x780C00", Offset = "0x780C00", VA = "0x780C00")]
	public static void RefreshCloudServerRating()
	{
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x780C74", Offset = "0x780C74", VA = "0x780C74")]
	public static void NetworkStatisticsReset()
	{
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x780CF0", Offset = "0x780CF0", VA = "0x780CF0")]
	public static string NetworkStatisticsToString()
	{
		return null;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x780DD0", Offset = "0x780DD0", VA = "0x780DD0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BC868", Offset = "0x4BC868")]
	public static void InitializeSecurity()
	{
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000098B8 File Offset: 0x00007AB8
	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x780DD4", Offset = "0x780DD4", VA = "0x780DD4")]
	private static bool VerifyCanUseNetwork()
	{
		return default(bool);
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x779B08", Offset = "0x779B08", VA = "0x779B08")]
	public static void Disconnect()
	{
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000098D0 File Offset: 0x00007AD0
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x780E80", Offset = "0x780E80", VA = "0x780E80")]
	public static bool FindFriends(string[] friendsToFind)
	{
		return default(bool);
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000098E8 File Offset: 0x00007AE8
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x780F64", Offset = "0x780F64", VA = "0x780F64")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BC8A0", Offset = "0x4BC8A0")]
	public static bool CreateRoom(string roomName, bool isVisible, bool isOpen, int maxPlayers)
	{
		return default(bool);
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x00009900 File Offset: 0x00007B00
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x781278", Offset = "0x781278", VA = "0x781278")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BC8D8", Offset = "0x4BC8D8")]
	public static bool CreateRoom(string roomName, bool isVisible, bool isOpen, int maxPlayers, Hashtable customRoomProperties, string[] propsToListInLobby)
	{
		return default(bool);
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x00009918 File Offset: 0x00007B18
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x7813B4", Offset = "0x7813B4", VA = "0x7813B4")]
	public static bool CreateRoom(string roomName)
	{
		return default(bool);
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x00009930 File Offset: 0x00007B30
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x78106C", Offset = "0x78106C", VA = "0x78106C")]
	public static bool CreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return default(bool);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x00009948 File Offset: 0x00007B48
	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x7815C8", Offset = "0x7815C8", VA = "0x7815C8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BC910", Offset = "0x4BC910")]
	public static bool JoinRoom(string roomName, bool createIfNotExists)
	{
		return default(bool);
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x00009960 File Offset: 0x00007B60
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x781830", Offset = "0x781830", VA = "0x781830")]
	public static bool JoinRoom(string roomName)
	{
		return default(bool);
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x00009978 File Offset: 0x00007B78
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x781A8C", Offset = "0x781A8C", VA = "0x781A8C")]
	public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby)
	{
		return default(bool);
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x00009990 File Offset: 0x00007B90
	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x781CFC", Offset = "0x781CFC", VA = "0x781CFC")]
	public static bool JoinRandomRoom()
	{
		return default(bool);
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000099A8 File Offset: 0x00007BA8
	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x781FA8", Offset = "0x781FA8", VA = "0x781FA8")]
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers)
	{
		return default(bool);
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000099C0 File Offset: 0x00007BC0
	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x781D6C", Offset = "0x781D6C", VA = "0x781D6C")]
	public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter)
	{
		return default(bool);
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x781420", Offset = "0x781420", VA = "0x781420")]
	private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom)
	{
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000099D8 File Offset: 0x00007BD8
	[Token(Token = "0x60019F5")]
	[Address(RVA = "0x782028", Offset = "0x782028", VA = "0x782028")]
	public static bool JoinLobby()
	{
		return default(bool);
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000099F0 File Offset: 0x00007BF0
	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x782088", Offset = "0x782088", VA = "0x782088")]
	public static bool JoinLobby(TypedLobby typedLobby)
	{
		return default(bool);
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x00009A08 File Offset: 0x00007C08
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x7821E0", Offset = "0x7821E0", VA = "0x7821E0")]
	public static bool LeaveLobby()
	{
		return default(bool);
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x00009A20 File Offset: 0x00007C20
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x7822B4", Offset = "0x7822B4", VA = "0x7822B4")]
	public static bool LeaveRoom()
	{
		return default(bool);
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x7824D4", Offset = "0x7824D4", VA = "0x7824D4")]
	public static RoomInfo[] GetRoomList()
	{
		return null;
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x7825B8", Offset = "0x7825B8", VA = "0x7825B8")]
	public static void SetPlayerCustomProperties(Hashtable customProperties)
	{
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x782C74", Offset = "0x782C74", VA = "0x782C74")]
	public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete)
	{
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x00009A38 File Offset: 0x00007C38
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x782E68", Offset = "0x782E68", VA = "0x782E68")]
	public static bool RaiseEvent(byte eventCode, object eventContent, bool sendReliable, RaiseEventOptions options)
	{
		return default(bool);
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x00009A50 File Offset: 0x00007C50
	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x782F9C", Offset = "0x782F9C", VA = "0x782F9C")]
	public static int AllocateViewID()
	{
		return 0;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x00009A68 File Offset: 0x00007C68
	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x783448", Offset = "0x783448", VA = "0x783448")]
	public static int AllocateSceneViewID()
	{
		return 0;
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x00009A80 File Offset: 0x00007C80
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x78304C", Offset = "0x78304C", VA = "0x78304C")]
	private static int AllocateViewID(int ownerId)
	{
		return 0;
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x783548", Offset = "0x783548", VA = "0x783548")]
	private static int[] AllocateSceneViewIDs(int countOfNewViews)
	{
		return null;
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x783638", Offset = "0x783638", VA = "0x783638")]
	public static void UnAllocateViewID(int viewID)
	{
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x783814", Offset = "0x783814", VA = "0x783814")]
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, int group)
	{
		return null;
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x7838E4", Offset = "0x7838E4", VA = "0x7838E4")]
	public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, int group, object[] data)
	{
		return null;
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x784078", Offset = "0x784078", VA = "0x784078")]
	public static GameObject InstantiateSceneObject(string prefabName, Vector3 position, Quaternion rotation, int group, object[] data)
	{
		return null;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x00009A98 File Offset: 0x00007C98
	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x78491C", Offset = "0x78491C", VA = "0x78491C")]
	public static int GetPing()
	{
		return 0;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x784998", Offset = "0x784998", VA = "0x784998")]
	public static void FetchServerTimestamp()
	{
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x784A48", Offset = "0x784A48", VA = "0x784A48")]
	public static void SendOutgoingCommands()
	{
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x784AF4", Offset = "0x784AF4", VA = "0x784AF4")]
	public static bool CloseConnection(PhotonPlayer kickPlayer)
	{
		return default(bool);
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x00009AC8 File Offset: 0x00007CC8
	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x784D80", Offset = "0x784D80", VA = "0x784D80")]
	public static bool SetMasterClient(PhotonPlayer masterClientPlayer)
	{
		return default(bool);
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x7850E8", Offset = "0x7850E8", VA = "0x7850E8")]
	public static void Destroy(PhotonView targetView)
	{
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x78521C", Offset = "0x78521C", VA = "0x78521C")]
	public static void Destroy(GameObject targetGo)
	{
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x7852B8", Offset = "0x7852B8", VA = "0x7852B8")]
	public static void DestroyPlayerObjects(PhotonPlayer targetPlayer)
	{
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x785384", Offset = "0x785384", VA = "0x785384")]
	public static void DestroyPlayerObjects(int targetPlayerId)
	{
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x78557C", Offset = "0x78557C", VA = "0x78557C")]
	public static void DestroyAll()
	{
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x78565C", Offset = "0x78565C", VA = "0x78565C")]
	public static void RemoveRPCs(PhotonPlayer targetPlayer)
	{
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x785794", Offset = "0x785794", VA = "0x785794")]
	public static void RemoveRPCs(PhotonView targetPhotonView)
	{
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x785844", Offset = "0x785844", VA = "0x785844")]
	public static void RemoveRPCsInGroup(int targetGroup)
	{
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x7858F4", Offset = "0x7858F4", VA = "0x7858F4")]
	internal static void RPC(PhotonView view, string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x785B94", Offset = "0x785B94", VA = "0x785B94")]
	internal static void RPC(PhotonView view, string methodName, PhotonPlayer targetPlayer, bool encrpyt, params object[] parameters)
	{
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x785E3C", Offset = "0x785E3C", VA = "0x785E3C")]
	public static void CacheSendMonoMessageTargets(Type type)
	{
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x785ED4", Offset = "0x785ED4", VA = "0x785ED4")]
	public static HashSet<GameObject> FindGameObjectsWithComponent(Type type)
	{
		return null;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x786084", Offset = "0x786084", VA = "0x786084")]
	public static void SetReceivingEnabled(int group, bool enabled)
	{
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x786148", Offset = "0x786148", VA = "0x786148")]
	public static void SetReceivingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x78620C", Offset = "0x78620C", VA = "0x78620C")]
	public static void SetSendingEnabled(int group, bool enabled)
	{
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x7862D0", Offset = "0x7862D0", VA = "0x7862D0")]
	public static void SetSendingEnabled(int[] enableGroups, int[] disableGroups)
	{
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x786394", Offset = "0x786394", VA = "0x786394")]
	public static void SetLevelPrefix(short prefix)
	{
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x786444", Offset = "0x786444", VA = "0x786444")]
	public static void LoadLevel(int levelNumber)
	{
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x786530", Offset = "0x786530", VA = "0x786530")]
	public static void LoadLevel(string levelName)
	{
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x00009AE0 File Offset: 0x00007CE0
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x7865F4", Offset = "0x7865F4", VA = "0x7865F4")]
	public static bool WebRpc(string name, object parameters)
	{
		return default(bool);
	}

	// Token: 0x04001145 RID: 4421
	[Token(Token = "0x4000D76")]
	public const string versionPUN = "1.60";

	// Token: 0x04001146 RID: 4422
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC778", Offset = "0x4BC778")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC778", Offset = "0x4BC778")]
	private static string <gameVersion>k__BackingField;

	// Token: 0x04001147 RID: 4423
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly PhotonHandler photonMono;

	// Token: 0x04001148 RID: 4424
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x10")]
	internal static NetworkingPeer networkingPeer;

	// Token: 0x04001149 RID: 4425
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int MAX_VIEW_IDS;

	// Token: 0x0400114A RID: 4426
	[Token(Token = "0x4000D7B")]
	internal const string serverSettingsAssetFile = "PhotonServerSettings";

	// Token: 0x0400114B RID: 4427
	[Token(Token = "0x4000D7C")]
	internal const string serverSettingsAssetPath = "Assets/Photon Unity Networking/Resources/PhotonServerSettings.asset";

	// Token: 0x0400114C RID: 4428
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x20")]
	public static ServerSettings PhotonServerSettings;

	// Token: 0x0400114D RID: 4429
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x28")]
	public static bool InstantiateInRoomOnly;

	// Token: 0x0400114E RID: 4430
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x2C")]
	public static PhotonLogLevel logLevel;

	// Token: 0x0400114F RID: 4431
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC7B4", Offset = "0x4BC7B4")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC7B4", Offset = "0x4BC7B4")]
	private static List<FriendInfo> <Friends>k__BackingField;

	// Token: 0x04001150 RID: 4432
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x38")]
	public static float precisionForVectorSynchronization;

	// Token: 0x04001151 RID: 4433
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x3C")]
	public static float precisionForQuaternionSynchronization;

	// Token: 0x04001152 RID: 4434
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x40")]
	public static float precisionForFloatSynchronization;

	// Token: 0x04001153 RID: 4435
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x44")]
	public static bool UseRpcMonoBehaviourCache;

	// Token: 0x04001154 RID: 4436
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x45")]
	public static bool UsePrefabCache;

	// Token: 0x04001155 RID: 4437
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x48")]
	public static Dictionary<string, GameObject> PrefabCache;

	// Token: 0x04001156 RID: 4438
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x50")]
	public static HashSet<GameObject> SendMonoMessageTargets;

	// Token: 0x04001157 RID: 4439
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x58")]
	public static Type SendMonoMessageTargetType;

	// Token: 0x04001158 RID: 4440
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x60")]
	private static bool isOfflineMode;

	// Token: 0x04001159 RID: 4441
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x68")]
	private static Room offlineModeRoom;

	// Token: 0x0400115A RID: 4442
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BC7F0", Offset = "0x4BC7F0")]
	public static int maxConnections;

	// Token: 0x0400115B RID: 4443
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x74")]
	private static bool _mAutomaticallySyncScene;

	// Token: 0x0400115C RID: 4444
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x75")]
	private static bool m_autoCleanUpPlayerObjects;

	// Token: 0x0400115D RID: 4445
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x78")]
	private static int sendInterval;

	// Token: 0x0400115E RID: 4446
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x7C")]
	private static int sendIntervalOnSerialize;

	// Token: 0x0400115F RID: 4447
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x80")]
	private static bool m_isMessageQueueRunning;

	// Token: 0x04001160 RID: 4448
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x88")]
	public static PhotonNetwork.EventCallback OnEventCall;

	// Token: 0x04001161 RID: 4449
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x90")]
	internal static int lastUsedViewSubId;

	// Token: 0x04001162 RID: 4450
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x94")]
	internal static int lastUsedViewSubIdStatic;

	// Token: 0x04001163 RID: 4451
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x98")]
	internal static List<int> manuallyAllocatedViewIds;

	// Token: 0x02000489 RID: 1161
	// (Invoke) Token: 0x06001F86 RID: 8070
	[Token(Token = "0x200033B")]
	public delegate void EventCallback(byte eventCode, object content, int senderId);
}
