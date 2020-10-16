using System;
using Il2CppDummyDll;

// Token: 0x020004AD RID: 1197
[Token(Token = "0x2000358")]
[Serializable]
public class PhotonTransformViewRotationModel
{
	// Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x78BB24", Offset = "0x78BB24", VA = "0x78BB24")]
	public PhotonTransformViewRotationModel()
	{
	}

	// Token: 0x04001224 RID: 4644
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x10")]
	public bool SynchronizeEnabled;

	// Token: 0x04001225 RID: 4645
	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x14")]
	public PhotonTransformViewRotationModel.InterpolateOptions InterpolateOption;

	// Token: 0x04001226 RID: 4646
	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x18")]
	public float InterpolateRotateTowardsSpeed;

	// Token: 0x04001227 RID: 4647
	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x1C")]
	public float InterpolateLerpSpeed;

	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x2000359")]
	public enum InterpolateOptions
	{
		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4000E46")]
		Disabled,
		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x4000E47")]
		RotateTowards,
		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x4000E48")]
		Lerp
	}
}
