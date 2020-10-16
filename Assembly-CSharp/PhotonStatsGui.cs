using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200048B RID: 1163
[Token(Token = "0x200033D")]
public class PhotonStatsGui : MonoBehaviour
{
	// Token: 0x06001F9F RID: 8095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x7888BC", Offset = "0x7888BC", VA = "0x7888BC")]
	public PhotonStatsGui()
	{
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x78892C", Offset = "0x78892C", VA = "0x78892C")]
	public void Start()
	{
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x788974", Offset = "0x788974", VA = "0x788974")]
	public void Update()
	{
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x788A28", Offset = "0x788A28", VA = "0x788A28")]
	public void OnGUI()
	{
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x788BC0", Offset = "0x788BC0", VA = "0x788BC0")]
	public void TrafficStatsWindow(int windowID)
	{
	}

	// Token: 0x04001169 RID: 4457
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x18")]
	public bool statsWindowOn;

	// Token: 0x0400116A RID: 4458
	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x19")]
	public bool statsOn;

	// Token: 0x0400116B RID: 4459
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x1A")]
	public bool healthStatsVisible;

	// Token: 0x0400116C RID: 4460
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x1B")]
	public bool trafficStatsOn;

	// Token: 0x0400116D RID: 4461
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x1C")]
	public bool buttonsOn;

	// Token: 0x0400116E RID: 4462
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x20")]
	public Rect statsRect;

	// Token: 0x0400116F RID: 4463
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x30")]
	public int WindowId;
}
