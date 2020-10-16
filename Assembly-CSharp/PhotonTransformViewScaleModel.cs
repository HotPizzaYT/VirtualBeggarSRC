using System;
using Il2CppDummyDll;

// Token: 0x020004B0 RID: 1200
[Token(Token = "0x200035B")]
[Serializable]
public class PhotonTransformViewScaleModel
{
	// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x78BB40", Offset = "0x78BB40", VA = "0x78BB40")]
	public PhotonTransformViewScaleModel()
	{
	}

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x10")]
	public bool SynchronizeEnabled;

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x14")]
	public PhotonTransformViewScaleModel.InterpolateOptions InterpolateOption;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x18")]
	public float InterpolateMoveTowardsSpeed;

	// Token: 0x04001231 RID: 4657
	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x1C")]
	public float InterpolateLerpSpeed;

	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x200035C")]
	public enum InterpolateOptions
	{
		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4000E50")]
		Disabled,
		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4000E51")]
		MoveTowards,
		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4000E52")]
		Lerp
	}
}
