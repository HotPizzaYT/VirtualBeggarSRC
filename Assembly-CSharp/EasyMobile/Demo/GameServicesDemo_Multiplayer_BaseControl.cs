using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x200001E")]
	public abstract class GameServicesDemo_Multiplayer_BaseControl : MonoBehaviour
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x576E34", Offset = "0x576E34", VA = "0x576E34")]
		protected GameServicesDemo_Multiplayer_BaseControl()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public bool IsInvitationDelegateRegistered
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x576EBC", Offset = "0x576EBC", VA = "0x576EBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC08", Offset = "0x4ACC08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x576EC4", Offset = "0x576EC4", VA = "0x576EC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC18", Offset = "0x4ACC18")]
			private set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		protected bool ShouldShowInvitationPanel
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x576ED0", Offset = "0x576ED0", VA = "0x576ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC28", Offset = "0x4ACC28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x576ED8", Offset = "0x576ED8", VA = "0x576ED8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC38", Offset = "0x4ACC38")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		private protected bool IsDestroyed
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x576EE4", Offset = "0x576EE4", VA = "0x576EE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC48", Offset = "0x4ACC48")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x576EEC", Offset = "0x576EEC", VA = "0x576EEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACC58", Offset = "0x4ACC58")]
			private set
			{
			}
		}

		// Token: 0x060000F2 RID: 242
		[Token(Token = "0x60000DA")]
		protected abstract void CreateQuickMatch();

		// Token: 0x060000F3 RID: 243
		[Token(Token = "0x60000DB")]
		protected abstract void CreateWithMatchmaker();

		// Token: 0x060000F4 RID: 244
		[Token(Token = "0x60000DC")]
		protected abstract void AcceptInvitation(Invitation invitation);

		// Token: 0x060000F5 RID: 245
		[Token(Token = "0x60000DD")]
		protected abstract void DeclineInvitation(Invitation invitation);

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F6 RID: 246
		[Token(Token = "0x17000024")]
		protected abstract MatchType MatchType { [Token(Token = "0x60000DE")] get; }

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x576EF8", Offset = "0x576EF8", VA = "0x576EF8", Slot = "9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x577218", Offset = "0x577218", VA = "0x577218")]
		[DebuggerHidden]
		protected IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x577290", Offset = "0x577290", VA = "0x577290", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x577340", Offset = "0x577340", VA = "0x577340", Slot = "11")]
		protected virtual void LateStart()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x577344", Offset = "0x577344", VA = "0x577344")]
		protected void OnInvitationReceived(Invitation invitation, bool shouldAutoAccept)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x577A00", Offset = "0x577A00", VA = "0x577A00")]
		private void ShowInvitationPanel(Invitation invitation)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x577B84", Offset = "0x577B84", VA = "0x577B84")]
		protected void CloseInvitationPanel()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x577C5C", Offset = "0x577C5C", VA = "0x577C5C")]
		private void AcceptCurrentInvitation()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x577CA0", Offset = "0x577CA0", VA = "0x577CA0")]
		private void DeclineCurrentInvitation()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x577CE4", Offset = "0x577CE4", VA = "0x577CE4")]
		private void ShowCurrentInvitationDetails()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x577BEC", Offset = "0x577BEC", VA = "0x577BEC")]
		[DebuggerHidden]
		private IEnumerator ShowNextInvitationCoroutine()
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x577AF0", Offset = "0x577AF0", VA = "0x577AF0")]
		[DebuggerHidden]
		private IEnumerator ShowInvitationCoroutine(Invitation invitation)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x577D68", Offset = "0x577D68", VA = "0x577D68")]
		private void RegisterInvitationDelegate()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5775FC", Offset = "0x5775FC", VA = "0x5775FC")]
		public string GetInvitationDisplayString(Invitation invitation)
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x577E18", Offset = "0x577E18", VA = "0x577E18")]
		public string GetParticipantDisplayString(Participant participant)
		{
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5786C4", Offset = "0x5786C4", VA = "0x5786C4")]
		public string GetTurnbasedMatchDisplayString(TurnBasedMatch match)
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x579100", Offset = "0x579100", VA = "0x579100", Slot = "12")]
		public virtual void StartCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5791FC", Offset = "0x5791FC", VA = "0x5791FC", Slot = "13")]
		public virtual void StopCreateQuickMatchSpinningUI()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x57918C", Offset = "0x57918C", VA = "0x57918C")]
		[DebuggerHidden]
		protected IEnumerator CreateQuickMatchSpinningCoroutine()
		{
			return null;
		}

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LoadingPanelController loadingPanel;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected DemoUtils demoUtils;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button createQuickMatchButton;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button createWithMatchmakerButton;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button acceptInvitationButton;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button declineInvitationButton;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button closeInvitationPanelButton;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button showInvitationDetailsButton;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text invitationInfoText;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject invitationPanel;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image createQuickMatchSpinningCircle;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACB54", Offset = "0x4ACB54")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ACB54", Offset = "0x4ACB54")]
		private bool <IsInvitationDelegateRegistered>k__BackingField;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACB90", Offset = "0x4ACB90")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ACB90", Offset = "0x4ACB90")]
		private bool <ShouldShowInvitationPanel>k__BackingField;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACBCC", Offset = "0x4ACBCC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ACBCC", Offset = "0x4ACBCC")]
		private bool <IsDestroyed>k__BackingField;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x78")]
		private Queue<Invitation> unhandledInvitations;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x80")]
		private Invitation currentInvitation;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x88")]
		private bool isInvitationPanelShowing;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x8C")]
		private float showNewInvitationDelayTime;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x90")]
		protected int createQuickMatchRequest;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x94")]
		private bool isCreateQuickMatchSpinningUIShowing;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine createQuickMatchSpinningCoroutine;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xA0")]
		private float createQuickMatchSpinningAngle;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xA4")]
		private float createQuickMatchSpinningFillSpeed;

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x20003EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACCA8", Offset = "0x4ACCA8")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E90")]
			[Address(RVA = "0x577288", Offset = "0x577288", VA = "0x577288")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x579934", Offset = "0x579934", VA = "0x579934", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A0")]
			private object Current
			{
				[Token(Token = "0x6001E92")]
				[Address(RVA = "0x579DC8", Offset = "0x579DC8", VA = "0x579DC8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A1")]
			private object Current
			{
				[Token(Token = "0x6001E93")]
				[Address(RVA = "0x579DD0", Offset = "0x579DD0", VA = "0x579DD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x579DD8", Offset = "0x579DD8", VA = "0x579DD8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x579DEC", Offset = "0x579DEC", VA = "0x579DEC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x579E54", Offset = "0x579E54", VA = "0x579E54")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000092 RID: 146
			[Token(Token = "0x400119D")]
			[FieldOffset(Offset = "0x10")]
			internal GameServicesDemo_Multiplayer_BaseControl $this;

			// Token: 0x04000093 RID: 147
			[Token(Token = "0x400119E")]
			[FieldOffset(Offset = "0x18")]
			internal object $current;

			// Token: 0x04000094 RID: 148
			[Token(Token = "0x400119F")]
			[FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			// Token: 0x04000095 RID: 149
			[Token(Token = "0x40011A0")]
			[FieldOffset(Offset = "0x24")]
			internal int $PC;
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x20003ED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACD08", Offset = "0x4ACD08")]
		private sealed class <ShowNextInvitationCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0x577D58", Offset = "0x577D58", VA = "0x577D58")]
			[DebuggerHidden]
			public <ShowNextInvitationCoroutine>c__Iterator1()
			{
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x6001E98")]
			[Address(RVA = "0x579738", Offset = "0x579738", VA = "0x579738", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000113 RID: 275 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A2")]
			private object Current
			{
				[Token(Token = "0x6001E99")]
				[Address(RVA = "0x5798A8", Offset = "0x5798A8", VA = "0x5798A8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A3")]
			private object Current
			{
				[Token(Token = "0x6001E9A")]
				[Address(RVA = "0x5798B0", Offset = "0x5798B0", VA = "0x5798B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x5798B8", Offset = "0x5798B8", VA = "0x5798B8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0x5798CC", Offset = "0x5798CC", VA = "0x5798CC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000096 RID: 150
			[Token(Token = "0x40011A1")]
			[FieldOffset(Offset = "0x10")]
			internal GameServicesDemo_Multiplayer_BaseControl $this;

			// Token: 0x04000097 RID: 151
			[Token(Token = "0x40011A2")]
			[FieldOffset(Offset = "0x18")]
			internal object $current;

			// Token: 0x04000098 RID: 152
			[Token(Token = "0x40011A3")]
			[FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			// Token: 0x04000099 RID: 153
			[Token(Token = "0x40011A4")]
			[FieldOffset(Offset = "0x24")]
			internal int $PC;
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x20003EE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACD68", Offset = "0x4ACD68")]
		private sealed class <ShowInvitationCoroutine>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E9D")]
			[Address(RVA = "0x577D60", Offset = "0x577D60", VA = "0x577D60")]
			[DebuggerHidden]
			public <ShowInvitationCoroutine>c__Iterator2()
			{
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00002238 File Offset: 0x00000438
			[Token(Token = "0x6001E9E")]
			[Address(RVA = "0x5794C4", Offset = "0x5794C4", VA = "0x5794C4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A4")]
			private object Current
			{
				[Token(Token = "0x6001E9F")]
				[Address(RVA = "0x5796AC", Offset = "0x5796AC", VA = "0x5796AC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600011A RID: 282 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A5")]
			private object Current
			{
				[Token(Token = "0x6001EA0")]
				[Address(RVA = "0x5796B4", Offset = "0x5796B4", VA = "0x5796B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x5796BC", Offset = "0x5796BC", VA = "0x5796BC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x5796D0", Offset = "0x5796D0", VA = "0x5796D0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400009A RID: 154
			[Token(Token = "0x40011A5")]
			[FieldOffset(Offset = "0x10")]
			internal Invitation invitation;

			// Token: 0x0400009B RID: 155
			[Token(Token = "0x40011A6")]
			[FieldOffset(Offset = "0x18")]
			internal GameServicesDemo_Multiplayer_BaseControl $this;

			// Token: 0x0400009C RID: 156
			[Token(Token = "0x40011A7")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x0400009D RID: 157
			[Token(Token = "0x40011A8")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x0400009E RID: 158
			[Token(Token = "0x40011A9")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x20003EF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACDC8", Offset = "0x4ACDC8")]
		private sealed class <CreateQuickMatchSpinningCoroutine>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x57927C", Offset = "0x57927C", VA = "0x57927C")]
			[DebuggerHidden]
			public <CreateQuickMatchSpinningCoroutine>c__Iterator3()
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00002250 File Offset: 0x00000450
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x579284", Offset = "0x579284", VA = "0x579284", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A6")]
			private object Current
			{
				[Token(Token = "0x6001EA5")]
				[Address(RVA = "0x579438", Offset = "0x579438", VA = "0x579438", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A7")]
			private object Current
			{
				[Token(Token = "0x6001EA6")]
				[Address(RVA = "0x579440", Offset = "0x579440", VA = "0x579440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA7")]
			[Address(RVA = "0x579448", Offset = "0x579448", VA = "0x579448", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EA8")]
			[Address(RVA = "0x57945C", Offset = "0x57945C", VA = "0x57945C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400009F RID: 159
			[Token(Token = "0x40011AA")]
			[FieldOffset(Offset = "0x10")]
			internal float <fillAmount>__0;

			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40011AB")]
			[FieldOffset(Offset = "0x18")]
			internal GameServicesDemo_Multiplayer_BaseControl $this;

			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40011AC")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40011AD")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40011AE")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}
	}
}
