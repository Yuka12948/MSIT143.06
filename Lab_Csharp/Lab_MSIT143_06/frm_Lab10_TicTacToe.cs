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
    public partial class frm_Lab10_TicTacToe : Form
    {

        public frm_Lab10_TicTacToe()
        {
            InitializeComponent();
        }

        bool OXturn = true; //true = 沒變 false = 有變
        int turnCount = 0;

        private void TSBtn_restart_Click(object sender, EventArgs e)
        {
            OXturn = true;
            turnCount = 0;

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

        private void TSBtn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (OXturn)
                b.Text = "X";
            else
                b.Text = "O";

            OXturn = !OXturn;
            b.Enabled = false;

            turnCount++;
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool IsWinner = false;

            if ((Btn_A1.Text == Btn_A2.Text) && (Btn_A2.Text == Btn_A3.Text) && (!Btn_A1.Enabled))
                IsWinner = true;
            else if ((Btn_B1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_B3.Text) && (!Btn_B1.Enabled))
                IsWinner = true;
            else if ((Btn_C1.Text == Btn_C2.Text) && (Btn_C2.Text == Btn_C3.Text) && (!Btn_C1.Enabled))
                IsWinner = true;
            else if ((Btn_A1.Text == Btn_B1.Text) && (Btn_B1.Text == Btn_C1.Text) && (!Btn_A1.Enabled))
                IsWinner = true;
            else if ((Btn_A2.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C2.Text) && (!Btn_A2.Enabled))
                IsWinner = true;
            else if ((Btn_A3.Text == Btn_B3.Text) && (Btn_B3.Text == Btn_C3.Text) && (!Btn_A3.Enabled))
                IsWinner = true;
            else if ((Btn_A1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C3.Text) && (!Btn_A1.Enabled))
                IsWinner = true;
            else if ((Btn_A3.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C1.Text) && (!Btn_C1.Enabled))
                IsWinner = true;

            if(IsWinner)
            {
                disableBtns();

                string winner = "";
                if (OXturn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show($"{winner} Wins!!!", "Congratulations!");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show($"Draw!!!", "What a pity!");
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
            }
            catch { }
        }

        #region
        // 參考 https://www.youtube.com/watch?v=p3gYVcggQOU&t=632s
        #endregion

    }
}
