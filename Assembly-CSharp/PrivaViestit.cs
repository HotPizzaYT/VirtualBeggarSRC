using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleFirebaseUnity;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004E0 RID: 1248
[Token(Token = "0x2000389")]
public class PrivaViestit : MonoBehaviour
{
	// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x794120", Offset = "0x794120", VA = "0x794120")]
	public PrivaViestit()
	{
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06002121 RID: 8481 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000470")]
	private Firebase firebase
	{
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x794190", Offset = "0x794190", VA = "0x794190")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9D")]
	[Address(RVA = "0x794238", Offset = "0x794238", VA = "0x794238")]
	private void Start()
	{
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x794768", Offset = "0x794768", VA = "0x794768")]
	public void PrivaPaivitaViestit(string targetID)
	{
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x794A64", Offset = "0x794A64", VA = "0x794A64")]
	public void UusiViesti(string viesti, bool siirraAlas = true)
	{
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x794F3C", Offset = "0x794F3C", VA = "0x794F3C")]
	public void IlmoitusViesti(string _viesti)
	{
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x794ECC", Offset = "0x794ECC", VA = "0x794ECC")]
	[DebuggerHidden]
	private IEnumerator AsetaScrollPanelAlas()
	{
		return null;
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x7950C8", Offset = "0x7950C8", VA = "0x7950C8")]
	public void LahetaViesti(string viesti)
	{
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x794300", Offset = "0x794300", VA = "0x794300")]
	private void LataaAiemmatViestit()
	{
	}

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject tekstiObj;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform mainPanel;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x28")]
	public ScrollRect scrollR;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> objt;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x38")]
	public FirebaseControl fbControl;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x40")]
	public GameObject pcObj;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x48")]
	public int omatviestitPutkeen;

	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x2000540")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD8D0", Offset = "0x4BD8D0")]
	private sealed class <AsetaScrollPanelAlas>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x7950C0", Offset = "0x7950C0", VA = "0x7950C0")]
		[DebuggerHidden]
		public <AsetaScrollPanelAlas>c__Iterator0()
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x7954BC", Offset = "0x7954BC", VA = "0x7954BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A0")]
		private object Current
		{
			[Token(Token = "0x60023FF")]
			[Address(RVA = "0x795564", Offset = "0x795564", VA = "0x795564", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A1")]
		private object Current
		{
			[Token(Token = "0x6002400")]
			[Address(RVA = "0x79556C", Offset = "0x79556C", VA = "0x79556C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x795574", Offset = "0x795574", VA = "0x795574", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x795588", Offset = "0x795588", VA = "0x795588", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400157B")]
		[FieldOffset(Offset = "0x10")]
		internal PrivaViestit $this;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x400157C")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x400157D")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x400157E")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
