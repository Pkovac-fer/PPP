using System;

namespace SpaceInvaders
{
	// Token: 0x02000019 RID: 25
	public class StartResume : MenuItem
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003B57 File Offset: 0x00001D57
		public StartResume(MatrixPosition topLeft) : base(topLeft, StartResume.message)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003B67 File Offset: 0x00001D67
		public override void TakeAction(Engine engine)
		{
			engine.Run();
		}

		// Token: 0x04000027 RID: 39
		public new static char[,] message = new char[,]
		{
			{
				'S',
				'T',
				'A',
				'R',
				'T',
				'/',
				'R',
				'E',
				'S',
				'U',
				'M',
				'E'
			}
		};
	}
}
