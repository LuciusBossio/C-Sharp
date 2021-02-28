using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//A 'Wheel of Fortune' style game with the 'Who Wants to be a Millionaire' logo because viruses
//Lucius Bossio

namespace COMP_60___Assignment_2
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        Player playerOne;
        Game gameOne;

        /// <summary>
        /// Creates the hidden word based on the length of the game winning word
        /// </summary>
        /// <param name="wordLength"></param>
        /// <returns></returns>
        public string GenerateHidden(int wordLength)
        {
            string wordHidden = new string('-', wordLength);
            return wordHidden;
        }

        //Initializes player and game objects to start game
        private void newGame_Click(object sender, EventArgs e)
        {
            if (playerOneName.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Enter your name before starting a new game.");
            }
            else
            {
                playerOne = new Player(playerOneName.Text);
                gameOne = new Game();

                playerOneScore.Text = 0 + "";

                displayTargetWord.Text = GenerateHidden(gameOne.gameWinningWord.Length);
                
                //Set current prize
                int randomNum;
                Random getRandom = new Random();
                randomNum = getRandom.Next() % Game.gameWords.Length;
                displayCurrentPrize.Text = Game.gamePrizes[randomNum] + "";
            }
        }

        //Evaluate and respond to user inputting guess
        private void playerOneGuess_KeyUp(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Return)       
            {
                //if entry (key) = return (key) then ignore input and initialize nuclear launch sequence
            }
            else
            {
                char[] targetWordArray = gameOne.gameWinningWord.ToCharArray();
                char[] hiddenWordArray = displayTargetWord.Text.ToCharArray();
                int ctr = 0;

                for (int index = 0; index < targetWordArray.Length; index++)
                {
                    if (char.Parse(playerOneGuess.Text) == targetWordArray[index])
                    {
                        hiddenWordArray[index] = char.Parse(playerOneGuess.Text);
                        ctr++;
                    }
                }

                if (new string(hiddenWordArray) == new string(targetWordArray))
                {
                    playerOne.playerScore += Int32.Parse(displayCurrentPrize.Text);
                    playerOneScore.Text = playerOne.playerScore + "";
                    MessageBox.Show("Congratulations! You guessed all the letters. \n\nYour final score is " + playerOne.playerScore + ".");
                    playerOneGuess.Text = "";
                    displayCurrentPrize.Text = "";
                }
                else if (ctr > 0)
                {
                    playerOne.playerScore += Int32.Parse(displayCurrentPrize.Text);
                    playerOneScore.Text = playerOne.playerScore + "";
                    MessageBox.Show("You guessed " + ctr + " letter(s) correctly!");
                    playerOneGuess.Text = "";
                    //Set new prize
                    int randomNum;
                    Random getRandom = new Random();
                    randomNum = getRandom.Next() % Game.gameWords.Length;
                    displayCurrentPrize.Text = Game.gamePrizes[randomNum] + "";
                }
                else
                {
                    MessageBox.Show("WRONG! Guess again.");
                    playerOneGuess.Text = "";
                    //Set new prize
                    int randomNum;
                    Random getRandom = new Random();
                    randomNum = getRandom.Next() % Game.gameWords.Length;
                    displayCurrentPrize.Text = Game.gamePrizes[randomNum] + "";
                }
                displayTargetWord.Text = new string(hiddenWordArray);
            }
        }
    }
}
