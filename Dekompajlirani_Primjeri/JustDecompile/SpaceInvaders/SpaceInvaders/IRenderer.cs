using System;

namespace SpaceInvaders
{
	public interface IRenderer
	{
		void ClearQueue();

		void EnqueueForRendering(IRenderable obj);

		int GetWidth();

		void RenderAll();
	}
}