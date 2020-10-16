using System;
using Il2CppDummyDll;
using Photon;

// Token: 0x020004C3 RID: 1219
[Token(Token = "0x200036D")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD594", Offset = "0x4BD594")]
public class PickupItemSyncer : MonoBehaviour
{
	// Token: 0x0600209A RID: 8346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x7915EC", Offset = "0x7915EC", VA = "0x7915EC")]
	public PickupItemSyncer()
	{
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x7915F4", Offset = "0x7915F4", VA = "0x7915F4")]
	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x792128", Offset = "0x792128", VA = "0x792128")]
	public void OnJoinedRoom()
	{
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x79240C", Offset = "0x79240C", VA = "0x79240C")]
	public void AskForPickupItemSpawnTimes()
	{
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x792650", Offset = "0x792650", VA = "0x792650")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD5F8", Offset = "0x4BD5F8")]
	public void RequestForPickupTimes(PhotonMessageInfo msgInfo)
	{
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x791680", Offset = "0x791680", VA = "0x791680")]
	private void SendPickedUpItems(PhotonPlayer targtePlayer)
	{
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x7926F8", Offset = "0x7926F8", VA = "0x7926F8")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD608", Offset = "0x4BD608")]
	public void PickupItemInit(double timeBase, float[] inactivePickupsAndTimes)
	{
	}

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x18")]
	public bool IsWaitingForPickupInit;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4000E8D")]
	private const float TimeDeltaToIgnore = 0.2f;
}
