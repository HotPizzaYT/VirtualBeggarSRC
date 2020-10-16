using System;
using Il2CppDummyDll;

// Token: 0x02000467 RID: 1127
[Token(Token = "0x200031A")]
public class FriendInfo
{
	// Token: 0x06001DC8 RID: 7624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x84908C", Offset = "0x84908C", VA = "0x84908C")]
	public FriendInfo()
	{
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E7")]
	public string Name
	{
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x849094", Offset = "0x849094", VA = "0x849094")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC24", Offset = "0x4BBC24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x84909C", Offset = "0x84909C", VA = "0x84909C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC34", Offset = "0x4BBC34")]
		protected internal set
		{
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00008F88 File Offset: 0x00007188
	// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E8")]
	public bool IsOnline
	{
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x8490A4", Offset = "0x8490A4", VA = "0x8490A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC44", Offset = "0x4BBC44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x8490AC", Offset = "0x8490AC", VA = "0x8490AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC54", Offset = "0x4BBC54")]
		protected internal set
		{
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003E9")]
	public string Room
	{
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x8490B8", Offset = "0x8490B8", VA = "0x8490B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC64", Offset = "0x4BBC64")]
		get
		{
			return null;
		}
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x8490C0", Offset = "0x8490C0", VA = "0x8490C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBC74", Offset = "0x4BBC74")]
		protected internal set
		{
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001DCF RID: 7631 RVA: 0x00008FA0 File Offset: 0x000071A0
	[Token(Token = "0x170003EA")]
	public bool IsInRoom
	{
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x8490C8", Offset = "0x8490C8", VA = "0x8490C8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x849154", Offset = "0x849154", VA = "0x849154", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBB70", Offset = "0x4BBB70")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBB70", Offset = "0x4BBB70")]
	private string <Name>k__BackingField;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBBAC", Offset = "0x4BBBAC")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBBAC", Offset = "0x4BBBAC")]
	private bool <IsOnline>k__BackingField;

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BBBE8", Offset = "0x4BBBE8")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BBBE8", Offset = "0x4BBBE8")]
	private string <Room>k__BackingField;
}
