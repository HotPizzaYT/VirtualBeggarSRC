using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200004E")]
	public class SharingDemo : MonoBehaviour
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5A04D4", Offset = "0x5A04D4", VA = "0x5A04D4")]
		public SharingDemo()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5A054C", Offset = "0x5A054C", VA = "0x5A054C")]
		private void Awake()
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5A05E8", Offset = "0x5A05E8", VA = "0x5A05E8")]
		private void OnEnable()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x5A0694", Offset = "0x5A0694", VA = "0x5A0694")]
		private void OnDisable()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x5A0740", Offset = "0x5A0740", VA = "0x5A0740")]
		private void ColorChooser_colorSelected(Color obj)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5A07A8", Offset = "0x5A07A8", VA = "0x5A07A8")]
		private void Update()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x5A086C", Offset = "0x5A086C", VA = "0x5A086C")]
		public void ShareText()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x5A0990", Offset = "0x5A0990", VA = "0x5A0990")]
		public void ShareURL()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x5A0A10", Offset = "0x5A0A10", VA = "0x5A0A10")]
		public void SaveScreenshot()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x5A0AAC", Offset = "0x5A0AAC", VA = "0x5A0AAC")]
		public void ShareScreenshot()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x5A0BBC", Offset = "0x5A0BBC", VA = "0x5A0BBC")]
		public void OneStepSharing()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x5A0A3C", Offset = "0x5A0A3C", VA = "0x5A0A3C")]
		[DebuggerHidden]
		private IEnumerator CRSaveScreenshot()
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x5A0BE8", Offset = "0x5A0BE8", VA = "0x5A0BE8")]
		[DebuggerHidden]
		private IEnumerator CROneStepSharing()
		{
			return null;
		}

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x18")]
		public Image clockRect;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x20")]
		public Text clockText;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x28")]
		public InputField twoStepShareMessage;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x30")]
		public InputField oneStepShareMessage;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x38")]
		public InputField shareTextMessage;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x40")]
		private string TwoStepScreenshotName;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x48")]
		private string OneStepScreenshotName;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x50")]
		private string TwoStepScreenshotPath;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x58")]
		private string sampleURL;

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x2000415")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0608", Offset = "0x4B0608")]
		private sealed class <CRSaveScreenshot>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x5A0C58", Offset = "0x5A0C58", VA = "0x5A0C58")]
			[DebuggerHidden]
			public <CRSaveScreenshot>c__Iterator0()
			{
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002DA8 File Offset: 0x00000FA8
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x5A0E40", Offset = "0x5A0E40", VA = "0x5A0E40", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600047D RID: 1149 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004C8")]
			private object Current
			{
				[Token(Token = "0x6001F3A")]
				[Address(RVA = "0x5A0FB8", Offset = "0x5A0FB8", VA = "0x5A0FB8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004C9")]
			private object Current
			{
				[Token(Token = "0x6001F3B")]
				[Address(RVA = "0x5A0FC0", Offset = "0x5A0FC0", VA = "0x5A0FC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x5A0FC8", Offset = "0x5A0FC8", VA = "0x5A0FC8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0x5A0FDC", Offset = "0x5A0FDC", VA = "0x5A0FDC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4001253")]
			[FieldOffset(Offset = "0x10")]
			internal SharingDemo $this;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4001254")]
			[FieldOffset(Offset = "0x18")]
			internal object $current;

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4001255")]
			[FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4001256")]
			[FieldOffset(Offset = "0x24")]
			internal int $PC;
		}

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x2000416")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0668", Offset = "0x4B0668")]
		private sealed class <CROneStepSharing>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0x5A0C60", Offset = "0x5A0C60", VA = "0x5A0C60")]
			[DebuggerHidden]
			public <CROneStepSharing>c__Iterator1()
			{
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00002DC0 File Offset: 0x00000FC0
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x5A0C68", Offset = "0x5A0C68", VA = "0x5A0C68", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000483 RID: 1155 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004CA")]
			private object Current
			{
				[Token(Token = "0x6001F40")]
				[Address(RVA = "0x5A0DB4", Offset = "0x5A0DB4", VA = "0x5A0DB4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004CB")]
			private object Current
			{
				[Token(Token = "0x6001F41")]
				[Address(RVA = "0x5A0DBC", Offset = "0x5A0DBC", VA = "0x5A0DBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F42")]
			[Address(RVA = "0x5A0DC4", Offset = "0x5A0DC4", VA = "0x5A0DC4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x5A0DD8", Offset = "0x5A0DD8", VA = "0x5A0DD8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4001257")]
			[FieldOffset(Offset = "0x10")]
			internal SharingDemo $this;

			// Token: 0x0400039A RID: 922
			[Token(Token = "0x4001258")]
			[FieldOffset(Offset = "0x18")]
			internal object $current;

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x4001259")]
			[FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400125A")]
			[FieldOffset(Offset = "0x24")]
			internal int $PC;
		}
	}
}
