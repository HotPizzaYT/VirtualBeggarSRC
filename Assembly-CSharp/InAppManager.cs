using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using EasyMobile;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000454 RID: 1108
[Token(Token = "0x2000308")]
public class InAppManager : MonoBehaviour
{
	// Token: 0x06001D97 RID: 7575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x689E20", Offset = "0x689E20", VA = "0x689E20")]
	public InAppManager()
	{
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x689E28", Offset = "0x689E28", VA = "0x689E28")]
	public void init()
	{
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x689E2C", Offset = "0x689E2C", VA = "0x689E2C")]
	private void Awake()
	{
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x689EC8", Offset = "0x689EC8", VA = "0x689EC8")]
	private void Start()
	{
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x689EF4", Offset = "0x689EF4", VA = "0x689EF4")]
	[DebuggerHidden]
	private IEnumerator HaeTuotteidenMetaData()
	{
		return null;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x689F6C", Offset = "0x689F6C", VA = "0x689F6C")]
	public void Purchase(string SKU)
	{
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x68A020", Offset = "0x68A020", VA = "0x68A020")]
	private void PurchaseCompletedHandler(IAPProduct product)
	{
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x68A6E4", Offset = "0x68A6E4", VA = "0x68A6E4")]
	private void PurchaseFailedHandler(IAPProduct product)
	{
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x68A058", Offset = "0x68A058", VA = "0x68A058")]
	private void OnProcessingConsumeProduct(string productID)
	{
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x68A800", Offset = "0x68A800", VA = "0x68A800")]
	private void LahetaHintatiedot(InAppManager.OstonMetaDataFull[] ostot)
	{
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x68B244", Offset = "0x68B244", VA = "0x68B244")]
	private void OnEnable()
	{
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x68B330", Offset = "0x68B330", VA = "0x68B330")]
	private void OnDisable()
	{
	}

	// Token: 0x04000F9B RID: 3995
	[Token(Token = "0x4000BDC")]
	private const string MYBASE64KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmjHvQXqrKoKcodEiSNfGAVPLTJxXqFnUq1DSMxlgXMMGcMvC7+Vj7y6oZ4Lgnyczospyctgn28NSVxvJ0MuDn/SIXqkWSbxaQeIKlUp6jZ71Ro543mpWVXpR49pi4rkJa4MFAhk08yUZug4HpbdsTShXDYoa0TgHJqOUun7rTkcl3mbJhDNiiiiW0zWk+jf7bmZBKS7xX0FsPHE1/TNCcpaCGc28IF56on7h9sE5I/Ka5sGOShm8Lrk28AnkSBiPPgbUuvVhsZjJBd79e3saJ6M6yoyMqj0WiwQd4KySVmtDjORWInXvOQ3UDlJaBXHDdnWYiEBTKUQruu7QaamYXwIDAQAB";

	// Token: 0x04000F9C RID: 3996
	[Token(Token = "0x4000BDD")]
	public const string ANDROID_TEST_PURCHASED = "android.test.purchased";

	// Token: 0x04000F9D RID: 3997
	[Token(Token = "0x4000BDE")]
	public const string ANDROID_TEST_CANCELED = "android.test.canceled";

	// Token: 0x04000F9E RID: 3998
	[Token(Token = "0x4000BDF")]
	public const string ANDROID_TEST_REFUNDED = "android.test.refunded";

	// Token: 0x04000F9F RID: 3999
	[Token(Token = "0x4000BE0")]
	public const string ANDROID_TEST_ITEM_UNAVALIABLE = "android.test.item_unavailable";

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB900", Offset = "0x4BB900")]
	private static Dictionary<string, int> <>f__switch$map0;

	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000309")]
	private class OstonMetaDataFull
	{
		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x68B72C", Offset = "0x68B72C", VA = "0x68B72C")]
		public OstonMetaDataFull()
		{
		}

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x10")]
		public string Id;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x18")]
		public string Price;
	}

	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000535")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB920", Offset = "0x4BB920")]
	private sealed class <HaeTuotteidenMetaData>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x689F64", Offset = "0x689F64", VA = "0x689F64")]
		[DebuggerHidden]
		public <HaeTuotteidenMetaData>c__Iterator0()
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x68B41C", Offset = "0x68B41C", VA = "0x68B41C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000596")]
		private object Current
		{
			[Token(Token = "0x60023D5")]
			[Address(RVA = "0x68B734", Offset = "0x68B734", VA = "0x68B734", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000597")]
		private object Current
		{
			[Token(Token = "0x60023D6")]
			[Address(RVA = "0x68B73C", Offset = "0x68B73C", VA = "0x68B73C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x68B744", Offset = "0x68B744", VA = "0x68B744", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x68B758", Offset = "0x68B758", VA = "0x68B758", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x10")]
		internal float <timeOutCalc>__0;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x18")]
		internal IAPProduct[] <products>__0;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x20")]
		internal List<InAppManager.OstonMetaDataFull> <metaData>__0;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x28")]
		internal IAPProduct[] $locvar0;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x30")]
		internal int $locvar1;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0x38")]
		internal InAppManager $this;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0x40")]
		internal object $current;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0x48")]
		internal bool $disposing;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0x4C")]
		internal int $PC;
	}
}
