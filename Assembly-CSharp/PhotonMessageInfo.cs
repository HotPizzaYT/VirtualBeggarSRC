using System;
using Il2CppDummyDll;

// Token: 0x0200047C RID: 1148
[Token(Token = "0x200032F")]
public class PhotonMessageInfo
{
	// Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x77C510", Offset = "0x77C510", VA = "0x77C510")]
	public PhotonMessageInfo()
	{
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x77C718", Offset = "0x77C718", VA = "0x77C718")]
	public PhotonMessageInfo(PhotonPlayer player, int timestamp, PhotonView view)
	{
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00009438 File Offset: 0x00007638
	[Token(Token = "0x17000408")]
	public double timestamp
	{
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x77C758", Offset = "0x77C758", VA = "0x77C758")]
		get
		{
			return 0.0;
		}
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x77C770", Offset = "0x77C770", VA = "0x77C770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x04001104 RID: 4356
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x10")]
	private int timeInt;

	// Token: 0x04001105 RID: 4357
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x18")]
	public PhotonPlayer sender;

	// Token: 0x04001106 RID: 4358
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x20")]
	public PhotonView photonView;
}
