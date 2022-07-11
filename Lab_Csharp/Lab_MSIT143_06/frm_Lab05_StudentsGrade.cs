using System;
using System.Collections;
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
    public partial class frm_Lab05_StudentsGrade : Form
    {
        public frm_Lab05_StudentsGrade()
        {
            InitializeComponent();
        }

        MyBase MB;
        ArrayList boxMB = new ArrayList();
        bool isNumCh, isNumEn, isNumMa;
        string result = "";

        private void btn_Save_Click(object sender, EventArgs e)
        {

            MB.name = txt_Name.Text;
            MB.chinese = int.Parse(txt_Cht.Text);
            MB.english = int.Parse(txt_Eng.Text);
            MB.math = int.Parse(txt_Math.Text);
            lab_Show.Text = "";
            boxMB.Add(MB);
            for (int i = 0; i < boxMB.Count; i++)
            {
                string na = ((MyBase)boxMB[i]).name;
                int ch = ((MyBase)boxMB[i]).chinese;
                int en = ((MyBase)boxMB[i]).english;
                int ma = ((MyBase)boxMB[i]).math;
                //Math.Round((double)totla/3,2)
                //if ()
                //{ 
                //max}

                lab_Show.Text += na + " " + ch + " " + en + " " + ma + "\n";
            }
            #region
            //if (string.IsNullOrEmpty(txt_Name.Text))
            //    MessageBox.Show("請輸入姓名!");
            //else if (string.IsNullOrEmpty(txt_Cht.Text))
            //    MessageBox.Show("請輸入國文成績!");
            //else if (string.IsNullOrEmpty(txt_Eng.Text))
            //    MessageBox.Show("請輸入英文成績!");
            //else if (string.IsNullOrEmpty(txt_Math.Text))
            //    MessageBox.Show("請輸入數學成績!");
            //else if (int.Parse(txt_Cht.Text) > 100)
            //    MessageBox.Show("請輸入正確的國文成績!");
            //else if (int.Parse(txt_Eng.Text) > 100)
            //    MessageBox.Show("請輸入正確的英文成績!");
            //else if (int.Parse(txt_Math.Text) > 100)
            //    MessageBox.Show("請輸入正確的數學成績!");
            //else
            //{
            //    Student student = new Student(txt_Name.Text, int.Parse(txt_Cht.Text), int.Parse(txt_Eng.Text), int.Parse(txt_Math.Text));
            //    result = $"學生姓名: {student.Name}\n國文成績: {student.Cht}\n英文成績: {student.Eng}\n數學成績: {student.Math}";
            //}
            #endregion
        }
        private void btn_Random_Click(object sender, EventArgs e)
        {

        }

        private void btn_Random20_Click(object sender, EventArgs e)
        {
            //for (i = 0 i++)
            //{
            //    MB.name = txt_Name.Text;
            //    MB.chinese = int.Parse(txt_Cht.Text);
            //    MB.english = int.Parse(txt_Eng.Text);
            //    MB.math = int.Parse(txt_Math.Text);
            //    boxMB.Add(MB);
            //}
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
