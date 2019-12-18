using System;

namespace SpaceInvaders
{
	// Token: 0x02000012 RID: 18
	public interface IRenderer
	{
		// Token: 0x06000041 RID: 65
		void EnqueueForRendering(IRenderable obj);

		// Token: 0x06000042 RID: 66
		void RenderAll();

		// Token: 0x06000043 RID: 67
		void ClearQueue();

		// Token: 0x06000044 RID: 68
		int GetWidth();
	}
}
