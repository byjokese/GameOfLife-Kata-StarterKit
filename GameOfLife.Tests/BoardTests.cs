using GameOfLife.Logic;

namespace GameOfLife.Tests;
public class BoardTests
{
    [Fact]
    public void Test1()
    {
        int[,] initialState = new int[3, 3]
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
        };

        Board board = new Board(initialState);
    }
}