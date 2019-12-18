using System;

namespace SpaceInvaders
{
	public class GiftPoints : Gift
	{
		public GiftPoints(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '$';
			base(topLeft, chrArray, speed);
			this.framesPerMove = 5;
		}
	}
}