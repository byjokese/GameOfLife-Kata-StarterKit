namespace GameOfLife.Logic;

public class Board
{
    public int[,] State { get; private set; }
    public int Rows { get; }
    public int Columns { get; }

    public Board(int[,] initialState)
    {
        if (initialState == null)
        {
            throw new ArgumentNullException(nameof(initialState), "Value cannot be NULL");
        }
        if (!IsValid(initialState))
        {
            throw new ArgumentException("Invalid board state", nameof(initialState));
        }

        State = initialState;
        Rows = initialState.GetLength(0);
        Columns = initialState.GetLength(1);
    }

    /* -------------------------------------------------------------------------- */
    /*                             Reglas de Evolución                            */
    /* -------------------------------------------------------------------------- */
    /*
    *   1. Cualquier célula viva con menos de dos vecinas vivas muere, por "soledad".
    *   2. Cualquier célula viva con dos o tres vecinas vivas sigue viva en la siguiente generación.
    *   3. Cualquier célula viva con más de tres vecinas vivas muere, por "superpoblación".
    *   4. Cualquier célula muerta con exactamente tres vecinos vivos revive, por "repodrucción".
    */

    /// <summary>
    /// Evolves the board to the next generation.
    /// </summary>
    /// <returns></returns>
    public void Evolve()
    {
        // TODO: Implement the logic to evolve the Game of Life to the next generation.
    }

    /// <summary>
    /// Checks if the board is valid.
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    private bool IsValid(int[,] board)
    {
        if (board.GetLength(0) < 1 || board.GetLength(1) < 1)
        {
            return false;
        }
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int value = board[i, j];
                if (value < 0 || value > 1)
                {
                    return false;
                }
            }
        }

        return true;
    }

    /// <summary>
    /// Creates a Board with a random state.
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    public static Board Random(int rows = 5, int columns = 5)
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        int[,] state = new int[rows, columns];
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                state[i, j] = random.Next(0, 2);
            }
        }
        return new Board(state);
    }
}

public static class BoardExtensions
{
    public static void Print(this Board board)
    {
        int[,] state = board.State;
        for (int i = 0; i < board.Rows; i++)
        {
            for (int j = 0; j < board.Columns; j++)
            {
                if (state[i, j] == 0) Console.Write(" - ");
                else Console.Write(" * ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
