using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000507 RID: 1287
[Token(Token = "0x20003A2")]
public class JackPlatformMover : MonoBehaviour
{
	// Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x74DF1C", Offset = "0x74DF1C", VA = "0x74DF1C")]
	public JackPlatformMover()
	{
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x74DF24", Offset = "0x74DF24", VA = "0x74DF24")]
	public void Init(JackPlatform pl, Vector3 spawnkohta)
	{
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x74E330", Offset = "0x74E330", VA = "0x74E330")]
	[DebuggerHidden]
	private IEnumerator Liiku()
	{
		return null;
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x74E3A8", Offset = "0x74E3A8", VA = "0x74E3A8")]
	private void Tuhoa()
	{
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x74E428", Offset = "0x74E428", VA = "0x74E428")]
	public Transform HaeTr()
	{
		return null;
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x74E430", Offset = "0x74E430", VA = "0x74E430")]
	public JackPlatform HaeTiedot()
	{
		return null;
	}

	// Token: 0x04001447 RID: 5191
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] sivupalat;

	// Token: 0x04001448 RID: 5192
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider2D maaTrigger;

	// Token: 0x04001449 RID: 5193
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x28")]
	public bool jaadyta;

	// Token: 0x0400144A RID: 5194
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x30")]
	private Transform tr;

	// Token: 0x0400144B RID: 5195
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x38")]
	private BoxCollider2D bc;

	// Token: 0x0400144C RID: 5196
	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x40")]
	private JackPlatform tiedot;

	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x200054E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE080", Offset = "0x4BE080")]
	private sealed class <Liiku>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x74E3A0", Offset = "0x74E3A0", VA = "0x74E3A0")]
		[DebuggerHidden]
		public <Liiku>c__Iterator0()
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x74E438", Offset = "0x74E438", VA = "0x74E438", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BC")]
		private object Current
		{
			[Token(Token = "0x6002453")]
			[Address(RVA = "0x74E608", Offset = "0x74E608", VA = "0x74E608", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BD")]
		private object Current
		{
			[Token(Token = "0x6002454")]
			[Address(RVA = "0x74E610", Offset = "0x74E610", VA = "0x74E610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x74E618", Offset = "0x74E618", VA = "0x74E618", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x74E62C", Offset = "0x74E62C", VA = "0x74E62C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x10")]
		internal JackPlatformMover $this;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
