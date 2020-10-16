using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x2000050")]
	public class ScrollableList : MonoBehaviour
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x59F28C", Offset = "0x59F28C", VA = "0x59F28C")]
		public ScrollableList()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action<ScrollableList, string, string> ItemSelected
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x59F438", Offset = "0x59F438", VA = "0x59F438")]
			add
			{
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x59F524", Offset = "0x59F524", VA = "0x59F524")]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action<ScrollableList> UIClosed
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x59F610", Offset = "0x59F610", VA = "0x59F610")]
			add
			{
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x59F6FC", Offset = "0x59F6FC", VA = "0x59F6FC")]
			remove
			{
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x59F7E8", Offset = "0x59F7E8", VA = "0x59F7E8")]
		public static ScrollableList Create(GameObject listPrefab, string title, Dictionary<string, string> items)
		{
			return null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x59F99C", Offset = "0x59F99C", VA = "0x59F99C")]
		public void Init()
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x59FEE0", Offset = "0x59FEE0", VA = "0x59FEE0")]
		public GameObject AddItem(string title, string subtitle)
		{
			return null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x5A0298", Offset = "0x5A0298", VA = "0x5A0298")]
		public void Close()
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x5A0340", Offset = "0x5A0340", VA = "0x5A0340")]
		private void EnableScroll()
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x5A03D0", Offset = "0x5A03D0", VA = "0x5A03D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B07D0", Offset = "0x4B07D0")]
		private static void <ItemSelected>m__0(ScrollableList A_0, string A_1, string A_2)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x5A03D4", Offset = "0x5A03D4", VA = "0x5A03D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B07E0", Offset = "0x4B07E0")]
		private static void <UIClosed>m__1(ScrollableList A_0)
		{
		}

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B0740", Offset = "0x4B0740")]
		public Vector3 position;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x34")]
		public bool horizontalScroll;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x35")]
		public bool verticalScroll;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x38")]
		public float width;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x3C")]
		public float height;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x40")]
		public float itemHeight;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x44")]
		public float spacing;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x48")]
		public int paddingLeft;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x4C")]
		public int paddingRight;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x50")]
		public int paddingTop;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x54")]
		public int paddingBottom;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x58")]
		public Color bodyColor;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x68")]
		public Color itemColor;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B0778", Offset = "0x4B0778")]
		public Text title;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x80")]
		public ScrollRect scrollRect;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x88")]
		public Transform content;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x90")]
		public GameObject itemPrefab;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, string> items;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B07B0", Offset = "0x4B07B0")]
		private static Action<ScrollableList, string, string> <>f__am$cache0;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B07C0", Offset = "0x4B07C0")]
		private static Action<ScrollableList> <>f__am$cache1;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000417")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B07F0", Offset = "0x4B07F0")]
		private sealed class <AddItem>c__AnonStorey0
		{
			// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x5A0290", Offset = "0x5A0290", VA = "0x5A0290")]
			public <AddItem>c__AnonStorey0()
			{
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x5A03D8", Offset = "0x5A03D8", VA = "0x5A03D8")]
			internal void <>m__0()
			{
			}

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x400125B")]
			[FieldOffset(Offset = "0x10")]
			internal string title;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x400125C")]
			[FieldOffset(Offset = "0x18")]
			internal string subtitle;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x400125D")]
			[FieldOffset(Offset = "0x20")]
			internal ScrollableList $this;
		}
	}
}
