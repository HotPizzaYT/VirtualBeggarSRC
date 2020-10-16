using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A5 RID: 1189
[Token(Token = "0x2000350")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCEA8", Offset = "0x4BCEA8")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCEA8", Offset = "0x4BCEA8")]
[Attribute(Name = "AddComponentMenu", RVA = "0x4BCEA8", Offset = "0x4BCEA8")]
public class PhotonRigidbody2DView : MonoBehaviour
{
	// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x788160", Offset = "0x788160", VA = "0x788160")]
	public PhotonRigidbody2DView()
	{
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x788170", Offset = "0x788170", VA = "0x788170")]
	private void Awake()
	{
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x7881C8", Offset = "0x7881C8", VA = "0x7881C8")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x040011F3 RID: 4595
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_SynchronizeVelocity;

	// Token: 0x040011F4 RID: 4596
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	// Token: 0x040011F5 RID: 4597
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D m_Body;
}
