using System;
using Com.Google.Android.Gms.Common.Api;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20001F2")]
	public class Stats_LoadPlayerStatsResultObject : JavaObjWrapper, Stats_LoadPlayerStatsResult, Result
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x705A84", Offset = "0x705A84", VA = "0x705A84")]
		public Stats_LoadPlayerStatsResultObject(IntPtr ptr)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x705A8C", Offset = "0x705A8C", VA = "0x705A8C", Slot = "5")]
		public PlayerStats getPlayerStats()
		{
			return null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x705B48", Offset = "0x705B48", VA = "0x705B48", Slot = "6")]
		public Status getStatus()
		{
			return null;
		}

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000A0F")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/Stats$LoadPlayerStatsResult";
	}
}
