using System;

namespace SpaceInvaders
{
	// Token: 0x0200001C RID: 28
	internal class ProgramExecution
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00003D8C File Offset: 0x00001F8C
		private static void Initialize(Engine engine)
		{
			int startRow = 2;
			int startCol = 2;
			int endCol = 40;
			int alienStartRow = startRow;
			for (int i = startCol; i < endCol; i++)
			{
				AlienShip alien = new AlienShip(new MatrixPosition(alienStartRow, i), new MatrixPosition(0, 1));
				HiveShip hiveAlien = new HiveShip(new MatrixPosition(alienStartRow + 1, i), new MatrixPosition(0, 1));
				engine.AddObject(alien);
				engine.AddObject(hiveAlien);
			}
			PlayerShip player = PlayerShip.Instance(new MatrixPosition(21, 25));
			engine.AddObject(player);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003E14 File Offset: 0x00002014
		private static void BuildMenu(Engine engine)
		{
			Cursor cursor = new Cursor(new MatrixPosition(3, 51));
			engine.AddObject(cursor);
			StartResume startResume = new StartResume(new MatrixPosition(3, 54));
			engine.AddObject(startResume);
			Exit exit = new Exit(new MatrixPosition(5, 54));
			engine.AddObject(exit);
			Score score = new Score(new MatrixPosition(21, 54), "Score:");
			engine.AddObject(score);
			Lifes lifes = new Lifes(new MatrixPosition(19, 54), "Lifes:");
			engine.AddObject(lifes);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003EA0 File Offset: 0x000020A0
		private static void BuildWalls(Engine engine)
		{
			for (int col = 0; col < 50; col++)
			{
				Wall wallBlockTop = new Wall(new MatrixPosition(0, col));
				Wall wallBlockBottom = new Wall(new MatrixPosition(22, col));
				engine.AddObject(wallBlockTop);
				engine.AddObject(wallBlockBottom);
			}
			for (int row = 1; row < 22; row++)
			{
				Wall wallBlockLeft = new Wall(new MatrixPosition(row, 0));
				Wall wallBlockRight = new Wall(new MatrixPosition(row, 49));
				engine.AddObject(wallBlockLeft);
				engine.AddObject(wallBlockRight);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003F38 File Offset: 0x00002138
		private static void GameOver(Engine engine)
		{
			GameInformation gameOver = new GameInformation(new MatrixPosition(17, 54), "Game Over:");
			engine.AddObject(gameOver);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003F64 File Offset: 0x00002164
		private static void Main(string[] args)
		{
			IRenderer renderer = new ConsoleRenderer(23, 70);
			IUserInterface keyboard = new KeyboardController();
			Engine gameEngine = new Engine(renderer, keyboard);
			ProgramExecution.BuildWalls(gameEngine);
			ProgramExecution.BuildMenu(gameEngine);
			ProgramExecution.Initialize(gameEngine);
			keyboard.OnLeftPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.MovePlayerShipLeft();
			};
			keyboard.OnRightPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.MovePlayerShipRight();
			};
			keyboard.OnActionPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.Shoot();
			};
			keyboard.OnEscapePressed += delegate(object sender, EventArgs eventInfo)
			{
				bool flag = !gameEngine.isPaused;
				if (flag)
				{
					gameEngine.isPaused = true;
					gameEngine.Pause();
				}
				else
				{
					gameEngine.isPaused = false;
					gameEngine.Run();
				}
			};
			keyboard.OnDownPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.MoveCursorDown();
			};
			keyboard.OnUpPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.MoveCursorUp();
			};
			keyboard.OnEnterPressed += delegate(object sender, EventArgs eventInfo)
			{
				gameEngine.CursorAction();
			};
			gameEngine.Pause();
		}

		// Token: 0x0400002E RID: 46
		public const int WorldRows = 23;

		// Token: 0x0400002F RID: 47
		public const int WorldCols = 50;

		// Token: 0x04000030 RID: 48
		public const int MenuRows = 5;

		// Token: 0x04000031 RID: 49
		public const int MenuCols = 10;
	}
}
