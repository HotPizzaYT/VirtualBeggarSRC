using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BC RID: 1212
[Token(Token = "0x2000366")]
public class OnClickInstantiate : MonoBehaviour
{
	// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x774104", Offset = "0x774104", VA = "0x774104")]
	public OnClickInstantiate()
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x77422C", Offset = "0x77422C", VA = "0x77422C")]
	private void OnClick()
	{
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x774530", Offset = "0x774530", VA = "0x774530")]
	private void OnGUI()
	{
	}

	// Token: 0x0400125D RID: 4701
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Prefab;

	// Token: 0x0400125E RID: 4702
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x20")]
	public int InstantiateType;

	// Token: 0x0400125F RID: 4703
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x28")]
	private string[] InstantiateTypeNames;

	// Token: 0x04001260 RID: 4704
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x30")]
	public bool showGui;
}
