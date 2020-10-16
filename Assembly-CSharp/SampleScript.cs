using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleFirebaseUnity;
using UnityEngine;

// Token: 0x0200054D RID: 1357
[Token(Token = "0x20003CF")]
public class SampleScript : MonoBehaviour
{
	// Token: 0x060023E0 RID: 9184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D71")]
	[Address(RVA = "0xAAA50C", Offset = "0xAAA50C", VA = "0xAAA50C")]
	public SampleScript()
	{
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D72")]
	[Address(RVA = "0xAAA514", Offset = "0xAAA514", VA = "0xAAA514")]
	private void Start()
	{
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D73")]
	[Address(RVA = "0xAAA62C", Offset = "0xAAA62C", VA = "0xAAA62C")]
	private void GetOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D74")]
	[Address(RVA = "0xAAACBC", Offset = "0xAAACBC", VA = "0xAAACBC")]
	private void GetFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D75")]
	[Address(RVA = "0xAAB33C", Offset = "0xAAB33C", VA = "0xAAB33C")]
	private void SetOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D76")]
	[Address(RVA = "0xAAB3E8", Offset = "0xAAB3E8", VA = "0xAAB3E8")]
	private void SetFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0xAAB734", Offset = "0xAAB734", VA = "0xAAB734")]
	private void UpdateOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D78")]
	[Address(RVA = "0xAAB7E0", Offset = "0xAAB7E0", VA = "0xAAB7E0")]
	private void UpdateFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D79")]
	[Address(RVA = "0xAABB2C", Offset = "0xAABB2C", VA = "0xAABB2C")]
	private void DelOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0xAABBD8", Offset = "0xAABBD8", VA = "0xAABBD8")]
	private void DelFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7B")]
	[Address(RVA = "0xAABF24", Offset = "0xAABF24", VA = "0xAABF24")]
	private void PushOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0xAABFD0", Offset = "0xAABFD0", VA = "0xAABFD0")]
	private void PushFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0xAAC31C", Offset = "0xAAC31C", VA = "0xAAC31C")]
	private void GetRulesOKHandler(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0xAAC3D0", Offset = "0xAAC3D0", VA = "0xAAC3D0")]
	private void GetRulesFailHandler(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0xAAC664", Offset = "0xAAC664", VA = "0xAAC664")]
	private void GetTimeStamp(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D80")]
	[Address(RVA = "0xAAA8E0", Offset = "0xAAA8E0", VA = "0xAAA8E0")]
	private void DebugLog(string str)
	{
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D81")]
	[Address(RVA = "0xAAC978", Offset = "0xAAC978", VA = "0xAAC978")]
	private void DebugWarning(string str)
	{
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D82")]
	[Address(RVA = "0xAAB010", Offset = "0xAAB010", VA = "0xAAB010")]
	private void DebugError(string str)
	{
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D83")]
	[Address(RVA = "0xAAA5BC", Offset = "0xAAA5BC", VA = "0xAAA5BC")]
	[DebuggerHidden]
	private IEnumerator Tests()
	{
		return null;
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D84")]
	[Address(RVA = "0xAACCAC", Offset = "0xAACCAC", VA = "0xAACCAC")]
	private Dictionary<string, object> GetSampleScoreBoard()
	{
		return null;
	}

	// Token: 0x040015DA RID: 5594
	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x0")]
	private static int debug_idx;

	// Token: 0x040015DB RID: 5595
	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMesh textMesh;

	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200056C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BED4C", Offset = "0x4BED4C")]
	private sealed class <Tests>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0xAACCA4", Offset = "0xAACCA4", VA = "0xAACCA4")]
		[DebuggerHidden]
		public <Tests>c__Iterator0()
		{
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0xAAD0C8", Offset = "0xAAD0C8", VA = "0xAAD0C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005EE")]
		private object Current
		{
			[Token(Token = "0x60024E9")]
			[Address(RVA = "0xAAFEE4", Offset = "0xAAFEE4", VA = "0xAAFEE4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005EF")]
		private object Current
		{
			[Token(Token = "0x60024EA")]
			[Address(RVA = "0xAAFEEC", Offset = "0xAAFEEC", VA = "0xAAFEEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0xAAFEF4", Offset = "0xAAFEF4", VA = "0xAAFEF4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0xAAFF08", Offset = "0xAAFF08", VA = "0xAAFF08", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0xAAFF70", Offset = "0xAAFF70", VA = "0xAAFF70")]
		internal void <>m__0(Firebase sender, DataSnapshot snapshot)
		{
		}

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x400165C")]
		[FieldOffset(Offset = "0x10")]
		internal Firebase <firebase>__0;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x400165D")]
		[FieldOffset(Offset = "0x18")]
		internal Firebase <temporary>__0;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x400165E")]
		[FieldOffset(Offset = "0x20")]
		internal Firebase <lastUpdate>__0;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x400165F")]
		[FieldOffset(Offset = "0x28")]
		internal FirebaseObserver <observer>__0;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x4001660")]
		[FieldOffset(Offset = "0x30")]
		internal FirebaseQueue <firebaseQueue>__0;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x4001661")]
		[FieldOffset(Offset = "0x38")]
		internal SampleScript $this;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x4001662")]
		[FieldOffset(Offset = "0x40")]
		internal object $current;

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x48")]
		internal bool $disposing;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x4C")]
		internal int $PC;
	}
}
