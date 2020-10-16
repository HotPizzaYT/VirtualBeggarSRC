using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class AdMobMainokset : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x6FE1F8", Offset = "0x6FE1F8", VA = "0x6FE1F8")]
	public AdMobMainokset()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x6FE200", Offset = "0x6FE200", VA = "0x6FE200")]
	private void Awake()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x6FE284", Offset = "0x6FE284", VA = "0x6FE284")]
	private void Start()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x6FE318", Offset = "0x6FE318", VA = "0x6FE318")]
	public void LoadAdMobIntersitial()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x6FE31C", Offset = "0x6FE31C", VA = "0x6FE31C")]
	public void ShowAdMobIntersitial()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x6FE320", Offset = "0x6FE320", VA = "0x6FE320")]
	public void AsetaAdFree()
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public string sceneBannerId
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x6FE3A0", Offset = "0x6FE3A0", VA = "0x6FE3A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public string AdMobInterstitialUnityId;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private bool intersitialLadattu;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x21")]
	private bool adFree;
}
