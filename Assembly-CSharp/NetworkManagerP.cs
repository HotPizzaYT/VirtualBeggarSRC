using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200051E RID: 1310
[Token(Token = "0x20003B0")]
public class NetworkManagerP : MonoBehaviour
{
	// Token: 0x0600229E RID: 8862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x76F088", Offset = "0x76F088", VA = "0x76F088")]
	public NetworkManagerP()
	{
	}

	// Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x76F150", Offset = "0x76F150", VA = "0x76F150")]
	private void Awake()
	{
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x76F43C", Offset = "0x76F43C", VA = "0x76F43C")]
	private void Start()
	{
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x76F64C", Offset = "0x76F64C", VA = "0x76F64C")]
	[DebuggerHidden]
	private IEnumerator PaivitaConnectionState()
	{
		return null;
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x76F6B0", Offset = "0x76F6B0", VA = "0x76F6B0")]
	private void OnJoinedLobby()
	{
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x76F71C", Offset = "0x76F71C", VA = "0x76F71C")]
	[DebuggerHidden]
	private IEnumerator OmienTietojenVarmistus()
	{
		return null;
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x76F794", Offset = "0x76F794", VA = "0x76F794")]
	private void OnJoinedRoom()
	{
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x76F9D8", Offset = "0x76F9D8", VA = "0x76F9D8")]
	private void OnPhotonRandomJoinFailed()
	{
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x76FB1C", Offset = "0x76FB1C", VA = "0x76FB1C")]
	private void OnPhotonPlayerDisconnected(PhotonPlayer other)
	{
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x770330", Offset = "0x770330", VA = "0x770330")]
	private void OnConnectionFail()
	{
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x770380", Offset = "0x770380", VA = "0x770380")]
	private void OnFailedToConnectToPhoton()
	{
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C9A")]
	[Address(RVA = "0x76F978", Offset = "0x76F978", VA = "0x76F978")]
	private void AloitaAsetaKerjalaiset()
	{
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x7703FC", Offset = "0x7703FC", VA = "0x7703FC")]
	[DebuggerHidden]
	private IEnumerator AsetaKerjalaiset()
	{
		return null;
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0x770474", Offset = "0x770474", VA = "0x770474")]
	public void AloitaLopetaPeli()
	{
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C9D")]
	[Address(RVA = "0x7704E4", Offset = "0x7704E4", VA = "0x7704E4")]
	public void AloitaSeuraavaPeli()
	{
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x770554", Offset = "0x770554", VA = "0x770554")]
	[DebuggerHidden]
	private IEnumerator LopetaPeli()
	{
		return null;
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x7705CC", Offset = "0x7705CC", VA = "0x7705CC")]
	[DebuggerHidden]
	private IEnumerator SeuraavaPeli()
	{
		return null;
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x770644", Offset = "0x770644", VA = "0x770644")]
	private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x770648", Offset = "0x770648", VA = "0x770648")]
	public void AvaaDropdownPanel(bool avaa)
	{
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x75003C", Offset = "0x75003C", VA = "0x75003C")]
	public void LahetaViesti(string viesti)
	{
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x770738", Offset = "0x770738", VA = "0x770738")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE548", Offset = "0x4BE548")]
	private void LahetaViesti_RPC(string viesti)
	{
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x770820", Offset = "0x770820", VA = "0x770820")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE558", Offset = "0x4BE558")]
	private void AloitaChat_RPC()
	{
	}

	// Token: 0x170005AF RID: 1455
	// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700047B")]
	public bool EnsimmainenPelaaja
	{
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x76F9CC", Offset = "0x76F9CC", VA = "0x76F9CC")]
		set
		{
		}
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA6")]
	[Address(RVA = "0x770E78", Offset = "0x770E78", VA = "0x770E78")]
	public void VastaanotaVaatekoodi(string vKoodi)
	{
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA7")]
	[Address(RVA = "0x770F0C", Offset = "0x770F0C", VA = "0x770F0C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE568", Offset = "0x4BE568")]
	private void VastaanotaStrangerinVaateKoodi_RPC(string vKoodi)
	{
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x771014", Offset = "0x771014", VA = "0x771014")]
	public void VastaanotaOmaID(string _omaID)
	{
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CA9")]
	[Address(RVA = "0x77101C", Offset = "0x77101C", VA = "0x77101C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE578", Offset = "0x4BE578")]
	private void VastaanotaStrangerinID_RPC(string[] _tiedot)
	{
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAA")]
	[Address(RVA = "0x771188", Offset = "0x771188", VA = "0x771188")]
	public void LisaaKaveri()
	{
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x77146C", Offset = "0x77146C", VA = "0x77146C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE588", Offset = "0x4BE588")]
	private void LisattiinKaveriksi()
	{
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x771580", Offset = "0x771580", VA = "0x771580")]
	public void LahetaReport()
	{
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x7716B0", Offset = "0x7716B0", VA = "0x7716B0")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE598", Offset = "0x4BE598")]
	private void VastaanotaReport()
	{
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x771720", Offset = "0x771720", VA = "0x771720")]
	public void LahetaGiftPC()
	{
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x771834", Offset = "0x771834", VA = "0x771834")]
	public void LahetaGift()
	{
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x771958", Offset = "0x771958", VA = "0x771958")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5A8", Offset = "0x4BE5A8")]
	private void VastaanotaGift()
	{
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x771A04", Offset = "0x771A04", VA = "0x771A04")]
	public void LahetaInvite()
	{
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x771B88", Offset = "0x771B88", VA = "0x771B88")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5B8", Offset = "0x4BE5B8")]
	private void VastaanotaInvite()
	{
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x771C64", Offset = "0x771C64", VA = "0x771C64")]
	public void HyvaksyInvite()
	{
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x772108", Offset = "0x772108", VA = "0x772108")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5C8", Offset = "0x4BE5C8")]
	private void InviteHyvaksytty()
	{
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x7721BC", Offset = "0x7721BC", VA = "0x7721BC")]
	public void VastaanotaOmaVarasto(string varastokoodi)
	{
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x7721C4", Offset = "0x7721C4", VA = "0x7721C4")]
	public void VastaanotaVarastoAvattu(bool _avattu)
	{
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x7721D0", Offset = "0x7721D0", VA = "0x7721D0")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5D8", Offset = "0x4BE5D8")]
	private void VastaanotaStrangerinVarasto_RPC(string varastokoodi)
	{
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x7721D8", Offset = "0x7721D8", VA = "0x7721D8")]
	public void VastaanotaOmatPrestigeKerrat(int pKerrat)
	{
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x772358", Offset = "0x772358", VA = "0x772358")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5E8", Offset = "0x4BE5E8")]
	private void VastaanotaStrangerinPrestigeKerrat_RPC(int pKerrat)
	{
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x7721EC", Offset = "0x7721EC", VA = "0x7721EC")]
	private void AsetaPrestigeBadge(int badgeInd, int pKerrat)
	{
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x77236C", Offset = "0x77236C", VA = "0x77236C")]
	public void VastaanotaOmaElainLevel(int _elainLevel)
	{
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x772374", Offset = "0x772374", VA = "0x772374")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE5F8", Offset = "0x4BE5F8")]
	private void VastaanotaStrangerinElainLevel_RPC(int _elainLevel)
	{
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x750248", Offset = "0x750248", VA = "0x750248")]
	public void LahetaKirjoituksenTila(bool kirjoitetaan)
	{
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x77237C", Offset = "0x77237C", VA = "0x77237C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE608", Offset = "0x4BE608")]
	private void VastaanotaKirjoituksenTila_RPC(bool kirjoitetaan)
	{
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x74D388", Offset = "0x74D388", VA = "0x74D388")]
	public void LahetaJackTila(int _tila, bool _ennatys = false)
	{
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x7723F8", Offset = "0x7723F8", VA = "0x7723F8")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE618", Offset = "0x4BE618")]
	private void VastaanotaJackTila_RPC(int _tila)
	{
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x772434", Offset = "0x772434", VA = "0x772434")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE628", Offset = "0x4BE628")]
	private void VastaanotaJackEnnatys_RPC(int _tulos)
	{
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x772464", Offset = "0x772464", VA = "0x772464")]
	public void LahetaVarastoOnMouse(int kategoriaInd)
	{
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x77257C", Offset = "0x77257C", VA = "0x77257C")]
	[Attribute(Name = "PunRPC", RVA = "0x4BE638", Offset = "0x4BE638")]
	private void VastaanotaVarastoOnMouse_RPC(int kategoriaInd)
	{
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x76FDC4", Offset = "0x76FDC4", VA = "0x76FDC4")]
	public void UusiViesti(NetworkManagerP.VRTeksti _viesti)
	{
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x771EF4", Offset = "0x771EF4", VA = "0x771EF4")]
	private void OnVaihdaVarasto()
	{
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x772798", Offset = "0x772798", VA = "0x772798")]
	public void MuutaVarastoUIPaikka(float uusiPosY)
	{
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x770E74", Offset = "0x770E74", VA = "0x770E74")]
	public void PaivitaViestit()
	{
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x7702B8", Offset = "0x7702B8", VA = "0x7702B8")]
	public void TyhjennaKaikkiTekstit()
	{
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x772894", Offset = "0x772894", VA = "0x772894")]
	public void AsetaIPhoneX()
	{
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x77298C", Offset = "0x77298C", VA = "0x77298C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE648", Offset = "0x4BE648")]
	private void <UusiViesti>m__0()
	{
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x772990", Offset = "0x772990", VA = "0x772990")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE658", Offset = "0x4BE658")]
	private void <UusiViesti>m__1()
	{
	}

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x18")]
	public string pelaajanNimi;

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x20")]
	public int tila;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x24")]
	private bool varastossa;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x28")]
	private GameObject pelaaja;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x30")]
	private GameObject pc;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x38")]
	public TextMesh teksti1;

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] prestigeBadget;

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x48")]
	public GameObject dropdownPanel;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x50")]
	public DropdownPanel dropdownP;

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x58")]
	public Button[] dropdownNapit;

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x60")]
	public bool voittaja;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x61")]
	private bool ensimmainenPelaaja;

	// Token: 0x040014F9 RID: 5369
	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x62")]
	private bool omaSpawnattu;

	// Token: 0x040014FA RID: 5370
	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x68")]
	private PhotonView photonView;

	// Token: 0x040014FB RID: 5371
	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject puhekuplaStranger;

	// Token: 0x040014FC RID: 5372
	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x78")]
	public GameObject puhekuplaStrangerVarasto;

	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x80")]
	public GameObject puhekuplaStrangerVarastoJack;

	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x88")]
	private SanaFilter sanafilter;

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x90")]
	private FirebaseControl fbControl;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x98")]
	private bool lopetetaanPeli;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0xA0")]
	private string omaID;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "HideInInspector", RVA = "0x4BE4E8", Offset = "0x4BE4E8")]
	public string strangerinID;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0xB0")]
	private string omaNimi;

	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0xB8")]
	private string strangerinNimi;

	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0xC0")]
	private string omaVarastoKoodi;

	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0xC8")]
	private string strangerVarastoKoodi;

	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0xD0")]
	private bool varastoAvattu;

	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0xD4")]
	private int omatPrestigeKerrat;

	// Token: 0x04001509 RID: 5385
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0xD8")]
	private int strangerinPrestigeKerrat;

	// Token: 0x0400150A RID: 5386
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0xDC")]
	private int omaElainLevel;

	// Token: 0x0400150B RID: 5387
	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0xE0")]
	private int strangerinElainLevel;

	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0xE8")]
	private string vaatekoodi;

	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0xF0")]
	private string strangerinVaatekoodi;

	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0xF8")]
	public Transform[] begChatTekstiPanel;

	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x100")]
	public GameObject[] begChatScrollObj;

	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x108")]
	public GameObject tekstiObj;

	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x110")]
	public GameObject tekstiNappiObj;

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x118")]
	public GameObject lahetettyInviteObj;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0x120")]
	public Sprite[] uiNuolet;

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0x128")]
	private bool varastoUIYlhaalla;

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0x129")]
	private bool iPhoneX;

	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x20003B1")]
	public class VRTeksti
	{
		// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x7706F8", Offset = "0x7706F8", VA = "0x7706F8")]
		public VRTeksti(string _teksti, bool _omaViesti)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x76FD88", Offset = "0x76FD88", VA = "0x76FD88")]
		public VRTeksti(string _teksti, int _giftTyyppi)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700047C")]
		public string Teksti
		{
			[Token(Token = "0x6001CCE")]
			[Address(RVA = "0x772644", Offset = "0x772644", VA = "0x772644")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x1700047D")]
		public int GiftTyyppi
		{
			[Token(Token = "0x6001CCF")]
			[Address(RVA = "0x77263C", Offset = "0x77263C", VA = "0x77263C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x10")]
		private string teksti;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x18")]
		private bool omaViesti;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x1C")]
		private int giftTyyppi;
	}

	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x200055B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE668", Offset = "0x4BE668")]
	private sealed class <PaivitaConnectionState>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060022DF RID: 8927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x76F6A8", Offset = "0x76F6A8", VA = "0x76F6A8")]
		[DebuggerHidden]
		public <PaivitaConnectionState>c__Iterator0()
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x772F28", Offset = "0x772F28", VA = "0x772F28", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CE")]
		private object Current
		{
			[Token(Token = "0x6002489")]
			[Address(RVA = "0x772F64", Offset = "0x772F64", VA = "0x772F64", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CF")]
		private object Current
		{
			[Token(Token = "0x600248A")]
			[Address(RVA = "0x772F6C", Offset = "0x772F6C", VA = "0x772F6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x772F74", Offset = "0x772F74", VA = "0x772F74", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x772F88", Offset = "0x772F88", VA = "0x772F88", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x10")]
		internal object $current;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x18")]
		internal bool $disposing;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x1C")]
		internal int $PC;
	}

	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x200055C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE6C8", Offset = "0x4BE6C8")]
	private sealed class <OmienTietojenVarmistus>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x76F78C", Offset = "0x76F78C", VA = "0x76F78C")]
		[DebuggerHidden]
		public <OmienTietojenVarmistus>c__Iterator1()
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x772CE8", Offset = "0x772CE8", VA = "0x772CE8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D0")]
		private object Current
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x772E9C", Offset = "0x772E9C", VA = "0x772E9C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D1")]
		private object Current
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x772EA4", Offset = "0x772EA4", VA = "0x772EA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x772EAC", Offset = "0x772EAC", VA = "0x772EAC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x772EC0", Offset = "0x772EC0", VA = "0x772EC0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x10")]
		internal NetworkManagerP $this;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x200055D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE728", Offset = "0x4BE728")]
	private sealed class <AsetaKerjalaiset>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x77046C", Offset = "0x77046C", VA = "0x77046C")]
		[DebuggerHidden]
		public <AsetaKerjalaiset>c__Iterator2()
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x772994", Offset = "0x772994", VA = "0x772994", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D2")]
		private object Current
		{
			[Token(Token = "0x6002495")]
			[Address(RVA = "0x772A68", Offset = "0x772A68", VA = "0x772A68", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D3")]
		private object Current
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0x772A70", Offset = "0x772A70", VA = "0x772A70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x772A78", Offset = "0x772A78", VA = "0x772A78", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x772A8C", Offset = "0x772A8C", VA = "0x772A8C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001520 RID: 5408
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x10")]
		internal NetworkManagerP $this;

		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x200055E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE788", Offset = "0x4BE788")]
	private sealed class <LopetaPeli>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x7705C4", Offset = "0x7705C4", VA = "0x7705C4")]
		[DebuggerHidden]
		public <LopetaPeli>c__Iterator3()
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x772AF4", Offset = "0x772AF4", VA = "0x772AF4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D4")]
		private object Current
		{
			[Token(Token = "0x600249B")]
			[Address(RVA = "0x772C5C", Offset = "0x772C5C", VA = "0x772C5C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D5")]
		private object Current
		{
			[Token(Token = "0x600249C")]
			[Address(RVA = "0x772C64", Offset = "0x772C64", VA = "0x772C64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x772C6C", Offset = "0x772C6C", VA = "0x772C6C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x772C80", Offset = "0x772C80", VA = "0x772C80", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x10")]
		internal NetworkManagerP $this;

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x400161A")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x400161B")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}

	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x200055F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4BE7E8", Offset = "0x4BE7E8")]
	private sealed class <SeuraavaPeli>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x77063C", Offset = "0x77063C", VA = "0x77063C")]
		[DebuggerHidden]
		public <SeuraavaPeli>c__Iterator4()
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x772FF0", Offset = "0x772FF0", VA = "0x772FF0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D6")]
		private object Current
		{
			[Token(Token = "0x60024A1")]
			[Address(RVA = "0x773110", Offset = "0x773110", VA = "0x773110", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D7")]
		private object Current
		{
			[Token(Token = "0x60024A2")]
			[Address(RVA = "0x773118", Offset = "0x773118", VA = "0x773118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A3")]
		[Address(RVA = "0x773120", Offset = "0x773120", VA = "0x773120", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024A4")]
		[Address(RVA = "0x773134", Offset = "0x773134", VA = "0x773134", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		// Token: 0x04001528 RID: 5416
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x10")]
		internal NetworkManagerP $this;

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x18")]
		internal object $current;

		// Token: 0x0400152A RID: 5418
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x24")]
		internal int $PC;
	}
}
