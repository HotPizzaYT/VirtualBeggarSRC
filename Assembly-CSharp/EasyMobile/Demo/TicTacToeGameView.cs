using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x200003F")]
	public class TicTacToeGameView : MonoBehaviour
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x5A76E0", Offset = "0x5A76E0", VA = "0x5A76E0")]
		public TicTacToeGameView()
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00002B20 File Offset: 0x00000D20
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		public float TileSize
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x5A7798", Offset = "0x5A7798", VA = "0x5A7798")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF5F4", Offset = "0x4AF5F4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x5A77A0", Offset = "0x5A77A0", VA = "0x5A77A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF604", Offset = "0x4AF604")]
			private set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x1700007D")]
		public float TileSpacing
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x5A77A8", Offset = "0x5A77A8", VA = "0x5A77A8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x1700007E")]
		public int BoardSize
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x5A1FF0", Offset = "0x5A1FF0", VA = "0x5A1FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00002B68 File Offset: 0x00000D68
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public bool IsInPlayingMode
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x5A77B8", Offset = "0x5A77B8", VA = "0x5A77B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF614", Offset = "0x4AF614")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x5A77C0", Offset = "0x5A77C0", VA = "0x5A77C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF624", Offset = "0x4AF624")]
			private set
			{
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5A77CC", Offset = "0x5A77CC", VA = "0x5A77CC", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5A7B00", Offset = "0x5A7B00", VA = "0x5A7B00", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5A556C", Offset = "0x5A556C", VA = "0x5A556C")]
		public void CreateBoard(TicTacToeGameModel model)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x5A8904", Offset = "0x5A8904", VA = "0x5A8904")]
		public void Move(int x, int y)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x5A6590", Offset = "0x5A6590", VA = "0x5A6590")]
		public void EndGame(MatchOutcome.ParticipantResult result)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x5A8A30", Offset = "0x5A8A30", VA = "0x5A8A30")]
		public void LeaveMatch()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x5A50FC", Offset = "0x5A50FC", VA = "0x5A50FC")]
		public void ShowGameOverUI(MatchOutcome.ParticipantResult result, bool showRematchButton)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x5A5A40", Offset = "0x5A5A40", VA = "0x5A5A40")]
		public void HideGameSection()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x5A2FB0", Offset = "0x5A2FB0", VA = "0x5A2FB0")]
		public void ShowAlert(string errorMessage, string title = "Error")
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x5A4EA0", Offset = "0x5A4EA0", VA = "0x5A4EA0")]
		public void ShowYesNoPopup(string title, string message, [Optional] Action<bool> callback)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x5A4478", Offset = "0x5A4478", VA = "0x5A4478")]
		public bool CheckShowingMatch(string matchId)
		{
			return default(bool);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x5A37D8", Offset = "0x5A37D8", VA = "0x5A37D8")]
		public void StartProgressUI(string message)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x5A5AE0", Offset = "0x5A5AE0", VA = "0x5A5AE0")]
		public void StopProgressUI(string message, float appearTime = -1f)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x5A8C48", Offset = "0x5A8C48", VA = "0x5A8C48")]
		[DebuggerHidden]
		private IEnumerator ProgressRunningUICoroutine(string message)
		{
			return null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x5A8CDC", Offset = "0x5A8CDC", VA = "0x5A8CDC")]
		[DebuggerHidden]
		private IEnumerator ProgressUIStoppingCoroutine(string message, float appearTime)
		{
			return null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x5A8DA0", Offset = "0x5A8DA0", VA = "0x5A8DA0")]
		private string GetDotMessageForProgessUI(int currentLoopTimes)
		{
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5A819C", Offset = "0x5A819C", VA = "0x5A819C")]
		private void InstantiateBoard(TicTacToeGameModel model)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x5A8AFC", Offset = "0x5A8AFC", VA = "0x5A8AFC")]
		private void ClearBoard()
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5A9184", Offset = "0x5A9184", VA = "0x5A9184")]
		private float CalculateTileSize(int boardSize)
		{
			return 0f;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x5A8E30", Offset = "0x5A8E30", VA = "0x5A8E30")]
		private void UpdateTileUI(int x, int y, TicTacToeGameModel.TileState state)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x5A7908", Offset = "0x5A7908", VA = "0x5A7908")]
		private void RegisterButtonsEvents()
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5A91E4", Offset = "0x5A91E4", VA = "0x5A91E4")]
		private void ShowMatchesUI()
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5A7F94", Offset = "0x5A7F94", VA = "0x5A7F94")]
		private Sprite GetSpriteForTile(TicTacToeGameModel.TileState state)
		{
			return null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5A7FD8", Offset = "0x5A7FD8", VA = "0x5A7FD8")]
		private Color GetColorForTile(TicTacToeGameModel.TileState state)
		{
			return default(Color);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x5A8A5C", Offset = "0x5A8A5C", VA = "0x5A8A5C")]
		private string GetResultText(MatchOutcome.ParticipantResult result)
		{
			return null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x5A9204", Offset = "0x5A9204", VA = "0x5A9204")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF654", Offset = "0x4AF654")]
		private void <RegisterButtonsEvents>m__0()
		{
		}

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color xColor;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color oColor;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x4AF308", Offset = "0x4AF308")]
		private float spaceRate;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x4AF348", Offset = "0x4AF348")]
		private float progressUISpeed;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x4AF38C", Offset = "0x4AF38C")]
		private float progressUIDisappearTime;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AF3D0", Offset = "0x4AF3D0")]
		[SerializeField]
		private TicTacToeGameControl control;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DemoUtils demoUtils;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AlertPopup popup;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject gameSection;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject multiplayerSection;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject progressTextObject;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject resultRootObject;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text resultText;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GridLayoutGroup grid;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform gridRect;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button showMatchesUIButton;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button hideGameButton;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button leaveMatchButton;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button rematchButton;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button tilePrefab;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text progressText;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Dropdown gameSizeSelector;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Sprite blankImage;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Sprite xImage;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Sprite oImage;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TicTacToeGameView.PlayerInfosUI selfInfos;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TicTacToeGameView.PlayerInfosUI opponentInfos;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Texture2D defaulAvatar;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF57C", Offset = "0x4AF57C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF57C", Offset = "0x4AF57C")]
		private float <TileSize>k__BackingField;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF5B8", Offset = "0x4AF5B8")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AF5B8", Offset = "0x4AF5B8")]
		private bool <IsInPlayingMode>k__BackingField;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Button[][] board;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private TicTacToeGameModel currentModel;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Coroutine progressUIRunningCoroutine;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine progressUIStoppingCoroutine;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private string wonText;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private string loseText;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private string tiedText;

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x2000040")]
		[Serializable]
		private struct PlayerInfosUI
		{
			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00002BC8 File Offset: 0x00000DC8
			// (set) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000080")]
			public bool HighLight
			{
				[Token(Token = "0x60002F2")]
				[Address(RVA = "0x5A9878", Offset = "0x5A9878", VA = "0x5A9878")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x5A9A58", Offset = "0x5A9A58", VA = "0x5A9A58")]
				set
				{
				}
			}

			// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x5A9A64", Offset = "0x5A9A64", VA = "0x5A9A64")]
			public void Update(Texture2D avatar, Sprite mark, Color markColor, string name, bool hightLight, bool anonymous = false)
			{
			}

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool highLight;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Color highlightColor;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Color normalColor;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RawImage avatar;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image rootPanel;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Image mark;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text name;
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x2000402")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF664", Offset = "0x4AF664")]
		private sealed class <Move>c__AnonStorey2
		{
			// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x5A8A28", Offset = "0x5A8A28", VA = "0x5A8A28")]
			public <Move>c__AnonStorey2()
			{
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x5A9278", Offset = "0x5A9278", VA = "0x5A9278")]
			internal void <>m__0(TicTacToeGameModel.Mark mark)
			{
			}

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x40011FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int x;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x40011FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int y;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x4001200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TicTacToeGameView $this;
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x2000403")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF674", Offset = "0x4AF674")]
		private sealed class <ShowYesNoPopup>c__AnonStorey3
		{
			// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x5A8C40", Offset = "0x5A8C40", VA = "0x5A8C40")]
			public <ShowYesNoPopup>c__AnonStorey3()
			{
			}

			// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x5A97B4", Offset = "0x5A97B4", VA = "0x5A97B4")]
			internal void <>m__0(AlertPopup.ButtonName buttonName)
			{
			}

			// Token: 0x0400026B RID: 619
			[Token(Token = "0x4001201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Action<bool> callback;
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x2000404")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF684", Offset = "0x4AF684")]
		private sealed class <ProgressRunningUICoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE5")]
			[Address(RVA = "0x5A8D90", Offset = "0x5A8D90", VA = "0x5A8D90")]
			[DebuggerHidden]
			public <ProgressRunningUICoroutine>c__Iterator0()
			{
			}

			// Token: 0x06000364 RID: 868 RVA: 0x00002BE0 File Offset: 0x00000DE0
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x5A92C4", Offset = "0x5A92C4", VA = "0x5A92C4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000365 RID: 869 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B2")]
			private object Current
			{
				[Token(Token = "0x6001EE7")]
				[Address(RVA = "0x5A94FC", Offset = "0x5A94FC", VA = "0x5A94FC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000366 RID: 870 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B3")]
			private object Current
			{
				[Token(Token = "0x6001EE8")]
				[Address(RVA = "0x5A9504", Offset = "0x5A9504", VA = "0x5A9504", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x5A950C", Offset = "0x5A950C", VA = "0x5A950C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x5A9520", Offset = "0x5A9520", VA = "0x5A9520", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x4001202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <loopTimes>__0;

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x4001203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string message;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x4001204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string <newMessage>__1;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x4001205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal TicTacToeGameView $this;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4001206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal object $current;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4001207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4001208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;
		}

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x2000405")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF6E4", Offset = "0x4AF6E4")]
		private sealed class <ProgressUIStoppingCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EEB")]
			[Address(RVA = "0x5A8D98", Offset = "0x5A8D98", VA = "0x5A8D98")]
			[DebuggerHidden]
			public <ProgressUIStoppingCoroutine>c__Iterator1()
			{
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0x5A9588", Offset = "0x5A9588", VA = "0x5A9588", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x0600036B RID: 875 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B4")]
			private object Current
			{
				[Token(Token = "0x6001EED")]
				[Address(RVA = "0x5A9728", Offset = "0x5A9728", VA = "0x5A9728", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x0600036C RID: 876 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004B5")]
			private object Current
			{
				[Token(Token = "0x6001EEE")]
				[Address(RVA = "0x5A9730", Offset = "0x5A9730", VA = "0x5A9730", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x5A9738", Offset = "0x5A9738", VA = "0x5A9738", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x5A974C", Offset = "0x5A974C", VA = "0x5A974C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4001209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string message;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x400120A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float appearTime;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x400120B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal TicTacToeGameView $this;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x400120C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x400120D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x400120E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal int $PC;
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x2000406")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF744", Offset = "0x4AF744")]
		private sealed class <InstantiateBoard>c__AnonStorey4
		{
			// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x5A91DC", Offset = "0x5A91DC", VA = "0x5A91DC")]
			public <InstantiateBoard>c__AnonStorey4()
			{
			}

			// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EF2")]
			[Address(RVA = "0x5A9208", Offset = "0x5A9208", VA = "0x5A9208")]
			internal void <>m__0()
			{
			}

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x400120F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int x;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x4001210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int y;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x4001211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TicTacToeGameView $this;
		}
	}
}
