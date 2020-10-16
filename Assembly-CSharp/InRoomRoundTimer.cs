using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B6 RID: 1206
[Token(Token = "0x2000361")]
public class InRoomRoundTimer : MonoBehaviour
{
	// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x68CCD4", Offset = "0x68CCD4", VA = "0x68CCD4")]
	public InRoomRoundTimer()
	{
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x68CD3C", Offset = "0x68CD3C", VA = "0x68CD3C")]
	private void StartRoundNow()
	{
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x68CE80", Offset = "0x68CE80", VA = "0x68CE80")]
	public void OnJoinedRoom()
	{
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x68D018", Offset = "0x68D018", VA = "0x68D018")]
	public void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
	{
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x68D134", Offset = "0x68D134", VA = "0x68D134")]
	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x68D23C", Offset = "0x68D23C", VA = "0x68D23C")]
	private void Update()
	{
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x68D24C", Offset = "0x68D24C", VA = "0x68D24C")]
	public void OnGUI()
	{
	}

	// Token: 0x0400124B RID: 4683
	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x18")]
	public int SecondsPerTurn;

	// Token: 0x0400124C RID: 4684
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x20")]
	public double StartTime;

	// Token: 0x0400124D RID: 4685
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x28")]
	public Rect TextPos;

	// Token: 0x0400124E RID: 4686
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x38")]
	private bool startRoundWhenTimeIsSynced;

	// Token: 0x0400124F RID: 4687
	[Token(Token = "0x4000E6C")]
	private const string StartTimeKey = "st";
}
