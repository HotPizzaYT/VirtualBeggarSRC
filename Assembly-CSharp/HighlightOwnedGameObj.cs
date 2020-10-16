using System;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004B3 RID: 1203
[Token(Token = "0x200035E")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD100", Offset = "0x4BD100")]
public class HighlightOwnedGameObj : Photon.MonoBehaviour
{
	// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x689B08", Offset = "0x689B08", VA = "0x689B08")]
	public HighlightOwnedGameObj()
	{
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x689B18", Offset = "0x689B18", VA = "0x689B18")]
	private void Update()
	{
	}

	// Token: 0x04001239 RID: 4665
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PointerPrefab;

	// Token: 0x0400123A RID: 4666
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x20")]
	public float Offset;

	// Token: 0x0400123B RID: 4667
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x28")]
	private Transform markerTransform;
}
