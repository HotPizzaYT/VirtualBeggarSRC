using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050B RID: 1291
[Token(Token = "0x20003A5")]
[Attribute(Name = "RequireComponent", RVA = "0x4BE0F0", Offset = "0x4BE0F0")]
public class JackPlayer : MonoBehaviour
{
	// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x74E69C", Offset = "0x74E69C", VA = "0x74E69C")]
	public JackPlayer()
	{
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x74E6B8", Offset = "0x74E6B8", VA = "0x74E6B8")]
	private void Awake()
	{
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x74E714", Offset = "0x74E714", VA = "0x74E714")]
	private void LaskeUudetHypynArvot()
	{
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x74E9C0", Offset = "0x74E9C0", VA = "0x74E9C0")]
	private void Update()
	{
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x74ED48", Offset = "0x74ED48", VA = "0x74ED48")]
	[DebuggerHidden]
	private IEnumerator AloitaKirppu()
	{
		return null;
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x74ECD8", Offset = "0x74ECD8", VA = "0x74ECD8")]
	[DebuggerHidden]
	private IEnumerator HyppyAnim()
	{
		return null;
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x74EDB8", Offset = "0x74EDB8", VA = "0x74EDB8")]
	[DebuggerHidden]
	private IEnumerator LaskeutumisAnim()
	{
		return null;
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x74EE40", Offset = "0x74EE40", VA = "0x74EE40")]
	[DebuggerHidden]
	private IEnumerator AloitaKuolema()
	{
		return null;
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x0000A440 File Offset: 0x00008640
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x74EC30", Offset = "0x74EC30", VA = "0x74EC30")]
	private bool Kosketaanko()
	{
		return default(bool);
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x74EEB8", Offset = "0x74EEB8", VA = "0x74EEB8")]
	private void OnTriggerEnter2D(Collider2D coll)
	{
	}

	// Token: 0x04001458 RID: 5208
	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0x18")]
	public float maxJumpHeight;

	// Token: 0x04001459 RID: 5209
	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x1C")]
	public float minJumpHeight;

	// Token: 0x0400145A RID: 5210
	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0x20")]
	public float timeToJumpApex;

	// Token: 0x0400145B RID: 5211
	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x24")]
	private float gravity;

	// Token: 0x0400145C RID: 5212
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x28")]
	private float maxJumpVelocity;

	// Token: 0x0400145D RID: 5213
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x2C")]
	private float minJumpVelocity;

	// Token: 0x0400145E RID: 5214
	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 velocity;

	// Token: 0x0400145F RID: 5215
	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x38")]
	private JackController controller;

	// Token: 0x04001460 RID: 5216
	[Token(Token = "0x4001016")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x4BE154", Offset = "0x4BE154")]
	public SpriteRenderer sr;

	// Token: 0x04001461 RID: 5217
	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x48")]
	public Sprite[] hyppySpritet;

	// Token: 0x04001462 RID: 5218
	[Token(Token = "0x4001018")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] laskeutumisSpritet;

	// Token: 0x04001463 RID: 5219
	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x58")]
	public JackManager jackManager;

	// Token: 0x04001464 RID: 5220
	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x60")]
	private bool kirppuMode;

	// Token: 0x04001465 RID: 5221
	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x61")]
	private bool hypatty;

	// Token: 0x04001466 RID: 5222
	[Token(Token = "0x400101C")]
	[FieldOffset(Offset = "0x62")]
	private bool kirppuLatautuu;

	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x2000550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE1A8", Offset = "0x4BE1A8")]
	private sealed class <AloitaKirppu>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600222C RID: 8748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x74EE28", Offset = "0x74EE28", VA = "0x74EE28")]
		[DebuggerHidden]
		public <AloitaKirppu>c__Iterator0()
		{
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x74F0D4", Offset = "0x74F0D4", VA = "0x74F0D4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BE")]
		private object Current
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x74F42C", Offset = "0x74F42C", VA = "0x74F42C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BF")]
		private object Current
		{
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x74F434", Offset = "0x74F434", VA = "0x74F434", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x74F43C", Offset = "0x74F43C", VA = "0x74F43C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x74F450", Offset = "0x74F450", VA = "0x74F450", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001467 RID: 5223
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x10")]
		internal float <aikaPaatyyn>__0;

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x14")]
		internal float <t>__0;

		// Token: 0x04001469 RID: 5225
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x18")]
		internal int <animkohta>__0;

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x1C")]
		internal float <tPr>__0;

		// Token: 0x0400146B RID: 5227
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x20")]
		internal JackPlayer $this;

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x28")]
		internal object $current;

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x30")]
		internal bool $disposing;

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x34")]
		internal int $PC;
	}

	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x2000551")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE208", Offset = "0x4BE208")]
	private sealed class <HyppyAnim>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x74EE30", Offset = "0x74EE30", VA = "0x74EE30")]
		[DebuggerHidden]
		public <HyppyAnim>c__Iterator1()
		{
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x74F620", Offset = "0x74F620", VA = "0x74F620", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C0")]
		private object Current
		{
			[Token(Token = "0x600245F")]
			[Address(RVA = "0x74F7B0", Offset = "0x74F7B0", VA = "0x74F7B0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C1")]
		private object Current
		{
			[Token(Token = "0x6002460")]
			[Address(RVA = "0x74F7B8", Offset = "0x74F7B8", VA = "0x74F7B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x74F7C0", Offset = "0x74F7C0", VA = "0x74F7C0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x74F7D4", Offset = "0x74F7D4", VA = "0x74F7D4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400146F RID: 5231
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x10")]
		internal int <i>__1;

		// Token: 0x04001470 RID: 5232
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x18")]
		internal JackPlayer $this;

		// Token: 0x04001471 RID: 5233
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x28")]
		internal bool $disposing;

		// Token: 0x04001473 RID: 5235
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x2C")]
		internal int $PC;
	}

	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x2000552")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE268", Offset = "0x4BE268")]
	private sealed class <LaskeutumisAnim>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002238 RID: 8760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x74EE38", Offset = "0x74EE38", VA = "0x74EE38")]
		[DebuggerHidden]
		public <LaskeutumisAnim>c__Iterator2()
		{
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x74F83C", Offset = "0x74F83C", VA = "0x74F83C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C2")]
		private object Current
		{
			[Token(Token = "0x6002465")]
			[Address(RVA = "0x74FA88", Offset = "0x74FA88", VA = "0x74FA88", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C3")]
		private object Current
		{
			[Token(Token = "0x6002466")]
			[Address(RVA = "0x74FA90", Offset = "0x74FA90", VA = "0x74FA90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x74FA98", Offset = "0x74FA98", VA = "0x74FA98", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x74FAAC", Offset = "0x74FAAC", VA = "0x74FAAC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x10")]
		internal JackPlayer $this;

		// Token: 0x04001475 RID: 5237
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x2000553")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE2C8", Offset = "0x4BE2C8")]
	private sealed class <AloitaKuolema>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x74EEB0", Offset = "0x74EEB0", VA = "0x74EEB0")]
		[DebuggerHidden]
		public <AloitaKuolema>c__Iterator3()
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x74F4B8", Offset = "0x74F4B8", VA = "0x74F4B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C4")]
		private object Current
		{
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x74F594", Offset = "0x74F594", VA = "0x74F594", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C5")]
		private object Current
		{
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x74F59C", Offset = "0x74F59C", VA = "0x74F59C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x74F5A4", Offset = "0x74F5A4", VA = "0x74F5A4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x74F5B8", Offset = "0x74F5B8", VA = "0x74F5B8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x40015EC")]
		[FieldOffset(Offset = "0x10")]
		internal JackPlayer $this;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
