namespace SpaceInvaders
    class Program
        const int WorldRows = 23;
        const int RacketLength = 6;
        const int MenuCols = 10;
        {
            int startCol = 2;
            int alienStartRow = startRow;
            {
                {
                }
                {
                }
                engine.AddObject(alien);
            PlayerShip player = new PlayerShip(new MatrixPosition(WorldRows - 2, WorldCols / 2));
        }
        {
            engine.AddObject(cursor);
            engine.AddObject(startResume);
        }
        {
            {
                Wall wallBlockBottom = new Wall(new MatrixPosition(WorldRows - 1, col));
                engine.AddObject(wallBlockBottom);
            for (int row = 1; row < WorldRows - 1; row++)
                Wall wallBlockLeft = new Wall(new MatrixPosition(row, 0));
                engine.AddObject(wallBlockLeft);
            }
        static void Main(string[] args)
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols + 20);
            Engine gameEngine = new Engine(renderer, keyboard);
            BuildMenu(gameEngine);
            keyboard.OnLeftPressed += (sender, eventInfo) =>
                gameEngine.MovePlayerShipLeft();
            keyboard.OnRightPressed += (sender, eventInfo) =>
                gameEngine.MovePlayerShipRight();
            keyboard.OnActionPressed += (sender, eventInfo) =>
                gameEngine.Shoot();
            keyboard.OnEscapePressed += (sender, eventInfo) =>
                if (gameEngine.isPaused == false)
                    gameEngine.isPaused = true;
                    gameEngine.Pause();
                else
                    gameEngine.isPaused = false;
                    gameEngine.Run();
            };
            {
            };
            keyboard.OnUpPressed += (sender, eventInfo) =>
                gameEngine.MoveCursorUp();
            keyboard.OnEnterPressed += (sender, eventInfo) =>
                    gameEngine.CursorAction();
            gameEngine.Pause();
    }
static int CheckForFullLines()
    {
        int linesRemoved = 0;
        for (int row = 0; row < gameState.GetLength(0); row++)
        {
            bool isFullLine = true;
            for (int col = 0; col < gameState.GetLength(1); col++)
            {
                if (gameState[row, col] == false)
                {
                    isFullLine = false;
                    break;
                }
            }
            if (isFullLine)
            {
                for (int nextLine = row - 1; nextLine >= 0; nextLine--)
                {
                    if (row < 0)
                    {
                        continue;
                    }
                    for (int colFromNextLine = 0; colFromNextLine < gameState.GetLength(1); colFromNextLine++)
                    {
                        gameState[nextLine + 1, colFromNextLine] =
                            gameState[nextLine, colFromNextLine];
                    }
                }
                for (int colLastLine = 0; colLastLine < gameState.GetLength(1); colLastLine++)
                {
                    gameState[0, colLastLine] = false;
                }
                linesRemoved++;
            }
        }
        return linesRemoved;
    }
