using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x02000491 RID: 1169
[Token(Token = "0x2000343")]
[Attribute(Name = "AddComponentMenu", RVA = "0x4BC9C4", Offset = "0x4BC9C4")]
public class PhotonView : Photon.MonoBehaviour
{
	// Token: 0x06001FAC RID: 8108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x78DA94", Offset = "0x78DA94", VA = "0x78DA94")]
	public PhotonView()
	{
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00009B70 File Offset: 0x00007D70
	// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000447")]
	public int prefix
	{
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x78DB20", Offset = "0x78DB20", VA = "0x78DB20")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x78DBD8", Offset = "0x78DBD8", VA = "0x78DBD8")]
		set
		{
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000448")]
	public object[] instantiationData
	{
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x78DBE0", Offset = "0x78DBE0", VA = "0x78DBE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x78DC88", Offset = "0x78DC88", VA = "0x78DC88")]
		set
		{
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00009B88 File Offset: 0x00007D88
	// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000449")]
	public int viewID
	{
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x78DC90", Offset = "0x78DC90", VA = "0x78DC90")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x78DC98", Offset = "0x78DC98", VA = "0x78DC98")]
		set
		{
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x00009BA0 File Offset: 0x00007DA0
	[Token(Token = "0x1700044A")]
	public bool isSceneView
	{
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x78DD84", Offset = "0x78DD84", VA = "0x78DD84")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700044B")]
	public PhotonPlayer owner
	{
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x78DE14", Offset = "0x78DE14", VA = "0x78DE14")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x00009BB8 File Offset: 0x00007DB8
	[Token(Token = "0x1700044C")]
	public int OwnerActorNr
	{
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x78DE1C", Offset = "0x78DE1C", VA = "0x78DE1C")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00009BD0 File Offset: 0x00007DD0
	[Token(Token = "0x1700044D")]
	public bool isOwnerActive
	{
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x78DE24", Offset = "0x78DE24", VA = "0x78DE24")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00009BE8 File Offset: 0x00007DE8
	[Token(Token = "0x1700044E")]
	public int CreatorActorNr
	{
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x78DDA0", Offset = "0x78DDA0", VA = "0x78DDA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00009C00 File Offset: 0x00007E00
	[Token(Token = "0x1700044F")]
	public bool isMine
	{
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x78BE84", Offset = "0x78BE84", VA = "0x78BE84")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x78DEDC", Offset = "0x78DEDC", VA = "0x78DEDC")]
	protected internal void Awake()
	{
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x78DFAC", Offset = "0x78DFAC", VA = "0x78DFAC")]
	public void RequestOwnership()
	{
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x78E044", Offset = "0x78E044", VA = "0x78E044")]
	public void TransferOwnership(PhotonPlayer newOwner)
	{
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x78E078", Offset = "0x78E078", VA = "0x78E078")]
	public void TransferOwnership(int newOwnerId)
	{
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x78E118", Offset = "0x78E118", VA = "0x78E118")]
	protected internal void OnApplicationQuit()
	{
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x78E124", Offset = "0x78E124", VA = "0x78E124")]
	protected internal void OnDestroy()
	{
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x78E514", Offset = "0x78E514", VA = "0x78E514")]
	public void SerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x78EBBC", Offset = "0x78EBBC", VA = "0x78EBBC")]
	public void DeserializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x78ECC0", Offset = "0x78ECC0", VA = "0x78ECC0")]
	protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x78E618", Offset = "0x78E618", VA = "0x78E618")]
	protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x78F864", Offset = "0x78F864", VA = "0x78F864")]
	protected internal void ExecuteComponentOnSerialize(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x78FC18", Offset = "0x78FC18", VA = "0x78FC18")]
	public void RefreshRpcMonoBehaviourCache()
	{
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x78FC70", Offset = "0x78FC70", VA = "0x78FC70")]
	public void RPC(string methodName, PhotonTargets target, params object[] parameters)
	{
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x78FC80", Offset = "0x78FC80", VA = "0x78FC80")]
	public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x78FD14", Offset = "0x78FD14", VA = "0x78FD14")]
	public void RPC(string methodName, PhotonPlayer targetPlayer, params object[] parameters)
	{
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x78FDA4", Offset = "0x78FDA4", VA = "0x78FDA4")]
	public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, params object[] parameters)
	{
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x78FE38", Offset = "0x78FE38", VA = "0x78FE38")]
	public static PhotonView Get(Component component)
	{
		return null;
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x78FE94", Offset = "0x78FE94", VA = "0x78FE94")]
	public static PhotonView Get(GameObject gameObj)
	{
		return null;
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x78FEF0", Offset = "0x78FEF0", VA = "0x78FEF0")]
	public static PhotonView Find(int viewID)
	{
		return null;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x78FF74", Offset = "0x78FF74", VA = "0x78FF74", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x18")]
	public int ownerId;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x1C")]
	public int group;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x20")]
	protected internal bool mixedModeIsReliable;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x24")]
	public int prefixBackup;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x28")]
	private object[] instantiationDataField;

	// Token: 0x04001190 RID: 4496
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x30")]
	protected internal object[] lastOnSerializeDataSent;

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x38")]
	protected internal object[] lastOnSerializeDataReceived;

	// Token: 0x04001192 RID: 4498
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x40")]
	public Component observed;

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x48")]
	public ViewSynchronization synchronization;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x4C")]
	public OnSerializeTransform onSerializeTransformOption;

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x50")]
	public OnSerializeRigidBody onSerializeRigidBodyOption;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x54")]
	public OwnershipOption ownershipTransfer;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x58")]
	public List<Component> ObservedComponents;

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<Component, MethodInfo> m_OnSerializeMethodInfos;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool ObservedComponentsFoldoutOpen;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int viewIdField;

	// Token: 0x0400119B RID: 4507
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x70")]
	public int instantiationId;

	// Token: 0x0400119C RID: 4508
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x74")]
	protected internal bool didAwake;

	// Token: 0x0400119D RID: 4509
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x75")]
	[SerializeField]
	protected internal bool isRuntimeInstantiated;

	// Token: 0x0400119E RID: 4510
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x76")]
	protected internal bool destroyedByPhotonNetworkOrQuit;

	// Token: 0x0400119F RID: 4511
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x78")]
	private MethodInfo OnSerializeMethodInfo;

	// Token: 0x040011A0 RID: 4512
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x80")]
	private bool failedToFindOnSerialize;

	// Token: 0x040011A1 RID: 4513
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x88")]
	internal UnityEngine.MonoBehaviour[] RpcMonoBehaviours;
}
