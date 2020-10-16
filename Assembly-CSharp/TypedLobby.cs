using System;
using Il2CppDummyDll;

// Token: 0x0200047E RID: 1150
[Token(Token = "0x2000331")]
public class TypedLobby
{
	// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195C")]
	[Address(RVA = "0xAC6390", Offset = "0xAC6390", VA = "0xAC6390")]
	public TypedLobby()
	{
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195D")]
	[Address(RVA = "0xAC6410", Offset = "0xAC6410", VA = "0xAC6410")]
	public TypedLobby(string name, LobbyType type)
	{
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06001EBF RID: 7871 RVA: 0x000094B0 File Offset: 0x000076B0
	[Token(Token = "0x1700040D")]
	public bool IsDefault
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0xAC644C", Offset = "0xAC644C", VA = "0xAC644C")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600195F")]
	[Address(RVA = "0xAC64D4", Offset = "0xAC64D4", VA = "0xAC64D4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400110E RID: 4366
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x0400110F RID: 4367
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x18")]
	public LobbyType Type;

	// Token: 0x04001110 RID: 4368
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x0")]
	public static readonly TypedLobby Default;
}
