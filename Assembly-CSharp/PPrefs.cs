using System;
using Il2CppDummyDll;

// Token: 0x02000544 RID: 1348
[Token(Token = "0x20003C8")]
public class PPrefs
{
	// Token: 0x060023AD RID: 9133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x793C8C", Offset = "0x793C8C", VA = "0x793C8C")]
	public PPrefs()
	{
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x793C94", Offset = "0x793C94", VA = "0x793C94")]
	private static void Init()
	{
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x793E04", Offset = "0x793E04", VA = "0x793E04")]
	public static void SetInt(string key, int target)
	{
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x0000A7E8 File Offset: 0x000089E8
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x793F60", Offset = "0x793F60", VA = "0x793F60")]
	public static int GetInt(string key, int defVal = 0)
	{
		return 0;
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4E")]
	[Address(RVA = "0x77AB00", Offset = "0x77AB00", VA = "0x77AB00")]
	public static void SetString(string key, string target)
	{
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D4F")]
	[Address(RVA = "0x77A6D4", Offset = "0x77A6D4", VA = "0x77A6D4")]
	public static string GetString(string key, string defVal = "")
	{
		return null;
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x0000A800 File Offset: 0x00008A00
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0x794008", Offset = "0x794008", VA = "0x794008")]
	public static bool HasKey(string key)
	{
		return default(bool);
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x77AA68", Offset = "0x77AA68", VA = "0x77AA68")]
	public static void DeleteKey(string key)
	{
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x7940A0", Offset = "0x7940A0", VA = "0x7940A0")]
	public static void DeleteAll()
	{
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x794100", Offset = "0x794100", VA = "0x794100")]
	public static void Save()
	{
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D54")]
	[Address(RVA = "0x793EFC", Offset = "0x793EFC", VA = "0x793EFC")]
	private static string GetTheNewKey(string key)
	{
		return null;
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x0000A818 File Offset: 0x00008A18
	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x793EAC", Offset = "0x793EAC", VA = "0x793EAC")]
	private static bool IsUsingTheNewSystem()
	{
		return default(bool);
	}

	// Token: 0x040015C8 RID: 5576
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x0")]
	public static bool theNewSystem;

	// Token: 0x040015C9 RID: 5577
	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x1")]
	public static bool inited;
}
