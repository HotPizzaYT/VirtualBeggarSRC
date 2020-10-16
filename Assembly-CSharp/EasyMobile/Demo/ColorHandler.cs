using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x2000016")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x4AC730", Offset = "0x4AC730")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x4AC730", Offset = "0x4AC730")]
	public class ColorHandler : MonoBehaviour
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x571374", Offset = "0x571374", VA = "0x571374")]
		public ColorHandler()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x571384", Offset = "0x571384", VA = "0x571384")]
		private void Start()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x571464", Offset = "0x571464", VA = "0x571464")]
		[DebuggerHidden]
		private IEnumerator CRChangeColor(float time)
		{
			return null;
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		public float lerpTime;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		public Color[] colors;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		private Image imgComp;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x38")]
		private Color currentColor;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x20003EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC78C", Offset = "0x4AC78C")]
		private sealed class <CRChangeColor>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x5714F4", Offset = "0x5714F4", VA = "0x5714F4")]
			[DebuggerHidden]
			public <CRChangeColor>c__Iterator0()
			{
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002178 File Offset: 0x00000378
			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x5714FC", Offset = "0x5714FC", VA = "0x5714FC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049C")]
			private object Current
			{
				[Token(Token = "0x6001E86")]
				[Address(RVA = "0x57191C", Offset = "0x57191C", VA = "0x57191C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600009D RID: 157 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700049D")]
			private object Current
			{
				[Token(Token = "0x6001E87")]
				[Address(RVA = "0x571924", Offset = "0x571924", VA = "0x571924", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x57192C", Offset = "0x57192C", VA = "0x57192C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x571940", Offset = "0x571940", VA = "0x571940", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4001190")]
			[FieldOffset(Offset = "0x10")]
			internal Color <newColor>__1;

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4001191")]
			[FieldOffset(Offset = "0x20")]
			internal float <elapsed>__2;

			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4001192")]
			[FieldOffset(Offset = "0x24")]
			internal float time;

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4001193")]
			[FieldOffset(Offset = "0x28")]
			internal Color <c>__3;

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4001194")]
			[FieldOffset(Offset = "0x38")]
			internal ColorHandler $this;

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4001195")]
			[FieldOffset(Offset = "0x40")]
			internal object $current;

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x4001196")]
			[FieldOffset(Offset = "0x48")]
			internal bool $disposing;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x4001197")]
			[FieldOffset(Offset = "0x4C")]
			internal int $PC;
		}
	}
}
