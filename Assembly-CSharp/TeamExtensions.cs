using System;
using Il2CppDummyDll;

// Token: 0x020004C9 RID: 1225
[Token(Token = "0x2000373")]
internal static class TeamExtensions
{
	// Token: 0x060020AC RID: 8364 RVA: 0x00009FC0 File Offset: 0x000081C0
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0xAC3A0C", Offset = "0xAC3A0C", VA = "0xAC3A0C")]
	public static PunTeams.Team GetTeam(this PhotonPlayer player)
	{
		return PunTeams.Team.none;
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0xAC3B28", Offset = "0xAC3B28", VA = "0xAC3B28")]
	public static void SetTeam(this PhotonPlayer player, PunTeams.Team team)
	{
	}
}
