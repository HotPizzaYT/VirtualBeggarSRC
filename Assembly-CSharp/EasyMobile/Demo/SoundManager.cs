using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x200001B")]
	[Attribute(Name = "RequireComponent", RVA = "0x4AC9AC", Offset = "0x4AC9AC")]
	public class SoundManager : MonoBehaviour
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5A1044", Offset = "0x5A1044", VA = "0x5A1044")]
		public SoundManager()
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public static SoundManager Instance
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5A104C", Offset = "0x5A104C", VA = "0x5A104C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACA4C", Offset = "0x4ACA4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x5A109C", Offset = "0x5A109C", VA = "0x5A109C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACA5C", Offset = "0x4ACA5C")]
			private set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000020")]
		public AudioSource AudioSource
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x5A10F0", Offset = "0x5A10F0", VA = "0x5A10F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5A1190", Offset = "0x5A1190", VA = "0x5A1190")]
		private void Awake()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5A12F8", Offset = "0x5A12F8", VA = "0x5A12F8")]
		public void PlaySound(AudioClip sound)
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ACA10", Offset = "0x4ACA10")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4ACA10", Offset = "0x4ACA10")]
		private static SoundManager <Instance>k__BackingField;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip button;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource _audioSource;
	}
}
