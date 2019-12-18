using System;

namespace SpaceInvaders
{
	// Token: 0x02000011 RID: 17
	public interface IRenderable
	{
		// Token: 0x0600003F RID: 63
		MatrixPosition GetPosition();

		// Token: 0x06000040 RID: 64
		char[,] GetImage();
	}
}
