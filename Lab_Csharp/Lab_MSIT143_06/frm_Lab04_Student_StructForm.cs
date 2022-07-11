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
    public partial class frm_Lab04_Student_StructForm : Form
    {
        public frm_Lab04_Student_StructForm()
        {
            InitializeComponent();
        }

        string result = "";
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name.Text))
                MessageBox.Show("請輸入姓名!");
            else if (string.IsNullOrEmpty(txt_Cht.Text))
                MessageBox.Show("請輸入國文成績!");
            else if (string.IsNullOrEmpty(txt_Eng.Text))
                MessageBox.Show("請輸入英文成績!");
            else if (string.IsNullOrEmpty(txt_Math.Text))
                MessageBox.Show("請輸入數學成績!");
            else if (int.Parse(txt_Cht.Text) > 100)
                MessageBox.Show("請輸入正確的國文成績!");
            else if (int.Parse(txt_Eng.Text) > 100)
                MessageBox.Show("請輸入正確的英文成績!");
            else if (int.Parse(txt_Math.Text) > 100)
                MessageBox.Show("請輸入正確的數學成績!");
            else
            {
                Student student = new Student(txt_Name.Text, int.Parse(txt_Cht.Text), int.Parse(txt_Eng.Text), int.Parse(txt_Math.Text));
                result = $"學生姓名: {student.Name}\n國文成績: {student.Cht}分\n英文成績: {student.Eng}分\n數學成績: {student.Math}分";
            }
        }
        private void btn_Grade_Click(object sender, EventArgs e)
        {
            lab_GradeList.Text = result;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lab_GradeList.Text = "成績顯示";
            lab_ScoreEst.Text = "最高分/最低分科目";
            txt_Name.Clear();
            txt_Cht.Clear();
            txt_Eng.Clear();
            txt_Math.Clear();
        }

        private void btn_ScoreMaxMin_Click(object sender, EventArgs e)
        {
            Student student = new Student(txt_Name.Text, int.Parse(txt_Cht.Text), int.Parse(txt_Eng.Text), int.Parse(txt_Math.Text));
            int[] arr = new int[] { student.Cht, student.Eng, student.Math };
            int Max = 0, Min = 100;
            string temp1 = "", temp2 = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] == arr[1] && arr[1] == arr[2]) //三科同分
                    lab_ScoreEst.Text = $"三科成績皆為: {arr[0]}分";

                else if (arr[0] == arr[1] && arr[1] > arr[2]) //兩科同分
                    lab_ScoreEst.Text = $"最高科目成績為: 國文.英文 {arr[0]}分\n" +
                                        $"最低科目成績為: 數學 {arr[2]}分";
                else if (arr[0] == arr[1] && arr[1] < arr[2])
                    lab_ScoreEst.Text = $"最高科目成績為: 數學 {arr[2]}分\n" +
                                        $"最低科目成績為: 國文.英文 {arr[0]}分"; 
                else if (arr[0] > arr[1] && arr[1] == arr[2])
                    lab_ScoreEst.Text = $"最高科目成績為: 國文 {arr[0]}分\n" +
                                        $"最低科目成績為: 英文.數學 {arr[2]}分";
                else if (arr[0] < arr[1] && arr[1] == arr[2])
                    lab_ScoreEst.Text = $"最高科目成績為: 英文.數學 {arr[2]}分\n" +
                                        $"最低科目成績為: 國文 {arr[0]}分";
                else if (arr[0] == arr[2] && arr[2] > arr[1])
                    lab_ScoreEst.Text = $"最高科目成績為: 國文.數學 {arr[0]}分\n" +
                                        $"最低科目成績為: 英文 {arr[1]}分";
                else if (arr[0] == arr[2] && arr[2] < arr[1])
                    lab_ScoreEst.Text = $"最高科目成績為: 英文 {arr[1]}分\n" +
                                        $"最低科目成績為: 國文.數學 {arr[0]}分";

                else //無同分狀況
                {
                    if (Max < arr[i]) //最大值
                    {
                        Max = arr[i];

                        if (i == 0)
                            temp1 = "國文";
                        else if (i == 1)
                            temp1 = "英文";
                        else if (i == 2)
                            temp1 = "數學";
                    }

                    if (Min > arr[i]) //最小值
                    {
                        Min = arr[i];

                        if (i == 0)
                            temp2 = "國文";
                        else if (i == 1)
                            temp2 = "英文";
                        else if (i == 2)
                            temp2 = "數學";
                    }

                    lab_ScoreEst.Text = $"最高科目成績為: {temp1}{Max}分\n" +
                        $"最低科目成績為: {temp2}{Min}分";
                }
            }
        }

        // 國英數 TextBox 限制只能輸入數字鍵
        private void txt_Cht_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txt_Eng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txt_Math_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
