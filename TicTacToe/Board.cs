// Board class: stores the 3x3 grid and handles moves, display, and win checks.
public class Board
{
    // Collection: array of 9 cells, each holds '1'-'9' until a player claims it.
    private char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    // Collection: every winning line, stored as cell indexes.
    private readonly int[][] winLines =
    {
        new[] {0,1,2}, new[] {3,4,5}, new[] {6,7,8},
        new[] {0,3,6}, new[] {1,4,7}, new[] {2,5,8},
        new[] {0,4,8}, new[] {2,4,6}
    };

    // Prints the current board to the console.
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($" {cells[0]} | {cells[1]} | {cells[2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {cells[3]} | {cells[4]} | {cells[5]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {cells[6]} | {cells[7]} | {cells[8]}");
        Console.WriteLine();
    }

    // Returns true if the spot (1-9) is still open.
    public bool IsOpen(int spot)
    {
        return cells[spot - 1] != 'X' && cells[spot - 1] != 'O';
    }

    // Places the player's mark on the board.
    public void PlaceMark(int spot, char mark)
    {
        cells[spot - 1] = mark;
    }

    // Returns true if the given mark has three in a row.
    public bool HasWinner(char mark)
    {
        foreach (int[] line in winLines)
        {
            if (cells[line[0]] == mark && cells[line[1]] == mark && cells[line[2]] == mark)
                return true;
        }
        return false;
    }

    // Returns true if every cell is taken.
    public bool IsFull()
    {
        foreach (char c in cells)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }
}
