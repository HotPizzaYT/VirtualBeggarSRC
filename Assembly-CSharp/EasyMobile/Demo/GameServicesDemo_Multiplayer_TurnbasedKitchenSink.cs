using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x2000021")]
	public class GameServicesDemo_Multiplayer_TurnbasedKitchenSink : GameServicesDemo_Multiplayer_BaseControl
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x57EC14", Offset = "0x57EC14", VA = "0x57EC14")]
		public GameServicesDemo_Multiplayer_TurnbasedKitchenSink()
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public uint Variant
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x57EC98", Offset = "0x57EC98", VA = "0x57EC98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA68", Offset = "0x4ADA68")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x57ECA0", Offset = "0x57ECA0", VA = "0x57ECA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA78", Offset = "0x4ADA78")]
			private set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public uint ExclusiveBitmask
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x57ECA8", Offset = "0x57ECA8", VA = "0x57ECA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA88", Offset = "0x4ADA88")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x57ECB0", Offset = "0x57ECB0", VA = "0x57ECB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA98", Offset = "0x4ADA98")]
			private set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public uint MinPlayers
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x57ECB8", Offset = "0x57ECB8", VA = "0x57ECB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAA8", Offset = "0x4ADAA8")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x57ECC0", Offset = "0x57ECC0", VA = "0x57ECC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAB8", Offset = "0x4ADAB8")]
			private set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public uint MaxPlayers
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x57ECC8", Offset = "0x57ECC8", VA = "0x57ECC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAC8", Offset = "0x4ADAC8")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x57ECD0", Offset = "0x57ECD0", VA = "0x57ECD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAD8", Offset = "0x4ADAD8")]
			private set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public uint MaxPlayersAllowed
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x57ECD8", Offset = "0x57ECD8", VA = "0x57ECD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAE8", Offset = "0x4ADAE8")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x57ECE0", Offset = "0x57ECE0", VA = "0x57ECE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADAF8", Offset = "0x4ADAF8")]
			private set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		public bool IsMatchDelegateRegistered
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x57ECE8", Offset = "0x57ECE8", VA = "0x57ECE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB08", Offset = "0x4ADB08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x57ECF0", Offset = "0x57ECF0", VA = "0x57ECF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB18", Offset = "0x4ADB18")]
			private set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public TurnBasedMatch CurrentMatch
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x57ECFC", Offset = "0x57ECFC", VA = "0x57ECFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB28", Offset = "0x4ADB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x57ED04", Offset = "0x57ED04", VA = "0x57ED04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB38", Offset = "0x4ADB38")]
			private set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000039")]
		public GameServicesDemo_Multiplayer_TurnbasedKitchenSink.MatchData CurrentMatchData
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x57ED0C", Offset = "0x57ED0C", VA = "0x57ED0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB48", Offset = "0x4ADB48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x57ED14", Offset = "0x57ED14", VA = "0x57ED14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB58", Offset = "0x4ADB58")]
			private set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public Participant[] CurrentOpponents
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x57ED1C", Offset = "0x57ED1C", VA = "0x57ED1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB68", Offset = "0x4ADB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x57ED24", Offset = "0x57ED24", VA = "0x57ED24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB78", Offset = "0x4ADB78")]
			private set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x1700003B")]
		public bool IsMyTurn
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x57ED2C", Offset = "0x57ED2C", VA = "0x57ED2C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003C")]
		public Participant SelectedParticipant
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x57ED70", Offset = "0x57ED70", VA = "0x57ED70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x1700003D")]
		public bool AllOpponensLeft
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x57EE28", Offset = "0x57EE28", VA = "0x57EE28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x1700003E")]
		public bool SelectedParticipantLeftMatch
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x57EF30", Offset = "0x57EF30", VA = "0x57EF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003F")]
		public MatchRequest MatchRequest
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x57EF8C", Offset = "0x57EF8C", VA = "0x57EF8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x17000040")]
		public bool CanRematch
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x57F0A0", Offset = "0x57F0A0", VA = "0x57F0A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x17000041")]
		protected override MatchType MatchType
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x57F0D0", Offset = "0x57F0D0", VA = "0x57F0D0", Slot = "8")]
			get
			{
				return MatchType.RealTime;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x57F0D8", Offset = "0x57F0D8", VA = "0x57F0D8", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x58034C", Offset = "0x58034C", VA = "0x58034C", Slot = "11")]
		protected override void LateStart()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x580650", Offset = "0x580650", VA = "0x580650", Slot = "14")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5806EC", Offset = "0x5806EC", VA = "0x5806EC", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x58085C", Offset = "0x58085C", VA = "0x58085C", Slot = "4")]
		protected override void CreateQuickMatch()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x5809AC", Offset = "0x5809AC", VA = "0x5809AC", Slot = "5")]
		protected override void CreateWithMatchmaker()
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x580B70", Offset = "0x580B70", VA = "0x580B70", Slot = "6")]
		protected override void AcceptInvitation(Invitation invitation)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x580CAC", Offset = "0x580CAC", VA = "0x580CAC", Slot = "7")]
		protected override void DeclineInvitation(Invitation invitation)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x580D94", Offset = "0x580D94", VA = "0x580D94")]
		public void GetAllMatches()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x580EC0", Offset = "0x580EC0", VA = "0x580EC0")]
		public void ShowMatchesUI()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x580FA0", Offset = "0x580FA0", VA = "0x580FA0")]
		public void TakeTurn()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x581400", Offset = "0x581400", VA = "0x581400")]
		public void Finish()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x581AD0", Offset = "0x581AD0", VA = "0x581AD0")]
		public void LeaveMatch()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x581D30", Offset = "0x581D30", VA = "0x581D30")]
		public void Rematch()
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x581EB8", Offset = "0x581EB8", VA = "0x581EB8")]
		public void AcknowledgeFinishedMatch()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5804F8", Offset = "0x5804F8", VA = "0x5804F8")]
		public void RegisterMatchDelegate()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x582008", Offset = "0x582008", VA = "0x582008")]
		public void ShowVariantHint()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x582064", Offset = "0x582064", VA = "0x582064")]
		public void ShowExclusiveBitmaskHint()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5820C0", Offset = "0x5820C0", VA = "0x5820C0")]
		public void ShowMinPlayersHint()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x58211C", Offset = "0x58211C", VA = "0x58211C")]
		public void ShowMaxPlayersHint()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x582178", Offset = "0x582178", VA = "0x582178")]
		public void ShowCreateQuickMatchHint()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5821D4", Offset = "0x5821D4", VA = "0x5821D4")]
		public void ShowCreateWithmatchmakerHint()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x582230", Offset = "0x582230", VA = "0x582230")]
		public void ShowTakeTurnHint()
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x58228C", Offset = "0x58228C", VA = "0x58228C")]
		public void ShowFinishHint()
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5822E8", Offset = "0x5822E8", VA = "0x5822E8")]
		public void ShowAcknowledgeMatchHint()
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x582344", Offset = "0x582344", VA = "0x582344")]
		public void ShowLeaveHint()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5823A0", Offset = "0x5823A0", VA = "0x5823A0")]
		public void ShowRematchHint()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5823FC", Offset = "0x5823FC", VA = "0x5823FC")]
		public void ShowShowMatchesUIHint()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x582458", Offset = "0x582458", VA = "0x582458")]
		public void ShowGetAllMatchesHint()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x5824B4", Offset = "0x5824B4", VA = "0x5824B4")]
		public void ShowRegisterMatchDelegateHint()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x582510", Offset = "0x582510", VA = "0x582510")]
		public void ShowNextParticipantHint()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x58256C", Offset = "0x58256C", VA = "0x58256C")]
		private void OnMatchReceived(TurnBasedMatch match, bool autoLaunch, bool playerWantsToQuit)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x583430", Offset = "0x583430", VA = "0x583430")]
		private void OnCreateQuickMatch(bool success, TurnBasedMatch match)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x583510", Offset = "0x583510", VA = "0x583510")]
		private void OnGetAllMatches(TurnBasedMatch[] matches)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x582F3C", Offset = "0x582F3C", VA = "0x582F3C")]
		private void CheckAndPlayMatch(TurnBasedMatch match, bool playerWantsToQuit)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x57F10C", Offset = "0x57F10C", VA = "0x57F10C")]
		private void RefreshParticipantsDropDown()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x583E78", Offset = "0x583E78", VA = "0x583E78")]
		private void ShowMatchInfo()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x583F00", Offset = "0x583F00", VA = "0x583F00")]
		private void ShowMatchData()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x5840AC", Offset = "0x5840AC", VA = "0x5840AC")]
		private void ShowSelfInfo()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x584140", Offset = "0x584140", VA = "0x584140")]
		private void ShowOpponentsInfo()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x584320", Offset = "0x584320", VA = "0x584320")]
		private void ShowNextParticipantDetails()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x5835B0", Offset = "0x5835B0", VA = "0x5835B0")]
		private void ShowAllMatchesPanel(TurnBasedMatch[] matches)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5843B8", Offset = "0x5843B8", VA = "0x5843B8")]
		private void HideAllMatchesPanel()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x57F40C", Offset = "0x57F40C", VA = "0x57F40C")]
		private void InitButtons()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x580028", Offset = "0x580028", VA = "0x580028")]
		private void InitInputFields()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x584550", Offset = "0x584550", VA = "0x584550")]
		private void OnVariantInputChanged(string value)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x584640", Offset = "0x584640", VA = "0x584640")]
		private void OnExclusiveBitmaskInputChanged(string value)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5846EC", Offset = "0x5846EC", VA = "0x5846EC")]
		private void OnMinPlayersInputChanged(string value)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x584880", Offset = "0x584880", VA = "0x584880")]
		private void OnMaxPlayersInputChanged(string value)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x581A04", Offset = "0x581A04", VA = "0x581A04")]
		private Action<bool> GetAlertCallbackAction(string successMessage, string failedMessage)
		{
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5849A4", Offset = "0x5849A4", VA = "0x5849A4", Slot = "12")]
		public override void StartCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5849FC", Offset = "0x5849FC", VA = "0x5849FC", Slot = "13")]
		public override void StopCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x584A54", Offset = "0x584A54", VA = "0x584A54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB88", Offset = "0x4ADB88")]
		private static bool <get_AllOpponensLeft>m__0(Participant participant)
		{
			return default(bool);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x584AB8", Offset = "0x584AB8", VA = "0x584AB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADB98", Offset = "0x4ADB98")]
		private static void <OnDestroy>m__1(TurnBasedMatch _, bool __, bool ___)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x584ABC", Offset = "0x584ABC", VA = "0x584ABC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBA8", Offset = "0x4ADBA8")]
		private static void <CreateWithMatchmaker>m__2()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x584AC0", Offset = "0x584AC0", VA = "0x584AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBB8", Offset = "0x4ADBB8")]
		private static void <CreateWithMatchmaker>m__3(string error)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x584B54", Offset = "0x584B54", VA = "0x584B54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBC8", Offset = "0x4ADBC8")]
		private void <AcceptInvitation>m__4(bool flag, TurnBasedMatch match)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x584BEC", Offset = "0x584BEC", VA = "0x584BEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBD8", Offset = "0x4ADBD8")]
		private void <TakeTurn>m__5(bool success)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x584C7C", Offset = "0x584C7C", VA = "0x584C7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBE8", Offset = "0x4ADBE8")]
		private static string <Finish>m__6(Participant p)
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x584CAC", Offset = "0x584CAC", VA = "0x584CAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADBF8", Offset = "0x4ADBF8")]
		private void <Finish>m__7(bool success)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x584CB8", Offset = "0x584CB8", VA = "0x584CB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC08", Offset = "0x4ADC08")]
		private void <Rematch>m__8(bool success, TurnBasedMatch match)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x584D70", Offset = "0x584D70", VA = "0x584D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC18", Offset = "0x4ADC18")]
		private static string <OnMatchReceived>m__9(Participant p)
		{
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x584DA0", Offset = "0x584DA0", VA = "0x584DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC28", Offset = "0x4ADC28")]
		private bool <CheckAndPlayMatch>m__A(Participant p)
		{
			return default(bool);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x584E5C", Offset = "0x584E5C", VA = "0x584E5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC38", Offset = "0x4ADC38")]
		private bool <ShowOpponentsInfo>m__B(Participant p)
		{
			return default(bool);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x584F18", Offset = "0x584F18", VA = "0x584F18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC48", Offset = "0x4ADC48")]
		private string <ShowOpponentsInfo>m__C(Participant p)
		{
			return null;
		}

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000C8")]
		private const string VariantHint = "The match variant. The meaning of this parameter is defined by the game. It usually indicates a particular game type or mode(for example \"capture the flag\", \"first to 10 points\", etc). Setting this value to 0 (default) allows the player to be matched into any waiting match. Setting it to a nonzero number to match the player only with players whose match request shares the same variant number. This value must be between 1 and 1023 (inclusive).";

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000C9")]
		private const string ExclusiveBitmaskHint = "If your game has multiple player roles (such as farmer, archer, and wizard) and you want to restrict auto-matched games to one player of each role, add an exclusive bitmask to your match request.When auto-matching with this option, players will only be considered for a match when the logical AND of their exclusive bitmasks is equal to 0. In other words, this value represents the exclusive role the player making this request wants to play in the created match. If this value is 0 (default) it will be ignored. If you're creating a match with the standard matchmaker UI, this value will also be ignored.";

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000CA")]
		private const string MinPlayersHint = "The minimum number of players that may join the match, including the player who is making the match request. Must be at least 2 (default).";

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000CB")]
		private const string MaxPlayersHint = "The maximum number of players that may join the match, including the player who is making the match request. Must be equal or greater than \"minPlayers\" and may be no more than the maximum number of players allowed for the turnbased type. Default value is 2.";

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000CC")]
		private const string CreateQuickMatchHint = "Start a game with randomly selected opponent(s).";

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000CD")]
		private const string CreateWithMatchmakerUIHint = "Start a game with built-in invitation screen.";

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000CE")]
		private const string TakeTurnHint = "Take a turn.\n Choose the next participant to play in \"Next Participant\" above. If you choose \"Auto-match slot\" and there are automatch slots open, the turn will be passed to one of the automatch players. Choosing \"Auto-match slot\" when there are no open automatch slots is an error.";

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000CF")]
		private const string FinishHint = "Notify all the participants that the match is over.";

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000D0")]
		private const string LeaveMatchHint = "Call this method to leave the match.";

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000D1")]
		private const string AcknowledgeMatchHint = "Acknowledges that a match was finished. Call this on a finished match that you have just shown to the user, to acknowledge that the user has seen the results of the finished match. This will remove the match from the user's inbox.";

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000D2")]
		private const string RematchHint = "Request a rematch. This can be used on a finished match in order to start a new match with the same opponents.";

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000D3")]
		private const string ShowMatchesUIHint = "Show the standard UI where player can pick a match or accept an invitations.";

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000D4")]
		private const string GetAllMatchesHint = "Return all matches' data.";

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000D5")]
		private const string RegisterMatchDelegateHint = "Register a match delegate to be called when a match arrives. Matches may arrive as notifications on the device when it's the player's turn. If the match arrived via notification (this can be determined from the delegate's parameters), the recommended implementation is to take the player directly to the game screen so they can play their turn.";

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x40000D6")]
		private const string NextParticipantHint = "Pick next participant to pass the turn when calling \"Take Turn\" or \"Leave During Turn\".";

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x40000D7")]
		private const string MatchFinishedMessage = "Click the \"Acknowledge Finished Match\" button to call \"AcknowledgeFinished\" method to acknowledge that the user has seen the results of the finished match. This will remove the match from the user's inbox.";

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x40000D8")]
		private const string NullMatchMessage = "Please create a match first.";

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x40000D9")]
		private const string ExpiredMatchMessage = "[Google Play Games only]\nThe match expired. A match expires when a user does not respond to an invitation or turn notification for two weeks. A match also expires in one day if there is an empty auto-match slot available but Google Play games services cannot find a user to auto-match.";

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x40000DA")]
		private const string DeletedMatchMessage = " [Google Play Games only]\nThe match has been deleted.";

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x40000DB")]
		private const string CancelledMatchMessage = "[Google Play Games only]\nThe match was cancelled by one of the participants. This might occur, for example, if a user who was invited to the match declined the invitation or if a participant explicitly cancels the match. Google Play games services allows participants to cancel the match at any point after joining a match (if you game interface supports this action).";

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x40000DC")]
		private const string SelectedParticipantLeftMessage = "The selected participant has left the match, please choose a different one.";

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x40000DD")]
		private const string AllOpponentsLeftMessage = "All your opponent(s) had left the match.";

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button getAllMatchesButton;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button showMatchesUIButton;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button takeTurnButton;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button finishButton;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button acknowledgeMatchButton;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button leaveMatchButton;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Button rematchButton;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Button showMatchInfosButton;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Button showMatchDataButton;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Button showSelfInfosButton;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Button showOpponentsInfosButton;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Button showNextParticipantDetailsButton;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Button registerMatchDelegateButton;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField variantInputField;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private InputField exclusiveBitmaskInputField;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private InputField minPlayersInputField;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private InputField maxPlayersInputField;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Dropdown participantsDropdown;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Text maxDataSizeText;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject matchDelegateRegisteredUI;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject isMyTurnUI;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string matchDelegateRegisteredText;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Button variantHintButton;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Button bitmaskHintButton;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Button minPlayersHintButton;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Button maxPlayersHintButton;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Button createQuickMatchHintButton;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Button createWithMatchmakerUIHintButton;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Button takeTurnHintButton;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Button finishHintButton;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Button acknowledgeMatchHintButton;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private Button leaveMatchHintButton;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Button rematchHintButton;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Button showMatchesUIHintButton;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Button getAllMatchesHintButton;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private Button registerMatchDelegateHintButton;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Button nextParticipantHintButton;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x1D0")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x4AD784", Offset = "0x4AD784")]
		[SerializeField]
		private GameObject allMatchesRootPanel;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private Transform allMatchesContent;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private Button matchButton;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private Button hideAllMatchesPanelButton;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD7EC", Offset = "0x4AD7EC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD7EC", Offset = "0x4AD7EC")]
		private uint <Variant>k__BackingField;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x1F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD828", Offset = "0x4AD828")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD828", Offset = "0x4AD828")]
		private uint <ExclusiveBitmask>k__BackingField;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x1F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD864", Offset = "0x4AD864")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD864", Offset = "0x4AD864")]
		private uint <MinPlayers>k__BackingField;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x1FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD8A0", Offset = "0x4AD8A0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD8A0", Offset = "0x4AD8A0")]
		private uint <MaxPlayers>k__BackingField;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD8DC", Offset = "0x4AD8DC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD8DC", Offset = "0x4AD8DC")]
		private uint <MaxPlayersAllowed>k__BackingField;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x204")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD918", Offset = "0x4AD918")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD918", Offset = "0x4AD918")]
		private bool <IsMatchDelegateRegistered>k__BackingField;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x208")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD954", Offset = "0x4AD954")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD954", Offset = "0x4AD954")]
		private TurnBasedMatch <CurrentMatch>k__BackingField;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD990", Offset = "0x4AD990")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD990", Offset = "0x4AD990")]
		private GameServicesDemo_Multiplayer_TurnbasedKitchenSink.MatchData <CurrentMatchData>k__BackingField;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x218")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD9CC", Offset = "0x4AD9CC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD9CC", Offset = "0x4AD9CC")]
		private Participant[] <CurrentOpponents>k__BackingField;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x220")]
		private bool canTakeTurn;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x228")]
		private List<Button> createdMatchButtons;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x230")]
		private uint maxVariant;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA08", Offset = "0x4ADA08")]
		private static Func<Participant, bool> <>f__am$cache0;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA18", Offset = "0x4ADA18")]
		private static MatchDelegate <>f__am$cache1;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA28", Offset = "0x4ADA28")]
		private static Action <>f__am$cache2;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA38", Offset = "0x4ADA38")]
		private static Action<string> <>f__am$cache3;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA48", Offset = "0x4ADA48")]
		private static Func<Participant, string> <>f__am$cache4;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADA58", Offset = "0x4ADA58")]
		private static Func<Participant, string> <>f__am$cache5;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x2000022")]
		[Serializable]
		public class MatchData
		{
			// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x583E58", Offset = "0x583E58", VA = "0x583E58")]
			public MatchData()
			{
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00002538 File Offset: 0x00000738
			// (set) Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000042")]
			public int TurnCount
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x583E70", Offset = "0x583E70", VA = "0x583E70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADCD0", Offset = "0x4ADCD0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x583E60", Offset = "0x583E60", VA = "0x583E60")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADCE0", Offset = "0x4ADCE0")]
				set
				{
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000043")]
			public string WinnerName
			{
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0x583E68", Offset = "0x583E68", VA = "0x583E68")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADCF0", Offset = "0x4ADCF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001AF")]
				[Address(RVA = "0x5819FC", Offset = "0x5819FC", VA = "0x5819FC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADD00", Offset = "0x4ADD00")]
				set
				{
				}
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5811F8", Offset = "0x5811F8", VA = "0x5811F8")]
			public byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x583BAC", Offset = "0x583BAC", VA = "0x583BAC")]
			public static GameServicesDemo_Multiplayer_TurnbasedKitchenSink.MatchData FromByteArray(byte[] bytes)
			{
				return null;
			}

			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC58", Offset = "0x4ADC58")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ADC58", Offset = "0x4ADC58")]
			private int <TurnCount>k__BackingField;

			// Token: 0x04000144 RID: 324
			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADC94", Offset = "0x4ADC94")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ADC94", Offset = "0x4ADC94")]
			private string <WinnerName>k__BackingField;
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x20003F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADD10", Offset = "0x4ADD10")]
		private sealed class <LeaveMatch>c__AnonStorey0
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x581D28", Offset = "0x581D28", VA = "0x581D28")]
			public <LeaveMatch>c__AnonStorey0()
			{
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x584F9C", Offset = "0x584F9C", VA = "0x584F9C")]
			internal void <>m__0(int button)
			{
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x5852B0", Offset = "0x5852B0", VA = "0x5852B0")]
			internal void <>m__1(bool success)
			{
			}

			// Token: 0x04000145 RID: 325
			[Token(Token = "0x40011BB")]
			[FieldOffset(Offset = "0x10")]
			internal string id;

			// Token: 0x04000146 RID: 326
			[Token(Token = "0x40011BC")]
			[FieldOffset(Offset = "0x18")]
			internal GameServicesDemo_Multiplayer_TurnbasedKitchenSink $this;
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x20003F3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADD20", Offset = "0x4ADD20")]
		private sealed class <OnMatchReceived>c__AnonStorey1
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x582F34", Offset = "0x582F34", VA = "0x582F34")]
			public <OnMatchReceived>c__AnonStorey1()
			{
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00002550 File Offset: 0x00000750
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x5852E0", Offset = "0x5852E0", VA = "0x5852E0")]
			internal bool <>m__0(Participant p)
			{
				return default(bool);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x585414", Offset = "0x585414", VA = "0x585414")]
			internal void <>m__1(int button)
			{
			}

			// Token: 0x04000147 RID: 327
			[Token(Token = "0x40011BD")]
			[FieldOffset(Offset = "0x10")]
			internal TurnBasedMatch match;

			// Token: 0x04000148 RID: 328
			[Token(Token = "0x40011BE")]
			[FieldOffset(Offset = "0x18")]
			internal bool playerWantsToQuit;

			// Token: 0x04000149 RID: 329
			[Token(Token = "0x40011BF")]
			[FieldOffset(Offset = "0x20")]
			internal GameServicesDemo_Multiplayer_TurnbasedKitchenSink $this;
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x20003F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADD30", Offset = "0x4ADD30")]
		private sealed class <ShowAllMatchesPanel>c__AnonStorey2
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x5843B0", Offset = "0x5843B0", VA = "0x5843B0")]
			public <ShowAllMatchesPanel>c__AnonStorey2()
			{
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x585454", Offset = "0x585454", VA = "0x585454")]
			internal void <>m__0()
			{
			}

			// Token: 0x0400014A RID: 330
			[Token(Token = "0x40011C0")]
			[FieldOffset(Offset = "0x10")]
			internal TurnBasedMatch match;

			// Token: 0x0400014B RID: 331
			[Token(Token = "0x40011C1")]
			[FieldOffset(Offset = "0x18")]
			internal GameServicesDemo_Multiplayer_TurnbasedKitchenSink $this;
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x20003F5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADD40", Offset = "0x4ADD40")]
		private sealed class <GetAlertCallbackAction>c__AnonStorey3
		{
			// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x58499C", Offset = "0x58499C", VA = "0x58499C")]
			public <GetAlertCallbackAction>c__AnonStorey3()
			{
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x584F1C", Offset = "0x584F1C", VA = "0x584F1C")]
			internal void <>m__0(bool success)
			{
			}

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x40011C2")]
			[FieldOffset(Offset = "0x10")]
			internal string successMessage;

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x40011C3")]
			[FieldOffset(Offset = "0x18")]
			internal string failedMessage;
		}
	}
}
