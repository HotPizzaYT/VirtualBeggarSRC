using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AF RID: 1199
[Token(Token = "0x200035A")]
public class PhotonTransformViewScaleControl
{
	// Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x78BD0C", Offset = "0x78BD0C", VA = "0x78BD0C")]
	public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel model)
	{
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x00009F48 File Offset: 0x00008148
	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x78C834", Offset = "0x78C834", VA = "0x78C834")]
	public Vector3 GetScale(Vector3 currentScale)
	{
		return default(Vector3);
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0x78CE28", Offset = "0x78CE28", VA = "0x78CE28")]
	public void OnPhotonSerializeView(Vector3 currentScale, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x10")]
	private PhotonTransformViewScaleModel m_Model;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_NetworkScale;
}
