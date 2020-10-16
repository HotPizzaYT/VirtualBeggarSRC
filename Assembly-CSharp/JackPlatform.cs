using System;
using Il2CppDummyDll;

// Token: 0x0200050A RID: 1290
[Token(Token = "0x20003A4")]
public class JackPlatform
{
	// Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x74DAA0", Offset = "0x74DAA0", VA = "0x74DAA0")]
	public JackPlatform(int _pituus, float _nopeus = -3f, int _korkeusTaso = 0)
	{
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x0000A3F8 File Offset: 0x000085F8
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x74DAF8", Offset = "0x74DAF8", VA = "0x74DAF8")]
	public float HaeWorldPituus()
	{
		return 0f;
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x0000A410 File Offset: 0x00008610
	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x74DB14", Offset = "0x74DB14", VA = "0x74DB14")]
	public float HaeTodellinenKorkeus()
	{
		return 0f;
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x0000A428 File Offset: 0x00008628
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x74DF00", Offset = "0x74DF00", VA = "0x74DF00")]
	public int HaeTasoero(JackPlatform pl)
	{
		return 0;
	}

	// Token: 0x04001454 RID: 5204
	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0x10")]
	public int pituus;

	// Token: 0x04001455 RID: 5205
	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x14")]
	public float nopeus;

	// Token: 0x04001456 RID: 5206
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x18")]
	public int korkeusTaso;

	// Token: 0x04001457 RID: 5207
	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x1C")]
	public bool pisteOtettu;
}
