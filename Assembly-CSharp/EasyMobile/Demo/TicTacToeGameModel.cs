using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace EasyMobile.Demo
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x200003A")]
	[Serializable]
	public class TicTacToeGameModel
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5A4FE8", Offset = "0x5A4FE8", VA = "0x5A4FE8")]
		public TicTacToeGameModel(TurnBasedMatch match, int size)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		public TicTacToeGameModel.TransferableDatas TransferDatas
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x5A2FA0", Offset = "0x5A2FA0", VA = "0x5A2FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEF94", Offset = "0x4AEF94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x5A6D70", Offset = "0x5A6D70", VA = "0x5A6D70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFA4", Offset = "0x4AEFA4")]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public TurnBasedMatch Match
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x5A1C38", Offset = "0x5A1C38", VA = "0x5A1C38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFB4", Offset = "0x4AEFB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x5A69D8", Offset = "0x5A69D8", VA = "0x5A69D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFC4", Offset = "0x4AEFC4")]
			private set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public TicTacToeGameModel.Mark LocalPlayerMark
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x5A6EC4", Offset = "0x5A6EC4", VA = "0x5A6EC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFD4", Offset = "0x4AEFD4")]
			get
			{
				return TicTacToeGameModel.Mark.X;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x5A6EBC", Offset = "0x5A6EBC", VA = "0x5A6EBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFE4", Offset = "0x4AEFE4")]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x17000071")]
		public TicTacToeGameModel.Mark OpponentMark
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x5A6ECC", Offset = "0x5A6ECC", VA = "0x5A6ECC")]
			get
			{
				return TicTacToeGameModel.Mark.X;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000072")]
		public Participant Opponent
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x5A3A38", Offset = "0x5A3A38", VA = "0x5A3A38")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000073")]
		public string OpponentId
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x5A3E8C", Offset = "0x5A3E8C", VA = "0x5A3E8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x17000074")]
		public MatchOutcome.ParticipantResult LocalFinalResult
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x5A60EC", Offset = "0x5A60EC", VA = "0x5A60EC")]
			get
			{
				return MatchOutcome.ParticipantResult.None;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x5A6EE4", Offset = "0x5A6EE4", VA = "0x5A6EE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x5A6D78", Offset = "0x5A6D78", VA = "0x5A6D78")]
		private TicTacToeGameModel.Mark CalculateLocalPlayerTurn()
		{
			return TicTacToeGameModel.Mark.X;
		}

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEEE0", Offset = "0x4AEEE0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEEE0", Offset = "0x4AEEE0")]
		private TicTacToeGameModel.TransferableDatas <TransferDatas>k__BackingField;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEF1C", Offset = "0x4AEF1C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEF1C", Offset = "0x4AEF1C")]
		private TurnBasedMatch <Match>k__BackingField;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEF58", Offset = "0x4AEF58")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEF58", Offset = "0x4AEF58")]
		private TicTacToeGameModel.Mark <LocalPlayerMark>k__BackingField;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x200003B")]
		public enum TileState
		{
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x40001C0")]
			Blank,
			// Token: 0x0400022E RID: 558
			[Token(Token = "0x40001C1")]
			X,
			// Token: 0x0400022F RID: 559
			[Token(Token = "0x40001C2")]
			O
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x200003C")]
		public enum Mark
		{
			// Token: 0x04000231 RID: 561
			[Token(Token = "0x40001C4")]
			X,
			// Token: 0x04000232 RID: 562
			[Token(Token = "0x40001C5")]
			O
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x200003D")]
		[Serializable]
		public class TransferableDatas
		{
			// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x5A69E0", Offset = "0x5A69E0", VA = "0x5A69E0")]
			public TransferableDatas(int size)
			{
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00002AA8 File Offset: 0x00000CA8
			// (set) Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000075")]
			public int Size
			{
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x5A30CC", Offset = "0x5A30CC", VA = "0x5A30CC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1B8", Offset = "0x4AF1B8")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60002BD")]
				[Address(RVA = "0x5A7198", Offset = "0x5A7198", VA = "0x5A7198")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1C8", Offset = "0x4AF1C8")]
				private set
				{
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000327 RID: 807 RVA: 0x00002AC0 File Offset: 0x00000CC0
			// (set) Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000076")]
			public int MoveCount
			{
				[Token(Token = "0x60002BE")]
				[Address(RVA = "0x5A34DC", Offset = "0x5A34DC", VA = "0x5A34DC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1D8", Offset = "0x4AF1D8")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60002BF")]
				[Address(RVA = "0x5A37D0", Offset = "0x5A37D0", VA = "0x5A37D0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1E8", Offset = "0x4AF1E8")]
				set
				{
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000329 RID: 809 RVA: 0x00002AD8 File Offset: 0x00000CD8
			// (set) Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000077")]
			public bool IsGameOver
			{
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0x5A2FA8", Offset = "0x5A2FA8", VA = "0x5A2FA8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1F8", Offset = "0x4AF1F8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002C1")]
				[Address(RVA = "0x5A56BC", Offset = "0x5A56BC", VA = "0x5A56BC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF208", Offset = "0x4AF208")]
				set
				{
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000078")]
			public TicTacToeGameModel.TileState[][] Board
			{
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0x5A302C", Offset = "0x5A302C", VA = "0x5A302C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF218", Offset = "0x4AF218")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x5A71A0", Offset = "0x5A71A0", VA = "0x5A71A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF228", Offset = "0x4AF228")]
				private set
				{
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00002AF0 File Offset: 0x00000CF0
			// (set) Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000079")]
			public TicTacToeGameModel.Mark CurrentTurn
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x5A3034", Offset = "0x5A3034", VA = "0x5A3034")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF238", Offset = "0x4AF238")]
				get
				{
					return TicTacToeGameModel.Mark.X;
				}
				[Token(Token = "0x60002C5")]
				[Address(RVA = "0x5A37C8", Offset = "0x5A37C8", VA = "0x5A37C8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF248", Offset = "0x4AF248")]
				set
				{
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600032F RID: 815 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007A")]
			public MatchOutcome FinalResult
			{
				[Token(Token = "0x60002C6")]
				[Address(RVA = "0x5A6EDC", Offset = "0x5A6EDC", VA = "0x5A6EDC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF258", Offset = "0x4AF258")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002C7")]
				[Address(RVA = "0x5A56C8", Offset = "0x5A56C8", VA = "0x5A56C8")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF268", Offset = "0x4AF268")]
				set
				{
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000331 RID: 817 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007B")]
			public string XPlayerId
			{
				[Token(Token = "0x60002C8")]
				[Address(RVA = "0x5A7188", Offset = "0x5A7188", VA = "0x5A7188")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF278", Offset = "0x4AF278")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x5A7190", Offset = "0x5A7190", VA = "0x5A7190")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF288", Offset = "0x4AF288")]
				set
				{
				}
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x5A3830", Offset = "0x5A3830", VA = "0x5A3830")]
			public byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x5A71A8", Offset = "0x5A71A8", VA = "0x5A71A8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x5A6B58", Offset = "0x5A6B58", VA = "0x5A6B58")]
			public static TicTacToeGameModel.TransferableDatas FromByteArray(byte[] bytes)
			{
				return null;
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x5A7640", Offset = "0x5A7640", VA = "0x5A7640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF298", Offset = "0x4AF298")]
			private static IEnumerable<TicTacToeGameModel.TileState> <ToString>m__0(TicTacToeGameModel.TileState[] ar)
			{
				return null;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x5A7648", Offset = "0x5A7648", VA = "0x5A7648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF2A8", Offset = "0x4AF2A8")]
			private static string <ToString>m__1(TicTacToeGameModel.TileState t)
			{
				return null;
			}

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEFF4", Offset = "0x4AEFF4")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEFF4", Offset = "0x4AEFF4")]
			private int <Size>k__BackingField;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF030", Offset = "0x4AF030")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF030", Offset = "0x4AF030")]
			private int <MoveCount>k__BackingField;

			// Token: 0x04000235 RID: 565
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF06C", Offset = "0x4AF06C")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF06C", Offset = "0x4AF06C")]
			private bool <IsGameOver>k__BackingField;

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF0A8", Offset = "0x4AF0A8")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF0A8", Offset = "0x4AF0A8")]
			private TicTacToeGameModel.TileState[][] <Board>k__BackingField;

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF0E4", Offset = "0x4AF0E4")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF0E4", Offset = "0x4AF0E4")]
			private TicTacToeGameModel.Mark <CurrentTurn>k__BackingField;

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF120", Offset = "0x4AF120")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF120", Offset = "0x4AF120")]
			private MatchOutcome <FinalResult>k__BackingField;

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF15C", Offset = "0x4AF15C")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF15C", Offset = "0x4AF15C")]
			private string <XPlayerId>k__BackingField;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF198", Offset = "0x4AF198")]
			private static Func<TicTacToeGameModel.TileState[], IEnumerable<TicTacToeGameModel.TileState>> <>f__am$cache0;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF1A8", Offset = "0x4AF1A8")]
			private static Func<TicTacToeGameModel.TileState, string> <>f__am$cache1;
		}
	}
}
