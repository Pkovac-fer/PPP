using System;

namespace Snake
{
	// Token: 0x02000002 RID: 2
	internal struct Position
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Position(int row, int col)
		{
			this.row = row;
			this.col = col;
		}

		// Token: 0x04000001 RID: 1
		public int row;

		// Token: 0x04000002 RID: 2
		public int col;
	}
}
