using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public class AlienShip : MovingObject
	{
		public bool IsShooting
		{
			get;
			set;
		}

		public AlienShip(MatrixPosition topLeft, MatrixPosition speed)
			: base(topLeft, new char[,] { { '@' } }, speed) {

			this.framesPerMove = 5;
		}

		private void ChangeSymbol()
		{
			switch (this.life)
			{
				case 1:
				{
					this.image[0, 0] = '@';
					break;
				}
				case 2:
				{
					this.image[0, 0] = '?';
					break;
				}
				case 3:
				{
					this.image[0, 0] = '~';
					break;
				}
			}
		}

		public override IEnumerable<GameObject> ProduceObjects()
		{
			List<GameObject> producedObjects = new List<GameObject>();
			if (this.IsShooting)
			{
				Projectile projectile = new Projectile(this.topLeft, new MatrixPosition(1, 0))
				{
					Owner = ProjectileOwner.Alien
				};
				producedObjects.Add(projectile);
				this.IsShooting = false;
			}
			Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
			if (base.IsDestroyed)
			{
				producedGift = GameData.GetGift();
				if (producedGift is GiftLife)
				{
					producedGift = new GiftLife(new MatrixPosition(base.TopLeft.Row + 1, base.TopLeft.Col), new MatrixPosition(1, 0));
					producedObjects.Add(producedGift);
				}
				if (producedGift is GiftPoints)
				{
					producedGift = new GiftPoints(new MatrixPosition(base.TopLeft.Row + 1, base.TopLeft.Col), new MatrixPosition(1, 0));
					producedObjects.Add(producedGift);
				}
			}
			return producedObjects;
		}

		public override void RespondToCollision(CollisionType collisionType)
		{
			if (collisionType == CollisionType.Bounce)
			{
				if (this.currentFrame == 0)
				{
					MatrixPosition speed = base.Speed;
					speed.Col = speed.Col * -1;
					MatrixPosition row = this.topLeft;
					row.Row = row.Row + 1;
				}
			}
			if (collisionType == CollisionType.Destruction)
			{
				base.Destroy();
				this.ChangeSymbol();
			}
		}

		public override void Update()
		{
			if (GameData.ShootingProbability())
			{
				this.IsShooting = true;
			}
			this.UpdatePosition();
		}
	}
}
