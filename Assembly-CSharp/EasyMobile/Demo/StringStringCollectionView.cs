using System;
using System.Collections.Generic;
using EasyMobile.Internal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x2000046")]
	public class StringStringCollectionView : MonoBehaviour
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x5A1334", Offset = "0x5A1334", VA = "0x5A1334")]
		public StringStringCollectionView()
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public string Title
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x5A13B4", Offset = "0x5A13B4", VA = "0x5A13B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x5A13BC", Offset = "0x5A13BC", VA = "0x5A13BC")]
			set
			{
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x5A1400", Offset = "0x5A1400", VA = "0x5A1400")]
		public void Show(List<StringStringKeyValuePair> collection, string title)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x5A17A0", Offset = "0x5A17A0", VA = "0x5A17A0")]
		public void Hide()
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x5A17DC", Offset = "0x5A17DC", VA = "0x5A17DC")]
		private void ClearAddedElement()
		{
		}

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string title;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject root;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AddedStringStringView elementTemplate;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform addedElementsScrollView;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text titleText;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x40")]
		private List<StringStringKeyValuePair> Collection;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x48")]
		private List<AddedStringStringView> addedElements;

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000411")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFF6C", Offset = "0x4AFF6C")]
		private sealed class <Show>c__AnonStorey0
		{
			// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F2B")]
			[Address(RVA = "0x5A1790", Offset = "0x5A1790", VA = "0x5A1790")]
			public <Show>c__AnonStorey0()
			{
			}

			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4001246")]
			[FieldOffset(Offset = "0x10")]
			internal StringStringKeyValuePair pair;

			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4001247")]
			[FieldOffset(Offset = "0x18")]
			internal StringStringCollectionView $this;
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000412")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFF7C", Offset = "0x4AFF7C")]
		private sealed class <Show>c__AnonStorey1
		{
			// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x5A1798", Offset = "0x5A1798", VA = "0x5A1798")]
			public <Show>c__AnonStorey1()
			{
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F2D")]
			[Address(RVA = "0x5A191C", Offset = "0x5A191C", VA = "0x5A191C")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4001248")]
			[FieldOffset(Offset = "0x10")]
			internal AddedStringStringView newElement;

			// Token: 0x0400030A RID: 778
			[Token(Token = "0x4001249")]
			[FieldOffset(Offset = "0x18")]
			internal StringStringCollectionView.<Show>c__AnonStorey0 <>f__ref$0;
		}
	}
}
