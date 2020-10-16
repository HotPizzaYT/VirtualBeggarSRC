using System;
using Il2CppDummyDll;

// Token: 0x02000463 RID: 1123
[Token(Token = "0x2000316")]
public enum DisconnectCause
{
	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4000C50")]
	ExceptionOnConnect = 1023,
	// Token: 0x04001019 RID: 4121
	[Token(Token = "0x4000C51")]
	SecurityExceptionOnConnect = 1022,
	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x4000C52")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BBA10", Offset = "0x4BBA10")]
	TimeoutDisconnect = 1040,
	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x4000C53")]
	DisconnectByClientTimeout = 1040,
	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x4000C54")]
	InternalReceiveException = 1039,
	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x4000C55")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x4BBA48", Offset = "0x4BBA48")]
	DisconnectByServer = 1041,
	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x4000C56")]
	DisconnectByServerTimeout = 1041,
	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x4000C57")]
	DisconnectByServerLogic = 1043,
	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4000C58")]
	DisconnectByServerUserLimit = 1042,
	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4000C59")]
	Exception = 1026,
	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4000C5A")]
	InvalidRegion = 32756,
	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4000C5B")]
	MaxCcuReached,
	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4000C5C")]
	InvalidAuthentication = 32767,
	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4000C5D")]
	AuthenticationTicketExpired = 32753
}
