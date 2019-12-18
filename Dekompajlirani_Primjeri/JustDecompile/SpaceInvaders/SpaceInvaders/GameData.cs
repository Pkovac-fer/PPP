using System;

namespace SpaceInvaders
{
	public class GameData
	{
		private static Random randomGenerator;

		private static int difficultyLevel;

		private static int giftLevel;

		static GameData()
		{
			GameData.randomGenerator = new Random();
			GameData.difficultyLevel = 1;
			GameData.giftLevel = 10;
		}

		public GameData()
		{
		}

		public static Gift GetGift()
		{
			Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
			if (GameData.randomGenerator.Next(101) <= GameData.giftLevel)
			{
				int num = GameData.randomGenerator.Next(3);
				if (num == 0)
				{
					producedGift = new GiftLife(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
				}
				else if (num - 1 <= 1)
				{
					producedGift = new GiftPoints(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
				}
			}
			return producedGift;
		}

		public static void IncreaseDifficulty()
		{
			GameData.difficultyLevel++;
		}

		public static bool ShootingProbability()
		{
			bool flag;
			flag = (GameData.randomGenerator.Next(0x3e9) > GameData.difficultyLevel ? false : true);
			return flag;
		}
	}
}