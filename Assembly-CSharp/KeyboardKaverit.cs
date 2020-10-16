using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000514 RID: 1300
[Token(Token = "0x20003A9")]
public class KeyboardKaverit : MonoBehaviour
{
	// Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x7503B4", Offset = "0x7503B4", VA = "0x7503B4")]
	public KeyboardKaverit()
	{
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x750444", Offset = "0x750444", VA = "0x750444")]
	private void Awake()
	{
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x7504F0", Offset = "0x7504F0", VA = "0x7504F0")]
	private void Update()
	{
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x750CDC", Offset = "0x750CDC", VA = "0x750CDC")]
	public void AvaaKeyboard(int uusitila = 0)
	{
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x750AD0", Offset = "0x750AD0", VA = "0x750AD0")]
	private string SiivoaTeksti(string kohdeteksti, bool kaytafilteria = true)
	{
		return null;
	}

	// Token: 0x04001489 RID: 5257
	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x18")]
	public TextMesh inputTeksti;

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x20")]
	public GameObject vilkkuObj;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x28")]
	public string editorTestiNimi;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x30")]
	private string defaultTeksti;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x38")]
	private TouchScreenKeyboard keyboard;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x40")]
	private bool avattu;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x44")]
	private KeyboardKaverit.KeyboardKaveritTilat tila;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x48")]
	private GameObject pcObj;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x50")]
	private SanaFilter sanafilter;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x58")]
	private FirebaseControl fbControl;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x400102F")]
	private const int maxpituus = 14;

	// Token: 0x04001494 RID: 5268
	[Token(Token = "0x4001030")]
	private const int maxpituusPrivaviesti = 200;

	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x20003AA")]
	private enum KeyboardKaveritTilat
	{
		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001032")]
		eiMikaan,
		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001033")]
		rekisterointi,
		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001034")]
		kaverinHaku,
		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001035")]
		privaMessage
	}
}
