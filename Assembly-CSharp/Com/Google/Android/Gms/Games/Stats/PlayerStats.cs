using System;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20001F3")]
	public interface PlayerStats
	{
		// Token: 0x0600155F RID: 5471
		[Token(Token = "0x6001102")]
		float getAverageSessionLength();

		// Token: 0x06001560 RID: 5472
		[Token(Token = "0x6001103")]
		float getChurnProbability();

		// Token: 0x06001561 RID: 5473
		[Token(Token = "0x6001104")]
		int getDaysSinceLastPlayed();

		// Token: 0x06001562 RID: 5474
		[Token(Token = "0x6001105")]
		int getNumberOfPurchases();

		// Token: 0x06001563 RID: 5475
		[Token(Token = "0x6001106")]
		int getNumberOfSessions();

		// Token: 0x06001564 RID: 5476
		[Token(Token = "0x6001107")]
		float getSessionPercentile();

		// Token: 0x06001565 RID: 5477
		[Token(Token = "0x6001108")]
		float getSpendPercentile();

		// Token: 0x06001566 RID: 5478
		[Token(Token = "0x6001109")]
		float getSpendProbability();

		// Token: 0x06001567 RID: 5479
		[Token(Token = "0x600110A")]
		float getHighSpenderProbability();

		// Token: 0x06001568 RID: 5480
		[Token(Token = "0x600110B")]
		float getTotalSpendNext28Days();
	}
}
