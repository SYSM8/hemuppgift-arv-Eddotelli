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
            board.getNoPins();

            // Mänskliga (Användaren) spelare. //
            Player human = new HumanPlayer("Human Player");

            // Dator spelare. //
            Player computer = new ComputerPlayer("Computer Player");

        }
    }
}
