using System;

namespace SpaceInvaders
{
	// Token: 0x0200000F RID: 15
	public class HiveShip : AlienShip
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003437 File Offset: 0x00001637
		public HiveShip(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '&';
			this.image = array;
			this.life = 5;
		}
	}
}
