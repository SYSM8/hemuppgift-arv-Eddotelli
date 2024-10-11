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

            board.takePins(0);
        }
    }
}
