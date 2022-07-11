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
    public partial class frm_Lab02_Loan_Report : Form
    {
        public frm_Lab02_Loan_Report()
        {
            InitializeComponent();
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
                MessageBox.Show("請輸入Email");
            else
                MessageBox.Show("你的收據已寄出!");
        }

        private void txt_Email_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Email.Clear();
            txt_Email.ForeColor = Color.Black;
        }
    }
}
