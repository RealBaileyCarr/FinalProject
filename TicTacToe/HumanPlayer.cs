// HumanPlayer class: a Player whose moves come from console input.
public class HumanPlayer : Player
{
    public HumanPlayer(char mark) : base(mark) { }

    // Input validation: keeps asking until the player enters an open spot from 1 to 9.
    public override int ChooseSpot(Board board)
    {
        while (true)
        {
            Console.Write($"Player {Mark}, choose a spot (1-9): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int spot) && spot >= 1 && spot <= 9)
            {
                if (board.IsOpen(spot))
                    return spot;
                Console.WriteLine("That spot is already taken. Try another one.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
            }
        }
    }
}
