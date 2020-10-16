using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Android
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x2000194")]
	internal class EMAndroidJavaObject : IDisposable
	{
		// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x71AE2C", Offset = "0x71AE2C", VA = "0x71AE2C")]
		public EMAndroidJavaObject(string className, params object[] args)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x71AEB0", Offset = "0x71AEB0", VA = "0x71AEB0")]
		public EMAndroidJavaObject(AndroidJavaObject nativeObj)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002FA")]
		public AndroidJavaObject NativeObject
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x71AEDC", Offset = "0x71AEDC", VA = "0x71AEDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x71AEE4", Offset = "0x71AEE4", VA = "0x71AEE4", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x71AF14", Offset = "0x71AF14", VA = "0x71AF14")]
		public void Call(string methodName, params object[] args)
		{
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DAE")]
		public T Call<T>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x71AF5C", Offset = "0x71AF5C", VA = "0x71AF5C")]
		public void CallStatic(string methodName, params object[] args)
		{
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DB0")]
		public T CallStatic<T>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DB1")]
		public T Get<T>(string fieldName)
		{
			return null;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DB2")]
		public T GetStatic<T>(string fieldName)
		{
			return null;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB3")]
		public void Set<T>(string fieldName, T val)
		{
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		public void SetStatic<T>(string fieldName, T val)
		{
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x71AFA4", Offset = "0x71AFA4", VA = "0x71AFA4")]
		public IntPtr GetRawObject()
		{
			return 0;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x71AFD4", Offset = "0x71AFD4", VA = "0x71AFD4")]
		public IntPtr GetRawClass()
		{
			return 0;
		}

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x10")]
		private readonly AndroidJavaObject nativeObj;
	}
}
