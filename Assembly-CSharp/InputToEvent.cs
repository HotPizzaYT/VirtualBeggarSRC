using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B4 RID: 1204
[Token(Token = "0x200035F")]
public class InputToEvent : MonoBehaviour
{
	// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x68B7C8", Offset = "0x68B7C8", VA = "0x68B7C8")]
	public InputToEvent()
	{
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06002057 RID: 8279 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000463")]
	public static GameObject goPointedAt
	{
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x68B850", Offset = "0x68B850", VA = "0x68B850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD1A0", Offset = "0x4BD1A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x68B8A0", Offset = "0x68B8A0", VA = "0x68B8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD1B0", Offset = "0x4BD1B0")]
		private set
		{
		}
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06002059 RID: 8281 RVA: 0x00009F60 File Offset: 0x00008160
	[Token(Token = "0x17000464")]
	public Vector2 DragVector
	{
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x68B8F4", Offset = "0x68B8F4", VA = "0x68B8F4")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x68B9C8", Offset = "0x68B9C8", VA = "0x68B9C8")]
	private void Start()
	{
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x68BA20", Offset = "0x68BA20", VA = "0x68BA20")]
	private void Update()
	{
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x68C00C", Offset = "0x68C00C", VA = "0x68C00C")]
	private void Press(Vector2 screenPos)
	{
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x68C0F0", Offset = "0x68C0F0", VA = "0x68C0F0")]
	private void Release(Vector2 screenPos)
	{
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x68BEAC", Offset = "0x68BEAC", VA = "0x68BEAC")]
	private GameObject RaycastObject(Vector2 screenPos)
	{
		return null;
	}

	// Token: 0x0400123C RID: 4668
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x18")]
	private GameObject lastGo;

	// Token: 0x0400123D RID: 4669
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 inputHitPos;

	// Token: 0x0400123E RID: 4670
	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x20")]
	public bool DetectPointedAtGameObject;

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BD164", Offset = "0x4BD164")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BD164", Offset = "0x4BD164")]
	private static GameObject <goPointedAt>k__BackingField;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 pressedPosition;

	// Token: 0x04001241 RID: 4673
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 currentPos;

	// Token: 0x04001242 RID: 4674
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x34")]
	public bool Dragging;

	// Token: 0x04001243 RID: 4675
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x38")]
	private Camera m_Camera;
}
