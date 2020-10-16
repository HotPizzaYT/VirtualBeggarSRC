using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000482 RID: 1154
[Token(Token = "0x2000335")]
public class PhotonStream
{
	// Token: 0x06001EC7 RID: 7879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x789B0C", Offset = "0x789B0C", VA = "0x789B0C")]
	public PhotonStream(bool write, object[] incomingData)
	{
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x000094C8 File Offset: 0x000076C8
	[Token(Token = "0x1700040E")]
	public bool isWriting
	{
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x788440", Offset = "0x788440", VA = "0x788440")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000094E0 File Offset: 0x000076E0
	[Token(Token = "0x1700040F")]
	public bool isReading
	{
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x789BBC", Offset = "0x789BBC", VA = "0x789BBC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001ECA RID: 7882 RVA: 0x000094F8 File Offset: 0x000076F8
	[Token(Token = "0x17000410")]
	public int Count
	{
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x789BCC", Offset = "0x789BCC", VA = "0x789BCC")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x788504", Offset = "0x788504", VA = "0x788504")]
	public object ReceiveNext()
	{
		return null;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x789C2C", Offset = "0x789C2C", VA = "0x789C2C")]
	public object PeekNext()
	{
		return null;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x788448", Offset = "0x788448", VA = "0x788448")]
	public void SendNext(object obj)
	{
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x789CE4", Offset = "0x789CE4", VA = "0x789CE4")]
	public object[] ToArray()
	{
		return null;
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x789D44", Offset = "0x789D44", VA = "0x789D44")]
	public void Serialize(ref bool myBool)
	{
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x789ED0", Offset = "0x789ED0", VA = "0x789ED0")]
	public void Serialize(ref int myInt)
	{
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x78A054", Offset = "0x78A054", VA = "0x78A054")]
	public void Serialize(ref string value)
	{
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x78A200", Offset = "0x78A200", VA = "0x78A200")]
	public void Serialize(ref char value)
	{
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x78A384", Offset = "0x78A384", VA = "0x78A384")]
	public void Serialize(ref short value)
	{
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001973")]
	[Address(RVA = "0x78A508", Offset = "0x78A508", VA = "0x78A508")]
	public void Serialize(ref float obj)
	{
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001974")]
	[Address(RVA = "0x78A68C", Offset = "0x78A68C", VA = "0x78A68C")]
	public void Serialize(ref PhotonPlayer obj)
	{
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001975")]
	[Address(RVA = "0x78A870", Offset = "0x78A870", VA = "0x78A870")]
	public void Serialize(ref Vector3 obj)
	{
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001976")]
	[Address(RVA = "0x78AA0C", Offset = "0x78AA0C", VA = "0x78AA0C")]
	public void Serialize(ref Vector2 obj)
	{
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x78AB90", Offset = "0x78AB90", VA = "0x78AB90")]
	public void Serialize(ref Quaternion obj)
	{
	}

	// Token: 0x04001128 RID: 4392
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x10")]
	private bool write;

	// Token: 0x04001129 RID: 4393
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x18")]
	internal List<object> data;

	// Token: 0x0400112A RID: 4394
	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x20")]
	private byte currentItem;
}
