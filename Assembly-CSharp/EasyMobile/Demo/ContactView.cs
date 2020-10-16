using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x2000045")]
	public class ContactView : MonoBehaviour
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5741C4", Offset = "0x5741C4", VA = "0x5741C4")]
		public ContactView()
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000081")]
		public Button DeleteButton
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x5726F4", Offset = "0x5726F4", VA = "0x5726F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5725C4", Offset = "0x5725C4", VA = "0x5725C4")]
		public void UpdateContact(Contact contact)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x57433C", Offset = "0x57433C", VA = "0x57433C")]
		public Contact GetContact()
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5741CC", Offset = "0x5741CC", VA = "0x5741CC")]
		private string GetContactInfoText()
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x574344", Offset = "0x574344", VA = "0x574344")]
		private void LoadPhoto()
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x574234", Offset = "0x574234", VA = "0x574234")]
		private void UpdateAvatar()
		{
		}

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImage avatarImage;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text infoText;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button deleteButton;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button loadPhotoButton;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x38")]
		private Contact contact;
	}
}
