using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            while (true) 
            {
                Board board = new Board();
                board.setUp(10);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--------- \\ SISTA PINNEN VINNER SPELET / ----------\n");
                Console.ResetColor();

                Console.WriteLine(" ---------- \\ ENTER NAME below playa / -----------\n");
                Console.Write("                      ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                string player = Console.ReadLine();
                Console.ResetColor();

                Console.Write($"\n             Player: {player} >>> ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" || READY ||\n");
                Console.ResetColor();

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>|<<<<<<<<<<<<<<<<<<<<<<<\n");


                // Mänskliga (Användaren) spelare. //
                Player human = new HumanPlayer(player);

                // Dator spelare. //
                Player computer = new SmarterComputerPlayer("Dator");

                // Spel-loop. //
                while (board.getNoPins() > 0)
                {
                    human.takePins(board);

                    if (board.getNoPins() <= 0)
                    {
                        break;
                    }
                    else
                    {
                        computer.takePins(board);
                    }
                }
                Console.WriteLine("Spelet är över!");
                Console.WriteLine("Köra en nytt spel? j/n"); string svar = Console.ReadLine();

                if (svar == "n")
                {
                    break;
                }
                else 
                {
                    continue;
                }
            }

            
        }
    }
}
