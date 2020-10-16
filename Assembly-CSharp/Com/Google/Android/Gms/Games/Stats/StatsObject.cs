using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20001F7")]
	public class StatsObject : JavaObjWrapper, Stats
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x705C04", Offset = "0x705C04", VA = "0x705C04")]
		public StatsObject(IntPtr ptr)
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x705C0C", Offset = "0x705C0C", VA = "0x705C0C", Slot = "5")]
		public PendingResult<Stats_LoadPlayerStatsResultObject> loadPlayerStats(GoogleApiClient arg_GoogleApiClient_1, bool arg_bool_2)
		{
			return null;
		}

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000A11")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats";
	}
}
