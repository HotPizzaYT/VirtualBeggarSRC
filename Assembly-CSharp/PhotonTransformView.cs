using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A7 RID: 1191
[Token(Token = "0x2000352")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD048", Offset = "0x4BD048")]
[Attribute(Name = "AddComponentMenu", RVA = "0x4BD048", Offset = "0x4BD048")]
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x78B82C", Offset = "0x78B82C", VA = "0x78B82C")]
	public PhotonTransformView()
	{
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x78BB50", Offset = "0x78BB50", VA = "0x78BB50")]
	private void Awake()
	{
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x78BD9C", Offset = "0x78BD9C", VA = "0x78BD9C")]
	private void Update()
	{
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x78BF54", Offset = "0x78BF54", VA = "0x78BF54")]
	private void UpdatePosition()
	{
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x78C054", Offset = "0x78C054", VA = "0x78C054")]
	private void UpdateRotation()
	{
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x78C164", Offset = "0x78C164", VA = "0x78C164")]
	private void UpdateScale()
	{
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x78C9D4", Offset = "0x78C9D4", VA = "0x78C9D4")]
	public void SetSynchronizedValues(Vector3 speed, float turnSpeed)
	{
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x78CA30", Offset = "0x78CA30", VA = "0x78CA30", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x78CF7C", Offset = "0x78CF7C", VA = "0x78CF7C")]
	private void DoDrawEstimatedPositionError()
	{
	}

	// Token: 0x040011F9 RID: 4601
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PhotonTransformViewPositionModel m_PositionModel;

	// Token: 0x040011FA RID: 4602
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PhotonTransformViewRotationModel m_RotationModel;

	// Token: 0x040011FB RID: 4603
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PhotonTransformViewScaleModel m_ScaleModel;

	// Token: 0x040011FC RID: 4604
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x30")]
	private PhotonTransformViewPositionControl m_PositionControl;

	// Token: 0x040011FD RID: 4605
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x38")]
	private PhotonTransformViewRotationControl m_RotationControl;

	// Token: 0x040011FE RID: 4606
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x40")]
	private PhotonTransformViewScaleControl m_ScaleControl;

	// Token: 0x040011FF RID: 4607
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x48")]
	private PhotonView m_PhotonView;

	// Token: 0x04001200 RID: 4608
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x50")]
	private bool m_ReceivedNetworkUpdate;
}
