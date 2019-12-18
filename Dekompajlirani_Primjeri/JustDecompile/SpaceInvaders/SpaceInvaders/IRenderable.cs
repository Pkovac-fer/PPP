using System;

namespace SpaceInvaders
{
	public interface IRenderable
	{
		char[,] GetImage();

		MatrixPosition GetPosition();
	}
}