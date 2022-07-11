using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MSIT143_06
{
    public partial class frm_Lab01_HelloFrom : Form
    {
        public frm_Lab01_HelloFrom()
        {
            InitializeComponent();

            date_Picker.Value = DateTime.Today;
            //date_Picker.Format = DateTimePickerFormat.Long;
            //date_Picker.CustomFormat = "yyyy - MM - dd";
        }

        bool IsIDCorrect(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$"); //ID格式驗證
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (IsIDCorrect(txt_ID.Text))
                lab_IDCorrect.Text = "身分證格式正確";
            else
                lab_IDCorrect.Text = "身分證格式錯誤";
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string checkedRBName = "";

            if (rBtn_male.Checked)
                checkedRBName = " 先生";
            else if (rBtn_female.Checked)
                checkedRBName = " 小姐";

            string Name = txt_Name.Text;
            string ID = txt_ID.Text;
            string Brithday = date_Picker.Value.ToLongDateString();

            DialogResult check = MessageBox.Show($"hello, { Name}{checkedRBName}" +
                $"\n跟你確認以下資料 :\n\n-你的姓名為 {Name}\n-你的生日為 {Brithday}\n-身分證字號為 {ID}\n\n" +
                $"請問以上資料是否正確?", "資料確認", MessageBoxButtons.YesNo);

            if (check == DialogResult.Yes)
            {
                MessageBox.Show("基本資料已儲存完畢!");
                txt_Name.Clear();
                txt_ID.Clear();
                date_Picker.Value = DateTime.Today;
                rBtn_male.Checked = false;
                rBtn_female.Checked = false;
                lab_IDCorrect.Text = "";
            }
            else
            {
                MessageBox.Show("請重新輸入基本資料");
                txt_Name.Clear();
                txt_ID.Clear();
                date_Picker.Value = DateTime.Today;
                rBtn_male.Checked = false;
                rBtn_female.Checked = false;
                lab_IDCorrect.Text = "";
            }
        }

        private void btn_Enter_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Enter.ForeColor = Color.Black;
            btn_Enter.BackColor = Color.White;
        }

        private void btn_Enter_MouseLeave(object sender, EventArgs e)
        {
            btn_Enter.ForeColor = Color.White;
            btn_Enter.BackColor = Color.DimGray;
        }

        private void btn_JOKE_MouseMove(object sender, MouseEventArgs e)
        {
            btn_JOKE.ForeColor = Color.Black;
            btn_JOKE.BackColor = Color.Red;
        }

        private void btn_JOKE_MouseLeave(object sender, EventArgs e)
        {
            btn_JOKE.ForeColor = Color.White;
            btn_JOKE.BackColor = Color.DimGray;
        }
        private void btn_JOKE_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            MessageBox.Show($"Hey, {Name} 你這個笨蛋!\n都叫你不要按了!!!\n" +
                $"自己確認資料吧~\n\n✧(ಡωಡ)✧(ಡωಡ)✧(ಡωಡ)✧", "Just kidding");
        }
        #region
        //判斷輸入框有無文字 //若無Textbox顯示提醒字樣 //bug還沒除完
        //bool textboxHasText = false;
        private void txt_Name_Enter(object sender, EventArgs e)
        {
            //    if (textboxHasText == false)
            //        txt_Name.Text = "";
            //    txt_Name.ForeColor = Color.Black;
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            //    if (txt_Name.Text == "")
            //    {
            //        txt_Name.Text = "請輸入姓名";
            //        txt_Name.ForeColor = Color.LightGray;
            //        textboxHasText = false;
            //    }
            //    else
            //        textboxHasText = true;
        }

        private void txt_ID_Enter(object sender, EventArgs e)
        {
            //    if (textboxHasText == false)
            //        txt_ID.Text = "";
            //    txt_ID.ForeColor = Color.Black;
        }

        private void txt_ID_Leave(object sender, EventArgs e)
        {
            //    if (txt_ID.Text == "")
            //    {
            //        txt_ID.Text = "請輸入身分證字號";
            //        txt_ID.ForeColor = Color.LightGray;
            //        textboxHasText = false;
            //    }
            //    else
            //        textboxHasText = true;
        }
        #endregion
    }
}
