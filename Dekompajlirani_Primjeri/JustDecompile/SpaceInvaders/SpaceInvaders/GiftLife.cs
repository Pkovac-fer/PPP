using System;

namespace SpaceInvaders
{
	public class GiftLife : Gift
	{
		public GiftLife(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '*';
			base(topLeft, chrArray, speed);
			this.framesPerMove = 5;
		}
	}
}