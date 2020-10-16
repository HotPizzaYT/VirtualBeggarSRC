using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x200000C")]
	[Serializable]
	public class LoadAndShowSection<T, U> : AdsSection where T : LoadAndShowSection<T, U>.DefaultElement where U : LoadAndShowSection<T, U>.CustomElement
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		public LoadAndShowSection()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		public virtual void Start(DemoUtils demoUtils)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		public virtual void Update()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T defaultElement;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private U customElement;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x200000D")]
		[Serializable]
		public abstract class DefaultElement
		{
			// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600004C")]
			protected DefaultElement()
			{
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000059 RID: 89 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000D")]
			private protected DemoUtils DemoUtils
			{
				[Token(Token = "0x600004D")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC4F8", Offset = "0x4AC4F8")]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600004E")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC508", Offset = "0x4AC508")]
				private set
				{
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000E")]
			protected string LoadedStatusMessage
			{
				[Token(Token = "0x600004F")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000050")]
			public virtual void Start(DemoUtils demoUtils)
			{
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000051")]
			public void Update()
			{
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000052")]
			protected void ShowAdIfAvailable()
			{
			}

			// Token: 0x0600005F RID: 95
			[Token(Token = "0x6000053")]
			protected abstract void LoadAd();

			// Token: 0x06000060 RID: 96
			[Token(Token = "0x6000054")]
			protected abstract void ShowAd();

			// Token: 0x06000061 RID: 97
			[Token(Token = "0x6000055")]
			protected abstract bool IsAdReady();

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000062 RID: 98
			[Token(Token = "0x1700000F")]
			protected abstract string AdReadyMessage { [Token(Token = "0x6000056")] get; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000063 RID: 99
			[Token(Token = "0x17000010")]
			protected abstract string AdNotReadyMessage { [Token(Token = "0x6000057")] get; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000064 RID: 100
			[Token(Token = "0x17000011")]
			protected abstract string UnavailableAdAlertMessage { [Token(Token = "0x6000058")] get; }

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected Button loadAdButton;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected Button showAdButton;

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected GameObject isAdLoadedToggle;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC4BC", Offset = "0x4AC4BC")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AC4BC", Offset = "0x4AC4BC")]
			private DemoUtils <DemoUtils>k__BackingField;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x200000E")]
		[Serializable]
		public abstract class CustomElement : LoadAndShowSection<T, U>.DefaultElement
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000059")]
			protected CustomElement()
			{
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000012")]
			protected string CustomKey
			{
				[Token(Token = "0x600005A")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600005B")]
			public override void Start(DemoUtils demoUtils)
			{
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600005C")]
			private void InitEnableCustomKeyToggle()
			{
			}

			// Token: 0x06000069 RID: 105
			[Token(Token = "0x600005D")]
			protected abstract void InitNetworkDropdown();

			// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600005E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AC558", Offset = "0x4AC558")]
			private void <InitEnableCustomKeyToggle>m__0(bool flag)
			{
			}

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected Dropdown networkSelector;

			// Token: 0x04000035 RID: 53
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected GameObject inputFieldRoot;

			// Token: 0x04000036 RID: 54
			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected InputField customKeyInputField;

			// Token: 0x04000037 RID: 55
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected Toggle enableCustomKey;
		}
	}
}
