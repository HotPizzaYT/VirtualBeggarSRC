using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000498 RID: 1176
[Token(Token = "0x2000349")]
[Serializable]
public class ServerSettings : ScriptableObject
{
	// Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0xAB1014", Offset = "0xAB1014", VA = "0xAB1014")]
	public ServerSettings()
	{
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0xAB10D4", Offset = "0xAB10D4", VA = "0xAB10D4")]
	public void UseCloudBestRegion(string cloudAppid)
	{
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0xAB10E4", Offset = "0xAB10E4", VA = "0xAB10E4")]
	public void UseCloud(string cloudAppid)
	{
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0xAB10F4", Offset = "0xAB10F4", VA = "0xAB10F4")]
	public void UseCloud(string cloudAppid, CloudRegionCode code)
	{
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0xAB1108", Offset = "0xAB1108", VA = "0xAB1108")]
	public void UseMyServer(string serverAddress, int serverPort, string application)
	{
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0xAB1198", Offset = "0xAB1198", VA = "0xAB1198", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x18")]
	public ServerSettings.HostingOption HostType;

	// Token: 0x040011C5 RID: 4549
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x1C")]
	public ConnectionProtocol Protocol;

	// Token: 0x040011C6 RID: 4550
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x20")]
	public string ServerAddress;

	// Token: 0x040011C7 RID: 4551
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x28")]
	public int ServerPort;

	// Token: 0x040011C8 RID: 4552
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x30")]
	public string AppID;

	// Token: 0x040011C9 RID: 4553
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x38")]
	public CloudRegionCode PreferredRegion;

	// Token: 0x040011CA RID: 4554
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x3C")]
	public CloudRegionFlag EnabledRegions;

	// Token: 0x040011CB RID: 4555
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x40")]
	public bool JoinLobby;

	// Token: 0x040011CC RID: 4556
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x41")]
	public bool EnableLobbyStatistics;

	// Token: 0x040011CD RID: 4557
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x48")]
	public List<string> RpcList;

	// Token: 0x040011CE RID: 4558
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BCCA8", Offset = "0x4BCCA8")]
	public bool DisableAutoOpenWizard;

	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x200034A")]
	public enum HostingOption
	{
		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x4000DF3")]
		NotSet,
		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x4000DF4")]
		PhotonCloud,
		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x4000DF5")]
		SelfHosted,
		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x4000DF6")]
		OfflineMode,
		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x4000DF7")]
		BestRegion
	}
}
