using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20001EA")]
	public class PendingResult<R> : JavaObjWrapper where R : Result
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109B")]
		public PendingResult(IntPtr ptr)
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109C")]
		public PendingResult()
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109D")]
		public R await(long arg_long_1, object arg_object_2)
		{
			return null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109E")]
		public R await()
		{
			return null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x600109F")]
		public bool isCanceled()
		{
			return default(bool);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A0")]
		public void cancel()
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A1")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1)
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A2")]
		public void setResultCallback(ResultCallback<R> arg_ResultCallback_1, long arg_long_2, object arg_object_3)
		{
		}

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000A09")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/PendingResult";
	}
}
