using System;
using Il2CppDummyDll;

// Token: 0x02000476 RID: 1142
[Token(Token = "0x2000329")]
public class AuthenticationValues
{
	// Token: 0x06001DEA RID: 7658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x6FE45C", Offset = "0x6FE45C", VA = "0x6FE45C")]
	public AuthenticationValues()
	{
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x6FE46C", Offset = "0x6FE46C", VA = "0x6FE46C")]
	public AuthenticationValues(string userId)
	{
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EC")]
	public object AuthPostData
	{
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x6FE4A8", Offset = "0x6FE4A8", VA = "0x6FE4A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBEFC", Offset = "0x4BBEFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x6FE4B0", Offset = "0x6FE4B0", VA = "0x6FE4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBF0C", Offset = "0x4BBF0C")]
		private set
		{
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003ED")]
	public string UserId
	{
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x6FE4B8", Offset = "0x6FE4B8", VA = "0x6FE4B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBF1C", Offset = "0x4BBF1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x6FE4A0", Offset = "0x6FE4A0", VA = "0x6FE4A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBF2C", Offset = "0x4BBF2C")]
		set
		{
		}
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600188F")]
	[Address(RVA = "0x6FE4C0", Offset = "0x6FE4C0", VA = "0x6FE4C0", Slot = "4")]
	public virtual void SetAuthPostData(string stringData)
	{
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001890")]
	[Address(RVA = "0x6FE554", Offset = "0x6FE554", VA = "0x6FE554", Slot = "5")]
	public virtual void SetAuthPostData(byte[] byteData)
	{
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001891")]
	[Address(RVA = "0x6FE55C", Offset = "0x6FE55C", VA = "0x6FE55C", Slot = "6")]
	public virtual void AddAuthParameter(string key, string value)
	{
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x6FE7F4", Offset = "0x6FE7F4", VA = "0x6FE7F4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x040010CC RID: 4300
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x10")]
	public CustomAuthenticationType AuthType;

	// Token: 0x040010CD RID: 4301
	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x18")]
	public string AuthGetParameters;

	// Token: 0x040010CE RID: 4302
	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBE84", Offset = "0x4BBE84")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBE84", Offset = "0x4BBE84")]
	private object <AuthPostData>k__BackingField;

	// Token: 0x040010CF RID: 4303
	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x28")]
	public string Token;

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBEC0", Offset = "0x4BBEC0")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBEC0", Offset = "0x4BBEC0")]
	private string <UserId>k__BackingField;
}
