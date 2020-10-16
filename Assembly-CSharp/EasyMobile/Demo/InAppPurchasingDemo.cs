using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000042")]
	public class InAppPurchasingDemo : MonoBehaviour
	{
		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5899FC", Offset = "0x5899FC", VA = "0x5899FC")]
		public InAppPurchasingDemo()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x589A6C", Offset = "0x589A6C", VA = "0x589A6C")]
		private void Awake()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x589B08", Offset = "0x589B08", VA = "0x589B08")]
		private void OnEnable()
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x589C34", Offset = "0x589C34", VA = "0x589C34")]
		private void OnDisable()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x589D60", Offset = "0x589D60", VA = "0x589D60")]
		private void OnPurchaseCompleted(IAPProduct product)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x589E84", Offset = "0x589E84", VA = "0x589E84")]
		private void OnPurchaseFailed(IAPProduct product)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x589F44", Offset = "0x589F44", VA = "0x589F44")]
		private void OnRestoreCompleted()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x589F70", Offset = "0x589F70", VA = "0x589F70")]
		[DebuggerHidden]
		private IEnumerator CROnRestoreCompleted()
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x589FD4", Offset = "0x589FD4", VA = "0x589FD4")]
		private void Start()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x58A314", Offset = "0x58A314", VA = "0x58A314")]
		private void Update()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x58A5B4", Offset = "0x58A5B4", VA = "0x58A5B4")]
		public void SelectProduct()
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x58A830", Offset = "0x58A830", VA = "0x58A830")]
		public void Purchase()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x58A8E0", Offset = "0x58A8E0", VA = "0x58A8E0")]
		public void ViewReceipt()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x58AFFC", Offset = "0x58AFFC", VA = "0x58AFFC")]
		public void ShowReceiptViewer(string receiptContent)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x58B0F4", Offset = "0x58B0F4", VA = "0x58B0F4")]
		public void HideReceiptViewer()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x58B128", Offset = "0x58B128", VA = "0x58B128")]
		public void GetSubscriptionInfo()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x58B790", Offset = "0x58B790", VA = "0x58B790")]
		public void RestorePurchases()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x58B7F4", Offset = "0x58B7F4", VA = "0x58B7F4")]
		private void OnItemSelected(ScrollableList list, string title, string subtitle)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x58A2A4", Offset = "0x58A2A4", VA = "0x58A2A4")]
		[DebuggerHidden]
		private IEnumerator CheckOwnedProducts()
		{
			return null;
		}

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x18")]
		public bool logProductLocalizedData;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject curtain;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject scrollableListPrefab;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject isInitInfo;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x38")]
		public Text ownedProductsInfo;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x40")]
		public Text selectedProductInfo;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x48")]
		public GameObject receiptViewer;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x50")]
		public DemoUtils demoUtils;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x58")]
		private IAPProduct selectedProduct;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x60")]
		private List<IAPProduct> ownedProducts;

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000408")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF990", Offset = "0x4AF990")]
		private sealed class <CROnRestoreCompleted>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x589FCC", Offset = "0x589FCC", VA = "0x589FCC")]
			[DebuggerHidden]
			public <CROnRestoreCompleted>c__Iterator0()
			{
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00002C28 File Offset: 0x00000E28
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x58BEA4", Offset = "0x58BEA4", VA = "0x58BEA4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B8")]
			private object Current
			{
				[Token(Token = "0x6001EFB")]
				[Address(RVA = "0x58BF80", Offset = "0x58BF80", VA = "0x58BF80", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B9")]
			private object Current
			{
				[Token(Token = "0x6001EFC")]
				[Address(RVA = "0x58BF88", Offset = "0x58BF88", VA = "0x58BF88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EFD")]
			[Address(RVA = "0x58BF90", Offset = "0x58BF90", VA = "0x58BF90", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x58BFA4", Offset = "0x58BFA4", VA = "0x58BFA4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x4001217")]
			[FieldOffset(Offset = "0x10")]
			internal object $current;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x4001218")]
			[FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x4001219")]
			[FieldOffset(Offset = "0x1C")]
			internal int $PC;
		}

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000409")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF9F0", Offset = "0x4AF9F0")]
		private sealed class <CheckOwnedProducts>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x58BB98", Offset = "0x58BB98", VA = "0x58BB98")]
			[DebuggerHidden]
			public <CheckOwnedProducts>c__Iterator1()
			{
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00002C40 File Offset: 0x00000E40
			[Token(Token = "0x6001F00")]
			[Address(RVA = "0x58BBA0", Offset = "0x58BBA0", VA = "0x58BBA0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060003AD RID: 941 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004BA")]
			private object Current
			{
				[Token(Token = "0x6001F01")]
				[Address(RVA = "0x58BE18", Offset = "0x58BE18", VA = "0x58BE18", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004BB")]
			private object Current
			{
				[Token(Token = "0x6001F02")]
				[Address(RVA = "0x58BE20", Offset = "0x58BE20", VA = "0x58BE20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F03")]
			[Address(RVA = "0x58BE28", Offset = "0x58BE28", VA = "0x58BE28", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F04")]
			[Address(RVA = "0x58BE3C", Offset = "0x58BE3C", VA = "0x58BE3C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x400121A")]
			[FieldOffset(Offset = "0x10")]
			internal IAPProduct[] <products>__0;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x400121B")]
			[FieldOffset(Offset = "0x18")]
			internal InAppPurchasingDemo $this;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x400121C")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x400121D")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x400121E")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}
	}
}
