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
    public partial class frm_Lab08_MyClac : Form
    {
        public frm_Lab08_MyClac()
        {
            InitializeComponent();
        }

        double Num1, Num2 ,Answer;
        string btn = "", result = "";

        private void Result()
        {
            result = Answer.ToString();
            lab_Result.Text = $"{Num1}  {btn}  {Num2}  =\n{result}";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            btn = "+";
            if (string.IsNullOrEmpty(txt_Num1.Text))
                MessageBox.Show("請輸入Num1數值!");
            else if (string.IsNullOrEmpty(txt_Num2.Text))
                MessageBox.Show("請輸入Num2數值!");
            else
            {
                Num1 = Convert.ToDouble(txt_Num1.Text);
                Num2 = Convert.ToDouble(txt_Num2.Text);
                Answer = Num1 + Num2;
                Result();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            btn = " - ";
            if (string.IsNullOrEmpty(txt_Num1.Text))
                MessageBox.Show("請輸入Num1數值!");
            else if (string.IsNullOrEmpty(txt_Num2.Text))
                MessageBox.Show("請輸入Num2數值!");
            else
            {
                Num1 = Convert.ToDouble(txt_Num1.Text);
                Num2 = Convert.ToDouble(txt_Num2.Text);
                Answer = Num1 - Num2;
                Result();
            }
        }

        private void btn_multipliedBy_Click(object sender, EventArgs e)
        {
            btn = "×";
            if (string.IsNullOrEmpty(txt_Num1.Text))
                MessageBox.Show("請輸入Num1數值!");
            else if (string.IsNullOrEmpty(txt_Num2.Text))
                MessageBox.Show("請輸入Num2數值!");
            else
            {
                Num1 = Convert.ToDouble(txt_Num1.Text);
                Num2 = Convert.ToDouble(txt_Num2.Text);
                Answer = Num1 * Num2;
                Result();
            }
        }

        private void btn_DividedBy_Click(object sender, EventArgs e)
        {
            btn = "÷";
            if (string.IsNullOrEmpty(txt_Num1.Text))
                MessageBox.Show("請輸入Num1數值!");
            else if (string.IsNullOrEmpty(txt_Num2.Text))
                MessageBox.Show("請輸入Num2數值!");
            else
            {
                Num1 = Convert.ToDouble(txt_Num1.Text);
                Num2 = Convert.ToDouble(txt_Num2.Text);
                Answer = Num1 / Num2;
                Result();
            }
        }
        //private void btn_equals_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show($"{Num1} {btn} {Num2} = {result}");
        //    lab_Result.Text = $"{Num1} {btn} {Num2} = {result}";
        //}

        private void txt_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能數字鍵.負號.小數點
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
                e.Handled = true;
            //輸入負號時,只能最前面輸入,且只能輸入一次
            if (e.KeyChar == 45 && (((TextBox)sender).SelectionStart != 0 || ((TextBox)sender).Text.IndexOf("-") >= 0))
                e.Handled = true;
            //輸入小數點時,不能最前面輸入,且只能輸入一次
            if (e.KeyChar == 46 && (((TextBox)sender).SelectionStart == 0 || ((TextBox)sender).Text.IndexOf(".") >= 0))
                e.Handled = true;
        }
    }
}
