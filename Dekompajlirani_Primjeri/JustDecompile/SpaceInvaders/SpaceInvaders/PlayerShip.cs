using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public class PlayerShip : GameObject
	{
		private static PlayerShip instance;

		private bool isShooting;

		public bool IsShooting
		{
			get
			{
				return this.isShooting;
			}
			set
			{
				this.isShooting = value;
			}
		}

		public int Score
		{
			get;
			protected set;
		}

		protected PlayerShip(MatrixPosition topLeft)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = '\u005E';
			base(topLeft, chrArray);
			this.isShooting = false;
			this.life = 3;
			this.Score = 0;
		}

		public void BonusLife()
		{
			this.life++;
		}

		public void IncreaseScore(int bonus)
		{
			this.Score = this.Score + bonus;
		}

		public static PlayerShip Instance(MatrixPosition position)
		{
			if (PlayerShip.instance == null)
			{
				PlayerShip.instance = new PlayerShip(position);
			}
			return PlayerShip.instance;
		}

		public void MoveLeft()
		{
			MatrixPosition col = this.topLeft;
			col.Col = col.Col - 1;
		}

		public void MoveRight()
		{
			MatrixPosition col = this.topLeft;
			col.Col = col.Col + 1;
		}

		public override IEnumerable<GameObject> ProduceObjects()
		{
			List<GameObject> projectiles = new List<GameObject>();
			if (this.isShooting)
			{
				Projectile projectile = new Projectile(new MatrixPosition(this.topLeft.Row, this.topLeft.Col), new MatrixPosition(-1, 0))
				{
					Owner = ProjectileOwner.Player
				};
				projectiles.Add(projectile);
				this.isShooting = false;
			}
			return projectiles;
		}

		public override void RespondToCollision(CollisionType collisionType)
		{
			base.Destroy();
		}
	}
}