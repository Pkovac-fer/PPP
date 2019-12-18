using System;

namespace SpaceInvaders
{
	// Token: 0x02000017 RID: 23
	public class Exit : MenuItem
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003B18 File Offset: 0x00001D18
		public Exit(MatrixPosition topLeft) : base(topLeft, Exit.message)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003B28 File Offset: 0x00001D28
		public override void TakeAction(Engine engine)
		{
			Environment.Exit(0);
		}

		// Token: 0x04000025 RID: 37
		public new static char[,] message = new char[,]
		{
			{
				'E',
				'X',
				'I',
				'T'
			}
		};
	}
}
