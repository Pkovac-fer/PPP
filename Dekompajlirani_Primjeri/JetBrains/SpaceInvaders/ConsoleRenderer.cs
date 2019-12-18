// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.ConsoleRenderer
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

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

    public void EnqueueForRendering(IRenderable obj)
    {
      char[,] image = obj.GetImage();
      int length1 = image.GetLength(0);
      int length2 = image.GetLength(1);
      MatrixPosition position = obj.GetPosition();
      int num1 = Math.Min(position.Row + length1, this.renderContextMatrixRows);
      int num2 = Math.Min(position.Col + length2, this.renderContextMatrixCols);
      for (int row = obj.GetPosition().Row; row < num1; ++row)
      {
        for (int col = obj.GetPosition().Col; col < num2; ++col)
        {
          if (row >= 0 && row < this.renderContextMatrixRows && col >= 0 && col < this.renderContextMatrixCols)
            this.renderContextMatrix[row, col] = image[row - obj.GetPosition().Row, col - obj.GetPosition().Col];
        }
      }
    }

    public void RenderAll()
    {
      Console.SetCursorPosition(0, 0);
      StringBuilder stringBuilder = new StringBuilder();
      for (int index1 = 0; index1 < this.renderContextMatrixRows; ++index1)
      {
        for (int index2 = 0; index2 < this.renderContextMatrixCols; ++index2)
          stringBuilder.Append(this.renderContextMatrix[index1, index2]);
        stringBuilder.Append(Environment.NewLine);
      }
      Console.WriteLine(stringBuilder.ToString());
    }

    public void ClearQueue()
    {
      for (int index1 = 0; index1 < this.renderContextMatrixRows; ++index1)
      {
        for (int index2 = 0; index2 < this.renderContextMatrixCols; ++index2)
          this.renderContextMatrix[index1, index2] = ' ';
      }
    }

    public int GetWidth()
    {
      return this.renderContextMatrixCols;
    }
  }
}
