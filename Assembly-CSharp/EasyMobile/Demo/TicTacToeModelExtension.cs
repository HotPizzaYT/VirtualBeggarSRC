using System;
using Il2CppDummyDll;

namespace EasyMobile.Demo
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x200003E")]
	public static class TicTacToeModelExtension
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x5A303C", Offset = "0x5A303C", VA = "0x5A303C")]
		public static TicTacToeGameModel.TileState ToTileState(this TicTacToeGameModel.Mark turn)
		{
			return TicTacToeGameModel.TileState.Blank;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x5A4474", Offset = "0x5A4474", VA = "0x5A4474")]
		public static TicTacToeGameModel.TransferableDatas ToTicTacToeGameTranferDatas(this byte[] bytes)
		{
			return null;
		}
	}
}
