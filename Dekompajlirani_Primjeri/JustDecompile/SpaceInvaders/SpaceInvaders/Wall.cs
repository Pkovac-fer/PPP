using System;

namespace SpaceInvaders
{
	public class Wall : GameObject
	{
		public Wall(MatrixPosition topLeft)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '#';
			base(topLeft, chrArray);
		}
	}
}