using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B7 RID: 1207
[Token(Token = "0x2000362")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD234", Offset = "0x4BD234")]
public class ManualPhotonViewAllocator : MonoBehaviour
{
	// Token: 0x0600206C RID: 8300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x751258", Offset = "0x751258", VA = "0x751258")]
	public ManualPhotonViewAllocator()
	{
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x751260", Offset = "0x751260", VA = "0x751260")]
	public void AllocateManualPhotonView()
	{
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x751444", Offset = "0x751444", VA = "0x751444")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD298", Offset = "0x4BD298")]
	public void InstantiateRpc(int viewID)
	{
	}

	// Token: 0x04001250 RID: 4688
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Prefab;
}
