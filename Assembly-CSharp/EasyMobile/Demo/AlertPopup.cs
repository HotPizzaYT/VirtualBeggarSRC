using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000012")]
	public class AlertPopup : MonoBehaviour
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x56F124", Offset = "0x56F124", VA = "0x56F124")]
		public AlertPopup()
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public string Title
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x56F18C", Offset = "0x56F18C", VA = "0x56F18C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x56F194", Offset = "0x56F194", VA = "0x56F194")]
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public string Message
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x56F1D8", Offset = "0x56F1D8", VA = "0x56F1D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x56F1E0", Offset = "0x56F1E0", VA = "0x56F1E0")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001C")]
		public UnityEvent<AlertPopup.ButtonName> OnClosed
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x56F224", Offset = "0x56F224", VA = "0x56F224")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x1700001D")]
		public bool IsShowing
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x56F22C", Offset = "0x56F22C", VA = "0x56F22C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x56F234", Offset = "0x56F234", VA = "0x56F234")]
		private void Awake()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x56F418", Offset = "0x56F418", VA = "0x56F418")]
		public void Alert()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x56F62C", Offset = "0x56F62C", VA = "0x56F62C")]
		public void Alert(string title, string message)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x56F480", Offset = "0x56F480", VA = "0x56F480")]
		public void Alert(string title, string message, string buttonMessage)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x56F690", Offset = "0x56F690", VA = "0x56F690")]
		public void Alert(string title, string message, string buttonAMessage, string buttonBMessage)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x56F738", Offset = "0x56F738", VA = "0x56F738")]
		public void Alert(string title, string message, string buttonAMessage, string buttonBMessage, string buttonCMessage)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x56F7E0", Offset = "0x56F7E0", VA = "0x56F7E0")]
		public void Hide(bool keepListeners = false)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x56F7EC", Offset = "0x56F7EC", VA = "0x56F7EC")]
		private void Hide(AlertPopup.ButtonName buttonName, bool keepListeners = false)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x56F880", Offset = "0x56F880", VA = "0x56F880")]
		private void RaiseOnClosed(AlertPopup.ButtonName buttonName)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x56F8F4", Offset = "0x56F8F4", VA = "0x56F8F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC628", Offset = "0x4AC628")]
		private void <Awake>m__0()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x56F900", Offset = "0x56F900", VA = "0x56F900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC638", Offset = "0x4AC638")]
		private void <Awake>m__1()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x56F90C", Offset = "0x56F90C", VA = "0x56F90C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC648", Offset = "0x4AC648")]
		private void <Awake>m__2()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject rootView;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button buttonA;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button buttonB;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button buttonC;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text buttonAText;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text buttonBText;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text buttonCText;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text titleText;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text messageText;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string title;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string message;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AlertPopup.IntEvent onClosed;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x400003A")]
		private const string defaultButtonText = "Ok";

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x78")]
		private bool isShowing;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000013")]
		public enum ButtonName
		{
			// Token: 0x04000048 RID: 72
			[Token(Token = "0x400003D")]
			None,
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x400003E")]
			ButtonA,
			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400003F")]
			ButtonB,
			// Token: 0x0400004B RID: 75
			[Token(Token = "0x4000040")]
			ButtonC
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000014")]
		[Serializable]
		public class IntEvent : UnityEvent<AlertPopup.ButtonName>
		{
			// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x56F918", Offset = "0x56F918", VA = "0x56F918")]
			public IntEvent()
			{
			}
		}
	}
}
