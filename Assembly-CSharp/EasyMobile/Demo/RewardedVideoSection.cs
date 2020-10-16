using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace EasyMobile.Demo
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x200000F")]
	[Serializable]
	public class RewardedVideoSection : LoadAndShowSection<RewardedVideoSection.DefaultRewardedVideolUI, RewardedVideoSection.CustomRewardedVideoUI>
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59E3F8", Offset = "0x59E3F8", VA = "0x59E3F8")]
		public RewardedVideoSection()
		{
		}

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000010")]
		[Serializable]
		public class DefaultRewardedVideolUI : LoadAndShowSection<RewardedVideoSection.DefaultRewardedVideolUI, RewardedVideoSection.CustomRewardedVideoUI>.DefaultElement
		{
			// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x59EFBC", Offset = "0x59EFBC", VA = "0x59EFBC")]
			public DefaultRewardedVideolUI()
			{
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000013")]
			protected override string AdReadyMessage
			{
				[Token(Token = "0x6000061")]
				[Address(RVA = "0x59F00C", Offset = "0x59F00C", VA = "0x59F00C", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000014")]
			protected override string AdNotReadyMessage
			{
				[Token(Token = "0x6000062")]
				[Address(RVA = "0x59F054", Offset = "0x59F054", VA = "0x59F054", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000015")]
			protected override string UnavailableAdAlertMessage
			{
				[Token(Token = "0x6000063")]
				[Address(RVA = "0x59F09C", Offset = "0x59F09C", VA = "0x59F09C", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002118 File Offset: 0x00000318
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x59F0E4", Offset = "0x59F0E4", VA = "0x59F0E4", Slot = "7")]
			protected override bool IsAdReady()
			{
				return default(bool);
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x59F148", Offset = "0x59F148", VA = "0x59F148", Slot = "5")]
			protected override void LoadAd()
			{
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x59F228", Offset = "0x59F228", VA = "0x59F228", Slot = "6")]
			protected override void ShowAd()
			{
			}
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000011")]
		[Serializable]
		public class CustomRewardedVideoUI : LoadAndShowSection<RewardedVideoSection.DefaultRewardedVideolUI, RewardedVideoSection.CustomRewardedVideoUI>.CustomElement
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x59E448", Offset = "0x59E448", VA = "0x59E448")]
			public CustomRewardedVideoUI()
			{
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000016")]
			protected override string AdReadyMessage
			{
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x59E498", Offset = "0x59E498", VA = "0x59E498", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000017")]
			protected override string AdNotReadyMessage
			{
				[Token(Token = "0x6000069")]
				[Address(RVA = "0x59E600", Offset = "0x59E600", VA = "0x59E600", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000018")]
			protected override string UnavailableAdAlertMessage
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x59E768", Offset = "0x59E768", VA = "0x59E768", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00002130 File Offset: 0x00000330
			[Token(Token = "0x17000019")]
			private RewardedAdNetwork SelectedNetwork
			{
				[Token(Token = "0x600006B")]
				[Address(RVA = "0x59E854", Offset = "0x59E854", VA = "0x59E854")]
				get
				{
					return RewardedAdNetwork.None;
				}
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x59E8D8", Offset = "0x59E8D8", VA = "0x59E8D8", Slot = "11")]
			protected override void InitNetworkDropdown()
			{
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002148 File Offset: 0x00000348
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x59ED4C", Offset = "0x59ED4C", VA = "0x59ED4C", Slot = "7")]
			protected override bool IsAdReady()
			{
				return default(bool);
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x59EE1C", Offset = "0x59EE1C", VA = "0x59EE1C", Slot = "5")]
			protected override void LoadAd()
			{
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x59EEEC", Offset = "0x59EEEC", VA = "0x59EEEC", Slot = "6")]
			protected override void ShowAd()
			{
			}

			// Token: 0x04000038 RID: 56
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x50")]
			private List<RewardedAdNetwork> allRewardedNetworks;
		}
	}
}
