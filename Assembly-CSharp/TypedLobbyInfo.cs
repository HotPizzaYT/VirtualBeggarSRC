using System;
using Il2CppDummyDll;

// Token: 0x0200047F RID: 1151
[Token(Token = "0x2000332")]
public class TypedLobbyInfo : TypedLobby
{
	// Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001961")]
	[Address(RVA = "0xAC65E4", Offset = "0xAC65E4", VA = "0xAC65E4")]
	public TypedLobbyInfo()
	{
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001962")]
	[Address(RVA = "0xAC6648", Offset = "0xAC6648", VA = "0xAC6648", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x04001111 RID: 4369
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x1C")]
	public int PlayerCount;

	// Token: 0x04001112 RID: 4370
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x20")]
	public int RoomCount;
}
