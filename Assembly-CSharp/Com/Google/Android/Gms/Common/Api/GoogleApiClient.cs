using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20001E9")]
	public class GoogleApiClient : JavaObjWrapper
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x70111C", Offset = "0x70111C", VA = "0x70111C")]
		public GoogleApiClient(IntPtr ptr)
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x701124", Offset = "0x701124", VA = "0x701124")]
		public GoogleApiClient()
		{
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x701178", Offset = "0x701178", VA = "0x701178")]
		public object getContext()
		{
			return null;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x701204", Offset = "0x701204", VA = "0x701204")]
		public void connect()
		{
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x701288", Offset = "0x701288", VA = "0x701288")]
		public void disconnect()
		{
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x70130C", Offset = "0x70130C", VA = "0x70130C")]
		public void dump(string arg_string_1, object arg_object_2, object arg_object_3, string[] arg_string_4)
		{
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x7014DC", Offset = "0x7014DC", VA = "0x7014DC")]
		public ConnectionResult blockingConnect(long arg_long_1, object arg_object_2)
		{
			return null;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x701640", Offset = "0x701640", VA = "0x701640")]
		public ConnectionResult blockingConnect()
		{
			return null;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x7016CC", Offset = "0x7016CC", VA = "0x7016CC")]
		public PendingResult<Status> clearDefaultAccountAndReconnect()
		{
			return null;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x701758", Offset = "0x701758", VA = "0x701758")]
		public ConnectionResult getConnectionResult(object arg_object_1)
		{
			return null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x701844", Offset = "0x701844", VA = "0x701844")]
		public int getSessionId()
		{
			return 0;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x7018D0", Offset = "0x7018D0", VA = "0x7018D0")]
		public bool isConnecting()
		{
			return default(bool);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x70195C", Offset = "0x70195C", VA = "0x70195C")]
		public bool isConnectionCallbacksRegistered(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x701A48", Offset = "0x701A48", VA = "0x701A48")]
		public bool isConnectionFailedListenerRegistered(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x701B34", Offset = "0x701B34", VA = "0x701B34")]
		public void reconnect()
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x701BB8", Offset = "0x701BB8", VA = "0x701BB8")]
		public void registerConnectionCallbacks(object arg_object_1)
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x701C9C", Offset = "0x701C9C", VA = "0x701C9C")]
		public void registerConnectionFailedListener(object arg_object_1)
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x701D80", Offset = "0x701D80", VA = "0x701D80")]
		public void stopAutoManage(object arg_object_1)
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x701E64", Offset = "0x701E64", VA = "0x701E64")]
		public void unregisterConnectionCallbacks(object arg_object_1)
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x701F48", Offset = "0x701F48", VA = "0x701F48")]
		public void unregisterConnectionFailedListener(object arg_object_1)
		{
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x70202C", Offset = "0x70202C", VA = "0x70202C")]
		public bool hasConnectedApi(object arg_object_1)
		{
			return default(bool);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x702118", Offset = "0x702118", VA = "0x702118")]
		public object getLooper()
		{
			return null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x7021A4", Offset = "0x7021A4", VA = "0x7021A4")]
		public bool isConnected()
		{
			return default(bool);
		}

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000A08")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/GoogleApiClient";
	}
}
