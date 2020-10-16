using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000479 RID: 1145
[Token(Token = "0x200032C")]
public interface IPunCallbacks
{
	// Token: 0x06001E79 RID: 7801
	[Token(Token = "0x6001918")]
	void OnConnectedToPhoton();

	// Token: 0x06001E7A RID: 7802
	[Token(Token = "0x6001919")]
	void OnLeftRoom();

	// Token: 0x06001E7B RID: 7803
	[Token(Token = "0x600191A")]
	void OnMasterClientSwitched(PhotonPlayer newMasterClient);

	// Token: 0x06001E7C RID: 7804
	[Token(Token = "0x600191B")]
	void OnPhotonCreateRoomFailed(object[] codeAndMsg);

	// Token: 0x06001E7D RID: 7805
	[Token(Token = "0x600191C")]
	void OnPhotonJoinRoomFailed(object[] codeAndMsg);

	// Token: 0x06001E7E RID: 7806
	[Token(Token = "0x600191D")]
	void OnCreatedRoom();

	// Token: 0x06001E7F RID: 7807
	[Token(Token = "0x600191E")]
	void OnJoinedLobby();

	// Token: 0x06001E80 RID: 7808
	[Token(Token = "0x600191F")]
	void OnLeftLobby();

	// Token: 0x06001E81 RID: 7809
	[Token(Token = "0x6001920")]
	void OnFailedToConnectToPhoton(DisconnectCause cause);

	// Token: 0x06001E82 RID: 7810
	[Token(Token = "0x6001921")]
	void OnConnectionFail(DisconnectCause cause);

	// Token: 0x06001E83 RID: 7811
	[Token(Token = "0x6001922")]
	void OnDisconnectedFromPhoton();

	// Token: 0x06001E84 RID: 7812
	[Token(Token = "0x6001923")]
	void OnPhotonInstantiate(PhotonMessageInfo info);

	// Token: 0x06001E85 RID: 7813
	[Token(Token = "0x6001924")]
	void OnReceivedRoomListUpdate();

	// Token: 0x06001E86 RID: 7814
	[Token(Token = "0x6001925")]
	void OnJoinedRoom();

	// Token: 0x06001E87 RID: 7815
	[Token(Token = "0x6001926")]
	void OnPhotonPlayerConnected(PhotonPlayer newPlayer);

	// Token: 0x06001E88 RID: 7816
	[Token(Token = "0x6001927")]
	void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer);

	// Token: 0x06001E89 RID: 7817
	[Token(Token = "0x6001928")]
	void OnPhotonRandomJoinFailed(object[] codeAndMsg);

	// Token: 0x06001E8A RID: 7818
	[Token(Token = "0x6001929")]
	void OnConnectedToMaster();

	// Token: 0x06001E8B RID: 7819
	[Token(Token = "0x600192A")]
	void OnPhotonMaxCccuReached();

	// Token: 0x06001E8C RID: 7820
	[Token(Token = "0x600192B")]
	void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged);

	// Token: 0x06001E8D RID: 7821
	[Token(Token = "0x600192C")]
	void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps);

	// Token: 0x06001E8E RID: 7822
	[Token(Token = "0x600192D")]
	void OnUpdatedFriendList();

	// Token: 0x06001E8F RID: 7823
	[Token(Token = "0x600192E")]
	void OnCustomAuthenticationFailed(string debugMessage);

	// Token: 0x06001E90 RID: 7824
	[Token(Token = "0x600192F")]
	void OnWebRpcResponse(OperationResponse response);

	// Token: 0x06001E91 RID: 7825
	[Token(Token = "0x6001930")]
	void OnOwnershipRequest(object[] viewAndPlayer);

	// Token: 0x06001E92 RID: 7826
	[Token(Token = "0x6001931")]
	void OnLobbyStatisticsUpdate();
}
