using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleFirebaseUnity;
using UnityEngine;

// Token: 0x02000500 RID: 1280
[Token(Token = "0x200039E")]
public class JackHiScores : MonoBehaviour
{
	// Token: 0x060021DF RID: 8671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x68DF08", Offset = "0x68DF08", VA = "0x68DF08")]
	public JackHiScores()
	{
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000475")]
	private Firebase firebase
	{
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x68DFB8", Offset = "0x68DFB8", VA = "0x68DFB8")]
		get
		{
			return null;
		}
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x68E060", Offset = "0x68E060", VA = "0x68E060")]
	private void Awake()
	{
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x68E138", Offset = "0x68E138", VA = "0x68E138")]
	public void AlustaKone(string _targetID)
	{
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x68E28C", Offset = "0x68E28C", VA = "0x68E28C")]
	[DebuggerHidden]
	private IEnumerator HaeOmaNimi()
	{
		return null;
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x68E7D0", Offset = "0x68E7D0", VA = "0x68E7D0")]
	private void HaeScoret()
	{
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x68EA6C", Offset = "0x68EA6C", VA = "0x68EA6C")]
	private void OnOmaKoneLadattu(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x68EF04", Offset = "0x68EF04", VA = "0x68EF04")]
	private void OnOmaKoneLadattuFail(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x68F658", Offset = "0x68F658", VA = "0x68F658")]
	public void PaivitaOmaScore(int _pisteet)
	{
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x68E2FC", Offset = "0x68E2FC", VA = "0x68E2FC")]
	private void AsetaScoret()
	{
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x0000A2F0 File Offset: 0x000084F0
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x68F4BC", Offset = "0x68F4BC", VA = "0x68F4BC")]
	private int OmaHighScore()
	{
		return 0;
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x0000A308 File Offset: 0x00008508
	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x68F918", Offset = "0x68F918", VA = "0x68F918")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BDF20", Offset = "0x4BDF20")]
	private static int <AsetaScoret>m__0(JackScore s)
	{
		return 0;
	}

	// Token: 0x04001415 RID: 5141
	[Token(Token = "0x4000FE1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject scoreSpawnObj;

	// Token: 0x04001416 RID: 5142
	[Token(Token = "0x4000FE2")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform spawnParentTr;

	// Token: 0x04001417 RID: 5143
	[Token(Token = "0x4000FE3")]
	[FieldOffset(Offset = "0x28")]
	public FirebaseControl fbControl;

	// Token: 0x04001418 RID: 5144
	[Token(Token = "0x4000FE4")]
	[FieldOffset(Offset = "0x30")]
	private List<JackScore> scoret;

	// Token: 0x04001419 RID: 5145
	[Token(Token = "0x4000FE5")]
	[FieldOffset(Offset = "0x38")]
	private List<JackScoreObj> scoreObj;

	// Token: 0x0400141A RID: 5146
	[Token(Token = "0x4000FE6")]
	[FieldOffset(Offset = "0x40")]
	private string omaNimi;

	// Token: 0x0400141B RID: 5147
	[Token(Token = "0x4000FE7")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BDEE0", Offset = "0x4BDEE0")]
	public string targetID;

	// Token: 0x0400141C RID: 5148
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x50")]
	private bool offlineMode;

	// Token: 0x0400141D RID: 5149
	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x51")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BDEF0", Offset = "0x4BDEF0")]
	public bool uusiEnnatys;

	// Token: 0x0400141E RID: 5150
	[Token(Token = "0x4000FEA")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BDF00", Offset = "0x4BDF00")]
	private static Func<JackScore, int> <>f__am$cache0;

	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x200054B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BDF30", Offset = "0x4BDF30")]
	private sealed class <HaeOmaNimi>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x68E7C8", Offset = "0x68E7C8", VA = "0x68E7C8")]
		[DebuggerHidden]
		public <HaeOmaNimi>c__Iterator0()
		{
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x68F944", Offset = "0x68F944", VA = "0x68F944", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B6")]
		private object Current
		{
			[Token(Token = "0x6002441")]
			[Address(RVA = "0x68FBE8", Offset = "0x68FBE8", VA = "0x68FBE8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B7")]
		private object Current
		{
			[Token(Token = "0x6002442")]
			[Address(RVA = "0x68FBF0", Offset = "0x68FBF0", VA = "0x68FBF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x68FBF8", Offset = "0x68FBF8", VA = "0x68FBF8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x68FC0C", Offset = "0x68FC0C", VA = "0x68FC0C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400141F RID: 5151
		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x10")]
		internal JackHiScores $this;

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x40015C6")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x40015C7")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x40015C8")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
