using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x200004B")]
	public class NotificationsDemo : MonoBehaviour
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x591D68", Offset = "0x591D68", VA = "0x591D68")]
		public NotificationsDemo()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x591E2C", Offset = "0x591E2C", VA = "0x591E2C")]
		private void Awake()
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x591EC8", Offset = "0x591EC8", VA = "0x591EC8")]
		private void Start()
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x59214C", Offset = "0x59214C", VA = "0x59214C")]
		private void Update()
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x592270", Offset = "0x592270", VA = "0x592270")]
		public void Init()
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x592328", Offset = "0x592328", VA = "0x592328")]
		public void ScheduleLocalNotification()
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x59269C", Offset = "0x59269C", VA = "0x59269C")]
		public void ScheduleRepeatLocalNotification()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x5927B4", Offset = "0x5927B4", VA = "0x5927B4")]
		public void CancelPendingLocalNotification()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x592954", Offset = "0x592954", VA = "0x592954")]
		public void CancelAllPendingLocalNotifications()
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x5929F0", Offset = "0x5929F0", VA = "0x5929F0")]
		public void RemoveAllDeliveredNotifications()
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x592604", Offset = "0x592604", VA = "0x592604")]
		private bool InitCheck()
		{
			return default(bool);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x592A78", Offset = "0x592A78", VA = "0x592A78")]
		private void UpdatePendingNotificationList()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x592B24", Offset = "0x592B24", VA = "0x592B24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0434", Offset = "0x4B0434")]
		private void <UpdatePendingNotificationList>m__0(NotificationRequest[] pendingNotifs)
		{
		}

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B038C", Offset = "0x4B038C")]
		public string title;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		public string subtitle;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x28")]
		public string message;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x30")]
		public string categoryId;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x38")]
		public bool fakeNewUpdate;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x3C")]
		public int delayHours;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x40")]
		public int delayMinutes;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x44")]
		public int delaySeconds;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B03C4", Offset = "0x4B03C4")]
		public string repeatTitle;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x50")]
		public string repeatSubtitle;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x58")]
		public string repeatMessage;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x60")]
		public string repeatCategoryId;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x68")]
		public int repeatDelayHours;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x6C")]
		public int repeatDelayMinutes;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x70")]
		public int repeatDelaySeconds;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x74")]
		public NotificationRepeat repeatType;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B03FC", Offset = "0x4B03FC")]
		public GameObject curtain;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject pushNotifService;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x88")]
		public GameObject isAutoInitInfo;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x90")]
		public GameObject isInitializedInfo;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x98")]
		public Text pendingNotificationList;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xA0")]
		public InputField idInputField;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xA8")]
		public DemoUtils demoUtils;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0xB0")]
		private string orgNotificationListText;
	}
}
