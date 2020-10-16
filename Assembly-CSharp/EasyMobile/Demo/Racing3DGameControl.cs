using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x2000029")]
	public class Racing3DGameControl : GameServicesDemo_Multiplayer_BaseControl, IRealTimeMultiplayerListener
	{
		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x59782C", Offset = "0x59782C", VA = "0x59782C")]
		public Racing3DGameControl()
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000050")]
		public Racing3DCarControl ControllableCar
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x597A30", Offset = "0x597A30", VA = "0x597A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000051")]
		public Racing3DCarControl OpponentCar
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x597AB0", Offset = "0x597AB0", VA = "0x597AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x5975F4", Offset = "0x5975F4", VA = "0x5975F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x597AF0", Offset = "0x597AF0", VA = "0x597AF0")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000053")]
		public bool IsRoomConnected
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x597B20", Offset = "0x597B20", VA = "0x597B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public bool IsOpponentDisconnected
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x597CAC", Offset = "0x597CAC", VA = "0x597CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE6FC", Offset = "0x4AE6FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x597CB4", Offset = "0x597CB4", VA = "0x597CB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE70C", Offset = "0x4AE70C")]
			private set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x17000055")]
		protected override MatchType MatchType
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x597CC0", Offset = "0x597CC0", VA = "0x597CC0", Slot = "8")]
			get
			{
				return MatchType.RealTime;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x597CC8", Offset = "0x597CC8", VA = "0x597CC8", Slot = "4")]
		protected override void CreateQuickMatch()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x597DD0", Offset = "0x597DD0", VA = "0x597DD0", Slot = "5")]
		protected override void CreateWithMatchmaker()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x597EC0", Offset = "0x597EC0", VA = "0x597EC0", Slot = "6")]
		protected override void AcceptInvitation(Invitation invitation)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x597FB4", Offset = "0x597FB4", VA = "0x597FB4", Slot = "7")]
		protected override void DeclineInvitation(Invitation invitation)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x598094", Offset = "0x598094", VA = "0x598094")]
		public void AcceptFromInbox()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x598174", Offset = "0x598174", VA = "0x598174")]
		public void LeaveRoom()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x59824C", Offset = "0x59824C", VA = "0x59824C")]
		public void SendMoveMessage(Racing3DGameModel.MoveDirections direction)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x598400", Offset = "0x598400", VA = "0x598400")]
		public void SendHitPowerUpMessage()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x5985A4", Offset = "0x5985A4", VA = "0x5985A4")]
		public void SendUseNitroMessage()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x598748", Offset = "0x598748", VA = "0x598748")]
		public void SendFinishMessage()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5988EC", Offset = "0x5988EC", VA = "0x5988EC")]
		private void SendStartGameMessage()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x598B00", Offset = "0x598B00", VA = "0x598B00")]
		public void SendReadyMessage()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x598CDC", Offset = "0x598CDC", VA = "0x598CDC")]
		public void SendRematchRequestMessage()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x598E80", Offset = "0x598E80", VA = "0x598E80")]
		public void SendRematchResponseMessage(bool accepted)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x599030", Offset = "0x599030", VA = "0x599030")]
		public void StartGame()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x59A5D8", Offset = "0x59A5D8", VA = "0x59A5D8")]
		private void OnDataReceived(string senderId, byte[] data)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x59B500", Offset = "0x59B500", VA = "0x59B500", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x59A534", Offset = "0x59A534", VA = "0x59A534")]
		private void LoadInfos(Participant self, Participant opponent)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x59B6E8", Offset = "0x59B6E8", VA = "0x59B6E8")]
		public void UseNitro()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x59B640", Offset = "0x59B640", VA = "0x59B640")]
		[DebuggerHidden]
		private IEnumerator LoadUserInfosCoroutine(Racing3DCarControl car, Participant participant)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x599588", Offset = "0x599588", VA = "0x599588")]
		private void ClearOldPowerUps()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x5996E4", Offset = "0x5996E4", VA = "0x5996E4")]
		private void ClearSideObjects()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x599B88", Offset = "0x599B88", VA = "0x599B88")]
		private void InstantiatePowerUps(List<Vector3> positions)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x59A0A8", Offset = "0x59A0A8", VA = "0x59A0A8")]
		private void InstantiateSideObjects(List<Vector3> positions)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x599840", Offset = "0x599840", VA = "0x599840")]
		private List<Vector3> GenerateRandomPositions()
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x599DC0", Offset = "0x599DC0", VA = "0x599DC0")]
		private List<Vector3> GenerateRandomSidePositions()
		{
			return null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x59B2F8", Offset = "0x59B2F8", VA = "0x59B2F8")]
		private void StopMoving(bool wonFlag, Racing3DGameModel.GameoverReason stopReason, bool showGameOverUI = true)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x59B934", Offset = "0x59B934", VA = "0x59B934")]
		private void StartMoving()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x59BA20", Offset = "0x59BA20", VA = "0x59BA20")]
		private Racing3DCarControl GetCarWithId(string id)
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x59BAE4", Offset = "0x59BAE4", VA = "0x59BAE4")]
		[DebuggerHidden]
		private IEnumerator SendStartMessageCoroutine()
		{
			return null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x59BB5C", Offset = "0x59BB5C", VA = "0x59BB5C", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x59BC68", Offset = "0x59BC68", VA = "0x59BC68", Slot = "17")]
		public void OnParticipantLeft(Participant participant)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x59BD18", Offset = "0x59BD18", VA = "0x59BD18", Slot = "18")]
		public void OnPeersConnected(string[] participantIds)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x59BF68", Offset = "0x59BF68", VA = "0x59BF68", Slot = "19")]
		public void OnPeersDisconnected(string[] participantIds)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x59C1B8", Offset = "0x59C1B8", VA = "0x59C1B8", Slot = "20")]
		public void OnRealTimeMessageReceived(string senderId, byte[] data)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x59C1FC", Offset = "0x59C1FC", VA = "0x59C1FC", Slot = "15")]
		public void OnRoomConnected(bool success)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x59C38C", Offset = "0x59C38C", VA = "0x59C38C", Slot = "14")]
		public void OnRoomSetupProgress(float percent)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x59C470", Offset = "0x59C470", VA = "0x59C470", Slot = "21")]
		public bool ShouldReinviteDisconnectedPlayer(Participant participant)
		{
			return default(bool);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x59C478", Offset = "0x59C478", VA = "0x59C478")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE73C", Offset = "0x4AE73C")]
		private bool <StartGame>m__0(Participant p)
		{
			return default(bool);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x59C4DC", Offset = "0x59C4DC", VA = "0x59C4DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE74C", Offset = "0x4AE74C")]
		private void <StartGame>m__1()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x59C508", Offset = "0x59C508", VA = "0x59C508")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE75C", Offset = "0x4AE75C")]
		private static float <GenerateRandomPositions>m__2(float _)
		{
			return 0f;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x59C514", Offset = "0x59C514", VA = "0x59C514")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE76C", Offset = "0x4AE76C")]
		private static float <GenerateRandomSidePositions>m__3(float _)
		{
			return 0f;
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Racing3DGameView view;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Racing3DCameraControl cameraControl;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Racing3DCarControl hostCar;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Racing3DCarControl guestCar;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform roadTransform;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject powerUpPrefab;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject[] sideObjects;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Texture2D anonymousAvatar;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float readyMessageDelay;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xEC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AE3F4", Offset = "0x4AE3F4")]
		[SerializeField]
		private float startMessageInterval;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int startMessageLimit;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AE450", Offset = "0x4AE450")]
		[SerializeField]
		private string powerUpName;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x4AE49C", Offset = "0x4AE49C")]
		private float powerUpsFrequency;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float powerUpsZ;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Vector2 powerUpsYRange;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Vector2 powerUpsDistanceRange;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<float> powerUpsX;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AE51C", Offset = "0x4AE51C")]
		[SerializeField]
		private Vector2 sideObjectsYRange;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AE568", Offset = "0x4AE568")]
		[SerializeField]
		private Vector2 sideObjectsDistanceRange;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float sideObjectMaxDeltaX;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float sideObjectMaxDeltaY;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<float> sideObjectsX;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x4AE5E4", Offset = "0x4AE5E4")]
		[SerializeField]
		private bool move;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x141")]
		[SerializeField]
		private bool hitPowerUp;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x142")]
		[SerializeField]
		private bool useNitro;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x143")]
		[SerializeField]
		private bool finish;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private bool start;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x145")]
		[SerializeField]
		private bool ready;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x146")]
		[SerializeField]
		private bool rematchRequest;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x147")]
		[SerializeField]
		private bool rematchResponse;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE6A0", Offset = "0x4AE6A0")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE6A0", Offset = "0x4AE6A0")]
		private bool <IsOpponentDisconnected>k__BackingField;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x150")]
		private MatchRequest matchRequest;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x158")]
		private Racing3DGameModel model;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x160")]
		private string selfId;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x168")]
		private string opponentId;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x170")]
		private List<GameObject> createdPowerUps;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x178")]
		private List<GameObject> createdSideObjects;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x180")]
		private bool isPlaying;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x181")]
		private bool isStartMessageReceived;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x188")]
		private Stopwatch stopwatch;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE6DC", Offset = "0x4AE6DC")]
		private static Func<float, float> <>f__am$cache0;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE6EC", Offset = "0x4AE6EC")]
		private static Func<float, float> <>f__am$cache1;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x20003F9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE77C", Offset = "0x4AE77C")]
		private sealed class <LoadUserInfosCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC1")]
			[Address(RVA = "0x59B7C8", Offset = "0x59B7C8", VA = "0x59B7C8")]
			[DebuggerHidden]
			public <LoadUserInfosCoroutine>c__Iterator0()
			{
			}

			// Token: 0x0600027F RID: 639 RVA: 0x000027A8 File Offset: 0x000009A8
			[Token(Token = "0x6001EC2")]
			[Address(RVA = "0x59C5F8", Offset = "0x59C5F8", VA = "0x59C5F8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000280 RID: 640 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AC")]
			private object Current
			{
				[Token(Token = "0x6001EC3")]
				[Address(RVA = "0x59C964", Offset = "0x59C964", VA = "0x59C964", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000281 RID: 641 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AD")]
			private object Current
			{
				[Token(Token = "0x6001EC4")]
				[Address(RVA = "0x59C96C", Offset = "0x59C96C", VA = "0x59C96C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC5")]
			[Address(RVA = "0x59C974", Offset = "0x59C974", VA = "0x59C974", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC6")]
			[Address(RVA = "0x59C988", Offset = "0x59C988", VA = "0x59C988", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40011D5")]
			[FieldOffset(Offset = "0x10")]
			internal Participant participant;

			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40011D6")]
			[FieldOffset(Offset = "0x18")]
			internal Racing3DCarControl car;

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40011D7")]
			[FieldOffset(Offset = "0x20")]
			internal Racing3DGameControl $this;

			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40011D8")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40011D9")]
			[FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40011DA")]
			[FieldOffset(Offset = "0x34")]
			internal int $PC;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40011DB")]
			[FieldOffset(Offset = "0x38")]
			private Racing3DGameControl.<LoadUserInfosCoroutine>c__Iterator0.<LoadUserInfosCoroutine>c__AnonStorey2 $locvar0;

			// Token: 0x0200003C RID: 60
			[Token(Token = "0x20003FC")]
			private sealed class <LoadUserInfosCoroutine>c__AnonStorey2
			{
				// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001ECF")]
				[Address(RVA = "0x59C95C", Offset = "0x59C95C", VA = "0x59C95C")]
				public <LoadUserInfosCoroutine>c__AnonStorey2()
				{
				}

				// Token: 0x06000285 RID: 645 RVA: 0x000027C0 File Offset: 0x000009C0
				[Token(Token = "0x6001ED0")]
				[Address(RVA = "0x59C9F0", Offset = "0x59C9F0", VA = "0x59C9F0")]
				internal bool <>m__0()
				{
					return default(bool);
				}

				// Token: 0x040001C7 RID: 455
				[Token(Token = "0x40011E4")]
				[FieldOffset(Offset = "0x10")]
				internal Participant participant;

				// Token: 0x040001C8 RID: 456
				[Token(Token = "0x40011E5")]
				[FieldOffset(Offset = "0x18")]
				internal Racing3DGameControl.<LoadUserInfosCoroutine>c__Iterator0 <>f__ref$0;
			}
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x20003FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE7DC", Offset = "0x4AE7DC")]
		private sealed class <GenerateRandomSidePositions>c__AnonStorey3
		{
			// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC7")]
			[Address(RVA = "0x59B7D0", Offset = "0x59B7D0", VA = "0x59B7D0")]
			public <GenerateRandomSidePositions>c__AnonStorey3()
			{
			}

			// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC8")]
			[Address(RVA = "0x59C520", Offset = "0x59C520", VA = "0x59C520")]
			internal void <>m__0(float x)
			{
			}

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40011DC")]
			[FieldOffset(Offset = "0x10")]
			internal List<Vector3> generatedPosition;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40011DD")]
			[FieldOffset(Offset = "0x18")]
			internal float currentY;

			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40011DE")]
			[FieldOffset(Offset = "0x20")]
			internal Racing3DGameControl $this;
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x20003FB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE7EC", Offset = "0x4AE7EC")]
		private sealed class <SendStartMessageCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC9")]
			[Address(RVA = "0x59BB54", Offset = "0x59BB54", VA = "0x59BB54")]
			[DebuggerHidden]
			public <SendStartMessageCoroutine>c__Iterator1()
			{
			}

			// Token: 0x06000289 RID: 649 RVA: 0x000027D8 File Offset: 0x000009D8
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0x59CAA0", Offset = "0x59CAA0", VA = "0x59CAA0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600028A RID: 650 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AE")]
			private object Current
			{
				[Token(Token = "0x6001ECB")]
				[Address(RVA = "0x59CC64", Offset = "0x59CC64", VA = "0x59CC64", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AF")]
			private object Current
			{
				[Token(Token = "0x6001ECC")]
				[Address(RVA = "0x59CC6C", Offset = "0x59CC6C", VA = "0x59CC6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ECD")]
			[Address(RVA = "0x59CC74", Offset = "0x59CC74", VA = "0x59CC74", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0x59CC88", Offset = "0x59CC88", VA = "0x59CC88", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40011DF")]
			[FieldOffset(Offset = "0x10")]
			internal int <count>__0;

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40011E0")]
			[FieldOffset(Offset = "0x18")]
			internal Racing3DGameControl $this;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40011E1")]
			[FieldOffset(Offset = "0x20")]
			internal object $current;

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40011E2")]
			[FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40011E3")]
			[FieldOffset(Offset = "0x2C")]
			internal int $PC;
		}
	}
}
