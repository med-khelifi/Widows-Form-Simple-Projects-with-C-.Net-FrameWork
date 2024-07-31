using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8__CarGame
{
    public  class PlayerList
    {
         public string Name;
         public  int Score;

        static private List<PlayerList> Players = new List<PlayerList>();

        public PlayerList(string Name,int Score) {
            this.Name = Name;
            this.Score = Score;
        }

       public static void AddPlayer(PlayerList Player)
        {
            Players.Add(Player);
        }

        public static List<PlayerList> GetPlayerList() { 
            
            return Players;
        }

        public string GetName()
        {
            return Name; 
        }
        public string GetScore()
        {
            return Score.ToString();
        }
    }
}
