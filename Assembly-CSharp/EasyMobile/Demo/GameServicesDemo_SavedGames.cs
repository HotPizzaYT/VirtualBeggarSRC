using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000023")]
	public class GameServicesDemo_SavedGames : MonoBehaviour
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x5854E8", Offset = "0x5854E8", VA = "0x5854E8")]
		public GameServicesDemo_SavedGames()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5854F0", Offset = "0x5854F0", VA = "0x5854F0")]
		private void Start()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x5856D4", Offset = "0x5856D4", VA = "0x5856D4")]
		private void Update()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x58582C", Offset = "0x58582C", VA = "0x58582C")]
		public void ShowGPGSSelectSavedGameUI()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x585974", Offset = "0x585974", VA = "0x585974")]
		public void OpenSavedGame()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x585CAC", Offset = "0x585CAC", VA = "0x585CAC")]
		public void FetchAllSavedGames()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x585DD8", Offset = "0x585DD8", VA = "0x585DD8")]
		public void ReadSavedGame()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x585FD8", Offset = "0x585FD8", VA = "0x585FD8")]
		public void WriteSavedGame()
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5864CC", Offset = "0x5864CC", VA = "0x5864CC")]
		public void DeleteSavedGame()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x586678", Offset = "0x586678", VA = "0x586678")]
		private void OnSavedGameSelectedFromScrollableList(ScrollableList list, string title, string subtitle)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x585AAC", Offset = "0x585AAC", VA = "0x585AAC")]
		private void DoOpenSavedGame(string name, Action<SavedGame, string> callback)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x586834", Offset = "0x586834", VA = "0x586834")]
		private void OnSavedGameRead(SavedGame game, byte[] data, string error)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x586B88", Offset = "0x586B88", VA = "0x586B88")]
		private GameServicesDemo_SavedGames.DemoSavedGameData ByteArrayToSavedGameData(byte[] data)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x586414", Offset = "0x586414", VA = "0x586414")]
		private byte[] SavedGameDataToByteArray(GameServicesDemo_SavedGames.DemoSavedGameData dataObj)
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x586C40", Offset = "0x586C40", VA = "0x586C40")]
		private void OnSavedGameUpdated(SavedGame game, string error)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x586D74", Offset = "0x586D74", VA = "0x586D74")]
		private bool CanUseSavedGames()
		{
			return default(bool);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x586E58", Offset = "0x586E58", VA = "0x586E58")]
		private void SavedGamesUnavailableAlert()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x586EB4", Offset = "0x586EB4", VA = "0x586EB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADDF8", Offset = "0x4ADDF8")]
		private void <ShowGPGSSelectSavedGameUI>m__0(SavedGame game, string error)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x586FC4", Offset = "0x586FC4", VA = "0x586FC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE08", Offset = "0x4ADE08")]
		private void <OpenSavedGame>m__1(SavedGame game, string error)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5870FC", Offset = "0x5870FC", VA = "0x5870FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE18", Offset = "0x4ADE18")]
		private void <FetchAllSavedGames>m__2(SavedGame[] games, string error)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x587374", Offset = "0x587374", VA = "0x587374")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE28", Offset = "0x4ADE28")]
		private void <ReadSavedGame>m__3(SavedGame game, string error)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x587550", Offset = "0x587550", VA = "0x587550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE38", Offset = "0x4ADE38")]
		private void <DeleteSavedGame>m__4(int button)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x587684", Offset = "0x587684", VA = "0x587684")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE48", Offset = "0x4ADE48")]
		private SavedGameConflictResolutionStrategy <DoOpenSavedGame>m__5(SavedGame baseGame, byte[] baseData, SavedGame remoteGame, byte[] remoteData)
		{
			return SavedGameConflictResolutionStrategy.UseBase;
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4ADD50", Offset = "0x4ADD50")]
		public DemoUtils demoUtils;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject scrollableListPrefab;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4ADD88", Offset = "0x4ADD88")]
		public GameObject isSavedGamesEnabledInfo;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject isSavedGameSelectedInfo;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject isSavedGameOpenedInfo;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x40")]
		public GameObject autoConflictResolutionInfo;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x48")]
		public InputField savedGameNameInput;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x50")]
		public InputField savedGameDataInput;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x4ADDC0", Offset = "0x4ADDC0")]
		public bool resolveConflictsManually;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000124")]
		private const int TEST_DATA_BYTE_COUNT = 10240;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x60")]
		private SavedGame selectedSavedGame;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x68")]
		private SavedGame[] allSavedGames;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000024")]
		public class DemoSavedGameData
		{
			// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x586338", Offset = "0x586338", VA = "0x586338")]
			public DemoSavedGameData(int data)
			{
			}

			// Token: 0x0400015A RID: 346
			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x10")]
			public int demoInt;

			// Token: 0x0400015B RID: 347
			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x18")]
			public byte[] largeData;
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x20003F6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4ADE58", Offset = "0x4ADE58")]
		private sealed class <WriteSavedGame>c__AnonStorey0
		{
			// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x586330", Offset = "0x586330", VA = "0x586330")]
			public <WriteSavedGame>c__AnonStorey0()
			{
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x5878E0", Offset = "0x5878E0", VA = "0x5878E0")]
			internal void <>m__0(SavedGame game, string error)
			{
			}

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x40011C4")]
			[FieldOffset(Offset = "0x10")]
			internal byte[] data;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x40011C5")]
			[FieldOffset(Offset = "0x18")]
			internal GameServicesDemo_SavedGames $this;
		}
	}
}
