using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000527 RID: 1319
[Token(Token = "0x20003B3")]
public class PlayerControl : MonoBehaviour
{
	// Token: 0x06002308 RID: 8968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD5")]
	[Address(RVA = "0x792D4C", Offset = "0x792D4C", VA = "0x792D4C")]
	public PlayerControl()
	{
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0x792D68", Offset = "0x792D68", VA = "0x792D68")]
	private void Start()
	{
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0x792E84", Offset = "0x792E84", VA = "0x792E84")]
	private void Update()
	{
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x792E88", Offset = "0x792E88", VA = "0x792E88")]
	private void InputMovement()
	{
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x7931E4", Offset = "0x7931E4", VA = "0x7931E4")]
	public void Kosketus(bool vas)
	{
	}

	// Token: 0x04001536 RID: 5430
	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	// Token: 0x04001537 RID: 5431
	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x1C")]
	public float vasenMax;

	// Token: 0x04001538 RID: 5432
	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x20")]
	public float oikeaMax;

	// Token: 0x04001539 RID: 5433
	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x24")]
	private bool vasKosketus;

	// Token: 0x0400153A RID: 5434
	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x25")]
	private bool oikKosketus;
}
