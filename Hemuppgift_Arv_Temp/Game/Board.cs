using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hemuppgift_Arv_Temp.Game
{
    //-------- Board-klass ---------//
    public class Board
    {
        //-------- Egenskap ---------//
        public int noPins {  get; set; }

        //-------- Metoder ---------//
        public void setUp(int pins) 
        {
            noPins = pins; // Använder argumentet för att ställa in antalet pinnar. //
        }

        public void takePins(int pins) 
        {
            noPins -= pins; // Minskar antalet pinnar baserat på spelarens val. //
            
            if (noPins < 0) noPins = 0; // Sätter antalet pinnar till noll så att det inte visar ett negativt tal vid spelets slut. //

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Det är nu {noPins} pinnar kvar.\n");
            Console.ResetColor();
        }

        public int getNoPins()
        {
            return noPins;
        }
    }
}
