using System;
using System.Text;

namespace SpaceInvaders
{
	public class ConsoleRenderer : IRenderer
	{
		private int renderContextMatrixRows;

		private int renderContextMatrixCols;

		private char[,] renderContextMatrix;

		public ConsoleRenderer(int visibleConsoleRows, int visibleConsoleCols)
		{
			this.renderContextMatrix = new char[visibleConsoleRows, visibleConsoleCols + 10];
			this.renderContextMatrixRows = this.renderContextMatrix.GetLength(0);
			this.renderContextMatrixCols = this.renderContextMatrix.GetLength(1) - 10;
			this.ClearQueue();
		}

		public void ClearQueue()
		{
			for (int row = 0; row < this.renderContextMatrixRows; row++)
			{
				for (int col = 0; col < this.renderContextMatrixCols; col++)
				{
					this.renderContextMatrix[row, col] = ' ';
				}
			}
		}

		public void EnqueueForRendering(IRenderable obj)
		{
			char[,] objImage = obj.GetImage();
			int imageRows = objImage.GetLength(0);
			int imageCols = objImage.GetLength(1);
			MatrixPosition objTopLeft = obj.GetPosition();
			int lastRow = Math.Min(objTopLeft.Row + imageRows, this.renderContextMatrixRows);
			int lastCol = Math.Min(objTopLeft.Col + imageCols, this.renderContextMatrixCols);
			for (int row = obj.GetPosition().Row; row < lastRow; row++)
			{
				for (int col = obj.GetPosition().Col; col < lastCol; col++)
				{
					if ((row < 0 || row >= this.renderContextMatrixRows || col < 0 ? false : col < this.renderContextMatrixCols))
					{
						this.renderContextMatrix[row, col] = objImage[row - obj.GetPosition().Row, col - obj.GetPosition().Col];
					}
				}
			}
		}

		public int GetWidth()
		{
			return this.renderContextMatrixCols;
		}

		public void RenderAll()
		{
			Console.SetCursorPosition(0, 0);
			StringBuilder scene = new StringBuilder();
			for (int row = 0; row < this.renderContextMatrixRows; row++)
			{
				for (int col = 0; col < this.renderContextMatrixCols; col++)
				{
					scene.Append(this.renderContextMatrix[row, col]);
				}
				scene.Append(Environment.NewLine);
			}
			Console.WriteLine(scene.ToString());
		}
	}
}