using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public abstract class GameObject : IRenderable
	{
		protected char[,] image;

		protected MatrixPosition topLeft;

		public int life = 1;

		public bool IsDestroyed
		{
			get;
			protected set;
		}

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

		protected GameObject(MatrixPosition topLeft, char[,] image)
		{
			this.TopLeft = topLeft;
			image.GetLength(0);
			image.GetLength(1);
			this.image = this.CopyImageMatrix(image);
			this.IsDestroyed = false;
		}

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

		protected void Destroy()
		{
			this.life--;
			if (this.life == 0)
			{
				this.IsDestroyed = true;
			}
		}

		public virtual char[,] GetImage()
		{
			return this.CopyImageMatrix(this.image);
		}

		public virtual MatrixPosition GetPosition()
		{
			return this.TopLeft;
		}

		public virtual IEnumerable<GameObject> ProduceObjects()
		{
			return new List<GameObject>();
		}

		public virtual void RespondToCollision(CollisionType collisionType)
		{
		}

		public virtual void Update()
		{
		}
	}
}