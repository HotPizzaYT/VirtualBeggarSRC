using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x200001F")]
	public class GameServicesDemo_Multiplayer_RealtimeKitchenSink : GameServicesDemo_Multiplayer_BaseControl, IRealTimeMultiplayerListener
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x579E8C", Offset = "0x579E8C", VA = "0x579E8C")]
		public GameServicesDemo_Multiplayer_RealtimeKitchenSink()
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public uint Variant
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x579F30", Offset = "0x579F30", VA = "0x579F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD2F0", Offset = "0x4AD2F0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x579F38", Offset = "0x579F38", VA = "0x579F38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD300", Offset = "0x4AD300")]
			private set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public uint ExclusiveBitmask
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x579F40", Offset = "0x579F40", VA = "0x579F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD310", Offset = "0x4AD310")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x579F48", Offset = "0x579F48", VA = "0x579F48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD320", Offset = "0x4AD320")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public uint MinPlayers
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x579F50", Offset = "0x579F50", VA = "0x579F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD330", Offset = "0x4AD330")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x579F58", Offset = "0x579F58", VA = "0x579F58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD340", Offset = "0x4AD340")]
			private set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public uint MaxPlayers
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x579F60", Offset = "0x579F60", VA = "0x579F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD350", Offset = "0x4AD350")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x579F68", Offset = "0x579F68", VA = "0x579F68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD360", Offset = "0x4AD360")]
			private set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public uint MaxPlayersAllowed
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x579F70", Offset = "0x579F70", VA = "0x579F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD370", Offset = "0x4AD370")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x579F78", Offset = "0x579F78", VA = "0x579F78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD380", Offset = "0x4AD380")]
			private set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public bool UseReliableMessage
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x579F80", Offset = "0x579F80", VA = "0x579F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD390", Offset = "0x4AD390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x579F88", Offset = "0x579F88", VA = "0x579F88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3A0", Offset = "0x4AD3A0")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public bool ShouldReInviteDisconnectedPlayer
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x579F94", Offset = "0x579F94", VA = "0x579F94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3B0", Offset = "0x4AD3B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x579F9C", Offset = "0x579F9C", VA = "0x579F9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3C0", Offset = "0x4AD3C0")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002C")]
		public MatchRequest MatchRequest
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x579FA8", Offset = "0x579FA8", VA = "0x579FA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002D")]
		public Participant TargetParticipant
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x57A0BC", Offset = "0x57A0BC", VA = "0x57A0BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x1700002E")]
		protected override MatchType MatchType
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x57A198", Offset = "0x57A198", VA = "0x57A198", Slot = "8")]
			get
			{
				return MatchType.RealTime;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x57A1A0", Offset = "0x57A1A0", VA = "0x57A1A0", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x57B2D4", Offset = "0x57B2D4", VA = "0x57B2D4", Slot = "11")]
		protected override void LateStart()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x57B304", Offset = "0x57B304", VA = "0x57B304", Slot = "22")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x57B4B4", Offset = "0x57B4B4", VA = "0x57B4B4", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x57B618", Offset = "0x57B618", VA = "0x57B618", Slot = "4")]
		protected override void CreateQuickMatch()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x57B730", Offset = "0x57B730", VA = "0x57B730", Slot = "5")]
		protected override void CreateWithMatchmaker()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x57B830", Offset = "0x57B830", VA = "0x57B830", Slot = "6")]
		protected override void AcceptInvitation(Invitation invitation)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x57B934", Offset = "0x57B934", VA = "0x57B934", Slot = "7")]
		protected override void DeclineInvitation(Invitation invitation)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x57BA1C", Offset = "0x57BA1C", VA = "0x57BA1C")]
		public void AcceptFromInbox()
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x57BB04", Offset = "0x57BB04", VA = "0x57BB04")]
		public void SendMessageToAll()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x57BE10", Offset = "0x57BE10", VA = "0x57BE10")]
		public void SendMessage()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x57BFA0", Offset = "0x57BFA0", VA = "0x57BFA0")]
		public void GetConnectedParticipants()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x57C1A0", Offset = "0x57C1A0", VA = "0x57C1A0")]
		public void GetSelf()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x57B538", Offset = "0x57B538", VA = "0x57B538")]
		public void LeaveRoom()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x57B3D4", Offset = "0x57B3D4", VA = "0x57B3D4")]
		public bool IsRoomConnected()
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x57C2A4", Offset = "0x57C2A4", VA = "0x57C2A4")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x57C38C", Offset = "0x57C38C", VA = "0x57C38C", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x57C440", Offset = "0x57C440", VA = "0x57C440", Slot = "17")]
		public void OnParticipantLeft(Participant participant)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x57C564", Offset = "0x57C564", VA = "0x57C564", Slot = "18")]
		public void OnPeersConnected(string[] participantIds)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x57CAEC", Offset = "0x57CAEC", VA = "0x57CAEC", Slot = "19")]
		public void OnPeersDisconnected(string[] participantIds)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x57CD2C", Offset = "0x57CD2C", VA = "0x57CD2C", Slot = "20")]
		public void OnRealTimeMessageReceived(string senderId, byte[] data)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x57D434", Offset = "0x57D434", VA = "0x57D434", Slot = "15")]
		public void OnRoomConnected(bool success)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x57D658", Offset = "0x57D658", VA = "0x57D658", Slot = "14")]
		public void OnRoomSetupProgress(float percent)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x57D748", Offset = "0x57D748", VA = "0x57D748", Slot = "21")]
		public bool ShouldReinviteDisconnectedPlayer(Participant participant)
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x57D750", Offset = "0x57D750", VA = "0x57D750")]
		public void ShowVariantHint()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x57D7AC", Offset = "0x57D7AC", VA = "0x57D7AC")]
		public void ShowExclusiveBitmaskHint()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x57D808", Offset = "0x57D808", VA = "0x57D808")]
		public void ShowMinPlayersHint()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x57D864", Offset = "0x57D864", VA = "0x57D864")]
		public void ShowMaxPlayersHint()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x57D8C0", Offset = "0x57D8C0", VA = "0x57D8C0")]
		public void ShowCreateQuickMatchHint()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x57D91C", Offset = "0x57D91C", VA = "0x57D91C")]
		public void ShowCreateWithmatchmakerHint()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x57D978", Offset = "0x57D978", VA = "0x57D978")]
		public void ShowAcceptFromInboxHint()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x57D9D4", Offset = "0x57D9D4", VA = "0x57D9D4")]
		public void ShowSendMessageHint()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x57DA30", Offset = "0x57DA30", VA = "0x57DA30")]
		public void ShowSendMessageToAllHint()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x57DA8C", Offset = "0x57DA8C", VA = "0x57DA8C")]
		public void ShowLeaveRoomHint()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x57DAE8", Offset = "0x57DAE8", VA = "0x57DAE8")]
		public void ShowSampleDataHint()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x57DB44", Offset = "0x57DB44", VA = "0x57DB44")]
		public void ShowUseReliableMessageHint()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x57DBA0", Offset = "0x57DBA0", VA = "0x57DBA0")]
		public void ShowShouldReinviteDisconnectedPlayerHint()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x57DBFC", Offset = "0x57DBFC", VA = "0x57DBFC")]
		public void ShowReceivedMessagesHint()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x57A318", Offset = "0x57A318", VA = "0x57A318")]
		private void InitButtons()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x57AC5C", Offset = "0x57AC5C", VA = "0x57AC5C")]
		private void InitInputFields()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x57A290", Offset = "0x57A290", VA = "0x57A290")]
		private void ShowSetupUI()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x57D5BC", Offset = "0x57D5BC", VA = "0x57D5BC")]
		private void ShowInGameUI()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x57BC40", Offset = "0x57BC40", VA = "0x57BC40")]
		private byte[] GetSentData()
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x57B164", Offset = "0x57B164", VA = "0x57B164")]
		private void ClearTargetParticipantDropdown()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x57C758", Offset = "0x57C758", VA = "0x57C758")]
		private void UpdateTargetParticipantDrowdown()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x57B1E0", Offset = "0x57B1E0", VA = "0x57B1E0")]
		private void RefreshFinalSizeText()
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x57DFC4", Offset = "0x57DFC4", VA = "0x57DFC4")]
		private void ShowTargetParticipant()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x57DC58", Offset = "0x57DC58", VA = "0x57DC58")]
		private void ClearReceivedMessagesText()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x57D01C", Offset = "0x57D01C", VA = "0x57D01C")]
		private void AddReceivedMessage(string message)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x57E054", Offset = "0x57E054", VA = "0x57E054")]
		private void OnUseMinimalDataToggleValueChanged(bool value)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x57E188", Offset = "0x57E188", VA = "0x57E188")]
		private void OnVariantInputChanged(string value)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x57E278", Offset = "0x57E278", VA = "0x57E278")]
		private void OnExclusiveBitmaskInputChanged(string value)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x57E324", Offset = "0x57E324", VA = "0x57E324")]
		private void OnMinPlayersInputChanged(string value)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x57E4BC", Offset = "0x57E4BC", VA = "0x57E4BC")]
		private void OnMaxPlayersInputChanged(string value)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x57D16C", Offset = "0x57D16C", VA = "0x57D16C")]
		private bool IsMinimumSizeData(byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x57E5D8", Offset = "0x57E5D8", VA = "0x57E5D8", Slot = "12")]
		public override void StartCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x57E630", Offset = "0x57E630", VA = "0x57E630", Slot = "13")]
		public override void StopCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x57E688", Offset = "0x57E688", VA = "0x57E688")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3D0", Offset = "0x4AD3D0")]
		private string <GetConnectedParticipants>m__0(Participant p)
		{
			return null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x57E68C", Offset = "0x57E68C", VA = "0x57E68C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3E0", Offset = "0x4AD3E0")]
		private void <InitInputFields>m__1(string _)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x57E690", Offset = "0x57E690", VA = "0x57E690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD3F0", Offset = "0x4AD3F0")]
		private void <InitInputFields>m__2(string _)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x57E694", Offset = "0x57E694", VA = "0x57E694")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD400", Offset = "0x4AD400")]
		private void <InitInputFields>m__3(string _)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x57E698", Offset = "0x57E698", VA = "0x57E698")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD410", Offset = "0x4AD410")]
		private static void <ClearReceivedMessagesText>m__4(Text rm)
		{
		}

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x400007A")]
		private const string VariantHint = "The match variant. The meaning of this parameter is defined by the game. It usually indicates a particular game type or mode(for example \"capture the flag\", \"first to 10 points\", etc). Setting this value to 0 (default) allows the player to be matched into any waiting match. Setting it to a nonzero number to match the player only with players whose match request shares the same variant number. This value must be between 1 and 1023 (inclusive).";

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x400007B")]
		private const string ExclusiveBitmaskHint = "If your game has multiple player roles (such as farmer, archer, and wizard) and you want to restrict auto-matched games to one player of each role, add an exclusive bitmask to your match request.When auto-matching with this option, players will only be considered for a match when the logical AND of their exclusive bitmasks is equal to 0. In other words, this value represents the exclusive role the player making this request wants to play in the created match. If this value is 0 (default) it will be ignored. If you're creating a match with the standard matchmaker UI, this value will also be ignored.";

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x400007C")]
		private const string MinPlayersHint = "The minimum number of players that may join the match, including the player who is making the match request. Must be at least 2 (default).";

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x400007D")]
		private const string MaxPlayersHint = "The maximum number of players that may join the match, including the player who is making the match request. Must be equal or greater than \"minPlayers\" and may be no more than the maximum number of players allowed for the turnbased type. Default value is 2.";

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x400007E")]
		private const string CreateQuickMatchHint = "Start a game with randomly selected opponent(s).";

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x400007F")]
		private const string CreateWithMatchmakerUIHint = "Start a game with built-in invitation screen.";

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x4000080")]
		private const string AcceptFromInboxHint = "Creates a real-time game starting with the inbox screen.";

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x4000081")]
		private const string SendMessageHint = "Send a message to a particular participant, which can be selected via the \"Target Participant\" dropdown list above.";

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x4000082")]
		private const string SendMessageToAllHint = "Sends a message to all other participants.";

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x4000083")]
		private const string LeaveRoomHint = "Leaves the room.";

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x4000084")]
		private const string UseReliableMessageHint = "Determine if \"SendMessage\" and \"SendMessageToAll\" should send reliable or unreliable message. Unreliable messages are faster, but are not guaranteed to arrive and may arrive out of order.";

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x4000085")]
		private const string ShouldReinviteDisconnectedPlayerHint = "[Game Center only] Called when a player in a two-player match was disconnected. Your game should return \"true\" if it wants Game Kit to attempt to reconnect the player, \"false\" if it wants to terminate the match.";

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x4000086")]
		private const string SampleDataHint = "These value will be sent to other participant(s) when calling \"SendMessage\" or \"SendMessageToAll\". ";

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x4000087")]
		private const string ReceivedMessagesHint = "All the messages (or errors) received in \"OnRealTimeMessageReceived\" will be displayed here.";

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x4000088")]
		private const string OnLeftRoomMessage = "The current player has left the room. This may have happened because you called LeaveRoom, or because an error occurred and the player was dropped from the room. You should react by stopping your game and possibly showing an error screen (unless leaving the room was the player's request, naturally).";

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x4000089")]
		private const string OnParticipantLeftMessage = "Raises the participant left event. This is called during room setup if a player declines an invitation or leaves. The status of the participant can be inspected to determine the reason. If all players have left, the room is closed automatically.";

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x400008A")]
		private const string OnRoomConnectedMessage = "Notifies that room setup is finished. If result is true, you should react by starting to play the game; otherwise, show an error screen.";

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x400008B")]
		private const string OnRoomSetupProgressMessage = "Called during room setup to notify of room setup progress.";

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject matchRequestRoot;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject matchCreationRoot;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject ingameRoot;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button acceptFromInboxButton;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button sendMessageButton;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button sendMessageToAllButton;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Button getConnectedParticipantsButton;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Button showTargetParticipantButton;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Button getSelfButton;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Button leaveRoomButton;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Button clearReceivedMessagesButton;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private InputField variantInputField;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InputField exclusiveBitmaskInputField;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField minPlayersInputField;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private InputField maxPlayersInputField;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private InputField sampleDataTextInputField;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private InputField sampleDataValueInputField;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private InputField dummySizeInputField;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Dropdown targetParticipantDropdown;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Text finalSizeText;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Scrollbar receivedMessagesVerticalScrollbar;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Button variantHintButton;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Button bitmaskHintButton;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Button minPlayersHintButton;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Button maxPlayersHintButton;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Button createQuickMatchHintButton;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Button createWithMatchmakerUIHintButton;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Button acceptFromInboxHintButton;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Button sendMessageHintButton;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Button sendMessageToAllHintButton;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Button leaveRoomHintButton;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private Button sampleDataHintButton;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Button useReliableMessageHintButton;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Button reiniviteDisconnectedPlayerHintButton;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Button receivedMessagesHintButton;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private GameObject isRoomConnectedUI;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private GameObject receivedMessagesRoot;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private Text receivedMessagesTextPrefab;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x1D8")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x4AD088", Offset = "0x4AD088")]
		[SerializeField]
		private Toggle useMinimalDataToggle;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GameObject sampleDataTextRoot;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private GameObject sampleDataValueRoot;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private GameObject sampleDataDummySizeRoot;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x4AD0F0", Offset = "0x4AD0F0")]
		private bool showInvitationWaitingRoomUI;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x1FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD13C", Offset = "0x4AD13C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD13C", Offset = "0x4AD13C")]
		private uint <Variant>k__BackingField;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD178", Offset = "0x4AD178")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD178", Offset = "0x4AD178")]
		private uint <ExclusiveBitmask>k__BackingField;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x204")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD1B4", Offset = "0x4AD1B4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD1B4", Offset = "0x4AD1B4")]
		private uint <MinPlayers>k__BackingField;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x208")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD1F0", Offset = "0x4AD1F0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD1F0", Offset = "0x4AD1F0")]
		private uint <MaxPlayers>k__BackingField;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x20C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD22C", Offset = "0x4AD22C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD22C", Offset = "0x4AD22C")]
		private uint <MaxPlayersAllowed>k__BackingField;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD268", Offset = "0x4AD268")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD268", Offset = "0x4AD268")]
		private bool <UseReliableMessage>k__BackingField;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x211")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD2A4", Offset = "0x4AD2A4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD2A4", Offset = "0x4AD2A4")]
		private bool <ShouldReInviteDisconnectedPlayer>k__BackingField;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x218")]
		private List<Participant> Opponents;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x220")]
		private List<Text> ReceivedMessages;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x228")]
		private bool isShowingIngameUI;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x229")]
		private bool useMinimalData;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x22C")]
		private uint maxVariant;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD2E0", Offset = "0x4AD2E0")]
		private static Action<Text> <>f__am$cache0;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x2000020")]
		[Serializable]
		public class SampleData
		{
			// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x57DD58", Offset = "0x57DD58", VA = "0x57DD58")]
			public SampleData()
			{
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000174 RID: 372 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700002F")]
			public string Text
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x57E724", Offset = "0x57E724", VA = "0x57E724")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD4D4", Offset = "0x4AD4D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000144")]
				[Address(RVA = "0x57DDCC", Offset = "0x57DDCC", VA = "0x57DDCC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD4E4", Offset = "0x4AD4E4")]
				set
				{
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000176 RID: 374 RVA: 0x00002370 File Offset: 0x00000570
			// (set) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000030")]
			public float Value
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0x57E72C", Offset = "0x57E72C", VA = "0x57E72C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD4F4", Offset = "0x4AD4F4")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x57DDD4", Offset = "0x57DDD4", VA = "0x57DDD4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD504", Offset = "0x4AD504")]
				set
				{
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000178 RID: 376 RVA: 0x00002388 File Offset: 0x00000588
			// (set) Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000031")]
			public DateTime TimeStamp
			{
				[Token(Token = "0x6000147")]
				[Address(RVA = "0x57E734", Offset = "0x57E734", VA = "0x57E734")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD514", Offset = "0x4AD514")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x57DDC4", Offset = "0x57DDC4", VA = "0x57DDC4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD524", Offset = "0x4AD524")]
				set
				{
				}
			}

			// Token: 0x0600017A RID: 378 RVA: 0x000023A0 File Offset: 0x000005A0
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x57E740", Offset = "0x57E740", VA = "0x57E740")]
			public int GetSize()
			{
				return 0;
			}

			// Token: 0x0600017B RID: 379 RVA: 0x000023B8 File Offset: 0x000005B8
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x57E764", Offset = "0x57E764", VA = "0x57E764")]
			public int GetDummySize()
			{
				return 0;
			}

			// Token: 0x0600017C RID: 380 RVA: 0x000023D0 File Offset: 0x000005D0
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x57E77C", Offset = "0x57E77C", VA = "0x57E77C")]
			public int GetBaseSize()
			{
				return 0;
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x57DDDC", Offset = "0x57DDDC", VA = "0x57DDDC")]
			public void UpdateDummySize(int size)
			{
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x57DE50", Offset = "0x57DE50", VA = "0x57DE50")]
			public byte[] ToByteArray()
			{
				return null;
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x57D1B8", Offset = "0x57D1B8", VA = "0x57D1B8")]
			public static GameServicesDemo_Multiplayer_RealtimeKitchenSink.SampleData FromByteArray(byte[] bytes)
			{
				return null;
			}

			// Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x57E7C4", Offset = "0x57E7C4", VA = "0x57E7C4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD420", Offset = "0x4AD420")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD420", Offset = "0x4AD420")]
			private string <Text>k__BackingField;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000C5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD45C", Offset = "0x4AD45C")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD45C", Offset = "0x4AD45C")]
			private float <Value>k__BackingField;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD498", Offset = "0x4AD498")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AD498", Offset = "0x4AD498")]
			private DateTime <TimeStamp>k__BackingField;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x30")]
			private byte[] dummyData;
		}
	}
}
