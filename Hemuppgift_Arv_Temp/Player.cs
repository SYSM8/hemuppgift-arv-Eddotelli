using Hemuppgift_Arv_Temp.Game;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{userID}, din tur!");
            Console.ResetColor();
            board.takePins(0);
        }
    }


        //-------- HumanPlayer ---------//
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string computer) : base(computer) { }

        public override void takePins(Board board)
        {
            Random slump = new Random();
            int pins = slump.Next(1,2); // Slumpval för datorn. //

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{userID}, din tur!");
            Console.ResetColor();

            board.takePins(pins);
        }
    }
    
}
