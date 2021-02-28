using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_60___Assignment_2
{
    //Class defines parameters of the players in the wheel of fortune game
    //Lucius Bossio
    class Player
    {
        public string playerName;
        public int playerScore;

        public Player(string initialPlayerName)
        {
            playerName = initialPlayerName;
            playerScore = 0;
        }
    }
}
