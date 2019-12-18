using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
	// Token: 0x0200001B RID: 27
	public class PlayerShip : GameObject
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003C19 File Offset: 0x00001E19
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003C21 File Offset: 0x00001E21
		public int Score { get; protected set; }

		// Token: 0x0600007E RID: 126 RVA: 0x00003C2A File Offset: 0x00001E2A
		protected PlayerShip(MatrixPosition topLeft)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = '^';
			base..ctor(topLeft, array);
			this.isShooting = false;
			this.life = 3;
			this.Score = 0;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003C5C File Offset: 0x00001E5C
		public static PlayerShip Instance(MatrixPosition position)
		{
			bool flag = PlayerShip.instance == null;
			if (flag)
			{
				PlayerShip.instance = new PlayerShip(position);
			}
			return PlayerShip.instance;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003C8C File Offset: 0x00001E8C
		public void IncreaseScore(int bonus)
		{
			this.Score += bonus;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003C9E File Offset: 0x00001E9E
		public void BonusLife()
		{
			this.life++;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003CB0 File Offset: 0x00001EB0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00003CC8 File Offset: 0x00001EC8
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

		// Token: 0x06000084 RID: 132 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public void MoveLeft()
		{
			MatrixPosition topLeft = this.topLeft;
			int col = topLeft.Col;
			topLeft.Col = col - 1;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public void MoveRight()
		{
			MatrixPosition topLeft = this.topLeft;
			int col = topLeft.Col;
			topLeft.Col = col + 1;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003D1C File Offset: 0x00001F1C
		public override IEnumerable<GameObject> ProduceObjects()
		{
			List<GameObject> projectiles = new List<GameObject>();
			bool flag = this.isShooting;
			if (flag)
			{
				projectiles.Add(new Projectile(new MatrixPosition(this.topLeft.Row, this.topLeft.Col), new MatrixPosition(-1, 0))
				{
					Owner = ProjectileOwner.Player
				});
				this.isShooting = false;
			}
			return projectiles;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003D80 File Offset: 0x00001F80
		public override void RespondToCollision(CollisionType collisionType)
		{
			base.Destroy();
		}

		// Token: 0x0400002B RID: 43
		private static PlayerShip instance;

		// Token: 0x0400002C RID: 44
		private bool isShooting;
	}
}
