// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.MatrixPosition
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

namespace SpaceInvaders
{
  public class MatrixPosition
  {
    public int Row { get; set; }

    public int Col { get; set; }

    public MatrixPosition(int row, int col)
    {
      this.Row = row;
      this.Col = col;
    }

    public static MatrixPosition operator +(MatrixPosition a, MatrixPosition b)
    {
      return new MatrixPosition(a.Row + b.Row, a.Col + b.Col);
    }

    public static MatrixPosition operator -(MatrixPosition a, MatrixPosition b)
    {
      return new MatrixPosition(a.Row - b.Row, a.Col - b.Col);
    }

    public override bool Equals(object obj)
    {
      MatrixPosition matrixPosition = obj as MatrixPosition;
      return matrixPosition.Row == this.Row && matrixPosition.Col == this.Col;
    }
  }
}
