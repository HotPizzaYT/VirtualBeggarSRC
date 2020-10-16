using System;
using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20001F6")]
	public interface Stats_LoadPlayerStatsResult : Result
	{
		// Token: 0x06001578 RID: 5496
		[Token(Token = "0x600111B")]
		PlayerStats getPlayerStats();
	}
}
