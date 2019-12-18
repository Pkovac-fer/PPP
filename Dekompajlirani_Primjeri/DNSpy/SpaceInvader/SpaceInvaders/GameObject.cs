using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
	// Token: 0x0200000B RID: 11
	public abstract class GameObject : IRenderable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000031DC File Offset: 0x000013DC
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00003209 File Offset: 0x00001409
		public MatrixPosition TopLeft
		{
			get
			{
				return new MatrixPosition(this.topLeft.Row, this.topLeft.Col);
			}
			protected set
			{
				this.topLeft = new MatrixPosition(value.Row, value.Col);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003223 File Offset: 0x00001423
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000322B File Offset: 0x0000142B
		public bool IsDestroyed { get; protected set; }

		// Token: 0x0600002D RID: 45 RVA: 0x00003234 File Offset: 0x00001434
		protected GameObject(MatrixPosition topLeft, char[,] image)
		{
			this.TopLeft = topLeft;
			int imageRows = image.GetLength(0);
			int imageCols = image.GetLength(1);
			this.image = this.CopyImageMatrix(image);
			this.IsDestroyed = false;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003280 File Offset: 0x00001480
		private char[,] CopyImageMatrix(char[,] matrixToCopy)
		{
			int rows = matrixToCopy.GetLength(0);
			int cols = matrixToCopy.GetLength(1);
			char[,] result = new char[rows, cols];
			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					result[row, col] = matrixToCopy[row, col];
				}
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000032EC File Offset: 0x000014EC
		public virtual MatrixPosition GetPosition()
		{
			return this.TopLeft;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003304 File Offset: 0x00001504
		public virtual char[,] GetImage()
		{
			return this.CopyImageMatrix(this.image);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003324 File Offset: 0x00001524
		public virtual IEnumerable<GameObject> ProduceObjects()
		{
			return new List<GameObject>();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000333B File Offset: 0x0000153B
		public virtual void Update()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000333B File Offset: 0x0000153B
		public virtual void RespondToCollision(CollisionType collisionType)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003340 File Offset: 0x00001540
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003358 File Offset: 0x00001558
		public int Life
		{
			get
			{
				return this.life;
			}
			private set
			{
				this.life = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003364 File Offset: 0x00001564
		protected void Destroy()
		{
			this.life--;
			bool flag = this.life == 0;
			if (flag)
			{
				this.IsDestroyed = true;
			}
		}

		// Token: 0x04000018 RID: 24
		protected char[,] image;

		// Token: 0x04000019 RID: 25
		protected MatrixPosition topLeft;

		// Token: 0x0400001B RID: 27
		public int life = 1;
	}
}
