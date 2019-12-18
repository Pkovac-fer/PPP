using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
	// Token: 0x0200001F RID: 31
	public class AlienShip : MovingObject
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004098 File Offset: 0x00002298
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000040A0 File Offset: 0x000022A0
		public bool IsShooting { get; set; }

		// Token: 0x06000094 RID: 148 RVA: 0x000040A9 File Offset: 0x000022A9
		public AlienShip(MatrixPosition topLeft, MatrixPosition speed)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '@';
			base..ctor(topLeft, array, speed);
			this.framesPerMove = 5;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000040D0 File Offset: 0x000022D0
		private void ChangeSymbol()
		{
			switch (this.life)
			{
			case 1:
				this.image[0, 0] = '@';
				break;
			case 2:
				this.image[0, 0] = '?';
				break;
			case 3:
				this.image[0, 0] = '~';
				break;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004134 File Offset: 0x00002334
		public override void RespondToCollision(CollisionType collisionType)
		{
			bool flag = collisionType == CollisionType.Bounce;
			if (flag)
			{
				bool flag2 = this.currentFrame == 0;
				if (flag2)
				{
					base.Speed.Col *= -1;
					MatrixPosition topLeft = this.topLeft;
					int row = topLeft.Row;
					topLeft.Row = row + 1;
				}
			}
			bool flag3 = collisionType == CollisionType.Destruction;
			if (flag3)
			{
				base.Destroy();
				this.ChangeSymbol();
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000041A0 File Offset: 0x000023A0
		public override IEnumerable<GameObject> ProduceObjects()
		{
			List<GameObject> producedObjects = new List<GameObject>();
			bool isShooting = this.IsShooting;
			if (isShooting)
			{
				producedObjects.Add(new Projectile(this.topLeft, new MatrixPosition(1, 0))
				{
					Owner = ProjectileOwner.Alien
				});
				this.IsShooting = false;
			}
			Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
			bool isDestroyed = base.IsDestroyed;
			if (isDestroyed)
			{
				producedGift = GameData.GetGift();
				bool flag = producedGift is GiftLife;
				if (flag)
				{
					producedGift = new GiftLife(new MatrixPosition(base.TopLeft.Row + 1, base.TopLeft.Col), new MatrixPosition(1, 0));
					producedObjects.Add(producedGift);
				}
				bool flag2 = producedGift is GiftPoints;
				if (flag2)
				{
					producedGift = new GiftPoints(new MatrixPosition(base.TopLeft.Row + 1, base.TopLeft.Col), new MatrixPosition(1, 0));
					producedObjects.Add(producedGift);
				}
			}
			return producedObjects;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000042A4 File Offset: 0x000024A4
		public override void Update()
		{
			bool flag = GameData.ShootingProbability();
			if (flag)
			{
				this.IsShooting = true;
			}
			this.UpdatePosition();
		}
	}
}
