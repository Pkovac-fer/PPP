using System;

namespace SpaceInvaders
{
	// Token: 0x02000006 RID: 6
	public class Cursor : GameObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000027D0 File Offset: 0x000009D0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000027E8 File Offset: 0x000009E8
		public bool IsActive
		{
			get
			{
				return this.isActive;
			}
			set
			{
				this.isActive = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000027F2 File Offset: 0x000009F2
		public Cursor(MatrixPosition topLeft)
		{
			char[,] array = new char[1, 2];
			array[0, 0] = '>';
			array[0, 1] = '>';
			base..ctor(topLeft, array);
			this.isActive = false;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002820 File Offset: 0x00000A20
		public void MoveUp()
		{
			bool flag = this.topLeft.Row > 3;
			if (flag)
			{
				this.topLeft.Row -= 2;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002856 File Offset: 0x00000A56
		public void MoveDown()
		{
			this.topLeft.Row += 2;
		}

		// Token: 0x04000007 RID: 7
		public bool isActive;
	}
}
