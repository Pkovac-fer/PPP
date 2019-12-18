using System;

namespace SpaceInvaders
{
	// Token: 0x02000021 RID: 33
	public class Wall : GameObject
	{
		// Token: 0x0600009A RID: 154 RVA: 0x000042CC File Offset: 0x000024CC
		public Wall(MatrixPosition topLeft)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '#';
			base..ctor(topLeft, array);
		}
	}
}
