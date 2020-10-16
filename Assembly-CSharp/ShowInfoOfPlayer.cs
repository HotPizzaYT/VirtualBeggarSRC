using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004CC RID: 1228
[Token(Token = "0x2000376")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD6EC", Offset = "0x4BD6EC")]
public class ShowInfoOfPlayer : Photon.MonoBehaviour
{
	// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0xAB1D3C", Offset = "0xAB1D3C", VA = "0xAB1D3C")]
	public ShowInfoOfPlayer()
	{
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0xAB1D44", Offset = "0xAB1D44", VA = "0xAB1D44")]
	private void Start()
	{
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0xAB216C", Offset = "0xAB216C", VA = "0xAB216C")]
	private void Update()
	{
	}

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x18")]
	private GameObject textGo;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x20")]
	private TextMesh tm;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x28")]
	public float CharacterSize;

	// Token: 0x0400127F RID: 4735
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x30")]
	public Font font;

	// Token: 0x04001280 RID: 4736
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x38")]
	public bool DisableOnOwnObjects;
}
