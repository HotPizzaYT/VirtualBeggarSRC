using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001A")]
	public class LoadingPanelController : MonoBehaviour
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x58CEA0", Offset = "0x58CEA0", VA = "0x58CEA0")]
		public LoadingPanelController()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x1700001E")]
		public bool IsShowing
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x579BF8", Offset = "0x579BF8", VA = "0x579BF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x579D28", Offset = "0x579D28", VA = "0x579D28")]
		public void Show()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x579D88", Offset = "0x579D88", VA = "0x579D88")]
		public void Hide()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x579C00", Offset = "0x579C00", VA = "0x579C00")]
		public void SetMessageText(string msg)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x579C40", Offset = "0x579C40", VA = "0x579C40")]
		public void SetButtonLabel(string label)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x579CD4", Offset = "0x579CD4", VA = "0x579CD4")]
		public void RegisterButtonCallback(UnityAction callback)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x58CEB8", Offset = "0x58CEB8", VA = "0x58CEB8")]
		private void OnEnable()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x58CF5C", Offset = "0x58CF5C", VA = "0x58CF5C")]
		private void OnDisable()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x58CEEC", Offset = "0x58CEEC", VA = "0x58CEEC")]
		[DebuggerHidden]
		private IEnumerator CRSpin()
		{
			return null;
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AC8CC", Offset = "0x4AC8CC")]
		public Image spinner;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public Text message;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		public Button button;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AC904", Offset = "0x4AC904")]
		public float spinningAngle;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x34")]
		public float spinningFillSpeed;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x38")]
		private bool mIsShowing;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine mSpinCoroutine;

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x20003EB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC94C", Offset = "0x4AC94C")]
		private sealed class <CRSpin>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x58CF90", Offset = "0x58CF90", VA = "0x58CF90")]
			[DebuggerHidden]
			public <CRSpin>c__Iterator0()
			{
			}

			// Token: 0x060000CA RID: 202 RVA: 0x000021A8 File Offset: 0x000003A8
			[Token(Token = "0x6001E8B")]
			[Address(RVA = "0x58CF98", Offset = "0x58CF98", VA = "0x58CF98", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000CB RID: 203 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049E")]
			private object Current
			{
				[Token(Token = "0x6001E8C")]
				[Address(RVA = "0x58D14C", Offset = "0x58D14C", VA = "0x58D14C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049F")]
			private object Current
			{
				[Token(Token = "0x6001E8D")]
				[Address(RVA = "0x58D154", Offset = "0x58D154", VA = "0x58D154", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E8E")]
			[Address(RVA = "0x58D15C", Offset = "0x58D15C", VA = "0x58D15C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0x58D170", Offset = "0x58D170", VA = "0x58D170", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4001198")]
			[FieldOffset(Offset = "0x10")]
			internal float <fillAmount>__0;

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4001199")]
			[FieldOffset(Offset = "0x18")]
			internal LoadingPanelController $this;

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400119A")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400119B")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400119C")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}
	}
}
