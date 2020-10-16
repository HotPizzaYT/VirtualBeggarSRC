using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x200001D")]
	public class GameServicesDemo : MonoBehaviour
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x575404", Offset = "0x575404", VA = "0x575404")]
		public GameServicesDemo()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x57540C", Offset = "0x57540C", VA = "0x57540C")]
		private void Awake()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5754A8", Offset = "0x5754A8", VA = "0x5754A8")]
		private void Start()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5754F0", Offset = "0x5754F0", VA = "0x5754F0")]
		private void Update()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x575690", Offset = "0x575690", VA = "0x575690")]
		public void Init()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x575748", Offset = "0x575748", VA = "0x575748")]
		public void ShowLeaderboardUI()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x57580C", Offset = "0x57580C", VA = "0x57580C")]
		public void ShowSelectedLeaderboardUI()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x575910", Offset = "0x575910", VA = "0x575910")]
		public void ShowAchievementUI()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5759D4", Offset = "0x5759D4", VA = "0x5759D4")]
		public void SelectAchievement()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x575BF8", Offset = "0x575BF8", VA = "0x575BF8")]
		public void UnlockAchievement()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x575CF4", Offset = "0x575CF4", VA = "0x575CF4")]
		public void SelectLeaderboard()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x575F18", Offset = "0x575F18", VA = "0x575F18")]
		public void ReportScore()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x576358", Offset = "0x576358", VA = "0x576358")]
		public void LoadLocalUserScore()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x5764A4", Offset = "0x5764A4", VA = "0x5764A4")]
		public void LoadFriends()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5765AC", Offset = "0x5765AC", VA = "0x5765AC")]
		public void SignOut()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x576610", Offset = "0x576610", VA = "0x576610")]
		private void OnAchievementSelected(ScrollableList list, string title, string subtitle)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x576754", Offset = "0x576754", VA = "0x576754")]
		private void OnLeaderboardSelected(ScrollableList list, string title, string subtitle)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x576898", Offset = "0x576898", VA = "0x576898")]
		private void OnLocalUserScoreLoaded(string leaderboardName, IScore score)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x576BA8", Offset = "0x576BA8", VA = "0x576BA8")]
		private void OnFriendsLoaded(IUserProfile[] friends)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x576DF4", Offset = "0x576DF4", VA = "0x576DF4")]
		public void OpenSavedGamesDemo()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x576E14", Offset = "0x576E14", VA = "0x576E14")]
		public void OpenMultiplayerDemo()
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4ACA6C", Offset = "0x4ACA6C")]
		public GameObject curtain;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x20")]
		public GameObject isAutoInitInfo;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject isInitializedInfo;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x30")]
		public Text selectedAchievementInfo;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x38")]
		public Text selectedLeaderboardInfo;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x40")]
		public InputField scoreInput;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x48")]
		public DemoUtils demoUtils;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject scrollableListPrefab;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x58")]
		private Achievement selectedAchievement;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x60")]
		private Leaderboard selectedLeaderboard;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x68")]
		private bool lastLoginState;
	}
}
