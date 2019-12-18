using System;

namespace SpaceInvaders
{
	// Token: 0x0200001A RID: 26
	public class MovingObject : GameObject
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003B8B File Offset: 0x00001D8B
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003B93 File Offset: 0x00001D93
		public MatrixPosition Speed { get; protected set; }

		// Token: 0x06000079 RID: 121 RVA: 0x00003B9C File Offset: 0x00001D9C
		public MovingObject(MatrixPosition topLeft, char[,] image, MatrixPosition speed) : base(topLeft, image)
		{
			this.currentFrame = 0;
			this.framesPerMove = 1;
			this.Speed = speed;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003BC0 File Offset: 0x00001DC0
		protected virtual void UpdatePosition()
		{
			this.currentFrame++;
			bool flag = this.currentFrame == this.framesPerMove;
			if (flag)
			{
				base.TopLeft += this.Speed;
				this.currentFrame = 0;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003C0F File Offset: 0x00001E0F
		public override void Update()
		{
			this.UpdatePosition();
		}

		// Token: 0x04000028 RID: 40
		protected int framesPerMove;

		// Token: 0x04000029 RID: 41
		protected int currentFrame;
	}
}
