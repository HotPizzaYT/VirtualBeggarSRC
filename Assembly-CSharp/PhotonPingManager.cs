using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000492 RID: 1170
[Token(Token = "0x2000344")]
public class PhotonPingManager
{
	// Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x77B908", Offset = "0x77B908", VA = "0x77B908")]
	public PhotonPingManager()
	{
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000450")]
	public Region BestRegion
	{
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x77B9B4", Offset = "0x77B9B4", VA = "0x77B9B4")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00009C18 File Offset: 0x00007E18
	[Token(Token = "0x17000451")]
	public bool Done
	{
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x77B9A4", Offset = "0x77B9A4", VA = "0x77B9A4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x77B910", Offset = "0x77B910", VA = "0x77B910")]
	[DebuggerHidden]
	public IEnumerator PingSocket(Region region)
	{
		return null;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x7869BC", Offset = "0x7869BC", VA = "0x7869BC")]
	public static string ResolveHost(string hostName)
	{
		return null;
	}

	// Token: 0x040011A2 RID: 4514
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x10")]
	public bool UseNative;

	// Token: 0x040011A3 RID: 4515
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x0")]
	public static int Attempts;

	// Token: 0x040011A4 RID: 4516
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x4")]
	public static bool IgnoreInitialAttempt;

	// Token: 0x040011A5 RID: 4517
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x8")]
	public static int MaxMilliseconsPerPing;

	// Token: 0x040011A6 RID: 4518
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x14")]
	private int PingsRunning;

	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000537")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCA7C", Offset = "0x4BCA7C")]
	private sealed class <PingSocket>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x7869B4", Offset = "0x7869B4", VA = "0x7869B4")]
		[DebuggerHidden]
		public <PingSocket>c__Iterator0()
		{
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x786CD4", Offset = "0x786CD4", VA = "0x786CD4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700059A")]
		private object Current
		{
			[Token(Token = "0x60023E1")]
			[Address(RVA = "0x787454", Offset = "0x787454", VA = "0x787454", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700059B")]
		private object Current
		{
			[Token(Token = "0x60023E2")]
			[Address(RVA = "0x78745C", Offset = "0x78745C", VA = "0x78745C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x787464", Offset = "0x787464", VA = "0x787464", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x787478", Offset = "0x787478", VA = "0x787478", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x10")]
		internal Region region;

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x18")]
		internal PhotonPing <ping>__1;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x20")]
		internal float <rttSum>__0;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x24")]
		internal int <replyCount>__0;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x28")]
		internal string <cleanIpOfRegion>__0;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x30")]
		internal int <indexOfColon>__0;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x34")]
		internal int <i>__2;

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x38")]
		internal bool <overtime>__3;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x40")]
		internal Stopwatch <sw>__3;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x4001569")]
		[FieldOffset(Offset = "0x48")]
		internal int <rtt>__3;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x50")]
		internal PhotonPingManager $this;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x58")]
		internal object $current;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x60")]
		internal bool $disposing;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x400156D")]
		[FieldOffset(Offset = "0x64")]
		internal int $PC;
	}
}
