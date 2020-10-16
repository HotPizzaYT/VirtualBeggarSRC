using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BF RID: 1215
[Token(Token = "0x2000369")]
public class OnJoinedInstantiate : MonoBehaviour
{
	// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x774664", Offset = "0x774664", VA = "0x774664")]
	public OnJoinedInstantiate()
	{
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x774674", Offset = "0x774674", VA = "0x774674")]
	public void OnJoinedRoom()
	{
	}

	// Token: 0x04001266 RID: 4710
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x18")]
	public Transform SpawnPosition;

	// Token: 0x04001267 RID: 4711
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x20")]
	public float PositionOffset;

	// Token: 0x04001268 RID: 4712
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] PrefabsToInstantiate;
}
