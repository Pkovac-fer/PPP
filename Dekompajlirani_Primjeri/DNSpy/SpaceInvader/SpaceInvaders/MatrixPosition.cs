using System;

namespace SpaceInvaders
{
	// Token: 0x02000016 RID: 22
	public class MatrixPosition
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003A3C File Offset: 0x00001C3C
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003A44 File Offset: 0x00001C44
		public int Row { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003A4D File Offset: 0x00001C4D
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00003A55 File Offset: 0x00001C55
		public int Col { get; set; }

		// Token: 0x0600006B RID: 107 RVA: 0x00003A5E File Offset: 0x00001C5E
		public MatrixPosition(int row, int col)
		{
			this.Row = row;
			this.Col = col;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003A78 File Offset: 0x00001C78
		public static MatrixPosition operator +(MatrixPosition a, MatrixPosition b)
		{
			return new MatrixPosition(a.Row + b.Row, a.Col + b.Col);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003AAC File Offset: 0x00001CAC
		public static MatrixPosition operator -(MatrixPosition a, MatrixPosition b)
		{
			return new MatrixPosition(a.Row - b.Row, a.Col - b.Col);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public override bool Equals(object obj)
		{
			MatrixPosition objAsMatrixCoords = obj as MatrixPosition;
			return objAsMatrixCoords.Row == this.Row && objAsMatrixCoords.Col == this.Col;
		}
	}
}
