using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
[Token(Token = "0x2000354")]
[Serializable]
public class PhotonTransformViewPositionModel
{
	// Token: 0x06002043 RID: 8259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x78B8EC", Offset = "0x78B8EC", VA = "0x78B8EC")]
	public PhotonTransformViewPositionModel()
	{
	}

	// Token: 0x04001209 RID: 4617
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x10")]
	public bool SynchronizeEnabled;

	// Token: 0x0400120A RID: 4618
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x11")]
	public bool TeleportEnabled;

	// Token: 0x0400120B RID: 4619
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x14")]
	public float TeleportIfDistanceGreaterThan;

	// Token: 0x0400120C RID: 4620
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x18")]
	public PhotonTransformViewPositionModel.InterpolateOptions InterpolateOption;

	// Token: 0x0400120D RID: 4621
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x1C")]
	public float InterpolateMoveTowardsSpeed;

	// Token: 0x0400120E RID: 4622
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x20")]
	public float InterpolateLerpSpeed;

	// Token: 0x0400120F RID: 4623
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x24")]
	public float InterpolateMoveTowardsAcceleration;

	// Token: 0x04001210 RID: 4624
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x28")]
	public float InterpolateMoveTowardsDeceleration;

	// Token: 0x04001211 RID: 4625
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve InterpolateSpeedCurve;

	// Token: 0x04001212 RID: 4626
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x38")]
	public PhotonTransformViewPositionModel.ExtrapolateOptions ExtrapolateOption;

	// Token: 0x04001213 RID: 4627
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x3C")]
	public float ExtrapolateSpeed;

	// Token: 0x04001214 RID: 4628
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x40")]
	public bool ExtrapolateIncludingRoundTripTime;

	// Token: 0x04001215 RID: 4629
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x44")]
	public int ExtrapolateNumberOfStoredPositions;

	// Token: 0x04001216 RID: 4630
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x48")]
	public bool DrawErrorGizmo;

	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x2000355")]
	public enum InterpolateOptions
	{
		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4000E35")]
		Disabled,
		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4000E36")]
		FixedSpeed,
		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x4000E37")]
		EstimatedSpeed,
		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x4000E38")]
		SynchronizeValues,
		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x4000E39")]
		Lerp
	}

	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x2000356")]
	public enum ExtrapolateOptions
	{
		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x4000E3B")]
		Disabled,
		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x4000E3C")]
		SynchronizeValues,
		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4000E3D")]
		EstimateSpeedAndTurn,
		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4000E3E")]
		FixedSpeed
	}
}
