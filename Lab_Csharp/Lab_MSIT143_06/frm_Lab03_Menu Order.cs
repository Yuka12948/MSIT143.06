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
    public partial class frm_Lab03_MenuOrder : Form
    {
        public frm_Lab03_MenuOrder()
        {
            InitializeComponent();
        }

        public int BeerC, SakeC, LiquorC, WineC, Total; //C = Count
        public int Beer = 120, Sake = 500, Liquor = 320, Wine = 320;
        int BeerT, SakeT, LiquorT, WineT; //T = Total
        string BeerS, SakeS, LiquorS, WineS; //S = Show

        private void btn_Beer_Click(object sender, EventArgs e)
        {
            BeerC += 1;
            BeerT = Beer * BeerC;

            if (BeerC > 0)
                BeerS = $"{BeerC}瓶啤酒 NT$ {BeerT}元\n";

            Total = BeerT + SakeT + LiquorT + WineT;
            lab_Total.Text = $"NT$ {Total}";
            lab_List.Text = BeerS + SakeS + LiquorS + WineS;
        }

        private void btn_Sake_Click(object sender, EventArgs e)
        {
            SakeC += 1;
            SakeT = Sake * SakeC;

            if (SakeC > 0)
                SakeS = $"{SakeC}瓶清酒 NT$ {SakeT}元\n";

            Total = BeerT + SakeT + LiquorT + WineT;
            lab_Total.Text = $"NT$ {Total}";
            lab_List.Text = BeerS + SakeS + LiquorS + WineS;
        }

        private void btn_Liquor_Click(object sender, EventArgs e)
        {
            LiquorC += 1;
            LiquorT = Liquor * LiquorC;

            if (LiquorC > 0)
                  LiquorS = $"{LiquorC}瓶白酒 NT$ {LiquorT}元\n";

            Total = BeerT + SakeT + LiquorT + WineT;
            lab_Total.Text = $"NT$ {Total}";
            lab_List.Text = BeerS + SakeS + LiquorS  + WineS;
        }

        private void btn_Wine_Click(object sender, EventArgs e)
        {
            WineC += 1;
            WineT = Wine * WineC;

            if (WineC > 0)
                WineS = $"{WineC}瓶紅酒 NT$ {WineT}元\n";

            Total = BeerT + SakeT + LiquorT + WineT;
            lab_Total.Text = $"NT$ {Total}";
            lab_List.Text = BeerS  + SakeS + LiquorS + WineS;
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show( $"總金額為: {Total} 元\n\n" +
                $"請問是否以現金結帳?", "現金支付", MessageBoxButtons.YesNo);
        }

        private void btn_CreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額為: {Total} 元\n信用卡優惠價為: {Total * 0.9} 元\n\n" +
                $"請問是否以信用卡結帳?", "信用卡支付", MessageBoxButtons.YesNo);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lab_List.Text = "尚未點餐";
            lab_Total.Text = "NT$ 0";
            BeerC = 0; SakeC = 0; LiquorC = 0; WineC = 0; Total = 0;
            BeerT = 0; SakeT = 0; LiquorT = 0; WineT = 0;
            BeerS = ""; SakeS = ""; LiquorS = ""; WineS = "";
        }
    }
}
