using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Gamae.Properties;

namespace Tic_Tac_Toe_Gamae
{
    public partial class Tic_Tac_Toe_Game: Form
    {
        public Tic_Tac_Toe_Game()
        {
            InitializeComponent();
        }

        private void Tic_Tac_Toe_Game_Paint(object sender, PaintEventArgs e)
        {
            
            Color white = Color.FromArgb(255, 255, 255, 255);

            Pen whitePen = new Pen(white);
            whitePen.Width = 15;

            
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }

        public enum enPlayturn
        {
            Player1,
            Player2
        }
        enPlayturn Player = enPlayturn.Player1;

        public enum enWinner
        {
            Player1,
            Player2,
            Draw,
            InProgress
        }
        enWinner Winner = enWinner.InProgress;

        struct stGameInfo
        {
            public enWinner Win;
            public short PlayeCount;
        }
        stGameInfo GameInfo;



        public void GameEnd()
        {
            lblWinner.Text = GameInfo.Win.ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;




        }

        public bool checkValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
            {
                if (btn3.Tag.ToString() == "O")
                {
                    GameInfo.Win = enWinner.Player2;
                    btn1.BackColor = Color.Yellow;
                    btn2.BackColor = Color.Yellow;
                    btn3.BackColor = Color.Yellow;
                    GameEnd();

                }
                else
                {
                    GameInfo.Win = enWinner.Player1;
                    btn1.BackColor = Color.Yellow;
                    btn2.BackColor = Color.Yellow;
                    btn3.BackColor = Color.Yellow;
                    GameEnd();
                }

                return true;
            }

            return false;
        }


        public void CheckWinner()
        {

            if (checkValue(button1, button2, button3))
            {

                return;
            }
            if (checkValue(button4, button5, button6))
            {
                return;
            }
            if (checkValue(button7, button8, button9))
            {
                return;
            }
            if (checkValue(button1, button4, button7))
            {
                return;
            }
            if (checkValue(button2, button5, button8))
            {
                return;
            }
            if (checkValue(button3, button6, button9))
            {
                return;
            }
            if (checkValue(button1, button5, button9))
            {
                return;
            }
            if (checkValue(button3, button5, button7))
            {
                return;
            }

        }

        public void ChangImage(Object sender)
        {

            if (((Button)sender).Tag == "?")
            {
                GameInfo.PlayeCount++;

                if (Player == enPlayturn.Player1)
                {
                    ((Button)sender).Image = Resources.X;
                    ((Button)sender).Tag = "X";
                    CheckWinner();
                    Player = enPlayturn.Player2;
                    lblTurn.Text = Player.ToString();

                }
                else
                {
                    ((Button)sender).Image = Resources.O;
                    ((Button)sender).Tag = "O";
                    CheckWinner();
                    Player = enPlayturn.Player1;
                    lblTurn.Text = Player.ToString();
                }
            }
            else
            {
                MessageBox.Show("Wronge choise !", "wronge", MessageBoxButtons.OK);
            }
            if (GameInfo.PlayeCount == 9)
            {
                GameInfo.Win = enWinner.Draw;
                GameEnd();
            }
        }

        private void allBottun_Click(object sender, EventArgs e)
        {

            if (GameInfo.PlayeCount != 9)
            {
                ChangImage(sender);
            }
            else
            {
                GameInfo.Win = enWinner.InProgress;
                GameEnd();
            }
        }

        public void ResetButton(Button btn)
        {
            btn.Enabled = true;
            btn.Tag = "?";
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);


            Player = enPlayturn.Player1;
            lblTurn.Text = enPlayturn.Player1.ToString();
            lblWinner.Text = enWinner.InProgress.ToString();
            GameInfo.PlayeCount = 0;

        }
    }
}
