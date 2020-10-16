using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000484 RID: 1156
[Token(Token = "0x2000337")]
public class WebRpcResponse
{
	// Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001979")]
	[Address(RVA = "0xAC7054", Offset = "0xAC7054", VA = "0xAC7054")]
	public WebRpcResponse(OperationResponse response)
	{
	}

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000411")]
	public string Name
	{
		[Token(Token = "0x600197A")]
		[Address(RVA = "0xAC72C4", Offset = "0xAC72C4", VA = "0xAC72C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC61C", Offset = "0x4BC61C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197B")]
		[Address(RVA = "0xAC72A4", Offset = "0xAC72A4", VA = "0xAC72A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC62C", Offset = "0x4BC62C")]
		private set
		{
		}
	}

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00009510 File Offset: 0x00007710
	// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000412")]
	public int ReturnCode
	{
		[Token(Token = "0x600197C")]
		[Address(RVA = "0xAC72CC", Offset = "0xAC72CC", VA = "0xAC72CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC63C", Offset = "0x4BC63C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600197D")]
		[Address(RVA = "0xAC72AC", Offset = "0xAC72AC", VA = "0xAC72AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC64C", Offset = "0x4BC64C")]
		private set
		{
		}
	}

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000413")]
	public string DebugMessage
	{
		[Token(Token = "0x600197E")]
		[Address(RVA = "0xAC72D4", Offset = "0xAC72D4", VA = "0xAC72D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC65C", Offset = "0x4BC65C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197F")]
		[Address(RVA = "0xAC72BC", Offset = "0xAC72BC", VA = "0xAC72BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC66C", Offset = "0x4BC66C")]
		private set
		{
		}
	}

	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000414")]
	public Dictionary<string, object> Parameters
	{
		[Token(Token = "0x6001980")]
		[Address(RVA = "0xAC72DC", Offset = "0xAC72DC", VA = "0xAC72DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC67C", Offset = "0x4BC67C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001981")]
		[Address(RVA = "0xAC72B4", Offset = "0xAC72B4", VA = "0xAC72B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC68C", Offset = "0x4BC68C")]
		private set
		{
		}
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001982")]
	[Address(RVA = "0xAC72E4", Offset = "0xAC72E4", VA = "0xAC72E4")]
	public string ToStringFull()
	{
		return null;
	}

	// Token: 0x0400112B RID: 4395
	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC52C", Offset = "0x4BC52C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC52C", Offset = "0x4BC52C")]
	private string <Name>k__BackingField;

	// Token: 0x0400112C RID: 4396
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC568", Offset = "0x4BC568")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC568", Offset = "0x4BC568")]
	private int <ReturnCode>k__BackingField;

	// Token: 0x0400112D RID: 4397
	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC5A4", Offset = "0x4BC5A4")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC5A4", Offset = "0x4BC5A4")]
	private string <DebugMessage>k__BackingField;

	// Token: 0x0400112E RID: 4398
	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC5E0", Offset = "0x4BC5E0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC5E0", Offset = "0x4BC5E0")]
	private Dictionary<string, object> <Parameters>k__BackingField;
}
