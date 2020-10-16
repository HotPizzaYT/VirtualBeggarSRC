using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x2000039")]
	public class TicTacToeGameControl : GameServicesDemo_Multiplayer_BaseControl
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5A1C04", Offset = "0x5A1C04", VA = "0x5A1C04")]
		public TicTacToeGameControl()
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public bool CanMove
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x5A1C0C", Offset = "0x5A1C0C", VA = "0x5A1C0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x5A1C40", Offset = "0x5A1C40", VA = "0x5A1C40")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public bool IsMatchDelegateRegistered
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x5A1C4C", Offset = "0x5A1C4C", VA = "0x5A1C4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE00", Offset = "0x4AEE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x5A1C54", Offset = "0x5A1C54", VA = "0x5A1C54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE10", Offset = "0x4AEE10")]
			private set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002EF RID: 751 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x1700006D")]
		protected override MatchType MatchType
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x5A1C60", Offset = "0x5A1C60", VA = "0x5A1C60", Slot = "8")]
			get
			{
				return MatchType.RealTime;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5A1C68", Offset = "0x5A1C68", VA = "0x5A1C68", Slot = "11")]
		protected override void LateStart()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5A1D94", Offset = "0x5A1D94", VA = "0x5A1D94", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5A1FB4", Offset = "0x5A1FB4", VA = "0x5A1FB4", Slot = "4")]
		protected override void CreateQuickMatch()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5A21F0", Offset = "0x5A21F0", VA = "0x5A21F0", Slot = "5")]
		protected override void CreateWithMatchmaker()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5A23CC", Offset = "0x5A23CC", VA = "0x5A23CC", Slot = "6")]
		protected override void AcceptInvitation(Invitation invitation)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5A2500", Offset = "0x5A2500", VA = "0x5A2500", Slot = "7")]
		protected override void DeclineInvitation(Invitation invitation)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5A20A4", Offset = "0x5A20A4", VA = "0x5A20A4")]
		public void CreateQuickMatch(int size)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5A222C", Offset = "0x5A222C", VA = "0x5A222C")]
		public void CreateWithMatchmakerUI(int size)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5A26B0", Offset = "0x5A26B0", VA = "0x5A26B0")]
		public void ShowMatchesUI()
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x5A1C6C", Offset = "0x5A1C6C", VA = "0x5A1C6C")]
		public void RegisterMatchDelegate()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x5A2788", Offset = "0x5A2788", VA = "0x5A2788")]
		public void Move(int x, int y, Action<TicTacToeGameModel.Mark> successCallback)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x5A34E4", Offset = "0x5A34E4", VA = "0x5A34E4")]
		public void SwitchTurn(int x, int y, Action<TicTacToeGameModel.Mark> successCallback)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5A3B94", Offset = "0x5A3B94", VA = "0x5A3B94")]
		public void LeaveMatch()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5A3EE0", Offset = "0x5A3EE0", VA = "0x5A3EE0")]
		public void Rematch()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x5A4044", Offset = "0x5A4044", VA = "0x5A4044")]
		private void OnMatchReceived(TurnBasedMatch match, bool autoLaunch, bool playerWantsToQuit)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x5A44CC", Offset = "0x5A44CC", VA = "0x5A44CC")]
		private void CheckAndPlayMatch(TurnBasedMatch match, bool playerWantsToQuit, int boardSize)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x5A30D4", Offset = "0x5A30D4", VA = "0x5A30D4")]
		private void EndGame(MatchOutcome.ParticipantResult localPlayerResult, MatchOutcome.ParticipantResult opponentResult, int x, int y, Action<TicTacToeGameModel.Mark> successCallback)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x5A56D0", Offset = "0x5A56D0", VA = "0x5A56D0")]
		private string GetResultMessage(bool flag)
		{
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5A37BC", Offset = "0x5A37BC", VA = "0x5A37BC")]
		private TicTacToeGameModel.Mark GetOppositeMark(TicTacToeGameModel.Mark mark)
		{
			return TicTacToeGameModel.Mark.X;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x5A25E0", Offset = "0x5A25E0", VA = "0x5A25E0")]
		private MatchRequest GetMatchRequest(int size)
		{
			return null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x5A572C", Offset = "0x5A572C", VA = "0x5A572C")]
		private void OnCreateQuickMatch(bool success, TurnBasedMatch match)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x5A5800", Offset = "0x5A5800", VA = "0x5A5800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE20", Offset = "0x4AEE20")]
		private static void <OnDestroy>m__0(TurnBasedMatch _, bool __, bool ___)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x5A5804", Offset = "0x5A5804", VA = "0x5A5804")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE30", Offset = "0x4AEE30")]
		private void <AcceptInvitation>m__1(bool flag, TurnBasedMatch match)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x5A589C", Offset = "0x5A589C", VA = "0x5A589C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE40", Offset = "0x4AEE40")]
		private static void <CreateWithMatchmakerUI>m__2()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x5A58A0", Offset = "0x5A58A0", VA = "0x5A58A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE50", Offset = "0x4AEE50")]
		private void <CreateWithMatchmakerUI>m__3(string error)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x5A590C", Offset = "0x5A590C", VA = "0x5A590C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE60", Offset = "0x4AEE60")]
		private void <LeaveMatch>m__4(bool flag)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x5A5BB8", Offset = "0x5A5BB8", VA = "0x5A5BB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE70", Offset = "0x4AEE70")]
		private void <LeaveMatch>m__5(bool flag)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x5A5D3C", Offset = "0x5A5D3C", VA = "0x5A5D3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE80", Offset = "0x4AEE80")]
		private void <Rematch>m__6(bool flag, TurnBasedMatch match)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x5A5DDC", Offset = "0x5A5DDC", VA = "0x5A5DDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEE90", Offset = "0x4AEE90")]
		private static string <CheckAndPlayMatch>m__7(Participant p)
		{
			return null;
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TicTacToeGameView view;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0xB0")]
		private TicTacToeGameModel model;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0xB8")]
		private bool canMove;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0xB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AED94", Offset = "0x4AED94")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AED94", Offset = "0x4AED94")]
		private bool <IsMatchDelegateRegistered>k__BackingField;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEDD0", Offset = "0x4AEDD0")]
		private static MatchDelegate <>f__am$cache0;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEDE0", Offset = "0x4AEDE0")]
		private static Action <>f__am$cache1;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEDF0", Offset = "0x4AEDF0")]
		private static Func<Participant, string> <>f__am$cache2;

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x20003FE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEEA0", Offset = "0x4AEEA0")]
		private sealed class <SwitchTurn>c__AnonStorey0
		{
			// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED7")]
			[Address(RVA = "0x5A37B4", Offset = "0x5A37B4", VA = "0x5A37B4")]
			public <SwitchTurn>c__AnonStorey0()
			{
			}

			// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x5A66CC", Offset = "0x5A66CC", VA = "0x5A66CC")]
			internal void <>m__0(bool success)
			{
			}

			// Token: 0x0400021A RID: 538
			[Token(Token = "0x40011EF")]
			[FieldOffset(Offset = "0x10")]
			internal int x;

			// Token: 0x0400021B RID: 539
			[Token(Token = "0x40011F0")]
			[FieldOffset(Offset = "0x14")]
			internal int y;

			// Token: 0x0400021C RID: 540
			[Token(Token = "0x40011F1")]
			[FieldOffset(Offset = "0x18")]
			internal Action<TicTacToeGameModel.Mark> successCallback;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x40011F2")]
			[FieldOffset(Offset = "0x20")]
			internal TicTacToeGameControl $this;
		}

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x20003FF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEEB0", Offset = "0x4AEEB0")]
		private sealed class <OnMatchReceived>c__AnonStorey1
		{
			// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED9")]
			[Address(RVA = "0x5A446C", Offset = "0x5A446C", VA = "0x5A446C")]
			public <OnMatchReceived>c__AnonStorey1()
			{
			}

			// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x5A6678", Offset = "0x5A6678", VA = "0x5A6678")]
			internal void <>m__0(bool accept)
			{
			}

			// Token: 0x0400021E RID: 542
			[Token(Token = "0x40011F3")]
			[FieldOffset(Offset = "0x10")]
			internal TurnBasedMatch match;

			// Token: 0x0400021F RID: 543
			[Token(Token = "0x40011F4")]
			[FieldOffset(Offset = "0x18")]
			internal bool playerWantsToQuit;

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x40011F5")]
			[FieldOffset(Offset = "0x1C")]
			internal int boardSize;

			// Token: 0x04000221 RID: 545
			[Token(Token = "0x40011F6")]
			[FieldOffset(Offset = "0x20")]
			internal TicTacToeGameControl $this;
		}

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEEC0", Offset = "0x4AEEC0")]
		private sealed class <CheckAndPlayMatch>c__AnonStorey2
		{
			// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x5A4FE0", Offset = "0x5A4FE0", VA = "0x5A4FE0")]
			public <CheckAndPlayMatch>c__AnonStorey2()
			{
			}

			// Token: 0x06000312 RID: 786 RVA: 0x00002A18 File Offset: 0x00000C18
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x5A5E0C", Offset = "0x5A5E0C", VA = "0x5A5E0C")]
			internal bool <>m__0(Participant p)
			{
				return default(bool);
			}

			// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EDD")]
			[Address(RVA = "0x5A5F40", Offset = "0x5A5F40", VA = "0x5A5F40")]
			internal void <>m__1(bool flag)
			{
			}

			// Token: 0x06000314 RID: 788 RVA: 0x00002A30 File Offset: 0x00000C30
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x5A6140", Offset = "0x5A6140", VA = "0x5A6140")]
			internal bool <>m__2(Participant p)
			{
				return default(bool);
			}

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x40011F7")]
			[FieldOffset(Offset = "0x10")]
			internal TurnBasedMatch match;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x40011F8")]
			[FieldOffset(Offset = "0x18")]
			internal TicTacToeGameControl $this;
		}

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000401")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEED0", Offset = "0x4AEED0")]
		private sealed class <EndGame>c__AnonStorey3
		{
			// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EDF")]
			[Address(RVA = "0x5A56B4", Offset = "0x5A56B4", VA = "0x5A56B4")]
			public <EndGame>c__AnonStorey3()
			{
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x5A61FC", Offset = "0x5A61FC", VA = "0x5A61FC")]
			internal void <>m__0(bool success)
			{
			}

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x40011F9")]
			[FieldOffset(Offset = "0x10")]
			internal int x;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x40011FA")]
			[FieldOffset(Offset = "0x14")]
			internal int y;

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x40011FB")]
			[FieldOffset(Offset = "0x18")]
			internal MatchOutcome.ParticipantResult localPlayerResult;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x40011FC")]
			[FieldOffset(Offset = "0x20")]
			internal Action<TicTacToeGameModel.Mark> successCallback;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x40011FD")]
			[FieldOffset(Offset = "0x28")]
			internal TicTacToeGameControl $this;
		}
	}
}
