using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleFirebaseUnity;

// Token: 0x02000513 RID: 1299
[Token(Token = "0x20003A8")]
public class FirebaseEvent
{
	// Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x83D6B4", Offset = "0x83D6B4", VA = "0x83D6B4")]
	public FirebaseEvent(Firebase _node)
	{
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x83D6E0", Offset = "0x83D6E0", VA = "0x83D6E0")]
	public void GetValue([Optional] FirebaseParam param)
	{
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x8476D4", Offset = "0x8476D4", VA = "0x8476D4")]
	private void OnGetSuccess(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x8478FC", Offset = "0x8478FC", VA = "0x8478FC")]
	private void OnGetFailed(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x847E20", Offset = "0x847E20", VA = "0x847E20")]
	public void UpdateValue(Dictionary<string, object> data)
	{
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x847EB8", Offset = "0x847EB8", VA = "0x847EB8")]
	public void DeleteValue()
	{
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x8480E4", Offset = "0x8480E4", VA = "0x8480E4")]
	private void OnDeleteSuccess(Firebase sender, DataSnapshot snapshot)
	{
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x8482C4", Offset = "0x8482C4", VA = "0x8482C4")]
	private void OnDeleteFailed(Firebase sender, FirebaseError err)
	{
	}

	// Token: 0x04001485 RID: 5253
	[Token(Token = "0x4001021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Firebase node;

	// Token: 0x04001486 RID: 5254
	[Token(Token = "0x4001022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DataSnapshot snap;

	// Token: 0x04001487 RID: 5255
	[Token(Token = "0x4001023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FirebaseError error;

	// Token: 0x04001488 RID: 5256
	[Token(Token = "0x4001024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int tila;
}
