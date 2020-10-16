using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004B8 RID: 1208
[Token(Token = "0x2000363")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD2A8", Offset = "0x4BD2A8")]
public class MoveByKeys : Photon.MonoBehaviour
{
	// Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x75603C", Offset = "0x75603C", VA = "0x75603C")]
	public MoveByKeys()
	{
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x756060", Offset = "0x756060", VA = "0x756060")]
	public void Start()
	{
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x756128", Offset = "0x756128", VA = "0x756128")]
	public void FixedUpdate()
	{
	}

	// Token: 0x04001251 RID: 4689
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x18")]
	public float Speed;

	// Token: 0x04001252 RID: 4690
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x1C")]
	public float JumpForce;

	// Token: 0x04001253 RID: 4691
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x20")]
	public float JumpTimeout;

	// Token: 0x04001254 RID: 4692
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x24")]
	private bool isSprite;

	// Token: 0x04001255 RID: 4693
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x28")]
	private float jumpingTime;

	// Token: 0x04001256 RID: 4694
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody body;

	// Token: 0x04001257 RID: 4695
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D body2d;
}
