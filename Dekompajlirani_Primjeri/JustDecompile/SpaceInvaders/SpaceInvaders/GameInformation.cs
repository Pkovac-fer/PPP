using System;

namespace SpaceInvaders
{
	public class GameInformation : GameObject
	{
		public GameInformation(MatrixPosition topLeft, string msg)
		{
			char[,] chrArray = new char[1, 1];
			chrArray[0, 0] = 'a';
			base(topLeft, chrArray);
			char[] msgArr = msg.ToCharArray();
			this.image = new char[1, (int)msgArr.Length];
			for (int i = 0; i < (int)msgArr.Length; i++)
			{
				this.image[0, i] = msgArr[i];
			}
			this.topLeft = topLeft;
		}

		public virtual void RefreshMessage(string msg)
		{
			char[] msgArr = msg.ToCharArray();
			this.image = new char[1, (int)msgArr.Length];
			for (int i = 0; i < (int)msgArr.Length; i++)
			{
				this.image[0, i] = msgArr[i];
			}
		}
	}
}