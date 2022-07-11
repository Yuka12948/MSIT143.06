
namespace Lab_MSIT143_06
{
    partial class frm_Lab16_Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab16_Alarm));
            this.Gbox_Alarm = new System.Windows.Forms.GroupBox();
            this.lab_Sec = new System.Windows.Forms.Label();
            this.lab_Min = new System.Windows.Forms.Label();
            this.lab_Hr = new System.Windows.Forms.Label();
            this.checkBox_SetAlarm = new System.Windows.Forms.CheckBox();
            this.cbBox_AlarmSec = new System.Windows.Forms.ComboBox();
            this.cbBox_AlarmMin = new System.Windows.Forms.ComboBox();
            this.cbBox_AlarmHr = new System.Windows.Forms.ComboBox();
            this.lab_AlarmTime = new System.Windows.Forms.Label();
            this.lab_GetTime = new System.Windows.Forms.Label();
            this.lab_Time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Gbox_Alarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_Alarm
            // 
            this.Gbox_Alarm.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Alarm.Controls.Add(this.lab_Sec);
            this.Gbox_Alarm.Controls.Add(this.lab_Min);
            this.Gbox_Alarm.Controls.Add(this.lab_Hr);
            this.Gbox_Alarm.Controls.Add(this.checkBox_SetAlarm);
            this.Gbox_Alarm.Controls.Add(this.cbBox_AlarmSec);
            this.Gbox_Alarm.Controls.Add(this.cbBox_AlarmMin);
            this.Gbox_Alarm.Controls.Add(this.cbBox_AlarmHr);
            this.Gbox_Alarm.Controls.Add(this.lab_AlarmTime);
            this.Gbox_Alarm.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold);
            this.Gbox_Alarm.Location = new System.Drawing.Point(79, 192);
            this.Gbox_Alarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Alarm.Name = "Gbox_Alarm";
            this.Gbox_Alarm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Alarm.Size = new System.Drawing.Size(465, 138);
            this.Gbox_Alarm.TabIndex = 0;
            this.Gbox_Alarm.TabStop = false;
            this.Gbox_Alarm.Text = "Alarm";
            // 
            // lab_Sec
            // 
            this.lab_Sec.AutoSize = true;
            this.lab_Sec.BackColor = System.Drawing.Color.Transparent;
            this.lab_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lab_Sec.Location = new System.Drawing.Point(390, 54);
            this.lab_Sec.Name = "lab_Sec";
            this.lab_Sec.Size = new System.Drawing.Size(35, 26);
            this.lab_Sec.TabIndex = 15;
            this.lab_Sec.Text = "秒";
            // 
            // lab_Min
            // 
            this.lab_Min.AutoSize = true;
            this.lab_Min.BackColor = System.Drawing.Color.Transparent;
            this.lab_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lab_Min.Location = new System.Drawing.Point(299, 54);
            this.lab_Min.Name = "lab_Min";
            this.lab_Min.Size = new System.Drawing.Size(35, 26);
            this.lab_Min.TabIndex = 14;
            this.lab_Min.Text = "分";
            // 
            // lab_Hr
            // 
            this.lab_Hr.AutoSize = true;
            this.lab_Hr.BackColor = System.Drawing.Color.Transparent;
            this.lab_Hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lab_Hr.Location = new System.Drawing.Point(208, 54);
            this.lab_Hr.Name = "lab_Hr";
            this.lab_Hr.Size = new System.Drawing.Size(35, 26);
            this.lab_Hr.TabIndex = 13;
            this.lab_Hr.Text = "時";
            // 
            // checkBox_SetAlarm
            // 
            this.checkBox_SetAlarm.AutoSize = true;
            this.checkBox_SetAlarm.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SetAlarm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.checkBox_SetAlarm.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.checkBox_SetAlarm.Location = new System.Drawing.Point(294, 91);
            this.checkBox_SetAlarm.Name = "checkBox_SetAlarm";
            this.checkBox_SetAlarm.Size = new System.Drawing.Size(132, 28);
            this.checkBox_SetAlarm.TabIndex = 12;
            this.checkBox_SetAlarm.Text = "Set Alarm";
            this.checkBox_SetAlarm.UseVisualStyleBackColor = false;
            this.checkBox_SetAlarm.CheckedChanged += new System.EventHandler(this.checkBox_SetAlarm_CheckedChanged);
            // 
            // cbBox_AlarmSec
            // 
            this.cbBox_AlarmSec.DropDownHeight = 300;
            this.cbBox_AlarmSec.DropDownWidth = 50;
            this.cbBox_AlarmSec.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.cbBox_AlarmSec.FormattingEnabled = true;
            this.cbBox_AlarmSec.IntegralHeight = false;
            this.cbBox_AlarmSec.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbBox_AlarmSec.Location = new System.Drawing.Point(340, 54);
            this.cbBox_AlarmSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBox_AlarmSec.Name = "cbBox_AlarmSec";
            this.cbBox_AlarmSec.Size = new System.Drawing.Size(50, 28);
            this.cbBox_AlarmSec.TabIndex = 11;
            this.cbBox_AlarmSec.Text = "00";
            // 
            // cbBox_AlarmMin
            // 
            this.cbBox_AlarmMin.DropDownHeight = 300;
            this.cbBox_AlarmMin.DropDownWidth = 50;
            this.cbBox_AlarmMin.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.cbBox_AlarmMin.FormattingEnabled = true;
            this.cbBox_AlarmMin.IntegralHeight = false;
            this.cbBox_AlarmMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbBox_AlarmMin.Location = new System.Drawing.Point(249, 54);
            this.cbBox_AlarmMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBox_AlarmMin.Name = "cbBox_AlarmMin";
            this.cbBox_AlarmMin.Size = new System.Drawing.Size(50, 28);
            this.cbBox_AlarmMin.TabIndex = 10;
            this.cbBox_AlarmMin.Text = "00";
            // 
            // cbBox_AlarmHr
            // 
            this.cbBox_AlarmHr.DropDownHeight = 300;
            this.cbBox_AlarmHr.DropDownWidth = 50;
            this.cbBox_AlarmHr.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.cbBox_AlarmHr.FormattingEnabled = true;
            this.cbBox_AlarmHr.IntegralHeight = false;
            this.cbBox_AlarmHr.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbBox_AlarmHr.Location = new System.Drawing.Point(158, 54);
            this.cbBox_AlarmHr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBox_AlarmHr.Name = "cbBox_AlarmHr";
            this.cbBox_AlarmHr.Size = new System.Drawing.Size(50, 28);
            this.cbBox_AlarmHr.TabIndex = 9;
            this.cbBox_AlarmHr.Text = "00";
            // 
            // lab_AlarmTime
            // 
            this.lab_AlarmTime.AutoSize = true;
            this.lab_AlarmTime.BackColor = System.Drawing.Color.Transparent;
            this.lab_AlarmTime.Font = new System.Drawing.Font("Lucida Bright", 16F);
            this.lab_AlarmTime.Location = new System.Drawing.Point(40, 55);
            this.lab_AlarmTime.Name = "lab_AlarmTime";
            this.lab_AlarmTime.Size = new System.Drawing.Size(115, 24);
            this.lab_AlarmTime.TabIndex = 8;
            this.lab_AlarmTime.Text = "Set Time :";
            // 
            // lab_GetTime
            // 
            this.lab_GetTime.BackColor = System.Drawing.Color.Transparent;
            this.lab_GetTime.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold);
            this.lab_GetTime.Location = new System.Drawing.Point(31, 76);
            this.lab_GetTime.Name = "lab_GetTime";
            this.lab_GetTime.Size = new System.Drawing.Size(186, 49);
            this.lab_GetTime.TabIndex = 2;
            this.lab_GetTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.BackColor = System.Drawing.Color.Transparent;
            this.lab_Time.Font = new System.Drawing.Font("Lucida Bright", 24.75F, System.Drawing.FontStyle.Bold);
            this.lab_Time.Location = new System.Drawing.Point(30, 39);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(190, 37);
            this.lab_Time.TabIndex = 1;
            this.lab_Time.Text = "Local time";
            this.lab_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frm_Lab16_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(625, 361);
            this.Controls.Add(this.lab_Time);
            this.Controls.Add(this.lab_GetTime);
            this.Controls.Add(this.Gbox_Alarm);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab16_Alarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.frm_Lab16_Alarm_Load);
            this.Gbox_Alarm.ResumeLayout(false);
            this.Gbox_Alarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_Alarm;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Label lab_GetTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lab_Sec;
        private System.Windows.Forms.Label lab_Min;
        private System.Windows.Forms.Label lab_Hr;
        private System.Windows.Forms.CheckBox checkBox_SetAlarm;
        private System.Windows.Forms.ComboBox cbBox_AlarmSec;
        private System.Windows.Forms.ComboBox cbBox_AlarmMin;
        private System.Windows.Forms.ComboBox cbBox_AlarmHr;
        private System.Windows.Forms.Label lab_AlarmTime;
    }
}