using System;

namespace SpaceInvaders
{
	public class HiveShip : AlienShip
	{
		public HiveShip(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '&';
			this.image = chrArray;
			this.life = 5;
		}
	}
}