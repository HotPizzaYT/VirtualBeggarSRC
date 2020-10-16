using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000529 RID: 1321
[Token(Token = "0x20003B5")]
public class SeinaPong : MonoBehaviour
{
	// Token: 0x06002313 RID: 8979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0xAB0E34", Offset = "0xAB0E34", VA = "0xAB0E34")]
	public SeinaPong()
	{
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0xAB0E3C", Offset = "0xAB0E3C", VA = "0xAB0E3C")]
	private void Awake()
	{
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0xAB0EBC", Offset = "0xAB0EBC", VA = "0xAB0EBC")]
	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	// Token: 0x04001541 RID: 5441
	[Token(Token = "0x40010AC")]
	[FieldOffset(Offset = "0x18")]
	public SeinaPong.TormaysTyypit tormaysTyyppi;

	// Token: 0x04001542 RID: 5442
	[Token(Token = "0x40010AD")]
	[FieldOffset(Offset = "0x20")]
	private KuulaPong pong;

	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x20003B6")]
	public enum TormaysTyypit
	{
		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x40010AF")]
		paaty,
		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x40010B0")]
		sivu,
		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x40010B1")]
		pelaaja
	}
}
