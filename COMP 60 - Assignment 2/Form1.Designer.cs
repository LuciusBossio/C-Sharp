namespace COMP_60___Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayTargetWord = new System.Windows.Forms.TextBox();
            this.playerOneGuess = new System.Windows.Forms.TextBox();
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerOneScore = new System.Windows.Forms.TextBox();
            this.newGame = new System.Windows.Forms.Button();
            this.lblCurrentPrize = new System.Windows.Forms.Label();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.lblTargetWord = new System.Windows.Forms.Label();
            this.displayCurrentPrize = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayTargetWord
            // 
            this.displayTargetWord.Location = new System.Drawing.Point(119, 288);
            this.displayTargetWord.Name = "displayTargetWord";
            this.displayTargetWord.ReadOnly = true;
            this.displayTargetWord.Size = new System.Drawing.Size(319, 31);
            this.displayTargetWord.TabIndex = 0;
            // 
            // playerOneGuess
            // 
            this.playerOneGuess.Location = new System.Drawing.Point(22, 569);
            this.playerOneGuess.Name = "playerOneGuess";
            this.playerOneGuess.Size = new System.Drawing.Size(137, 31);
            this.playerOneGuess.TabIndex = 1;
            this.playerOneGuess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playerOneGuess_KeyUp);
            // 
            // playerOneName
            // 
            this.playerOneName.Location = new System.Drawing.Point(19, 445);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(192, 31);
            this.playerOneName.TabIndex = 2;
            // 
            // playerOneScore
            // 
            this.playerOneScore.Location = new System.Drawing.Point(413, 570);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.ReadOnly = true;
            this.playerOneScore.Size = new System.Drawing.Size(132, 31);
            this.playerOneScore.TabIndex = 3;
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(234, 625);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(100, 74);
            this.newGame.TabIndex = 4;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // lblCurrentPrize
            // 
            this.lblCurrentPrize.AutoSize = true;
            this.lblCurrentPrize.Location = new System.Drawing.Point(408, 404);
            this.lblCurrentPrize.Name = "lblCurrentPrize";
            this.lblCurrentPrize.Size = new System.Drawing.Size(144, 25);
            this.lblCurrentPrize.TabIndex = 7;
            this.lblCurrentPrize.Text = "Current Prize:";
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Location = new System.Drawing.Point(20, 404);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(125, 25);
            this.lblPlayerOneName.TabIndex = 8;
            this.lblPlayerOneName.Text = "Player One:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guess:";
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(408, 528);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(121, 25);
            this.lblPlayerOneScore.TabIndex = 10;
            this.lblPlayerOneScore.Text = "Total Prize:";
            // 
            // lblTargetWord
            // 
            this.lblTargetWord.AutoSize = true;
            this.lblTargetWord.Location = new System.Drawing.Point(218, 237);
            this.lblTargetWord.Name = "lblTargetWord";
            this.lblTargetWord.Size = new System.Drawing.Size(131, 25);
            this.lblTargetWord.TabIndex = 11;
            this.lblTargetWord.Text = "Target Word";
            // 
            // displayCurrentPrize
            // 
            this.displayCurrentPrize.Location = new System.Drawing.Point(413, 444);
            this.displayCurrentPrize.Name = "displayCurrentPrize";
            this.displayCurrentPrize.ReadOnly = true;
            this.displayCurrentPrize.Size = new System.Drawing.Size(133, 31);
            this.displayCurrentPrize.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP_60___Assignment_2.Properties.Resources.WhoWantsToBeAMillionaire;
            this.pictureBox1.Location = new System.Drawing.Point(45, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayCurrentPrize);
            this.Controls.Add(this.lblTargetWord);
            this.Controls.Add(this.lblPlayerOneScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.lblCurrentPrize);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.playerOneName);
            this.Controls.Add(this.playerOneGuess);
            this.Controls.Add(this.displayTargetWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTargetWord;
        private System.Windows.Forms.TextBox playerOneGuess;
        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.TextBox playerOneScore;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label lblCurrentPrize;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Label lblTargetWord;
        private System.Windows.Forms.TextBox displayCurrentPrize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

