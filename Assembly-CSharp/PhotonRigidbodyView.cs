using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
[Token(Token = "0x2000351")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCF78", Offset = "0x4BCF78")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCF78", Offset = "0x4BCF78")]
[Attribute(Name = "AddComponentMenu", RVA = "0x4BCF78", Offset = "0x4BCF78")]
public class PhotonRigidbodyView : MonoBehaviour
{
	// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x7885CC", Offset = "0x7885CC", VA = "0x7885CC")]
	public PhotonRigidbodyView()
	{
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x7885DC", Offset = "0x7885DC", VA = "0x7885DC")]
	private void Awake()
	{
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x788634", Offset = "0x788634", VA = "0x788634")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x040011F6 RID: 4598
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_SynchronizeVelocity;

	// Token: 0x040011F7 RID: 4599
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool m_SynchronizeAngularVelocity;

	// Token: 0x040011F8 RID: 4600
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody m_Body;
}
