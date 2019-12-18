using System;

namespace SpaceInvaders
{
	// Token: 0x0200000C RID: 12
	public class Gift : MovingObject
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003397 File Offset: 0x00001597
		public Gift(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = 'G';
			base..ctor(topLeft, array, speed);
			this.framesPerMove = 5;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000033BB File Offset: 0x000015BB
		public Gift(MatrixPosition topLeft, char[,] image, MatrixPosition speed) : base(topLeft, image, speed)
		{
			this.framesPerMove = 5;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000033D0 File Offset: 0x000015D0
		public override void RespondToCollision(CollisionType collisionType)
		{
			bool flag = collisionType == CollisionType.Destruction;
			if (flag)
			{
				base.Destroy();
			}
		}
	}
}
