using System;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000487 RID: 1159
[Token(Token = "0x2000339")]
public class PhotonLagSimulationGui : MonoBehaviour
{
	// Token: 0x06001EFE RID: 7934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x77BC3C", Offset = "0x77BC3C", VA = "0x77BC3C")]
	public PhotonLagSimulationGui()
	{
	}

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000416")]
	public PhotonPeer Peer
	{
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x77BCA8", Offset = "0x77BCA8", VA = "0x77BCA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC758", Offset = "0x4BC758")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x77BCB0", Offset = "0x77BCB0", VA = "0x77BCB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC768", Offset = "0x4BC768")]
		set
		{
		}
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x77BCB8", Offset = "0x77BCB8", VA = "0x77BCB8")]
	public void Start()
	{
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x77BD28", Offset = "0x77BD28", VA = "0x77BD28")]
	public void OnGUI()
	{
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x77BE3C", Offset = "0x77BE3C", VA = "0x77BE3C")]
	private void NetSimHasNoPeerWindow(int windowId)
	{
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x77BEB0", Offset = "0x77BEB0", VA = "0x77BEB0")]
	private void NetSimWindow(int windowId)
	{
	}

	// Token: 0x04001141 RID: 4417
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x18")]
	public Rect WindowRect;

	// Token: 0x04001142 RID: 4418
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x28")]
	public int WindowId;

	// Token: 0x04001143 RID: 4419
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x2C")]
	public bool Visible;

	// Token: 0x04001144 RID: 4420
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BC71C", Offset = "0x4BC71C")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4BC71C", Offset = "0x4BC71C")]
	private PhotonPeer <Peer>k__BackingField;
}
