using System;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	public class MatrixPosition
	{
		public int Col
		{
			get;
			set;
		}

		public int Row
		{
			get;
			set;
		}

		public MatrixPosition(int row, int col)
		{
			this.Row = row;
			this.Col = col;
		}

		public override bool Equals(object obj)
		{
			MatrixPosition objAsMatrixCoords = obj as MatrixPosition;
			return (objAsMatrixCoords.Row != this.Row ? false : objAsMatrixCoords.Col == this.Col);
		}

		public static MatrixPosition operator +(MatrixPosition a, MatrixPosition b)
		{
			MatrixPosition matrixPosition = new MatrixPosition(a.Row + b.Row, a.Col + b.Col);
			return matrixPosition;
		}

		public static MatrixPosition operator -(MatrixPosition a, MatrixPosition b)
		{
			MatrixPosition matrixPosition = new MatrixPosition(a.Row - b.Row, a.Col - b.Col);
			return matrixPosition;
		}
	}
}