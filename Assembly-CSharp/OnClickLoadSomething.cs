using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BD RID: 1213
[Token(Token = "0x2000367")]
public class OnClickLoadSomething : MonoBehaviour
{
	// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x774624", Offset = "0x774624", VA = "0x774624")]
	public OnClickLoadSomething()
	{
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x77462C", Offset = "0x77462C", VA = "0x77462C")]
	public void OnClick()
	{
	}

	// Token: 0x04001261 RID: 4705
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x18")]
	public OnClickLoadSomething.ResourceTypeOption ResourceTypeToLoad;

	// Token: 0x04001262 RID: 4706
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x20")]
	public string ResourceToLoad;

	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x2000368")]
	public enum ResourceTypeOption : byte
	{
		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4000E7D")]
		Scene,
		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4000E7E")]
		Web
	}
}
