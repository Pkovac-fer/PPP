// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.GameData
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  public class GameData
  {
    private static Random randomGenerator = new Random();
    private static int difficultyLevel = 1;
    private static int giftLevel = 10;

    public static void IncreaseDifficulty()
    {
      ++GameData.difficultyLevel;
    }

    public static bool ShootingProbability()
    {
      return GameData.randomGenerator.Next(1001) <= GameData.difficultyLevel;
    }

    public static Gift GetGift()
    {
      Gift gift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
      if (GameData.randomGenerator.Next(101) <= GameData.giftLevel)
      {
        switch (GameData.randomGenerator.Next(3))
        {
          case 0:
            gift = (Gift) new GiftLife(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
            break;
          case 1:
          case 2:
            gift = (Gift) new GiftPoints(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
            break;
        }
      }
      return gift;
    }
  }
}
