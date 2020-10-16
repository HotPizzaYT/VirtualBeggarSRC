using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class AdsSection
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x72376C", Offset = "0x72376C", VA = "0x72376C")]
		public AdsSection()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public bool IsUsingDefaultSection
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x72377C", Offset = "0x72377C", VA = "0x72377C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC234", Offset = "0x4AC234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x723784", Offset = "0x723784", VA = "0x723784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC244", Offset = "0x4AC244")]
			private set
			{
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x723790", Offset = "0x723790", VA = "0x723790", Slot = "4")]
		public virtual void Start()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x7238F0", Offset = "0x7238F0", VA = "0x7238F0")]
		public void Switch()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7238D0", Offset = "0x7238D0", VA = "0x7238D0")]
		public void Switch(bool isUsingDefaultSection)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x723914", Offset = "0x723914", VA = "0x723914", Slot = "5")]
		protected virtual void ShowDefaultSection()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x7239E4", Offset = "0x7239E4", VA = "0x7239E4", Slot = "6")]
		protected virtual void ShowCustomSection()
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected GameObject defaultRoot;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameObject customRoot;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Button enableDefaultSectionButton;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Button enableCustomSectionButton;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool useDefaultUIAsDefault;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC1F8", Offset = "0x4AC1F8")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AC1F8", Offset = "0x4AC1F8")]
		private bool <IsUsingDefaultSection>k__BackingField;
	}
}
