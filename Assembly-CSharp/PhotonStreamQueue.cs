using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200048C RID: 1164
[Token(Token = "0x200033E")]
public class PhotonStreamQueue
{
	// Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x78AD1C", Offset = "0x78AD1C", VA = "0x78AD1C")]
	public PhotonStreamQueue(int sampleRate)
	{
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x78ADB4", Offset = "0x78ADB4", VA = "0x78ADB4")]
	private void BeginWritePackage()
	{
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x78B294", Offset = "0x78B294", VA = "0x78B294")]
	public void Reset()
	{
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x78B304", Offset = "0x78B304", VA = "0x78B304")]
	public void SendNext(object obj)
	{
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x00009B58 File Offset: 0x00007D58
	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x78B3BC", Offset = "0x78B3BC", VA = "0x78B3BC")]
	public bool HasQueuedObjects()
	{
		return default(bool);
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x78B3CC", Offset = "0x78B3CC", VA = "0x78B3CC")]
	public object ReceiveNext()
	{
		return null;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x78B49C", Offset = "0x78B49C", VA = "0x78B49C")]
	public void Serialize(PhotonStream stream)
	{
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x78B604", Offset = "0x78B604", VA = "0x78B604")]
	public void Deserialize(PhotonStream stream)
	{
	}

	// Token: 0x04001170 RID: 4464
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x10")]
	private int m_SampleRate;

	// Token: 0x04001171 RID: 4465
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x14")]
	private int m_SampleCount;

	// Token: 0x04001172 RID: 4466
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x18")]
	private int m_ObjectsPerSample;

	// Token: 0x04001173 RID: 4467
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x1C")]
	private float m_LastSampleTime;

	// Token: 0x04001174 RID: 4468
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x20")]
	private int m_LastFrameCount;

	// Token: 0x04001175 RID: 4469
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x24")]
	private int m_NextObjectIndex;

	// Token: 0x04001176 RID: 4470
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x28")]
	private List<object> m_Objects;

	// Token: 0x04001177 RID: 4471
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsWriting;
}
