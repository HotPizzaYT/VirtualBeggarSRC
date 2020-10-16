using System;
using Il2CppDummyDll;
using Photon;

// Token: 0x020004B2 RID: 1202
[Token(Token = "0x200035D")]
public class ConnectAndJoinRandom : MonoBehaviour
{
	// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x705DA4", Offset = "0x705DA4", VA = "0x705DA4")]
	public ConnectAndJoinRandom()
	{
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x705DBC", Offset = "0x705DBC", VA = "0x705DBC", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x705E24", Offset = "0x705E24", VA = "0x705E24", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x705FB4", Offset = "0x705FB4", VA = "0x705FB4", Slot = "6")]
	public virtual void OnConnectedToMaster()
	{
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x706438", Offset = "0x706438", VA = "0x706438", Slot = "7")]
	public virtual void OnPhotonRandomJoinFailed()
	{
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x706510", Offset = "0x706510", VA = "0x706510", Slot = "8")]
	public virtual void OnFailedToConnectToPhoton(DisconnectCause cause)
	{
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x7065EC", Offset = "0x7065EC", VA = "0x7065EC")]
	public void OnJoinedRoom()
	{
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x70665C", Offset = "0x70665C", VA = "0x70665C")]
	public void OnJoinedLobby()
	{
	}

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x18")]
	public bool AutoConnect;

	// Token: 0x04001237 RID: 4663
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x19")]
	public byte Version;

	// Token: 0x04001238 RID: 4664
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x1A")]
	private bool ConnectInUpdate;
}
