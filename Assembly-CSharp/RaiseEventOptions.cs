using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000480 RID: 1152
[Token(Token = "0x2000333")]
public class RaiseEventOptions
{
	// Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x784D78", Offset = "0x784D78", VA = "0x784D78")]
	public RaiseEventOptions()
	{
	}

	// Token: 0x04001113 RID: 4371
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly RaiseEventOptions Default;

	// Token: 0x04001114 RID: 4372
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x10")]
	public EventCaching CachingOption;

	// Token: 0x04001115 RID: 4373
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x11")]
	public byte InterestGroup;

	// Token: 0x04001116 RID: 4374
	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x18")]
	public int[] TargetActors;

	// Token: 0x04001117 RID: 4375
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x20")]
	public ReceiverGroup Receivers;

	// Token: 0x04001118 RID: 4376
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x21")]
	public byte SequenceChannel;

	// Token: 0x04001119 RID: 4377
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x22")]
	public bool ForwardToWebhook;

	// Token: 0x0400111A RID: 4378
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x24")]
	public int CacheSliceIndex;

	// Token: 0x0400111B RID: 4379
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x28")]
	public bool Encrypt;
}
