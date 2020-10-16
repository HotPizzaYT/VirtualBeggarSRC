using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace EasyMobile.Demo
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000047")]
	public class MediaDemo : MonoBehaviour
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x58D1D8", Offset = "0x58D1D8", VA = "0x58D1D8")]
		public MediaDemo()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x58D278", Offset = "0x58D278", VA = "0x58D278", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x58DBFC", Offset = "0x58DBFC", VA = "0x58DBFC")]
		public void TakePicture()
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x58DD18", Offset = "0x58DD18", VA = "0x58DD18")]
		public void RecordVideo()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x58DE34", Offset = "0x58DE34", VA = "0x58DE34")]
		public void PickFromGallery()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x58DF3C", Offset = "0x58DF3C", VA = "0x58DF3C")]
		public void SaveImage()
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x58E274", Offset = "0x58E274", VA = "0x58E274")]
		public void UpdateDisplayImage(Texture2D texture)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x58E6DC", Offset = "0x58E6DC", VA = "0x58E6DC")]
		public void CameraCallback(string error, MediaResult result)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x58E9D8", Offset = "0x58E9D8", VA = "0x58E9D8")]
		public void GalleryPickCallback(string error, MediaResult[] result)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x58EAA0", Offset = "0x58EAA0", VA = "0x58EAA0")]
		public void SaveImageCallback(string error)
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x58E8D4", Offset = "0x58E8D4", VA = "0x58E8D4")]
		public void AddViewWithError(string error)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x58E770", Offset = "0x58E770", VA = "0x58E770")]
		public void AddView(MediaResult model)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x58EEC0", Offset = "0x58EEC0", VA = "0x58EEC0")]
		public void RemoveDisplayedView(MediaResultView view)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x58EFCC", Offset = "0x58EFCC", VA = "0x58EFCC")]
		public void RandomDisplayImage()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x58F1E0", Offset = "0x58F1E0", VA = "0x58F1E0")]
		public void ClearDisplayImage()
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x58F214", Offset = "0x58F214", VA = "0x58F214")]
		private void ClearDisplayedViews()
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x58D888", Offset = "0x58D888", VA = "0x58D888")]
		private void InitDropdownWithEnum(Dropdown dropdown, Type enumType)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x58EFF4", Offset = "0x58EFF4", VA = "0x58EFF4")]
		private Texture2D GenerateRandomTexture2D()
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x58E338", Offset = "0x58E338", VA = "0x58E338")]
		private Vector2 SizeToParent(RectTransform parent, RectTransform imageTransform, RawImage image, float padding = 0f)
		{
			return default(Vector2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x58F38C", Offset = "0x58F38C", VA = "0x58F38C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B012C", Offset = "0x4B012C")]
		private void <Start>m__0(int index)
		{
		}

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject curtain;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private uint randomTextureWidth;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private uint randomTextureHeight;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color[] randomTextureColors;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color videoBackground;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float imagePadding;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private FullScreenMovieControlMode videoControlMode;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullScreenMovieScalingMode videoScalingMode;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MediaResultView viewPrefab;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform viewRoot;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RawImage displayImage;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform displayImageTransform;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform parentTransform;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField imageNameInputField;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Dropdown imageFormatDropdown;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Dropdown cameraTypeDropdown;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DemoUtils demoUtils;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject frontCameraSupportedToggle;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject backCameraSupportedToggle;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button takePictureButton;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button recordVideoButton;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button pickButton;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button saveImageButton;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button clearViewsButton;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button randomTextureButton;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Button clearTexutreButton;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0xE0")]
		private List<MediaResultView> displayedViews;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0xE8")]
		private CameraType currentCameraType;
	}
}
