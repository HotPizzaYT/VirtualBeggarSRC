using System;
using Il2CppDummyDll;

// Token: 0x02000462 RID: 1122
[Token(Token = "0x2000315")]
public enum PeerState
{
	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4000C3A")]
	Uninitialized,
	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4000C3B")]
	PeerCreated,
	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4000C3C")]
	Queued,
	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4000C3D")]
	Authenticated,
	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4000C3E")]
	JoinedLobby,
	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4000C3F")]
	DisconnectingFromMasterserver,
	// Token: 0x04001008 RID: 4104
	[Token(Token = "0x4000C40")]
	ConnectingToGameserver,
	// Token: 0x04001009 RID: 4105
	[Token(Token = "0x4000C41")]
	ConnectedToGameserver,
	// Token: 0x0400100A RID: 4106
	[Token(Token = "0x4000C42")]
	Joining,
	// Token: 0x0400100B RID: 4107
	[Token(Token = "0x4000C43")]
	Joined,
	// Token: 0x0400100C RID: 4108
	[Token(Token = "0x4000C44")]
	Leaving,
	// Token: 0x0400100D RID: 4109
	[Token(Token = "0x4000C45")]
	DisconnectingFromGameserver,
	// Token: 0x0400100E RID: 4110
	[Token(Token = "0x4000C46")]
	ConnectingToMasterserver,
	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x4000C47")]
	QueuedComingFromGameserver,
	// Token: 0x04001010 RID: 4112
	[Token(Token = "0x4000C48")]
	Disconnecting,
	// Token: 0x04001011 RID: 4113
	[Token(Token = "0x4000C49")]
	Disconnected,
	// Token: 0x04001012 RID: 4114
	[Token(Token = "0x4000C4A")]
	ConnectedToMaster,
	// Token: 0x04001013 RID: 4115
	[Token(Token = "0x4000C4B")]
	ConnectingToNameServer,
	// Token: 0x04001014 RID: 4116
	[Token(Token = "0x4000C4C")]
	ConnectedToNameServer,
	// Token: 0x04001015 RID: 4117
	[Token(Token = "0x4000C4D")]
	DisconnectingFromNameServer,
	// Token: 0x04001016 RID: 4118
	[Token(Token = "0x4000C4E")]
	Authenticating
}
