// Game setup: create the board, the two players, and the starting state before the loop.
Board board = new Board();
Player[] players = { new HumanPlayer('X'), new HumanPlayer('O') };
int currentIndex = 0;
bool gameOver = false;

Console.WriteLine("Welcome to Tic-Tac-Toe! Player X goes first.");

// Main game loop: runs until a win or a draw.
while (!gameOver)
{
    Player current = players[currentIndex];

    // Output: show the board, then get and apply the player's move.
    board.Display();
    int spot = current.ChooseSpot(board);
    board.PlaceMark(spot, current.Mark);

    // State update: check for a win or draw, otherwise switch turns.
    if (board.HasWinner(current.Mark))
    {
        board.Display();
        Console.WriteLine($"Player {current.Mark} wins!");
        gameOver = true;
    }
    else if (board.IsFull())
    {
        board.Display();
        Console.WriteLine("It's a draw!");
        gameOver = true;
    }
    else
    {
        currentIndex = 1 - currentIndex;
    }
}

Console.WriteLine("Thanks for playing!");
