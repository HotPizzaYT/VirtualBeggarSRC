using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000539 RID: 1337
[Token(Token = "0x20003BD")]
public class EventTriggerOmaC : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
{
	// Token: 0x06002377 RID: 9079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x837FDC", Offset = "0x837FDC", VA = "0x837FDC")]
	public EventTriggerOmaC()
	{
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x837FE4", Offset = "0x837FE4", VA = "0x837FE4")]
	private void Awake()
	{
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x83807C", Offset = "0x83807C", VA = "0x83807C", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x838188", Offset = "0x838188", VA = "0x838188", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x0000A7A0 File Offset: 0x000089A0
	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x838298", Offset = "0x838298", VA = "0x838298")]
	private float MuunnaScrollUIPaikaksi(float yWorldPos)
	{
		return 0f;
	}

	// Token: 0x0400159E RID: 5534
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0x18")]
	public NetworkManagerP netw;

	// Token: 0x0400159F RID: 5535
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform tr;

	// Token: 0x040015A0 RID: 5536
	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0x28")]
	private float offsetY;

	// Token: 0x040015A1 RID: 5537
	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0x30")]
	private Camera cam;
}
