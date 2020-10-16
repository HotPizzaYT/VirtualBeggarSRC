using System;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004DF RID: 1247
[Token(Token = "0x2000388")]
public class TestReporter : MonoBehaviour
{
	// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0xAC3F90", Offset = "0xAC3F90", VA = "0xAC3F90")]
	public TestReporter()
	{
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B96")]
	[Address(RVA = "0xAC3FA8", Offset = "0xAC3FA8", VA = "0xAC3FA8")]
	private void Start()
	{
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B97")]
	[Address(RVA = "0xAC4568", Offset = "0xAC4568", VA = "0xAC4568")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B98")]
	[Address(RVA = "0xAC4598", Offset = "0xAC4598", VA = "0xAC4598")]
	private void threadLogTest()
	{
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B99")]
	[Address(RVA = "0xAC4670", Offset = "0xAC4670", VA = "0xAC4670")]
	private void Update()
	{
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0xAC488C", Offset = "0xAC488C", VA = "0xAC488C")]
	private void OnGUI()
	{
	}

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x18")]
	public int logTestCount;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x1C")]
	public int threadLogTestCount;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x20")]
	public bool logEverySecond;

	// Token: 0x0400135D RID: 4957
	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x24")]
	private int currentLogTestCount;

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x28")]
	private Reporter reporter;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x30")]
	private GUIStyle style;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x38")]
	private Rect rect1;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x48")]
	private Rect rect2;

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x58")]
	private Rect rect3;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x68")]
	private Rect rect4;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x78")]
	private Rect rect5;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x88")]
	private Rect rect6;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x98")]
	private Thread thread;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0xA0")]
	private float elapsed;
}
