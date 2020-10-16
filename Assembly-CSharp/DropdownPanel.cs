using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200051A RID: 1306
[Token(Token = "0x20003AD")]
public class DropdownPanel : MonoBehaviour
{
	// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C73")]
	[Address(RVA = "0x70E2DC", Offset = "0x70E2DC", VA = "0x70E2DC")]
	public DropdownPanel()
	{
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x70E2F4", Offset = "0x70E2F4", VA = "0x70E2F4")]
	public void AsetaPaalle()
	{
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x70E348", Offset = "0x70E348", VA = "0x70E348")]
	public void AsetaPaalle(bool paalle)
	{
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x70E374", Offset = "0x70E374", VA = "0x70E374")]
	[DebuggerHidden]
	public IEnumerator Anim()
	{
		return null;
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x70E3EC", Offset = "0x70E3EC", VA = "0x70E3EC")]
	public void VaihdaMenuKuva(bool avataan)
	{
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x70E4D8", Offset = "0x70E4D8", VA = "0x70E4D8")]
	public void OnVaihdaVarasto()
	{
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x0000A518 File Offset: 0x00008718
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x70E5AC", Offset = "0x70E5AC", VA = "0x70E5AC")]
	private float LinearLiike(float t, float b, float c, float d)
	{
		return 0f;
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x70E5BC", Offset = "0x70E5BC", VA = "0x70E5BC")]
	public void AsetaIPhoneXJututAlku()
	{
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x70E5CC", Offset = "0x70E5CC", VA = "0x70E5CC")]
	public void AsetaIPhoneXJutut()
	{
	}

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform tr;

	// Token: 0x040014CB RID: 5323
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform takakelmuTr;

	// Token: 0x040014CC RID: 5324
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x28")]
	public Image menuImg;

	// Token: 0x040014CD RID: 5325
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x30")]
	public Sprite[] menuSpritet;

	// Token: 0x040014CE RID: 5326
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x38")]
	private float yAlkupaikka;

	// Token: 0x040014CF RID: 5327
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x3C")]
	private float muutosY;

	// Token: 0x040014D0 RID: 5328
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x40")]
	private bool varastossa;

	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200055A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE488", Offset = "0x4BE488")]
	private sealed class <Anim>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x70E3E4", Offset = "0x70E3E4", VA = "0x70E3E4")]
		[DebuggerHidden]
		public <Anim>c__Iterator0()
		{
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x70EA40", Offset = "0x70EA40", VA = "0x70EA40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CC")]
		private object Current
		{
			[Token(Token = "0x6002483")]
			[Address(RVA = "0x70EC80", Offset = "0x70EC80", VA = "0x70EC80", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CD")]
		private object Current
		{
			[Token(Token = "0x6002484")]
			[Address(RVA = "0x70EC88", Offset = "0x70EC88", VA = "0x70EC88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x70EC90", Offset = "0x70EC90", VA = "0x70EC90", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x70ECA4", Offset = "0x70ECA4", VA = "0x70ECA4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x10")]
		internal float <t>__0;

		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x14")]
		internal float <d>__0;

		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x18")]
		internal float <c>__0;

		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x1C")]
		internal float <alkuY>__0;

		// Token: 0x040014D5 RID: 5333
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x20")]
		internal float <uusiY>__1;

		// Token: 0x040014D6 RID: 5334
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x28")]
		internal DropdownPanel $this;

		// Token: 0x040014D7 RID: 5335
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x30")]
		internal object $current;

		// Token: 0x040014D8 RID: 5336
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x38")]
		internal bool $disposing;

		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x3C")]
		internal int $PC;
	}
}
