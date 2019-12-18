using System;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public class Projectile : MovingObject
	{
		public ProjectileOwner Owner
		{
			get;
			set;
		}

		public Projectile(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '|';
			base(topLeft, chrArray, speed);
		}

		public override void RespondToCollision(CollisionType collisionType)
		{
			if (collisionType == CollisionType.Destruction)
			{
				base.IsDestroyed = true;
			}
		}
	}
}