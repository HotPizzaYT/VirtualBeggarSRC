using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004C1 RID: 1217
[Token(Token = "0x200036B")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD48C", Offset = "0x4BD48C")]
public class PickupItem : Photon.MonoBehaviour, IPunObservable
{
	// Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x7902B4", Offset = "0x7902B4", VA = "0x7902B4")]
	public PickupItem()
	{
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x0600208A RID: 8330 RVA: 0x00009F90 File Offset: 0x00008190
	[Token(Token = "0x17000465")]
	public int ViewID
	{
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x7902C4", Offset = "0x7902C4", VA = "0x7902C4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x7902F8", Offset = "0x7902F8", VA = "0x7902F8")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x79048C", Offset = "0x79048C", VA = "0x79048C", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x7903D4", Offset = "0x7903D4", VA = "0x7903D4")]
	public void Pickup()
	{
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B0F")]
	[Address(RVA = "0x790678", Offset = "0x790678", VA = "0x790678")]
	public void Drop()
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B10")]
	[Address(RVA = "0x790728", Offset = "0x790728", VA = "0x790728")]
	public void Drop(Vector3 newPosition)
	{
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B11")]
	[Address(RVA = "0x79086C", Offset = "0x79086C", VA = "0x79086C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD4F0", Offset = "0x4BD4F0")]
	public void PunPickup(PhotonMessageInfo msgInfo)
	{
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B12")]
	[Address(RVA = "0x790DD4", Offset = "0x790DD4", VA = "0x790DD4")]
	internal void PickedUp(float timeUntilRespawn)
	{
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B13")]
	[Address(RVA = "0x790F00", Offset = "0x790F00", VA = "0x790F00")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD500", Offset = "0x4BD500")]
	internal void PunRespawn(Vector3 pos)
	{
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B14")]
	[Address(RVA = "0x790FE8", Offset = "0x790FE8", VA = "0x790FE8")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD510", Offset = "0x4BD510")]
	internal void PunRespawn()
	{
	}

	// Token: 0x04001269 RID: 4713
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x18")]
	public float SecondsBeforeRespawn;

	// Token: 0x0400126A RID: 4714
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x1C")]
	public bool PickupOnTrigger;

	// Token: 0x0400126B RID: 4715
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x1D")]
	public bool PickupIsMine;

	// Token: 0x0400126C RID: 4716
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x20")]
	public UnityEngine.MonoBehaviour OnPickedUpCall;

	// Token: 0x0400126D RID: 4717
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x28")]
	public bool SentPickup;

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x30")]
	public double TimeOfRespawn;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x0")]
	public static HashSet<PickupItem> DisabledPickupItems;
}
