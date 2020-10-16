using System;
using Il2CppDummyDll;

// Token: 0x0200045A RID: 1114
[Token(Token = "0x200030D")]
public enum PhotonNetworkingMessage
{
	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000BF8")]
	OnConnectedToPhoton,
	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000BF9")]
	OnLeftRoom,
	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000BFA")]
	OnMasterClientSwitched,
	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000BFB")]
	OnPhotonCreateRoomFailed,
	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000BFC")]
	OnPhotonJoinRoomFailed,
	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000BFD")]
	OnCreatedRoom,
	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000BFE")]
	OnJoinedLobby,
	// Token: 0x04000FC7 RID: 4039
	[Token(Token = "0x4000BFF")]
	OnLeftLobby,
	// Token: 0x04000FC8 RID: 4040
	[Token(Token = "0x4000C00")]
	OnDisconnectedFromPhoton,
	// Token: 0x04000FC9 RID: 4041
	[Token(Token = "0x4000C01")]
	OnConnectionFail,
	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000C02")]
	OnFailedToConnectToPhoton,
	// Token: 0x04000FCB RID: 4043
	[Token(Token = "0x4000C03")]
	OnReceivedRoomListUpdate,
	// Token: 0x04000FCC RID: 4044
	[Token(Token = "0x4000C04")]
	OnJoinedRoom,
	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000C05")]
	OnPhotonPlayerConnected,
	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000C06")]
	OnPhotonPlayerDisconnected,
	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000C07")]
	OnPhotonRandomJoinFailed,
	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000C08")]
	OnConnectedToMaster,
	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000C09")]
	OnPhotonSerializeView,
	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000C0A")]
	OnPhotonInstantiate,
	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000C0B")]
	OnPhotonMaxCccuReached,
	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000C0C")]
	OnPhotonCustomRoomPropertiesChanged,
	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000C0D")]
	OnPhotonPlayerPropertiesChanged,
	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000C0E")]
	OnUpdatedFriendList,
	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000C0F")]
	OnCustomAuthenticationFailed,
	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000C10")]
	OnWebRpcResponse,
	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000C11")]
	OnOwnershipRequest,
	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000C12")]
	OnLobbyStatisticsUpdate
}
