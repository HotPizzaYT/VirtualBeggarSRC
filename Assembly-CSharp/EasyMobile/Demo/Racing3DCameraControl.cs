using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000025")]
	public class Racing3DCameraControl : MonoBehaviour
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x595B20", Offset = "0x595B20", VA = "0x595B20")]
		public Racing3DCameraControl()
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public bool IsFollowingTarget
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x595B30", Offset = "0x595B30", VA = "0x595B30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x595B38", Offset = "0x595B38", VA = "0x595B38")]
			private set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public GameObject FollowTarget
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x595B44", Offset = "0x595B44", VA = "0x595B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x595B4C", Offset = "0x595B4C", VA = "0x595B4C")]
			private set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public Vector3 Offset
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x595B54", Offset = "0x595B54", VA = "0x595B54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x595B60", Offset = "0x595B60", VA = "0x595B60")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public float Speed
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x595B6C", Offset = "0x595B6C", VA = "0x595B6C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x595B74", Offset = "0x595B74", VA = "0x595B74")]
			set
			{
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x595B84", Offset = "0x595B84", VA = "0x595B84")]
		[Attribute(Name = "ContextMenu", RVA = "0x4ADEB8", Offset = "0x4ADEB8")]
		public void LogOffset()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x595D80", Offset = "0x595D80", VA = "0x595D80")]
		[Attribute(Name = "ContextMenu", RVA = "0x4ADEF0", Offset = "0x4ADEF0")]
		public void ResetPosition()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x595E00", Offset = "0x595E00", VA = "0x595E00")]
		public void StartFollowing(GameObject followTarget)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x595E10", Offset = "0x595E10", VA = "0x595E10")]
		public void StopFollowing()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x595E1C", Offset = "0x595E1C", VA = "0x595E1C", Slot = "4")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x596024", Offset = "0x596024", VA = "0x596024", Slot = "5")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera cam;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float speed;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 offset;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject followTarget;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool isFollowingTarget;
	}
}
