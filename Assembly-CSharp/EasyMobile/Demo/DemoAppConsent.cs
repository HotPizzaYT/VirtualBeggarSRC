using System;
using Il2CppDummyDll;

namespace EasyMobile.Demo
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x200004C")]
	[Serializable]
	public class DemoAppConsent
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x574380", Offset = "0x574380", VA = "0x574380")]
		public DemoAppConsent()
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x574388", Offset = "0x574388", VA = "0x574388", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x57439C", Offset = "0x57439C", VA = "0x57439C")]
		public void Save(string key)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5743D8", Offset = "0x5743D8", VA = "0x5743D8")]
		public static void ApplyDemoAppConsent(DemoAppConsent consent)
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x57451C", Offset = "0x57451C", VA = "0x57451C")]
		public static void SaveDemoAppConsent(DemoAppConsent consent)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x574598", Offset = "0x574598", VA = "0x574598")]
		public static DemoAppConsent LoadDemoAppConsent()
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000296")]
		public const string DemoStorageKey = "EM_Demo_AppConsent";

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x10")]
		public ConsentStatus advertisingConsent;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x14")]
		public ConsentStatus notificationConsent;
	}
}
