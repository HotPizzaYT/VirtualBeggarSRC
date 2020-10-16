using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Photon;

// Token: 0x020004BA RID: 1210
[Token(Token = "0x2000365")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD390", Offset = "0x4BD390")]
public class OnClickDestroy : MonoBehaviour
{
	// Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x773D80", Offset = "0x773D80", VA = "0x773D80")]
	public OnClickDestroy()
	{
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x773D88", Offset = "0x773D88", VA = "0x773D88")]
	public void OnClick()
	{
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x773E7C", Offset = "0x773E7C", VA = "0x773E7C")]
	[DebuggerHidden]
	[Attribute(Name = "PunRPC", RVA = "0x4BD3F4", Offset = "0x4BD3F4")]
	public IEnumerator DestroyRpc()
	{
		return null;
	}

	// Token: 0x04001258 RID: 4696
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x18")]
	public bool DestroyByRpc;

	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x200053E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD42C", Offset = "0x4BD42C")]
	private sealed class <DestroyRpc>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x773EEC", Offset = "0x773EEC", VA = "0x773EEC")]
		[DebuggerHidden]
		public <DestroyRpc>c__Iterator0()
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x773EF4", Offset = "0x773EF4", VA = "0x773EF4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700059C")]
		private object Current
		{
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x774078", Offset = "0x774078", VA = "0x774078", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700059D")]
		private object Current
		{
			[Token(Token = "0x60023F4")]
			[Address(RVA = "0x774080", Offset = "0x774080", VA = "0x774080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x774088", Offset = "0x774088", VA = "0x774088", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x77409C", Offset = "0x77409C", VA = "0x77409C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x10")]
		internal OnClickDestroy $this;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
