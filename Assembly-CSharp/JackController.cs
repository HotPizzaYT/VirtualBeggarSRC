using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004FD RID: 1277
[Token(Token = "0x200039B")]
public class JackController : MonoBehaviour
{
	// Token: 0x060021D7 RID: 8663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x68D77C", Offset = "0x68D77C", VA = "0x68D77C")]
	public JackController()
	{
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x68D78C", Offset = "0x68D78C", VA = "0x68D78C")]
	private void Awake()
	{
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x68D7FC", Offset = "0x68D7FC", VA = "0x68D7FC")]
	private void Start()
	{
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x68D8F4", Offset = "0x68D8F4", VA = "0x68D8F4")]
	public void Move(Vector2 velocity)
	{
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C14")]
	[Address(RVA = "0x68DB4C", Offset = "0x68DB4C", VA = "0x68DB4C")]
	private void VerticalCollisions(ref Vector2 velocity)
	{
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x68D9E4", Offset = "0x68D9E4", VA = "0x68D9E4")]
	private void UpdateRaycastOrigins()
	{
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x68D800", Offset = "0x68D800", VA = "0x68D800")]
	private void CalculateRaySpacing()
	{
	}

	// Token: 0x04001407 RID: 5127
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask collisionMask;

	// Token: 0x04001408 RID: 5128
	[Token(Token = "0x4000FD4")]
	private const float skinWidth = 0.015f;

	// Token: 0x04001409 RID: 5129
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x1C")]
	public int verticalRayCount;

	// Token: 0x0400140A RID: 5130
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x20")]
	private float verticalRaySpacing;

	// Token: 0x0400140B RID: 5131
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x24")]
	private JackController.RaycastOrigins raycastOrigins;

	// Token: 0x0400140C RID: 5132
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x44")]
	public JackController.CollisionInfo collisions;

	// Token: 0x0400140D RID: 5133
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x48")]
	private Transform tr;

	// Token: 0x0400140E RID: 5134
	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x50")]
	private BoxCollider2D coll2D;

	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x200039C")]
	private struct RaycastOrigins
	{
		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 topLeft;

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 topRight;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 bottomLeft;

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 bottomRight;
	}

	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x200039D")]
	public struct CollisionInfo
	{
		// Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x68DEFC", Offset = "0x68DEFC", VA = "0x68DEFC")]
		public void Reset()
		{
		}

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x0")]
		public bool above;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x1")]
		public bool below;
	}
}
