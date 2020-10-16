using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000026")]
	public class Racing3DCarControl : MonoBehaviour
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x596038", Offset = "0x596038", VA = "0x596038")]
		public Racing3DCarControl()
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public bool IsMoving
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x59610C", Offset = "0x59610C", VA = "0x59610C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE1B4", Offset = "0x4AE1B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x596114", Offset = "0x596114", VA = "0x596114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE1C4", Offset = "0x4AE1C4")]
			private set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public bool IsUsingNitro
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x596120", Offset = "0x596120", VA = "0x596120")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE1D4", Offset = "0x4AE1D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x596128", Offset = "0x596128", VA = "0x596128")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE1E4", Offset = "0x4AE1E4")]
			private set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public float RunDistance
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x596134", Offset = "0x596134", VA = "0x596134")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE1F4", Offset = "0x4AE1F4")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x59613C", Offset = "0x59613C", VA = "0x59613C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE204", Offset = "0x4AE204")]
			private set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public bool Controllable
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x596144", Offset = "0x596144", VA = "0x596144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x59614C", Offset = "0x59614C", VA = "0x59614C")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public float Speed
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x596188", Offset = "0x596188", VA = "0x596188")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x596190", Offset = "0x596190", VA = "0x596190")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public int Nitro
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x59621C", Offset = "0x59621C", VA = "0x59621C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x596224", Offset = "0x596224", VA = "0x596224")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		public int CurrentRoadLine
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5962AC", Offset = "0x5962AC", VA = "0x5962AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE214", Offset = "0x4AE214")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5962B4", Offset = "0x5962B4", VA = "0x5962B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE224", Offset = "0x4AE224")]
			private set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x1700004F")]
		public Vector3 PrepareCameraPosition
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5962BC", Offset = "0x5962BC", VA = "0x5962BC")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x5962C8", Offset = "0x5962C8", VA = "0x5962C8", Slot = "4")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x596340", Offset = "0x596340", VA = "0x596340", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x59637C", Offset = "0x59637C", VA = "0x59637C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x59640C", Offset = "0x59640C", VA = "0x59640C")]
		public void ResetValues()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x59649C", Offset = "0x59649C", VA = "0x59649C")]
		public void StartMoving(bool controllable)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5964D4", Offset = "0x5964D4", VA = "0x5964D4")]
		public void ContinueMoving()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5964E8", Offset = "0x5964E8", VA = "0x5964E8")]
		public void StopMoving(int slowdownFrames = 0)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x59669C", Offset = "0x59669C", VA = "0x59669C")]
		public void Move(Racing3DGameModel.MoveDirections direction)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x5969B8", Offset = "0x5969B8", VA = "0x5969B8")]
		public void UseNitro()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x596AB0", Offset = "0x596AB0", VA = "0x596AB0")]
		public void CreateHitPowerUpEffect()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x596A40", Offset = "0x596A40", VA = "0x596A40")]
		[DebuggerHidden]
		private IEnumerator UseNitroCoroutine()
		{
			return null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x596AB4", Offset = "0x596AB4", VA = "0x596AB4")]
		public void UpdateInfo(Texture2D avatar, string name)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x596AC0", Offset = "0x596AC0", VA = "0x596AC0")]
		public void UpdateName(string name)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x596ACC", Offset = "0x596ACC", VA = "0x596ACC")]
		public void UpdateAvatar(Texture2D avatar)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x596608", Offset = "0x596608", VA = "0x596608")]
		[DebuggerHidden]
		private IEnumerator SlowDownCoroutine(int slowdownFrames)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x596AD8", Offset = "0x596AD8", VA = "0x596AD8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody rb;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject hightlightObject;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Racing3DGameControl gameControl;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Racing3DGameView gameView;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x4ADF68", Offset = "0x4ADF68")]
		[SerializeField]
		private bool controlable;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x4ADFA0", Offset = "0x4ADFA0")]
		private int nitro;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string powerUpsName;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string finishLineName;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float defaultSpeed;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float maxSpeed;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float nitroBoost;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float nitroBoostFrame;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float nitroAutoFillRate;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float moveDistance;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 defaultPosition;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private int defaultRoadLine;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int maxRoadLine;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int finishLineSlowdownFrames;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 prepareCameraPosition;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Racing3DCarControl.OverheadInfo info;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE0C4", Offset = "0x4AE0C4")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE0C4", Offset = "0x4AE0C4")]
		private bool <IsMoving>k__BackingField;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xA1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE100", Offset = "0x4AE100")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE100", Offset = "0x4AE100")]
		private bool <IsUsingNitro>k__BackingField;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE13C", Offset = "0x4AE13C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE13C", Offset = "0x4AE13C")]
		private float <RunDistance>k__BackingField;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE178", Offset = "0x4AE178")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4AE178", Offset = "0x4AE178")]
		private int <CurrentRoadLine>k__BackingField;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine useNitroCoroutine;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xB8")]
		private float speed;

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000027")]
		[Serializable]
		public struct OverheadInfo
		{
			// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x5974B0", Offset = "0x5974B0", VA = "0x5974B0")]
			public void Update(Texture2D avatar, string name)
			{
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x5974B8", Offset = "0x5974B8", VA = "0x5974B8")]
			public void UpdateName(string name)
			{
			}

			// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x5974F8", Offset = "0x5974F8", VA = "0x5974F8")]
			public void UpdateAvatar(Texture2D texture)
			{
			}

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x0")]
			public RawImage avatarImage;

			// Token: 0x0400017E RID: 382
			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x8")]
			public Text nameText;
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x20003F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE254", Offset = "0x4AE254")]
		private sealed class <UseNitroCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x597044", Offset = "0x597044", VA = "0x597044")]
			[DebuggerHidden]
			public <UseNitroCoroutine>c__Iterator0()
			{
			}

			// Token: 0x0600023A RID: 570 RVA: 0x000026A0 File Offset: 0x000008A0
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x59704C", Offset = "0x59704C", VA = "0x59704C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A8")]
			private object Current
			{
				[Token(Token = "0x6001EB7")]
				[Address(RVA = "0x597318", Offset = "0x597318", VA = "0x597318", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600023C RID: 572 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004A9")]
			private object Current
			{
				[Token(Token = "0x6001EB8")]
				[Address(RVA = "0x597320", Offset = "0x597320", VA = "0x597320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EB9")]
			[Address(RVA = "0x597328", Offset = "0x597328", VA = "0x597328", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EBA")]
			[Address(RVA = "0x59733C", Offset = "0x59733C", VA = "0x59733C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x0400017F RID: 383
			[Token(Token = "0x40011C6")]
			[FieldOffset(Offset = "0x10")]
			internal int <steps>__0;

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x40011C7")]
			[FieldOffset(Offset = "0x14")]
			internal int <maxSteps>__0;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x40011C8")]
			[FieldOffset(Offset = "0x18")]
			internal float <originalSpeed>__0;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x40011C9")]
			[FieldOffset(Offset = "0x1C")]
			internal float <maxSpeed>__0;

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x40011CA")]
			[FieldOffset(Offset = "0x20")]
			internal Racing3DCarControl $this;

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x40011CB")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x40011CC")]
			[FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x40011CD")]
			[FieldOffset(Offset = "0x34")]
			internal int $PC;
		}

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x20003F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AE2B4", Offset = "0x4AE2B4")]
		private sealed class <SlowDownCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EBB")]
			[Address(RVA = "0x596D98", Offset = "0x596D98", VA = "0x596D98")]
			[DebuggerHidden]
			public <SlowDownCoroutine>c__Iterator1()
			{
			}

			// Token: 0x06000240 RID: 576 RVA: 0x000026B8 File Offset: 0x000008B8
			[Token(Token = "0x6001EBC")]
			[Address(RVA = "0x596DA0", Offset = "0x596DA0", VA = "0x596DA0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000241 RID: 577 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AA")]
			private object Current
			{
				[Token(Token = "0x6001EBD")]
				[Address(RVA = "0x596FB8", Offset = "0x596FB8", VA = "0x596FB8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000242 RID: 578 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004AB")]
			private object Current
			{
				[Token(Token = "0x6001EBE")]
				[Address(RVA = "0x596FC0", Offset = "0x596FC0", VA = "0x596FC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EBF")]
			[Address(RVA = "0x596FC8", Offset = "0x596FC8", VA = "0x596FC8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EC0")]
			[Address(RVA = "0x596FDC", Offset = "0x596FDC", VA = "0x596FDC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x40011CE")]
			[FieldOffset(Offset = "0x10")]
			internal int slowdownFrames;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x40011CF")]
			[FieldOffset(Offset = "0x14")]
			internal float <factor>__0;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x40011D0")]
			[FieldOffset(Offset = "0x18")]
			internal int <currentFrame>__0;

			// Token: 0x0400018A RID: 394
			[Token(Token = "0x40011D1")]
			[FieldOffset(Offset = "0x20")]
			internal Racing3DCarControl $this;

			// Token: 0x0400018B RID: 395
			[Token(Token = "0x40011D2")]
			[FieldOffset(Offset = "0x28")]
			internal object $current;

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x40011D3")]
			[FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			// Token: 0x0400018D RID: 397
			[Token(Token = "0x40011D4")]
			[FieldOffset(Offset = "0x34")]
			internal int $PC;
		}
	}
}
