using System;

namespace SpaceInvaders
{
	// Token: 0x02000009 RID: 9
	public class GameData
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003046 File Offset: 0x00001246
		public static void IncreaseDifficulty()
		{
			GameData.difficultyLevel++;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003058 File Offset: 0x00001258
		public static bool ShootingProbability()
		{
			int randomNumber = GameData.randomGenerator.Next(1001);
			return randomNumber <= GameData.difficultyLevel;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003090 File Offset: 0x00001290
		public static Gift GetGift()
		{
			Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
			int randomNumber = GameData.randomGenerator.Next(101);
			bool flag = randomNumber <= GameData.giftLevel;
			if (flag)
			{
				int num = GameData.randomGenerator.Next(3);
				int num2 = num;
				if (num2 != 0)
				{
					if (num2 - 1 <= 1)
					{
						producedGift = new GiftPoints(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
					}
				}
				else
				{
					producedGift = new GiftLife(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
				}
			}
			return producedGift;
		}

		// Token: 0x04000015 RID: 21
		private static Random randomGenerator = new Random();

		// Token: 0x04000016 RID: 22
		private static int difficultyLevel = 1;

		// Token: 0x04000017 RID: 23
		private static int giftLevel = 10;
	}
}
