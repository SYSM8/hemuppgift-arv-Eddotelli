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
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n!! --- FEL INMATNING --- !!");
                    Console.ResetColor();

                    Console.WriteLine(" - Var god ange ett giltigt heltal mellan 1-3.\n");
                }
            }
           
            board.takePins(pins); // Minskar antal pinnar med rundans drag från spelaren. //

            Console.WriteLine("------------\n");
        }
    }


        //-------- HumanPlayer ---------//
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

            board.takePins(pins);

            Console.WriteLine("--------------------------------------------------------------------------------------------\n");
        }
    }   
}
