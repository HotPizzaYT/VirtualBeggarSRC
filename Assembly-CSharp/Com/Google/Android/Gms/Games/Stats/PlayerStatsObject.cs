using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20001F4")]
	public class PlayerStatsObject : JavaObjWrapper, PlayerStats
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x7053F0", Offset = "0x7053F0", VA = "0x7053F0")]
		public PlayerStatsObject(IntPtr ptr)
		{
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x170003D1")]
		public static float UNSET_VALUE
		{
			[Token(Token = "0x600110D")]
			[Address(RVA = "0x7053F8", Offset = "0x7053F8", VA = "0x7053F8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x170003D2")]
		public static int CONTENTS_FILE_DESCRIPTOR
		{
			[Token(Token = "0x600110E")]
			[Address(RVA = "0x705454", Offset = "0x705454", VA = "0x705454")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x170003D3")]
		public static int PARCELABLE_WRITE_RETURN_VALUE
		{
			[Token(Token = "0x600110F")]
			[Address(RVA = "0x7054B0", Offset = "0x7054B0", VA = "0x7054B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x70550C", Offset = "0x70550C", VA = "0x70550C", Slot = "5")]
		public float getAverageSessionLength()
		{
			return 0f;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x705598", Offset = "0x705598", VA = "0x705598", Slot = "6")]
		public float getChurnProbability()
		{
			return 0f;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x705624", Offset = "0x705624", VA = "0x705624", Slot = "7")]
		public int getDaysSinceLastPlayed()
		{
			return 0;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x7056B0", Offset = "0x7056B0", VA = "0x7056B0", Slot = "8")]
		public int getNumberOfPurchases()
		{
			return 0;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x70573C", Offset = "0x70573C", VA = "0x70573C", Slot = "9")]
		public int getNumberOfSessions()
		{
			return 0;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x7057C8", Offset = "0x7057C8", VA = "0x7057C8", Slot = "10")]
		public float getSessionPercentile()
		{
			return 0f;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x705854", Offset = "0x705854", VA = "0x705854", Slot = "11")]
		public float getSpendPercentile()
		{
			return 0f;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x7058E0", Offset = "0x7058E0", VA = "0x7058E0", Slot = "12")]
		public float getSpendProbability()
		{
			return 0f;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x70596C", Offset = "0x70596C", VA = "0x70596C", Slot = "13")]
		public float getHighSpenderProbability()
		{
			return 0f;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x7059F8", Offset = "0x7059F8", VA = "0x7059F8", Slot = "14")]
		public float getTotalSpendNext28Days()
		{
			return 0f;
		}

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000A10")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/PlayerStats";
	}
}
