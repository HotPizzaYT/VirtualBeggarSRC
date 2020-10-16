using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200051C RID: 1308
[Token(Token = "0x20003AE")]
public class KuulaPong : MonoBehaviour
{
	// Token: 0x0600228B RID: 8843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x750E44", Offset = "0x750E44", VA = "0x750E44")]
	public KuulaPong()
	{
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x750E68", Offset = "0x750E68", VA = "0x750E68")]
	private void Awake()
	{
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x750ED8", Offset = "0x750ED8", VA = "0x750ED8")]
	private void Start()
	{
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x750EDC", Offset = "0x750EDC", VA = "0x750EDC")]
	public void AloitaPeli()
	{
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x750F78", Offset = "0x750F78", VA = "0x750F78")]
	public void LopetaPeli()
	{
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x751030", Offset = "0x751030", VA = "0x751030")]
	private void LateUpdate()
	{
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x751034", Offset = "0x751034", VA = "0x751034")]
	private void LiikutaKuulaa()
	{
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x751134", Offset = "0x751134", VA = "0x751134")]
	public void MuutaSuunta()
	{
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x751198", Offset = "0x751198", VA = "0x751198")]
	public void PeilaaXNopeus()
	{
	}

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06002294 RID: 8852 RVA: 0x0000A548 File Offset: 0x00008748
	// (set) Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000477")]
	public float Suunta
	{
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x7511A8", Offset = "0x7511A8", VA = "0x7511A8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x7511B0", Offset = "0x7511B0", VA = "0x7511B0")]
		set
		{
		}
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06002296 RID: 8854 RVA: 0x0000A560 File Offset: 0x00008760
	// (set) Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000478")]
	public float XNopeus
	{
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x7511B8", Offset = "0x7511B8", VA = "0x7511B8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x7511C0", Offset = "0x7511C0", VA = "0x7511C0")]
		set
		{
		}
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x06002298 RID: 8856 RVA: 0x0000A578 File Offset: 0x00008778
	// (set) Token: 0x06002299 RID: 8857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000479")]
	public float YNopeus
	{
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x7511C8", Offset = "0x7511C8", VA = "0x7511C8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x7511D0", Offset = "0x7511D0", VA = "0x7511D0")]
		set
		{
		}
	}

	// Token: 0x170005AE RID: 1454
	// (set) Token: 0x0600229A RID: 8858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047A")]
	public bool EnsimmainenPelaaja
	{
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x7511D8", Offset = "0x7511D8", VA = "0x7511D8")]
		set
		{
		}
	}

	// Token: 0x040014DA RID: 5338
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x18")]
	public Transform kuula;

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x20")]
	public NetworkManagerP nwManager;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x28")]
	public float ylaPaaty;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x2C")]
	public float alaPaaty;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x30")]
	public float nopeusLisays;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x34")]
	public float nopeusMax;

	// Token: 0x040014E0 RID: 5344
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x38")]
	public bool voitto;

	// Token: 0x040014E1 RID: 5345
	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x3C")]
	private float xNopeus;

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x40")]
	private float yNopeus;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x44")]
	private float tulevaXNopeus;

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x48")]
	private float suunta;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x4C")]
	private bool peliAlkanut;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x4D")]
	private bool ensimmainenPelaaja;
}
