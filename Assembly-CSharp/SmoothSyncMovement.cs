using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004CE RID: 1230
[Token(Token = "0x2000378")]
public class SmoothSyncMovement : Photon.MonoBehaviour
{
	// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B39")]
	[Address(RVA = "0xABD35C", Offset = "0xABD35C", VA = "0xABD35C")]
	public SmoothSyncMovement()
	{
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0xABD414", Offset = "0xABD414", VA = "0xABD414")]
	public void Awake()
	{
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0xABD57C", Offset = "0xABD57C", VA = "0xABD57C")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0xABD7E4", Offset = "0xABD7E4", VA = "0xABD7E4")]
	public void Update()
	{
	}

	// Token: 0x04001282 RID: 4738
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x18")]
	public float SmoothingDelay;

	// Token: 0x04001283 RID: 4739
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 correctPlayerPos;

	// Token: 0x04001284 RID: 4740
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion correctPlayerRot;
}
