using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Photon;
using UnityEngine;

// Token: 0x020004B5 RID: 1205
[Token(Token = "0x2000360")]
[Attribute(Name = "RequireComponent", RVA = "0x4BD1C0", Offset = "0x4BD1C0")]
public class InRoomChat : Photon.MonoBehaviour
{
	// Token: 0x0600205F RID: 8287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x68C260", Offset = "0x68C260", VA = "0x68C260")]
	public InRoomChat()
	{
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x68C374", Offset = "0x68C374", VA = "0x68C374")]
	public void Start()
	{
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x68C3C8", Offset = "0x68C3C8", VA = "0x68C3C8")]
	public void OnGUI()
	{
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x68CA58", Offset = "0x68CA58", VA = "0x68CA58")]
	[Attribute(Name = "PunRPC", RVA = "0x4BD224", Offset = "0x4BD224")]
	public void Chat(string newLine, PhotonMessageInfo mi)
	{
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x68CC08", Offset = "0x68CC08", VA = "0x68CC08")]
	public void AddLine(string newLine)
	{
	}

	// Token: 0x04001244 RID: 4676
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x18")]
	public Rect GuiRect;

	// Token: 0x04001245 RID: 4677
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x28")]
	public bool IsVisible;

	// Token: 0x04001246 RID: 4678
	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x29")]
	public bool AlignBottom;

	// Token: 0x04001247 RID: 4679
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x30")]
	public List<string> messages;

	// Token: 0x04001248 RID: 4680
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x38")]
	private string inputLine;

	// Token: 0x04001249 RID: 4681
	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 scrollPos;

	// Token: 0x0400124A RID: 4682
	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ChatRPC;
}
