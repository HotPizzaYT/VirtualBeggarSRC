using System;
using Google.Developers;
using Il2CppDummyDll;
using UnityEngine;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20001ED")]
	public abstract class ResultCallbackProxy<R> : JavaInterfaceProxy, ResultCallback<R> where R : Result
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A5")]
		public ResultCallbackProxy()
		{
		}

		// Token: 0x06001503 RID: 5379
		[Token(Token = "0x60010A6")]
		public abstract void OnResult(R arg_Result_1);

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A7")]
		public void onResult(R arg_Result_1)
		{
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A8")]
		public void onResult(AndroidJavaObject arg_Result_1)
		{
		}

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000A0A")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/ResultCallback";
	}
}
