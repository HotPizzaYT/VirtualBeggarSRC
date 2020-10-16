using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000043")]
	[Serializable]
	public class AddedStringStringView : MonoBehaviour
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x723384", Offset = "0x723384", VA = "0x723384")]
		public AddedStringStringView()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action OnDestroy
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x72338C", Offset = "0x72338C", VA = "0x72338C")]
			add
			{
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x723478", Offset = "0x723478", VA = "0x723478")]
			remove
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x723564", Offset = "0x723564", VA = "0x723564")]
		public void Setup(string label, string value)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x7236D4", Offset = "0x7236D4", VA = "0x7236D4")]
		public void Destroy(bool invokeCallback)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x723764", Offset = "0x723764", VA = "0x723764")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFABC", Offset = "0x4AFABC")]
		private void <Setup>m__0()
		{
		}

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject root;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text stringView;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button removeButton;
	}
}
