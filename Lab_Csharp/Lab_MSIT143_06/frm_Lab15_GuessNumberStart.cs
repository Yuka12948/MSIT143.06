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
    public partial class frm_Lab15_GuessNumberStart : Form
    {
        public frm_Lab15_GuessNumberStart()
        {
            InitializeComponent();
        }

        public int Number;//要猜的數字

        Random rng = new Random();

        private void frm_Lab15_GuessNumberStart_Load(object sender, EventArgs e)
        {
            int Num = rng.Next(1, 100);
            Number = Num;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            frm_Lab15_GuessNumber GN = new frm_Lab15_GuessNumber();
            GN.Owner = this; 
            //GN.TopLevel = true;
            GN.StartPosition = FormStartPosition.CenterParent;
            GN.ShowDialog();
        }

        private void btn_Answer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"既然你誠心誠意地發問了，那我就大發慈悲地告訴你~\n\n" +
                $"這次的猜數字答案為: {Number}\n\n" +
                $"就是這樣, 喵~", "Answer",MessageBoxButtons.OK);

            int Num = rng.Next(1, 100);
            Number = Num;
        }
    }
}
