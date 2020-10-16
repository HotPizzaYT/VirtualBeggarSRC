using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AC RID: 1196
[Token(Token = "0x2000357")]
public class PhotonTransformViewRotationControl
{
	// Token: 0x06002044 RID: 8260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x78BCE0", Offset = "0x78BCE0", VA = "0x78BCE0")]
	public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel model)
	{
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x00009F30 File Offset: 0x00008130
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x78C660", Offset = "0x78C660", VA = "0x78C660")]
	public Quaternion GetRotation(Quaternion currentRotation)
	{
		return default(Quaternion);
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x78CCD4", Offset = "0x78CCD4", VA = "0x78CCD4")]
	public void OnPhotonSerializeView(Quaternion currentRotation, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x04001222 RID: 4642
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x10")]
	private PhotonTransformViewRotationModel m_Model;

	// Token: 0x04001223 RID: 4643
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion m_NetworkRotation;
}
