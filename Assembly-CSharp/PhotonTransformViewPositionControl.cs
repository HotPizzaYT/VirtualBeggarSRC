using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A8 RID: 1192
[Token(Token = "0x2000353")]
public class PhotonTransformViewPositionControl
{
	// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x78BC20", Offset = "0x78BC20", VA = "0x78BC20")]
	public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel model)
	{
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x00009ED0 File Offset: 0x000080D0
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x78D234", Offset = "0x78D234", VA = "0x78D234")]
	private Vector3 GetOldestStoredNetworkPosition()
	{
		return default(Vector3);
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x78CA24", Offset = "0x78CA24", VA = "0x78CA24")]
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x00009EE8 File Offset: 0x000080E8
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x78C264", Offset = "0x78C264", VA = "0x78C264")]
	public Vector3 UpdatePosition(Vector3 currentPosition)
	{
		return default(Vector3);
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00009F00 File Offset: 0x00008100
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x78D228", Offset = "0x78D228", VA = "0x78D228")]
	public Vector3 GetNetworkPosition()
	{
		return default(Vector3);
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x00009F18 File Offset: 0x00008118
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x78D2F4", Offset = "0x78D2F4", VA = "0x78D2F4")]
	public Vector3 GetExtrapolatedPositionOffset()
	{
		return default(Vector3);
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x78CBEC", Offset = "0x78CBEC", VA = "0x78CBEC")]
	public void OnPhotonSerializeView(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x78D650", Offset = "0x78D650", VA = "0x78D650")]
	private void SerializeData(Vector3 currentPosition, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x78D7A0", Offset = "0x78D7A0", VA = "0x78D7A0")]
	private void DeserializeData(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x04001201 RID: 4609
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x10")]
	private PhotonTransformViewPositionModel m_Model;

	// Token: 0x04001202 RID: 4610
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x18")]
	private float m_CurrentSpeed;

	// Token: 0x04001203 RID: 4611
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x20")]
	private double m_LastSerializeTime;

	// Token: 0x04001204 RID: 4612
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_SynchronizedSpeed;

	// Token: 0x04001205 RID: 4613
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x34")]
	private float m_SynchronizedTurnSpeed;

	// Token: 0x04001206 RID: 4614
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_NetworkPosition;

	// Token: 0x04001207 RID: 4615
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x48")]
	private Queue<Vector3> m_OldNetworkPositions;

	// Token: 0x04001208 RID: 4616
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x50")]
	private bool m_UpdatedPositionAfterOnSerialize;
}
