using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board();
            board.setUp(10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------- / SISTA PINNEN VINNER SPELET / ---------\n");
            Console.ResetColor();

            // Mänskliga (Användaren) spelare. //
            Player human = new HumanPlayer("Spelare");

            // Dator spelare. //
            Player computer = new ComputerPlayer("Dator");

            // Spel-loop. //
            while (board.getNoPins() > 0)
            {
                human.takePins(board);

                if( board.getNoPins() <= 0)
                {
                    break;
                }
                else
                {
                    computer.takePins(board);
                }
            }
            Console.WriteLine("Spelet är över!");
        }
    }
}
