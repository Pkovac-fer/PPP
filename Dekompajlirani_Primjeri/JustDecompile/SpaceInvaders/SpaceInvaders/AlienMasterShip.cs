using System;

namespace SpaceInvaders
{
	public class AlienMasterShip : AlienShip
	{
		public AlienMasterShip(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '?';
			this.image = chrArray;
			this.life = 2;
		}
	}
}