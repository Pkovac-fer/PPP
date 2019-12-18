using System;
using System.Text;

namespace SpaceInvaders
{
	// Token: 0x02000005 RID: 5
	public class ConsoleRenderer : IRenderer
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000025A4 File Offset: 0x000007A4
		public ConsoleRenderer(int visibleConsoleRows, int visibleConsoleCols)
		{
			this.renderContextMatrix = new char[visibleConsoleRows, visibleConsoleCols + 10];
			this.renderContextMatrixRows = this.renderContextMatrix.GetLength(0);
			this.renderContextMatrixCols = this.renderContextMatrix.GetLength(1) - 10;
			this.ClearQueue();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000025F8 File Offset: 0x000007F8
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
					bool flag = row >= 0 && row < this.renderContextMatrixRows && col >= 0 && col < this.renderContextMatrixCols;
					if (flag)
					{
						this.renderContextMatrix[row, col] = objImage[row - obj.GetPosition().Row, col - obj.GetPosition().Col];
					}
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000026F4 File Offset: 0x000008F4
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

		// Token: 0x06000008 RID: 8 RVA: 0x0000276C File Offset: 0x0000096C
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

		// Token: 0x06000009 RID: 9 RVA: 0x000027B8 File Offset: 0x000009B8
		public int GetWidth()
		{
			return this.renderContextMatrixCols;
		}

		// Token: 0x04000004 RID: 4
		private int renderContextMatrixRows;

		// Token: 0x04000005 RID: 5
		private int renderContextMatrixCols;

		// Token: 0x04000006 RID: 6
		private char[,] renderContextMatrix;
	}
}
