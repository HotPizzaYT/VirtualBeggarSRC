using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000049")]
	public class NativeUIDemo : MonoBehaviour
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x58F85C", Offset = "0x58F85C", VA = "0x58F85C")]
		public NativeUIDemo()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x58F864", Offset = "0x58F864", VA = "0x58F864")]
		private void Awake()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x58F900", Offset = "0x58F900", VA = "0x58F900")]
		public void ShowThreeButtonsAlert()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x58FA30", Offset = "0x58FA30", VA = "0x58FA30")]
		public void ShowTwoButtonsAlert()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x58FB54", Offset = "0x58FB54", VA = "0x58FB54")]
		public void ShowOneButtonAlert()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x58FC60", Offset = "0x58FC60", VA = "0x58FC60")]
		public void ShowToast()
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x58FCB4", Offset = "0x58FCB4", VA = "0x58FCB4")]
		private void OnAlertComplete(int buttonIndex)
		{
		}

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x18")]
		public GameObject isFirstButtonBool;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject isSecondButtonBool;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject isThirdButtonBool;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x30")]
		public DemoUtils demoUtils;
	}
}
