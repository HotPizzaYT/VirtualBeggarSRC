using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E8 RID: 1256
[Token(Token = "0x2000390")]
public class CloudUIHandler : MonoBehaviour
{
	// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x7010C0", Offset = "0x7010C0", VA = "0x7010C0")]
	public CloudUIHandler()
	{
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB9")]
	[Address(RVA = "0x7010C8", Offset = "0x7010C8", VA = "0x7010C8")]
	private void Start()
	{
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x701118", Offset = "0x701118", VA = "0x701118")]
	public void OnAvaaIkkuna()
	{
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x6FFDB0", Offset = "0x6FFDB0", VA = "0x6FFDB0")]
	public void AsetaLadattuSave(string title, string description, long lastModifiedNative = 0L)
	{
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x70059C", Offset = "0x70059C", VA = "0x70059C")]
	public void AsetaSaveTiedot(string metaStr)
	{
	}

	// Token: 0x04001380 RID: 4992
	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x18")]
	public TextMesh aikateksti;

	// Token: 0x04001381 RID: 4993
	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x20")]
	public TextMesh lvlTeksti;

	// Token: 0x04001382 RID: 4994
	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x28")]
	public TextMesh udTeksti;

	// Token: 0x04001383 RID: 4995
	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x30")]
	public TextMesh iosDeviceTeksti;

	// Token: 0x04001384 RID: 4996
	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x38")]
	public GameObject udMerkkiObj;

	// Token: 0x04001385 RID: 4997
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x40")]
	public GameObject androidObjektit;

	// Token: 0x04001386 RID: 4998
	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x48")]
	public GCManagerIOS gc;
}
