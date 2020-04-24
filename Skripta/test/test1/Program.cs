class Program
{
    const int TetrisWidth = 10;
    const int TetrisHeight = 16;
    const int InfoPanelWidth = 10;
    const int GameWidth = TetrisWidth +
        InfoPanelWidth + 3;
    const int GameHeight = TetrisHeight + 2;
    const char BorderCharacter = (char)219;
    static int Score = 0;
    static int Level = 1; // Max level: 9
    #region Figures
    static bool[][,] Figures = new bool[8][,]
    {
        new bool[,] // ----
        {
            { true, true, true, true }
        },
        new bool[,] // I
        {
            { true },
            { true },
            { true },
            { true }
        },
        new bool[,] // J
        {
            { true, true, true },
            { false, false, true }
        },
        new bool[,] // L
        {
            { true, true, true },
            { true, false, false }
        },
        new bool[,] // O
        {
            { true, true },
            { true, true }
        },
        new bool[,] // S
        {
            { false, true, true },
            { true, true, false }
        },
        new bool[,] // T
        {
            { true, true, true },
            { false, true, false }
        },
        new bool[,] // Z
        {
            { true, true, false },
            { false, true, true }
        },
    };
}
