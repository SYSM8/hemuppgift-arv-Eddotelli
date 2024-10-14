using Hemuppgift_Arv_Temp.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    //-------- Basklass ---------//
    public abstract class Player
    {
        //-------- Egenskap ---------//
        public string userID { get; set; }

        //-------- Konstruktor ---------//
        public Player(string name)
        {
            userID = name;
        }

        public string getUserId()
        {
            return userID;
        }

        public abstract void takePins(Board board);
    }

    //----------------------------------------- KLASSER -----------------------------------------//

    //-------- HumanPlayer ---------//
    public class HumanPlayer : Player
    {
        public HumanPlayer(string human) : base(human) { }

        public override void takePins(Board board)
        {
            int pins = 0;

            // Loopar enbart igenom om inmatningen är fel från användaren.
            while (true) 
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{userID}, din tur!");
                    Console.ResetColor();

                    Console.Write(" - ");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{board.getNoPins()} pinne/ar kvar.\n"); // Visar hur många pinnar som återstår. //
                    Console.ResetColor();

                    Console.Write("Hur många pinnar vill du ta? (1-3)? ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    pins = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    // Om inmatningen är mindre eller lika med noll och högre än 3, skickar ett felmeddelande. //
                    if (pins <= 0 || pins > 3) 
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                // Fångar upp inmatning som är allt annat än en siffra, skriver även ut ett felmeddelande. //
                catch ( FormatException )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n!! --- FEL INMATNING --- !!");
                    Console.ResetColor();

                    Console.WriteLine(" - Var god ange ett giltigt heltal mellan 1-3.\n");
                }
                // Fångar upp inmatning som är under eller lika med noll och över tre, skriver även ut ett felmeddelande. //
                catch ( ArgumentOutOfRangeException x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n!! --- FEL INMATNING --- !!");
                    Console.ResetColor();

                    Console.WriteLine(" - Var god ange ett giltigt heltal mellan 1-3.\n");
                }
            }
           
            board.takePins(pins); // Minskar antal pinnar med rundans drag från spelaren. //

            // Ifall användaren når tar sista pinnen, skrivs ett meddelande om hen vann. //
            if (board.getNoPins() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{userID} vinner spelet, tog den sista pinnen!");
                Console.ResetColor();
            }

            Console.WriteLine("------------\n");
        }
    }


        //-------- ComputerPlayer ---------//
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string computer) : base(computer) { }

        public override void takePins(Board board)
        {
            Random slump = new Random();
            int pins = slump.Next(1,4); // Slumpval för datorn. //

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{userID}'s tur, den tar {pins} pinne/ar!");
            Console.ResetColor();

            Console.Write(" - ");

            board.takePins(pins); // Minskar antal pinnar med rundans drag från datorn. //

            // Ifall datorn når tar sista pinnen, skrivs ett meddelande om den vann. //
            if (board.getNoPins() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{userID} vinner därmed spelet, tog den sista pinnen!");
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------\n");
        }
    }

    public class SmarterComputerPlayer : Player
    {
        public SmarterComputerPlayer(string sComputer) : base(sComputer) { }

        public override void takePins(Board board)
        {
            int pins;
            int remainder = board.getNoPins() % 4;

            if (remainder == 0) 
            {
                pins = new Random().Next(1,4); // Slumpval för datorn. //
            }
            else
            {
                pins = remainder; // Tar ett antal pinnar som lämnar en multipel av 4. //
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{userID}'s tur, den tar {pins} pinne/ar!");
            Console.ResetColor();

            Console.Write(" - ");

            board.takePins(pins); // Minskar antal pinnar med rundans drag från datorn. //

            // Ifall datorn når tar sista pinnen, skrivs ett meddelande om den vann. //
            if (board.getNoPins() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{userID} vinner därmed spelet, tog den sista pinnen!");
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------\n");


        }
    }
}
