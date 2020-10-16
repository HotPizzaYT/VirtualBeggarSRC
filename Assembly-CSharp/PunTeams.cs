using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C7 RID: 1223
[Token(Token = "0x2000371")]
public class PunTeams : MonoBehaviour
{
	// Token: 0x060020A7 RID: 8359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x795608", Offset = "0x795608", VA = "0x795608")]
	public PunTeams()
	{
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x795610", Offset = "0x795610", VA = "0x795610")]
	public void Start()
	{
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x7959D0", Offset = "0x7959D0", VA = "0x7959D0")]
	public void OnJoinedRoom()
	{
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x795E68", Offset = "0x795E68", VA = "0x795E68")]
	public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
	{
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x7959D4", Offset = "0x7959D4", VA = "0x7959D4")]
	public void UpdateTeams()
	{
	}

	// Token: 0x04001276 RID: 4726
	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<PunTeams.Team, List<PhotonPlayer>> PlayersPerTeam;

	// Token: 0x04001277 RID: 4727
	[Token(Token = "0x4000E90")]
	public const string TeamPlayerProp = "team";

	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x2000372")]
	public enum Team : byte
	{
		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4000E92")]
		none,
		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x4000E93")]
		red,
		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x4000E94")]
		blue
	}
}
