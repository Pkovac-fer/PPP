﻿using System;

namespace SpaceInvaders
{
	// Token: 0x02000002 RID: 2
	public class AlienMasterShip : AlienShip
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AlienMasterShip(MatrixPosition topLeft, MatrixPosition speed) : base(topLeft, speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '?';
			this.image = array;
			this.life = 2;
		}
	}
}
