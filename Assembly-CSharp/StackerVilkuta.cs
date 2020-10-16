using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[Token(Token = "0x20003BA")]
public class StackerVilkuta : MonoBehaviour
{
	// Token: 0x06002362 RID: 9058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0xAC2664", Offset = "0xAC2664", VA = "0xAC2664")]
	public StackerVilkuta()
	{
	}

	// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D06")]
	[Address(RVA = "0xAC266C", Offset = "0xAC266C", VA = "0xAC266C")]
	private void Awake()
	{
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D07")]
	[Address(RVA = "0xABE37C", Offset = "0xABE37C", VA = "0xABE37C")]
	public void AloitaVilkutus()
	{
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D08")]
	[Address(RVA = "0xABE3C0", Offset = "0xABE3C0", VA = "0xABE3C0")]
	public void LopetaVilkutus()
	{
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D09")]
	[Address(RVA = "0xAC26E8", Offset = "0xAC26E8", VA = "0xAC26E8")]
	[DebuggerHidden]
	private IEnumerator Vilkuta(int kerrat, float interval, bool lopuksiPoisPaalta = true)
	{
		return null;
	}

	// Token: 0x0400158F RID: 5519
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x18")]
	private SpriteRenderer sr;

	// Token: 0x04001590 RID: 5520
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x20")]
	private Color aVari;

	// Token: 0x04001591 RID: 5521
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerator vilkutus;

	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000569")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BEBD8", Offset = "0x4BEBD8")]
	private sealed class <Vilkuta>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002367 RID: 9063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0xAC27B4", Offset = "0xAC27B4", VA = "0xAC27B4")]
		[DebuggerHidden]
		public <Vilkuta>c__Iterator0()
		{
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0xAC27BC", Offset = "0xAC27BC", VA = "0xAC27BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005E8")]
		private object Current
		{
			[Token(Token = "0x60024D7")]
			[Address(RVA = "0xAC2A70", Offset = "0xAC2A70", VA = "0xAC2A70", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005E9")]
		private object Current
		{
			[Token(Token = "0x60024D8")]
			[Address(RVA = "0xAC2A78", Offset = "0xAC2A78", VA = "0xAC2A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0xAC2A80", Offset = "0xAC2A80", VA = "0xAC2A80", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0xAC2A94", Offset = "0xAC2A94", VA = "0xAC2A94", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x10")]
		internal int <i>__1;

		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x14")]
		internal int kerrat;

		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x400164B")]
		[FieldOffset(Offset = "0x18")]
		internal float interval;

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x1C")]
		internal bool lopuksiPoisPaalta;

		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x400164D")]
		[FieldOffset(Offset = "0x20")]
		internal StackerVilkuta $this;

		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x400164E")]
		[FieldOffset(Offset = "0x28")]
		internal object $current;

		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x30")]
		internal bool $disposing;

		// Token: 0x04001599 RID: 5529
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x34")]
		internal int $PC;
	}
}
