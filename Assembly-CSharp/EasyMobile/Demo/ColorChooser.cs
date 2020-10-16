using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000015")]
	[Attribute(Name = "RequireComponent", RVA = "0x4AC658", Offset = "0x4AC658")]
	[Attribute(Name = "RequireComponent", RVA = "0x4AC658", Offset = "0x4AC658")]
	public class ColorChooser : MonoBehaviour
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x570EA0", Offset = "0x570EA0", VA = "0x570EA0")]
		public ColorChooser()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event Action<Color> colorSelected
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x570EA8", Offset = "0x570EA8", VA = "0x570EA8")]
			add
			{
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x570FE8", Offset = "0x570FE8", VA = "0x570FE8")]
			remove
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x571128", Offset = "0x571128", VA = "0x571128")]
		private void Start()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x57120C", Offset = "0x57120C", VA = "0x57120C")]
		public void SelectColor()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x571370", Offset = "0x571370", VA = "0x571370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC720", Offset = "0x4AC720")]
		private static void <colorSelected>m__0(Color A_0)
		{
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x18")]
		private Image imgComp;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		private Button btnComp;
	}
}
