using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020004D3 RID: 1235
[Token(Token = "0x200037D")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x4BD808", Offset = "0x4BD808")]
public class MultiKeyDictionary<T1, T2, T3> : Dictionary<T1, Dictionary<T2, T3>>
{
	// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B55")]
	public MultiKeyDictionary()
	{
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000469")]
	public new Dictionary<T2, T3> Item
	{
		[Token(Token = "0x6001B56")]
		get
		{
			return null;
		}
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x0000A020 File Offset: 0x00008220
	[Token(Token = "0x6001B57")]
	public bool ContainsKey(T1 key1, T2 key2)
	{
		return default(bool);
	}
}
