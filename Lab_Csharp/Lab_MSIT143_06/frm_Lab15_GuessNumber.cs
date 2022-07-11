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
    public partial class frm_Lab15_GuessNumber : Form
    {
        public frm_Lab15_GuessNumber()
        {
            InitializeComponent();
        }

        int Ans;//int Num,Number //系統亂數產生要猜的數字
        int Guess;               //User猜的數字
        int Count = 0;           //猜的次數
        int Min = 1;             //猜數字範圍最小值
        int Max = 100;           //猜數字範圍最大值

        //限制只能輸入數字0-9
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_guess.Text))
                MessageBox.Show("請輸入1~100之間的數字!","錯誤",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frm_Lab15_GuessNumberStart GNS = (frm_Lab15_GuessNumberStart)this.Owner;
                GNS.lab_1to100.Text = $"Please Guess A Number Between {Min} to {Max} !";
                GNS.lab_TEXT.Text = string.Empty;
                Ans = GNS.Number;
                Guess = int.Parse(txt_guess.Text);

                if (Guess >= Min && Guess <= Max)
                {
                    Count++;
                    if (Guess == Ans)
                    {
                        GNS.lab_TEXT.Text = $"Bingo !!!!!  Count {Count} times.";
                        GNS.lab_1to100.Text = $"Please Guess A Number Between {Min} to {Max} !";
                        this.Close();
                    }
                    else if (Guess > Ans)
                    {
                        GNS.lab_TEXT.Text = "Too large  ↓↓↓↓↓";
                        GNS.lab_1to100.Text = $"Please Guess A Number Between {Min} to {Guess - 1} !";
                        Max = Guess - 1;
                        if (Min == Ans && Max == Ans)
                        {
                            GNS.lab_TEXT.Text = "Game over.";
                            this.Close();
                        }
                    }
                    else if (Guess < Ans)
                    {
                        GNS.lab_TEXT.Text = "Too small  ↑↑↑↑↑";
                        GNS.lab_1to100.Text = $"Please Guess A Number Between {Guess + 1} to {Max} !";
                        Min = Guess + 1;
                        if (Min == Ans && Max == Ans)
                        {
                            GNS.lab_TEXT.Text = "Game over.";
                            this.Close();
                        }
                    }
                }
                else
                    GNS.lab_TEXT.Text = "Out of range! Please try again.";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Lab15_GuessNumberStart GNS = (frm_Lab15_GuessNumberStart)this.Owner;
            GNS.lab_1to100.Text = "Please Guess A Number Between 1 to 100 !";
            GNS.lab_TEXT.Text = string.Empty;
            this.Close();

            //關閉所有窗體
            //Environment.Exit(Environment.ExitCode);
            //InitializeComponent();
        }
    }
}
