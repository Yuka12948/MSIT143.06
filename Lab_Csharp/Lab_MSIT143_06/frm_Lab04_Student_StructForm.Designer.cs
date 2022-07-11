
namespace Lab_MSIT143_06
{
    partial class frm_Lab04_Student_StructForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab04_Student_StructForm));
            this.lab_GradeList = new System.Windows.Forms.Label();
            this.Gbox_Grade = new System.Windows.Forms.GroupBox();
            this.lab_ScoreEst = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ScoreEst = new System.Windows.Forms.Button();
            this.btn_Grade = new System.Windows.Forms.Button();
            this.lab_Math = new System.Windows.Forms.Label();
            this.lab_Eng = new System.Windows.Forms.Label();
            this.lab_Cht = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.txt_Cht = new System.Windows.Forms.TextBox();
            this.txt_Eng = new System.Windows.Forms.TextBox();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.Gbox_KeyIn = new System.Windows.Forms.GroupBox();
            this.Gbox_Grade.SuspendLayout();
            this.Gbox_KeyIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_GradeList
            // 
            this.lab_GradeList.BackColor = System.Drawing.Color.White;
            this.lab_GradeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_GradeList.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_GradeList.Location = new System.Drawing.Point(26, 49);
            this.lab_GradeList.Name = "lab_GradeList";
            this.lab_GradeList.Padding = new System.Windows.Forms.Padding(12, 20, 0, 0);
            this.lab_GradeList.Size = new System.Drawing.Size(322, 215);
            this.lab_GradeList.TabIndex = 4;
            this.lab_GradeList.Text = "成績顯示";
            // 
            // Gbox_Grade
            // 
            this.Gbox_Grade.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Grade.Controls.Add(this.lab_ScoreEst);
            this.Gbox_Grade.Controls.Add(this.lab_GradeList);
            this.Gbox_Grade.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gbox_Grade.Location = new System.Drawing.Point(368, 24);
            this.Gbox_Grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Grade.Name = "Gbox_Grade";
            this.Gbox_Grade.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Grade.Size = new System.Drawing.Size(371, 407);
            this.Gbox_Grade.TabIndex = 6;
            this.Gbox_Grade.TabStop = false;
            this.Gbox_Grade.Text = "總成績";
            // 
            // lab_ScoreEst
            // 
            this.lab_ScoreEst.BackColor = System.Drawing.Color.White;
            this.lab_ScoreEst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_ScoreEst.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_ScoreEst.Location = new System.Drawing.Point(26, 276);
            this.lab_ScoreEst.Name = "lab_ScoreEst";
            this.lab_ScoreEst.Padding = new System.Windows.Forms.Padding(12, 20, 0, 0);
            this.lab_ScoreEst.Size = new System.Drawing.Size(322, 105);
            this.lab_ScoreEst.TabIndex = 5;
            this.lab_ScoreEst.Text = "最高分/最低分科目";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(30, 276);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 44);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(162, 276);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(126, 44);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ScoreEst
            // 
            this.btn_ScoreEst.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_ScoreEst.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn_ScoreEst.ForeColor = System.Drawing.Color.White;
            this.btn_ScoreEst.Location = new System.Drawing.Point(150, 387);
            this.btn_ScoreEst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ScoreEst.Name = "btn_ScoreEst";
            this.btn_ScoreEst.Size = new System.Drawing.Size(193, 44);
            this.btn_ScoreEst.TabIndex = 14;
            this.btn_ScoreEst.Text = "最高分/最低分";
            this.btn_ScoreEst.UseVisualStyleBackColor = false;
            this.btn_ScoreEst.Click += new System.EventHandler(this.btn_ScoreMaxMin_Click);
            // 
            // btn_Grade
            // 
            this.btn_Grade.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Grade.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn_Grade.ForeColor = System.Drawing.Color.White;
            this.btn_Grade.Location = new System.Drawing.Point(22, 387);
            this.btn_Grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Grade.Name = "btn_Grade";
            this.btn_Grade.Size = new System.Drawing.Size(122, 44);
            this.btn_Grade.TabIndex = 13;
            this.btn_Grade.Text = "顯示成績";
            this.btn_Grade.UseVisualStyleBackColor = false;
            this.btn_Grade.Click += new System.EventHandler(this.btn_Grade_Click);
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Math.Location = new System.Drawing.Point(32, 222);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(95, 24);
            this.lab_Math.TabIndex = 3;
            this.lab_Math.Tag = "";
            this.lab_Math.Text = "數學成績 :";
            // 
            // lab_Eng
            // 
            this.lab_Eng.AutoSize = true;
            this.lab_Eng.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Eng.Location = new System.Drawing.Point(32, 166);
            this.lab_Eng.Name = "lab_Eng";
            this.lab_Eng.Size = new System.Drawing.Size(95, 24);
            this.lab_Eng.TabIndex = 2;
            this.lab_Eng.Tag = "";
            this.lab_Eng.Text = "英文成績 :";
            // 
            // lab_Cht
            // 
            this.lab_Cht.AutoSize = true;
            this.lab_Cht.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Cht.Location = new System.Drawing.Point(32, 110);
            this.lab_Cht.Name = "lab_Cht";
            this.lab_Cht.Size = new System.Drawing.Size(95, 24);
            this.lab_Cht.TabIndex = 1;
            this.lab_Cht.Tag = "";
            this.lab_Cht.Text = "國文成績 :";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txt_Name.Location = new System.Drawing.Point(133, 49);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(155, 36);
            this.txt_Name.TabIndex = 10;
            this.txt_Name.Tag = "";
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Name.Location = new System.Drawing.Point(32, 54);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(95, 24);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Tag = "";
            this.lab_Name.Text = "學生姓名 :";
            // 
            // txt_Cht
            // 
            this.txt_Cht.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txt_Cht.Location = new System.Drawing.Point(133, 105);
            this.txt_Cht.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Cht.MaxLength = 3;
            this.txt_Cht.Name = "txt_Cht";
            this.txt_Cht.Size = new System.Drawing.Size(155, 36);
            this.txt_Cht.TabIndex = 11;
            this.txt_Cht.Tag = "";
            this.txt_Cht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cht_KeyPress);
            // 
            // txt_Eng
            // 
            this.txt_Eng.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txt_Eng.Location = new System.Drawing.Point(133, 161);
            this.txt_Eng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Eng.MaxLength = 3;
            this.txt_Eng.Name = "txt_Eng";
            this.txt_Eng.Size = new System.Drawing.Size(155, 36);
            this.txt_Eng.TabIndex = 12;
            this.txt_Eng.Tag = "";
            this.txt_Eng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Eng_KeyPress);
            // 
            // txt_Math
            // 
            this.txt_Math.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txt_Math.Location = new System.Drawing.Point(133, 217);
            this.txt_Math.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Math.MaxLength = 3;
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(155, 36);
            this.txt_Math.TabIndex = 13;
            this.txt_Math.Tag = "";
            this.txt_Math.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Math_KeyPress);
            // 
            // Gbox_KeyIn
            // 
            this.Gbox_KeyIn.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_KeyIn.Controls.Add(this.txt_Math);
            this.Gbox_KeyIn.Controls.Add(this.txt_Eng);
            this.Gbox_KeyIn.Controls.Add(this.btn_Clear);
            this.Gbox_KeyIn.Controls.Add(this.txt_Cht);
            this.Gbox_KeyIn.Controls.Add(this.lab_Name);
            this.Gbox_KeyIn.Controls.Add(this.btn_Save);
            this.Gbox_KeyIn.Controls.Add(this.txt_Name);
            this.Gbox_KeyIn.Controls.Add(this.lab_Cht);
            this.Gbox_KeyIn.Controls.Add(this.lab_Eng);
            this.Gbox_KeyIn.Controls.Add(this.lab_Math);
            this.Gbox_KeyIn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gbox_KeyIn.Location = new System.Drawing.Point(22, 24);
            this.Gbox_KeyIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_KeyIn.Name = "Gbox_KeyIn";
            this.Gbox_KeyIn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_KeyIn.Size = new System.Drawing.Size(321, 344);
            this.Gbox_KeyIn.TabIndex = 11;
            this.Gbox_KeyIn.TabStop = false;
            this.Gbox_KeyIn.Text = "成績輸入";
            // 
            // frm_Lab04_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.btn_ScoreEst);
            this.Controls.Add(this.Gbox_KeyIn);
            this.Controls.Add(this.Gbox_Grade);
            this.Controls.Add(this.btn_Grade);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab04_Student_StructForm";
            this.Text = "Frm_Student_StructForm";
            this.Gbox_Grade.ResumeLayout(false);
            this.Gbox_KeyIn.ResumeLayout(false);
            this.Gbox_KeyIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lab_GradeList;
        private System.Windows.Forms.GroupBox Gbox_Grade;
        private System.Windows.Forms.Label lab_ScoreEst;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ScoreEst;
        private System.Windows.Forms.Button btn_Grade;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.Label lab_Eng;
        private System.Windows.Forms.Label lab_Cht;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox txt_Cht;
        private System.Windows.Forms.TextBox txt_Eng;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.GroupBox Gbox_KeyIn;
    }
}