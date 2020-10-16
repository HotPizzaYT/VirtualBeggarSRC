using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon;

// Token: 0x02000485 RID: 1157
[Token(Token = "0x2000338")]
internal class PhotonHandler : MonoBehaviour, IPhotonPeerListener
{
	// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001983")]
	[Address(RVA = "0x779548", Offset = "0x779548", VA = "0x779548")]
	public PhotonHandler()
	{
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001984")]
	[Address(RVA = "0x779550", Offset = "0x779550", VA = "0x779550")]
	protected void Awake()
	{
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001985")]
	[Address(RVA = "0x779A10", Offset = "0x779A10", VA = "0x779A10")]
	protected void OnApplicationQuit()
	{
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x779C68", Offset = "0x779C68", VA = "0x779C68")]
	protected void OnDestroy()
	{
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x779CC4", Offset = "0x779CC4", VA = "0x779CC4")]
	protected void Update()
	{
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x77A1B0", Offset = "0x77A1B0", VA = "0x77A1B0")]
	protected void OnLevelWasLoaded(int level)
	{
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x77A264", Offset = "0x77A264", VA = "0x77A264")]
	protected void OnJoinedRoom()
	{
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x77A2E0", Offset = "0x77A2E0", VA = "0x77A2E0")]
	protected void OnCreatedRoom()
	{
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x7798AC", Offset = "0x7798AC", VA = "0x7798AC")]
	public static void StartFallbackSendAckThread()
	{
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198C")]
	[Address(RVA = "0x779AA0", Offset = "0x779AA0", VA = "0x779AA0")]
	public static void StopFallbackSendAckThread()
	{
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00009528 File Offset: 0x00007728
	[Token(Token = "0x600198D")]
	[Address(RVA = "0x77A370", Offset = "0x77A370", VA = "0x77A370")]
	public static bool FallbackSendAckThread()
	{
		return default(bool);
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198E")]
	[Address(RVA = "0x77A46C", Offset = "0x77A46C", VA = "0x77A46C", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x77A5FC", Offset = "0x77A5FC", VA = "0x77A5FC", Slot = "5")]
	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x77A600", Offset = "0x77A600", VA = "0x77A600", Slot = "6")]
	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x77A604", Offset = "0x77A604", VA = "0x77A604", Slot = "7")]
	public void OnEvent(EventData photonEvent)
	{
	}

	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00009540 File Offset: 0x00007740
	// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000415")]
	internal static CloudRegionCode BestRegionCodeInPreferences
	{
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x77A608", Offset = "0x77A608", VA = "0x77A608")]
		get
		{
			return CloudRegionCode.eu;
		}
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x77A950", Offset = "0x77A950", VA = "0x77A950")]
		set
		{
		}
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x77ABA8", Offset = "0x77ABA8", VA = "0x77ABA8")]
	protected internal static void PingAvailableRegionsAndConnectToBest()
	{
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x77AC4C", Offset = "0x77AC4C", VA = "0x77AC4C")]
	[DebuggerHidden]
	internal IEnumerator PingAvailableRegionsCoroutine(bool connectToBest)
	{
		return null;
	}

	// Token: 0x0400112F RID: 4399
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x0")]
	public static PhotonHandler SP;

	// Token: 0x04001130 RID: 4400
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x18")]
	public int updateInterval;

	// Token: 0x04001131 RID: 4401
	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x1C")]
	public int updateIntervalOnSerialize;

	// Token: 0x04001132 RID: 4402
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x20")]
	private int nextSendTickCount;

	// Token: 0x04001133 RID: 4403
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x24")]
	private int nextSendTickCountOnSerialize;

	// Token: 0x04001134 RID: 4404
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x8")]
	private static bool sendThreadShouldRun;

	// Token: 0x04001135 RID: 4405
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x9")]
	protected internal static bool AppQuits;

	// Token: 0x04001136 RID: 4406
	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x10")]
	protected internal static Type PingImplementation;

	// Token: 0x04001137 RID: 4407
	[Token(Token = "0x4000D6F")]
	private const string PPrefsKey = "PUNCloudBestRegion";

	// Token: 0x04001138 RID: 4408
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x18")]
	internal static CloudRegionCode BestRegionCodeCurrently;

	// Token: 0x04001139 RID: 4409
	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC69C", Offset = "0x4BC69C")]
	private static Func<bool> <>f__mg$cache0;

	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000536")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC6BC", Offset = "0x4BC6BC")]
	private sealed class <PingAvailableRegionsCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x77ACC0", Offset = "0x77ACC0", VA = "0x77ACC0")]
		[DebuggerHidden]
		public <PingAvailableRegionsCoroutine>c__Iterator0()
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x77AD1C", Offset = "0x77AD1C", VA = "0x77AD1C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000598")]
		private object Current
		{
			[Token(Token = "0x60023DB")]
			[Address(RVA = "0x77BBB0", Offset = "0x77BBB0", VA = "0x77BBB0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000599")]
		private object Current
		{
			[Token(Token = "0x60023DC")]
			[Address(RVA = "0x77BBB8", Offset = "0x77BBB8", VA = "0x77BBB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x77BBC0", Offset = "0x77BBC0", VA = "0x77BBC0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x77BBD4", Offset = "0x77BBD4", VA = "0x77BBD4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x10")]
		internal PhotonPingManager <pingManager>__0;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x18")]
		internal List<Region>.Enumerator $locvar0;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x30")]
		internal Region <best>__0;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x38")]
		internal bool connectToBest;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x40")]
		internal object $current;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x48")]
		internal bool $disposing;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x4C")]
		internal int $PC;
	}
}
