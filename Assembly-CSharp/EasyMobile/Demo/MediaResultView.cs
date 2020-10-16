using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000048")]
	public class MediaResultView : MonoBehaviour
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x58F394", Offset = "0x58F394", VA = "0x58F394")]
		public MediaResultView()
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public Color VideoBackground
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x58F39C", Offset = "0x58F39C", VA = "0x58F39C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0250", Offset = "0x4B0250")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x58EC88", Offset = "0x58EC88", VA = "0x58EC88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0260", Offset = "0x4B0260")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public FullScreenMovieControlMode VideoControlMode
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x58F3A8", Offset = "0x58F3A8", VA = "0x58F3A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0270", Offset = "0x4B0270")]
			get
			{
				return FullScreenMovieControlMode.Full;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x58EC94", Offset = "0x58EC94", VA = "0x58EC94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0280", Offset = "0x4B0280")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00002D48 File Offset: 0x00000F48
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public FullScreenMovieScalingMode VideoScalingMode
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x58F3B0", Offset = "0x58F3B0", VA = "0x58F3B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0290", Offset = "0x4B0290")]
			get
			{
				return FullScreenMovieScalingMode.None;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x58EC9C", Offset = "0x58EC9C", VA = "0x58EC9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B02A0", Offset = "0x4B02A0")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x17000086")]
		public int MaxImageSize
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x58F3B8", Offset = "0x58F3B8", VA = "0x58F3B8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x58F49C", Offset = "0x58F49C", VA = "0x58F49C")]
		private void Start()
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x58F5E0", Offset = "0x58F5E0", VA = "0x58F5E0")]
		public MediaResult GetMedia()
		{
			return null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x58EB58", Offset = "0x58EB58", VA = "0x58EB58")]
		public void UpdateWithError(string error)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x58ECA4", Offset = "0x58ECA4", VA = "0x58ECA4")]
		public void UpdateWithModel(MediaResult newModel)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x58F5E8", Offset = "0x58F5E8", VA = "0x58F5E8")]
		public void Load()
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x58F65C", Offset = "0x58F65C", VA = "0x58F65C")]
		private void LoadImage()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x58F708", Offset = "0x58F708", VA = "0x58F708")]
		private void PlayVideo()
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x58F758", Offset = "0x58F758", VA = "0x58F758")]
		private void LoadImageCallback(string error, Texture2D image)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x58F828", Offset = "0x58F828", VA = "0x58F828")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B02B0", Offset = "0x4B02B0")]
		private void <Start>m__0()
		{
		}

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text infoText;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputField maxImageSizeInput;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject maxImageSizeRoot;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button loadButton;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button removeButton;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MediaDemo mediaDemo;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x48")]
		private MediaResult model;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x50")]
		private string error;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B019C", Offset = "0x4B019C")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4B019C", Offset = "0x4B019C")]
		private Color <VideoBackground>k__BackingField;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B01D8", Offset = "0x4B01D8")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4B01D8", Offset = "0x4B01D8")]
		private FullScreenMovieControlMode <VideoControlMode>k__BackingField;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B0214", Offset = "0x4B0214")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4B0214", Offset = "0x4B0214")]
		private FullScreenMovieScalingMode <VideoScalingMode>k__BackingField;
	}
}
