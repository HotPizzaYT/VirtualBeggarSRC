using System;
using EasyMobile;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
[Token(Token = "0x200038D")]
public class CloudSaveAndroid : MonoBehaviour
{
	// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x6FF094", Offset = "0x6FF094", VA = "0x6FF094")]
	public CloudSaveAndroid()
	{
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAC")]
	[Address(RVA = "0x6FF09C", Offset = "0x6FF09C", VA = "0x6FF09C")]
	public void MakeSnapshot()
	{
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0x6FF9C8", Offset = "0x6FF9C8", VA = "0x6FF9C8")]
	public void LoadSavedGames()
	{
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x6FFB00", Offset = "0x6FFB00", VA = "0x6FFB00")]
	private void OpenSavedGameCallback(SavedGame savedGame, string error)
	{
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x6FFED8", Offset = "0x6FFED8", VA = "0x6FFED8")]
	public void LataaViimeisinCloudSave()
	{
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x700070", Offset = "0x700070", VA = "0x700070")]
	private void FetchAllSavedGames()
	{
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x7001C4", Offset = "0x7001C4", VA = "0x7001C4")]
	public void DeleteMainFile()
	{
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x700348", Offset = "0x700348", VA = "0x700348")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD940", Offset = "0x4BD940")]
	private void <MakeSnapshot>m__0(SavedGame updatedSavedGame, string error)
	{
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x7007C0", Offset = "0x7007C0", VA = "0x7007C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD950", Offset = "0x4BD950")]
	private void <LataaViimeisinCloudSave>m__1(SavedGame game, byte[] data, string error)
	{
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x700A64", Offset = "0x700A64", VA = "0x700A64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD960", Offset = "0x4BD960")]
	private static void <FetchAllSavedGames>m__2(SavedGame[] games, string error)
	{
	}

	// Token: 0x04001377 RID: 4983
	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x18")]
	public DataKasaaja dataManager;

	// Token: 0x04001378 RID: 4984
	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D mainImage;

	// Token: 0x04001379 RID: 4985
	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x28")]
	public CloudDataSiirtaja dataSiirtaja;

	// Token: 0x0400137A RID: 4986
	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x30")]
	private string lastDescription;

	// Token: 0x0400137B RID: 4987
	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x38")]
	private SavedGame mySavedGame;

	// Token: 0x0400137C RID: 4988
	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD930", Offset = "0x4BD930")]
	private static Action<SavedGame[], string> <>f__am$cache0;
}
