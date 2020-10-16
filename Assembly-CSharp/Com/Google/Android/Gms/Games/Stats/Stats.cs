using System;
using Com.Google.Android.Gms.Common.Api;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20001F5")]
	public interface Stats
	{
		// Token: 0x06001577 RID: 5495
		[Token(Token = "0x600111A")]
		PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2);
	}
}
