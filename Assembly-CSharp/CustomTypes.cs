using System;
using System.IO;
using ExitGames.Client.Photon;
using Il2CppDummyDll;

// Token: 0x02000459 RID: 1113
[Token(Token = "0x200030C")]
internal static class CustomTypes
{
	// Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x7066CC", Offset = "0x7066CC", VA = "0x7066CC")]
	internal static void Register()
	{
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x00008E98 File Offset: 0x00007098
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x706CB0", Offset = "0x706CB0", VA = "0x706CB0")]
	private static short SerializeVector3(MemoryStream outStream, object customobject)
	{
		return 0;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x706ED4", Offset = "0x706ED4", VA = "0x706ED4")]
	private static object DeserializeVector3(MemoryStream inStream, short length)
	{
		return null;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x00008EB0 File Offset: 0x000070B0
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x7070B4", Offset = "0x7070B4", VA = "0x7070B4")]
	private static short SerializeVector2(MemoryStream outStream, object customobject)
	{
		return 0;
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x7072B4", Offset = "0x7072B4", VA = "0x7072B4")]
	private static object DeserializeVector2(MemoryStream inStream, short length)
	{
		return null;
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00008EC8 File Offset: 0x000070C8
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x707464", Offset = "0x707464", VA = "0x707464")]
	private static short SerializeQuaternion(MemoryStream outStream, object customobject)
	{
		return 0;
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x7076A0", Offset = "0x7076A0", VA = "0x7076A0")]
	private static object DeserializeQuaternion(MemoryStream inStream, short length)
	{
		return null;
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x00008EE0 File Offset: 0x000070E0
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x707898", Offset = "0x707898", VA = "0x707898")]
	private static short SerializePhotonPlayer(MemoryStream outStream, object customobject)
	{
		return 0;
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x707B04", Offset = "0x707B04", VA = "0x707B04")]
	private static object DeserializePhotonPlayer(MemoryStream inStream, short length)
	{
		return null;
	}

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x0")]
	public static readonly byte[] memVector3;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x8")]
	public static readonly byte[] memVector2;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x10")]
	public static readonly byte[] memQuarternion;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x18")]
	public static readonly byte[] memPlayer;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB980", Offset = "0x4BB980")]
	private static SerializeStreamMethod <>f__mg$cache0;

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB990", Offset = "0x4BB990")]
	private static DeserializeStreamMethod <>f__mg$cache1;

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9A0", Offset = "0x4BB9A0")]
	private static SerializeStreamMethod <>f__mg$cache2;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9B0", Offset = "0x4BB9B0")]
	private static DeserializeStreamMethod <>f__mg$cache3;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9C0", Offset = "0x4BB9C0")]
	private static SerializeStreamMethod <>f__mg$cache4;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9D0", Offset = "0x4BB9D0")]
	private static DeserializeStreamMethod <>f__mg$cache5;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9E0", Offset = "0x4BB9E0")]
	private static SerializeStreamMethod <>f__mg$cache6;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BB9F0", Offset = "0x4BB9F0")]
	private static DeserializeStreamMethod <>f__mg$cache7;
}
