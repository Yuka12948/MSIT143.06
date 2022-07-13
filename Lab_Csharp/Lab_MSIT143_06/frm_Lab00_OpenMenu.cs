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
    public partial class frm_Lab00_OpenMenu : Form
    {
        public frm_Lab00_OpenMenu()
        {
            InitializeComponent();
        }
        
        private void btn_Lab01_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear(); 
            frm_Lab01_HelloFrom Lab01 = new frm_Lab01_HelloFrom();
            Lab01.TopLevel = false;
            Lab01.FormBorderStyle = FormBorderStyle.None;
            Lab01.Top = 20;
            Lab01.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab01);
            Lab01.Show();
        }

        private void btn_Lab02_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab02_Loan Lab02 = new frm_Lab02_Loan();
            Lab02.TopLevel = false;
            Lab02.FormBorderStyle = FormBorderStyle.None;
            Lab02.Top = 20;
            Lab02.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab02);
            Lab02.Show();
        }

        private void btn_Lab03_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab03_MenuOrder Lab03 = new frm_Lab03_MenuOrder();
            Lab03.TopLevel = false;
            Lab03.FormBorderStyle = FormBorderStyle.None;
            Lab03.Top = 20;
            Lab03.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab03);
            Lab03.Show();
        }

        private void btn_Lab04_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab04_Student_StructForm Lab04 = new frm_Lab04_Student_StructForm();
            Lab04.TopLevel = false;
            Lab04.FormBorderStyle = FormBorderStyle.None;
            Lab04.Top = 20;
            Lab04.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab04);
            Lab04.Show();
        }

        private void btn_Lab05_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear();
            //frm_Lab05_StudentsGrade Lab05 = new frm_Lab05_StudentsGrade();
            //Lab05.TopLevel = false;
            //Lab05.FormBorderStyle = FormBorderStyle.None;
            //Lab05.Top = 20;
            //Lab05.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab05);
            //Lab05.Show();
        }

        private void btn_Lab06_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear();
            //frm_Lab06_StudentsGradeList Lab06 = new frm_Lab06_StudentsGradeList();
            //Lab06.TopLevel = false;
            //Lab06.FormBorderStyle = FormBorderStyle.None;
            //Lab06.Top = 20;
            //Lab06.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab06);
            //Lab06.Show();
        }

        private void btn_Lab07_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear();
            //frm_Lab07_Method Lab07 = new frm_Lab07_Method();
            //Lab07.TopLevel = false;
            //Lab07.FormBorderStyle = FormBorderStyle.None;
            //Lab07.Top = 20;
            //Lab07.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab07);
            //Lab07.Show();
        }

        private void btn_Lab08_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab08_MyClac Lab08 = new frm_Lab08_MyClac();
            Lab08.TopLevel = false;
            Lab08.FormBorderStyle = FormBorderStyle.None;
            Lab08.Top = 20;
            Lab08.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab08);
            Lab08.Show();
        }

        private void btn_Lab09_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear(); 
            //frm_Lab09_ForDoWhile Lab09 = new frm_Lab09_ForDoWhile();
            //Lab09.TopLevel = false;
            //Lab09.FormBorderStyle = FormBorderStyle.None;
            //Lab09.Top = 20;
            //Lab09.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab09);
            //Lab09.Show();
        }

        private void btn_Lab10_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab10_TicTacToe Lab10 = new frm_Lab10_TicTacToe();
            Lab10.TopLevel = false;
            Lab10.FormBorderStyle = FormBorderStyle.None;
            Lab10.Top = 20;
            Lab10.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab10);
            Lab10.Show();
        }

        private void btn_Lab11_Click(object sender, EventArgs e)
        {
            //Lab11_螢幕保護程式
        }

        private void btn_Lab12_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab12_Notepad Lab12 = new frm_Lab12_Notepad();
            Lab12.TopLevel = false;
            Lab12.FormBorderStyle = FormBorderStyle.None;
            Lab12.Top = 20;
            Lab12.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab12);
            Lab12.Show();
        }

        private void btn_Lab13_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear(); 
            //frm_Lab13_Paint Lab13 = new frm_Lab13_Paint();
            //Lab13.TopLevel = false;
            //Lab13.FormBorderStyle = FormBorderStyle.None;
            //Lab13.Top = 20;
            //Lab13.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab13);
            //Lab13.Show();
        }

        private void btn_Lab14_Click(object sender, EventArgs e)
        {
            //splitContainer.Panel2.Controls.Clear(); 
            //frm_Lab14_PictureViewer Lab14 = new frm_Lab14_PictureViewer();
            //Lab14.TopLevel = false;
            //Lab14.FormBorderStyle = FormBorderStyle.None;
            //Lab14.Top = 20;
            //Lab14.Left = 20;
            //splitContainer.Panel2.Controls.Add(Lab14);
            //Lab14.Show();
        }

        private void btn_Lab15_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab15_GuessNumberStart Lab15 = new frm_Lab15_GuessNumberStart();
            Lab15.TopLevel = false;
            Lab15.FormBorderStyle = FormBorderStyle.None;
            Lab15.Top = 20;
            Lab15.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab15);
            Lab15.Show();
        }

        private void btn_Lab16_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls.Clear();
            frm_Lab16_Alarm Lab16 = new frm_Lab16_Alarm();
            Lab16.TopLevel = false;
            Lab16.FormBorderStyle = FormBorderStyle.None;
            Lab16.Top = 20;
            Lab16.Left = 20;
            splitContainer.Panel2.Controls.Add(Lab16);
            Lab16.Show();
        }
        #region
        //參考 https://www.cnblogs.com/nsky/p/3330296.html

        /* splitContainer Panel
        
        splitContainer.Panel2.Controls.Clear(); //清除Panel2原有控件 
        frm_Lab01 L = new frm_Lab01();
        L.TopLevel = false; //子窗體不能是頂級窗體
        L.Top = 0; //頂部距離
        L.Dock = DockStyle.Fill; //子視窗(Frm)充滿父容器(Panel)
        L.FormBorderStyle = FormBorderStyle.None; //不顯示邊框(表單無法放大縮小關閉)
        splitContainer1.Panel2.Controls.Add(L); //在Panel2增加A控件
        L.Show();
        */
        #endregion
    }
}
