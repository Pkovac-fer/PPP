using System;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public class MovingObject : GameObject
	{
		protected int framesPerMove;

		protected int currentFrame;

		public MatrixPosition Speed
		{
			get;
			protected set;
		}

		public MovingObject(MatrixPosition topLeft, char[,] image, MatrixPosition speed) : base(topLeft, image)
		{
			this.currentFrame = 0;
			this.framesPerMove = 1;
			this.Speed = speed;
		}

		public override void Update()
		{
			this.UpdatePosition();
		}

		protected virtual void UpdatePosition()
		{
			this.currentFrame++;
			if (this.currentFrame == this.framesPerMove)
			{
				base.TopLeft = base.TopLeft + this.Speed;
				this.currentFrame = 0;
			}
		}
	}
}