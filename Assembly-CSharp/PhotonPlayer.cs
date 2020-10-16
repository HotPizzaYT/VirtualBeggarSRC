using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x0200048A RID: 1162
[Token(Token = "0x200033C")]
public class PhotonPlayer
{
	// Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x7874E0", Offset = "0x7874E0", VA = "0x7874E0")]
	public PhotonPlayer(bool isLocal, int actorID, string name)
	{
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x7875B0", Offset = "0x7875B0", VA = "0x7875B0")]
	protected internal PhotonPlayer(bool isLocal, int actorID, Hashtable properties)
	{
	}

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00009AF8 File Offset: 0x00007CF8
	[Token(Token = "0x17000442")]
	public int ID
	{
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x77E968", Offset = "0x77E968", VA = "0x77E968")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000443")]
	public string name
	{
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x787684", Offset = "0x787684", VA = "0x787684")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x78768C", Offset = "0x78768C", VA = "0x78768C")]
		set
		{
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00009B10 File Offset: 0x00007D10
	[Token(Token = "0x17000444")]
	public bool isMasterClient
	{
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x784CE8", Offset = "0x784CE8", VA = "0x784CE8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000445")]
	public Hashtable customProperties
	{
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x7828AC", Offset = "0x7828AC", VA = "0x7828AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC9A4", Offset = "0x4BC9A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x782E60", Offset = "0x782E60", VA = "0x782E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC9B4", Offset = "0x4BC9B4")]
		internal set
		{
		}
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000446")]
	public Hashtable allProperties
	{
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x7877BC", Offset = "0x7877BC", VA = "0x7877BC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x00009B28 File Offset: 0x00007D28
	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x787884", Offset = "0x787884", VA = "0x787884", Slot = "0")]
	public override bool Equals(object p)
	{
		return default(bool);
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x00009B40 File Offset: 0x00007D40
	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x78793C", Offset = "0x78793C", VA = "0x78793C", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x787944", Offset = "0x787944", VA = "0x787944")]
	internal void InternalChangeLocalID(int newID)
	{
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x782AC8", Offset = "0x782AC8", VA = "0x782AC8")]
	internal void InternalCacheProperties(Hashtable properties)
	{
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x7828B4", Offset = "0x7828B4", VA = "0x7828B4")]
	public void SetCustomProperties(Hashtable propertiesToSet)
	{
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x7879E0", Offset = "0x7879E0", VA = "0x7879E0")]
	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues)
	{
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x787B58", Offset = "0x787B58", VA = "0x787B58")]
	public static PhotonPlayer Find(int ID)
	{
		return null;
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x787C14", Offset = "0x787C14", VA = "0x787C14")]
	public PhotonPlayer Get(int id)
	{
		return null;
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x787C18", Offset = "0x787C18", VA = "0x787C18")]
	public PhotonPlayer GetNext()
	{
		return null;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x787EA0", Offset = "0x787EA0", VA = "0x787EA0")]
	public PhotonPlayer GetNextFor(PhotonPlayer currentPlayer)
	{
		return null;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x787C20", Offset = "0x787C20", VA = "0x787C20")]
	public PhotonPlayer GetNextFor(int currentPlayerId)
	{
		return null;
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x787EB4", Offset = "0x787EB4", VA = "0x787EB4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x788090", Offset = "0x788090", VA = "0x788090")]
	public string ToStringFull()
	{
		return null;
	}

	// Token: 0x04001164 RID: 4452
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x10")]
	private int actorID;

	// Token: 0x04001165 RID: 4453
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x18")]
	private string nameField;

	// Token: 0x04001166 RID: 4454
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0x20")]
	public readonly bool isLocal;

	// Token: 0x04001167 RID: 4455
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC968", Offset = "0x4BC968")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC968", Offset = "0x4BC968")]
	private Hashtable <customProperties>k__BackingField;

	// Token: 0x04001168 RID: 4456
	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0x30")]
	public object TagObject;
}
