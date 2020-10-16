using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x2000038")]
	public class Racing3DGameView : MonoBehaviour
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x59D6A0", Offset = "0x59D6A0", VA = "0x59D6A0")]
		public Racing3DGameView()
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public bool IsWaitingUIShowing
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x59D6B4", Offset = "0x59D6B4", VA = "0x59D6B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEC84", Offset = "0x4AEC84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x59D6BC", Offset = "0x59D6BC", VA = "0x59D6BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEC94", Offset = "0x4AEC94")]
			private set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public bool IsSettingUIShowing
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x59D6C8", Offset = "0x59D6C8", VA = "0x59D6C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AECA4", Offset = "0x4AECA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x59D6D0", Offset = "0x59D6D0", VA = "0x59D6D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AECB4", Offset = "0x4AECB4")]
			private set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public bool IsIngameShowing
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x59D6DC", Offset = "0x59D6DC", VA = "0x59D6DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AECC4", Offset = "0x4AECC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x59D6E4", Offset = "0x59D6E4", VA = "0x59D6E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AECD4", Offset = "0x4AECD4")]
			private set
			{
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x59D6F0", Offset = "0x59D6F0", VA = "0x59D6F0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x59D9F0", Offset = "0x59D9F0", VA = "0x59D9F0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x59BC18", Offset = "0x59BC18", VA = "0x59BC18")]
		public void ShowSettingUI()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x59A464", Offset = "0x59A464", VA = "0x59A464")]
		public void ShowInGameUI()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x59A3BC", Offset = "0x59A3BC", VA = "0x59A3BC")]
		public void ShowPrepareText()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x59B0A4", Offset = "0x59B0A4", VA = "0x59B0A4")]
		public void StartCounting(float delay = 0f, [Optional] Action onFinish)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x59DB1C", Offset = "0x59DB1C", VA = "0x59DB1C")]
		public void SetActiveSettingUI(bool showFlag)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x59DB80", Offset = "0x59DB80", VA = "0x59DB80")]
		public void SetActiveInGame(bool showFlag)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x59B7D8", Offset = "0x59B7D8", VA = "0x59B7D8")]
		public void ShowGameOverUI(bool wonFlag, Racing3DGameModel.GameoverReason gameoverReason)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5972D0", Offset = "0x5972D0", VA = "0x5972D0")]
		public void SetActiveNitro(bool active)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x59DCF8", Offset = "0x59DCF8", VA = "0x59DCF8")]
		public void BackButton()
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x59B3D0", Offset = "0x59B3D0", VA = "0x59B3D0")]
		public void ShowRematchRequestedUI()
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x59B458", Offset = "0x59B458", VA = "0x59B458")]
		public void ShowRematchResponsedUI(bool accepted)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x59DE08", Offset = "0x59DE08", VA = "0x59DE08")]
		private void SendRematchRequest()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x59DEC0", Offset = "0x59DEC0", VA = "0x59DEC0")]
		private void SendRematchResponse(bool accepted)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x59DBE4", Offset = "0x59DBE4", VA = "0x59DBE4")]
		[DebuggerHidden]
		private IEnumerator CountingDownCoroutine(float delay = 0f, [Optional] Action onFinish)
		{
			return null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x59D938", Offset = "0x59D938", VA = "0x59D938")]
		private void RegisterButtonsEvent()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x59DC98", Offset = "0x59DC98", VA = "0x59DC98")]
		private string GetGameoverSubtitle(Racing3DGameModel.GameoverReason gameoverReason)
		{
			return null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x59DF94", Offset = "0x59DF94", VA = "0x59DF94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AECF4", Offset = "0x4AECF4")]
		private void <Start>m__0()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x59DF9C", Offset = "0x59DF9C", VA = "0x59DF9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AED04", Offset = "0x4AED04")]
		private void <Start>m__1()
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x59DFA4", Offset = "0x59DFA4", VA = "0x59DFA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AED14", Offset = "0x4AED14")]
		private void <BackButton>m__2(int button)
		{
		}

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Racing3DGameControl control;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DemoUtils utilities;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject settingUIRootObject;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject ingameRootObject;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image nitroImage;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text ingamePrepareText;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button acceptFromInboxButton;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject nitroRoot;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject gameoverPanel;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject requestResponseRoot;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text gameoverTitle;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text gameoverSubtitle;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button gameoverDoneButton;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button rematchButton;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button acceptRematchButton;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button denyRematchButton;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject header;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x4AEB88", Offset = "0x4AEB88")]
		[SerializeField]
		private int maxCountDown;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float countDownTime;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEBD0", Offset = "0x4AEBD0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEBD0", Offset = "0x4AEBD0")]
		private bool <IsWaitingUIShowing>k__BackingField;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEC0C", Offset = "0x4AEC0C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEC0C", Offset = "0x4AEC0C")]
		private bool <IsSettingUIShowing>k__BackingField;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AEC48", Offset = "0x4AEC48")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AEC48", Offset = "0x4AEC48")]
		private bool <IsIngameShowing>k__BackingField;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x40001B3")]
		private const string wonText = "<color=blue>YOU WON!!!</color>";

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x40001B4")]
		private const string loseText = "<color=red>YOU LOSE!!!</color>";

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x20003FD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AED24", Offset = "0x4AED24")]
		private sealed class <CountingDownCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0x59DF8C", Offset = "0x59DF8C", VA = "0x59DF8C")]
			[DebuggerHidden]
			public <CountingDownCoroutine>c__Iterator0()
			{
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x000029A0 File Offset: 0x00000BA0
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0x59E080", Offset = "0x59E080", VA = "0x59E080", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B0")]
			private object Current
			{
				[Token(Token = "0x6001ED3")]
				[Address(RVA = "0x59E36C", Offset = "0x59E36C", VA = "0x59E36C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060002E7 RID: 743 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B1")]
			private object Current
			{
				[Token(Token = "0x6001ED4")]
				[Address(RVA = "0x59E374", Offset = "0x59E374", VA = "0x59E374", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x59E37C", Offset = "0x59E37C", VA = "0x59E37C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ED6")]
			[Address(RVA = "0x59E390", Offset = "0x59E390", VA = "0x59E390", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x40011E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float delay;

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x40011E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Action onFinish;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x40011E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float <totalTime>__0;

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x40011E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float <waitTime>__0;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x40011EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int <i>__1;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x40011EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Racing3DGameView $this;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x40011EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal object $current;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x40011ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal bool $disposing;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x40011EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal int $PC;
		}
	}
}
