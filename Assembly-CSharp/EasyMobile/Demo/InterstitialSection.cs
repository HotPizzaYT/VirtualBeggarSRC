using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace EasyMobile.Demo
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x2000009")]
	[Serializable]
	public class InterstitialSection : LoadAndShowSection<InterstitialSection.DefaultInterstitialUI, InterstitialSection.CustomInterstitialUI>
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x58C00C", Offset = "0x58C00C", VA = "0x58C00C")]
		public InterstitialSection()
		{
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000A")]
		[Serializable]
		public class DefaultInterstitialUI : LoadAndShowSection<InterstitialSection.DefaultInterstitialUI, InterstitialSection.CustomInterstitialUI>.DefaultElement
		{
			// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x58CBD0", Offset = "0x58CBD0", VA = "0x58CBD0")]
			public DefaultInterstitialUI()
			{
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000006")]
			protected override string AdReadyMessage
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x58CC20", Offset = "0x58CC20", VA = "0x58CC20", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000047 RID: 71 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000007")]
			protected override string AdNotReadyMessage
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x58CC68", Offset = "0x58CC68", VA = "0x58CC68", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000048 RID: 72 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000008")]
			protected override string UnavailableAdAlertMessage
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x58CCB0", Offset = "0x58CCB0", VA = "0x58CCB0", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000049 RID: 73 RVA: 0x000020D0 File Offset: 0x000002D0
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x58CCF8", Offset = "0x58CCF8", VA = "0x58CCF8", Slot = "7")]
			protected override bool IsAdReady()
			{
				return default(bool);
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x58CD5C", Offset = "0x58CD5C", VA = "0x58CD5C", Slot = "5")]
			protected override void LoadAd()
			{
			}

			// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x58CE3C", Offset = "0x58CE3C", VA = "0x58CE3C", Slot = "6")]
			protected override void ShowAd()
			{
			}
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000B")]
		[Serializable]
		public class CustomInterstitialUI : LoadAndShowSection<InterstitialSection.DefaultInterstitialUI, InterstitialSection.CustomInterstitialUI>.CustomElement
		{
			// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x58C05C", Offset = "0x58C05C", VA = "0x58C05C")]
			public CustomInterstitialUI()
			{
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000009")]
			protected override string AdReadyMessage
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x58C0AC", Offset = "0x58C0AC", VA = "0x58C0AC", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000A")]
			protected override string AdNotReadyMessage
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x58C214", Offset = "0x58C214", VA = "0x58C214", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000B")]
			protected override string UnavailableAdAlertMessage
			{
				[Token(Token = "0x6000043")]
				[Address(RVA = "0x58C37C", Offset = "0x58C37C", VA = "0x58C37C", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000050 RID: 80 RVA: 0x000020E8 File Offset: 0x000002E8
			[Token(Token = "0x1700000C")]
			private InterstitialAdNetwork SelectedNetwork
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x58C468", Offset = "0x58C468", VA = "0x58C468")]
				get
				{
					return InterstitialAdNetwork.None;
				}
			}

			// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x58C4EC", Offset = "0x58C4EC", VA = "0x58C4EC", Slot = "11")]
			protected override void InitNetworkDropdown()
			{
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00002100 File Offset: 0x00000300
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x58C960", Offset = "0x58C960", VA = "0x58C960", Slot = "7")]
			protected override bool IsAdReady()
			{
				return default(bool);
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x58CA30", Offset = "0x58CA30", VA = "0x58CA30", Slot = "5")]
			protected override void LoadAd()
			{
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x58CB00", Offset = "0x58CB00", VA = "0x58CB00", Slot = "6")]
			protected override void ShowAd()
			{
			}

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x50")]
			private List<InterstitialAdNetwork> allInterstitialNetworks;
		}
	}
}
