using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x2000006")]
	[Serializable]
	public class BannerSection : AdsSection
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x56F968", Offset = "0x56F968", VA = "0x56F968")]
		public BannerSection()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x56F970", Offset = "0x56F970", VA = "0x56F970", Slot = "4")]
		public override void Start()
		{
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BannerSection.DefaulBannerUI defaultBannerUI;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BannerSection.CustomBannerUI customBannerUI;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x2000007")]
		[Serializable]
		private class DefaulBannerUI
		{
			// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x56F9D8", Offset = "0x56F9D8", VA = "0x56F9D8")]
			public DefaulBannerUI()
			{
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000003")]
			public BannerAdSize SelectedBannerSize
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x570120", Offset = "0x570120", VA = "0x570120")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000035 RID: 53 RVA: 0x000020A0 File Offset: 0x000002A0
			[Token(Token = "0x17000004")]
			public BannerAdPosition SelectedBannerPosition
			{
				[Token(Token = "0x6000029")]
				[Address(RVA = "0x57009C", Offset = "0x57009C", VA = "0x57009C")]
				get
				{
					return BannerAdPosition.Top;
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x56FA98", Offset = "0x56FA98", VA = "0x56FA98", Slot = "4")]
			public virtual void Start()
			{
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x5706AC", Offset = "0x5706AC", VA = "0x5706AC")]
			protected void InitBannerPositionDropdown()
			{
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x570350", Offset = "0x570350", VA = "0x570350")]
			protected void InitBannerSizesDropdown()
			{
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x570B6C", Offset = "0x570B6C", VA = "0x570B6C")]
			protected void InitButtons()
			{
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x570CEC", Offset = "0x570CEC", VA = "0x570CEC", Slot = "5")]
			protected virtual void ShowBanner()
			{
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x570DD8", Offset = "0x570DD8", VA = "0x570DD8", Slot = "6")]
			protected virtual void HideBanner()
			{
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x570E3C", Offset = "0x570E3C", VA = "0x570E3C", Slot = "7")]
			protected virtual void DestroyBanner()
			{
			}

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			protected Button showBannerButton;

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000019")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			protected Button hideBannerButton;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			protected Button destroyBannerButton;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			protected Dropdown bannerPositionSelector;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			protected Dropdown bannerSizeSelector;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private List<BannerAdSize> allBannerSizes;

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x40")]
			private List<BannerAdPosition> allBannerPositions;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x2000008")]
		[Serializable]
		private class CustomBannerUI : BannerSection.DefaulBannerUI
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x56F9D0", Offset = "0x56F9D0", VA = "0x56F9D0")]
			public CustomBannerUI()
			{
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000020B8 File Offset: 0x000002B8
			[Token(Token = "0x17000005")]
			public BannerAdNetwork SelectedNetwork
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x56F9E0", Offset = "0x56F9E0", VA = "0x56F9E0")]
				get
				{
					return BannerAdNetwork.None;
				}
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x56FA64", Offset = "0x56FA64", VA = "0x56FA64", Slot = "4")]
			public override void Start()
			{
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x56FAC4", Offset = "0x56FAC4", VA = "0x56FAC4")]
			private void InitBannerNetworkDropdown()
			{
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x56FF38", Offset = "0x56FF38", VA = "0x56FF38", Slot = "5")]
			protected override void ShowBanner()
			{
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x5701A0", Offset = "0x5701A0", VA = "0x5701A0", Slot = "6")]
			protected override void HideBanner()
			{
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x570278", Offset = "0x570278", VA = "0x570278", Slot = "7")]
			protected override void DestroyBanner()
			{
			}

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Dropdown networkSelector;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private InputField customKeyInputField;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x58")]
			private List<BannerAdNetwork> allBannerNetworks;
		}
	}
}
