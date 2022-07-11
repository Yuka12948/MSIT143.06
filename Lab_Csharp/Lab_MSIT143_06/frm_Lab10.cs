using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MSIT143_06
{
    public partial class frm_Lab10 : Form
    {
        bool turn = true;
        int count = 0;

        public frm_Lab10()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            count++;

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool win = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                win = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                win = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                win = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                win = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                win = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                win = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                win = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                win = true;

            if (win)
            {
                disableBtns();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show($"{winner} Wins!!!");
            }
            else
            {
                if(count == 9)
                    MessageBox.Show($"Draw!!!");
            }
        }

        private void disableBtns()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//
        {
            turn = true;
            count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//
        {
            this.Close(); //Application.Exit();
        }

        private void nEWToolStripMenuItem_Click_1(object sender, EventArgs e)////
        {
            turn = true;
            count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void eIXTToolStripMenuItem_Click(object sender, EventArgs e)////
        {
            this.Close(); //Application.Exit();
        }
    }
}
