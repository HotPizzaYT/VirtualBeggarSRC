using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004C2 RID: 1218
[Token(Token = "0x200036C")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD520", Offset = "0x4BD520")]
public class PickupItemSimple : Photon.MonoBehaviour
{
	// Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x791174", Offset = "0x791174", VA = "0x791174")]
	public PickupItemSimple()
	{
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x791184", Offset = "0x791184", VA = "0x791184")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x791260", Offset = "0x791260", VA = "0x791260")]
	public void Pickup()
	{
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x791318", Offset = "0x791318", VA = "0x791318")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD584", Offset = "0x4BD584")]
	public void PunPickupSimple(PhotonMessageInfo msgInfo)
	{
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x79152C", Offset = "0x79152C", VA = "0x79152C")]
	public void RespawnAfter()
	{
	}

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x18")]
	public float SecondsBeforeRespawn;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x1C")]
	public bool PickupOnCollide;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x1D")]
	public bool SentPickup;
}
