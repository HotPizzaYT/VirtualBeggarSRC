using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x0200047D RID: 1149
[Token(Token = "0x2000330")]
public class RoomOptions
{
	// Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001954")]
	[Address(RVA = "0xAA844C", Offset = "0xAA844C", VA = "0xAA844C")]
	public RoomOptions()
	{
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00009450 File Offset: 0x00007650
	// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000409")]
	public bool isVisible
	{
		[Token(Token = "0x6001955")]
		[Address(RVA = "0xAA84F4", Offset = "0xAA84F4", VA = "0xAA84F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001956")]
		[Address(RVA = "0xAAA400", Offset = "0xAAA400", VA = "0xAAA400")]
		set
		{
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00009468 File Offset: 0x00007668
	// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700040A")]
	public bool isOpen
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0xAA84FC", Offset = "0xAA84FC", VA = "0xAA84FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001958")]
		[Address(RVA = "0xAAA40C", Offset = "0xAAA40C", VA = "0xAAA40C")]
		set
		{
		}
	}

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00009480 File Offset: 0x00007680
	// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700040B")]
	public bool cleanupCacheOnLeave
	{
		[Token(Token = "0x6001959")]
		[Address(RVA = "0xAAA418", Offset = "0xAAA418", VA = "0xAAA418")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600195A")]
		[Address(RVA = "0xAAA420", Offset = "0xAAA420", VA = "0xAAA420")]
		set
		{
		}
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00009498 File Offset: 0x00007698
	[Token(Token = "0x1700040C")]
	public bool suppressRoomEvents
	{
		[Token(Token = "0x600195B")]
		[Address(RVA = "0xAAA42C", Offset = "0xAAA42C", VA = "0xAAA42C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04001107 RID: 4359
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x10")]
	private bool isVisibleField;

	// Token: 0x04001108 RID: 4360
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x11")]
	private bool isOpenField;

	// Token: 0x04001109 RID: 4361
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x12")]
	public byte maxPlayers;

	// Token: 0x0400110A RID: 4362
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x13")]
	private bool cleanupCacheOnLeaveField;

	// Token: 0x0400110B RID: 4363
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x18")]
	public Hashtable customRoomProperties;

	// Token: 0x0400110C RID: 4364
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x20")]
	public string[] customRoomPropertiesForLobby;

	// Token: 0x0400110D RID: 4365
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x28")]
	private bool suppressRoomEventsField;
}
