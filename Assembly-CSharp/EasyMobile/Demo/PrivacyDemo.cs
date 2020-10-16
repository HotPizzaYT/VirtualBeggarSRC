using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x200004D")]
	public class PrivacyDemo : MonoBehaviour
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x5930A4", Offset = "0x5930A4", VA = "0x5930A4")]
		public PrivacyDemo()
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public static string UnityAnalyticsOptOutURL
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x5930B4", Offset = "0x5930B4", VA = "0x5930B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0588", Offset = "0x4B0588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x59311C", Offset = "0x59311C", VA = "0x59311C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0598", Offset = "0x4B0598")]
			private set
			{
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x593188", Offset = "0x593188", VA = "0x593188")]
		private void Awake()
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x59383C", Offset = "0x59383C", VA = "0x59383C")]
		private void Update()
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x593940", Offset = "0x593940", VA = "0x593940")]
		public void PreviewDefaultConsentDialog(bool dismissible = true)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x593CC4", Offset = "0x593CC4", VA = "0x593CC4")]
		public void ShowDemoConsentDialog(bool dismissible = true)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x593EB0", Offset = "0x593EB0", VA = "0x593EB0")]
		public void ShowLocalizedDemoConsentDialog(bool dismissible = true)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x593D2C", Offset = "0x593D2C", VA = "0x593D2C")]
		public static void ShowDemoConsentDialog(bool localize, bool dismissible)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x593F18", Offset = "0x593F18", VA = "0x593F18")]
		private static ConsentDialog ConstructConsentDialog(bool localize)
		{
			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x593410", Offset = "0x593410", VA = "0x593410")]
		public static void FetchUnityAnalyticsOptOutURL(Action<string> success, Action<string> failure)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5949B0", Offset = "0x5949B0", VA = "0x5949B0")]
		private static void OnFetchUnityAnalyticsURLSuccess(string url, Action<string> callback)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x59488C", Offset = "0x59488C", VA = "0x59488C")]
		private static void OnFetchUnityAnalyticsURLFailure(string error, Action<string> callback)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x594648", Offset = "0x594648", VA = "0x594648")]
		private static void SubscribeConsentDialogEvents(ConsentDialog dialog)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x594A74", Offset = "0x594A74", VA = "0x594A74")]
		private static void DemoDialog_Dismissed(ConsentDialog dialog)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x594AE4", Offset = "0x594AE4", VA = "0x594AE4")]
		private static void DemoDialog_Completed(ConsentDialog dialog, ConsentDialog.CompletedResults results)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x595098", Offset = "0x595098", VA = "0x595098")]
		private static void DemoDialog_ToggleStateUpdated(ConsentDialog dialog, string toggleId, bool isOn)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x593A30", Offset = "0x593A30", VA = "0x593A30")]
		private static void SubscribePreviewConsentDialogEvents()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5952D8", Offset = "0x5952D8", VA = "0x5952D8")]
		private static void PreviewDialog_Dismissed(ConsentDialog dialog)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x595348", Offset = "0x595348", VA = "0x595348")]
		private static void PreviewDialog_Completed(ConsentDialog dialog, ConsentDialog.CompletedResults results)
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x595768", Offset = "0x595768", VA = "0x595768")]
		private static void PreviewDialog_ToggleStateUpdated(ConsentDialog dialog, string toggleId, bool isOn)
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5959AC", Offset = "0x5959AC", VA = "0x5959AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B05A8", Offset = "0x4B05A8")]
		private static void <Awake>m__0(EEARegionStatus result)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x595A20", Offset = "0x595A20", VA = "0x595A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B05B8", Offset = "0x4B05B8")]
		private void <Awake>m__1(string url)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x595A28", Offset = "0x595A28", VA = "0x595A28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B05C8", Offset = "0x4B05C8")]
		private void <Awake>m__2(string error)
		{
		}

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000299")]
		public const string EasyMobilePolicyURL = "http://sglibgames.com/privacy-policies/easy-mobile-demo.html";

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400029A")]
		public const string AdMobPolicyURL = "https://support.google.com/admob/answer/6128543?hl=en";

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400029B")]
		public const string UnityAdsPolicyURL = "https://unity3d.com/legal/privacy-policy";

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400029C")]
		public const string OneSignalPolicyURL = "https://onesignal.com/privacy_policy";

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400029D")]
		public const string UnityAnalyticsOptOutURLPlaceholder = "UNITY_ANALYTICS_URL";

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0444", Offset = "0x4B0444")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4B0444", Offset = "0x4B0444")]
		private static string <UnityAnalyticsOptOutURL>k__BackingField;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400029F")]
		public const string Disclaimer = "<i><b>Disclaimer:</b> The below content is for demonstration purpose only. It is NOT intended to be used as-is in your apps. <b>SgLib Games</b> offers tools and information as a resource, but we don’t offer legal advice. We recommend you contact your legal counsel to find out how GDPR affects you.</i>\n---------\n";

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x40002A0")]
		public const string EnTitle = "Data Privacy Consent";

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x40002A1")]
		public const string EnFirstParagraph = "This app collects certain information about your use of our app that we would like your permission to use for advertising, analytics and notification purposes. We strictly follow our <a href=\"http://sglibgames.com/privacy-policies/easy-mobile-demo.html\">Privacy Policy</a> to access and process your information.\nConsent is optional, and you may use the app without granting consent. Please understand that some features may not function properly if you deny our access.";

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x40002A2")]
		public const string EnAdsToggleTitle = "Advertising";

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x40002A3")]
		public const string EnAdsToggleOnDesc = "You will receive relevant ads! Our ad providers will collect data and use a unique identifier on your device. You can review their policies: <a href=\"https://support.google.com/admob/answer/6128543?hl=en\">AdMob</a> and <a href=\"https://unity3d.com/legal/privacy-policy\">Unity Ads</a>.";

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x40002A4")]
		public const string EnAdsToggleOffDesc = "Our ad providers will collect data and use a unique identifier on your device to show you relevant ads. Here're their policies: <a href=\"https://support.google.com/admob/answer/6128543?hl=en\">AdMob</a> and <a href=\"https://unity3d.com/legal/privacy-policy\">Unity Ads</a>.";

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x40002A5")]
		public const string EnNotifsToggleTitle = "Notifications";

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x40002A6")]
		public const string EnNotifsToggleDesc = "Our service provider, OneSignal, will collect data and use a unique identifier on your device to send you push notifications. You can learn about <a href=\"https://onesignal.com/privacy_policy\">One Signal Privacy Policy</a>.";

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x40002A7")]
		public const string EnAnalyticsToggleTitle = "Analytics*";

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x40002A8")]
		public const string EnAnalyticsToogleDesc = "We use Unity Analytics service to collect certain analytical information necessary for us to improve this app. You can opt-out of this use by visiting <a href=\"UNITY_ANALYTICS_URL\">this link</a>.";

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x40002A9")]
		public const string EnAnalyticsToggleUnavailDesc = "We use Unity Analytics service to collect certain analytical information necessary for us to improve this app. You can opt-out of this use by visiting an opt-out URL, which unfortunately <b>can't be fetched now</b>. But you can opt-out later in the \"Privacy\" page of this app.";

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x40002AA")]
		public const string EnSecondParagraph = "Click the below button to confirm your consent. You can change this consent at any time in the \"Privacy\" page of this app.";

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x40002AB")]
		public const string EnButtonTitle = "Accept";

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x40002AC")]
		public const string FrTitle = "Consentement";

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x40002AD")]
		public const string FrFirstParagraph = "Cette application recueille certaines informations sur votre utilisation de notre application que nous aimerions que vous utilisiez à des fins de publicité, d'analyse et de notification. Nous suivons strictement notre <a href=\"http://sglibgames.com/privacy-policies/easy-mobile-demo.html\">Privacy Policy</a> pour accéder et traiter vos informations.\nLe consentement est facultatif et vous pouvez utiliser l'application sans donner votre consentement. S'il vous plaît comprendre que certaines fonctionnalités peuvent ne pas fonctionner correctement si vous refusez notre accès.";

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x40002AE")]
		public const string FrAdsToggleTitle = "La publicité";

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x40002AF")]
		public const string FrAdsToggleOnDesc = "Vous recevrez des annonces pertinentes! Nos fournisseurs de publicité collecteront des données et utiliseront un identifiant unique sur votre appareil. Vous pouvez revoir leurs politiques: <a href=\"https://support.google.com/admob/answer/6128543?hl=en\">AdMob</a> et <a href=\"https://unity3d.com/legal/privacy-policy\">Unity Ads</a>.";

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x40002B0")]
		public const string FrAdsToggleOffDesc = "Nos fournisseurs d'annonces collecteront des données et utiliseront un identifiant unique sur votre appareil pour vous montrer les annonces pertinentes. Voici leurs politiques: <a href=\"https://support.google.com/admob/answer/6128543?hl=en\">AdMob</a> et <a href=\"https://unity3d.com/legal/privacy-policy\">Unity Ads</a>.";

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x40002B1")]
		public const string FrNotifsToggleTitle = "Les notifications";

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x40002B2")]
		public const string FrNotifsToggleDesc = "Notre fournisseur de services, OneSignal, collectera des données et utilisera un identifiant unique sur votre appareil pour vous envoyer des notifications push. Vous pouvez en apprendre davantage sur <a href=\"https://onesignal.com/privacy_policy\">One Signal Privacy Policy</a>.";

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x40002B3")]
		public const string FrAnalyticsToggleTitle = "Analytique*";

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x40002B4")]
		public const string FrAnalyticsToogleDesc = "Nous utilisons le service Unity Analytics pour collecter certaines informations analytiques nécessaires à l'amélioration de cette application. Vous pouvez désactiver cette utilisation en visitant <a href=\"UNITY_ANALYTICS_URL\">ce lien</a>.";

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x40002B5")]
		public const string FrAnalyticsToggleUnavailDesc = "Nous utilisons le service Unity Analytics pour collecter certaines informations analytiques nécessaires à l'amélioration de cette application. Vous pouvez refuser cette utilisation en visitant une URL de désinscription, qui ne peut malheureusement pas être récupérée maintenant. Mais vous pouvez vous désinscrire plus tard dans la page \"Privacy\" de cette application";

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x40002B6")]
		public const string FrSecondParagraph = "Cliquez sur le bouton ci-dessous pour confirmer le consentement spécifié. Vous pouvez modifier ce consentement à tout moment dans la page \"Privacy\" de cette application.";

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x40002B7")]
		public const string FrButtonTitle = "Acceptez";

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x40002B8")]
		private const string AdsToggleId = "em-demo-consent-toggle-ads";

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x40002B9")]
		private const string NotifsToggleId = "em-demo-consent-toggle-notifs";

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x40002BA")]
		private const string UnityAnalyticsToggleId = "em-demo-consent-toggle-unity-analytics";

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x40002BB")]
		private const string AcceptButtonId = "em-demo-consent-button-ok";

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B0480", Offset = "0x4B0480")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x4B0480", Offset = "0x4B0480")]
		public bool shouldRequestConsent;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4B04E0", Offset = "0x4B04E0")]
		public GameObject isInEeaRegionDisplayer;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x28")]
		public DemoUtils demoUtils;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x8")]
		private static ConsentDialog mPreviewConsentDialog;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		private static ConsentDialog mDemoConsentDialog;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		private static ConsentDialog mDemoConsentDialogLocalized;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x20")]
		private static bool mIsInEEARegion;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0518", Offset = "0x4B0518")]
		private static Action<EEARegionStatus> <>f__am$cache0;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0528", Offset = "0x4B0528")]
		private static Action<ConsentDialog> <>f__mg$cache0;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0538", Offset = "0x4B0538")]
		private static ConsentDialog.CompletedHandler <>f__mg$cache1;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0548", Offset = "0x4B0548")]
		private static ConsentDialog.ToggleStateUpdatedHandler <>f__mg$cache2;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0558", Offset = "0x4B0558")]
		private static Action<ConsentDialog> <>f__mg$cache3;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0568", Offset = "0x4B0568")]
		private static ConsentDialog.CompletedHandler <>f__mg$cache4;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0578", Offset = "0x4B0578")]
		private static ConsentDialog.ToggleStateUpdatedHandler <>f__mg$cache5;

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x2000414")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B05D8", Offset = "0x4B05D8")]
		private sealed class <FetchUnityAnalyticsOptOutURL>c__AnonStorey0
		{
			// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F35")]
			[Address(RVA = "0x594884", Offset = "0x594884", VA = "0x594884")]
			public <FetchUnityAnalyticsOptOutURL>c__AnonStorey0()
			{
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0x595A30", Offset = "0x595A30", VA = "0x595A30")]
			internal void <>m__0(string url)
			{
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x595AA8", Offset = "0x595AA8", VA = "0x595AA8")]
			internal void <>m__1(string error)
			{
			}

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x4001251")]
			[FieldOffset(Offset = "0x10")]
			internal Action<string> success;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x4001252")]
			[FieldOffset(Offset = "0x18")]
			internal Action<string> failure;
		}
	}
}
