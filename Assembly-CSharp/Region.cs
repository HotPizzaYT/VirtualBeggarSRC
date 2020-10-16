using System;
using Il2CppDummyDll;

// Token: 0x02000497 RID: 1175
[Token(Token = "0x2000348")]
public class Region
{
	// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x795F5C", Offset = "0x795F5C", VA = "0x795F5C")]
	public Region()
	{
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x00009DB0 File Offset: 0x00007FB0
	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x77A77C", Offset = "0x77A77C", VA = "0x77A77C")]
	public static CloudRegionCode Parse(string codeAsString)
	{
		return CloudRegionCode.eu;
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x00009DC8 File Offset: 0x00007FC8
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x795F64", Offset = "0x795F64", VA = "0x795F64")]
	internal static CloudRegionFlag ParseFlag(string codeAsString)
	{
		return (CloudRegionFlag)0;
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x796138", Offset = "0x796138", VA = "0x796138", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x10")]
	public CloudRegionCode Code;

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x18")]
	public string HostAndPort;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x20")]
	public int Ping;
}
