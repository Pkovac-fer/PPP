// Decompiled with JetBrains decompiler
// Type: SpaceInvaders.ProgramExecution
// Assembly: SpaceInvaders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 88196E59-E302-49B4-949B-B569AF858054
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\spaceinvaders\SpaceInvaders\bin\Debug\SpaceInvaders.exe

using System;

namespace SpaceInvaders
{
  internal class ProgramExecution
  {
    public const int WorldRows = 23;
    public const int WorldCols = 50;
    public const int MenuRows = 5;
    public const int MenuCols = 10;

    private static void Initialize(Engine engine)
    {
      int num1 = 2;
      int num2 = 2;
      int num3 = 40;
      int row = num1;
      for (int col = num2; col < num3; ++col)
      {
        AlienShip alienShip = new AlienShip(new MatrixPosition(row, col), new MatrixPosition(0, 1));
        HiveShip hiveShip = new HiveShip(new MatrixPosition(row + 1, col), new MatrixPosition(0, 1));
        engine.AddObject((GameObject) alienShip);
        engine.AddObject((GameObject) hiveShip);
      }
      PlayerShip playerShip = PlayerShip.Instance(new MatrixPosition(21, 25));
      engine.AddObject((GameObject) playerShip);
    }

    private static void BuildMenu(Engine engine)
    {
      Cursor cursor = new Cursor(new MatrixPosition(3, 51));
      engine.AddObject((GameObject) cursor);
      StartResume startResume = new StartResume(new MatrixPosition(3, 54));
      engine.AddObject((GameObject) startResume);
      Exit exit = new Exit(new MatrixPosition(5, 54));
      engine.AddObject((GameObject) exit);
      Score score = new Score(new MatrixPosition(21, 54), "Score:");
      engine.AddObject((GameObject) score);
      Lifes lifes = new Lifes(new MatrixPosition(19, 54), "Lifes:");
      engine.AddObject((GameObject) lifes);
    }

    private static void BuildWalls(Engine engine)
    {
      for (int col = 0; col < 50; ++col)
      {
        Wall wall1 = new Wall(new MatrixPosition(0, col));
        Wall wall2 = new Wall(new MatrixPosition(22, col));
        engine.AddObject((GameObject) wall1);
        engine.AddObject((GameObject) wall2);
      }
      for (int row = 1; row < 22; ++row)
      {
        Wall wall1 = new Wall(new MatrixPosition(row, 0));
        Wall wall2 = new Wall(new MatrixPosition(row, 49));
        engine.AddObject((GameObject) wall1);
        engine.AddObject((GameObject) wall2);
      }
    }

    private static void GameOver(Engine engine)
    {
      GameInformation gameInformation = new GameInformation(new MatrixPosition(17, 54), "Game Over:");
      engine.AddObject((GameObject) gameInformation);
    }

    private static void Main(string[] args)
    {
      IRenderer renderer = (IRenderer) new ConsoleRenderer(23, 70);
      IUserInterface userInterface = (IUserInterface) new KeyboardController();
      Engine gameEngine = new Engine(renderer, userInterface);
      ProgramExecution.BuildWalls(gameEngine);
      ProgramExecution.BuildMenu(gameEngine);
      ProgramExecution.Initialize(gameEngine);
      userInterface.OnLeftPressed += (EventHandler) ((sender, eventInfo) => gameEngine.MovePlayerShipLeft());
      userInterface.OnRightPressed += (EventHandler) ((sender, eventInfo) => gameEngine.MovePlayerShipRight());
      userInterface.OnActionPressed += (EventHandler) ((sender, eventInfo) => gameEngine.Shoot());
      userInterface.OnEscapePressed += (EventHandler) ((sender, eventInfo) =>
      {
        if (!gameEngine.isPaused)
        {
          gameEngine.isPaused = true;
          gameEngine.Pause();
        }
        else
        {
          gameEngine.isPaused = false;
          gameEngine.Run();
        }
      });
      userInterface.OnDownPressed += (EventHandler) ((sender, eventInfo) => gameEngine.MoveCursorDown());
      userInterface.OnUpPressed += (EventHandler) ((sender, eventInfo) => gameEngine.MoveCursorUp());
      userInterface.OnEnterPressed += (EventHandler) ((sender, eventInfo) => gameEngine.CursorAction());
      gameEngine.Pause();
    }
  }
}
