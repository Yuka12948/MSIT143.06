using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MSIT143_06
{
    public partial class frm_Lab16_Alarm : Form
    {
        public frm_Lab16_Alarm()
        {
            InitializeComponent();
            //Gbox_Alarm.BackColor = Color.FromArgb(255, 255, 255, 255); 背景半透明
        }

        //利用 Label 控制項來顯示現在時間
        //設定 timer 每1000毫秒(1秒)中必須觸發一次
        private void frm_Lab16_Alarm_Load(object sender, EventArgs e)
        {
            timer.Start();
            lab_GetTime.Text = DateTime.Now.ToString("HH:mm:ss"); //頁面載入時獲取當前時間
        }

        bool b = false; //記錄時間是否到了

        private void timer_Tick(object sender, EventArgs e)
        {
            lab_GetTime.Text = DateTime.Now.ToString("HH:mm:ss"); //timer每一秒執行一次更新一次值
            if (b == false) //時間沒到,進行一次判斷
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            b = true; //時間剛好到了
                            SoundPlayer sound = new SoundPlayer();
                            sound.SoundLocation = "IU-You&I.wav";
                            //sound.SoundLocation = @"E:\MSIT_143_06_Csharp\Lab_Csharp\Lab_Y01\bin\Debug\IU-Good day.wav";
                            sound.Play();
                            DialogResult check = MessageBox.Show("該起床囉~~~", "Alarm", MessageBoxButtons.OK);
                            if (check == DialogResult.OK)
                            {
                                sound.Stop();
                                cbBox_AlarmHr.Text = "00";
                                cbBox_AlarmMin.Text = "00";
                                cbBox_AlarmSec.Text = "00";
                                checkBox_SetAlarm.Checked = false;
                            }
                        }
                    }
                }
            }
        }

        int h, m, s;

        private void checkBox_SetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            //string time = $"{cbBox_AlarmHr.Text}:{cbBox_AlarmMin.Text}:{cbBox_AlarmSec.Text}";
            b = false;
            //獲取設定的鬧鐘時間的小時數和分鐘數
            h = int.Parse(cbBox_AlarmHr.Text);
            m = int.Parse(cbBox_AlarmMin.Text);
            s = int.Parse(cbBox_AlarmSec.Text);
        }
    }
}
