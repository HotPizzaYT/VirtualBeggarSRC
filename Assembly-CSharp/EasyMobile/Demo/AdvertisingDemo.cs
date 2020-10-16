using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class AdvertisingDemo : MonoBehaviour
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x723AB4", Offset = "0x723AB4", VA = "0x723AB4")]
		public AdvertisingDemo()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x723ABC", Offset = "0x723ABC", VA = "0x723ABC")]
		private void Awake()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x723B58", Offset = "0x723B58", VA = "0x723B58")]
		private void Start()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7243A4", Offset = "0x7243A4", VA = "0x7243A4")]
		private void Update()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x724518", Offset = "0x724518", VA = "0x724518")]
		public void RemoveAds()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x72459C", Offset = "0x72459C", VA = "0x72459C")]
		public void ResetRemoveAds()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x723C2C", Offset = "0x723C2C", VA = "0x723C2C")]
		protected void SetupDefaultNetworkTexts()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x723EB8", Offset = "0x723EB8", VA = "0x723EB8")]
		protected void SetupAutoLoadModeDropdown()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x72461C", Offset = "0x72461C", VA = "0x72461C")]
		private void OnEnable()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x724738", Offset = "0x724738", VA = "0x724738")]
		private void OnDisable()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x724854", Offset = "0x724854", VA = "0x724854")]
		private void OnInterstitialAdCompleted(InterstitialAdNetwork network, AdPlacement placement)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x724ADC", Offset = "0x724ADC", VA = "0x724ADC")]
		private void OnRewardedAdCompleted(RewardedAdNetwork network, AdPlacement placement)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x724CC8", Offset = "0x724CC8", VA = "0x724CC8")]
		private void OnRewardedAdSkipped(RewardedAdNetwork network, AdPlacement placement)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x724A48", Offset = "0x724A48", VA = "0x724A48")]
		[DebuggerHidden]
		private IEnumerator DelayCoroutine(float time, Action action)
		{
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x724A40", Offset = "0x724A40", VA = "0x724A40")]
		private float GetPopupDelayTime(AdNetwork network)
		{
			return 0f;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x724EBC", Offset = "0x724EBC", VA = "0x724EBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC32C", Offset = "0x4AC32C")]
		private void <SetupAutoLoadModeDropdown>m__0(int mode)
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DemoUtils demoUtils;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject curtain;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject isAdRemovedInfo;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text defaultBannerNetworkText;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text defaultInterstitialNetworkText;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text defaultRewardedNetworkText;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Dropdown autoLoadModeDropdown;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x4AC2C4", Offset = "0x4AC2C4")]
		[SerializeField]
		private BannerSection bannerUI;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private InterstitialSection interstitialUI;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RewardedVideoSection rewardedVideoUI;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x68")]
		private AutoAdLoadingMode lastAutoLoadMode;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x20003E6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC33C", Offset = "0x4AC33C")]
		private sealed class <OnInterstitialAdCompleted>c__AnonStorey1
		{
			// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E78")]
			[Address(RVA = "0x56EE00", Offset = "0x56EE00", VA = "0x56EE00")]
			public <OnInterstitialAdCompleted>c__AnonStorey1()
			{
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E79")]
			[Address(RVA = "0x56EE08", Offset = "0x56EE08", VA = "0x56EE08")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4001185")]
			[FieldOffset(Offset = "0x10")]
			internal InterstitialAdNetwork network;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4001186")]
			[FieldOffset(Offset = "0x18")]
			internal AdPlacement placement;
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x20003E7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC34C", Offset = "0x4AC34C")]
		private sealed class <OnRewardedAdCompleted>c__AnonStorey2
		{
			// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x56EF0C", Offset = "0x56EF0C", VA = "0x56EF0C")]
			public <OnRewardedAdCompleted>c__AnonStorey2()
			{
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E7B")]
			[Address(RVA = "0x56EF14", Offset = "0x56EF14", VA = "0x56EF14")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4001187")]
			[FieldOffset(Offset = "0x10")]
			internal RewardedAdNetwork network;

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4001188")]
			[FieldOffset(Offset = "0x18")]
			internal AdPlacement placement;
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x20003E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC35C", Offset = "0x4AC35C")]
		private sealed class <OnRewardedAdSkipped>c__AnonStorey3
		{
			// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E7C")]
			[Address(RVA = "0x56F018", Offset = "0x56F018", VA = "0x56F018")]
			public <OnRewardedAdSkipped>c__AnonStorey3()
			{
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E7D")]
			[Address(RVA = "0x56F020", Offset = "0x56F020", VA = "0x56F020")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x4001189")]
			[FieldOffset(Offset = "0x10")]
			internal RewardedAdNetwork network;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400118A")]
			[FieldOffset(Offset = "0x18")]
			internal AdPlacement placement;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x20003E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC36C", Offset = "0x4AC36C")]
		private sealed class <DelayCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x724EB4", Offset = "0x724EB4", VA = "0x724EB4")]
			[DebuggerHidden]
			public <DelayCoroutine>c__Iterator0()
			{
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002088 File Offset: 0x00000288
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x724F34", Offset = "0x724F34", VA = "0x724F34", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049A")]
			private object Current
			{
				[Token(Token = "0x6001E80")]
				[Address(RVA = "0x725030", Offset = "0x725030", VA = "0x725030", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049B")]
			private object Current
			{
				[Token(Token = "0x6001E81")]
				[Address(RVA = "0x725038", Offset = "0x725038", VA = "0x725038", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E82")]
			[Address(RVA = "0x725040", Offset = "0x725040", VA = "0x725040", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0x725054", Offset = "0x725054", VA = "0x725054", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400118B")]
			[FieldOffset(Offset = "0x10")]
			internal float time;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400118C")]
			[FieldOffset(Offset = "0x18")]
			internal Action action;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400118D")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400118E")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x400118F")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}
	}
}
