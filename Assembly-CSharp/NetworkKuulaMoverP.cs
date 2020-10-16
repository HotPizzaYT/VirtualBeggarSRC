using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x0200051D RID: 1309
[Token(Token = "0x20003AF")]
public class NetworkKuulaMoverP : Photon.MonoBehaviour
{
	// Token: 0x0600229B RID: 8859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x76EBA4", Offset = "0x76EBA4", VA = "0x76EBA4")]
	public NetworkKuulaMoverP()
	{
	}

	// Token: 0x0600229C RID: 8860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x76EBB4", Offset = "0x76EBB4", VA = "0x76EBB4")]
	private void Awake()
	{
	}

	// Token: 0x0600229D RID: 8861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x76EC24", Offset = "0x76EC24", VA = "0x76EC24")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 pos;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion rotation;

	// Token: 0x040014E9 RID: 5353
	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x34")]
	private float smoothing;

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x38")]
	private Transform myTr;

	// Token: 0x040014EB RID: 5355
	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0x40")]
	private KuulaPong pong;

	// Token: 0x040014EC RID: 5356
	[Token(Token = "0x400106F")]
	[FieldOffset(Offset = "0x48")]
	public bool ensimmainenPelaaja;
}
