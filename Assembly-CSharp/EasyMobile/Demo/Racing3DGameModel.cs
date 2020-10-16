using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200002A")]
	public class Racing3DGameModel
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x599550", Offset = "0x599550", VA = "0x599550")]
		public Racing3DGameModel(string selfId, string opponentId)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public string SelfId
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x59CD00", Offset = "0x59CD00", VA = "0x59CD00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE93C", Offset = "0x4AE93C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x59CCF0", Offset = "0x59CCF0", VA = "0x59CCF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE94C", Offset = "0x4AE94C")]
			private set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public string OpponentId
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x59BF60", Offset = "0x59BF60", VA = "0x59BF60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE95C", Offset = "0x4AE95C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x59CCF8", Offset = "0x59CCF8", VA = "0x59CCF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE96C", Offset = "0x4AE96C")]
			private set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public List<Vector3> PowerUpsPosition
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x598A6C", Offset = "0x598A6C", VA = "0x598A6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE97C", Offset = "0x4AE97C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x599DB8", Offset = "0x599DB8", VA = "0x599DB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE98C", Offset = "0x4AE98C")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public List<Vector3> SideObjectsPosition
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x598A74", Offset = "0x598A74", VA = "0x598A74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE99C", Offset = "0x4AE99C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x59A3B4", Offset = "0x59A3B4", VA = "0x59A3B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9AC", Offset = "0x4AE9AC")]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x1700005A")]
		public bool IsHost
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x597A70", Offset = "0x597A70", VA = "0x597A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x598A7C", Offset = "0x598A7C", VA = "0x598A7C")]
		public byte[] CreateStartGameMessage()
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x598C6C", Offset = "0x598C6C", VA = "0x598C6C")]
		public byte[] CreateReadyMessage()
		{
			return null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x598388", Offset = "0x598388", VA = "0x598388")]
		public byte[] CreateMoveMessage(Racing3DGameModel.MoveDirections direction)
		{
			return null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x5986D8", Offset = "0x5986D8", VA = "0x5986D8")]
		public byte[] CreateUseNitroMessage()
		{
			return null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x598534", Offset = "0x598534", VA = "0x598534")]
		public byte[] CreateHitPowerUpMessage()
		{
			return null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x59887C", Offset = "0x59887C", VA = "0x59887C")]
		public byte[] CreateFinishRaceMessage()
		{
			return null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x598E10", Offset = "0x598E10", VA = "0x598E10")]
		public byte[] CreateRematchRequestMessage()
		{
			return null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x598FBC", Offset = "0x598FBC", VA = "0x598FBC")]
		public byte[] CreateRematchReponseMessage(bool accepted)
		{
			return null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x59AC50", Offset = "0x59AC50", VA = "0x59AC50")]
		public Racing3DGameModel.RealtimeMultiplayerMessage FromByteArray(byte[] bytes)
		{
			return null;
		}

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE84C", Offset = "0x4AE84C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE84C", Offset = "0x4AE84C")]
		private string <SelfId>k__BackingField;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE888", Offset = "0x4AE888")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE888", Offset = "0x4AE888")]
		private string <OpponentId>k__BackingField;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE8C4", Offset = "0x4AE8C4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE8C4", Offset = "0x4AE8C4")]
		private List<Vector3> <PowerUpsPosition>k__BackingField;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE900", Offset = "0x4AE900")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE900", Offset = "0x4AE900")]
		private List<Vector3> <SideObjectsPosition>k__BackingField;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x200002B")]
		public enum MessageTypes
		{
			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x4000181")]
			None,
			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x4000182")]
			StartGame,
			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x4000183")]
			Ready,
			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x4000184")]
			Move,
			// Token: 0x040001DA RID: 474
			[Token(Token = "0x4000185")]
			UseNitro,
			// Token: 0x040001DB RID: 475
			[Token(Token = "0x4000186")]
			HitPowerUp,
			// Token: 0x040001DC RID: 476
			[Token(Token = "0x4000187")]
			FinishRace,
			// Token: 0x040001DD RID: 477
			[Token(Token = "0x4000188")]
			RematchRequest,
			// Token: 0x040001DE RID: 478
			[Token(Token = "0x4000189")]
			RematchResponse
		}

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x200002C")]
		public enum MoveDirections
		{
			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x400018B")]
			Left,
			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x400018C")]
			Right
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x200002D")]
		public enum GameoverReason
		{
			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x400018E")]
			None,
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x400018F")]
			FinishRace,
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x4000190")]
			OpponentFinishRace,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x4000191")]
			HitPowerUp,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x4000192")]
			OpponentHitPowerUp,
			// Token: 0x040001E8 RID: 488
			[Token(Token = "0x4000193")]
			OpponentLeftRoom
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x200002E")]
		[Serializable]
		public abstract class RealtimeMultiplayerMessage
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x59CEE0", Offset = "0x59CEE0", VA = "0x59CEE0")]
			protected RealtimeMultiplayerMessage()
			{
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060002A2 RID: 674
			[Token(Token = "0x1700005B")]
			public abstract Racing3DGameModel.MessageTypes Type { [Token(Token = "0x6000249")] get; }

			// Token: 0x060002A3 RID: 675
			[Token(Token = "0x600024A")]
			public abstract byte[] ToByteArray();
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x200002F")]
		[Serializable]
		public class StartGameMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x59CD08", Offset = "0x59CD08", VA = "0x59CD08")]
			public StartGameMessage(List<Vector3> powerUpsPosition, List<Vector3> sideObjectsPosition)
			{
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002808 File Offset: 0x00000A08
			[Token(Token = "0x1700005C")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x600024C")]
				[Address(RVA = "0x59D314", Offset = "0x59D314", VA = "0x59D314", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060002A6 RID: 678 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005D")]
			public List<Vector3> PowerUpsPosition
			{
				[Token(Token = "0x600024D")]
				[Address(RVA = "0x59B130", Offset = "0x59B130", VA = "0x59B130")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700005E")]
			public List<Vector3> SideObjectsPosition
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0x59B210", Offset = "0x59B210", VA = "0x59B210")]
				get
				{
					return null;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x59D31C", Offset = "0x59D31C", VA = "0x59D31C", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00002820 File Offset: 0x00000A20
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x59D490", Offset = "0x59D490", VA = "0x59D490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9DC", Offset = "0x4AE9DC")]
			private static Vector3 <get_PowerUpsPosition>m__0(Racing3DGameModel.SerializableVector3 v)
			{
				return default(Vector3);
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00002838 File Offset: 0x00000A38
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x59D4C4", Offset = "0x59D4C4", VA = "0x59D4C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9EC", Offset = "0x4AE9EC")]
			private static Vector3 <get_SideObjectsPosition>m__1(Racing3DGameModel.SerializableVector3 v)
			{
				return default(Vector3);
			}

			// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x59D4F8", Offset = "0x59D4F8", VA = "0x59D4F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9FC", Offset = "0x4AE9FC")]
			private void <StartGameMessage>m__2(Vector3 op)
			{
			}

			// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x59D580", Offset = "0x59D580", VA = "0x59D580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEA0C", Offset = "0x4AEA0C")]
			private void <StartGameMessage>m__3(Vector3 op)
			{
			}

			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x10")]
			private List<Racing3DGameModel.SerializableVector3> powerUpsPosition;

			// Token: 0x040001EA RID: 490
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x18")]
			private List<Racing3DGameModel.SerializableVector3> sideObjectsPosition;

			// Token: 0x040001EB RID: 491
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9BC", Offset = "0x4AE9BC")]
			private static Func<Racing3DGameModel.SerializableVector3, Vector3> <>f__am$cache0;

			// Token: 0x040001EC RID: 492
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE9CC", Offset = "0x4AE9CC")]
			private static Func<Racing3DGameModel.SerializableVector3, Vector3> <>f__am$cache1;
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000030")]
		[Serializable]
		public class ReadyMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x59CE50", Offset = "0x59CE50", VA = "0x59CE50")]
			public ReadyMessage()
			{
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060002AE RID: 686 RVA: 0x00002850 File Offset: 0x00000A50
			[Token(Token = "0x1700005F")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000255")]
				[Address(RVA = "0x59D0E0", Offset = "0x59D0E0", VA = "0x59D0E0", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x59D0E8", Offset = "0x59D0E8", VA = "0x59D0E8", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000031")]
		[Serializable]
		public class MoveMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x59CE58", Offset = "0x59CE58", VA = "0x59CE58")]
			public MoveMessage(Racing3DGameModel.MoveDirections direction)
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002868 File Offset: 0x00000A68
			[Token(Token = "0x17000060")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000258")]
				[Address(RVA = "0x59D020", Offset = "0x59D020", VA = "0x59D020", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x00002880 File Offset: 0x00000A80
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000061")]
			public Racing3DGameModel.MoveDirections Direction
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x59B2F0", Offset = "0x59B2F0", VA = "0x59B2F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEA58", Offset = "0x4AEA58")]
				get
				{
					return Racing3DGameModel.MoveDirections.Left;
				}
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x59D018", Offset = "0x59D018", VA = "0x59D018")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEA68", Offset = "0x4AEA68")]
				private set
				{
				}
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x59D028", Offset = "0x59D028", VA = "0x59D028", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x040001ED RID: 493
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEA1C", Offset = "0x4AEA1C")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEA1C", Offset = "0x4AEA1C")]
			private Racing3DGameModel.MoveDirections <Direction>k__BackingField;
		}

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000032")]
		[Serializable]
		public class UseNitroMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x59CE84", Offset = "0x59CE84", VA = "0x59CE84")]
			public UseNitroMessage()
			{
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060002B6 RID: 694 RVA: 0x00002898 File Offset: 0x00000A98
			[Token(Token = "0x17000062")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x59D608", Offset = "0x59D608", VA = "0x59D608", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x59D610", Offset = "0x59D610", VA = "0x59D610", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000033")]
		[Serializable]
		public class HitPowerUpMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x59CE8C", Offset = "0x59CE8C", VA = "0x59CE8C")]
			public HitPowerUpMessage()
			{
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x000028B0 File Offset: 0x00000AB0
			[Token(Token = "0x17000063")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000260")]
				[Address(RVA = "0x59CF80", Offset = "0x59CF80", VA = "0x59CF80", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x59CF88", Offset = "0x59CF88", VA = "0x59CF88", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000034")]
		[Serializable]
		public class FinishRaceMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x59CE94", Offset = "0x59CE94", VA = "0x59CE94")]
			public FinishRaceMessage()
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060002BC RID: 700 RVA: 0x000028C8 File Offset: 0x00000AC8
			[Token(Token = "0x17000064")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x59CEE8", Offset = "0x59CEE8", VA = "0x59CEE8", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x59CEF0", Offset = "0x59CEF0", VA = "0x59CEF0", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x2000035")]
		[Serializable]
		public class RematchRequestchMessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x59CE9C", Offset = "0x59CE9C", VA = "0x59CE9C")]
			public RematchRequestchMessage()
			{
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060002BF RID: 703 RVA: 0x000028E0 File Offset: 0x00000AE0
			[Token(Token = "0x17000065")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000266")]
				[Address(RVA = "0x59D178", Offset = "0x59D178", VA = "0x59D178", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x59D180", Offset = "0x59D180", VA = "0x59D180", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}
		}

		// Token: 0x0200004B RID: 75
		[Token(Token = "0x2000036")]
		[Serializable]
		public class RematchResponseMaessage : Racing3DGameModel.RealtimeMultiplayerMessage
		{
			// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x59CEA4", Offset = "0x59CEA4", VA = "0x59CEA4")]
			public RematchResponseMaessage(bool accepted)
			{
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x000028F8 File Offset: 0x00000AF8
			[Token(Token = "0x17000066")]
			public override Racing3DGameModel.MessageTypes Type
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x59D210", Offset = "0x59D210", VA = "0x59D210", Slot = "4")]
				get
				{
					return Racing3DGameModel.MessageTypes.None;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002910 File Offset: 0x00000B10
			[Token(Token = "0x17000067")]
			public bool Accepted
			{
				[Token(Token = "0x600026A")]
				[Address(RVA = "0x59B448", Offset = "0x59B448", VA = "0x59B448")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x59D218", Offset = "0x59D218", VA = "0x59D218", Slot = "5")]
			public override byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x040001EE RID: 494
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x10")]
			private byte accepted;
		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x2000037")]
		[Serializable]
		public struct SerializableVector3
		{
			// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x59D2D0", Offset = "0x59D2D0", VA = "0x59D2D0")]
			public SerializableVector3(float x, float y, float z = 0f)
			{
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00002928 File Offset: 0x00000B28
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x59D2DC", Offset = "0x59D2DC", VA = "0x59D2DC")]
			public static explicit operator Vector3(Racing3DGameModel.SerializableVector3 sVector3)
			{
				return default(Vector3);
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00002940 File Offset: 0x00000B40
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x59D310", Offset = "0x59D310", VA = "0x59D310")]
			public static implicit operator Racing3DGameModel.SerializableVector3(Vector3 vector3)
			{
				return default(Racing3DGameModel.SerializableVector3);
			}

			// Token: 0x040001EF RID: 495
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x0")]
			public float x;

			// Token: 0x040001F0 RID: 496
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x4")]
			public float y;

			// Token: 0x040001F1 RID: 497
			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x8")]
			public float z;
		}
	}
}
