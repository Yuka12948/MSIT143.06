using Lab_MSIT143_06;
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
    public partial class frm_Lab02_Loan : Form
    {
        public frm_Lab02_Loan()
        {
            InitializeComponent();
        }

        uint 貸款金額, 貸款期數, 頭期款;
        double 月利率, X, Y, PMT, 總付款;

        public double 月付款()
        {
            貸款金額 = uint.Parse(txt_01.Text);
            貸款期數 = uint.Parse(txt_02.Text) * 12;
            月利率 = double.Parse(txt_03.Text) / 100 / 12;
            頭期款 = uint.Parse(txt_04.Text);

            X = (貸款金額 - 頭期款) * 月利率 * Math.Pow((1 + 月利率), 貸款期數);
            Y = Math.Pow((1 + 月利率), 貸款期數) - 1;
            PMT = X / Y;
            return PMT;
        }

        public void btn_01_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_01.Text))
                MessageBox.Show("請輸入貸款金額!");
            else if (string.IsNullOrEmpty(txt_02.Text))
                MessageBox.Show("請輸入貸款年期!");
            else if (string.IsNullOrEmpty(txt_03.Text))
                MessageBox.Show("請輸入年利率!");
            else if (string.IsNullOrEmpty(txt_04.Text))
                MessageBox.Show("請輸入頭期款金額! 若無頭期款請輸入0 ");
            else
                MessageBox.Show("PMT月付為 " + Math.Floor(月付款()) + " 元");
        }

        public void btn_02_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_01.Text))
                MessageBox.Show("請輸入貸款金額!");
            else if (string.IsNullOrEmpty(txt_02.Text))
                MessageBox.Show("請輸入貸款年期!");
            else if (string.IsNullOrEmpty(txt_03.Text))
                MessageBox.Show("請輸入年利率!");
            else if (string.IsNullOrEmpty(txt_04.Text))
                MessageBox.Show("請輸入頭期款金額! 若無頭期款請輸入0 ");
            else
            {
                總付款 = 月付款() * 貸款期數;
                MessageBox.Show("總付款為 " + Math.Floor(總付款) + " 元");
            }
        }

        public void btn_03_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_01.Text))
                MessageBox.Show("請輸入貸款金額!");
            else if (string.IsNullOrEmpty(txt_02.Text))
                MessageBox.Show("請輸入貸款年期!");
            else if (string.IsNullOrEmpty(txt_03.Text))
                MessageBox.Show("請輸入年利率!");
            else if (string.IsNullOrEmpty(txt_04.Text))
                MessageBox.Show("請輸入頭期款金額! 若無頭期款請輸入0 ");
            else
            {
                //呼叫frm_Loan_Report表單
                frm_Lab02_Loan_Report report = new frm_Lab02_Loan_Report();
                report.label1.Text = uint.Parse(txt_01.Text) + " 元";
                report.label2.Text = uint.Parse(txt_02.Text) + " 年";
                report.label3.Text = double.Parse(txt_03.Text) + " %";
                report.label4.Text = Math.Floor(月付款()) + " 元";
                report.label5.Text = Math.Floor(總付款) + " 元";
                report.Show();
            }
        }

        private void txt_01_MouseMove(object sender, MouseEventArgs e)
        {
            lab_001.Text = "請輸入貸款金額";
            lab_001.ForeColor = Color.LightGray;
        }

        private void txt_01_MouseLeave(object sender, EventArgs e)
        {
            lab_001.Text = "";
        }

        private void txt_02_MouseMove(object sender, MouseEventArgs e)
        {
            lab_002.Text = "請輸入貸款年期";
            lab_002.ForeColor = Color.LightGray;
        }

        private void txt_02_MouseLeave(object sender, EventArgs e)
        {
            lab_002.Text = "";
        }

        private void txt_03_MouseMove(object sender, MouseEventArgs e)
        {
            lab_003.Text = "請輸入年利率";
            lab_003.ForeColor = Color.LightGray;
        }

        private void txt_03_MouseLeave(object sender, EventArgs e)
        {
            lab_003.Text = "";
        }

        private void txt_04_MouseMove(object sender, MouseEventArgs e)
        {
            lab_004.Text = "請輸入頭期款";
            lab_004.ForeColor = Color.LightGray;
        }

        private void txt_04_MouseLeave(object sender, EventArgs e)
        {
            lab_004.Text = "";
        }

        private void txt_01_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能數字鍵.退格鍵
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            e.Handled = true;
        }

        private void txt_03_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //只能數字鍵.退格鍵.小數點
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8  && e.KeyChar != 46)
                e.Handled = true;
            //輸入小數點時,不能最前面輸入,且只能輸入一次
            if (e.KeyChar == 46 && (((TextBox)sender).SelectionStart == 0 || ((TextBox)sender).Text.IndexOf(".") >= 0))
                e.Handled = true;
        }
    }
}