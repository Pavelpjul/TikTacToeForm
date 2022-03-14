using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TikTok
{
    public partial class TikTacToe : Form
    {
        public bool win = false;
        public int player = 0;
        public List<int> playerOneCases = new List<int>();
        public List<int> playerTwoCases = new List<int>();

        public TikTacToe()
        {
            InitializeComponent();
            txt_Player1.BackColor = Color.Green;
            txt_Winner.Hide();
        }
        private void TikTacToe_Load(object sender, EventArgs e)
        {
        }

        private void Turn()
        {
            if (player == 0)
            {
                player = 1;
                txt_Player1.BackColor = Color.Gray;
                txt_Player2.BackColor = Color.Red;
            }
            else
            {
                player = 0;
                txt_Player1.BackColor = Color.Green;
                txt_Player2.BackColor = Color.Gray;
            }
        }

        private void CheckWinner(List<int> playerList)
        {
            if (playerList.Contains(1) && playerList.Contains(2) && playerList.Contains(3)
                || playerList.Contains(1) && playerList.Contains(5) && playerList.Contains(9)
                || playerList.Contains(1) && playerList.Contains(4) && playerList.Contains(7)
                || playerList.Contains(2) && playerList.Contains(5) && playerList.Contains(8)
                || playerList.Contains(3) && playerList.Contains(6) && playerList.Contains(9)
                || playerList.Contains(3) && playerList.Contains(5) && playerList.Contains(7)
                || playerList.Contains(4) && playerList.Contains(5) && playerList.Contains(6)
                || playerList.Contains(7) && playerList.Contains(8) && playerList.Contains(9))
            {
                txt_Winner.Show();
                string winner = "One";
                txt_Winner.BackColor = Color.Green;
                if (player == 1)
                {
                    winner = "Two";
                    txt_Winner.BackColor = Color.Red;
                }
                txt_Winner.Text = $"Player {winner} have WON !!!";
                win = true;
            }     
            else if (playerOneCases.Count + playerTwoCases.Count == 9)
            {
                txt_Winner.Show();
                txt_Winner.BackColor = Color.Yellow;
                txt_Winner.Text = "Its a DRAW :(";
                win = true;
            }
        }
        
        private void Click(int number)
        {
            if (player == 0)
            {                
                playerOneCases.Add(number);
                CheckWinner(playerOneCases);
                Turn();
            } else
            {
                playerTwoCases.Add(number);
                CheckWinner(playerTwoCases);
                Turn();
            }
        }

        private void Button(Button btn, int number)
        {
            if (btn.Text =="" && win == false)
            {
                if (player == 0)
                {
                    btn.BackColor = Color.Green;
                    btn.Text = "X";
                }
                else
                {
                    btn.BackColor = Color.Red;
                    btn.Text = "O";
                }
                Click(number);
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button(button1,1);            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button(button2,2);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button(button3,3);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button(button4,4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button(button5,5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button(button6,6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button(button7,7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button(button8, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button(button9,9);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Winner.Hide();
            playerOneCases.Clear();
            playerTwoCases.Clear();
            
            button1.BackColor = Color.LightGray;
            button1.Text = "";

            button2.BackColor = Color.LightGray;
            button2.Text = "";

            button3.BackColor = Color.LightGray;
            button3.Text = "";

            button4.BackColor = Color.LightGray;
            button4.Text = "";

            button5.BackColor = Color.LightGray;
            button5.Text = "";

            button6.BackColor = Color.LightGray;
            button6.Text = "";

            button7.BackColor = Color.LightGray;
            button7.Text = "";

            button8.BackColor = Color.LightGray;
            button8.Text = "";

            button9.BackColor = Color.LightGray;
            button9.Text = "";

            player = 0;
            txt_Player1.BackColor = Color.Green;
            txt_Player2.BackColor = Color.Gray;
            win = false;
        }
    }
}
