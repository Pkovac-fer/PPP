using System;

namespace SpaceInvaders
{
	public class Gift : MovingObject
	{
		public Gift(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = 'G';
			base(topLeft, chrArray, speed);
			this.framesPerMove = 5;
		}

		public Gift(MatrixPosition topLeft, char[,] image, MatrixPosition speed) : base(topLeft, image, speed)
		{
			this.framesPerMove = 5;
		}

		public override void RespondToCollision(CollisionType collisionType)
		{
			if (collisionType == CollisionType.Destruction)
			{
				base.Destroy();
			}
		}
	}
}