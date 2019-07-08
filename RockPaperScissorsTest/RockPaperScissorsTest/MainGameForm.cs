using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissorsTest
{
    public partial class MainGameForm : Form
    {
        int counter;
        public MainGameForm()
        {
            InitializeComponent();

            counter = 2;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if(cmbUser.SelectedItem == null)
            {
                MessageBox.Show("Choose your variant!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Width = 500;
                this.Height = 500;

                pnlUser.Visible = false;
                lblCounter.Visible = true;
                lblCounter.Text = counter.ToString();
                tmrCounter.Enabled = true;
            }
        }

        private void TmrCounter_Tick(object sender, EventArgs e)
        {
            if(counter == 1)
            {
                lblCounter.Text = "START";
                lblCounter.Left -= 80;
                counter--;
            }
            else if(counter == 0)
            {
                lblCounter.Visible = false;
                tmrCounter.Enabled = false;
                pnlAI.Visible = true;
                Result();
            }
            else
            {
                counter--;
                lblCounter.Text = counter.ToString();
            }
        }

        private void Result()
        {
            Random rnd = new Random();
            int AIChoose = rnd.Next(0, 3);

            if(AIChoose == 0)
            {
                txtAI.Text = "Rock";

                if(cmbUser.SelectedIndex == 0)
                {
                    lblResult.ForeColor = Color.Yellow;
                    lblResult.Text = "DRAW!";
                }
                else if (cmbUser.SelectedIndex == 1)
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "YOU WIN!";
                }
                else
                {
                    lblResult.ForeColor = Color.DarkRed;
                    lblResult.Text = "YOU LOSE!";
                }
            }
            else if(AIChoose == 1)
            {
                txtAI.Text = "Paper";

                if (cmbUser.SelectedIndex == 0)
                {
                    lblResult.ForeColor = Color.DarkRed;
                    lblResult.Text = "YOU LOSE!";
                }
                else if (cmbUser.SelectedIndex == 1)
                {
                    lblResult.ForeColor = Color.Yellow;
                    lblResult.Text = "DRAW!";
                }
                else
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "YOU WIN!";
                }
            }
            else
            {
                txtAI.Text = "Scissors";

                if (cmbUser.SelectedIndex == 0)
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "YOU WIN!";
                }
                else if (cmbUser.SelectedIndex == 1)
                {
                    lblResult.ForeColor = Color.DarkRed;
                    lblResult.Text = "YOU LOSE!";
                }
                else
                {
                    lblResult.ForeColor = Color.Yellow;
                    lblResult.Text = "DRAW!";
                }
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            MainGameForm form = new MainGameForm();
            form.Show();
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
