using System;

namespace SpaceInvaders
{
	// Token: 0x0200001E RID: 30
	public class Projectile : MovingObject
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000404A File Offset: 0x0000224A
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00004052 File Offset: 0x00002252
		public ProjectileOwner Owner { get; set; }

		// Token: 0x06000090 RID: 144 RVA: 0x0000405B File Offset: 0x0000225B
		public Projectile(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '|';
			base..ctor(topLeft, array, speed);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004078 File Offset: 0x00002278
		public override void RespondToCollision(CollisionType collisionType)
		{
			bool flag = collisionType == CollisionType.Destruction;
			if (flag)
			{
				base.IsDestroyed = true;
			}
		}
	}
}
