using System;
using Il2CppDummyDll;
using UnityEngine;

namespace EasyMobile.Demo
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000028")]
	public class Racing3DCarInputHandler : MonoBehaviour
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x597500", Offset = "0x597500", VA = "0x597500")]
		public Racing3DCarInputHandler()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x597518", Offset = "0x597518", VA = "0x597518", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5975FC", Offset = "0x5975FC", VA = "0x5975FC")]
		private void SwipeDetect(Touch touch)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x597694", Offset = "0x597694", VA = "0x597694")]
		private float HorizontalValMove()
		{
			return 0f;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x59770C", Offset = "0x59770C", VA = "0x59770C")]
		private void CheckSwipe()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5977CC", Offset = "0x5977CC", VA = "0x5977CC")]
		private void Move(Racing3DCarControl car, Racing3DGameModel.MoveDirections direction)
		{
		}

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Racing3DCarControl hostCar;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Racing3DCarControl guestCar;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Racing3DGameControl gameControl;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float clickDelay;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float swipeThreshold;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x38")]
		private float previousClickTime;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 fingerDown;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 fingerUp;
	}
}
