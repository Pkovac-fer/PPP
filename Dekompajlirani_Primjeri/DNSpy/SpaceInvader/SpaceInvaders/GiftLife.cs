using System;

namespace SpaceInvaders
{
	// Token: 0x0200000D RID: 13
	public class GiftLife : Gift
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000033EF File Offset: 0x000015EF
		public GiftLife(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '*';
			base..ctor(topLeft, array, speed);
			this.framesPerMove = 5;
		}
	}
}
