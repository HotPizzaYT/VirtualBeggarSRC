using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

// Token: 0x020004EA RID: 1258
[Token(Token = "0x2000392")]
public class DataKasaaja : MonoBehaviour
{
	// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x707E2C", Offset = "0x707E2C", VA = "0x707E2C")]
	public DataKasaaja()
	{
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x6FF740", Offset = "0x6FF740", VA = "0x6FF740")]
	public JsonData KasaaKaikkiData()
	{
		return null;
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x70B684", Offset = "0x70B684", VA = "0x70B684")]
	private Dictionary<string, int> ConvertToDictionary(string[] keys)
	{
		return null;
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x70B88C", Offset = "0x70B88C", VA = "0x70B88C")]
	private Dictionary<string, string> ConvertToDictionaryStr(string[] keys)
	{
		return null;
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x70BA68", Offset = "0x70BA68", VA = "0x70BA68")]
	private string[] KasaaIteroitavat(string[] itr)
	{
		return null;
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x70BC84", Offset = "0x70BC84", VA = "0x70BC84")]
	private string[] KasaaIteroitavatMaksimilla(string[] itr, int maksimiIndeksi)
	{
		return null;
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x70BE9C", Offset = "0x70BE9C", VA = "0x70BE9C")]
	private string[] KasaaIteroitavatMaxLong(string[] itr, int maksimiIndeksi)
	{
		return null;
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x6FEEA4", Offset = "0x6FEEA4", VA = "0x6FEEA4")]
	public void ReadData(string rawJsonData)
	{
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x70C108", Offset = "0x70C108", VA = "0x70C108")]
	private void ParseType(JsonData data, string header, TypeCode type)
	{
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x70C37C", Offset = "0x70C37C", VA = "0x70C37C")]
	public void PCLatauksenTestaus()
	{
	}

	// Token: 0x0400138B RID: 5003
	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x18")]
	private string[] essentialKeys;

	// Token: 0x0400138C RID: 5004
	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x20")]
	private string[] strs;

	// Token: 0x0400138D RID: 5005
	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x28")]
	private string[] iteroitavat;

	// Token: 0x0400138E RID: 5006
	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x30")]
	private string[] iteroitavatStr;

	// Token: 0x0400138F RID: 5007
	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x38")]
	private string[] iteroitavatMaxIndeksi;

	// Token: 0x04001390 RID: 5008
	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x40")]
	private string[] iteroitavatMaxLong;

	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x2000393")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x4BD970", Offset = "0x4BD970")]
	public class KeySet
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x70C50C", Offset = "0x70C50C", VA = "0x70C50C")]
		public KeySet()
		{
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public string Item
		{
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x70C57C", Offset = "0x70C57C", VA = "0x70C57C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BCC")]
			[Address(RVA = "0x70C5EC", Offset = "0x70C5EC", VA = "0x70C5EC")]
			set
			{
			}
		}

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x10")]
		public List<string> keys;
	}
}
