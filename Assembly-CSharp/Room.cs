using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000494 RID: 1172
[Token(Token = "0x2000345")]
public class Room : RoomInfo
{
	// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0xAA8274", Offset = "0xAA8274", VA = "0xAA8274")]
	internal Room(string roomName, RoomOptions options)
	{
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00009C48 File Offset: 0x00007E48
	[Token(Token = "0x17000452")]
	public new int playerCount
	{
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0xAA8B48", Offset = "0xAA8B48", VA = "0xAA8B48")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000453")]
	public new string name
	{
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0xAA8BF4", Offset = "0xAA8BF4", VA = "0xAA8BF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0xAA8BFC", Offset = "0xAA8BFC", VA = "0xAA8BFC")]
		internal set
		{
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00009C60 File Offset: 0x00007E60
	// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000454")]
	public new int maxPlayers
	{
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0xAA8C04", Offset = "0xAA8C04", VA = "0xAA8C04")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0xAA8C0C", Offset = "0xAA8C0C", VA = "0xAA8C0C")]
		set
		{
		}
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00009C78 File Offset: 0x00007E78
	// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000455")]
	public new bool open
	{
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0xAA8E98", Offset = "0xAA8E98", VA = "0xAA8E98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0xAA8EA0", Offset = "0xAA8EA0", VA = "0xAA8EA0")]
		set
		{
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00009C90 File Offset: 0x00007E90
	// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000456")]
	public new bool visible
	{
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0xAA9098", Offset = "0xAA9098", VA = "0xAA9098")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0xAA90A0", Offset = "0xAA90A0", VA = "0xAA90A0")]
		set
		{
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000457")]
	public string[] propertiesListedInLobby
	{
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0xAA9298", Offset = "0xAA9298", VA = "0xAA9298")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCB18", Offset = "0x4BCB18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0xAA8B40", Offset = "0xAA8B40", VA = "0xAA8B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCB28", Offset = "0x4BCB28")]
		private set
		{
		}
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00009CA8 File Offset: 0x00007EA8
	[Token(Token = "0x17000458")]
	public bool autoCleanUp
	{
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0xAA92A0", Offset = "0xAA92A0", VA = "0xAA92A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00009CC0 File Offset: 0x00007EC0
	// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000459")]
	protected internal int masterClientId
	{
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0xAA92A8", Offset = "0xAA92A8", VA = "0xAA92A8")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0xAA92B0", Offset = "0xAA92B0", VA = "0xAA92B0")]
		set
		{
		}
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0xAA92B8", Offset = "0xAA92B8", VA = "0xAA92B8")]
	public void SetCustomProperties(Hashtable propertiesToSet)
	{
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0xAA9478", Offset = "0xAA9478", VA = "0xAA9478")]
	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues)
	{
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0xAA95E0", Offset = "0xAA95E0", VA = "0xAA95E0")]
	public void SetPropertiesListedInLobby(string[] propsListedInLobby)
	{
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0xAA96E8", Offset = "0xAA96E8", VA = "0xAA96E8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0xAA99AC", Offset = "0xAA99AC", VA = "0xAA99AC")]
	public new string ToStringFull()
	{
		return null;
	}

	// Token: 0x040011B5 RID: 4533
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCADC", Offset = "0x4BCADC")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BCADC", Offset = "0x4BCADC")]
	private string[] <propertiesListedInLobby>k__BackingField;
}
