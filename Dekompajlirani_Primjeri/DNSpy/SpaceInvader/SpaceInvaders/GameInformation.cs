using System;

namespace SpaceInvaders
{
	// Token: 0x0200000A RID: 10
	public class GameInformation : GameObject
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000312C File Offset: 0x0000132C
		public GameInformation(MatrixPosition topLeft, string msg)
		{
			char[,] array = new char[1, 1];
			array[0, 0] = 'a';
			base..ctor(topLeft, array);
			char[] msgArr = msg.ToCharArray();
			this.image = new char[1, msgArr.Length];
			for (int i = 0; i < msgArr.Length; i++)
			{
				this.image[0, i] = msgArr[i];
			}
			this.topLeft = topLeft;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003194 File Offset: 0x00001394
		public virtual void RefreshMessage(string msg)
		{
			char[] msgArr = msg.ToCharArray();
			this.image = new char[1, msgArr.Length];
			for (int i = 0; i < msgArr.Length; i++)
			{
				this.image[0, i] = msgArr[i];
			}
		}
	}
}
