using System;
using Il2CppDummyDll;

// Token: 0x020004E9 RID: 1257
[Token(Token = "0x2000391")]
internal class SavedGameMetaData
{
	// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0xAB0460", Offset = "0xAB0460", VA = "0xAB0460")]
	public SavedGameMetaData()
	{
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0xAB04F8", Offset = "0xAB04F8", VA = "0xAB04F8")]
	public void PuraStr(string str)
	{
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x0000A188 File Offset: 0x00008388
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0xAB0650", Offset = "0xAB0650", VA = "0xAB0650")]
	public bool IsInited()
	{
		return default(bool);
	}

	// Token: 0x04001387 RID: 4999
	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x10")]
	public string level;

	// Token: 0x04001388 RID: 5000
	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x18")]
	public string prestigeKerrat;

	// Token: 0x04001389 RID: 5001
	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x20")]
	public string lastModified;

	// Token: 0x0400138A RID: 5002
	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x28")]
	private bool inited;
}
