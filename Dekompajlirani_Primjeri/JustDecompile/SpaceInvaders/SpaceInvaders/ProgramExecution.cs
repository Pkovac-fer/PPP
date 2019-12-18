using System;
using System.Runtime.CompilerServices;

namespace SpaceInvaders
{
	internal class ProgramExecution
	{
		public const int WorldRows = 23;

		public const int WorldCols = 50;

		public const int MenuRows = 5;

		public const int MenuCols = 10;

		public ProgramExecution()
		{
		}

		private static void BuildMenu(Engine engine)
		{
			engine.AddObject(new Cursor(new MatrixPosition(3, 51)));
			engine.AddObject(new StartResume(new MatrixPosition(3, 54)));
			engine.AddObject(new Exit(new MatrixPosition(5, 54)));
			engine.AddObject(new Score(new MatrixPosition(21, 54), "Score:"));
			engine.AddObject(new Lifes(new MatrixPosition(19, 54), "Lifes:"));
		}

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

		private static void GameOver(Engine engine)
		{
			engine.AddObject(new GameInformation(new MatrixPosition(17, 54), "Game Over:"));
		}

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
			engine.AddObject(PlayerShip.Instance(new MatrixPosition(21, 25)));
		}

		private static void Main(string[] args)
		{
			IRenderer renderer = new ConsoleRenderer(23, 70);
			IUserInterface keyboard = new KeyboardController();
			Engine engine = new Engine(renderer, keyboard);
			ProgramExecution.BuildWalls(engine);
			ProgramExecution.BuildMenu(engine);
			ProgramExecution.Initialize(engine);
			keyboard.OnLeftPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.MovePlayerShipLeft());
			keyboard.OnRightPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.MovePlayerShipRight());
			keyboard.OnActionPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.Shoot());
			keyboard.OnEscapePressed += new EventHandler((object sender, EventArgs eventInfo) => {
				if (engine.isPaused)
				{
					engine.isPaused = false;
					engine.Run();
				}
				else
				{
					engine.isPaused = true;
					engine.Pause();
				}
			});
			keyboard.OnDownPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.MoveCursorDown());
			keyboard.OnUpPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.MoveCursorUp());
			keyboard.OnEnterPressed += new EventHandler((object sender, EventArgs eventInfo) => engine.CursorAction());
			engine.Pause();
		}
	}
}