using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        //-------- Egenskap ---------//
        public int noPins {  get; set; }

        //-------- Metoder ---------//
        public void setUp(int pins) 
        {
            noPins = pins; // Använd argumentet för att ställa in antalet pinnar. //
        }

        public void takePins(int pins) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------- / SISTA PINNEN VINNER SPELET / ---------");
            Console.ResetColor();

            Console.WriteLine("\n| Spelare XXX | Välj hur många pinnar du vill ta? ");
            Console.Write("- Pinne/ar: "); pins = Convert.ToInt32(Console.ReadLine()); // Läser in spelarens val. //
            noPins -= pins; // Minskar antalet pinnar baserat på spelarens val.
            Console.WriteLine($"{noPins} pinnar kvar."); // Visar hur många pinnar som återstår. //
        }

        public int getNoPins()
        {
            return noPins;
        }
    }
}
