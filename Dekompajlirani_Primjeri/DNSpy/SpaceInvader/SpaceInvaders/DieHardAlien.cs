using System;

namespace SpaceInvaders
{
	// Token: 0x02000007 RID: 7
	public class DieHardAlien : AlienShip
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000286D File Offset: 0x00000A6D
		public DieHardAlien(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '~';
			this.image = array;
			this.life = 3;
		}
	}
}
