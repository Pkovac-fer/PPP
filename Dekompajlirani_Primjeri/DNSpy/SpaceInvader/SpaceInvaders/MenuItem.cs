using System;

namespace SpaceInvaders
{
	// Token: 0x02000018 RID: 24
	public abstract class MenuItem : GameObject
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003B4B File Offset: 0x00001D4B
		protected MenuItem(MatrixPosition topLeft, char[,] message) : base(topLeft, message)
		{
		}

		// Token: 0x06000073 RID: 115
		public abstract void TakeAction(Engine engine);

		// Token: 0x04000026 RID: 38
		protected char[,] message;
	}
}
