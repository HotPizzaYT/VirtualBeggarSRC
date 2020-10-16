using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200049A RID: 1178
[Token(Token = "0x200034B")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCCB8", Offset = "0x4BCCB8")]
[Attribute(Name = "RequireComponent", RVA = "0x4BCCB8", Offset = "0x4BCCB8")]
[Attribute(Name = "AddComponentMenu", RVA = "0x4BCCB8", Offset = "0x4BCCB8")]
public class PhotonAnimatorView : MonoBehaviour
{
	// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x77715C", Offset = "0x77715C", VA = "0x77715C")]
	public PhotonAnimatorView()
	{
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x777204", Offset = "0x777204", VA = "0x777204")]
	private void Awake()
	{
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x777298", Offset = "0x777298", VA = "0x777298")]
	private void Update()
	{
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x00009DE0 File Offset: 0x00007FE0
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x777C10", Offset = "0x777C10", VA = "0x777C10")]
	public bool DoesLayerSynchronizeTypeExist(int layerIndex)
	{
		return default(bool);
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x00009DF8 File Offset: 0x00007FF8
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x777CF0", Offset = "0x777CF0", VA = "0x777CF0")]
	public bool DoesParameterSynchronizeTypeExist(string name)
	{
		return default(bool);
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x777DD0", Offset = "0x777DD0", VA = "0x777DD0")]
	public List<PhotonAnimatorView.SynchronizedLayer> GetSynchronizedLayers()
	{
		return null;
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x777DD8", Offset = "0x777DD8", VA = "0x777DD8")]
	public List<PhotonAnimatorView.SynchronizedParameter> GetSynchronizedParameters()
	{
		return null;
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x00009E10 File Offset: 0x00008010
	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x777DE0", Offset = "0x777DE0", VA = "0x777DE0")]
	public PhotonAnimatorView.SynchronizeType GetLayerSynchronizeType(int layerIndex)
	{
		return PhotonAnimatorView.SynchronizeType.Disabled;
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x00009E28 File Offset: 0x00008028
	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x777F10", Offset = "0x777F10", VA = "0x777F10")]
	public PhotonAnimatorView.SynchronizeType GetParameterSynchronizeType(string name)
	{
		return PhotonAnimatorView.SynchronizeType.Disabled;
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x778040", Offset = "0x778040", VA = "0x778040")]
	public void SetLayerSynchronized(int layerIndex, PhotonAnimatorView.SynchronizeType synchronizeType)
	{
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x778208", Offset = "0x778208", VA = "0x778208")]
	public void SetParameterSynchronized(string name, PhotonAnimatorView.ParameterType type, PhotonAnimatorView.SynchronizeType synchronizeType)
	{
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x77741C", Offset = "0x77741C", VA = "0x77741C")]
	private void SerializeDataContinuously()
	{
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x777760", Offset = "0x777760", VA = "0x777760")]
	private void DeserializeDataContinuously()
	{
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x7783F8", Offset = "0x7783F8", VA = "0x7783F8")]
	private void SerializeDataDiscretly(PhotonStream stream)
	{
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x778700", Offset = "0x778700", VA = "0x778700")]
	private void DeserializeDataDiscretly(PhotonStream stream)
	{
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x778C58", Offset = "0x778C58", VA = "0x778C58")]
	private void SerializeSynchronizationTypeState(PhotonStream stream)
	{
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x778EB4", Offset = "0x778EB4", VA = "0x778EB4")]
	private void DeserializeSynchronizationTypeState(PhotonStream stream)
	{
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x779120", Offset = "0x779120", VA = "0x779120")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x040011D5 RID: 4565
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x18")]
	private Animator m_Animator;

	// Token: 0x040011D6 RID: 4566
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x20")]
	private PhotonStreamQueue m_StreamQueue;

	// Token: 0x040011D7 RID: 4567
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BCD68", Offset = "0x4BCD68")]
	[SerializeField]
	private bool ShowLayerWeightsInspector;

	// Token: 0x040011D8 RID: 4568
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x29")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BCDA0", Offset = "0x4BCDA0")]
	[SerializeField]
	private bool ShowParameterInspector;

	// Token: 0x040011D9 RID: 4569
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BCDD8", Offset = "0x4BCDD8")]
	[SerializeField]
	private List<PhotonAnimatorView.SynchronizedParameter> m_SynchronizeParameters;

	// Token: 0x040011DA RID: 4570
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BCE10", Offset = "0x4BCE10")]
	[SerializeField]
	private List<PhotonAnimatorView.SynchronizedLayer> m_SynchronizeLayers;

	// Token: 0x040011DB RID: 4571
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_ReceiverPosition;

	// Token: 0x040011DC RID: 4572
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x4C")]
	private float m_LastDeserializeTime;

	// Token: 0x040011DD RID: 4573
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x50")]
	private bool m_WasSynchronizeTypeChanged;

	// Token: 0x040011DE RID: 4574
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x58")]
	private PhotonView m_PhotonView;

	// Token: 0x0200049B RID: 1179
	[Token(Token = "0x200034C")]
	public enum ParameterType
	{
		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x4000E03")]
		Float = 1,
		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x4000E04")]
		Int = 3,
		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x4000E05")]
		Bool,
		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x4000E06")]
		Trigger = 9
	}

	// Token: 0x0200049C RID: 1180
	[Token(Token = "0x200034D")]
	public enum SynchronizeType
	{
		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x4000E08")]
		Disabled,
		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x4000E09")]
		Discrete,
		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x4000E0A")]
		Continuous
	}

	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200034E")]
	[Serializable]
	public class SynchronizedParameter
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x779540", Offset = "0x779540", VA = "0x779540")]
		public SynchronizedParameter()
		{
		}

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x10")]
		public PhotonAnimatorView.ParameterType Type;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x14")]
		public PhotonAnimatorView.SynchronizeType SynchronizeType;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x18")]
		public string Name;
	}

	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200034F")]
	[Serializable]
	public class SynchronizedLayer
	{
		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x779538", Offset = "0x779538", VA = "0x779538")]
		public SynchronizedLayer()
		{
		}

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x10")]
		public PhotonAnimatorView.SynchronizeType SynchronizeType;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x14")]
		public int LayerIndex;
	}

	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x2000538")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE48", Offset = "0x4BCE48")]
	private sealed class <DoesLayerSynchronizeTypeExist>c__AnonStorey0
	{
		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x7792A4", Offset = "0x7792A4", VA = "0x7792A4")]
		public <DoesLayerSynchronizeTypeExist>c__AnonStorey0()
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x7792AC", Offset = "0x7792AC", VA = "0x7792AC")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedLayer item)
		{
			return default(bool);
		}

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x400156E")]
		[FieldOffset(Offset = "0x10")]
		internal int layerIndex;
	}

	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x2000539")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE58", Offset = "0x4BCE58")]
	private sealed class <DoesParameterSynchronizeTypeExist>c__AnonStorey1
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x7792E8", Offset = "0x7792E8", VA = "0x7792E8")]
		public <DoesParameterSynchronizeTypeExist>c__AnonStorey1()
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x7792F0", Offset = "0x7792F0", VA = "0x7792F0")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedParameter item)
		{
			return default(bool);
		}

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0x10")]
		internal string name;
	}

	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x200053A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE68", Offset = "0x4BCE68")]
	private sealed class <GetLayerSynchronizeType>c__AnonStorey2
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x779380", Offset = "0x779380", VA = "0x779380")]
		public <GetLayerSynchronizeType>c__AnonStorey2()
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x779388", Offset = "0x779388", VA = "0x779388")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedLayer item)
		{
			return default(bool);
		}

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x4001570")]
		[FieldOffset(Offset = "0x10")]
		internal int layerIndex;
	}

	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x200053B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE78", Offset = "0x4BCE78")]
	private sealed class <GetParameterSynchronizeType>c__AnonStorey3
	{
		// Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x7793C4", Offset = "0x7793C4", VA = "0x7793C4")]
		public <GetParameterSynchronizeType>c__AnonStorey3()
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x7793CC", Offset = "0x7793CC", VA = "0x7793CC")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedParameter item)
		{
			return default(bool);
		}

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x4001571")]
		[FieldOffset(Offset = "0x10")]
		internal string name;
	}

	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x200053C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE88", Offset = "0x4BCE88")]
	private sealed class <SetLayerSynchronized>c__AnonStorey4
	{
		// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x77945C", Offset = "0x77945C", VA = "0x77945C")]
		public <SetLayerSynchronized>c__AnonStorey4()
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x779464", Offset = "0x779464", VA = "0x779464")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedLayer item)
		{
			return default(bool);
		}

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x4001572")]
		[FieldOffset(Offset = "0x10")]
		internal int layerIndex;
	}

	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x200053D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BCE98", Offset = "0x4BCE98")]
	private sealed class <SetParameterSynchronized>c__AnonStorey5
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x7794A0", Offset = "0x7794A0", VA = "0x7794A0")]
		public <SetParameterSynchronized>c__AnonStorey5()
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x7794A8", Offset = "0x7794A8", VA = "0x7794A8")]
		internal bool <>m__0(PhotonAnimatorView.SynchronizedParameter item)
		{
			return default(bool);
		}

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x10")]
		internal string name;
	}
}
