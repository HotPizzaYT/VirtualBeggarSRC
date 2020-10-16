using System;
using Il2CppDummyDll;

// Token: 0x02000538 RID: 1336
[Token(Token = "0x20003BC")]
public class IsoInt
{
	// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x68D4BC", Offset = "0x68D4BC", VA = "0x68D4BC")]
	public IsoInt()
	{
	}

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06002370 RID: 9072 RVA: 0x0000A758 File Offset: 0x00008958
	// (set) Token: 0x06002371 RID: 9073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047E")]
	public long Maara
	{
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x68D4C4", Offset = "0x68D4C4", VA = "0x68D4C4")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x68D4CC", Offset = "0x68D4CC", VA = "0x68D4CC")]
		set
		{
		}
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x0000A770 File Offset: 0x00008970
	[Token(Token = "0x6001D0F")]
	[Address(RVA = "0x68D50C", Offset = "0x68D50C", VA = "0x68D50C")]
	public long HaeLuku()
	{
		return 0L;
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x0000A788 File Offset: 0x00008988
	[Token(Token = "0x6001D10")]
	[Address(RVA = "0x68D524", Offset = "0x68D524", VA = "0x68D524")]
	public int HaeAlinLuku()
	{
		return 0;
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x68D52C", Offset = "0x68D52C", VA = "0x68D52C")]
	public void SummaaIsoLuku(IsoInt il)
	{
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x68D5A8", Offset = "0x68D5A8", VA = "0x68D5A8")]
	public void TallennaLuku(string key)
	{
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x68D694", Offset = "0x68D694", VA = "0x68D694")]
	public void LataaLuku(string key)
	{
	}

	// Token: 0x0400159A RID: 5530
	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x10")]
	private long maara;

	// Token: 0x0400159B RID: 5531
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0x18")]
	private int alinMaara;

	// Token: 0x0400159C RID: 5532
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0x1C")]
	private int kertaluku;

	// Token: 0x0400159D RID: 5533
	[Token(Token = "0x40010DD")]
	private const int maxMaara = 1000000000;
}
