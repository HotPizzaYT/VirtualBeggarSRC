using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x200004A")]
	public class NotificationHandler : MonoBehaviour
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x58FDD8", Offset = "0x58FDD8", VA = "0x58FDD8")]
		public NotificationHandler()
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public static NotificationHandler Instance
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x58FDE0", Offset = "0x58FDE0", VA = "0x58FDE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B02FC", Offset = "0x4B02FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x58FE30", Offset = "0x58FE30", VA = "0x58FE30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B030C", Offset = "0x4B030C")]
			private set
			{
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x58FE84", Offset = "0x58FE84", VA = "0x58FE84")]
		private void Awake()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x58FFEC", Offset = "0x58FFEC", VA = "0x58FFEC")]
		private void OnEnable()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x590128", Offset = "0x590128", VA = "0x590128")]
		private void OnDisable()
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x590264", Offset = "0x590264", VA = "0x590264")]
		private void OnPushNotificationTokenReceived(string token)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x590314", Offset = "0x590314", VA = "0x590314")]
		private void OnLocalNotificationOpened(LocalNotification delivered)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x5919D8", Offset = "0x5919D8", VA = "0x5919D8")]
		private void OnPushNotificationOpened(RemoteNotification delivered)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x5903B0", Offset = "0x5903B0", VA = "0x5903B0")]
		private void DisplayNotification(Notification delivered, bool isRemote)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x5919E0", Offset = "0x5919E0", VA = "0x5919E0")]
		[DebuggerHidden]
		private IEnumerator CRWaitAndShowPopup(bool hasNewUpdate, string title, string message)
		{
			return null;
		}

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B02C0", Offset = "0x4B02C0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4B02C0", Offset = "0x4B02C0")]
		private static NotificationHandler <Instance>k__BackingField;

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000413")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B032C", Offset = "0x4B032C")]
		private sealed class <CRWaitAndShowPopup>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F2E")]
			[Address(RVA = "0x591A94", Offset = "0x591A94", VA = "0x591A94")]
			[DebuggerHidden]
			public <CRWaitAndShowPopup>c__Iterator0()
			{
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00002D78 File Offset: 0x00000F78
			[Token(Token = "0x6001F2F")]
			[Address(RVA = "0x591A9C", Offset = "0x591A9C", VA = "0x591A9C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004C6")]
			private object Current
			{
				[Token(Token = "0x6001F30")]
				[Address(RVA = "0x591C6C", Offset = "0x591C6C", VA = "0x591C6C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004C7")]
			private object Current
			{
				[Token(Token = "0x6001F31")]
				[Address(RVA = "0x591C74", Offset = "0x591C74", VA = "0x591C74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F32")]
			[Address(RVA = "0x591C7C", Offset = "0x591C7C", VA = "0x591C7C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F33")]
			[Address(RVA = "0x591C90", Offset = "0x591C90", VA = "0x591C90", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F34")]
			[Address(RVA = "0x591CF8", Offset = "0x591CF8", VA = "0x591CF8")]
			private static void <>m__0(int button)
			{
			}

			// Token: 0x04000337 RID: 823
			[Token(Token = "0x400124A")]
			[FieldOffset(Offset = "0x10")]
			internal bool hasNewUpdate;

			// Token: 0x04000338 RID: 824
			[Token(Token = "0x400124B")]
			[FieldOffset(Offset = "0x18")]
			internal string title;

			// Token: 0x04000339 RID: 825
			[Token(Token = "0x400124C")]
			[FieldOffset(Offset = "0x20")]
			internal string message;

			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400124D")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400124E")]
			[FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400124F")]
			[FieldOffset(Offset = "0x34")]
			internal int $PC;

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x4001250")]
			[FieldOffset(Offset = "0x0")]
			private static Action<int> <>f__am$cache0;
		}
	}
}
