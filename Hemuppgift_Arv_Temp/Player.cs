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

        //public abstract TakePins : Board
    }
}
