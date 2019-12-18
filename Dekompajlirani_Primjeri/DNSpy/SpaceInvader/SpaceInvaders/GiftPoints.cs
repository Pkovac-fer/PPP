using System;

namespace SpaceInvaders
{
	// Token: 0x0200000E RID: 14
	public class GiftPoints : Gift
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003413 File Offset: 0x00001613
		public GiftPoints(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '$';
			base..ctor(topLeft, array, speed);
			this.framesPerMove = 5;
		}
	}
}
