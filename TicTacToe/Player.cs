// Player base class: stores a player's mark and defines how a move is chosen.
public abstract class Player
{
    // The mark this player uses on the board ('X' or 'O').
    public char Mark { get; }

    public Player(char mark)
    {
        Mark = mark;
    }

    // Each kind of player decides its own move (polymorphism).
    public abstract int ChooseSpot(Board board);
}
