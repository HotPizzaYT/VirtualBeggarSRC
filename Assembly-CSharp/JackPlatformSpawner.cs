using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000509 RID: 1289
[Token(Token = "0x20003A3")]
public class JackPlatformSpawner : MonoBehaviour
{
	// Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x74E694", Offset = "0x74E694", VA = "0x74E694")]
	public JackPlatformSpawner()
	{
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x74DBC8", Offset = "0x74DBC8", VA = "0x74DBC8")]
	public void Spawn(JackPlatform pl, Vector3 spawnKohta)
	{
	}

	// Token: 0x04001451 RID: 5201
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x18")]
	public GameObject platform;

	// Token: 0x04001452 RID: 5202
	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x20")]
	public GameObject keskipala;

	// Token: 0x04001453 RID: 5203
	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BE0E0", Offset = "0x4BE0E0")]
	public JackPlatformMover nPlMover;
}
