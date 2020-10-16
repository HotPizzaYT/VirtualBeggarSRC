using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E6 RID: 1254
[Token(Token = "0x200038E")]
public class CloudSaveIOS : MonoBehaviour
{
	// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x7010AC", Offset = "0x7010AC", VA = "0x7010AC")]
	public CloudSaveIOS()
	{
	}

	// Token: 0x0400137D RID: 4989
	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x18")]
	public DataKasaaja dataManager;

	// Token: 0x0400137E RID: 4990
	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x20")]
	public CloudDataSiirtaja dataSiirtaja;

	// Token: 0x0400137F RID: 4991
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x28")]
	private bool isConnected;
}
