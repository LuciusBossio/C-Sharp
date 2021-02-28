using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_60___Assignment_2
{
    //Class defines parameters of the wheel of fortune game
    //Lucius Bossio
    public class Game
    {
        public static string[] gameWords = new string[] { "diesel", "widow", "chocolate", "rockstar", "blueberry", "haze", "tuna", "skunk", "kush", "afghani" };
        public static int[] gamePrizes = new int[] { 100, 200, 300, 400, 500, 750, 1000, 1500, 2000, 2500 };
        public int gameRandomNum;
        public string gameWinningWord;

        public Game()
        {
            gameRandomNum = 0;
            SetGameWinningWord();
        }

        /// <summary>
        /// Sets random number used to get target word
        /// </summary>
        public void SetRandomNumber()
        {
            Random getRandom = new Random();
            gameRandomNum = getRandom.Next() % gameWords.Length;
        }

        /// <summary>
        /// Sets game winning word using a random number
        /// </summary>
        public void SetGameWinningWord()
        {
            SetRandomNumber();
            gameWinningWord = gameWords[gameRandomNum];
        }
    }
}
