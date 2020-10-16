using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x02000525 RID: 1317
[Token(Token = "0x20003B2")]
public class NetworkMoverP : Photon.MonoBehaviour
{
	// Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x77319C", Offset = "0x77319C", VA = "0x77319C")]
	public NetworkMoverP()
	{
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x7731AC", Offset = "0x7731AC", VA = "0x7731AC")]
	private void Awake()
	{
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x773204", Offset = "0x773204", VA = "0x773204")]
	private void Start()
	{
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x7732D0", Offset = "0x7732D0", VA = "0x7732D0")]
	[DebuggerHidden]
	private IEnumerator UpdateData()
	{
		return null;
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD4")]
	[Address(RVA = "0x773348", Offset = "0x773348", VA = "0x773348")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x0400152C RID: 5420
	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x18")]
	public bool omaObjekti;

	// Token: 0x0400152D RID: 5421
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x1C")]
	private float posX;

	// Token: 0x0400152E RID: 5422
	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x20")]
	private Quaternion rotation;

	// Token: 0x0400152F RID: 5423
	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x30")]
	private float smoothing;

	// Token: 0x04001530 RID: 5424
	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x38")]
	private Transform myTr;

	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000560")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE858", Offset = "0x4BE858")]
	private sealed class <UpdateData>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002302 RID: 8962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x773340", Offset = "0x773340", VA = "0x773340")]
		[DebuggerHidden]
		public <UpdateData>c__Iterator0()
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x60024A6")]
		[Address(RVA = "0x7734A4", Offset = "0x7734A4", VA = "0x7734A4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D8")]
		private object Current
		{
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0x7737A0", Offset = "0x7737A0", VA = "0x7737A0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D9")]
		private object Current
		{
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0x7737A8", Offset = "0x7737A8", VA = "0x7737A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x7737B0", Offset = "0x7737B0", VA = "0x7737B0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x7737C4", Offset = "0x7737C4", VA = "0x7737C4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x10")]
		internal Vector3 <uusiPos>__1;

		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x20")]
		internal NetworkMoverP $this;

		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x28")]
		internal object $current;

		// Token: 0x04001534 RID: 5428
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x30")]
		internal bool $disposing;

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x34")]
		internal int $PC;
	}
}
