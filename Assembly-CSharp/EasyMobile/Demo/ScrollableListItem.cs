using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000051")]
	public class ScrollableListItem : MonoBehaviour
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x5A04CC", Offset = "0x5A04CC", VA = "0x5A04CC")]
		public ScrollableListItem()
		{
		}

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x18")]
		public Text title;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x20")]
		public Text subtitle;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x28")]
		public Button button;
	}
}
