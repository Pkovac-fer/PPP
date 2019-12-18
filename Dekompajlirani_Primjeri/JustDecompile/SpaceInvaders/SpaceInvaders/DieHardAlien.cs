using System;

namespace SpaceInvaders
{
	public class DieHardAlien : AlienShip
	{
		public DieHardAlien(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '~';
			this.image = chrArray;
			this.life = 3;
		}
	}
}