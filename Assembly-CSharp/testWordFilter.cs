using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Token(Token = "0x20003E5")]
public class testWordFilter : MonoBehaviour
{
	// Token: 0x06002504 RID: 9476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0xAC4B84", Offset = "0xAC4B84", VA = "0xAC4B84")]
	public testWordFilter()
	{
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E70")]
	[Address(RVA = "0xAC4C34", Offset = "0xAC4C34", VA = "0xAC4C34")]
	private void Start()
	{
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E71")]
	[Address(RVA = "0xAC4CD0", Offset = "0xAC4CD0", VA = "0xAC4CD0")]
	private void stringDone(string s)
	{
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E72")]
	[Address(RVA = "0xAC4CDC", Offset = "0xAC4CDC", VA = "0xAC4CDC")]
	private void OnGUI()
	{
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E73")]
	[Address(RVA = "0xAC5414", Offset = "0xAC5414", VA = "0xAC5414")]
	private void getRescourceFile(bool withReplacements)
	{
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0xAC5608", Offset = "0xAC5608", VA = "0xAC5608")]
	private void downloadWords(bool withReplacements)
	{
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0xAC5754", Offset = "0xAC5754", VA = "0xAC5754")]
	[DebuggerHidden]
	private IEnumerator waitForWords(WWW www)
	{
		return null;
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0xAC5714", Offset = "0xAC5714", VA = "0xAC5714")]
	private void finishedLoadingWords(string wordFileText)
	{
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0xAC530C", Offset = "0xAC530C", VA = "0xAC530C")]
	private string dots(float startTime, int n)
	{
		return null;
	}

	// Token: 0x0400166F RID: 5743
	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x18")]
	private string dirty;

	// Token: 0x04001670 RID: 5744
	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x20")]
	private string clean;

	// Token: 0x04001671 RID: 5745
	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x28")]
	private TWordFilter wf;

	// Token: 0x04001672 RID: 5746
	[Token(Token = "0x4001180")]
	[FieldOffset(Offset = "0x30")]
	private bool hasLoadedWords;

	// Token: 0x04001673 RID: 5747
	[Token(Token = "0x4001181")]
	[FieldOffset(Offset = "0x31")]
	private bool isloadingFile;

	// Token: 0x04001674 RID: 5748
	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x32")]
	private bool isFilteringString;

	// Token: 0x04001675 RID: 5749
	[Token(Token = "0x4001183")]
	[FieldOffset(Offset = "0x33")]
	private bool replacements;

	// Token: 0x04001676 RID: 5750
	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x34")]
	private float startTime;

	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x2000572")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BF01C", Offset = "0x4BF01C")]
	private sealed class <waitForWords>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x0600250D RID: 9485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250D")]
		[Address(RVA = "0xAC57E8", Offset = "0xAC57E8", VA = "0xAC57E8")]
		[DebuggerHidden]
		public <waitForWords>c__Iterator0()
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x600250E")]
		[Address(RVA = "0xAC57F0", Offset = "0xAC57F0", VA = "0xAC57F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FA")]
		private object Current
		{
			[Token(Token = "0x600250F")]
			[Address(RVA = "0xAC5948", Offset = "0xAC5948", VA = "0xAC5948", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FB")]
		private object Current
		{
			[Token(Token = "0x6002510")]
			[Address(RVA = "0xAC5950", Offset = "0xAC5950", VA = "0xAC5950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002511")]
		[Address(RVA = "0xAC5958", Offset = "0xAC5958", VA = "0xAC5958", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002512")]
		[Address(RVA = "0xAC596C", Offset = "0xAC596C", VA = "0xAC596C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0x10")]
		internal WWW www;

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0x18")]
		internal testWordFilter $this;

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x20")]
		internal object $current;

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x28")]
		internal bool $disposing;

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x2C")]
		internal int $PC;
	}
}
