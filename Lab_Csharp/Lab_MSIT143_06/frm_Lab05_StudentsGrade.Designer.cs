
namespace Lab_MSIT143_06
{
    partial class frm_Lab05_StudentsGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab05_StudentsGrade));
            this.Gbox_KeyIn = new System.Windows.Forms.GroupBox();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.txt_Eng = new System.Windows.Forms.TextBox();
            this.txt_Cht = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lab_Cht = new System.Windows.Forms.Label();
            this.lab_Eng = new System.Windows.Forms.Label();
            this.lab_Math = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_Random20 = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lab_Show = new System.Windows.Forms.Label();
            this.lab_est = new System.Windows.Forms.Label();
            this.Gbox_KeyIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_KeyIn
            // 
            this.Gbox_KeyIn.Controls.Add(this.txt_Math);
            this.Gbox_KeyIn.Controls.Add(this.txt_Eng);
            this.Gbox_KeyIn.Controls.Add(this.txt_Cht);
            this.Gbox_KeyIn.Controls.Add(this.lab_Name);
            this.Gbox_KeyIn.Controls.Add(this.txt_Name);
            this.Gbox_KeyIn.Controls.Add(this.lab_Cht);
            this.Gbox_KeyIn.Controls.Add(this.lab_Eng);
            this.Gbox_KeyIn.Controls.Add(this.lab_Math);
            this.Gbox_KeyIn.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.Gbox_KeyIn.Location = new System.Drawing.Point(27, 16);
            this.Gbox_KeyIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_KeyIn.Name = "Gbox_KeyIn";
            this.Gbox_KeyIn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_KeyIn.Size = new System.Drawing.Size(284, 224);
            this.Gbox_KeyIn.TabIndex = 12;
            this.Gbox_KeyIn.TabStop = false;
            this.Gbox_KeyIn.Text = "成績輸入";
            // 
            // txt_Math
            // 
            this.txt_Math.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_Math.Location = new System.Drawing.Point(117, 168);
            this.txt_Math.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Math.MaxLength = 3;
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(136, 32);
            this.txt_Math.TabIndex = 13;
            // 
            // txt_Eng
            // 
            this.txt_Eng.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_Eng.Location = new System.Drawing.Point(117, 128);
            this.txt_Eng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Eng.MaxLength = 3;
            this.txt_Eng.Name = "txt_Eng";
            this.txt_Eng.Size = new System.Drawing.Size(136, 32);
            this.txt_Eng.TabIndex = 12;
            // 
            // txt_Cht
            // 
            this.txt_Cht.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_Cht.Location = new System.Drawing.Point(117, 88);
            this.txt_Cht.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Cht.MaxLength = 3;
            this.txt_Cht.Name = "txt_Cht";
            this.txt_Cht.Size = new System.Drawing.Size(136, 32);
            this.txt_Cht.TabIndex = 11;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Name.Location = new System.Drawing.Point(21, 51);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(90, 24);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "學生姓名:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_Name.Location = new System.Drawing.Point(117, 48);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(136, 32);
            this.txt_Name.TabIndex = 10;
            // 
            // lab_Cht
            // 
            this.lab_Cht.AutoSize = true;
            this.lab_Cht.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Cht.Location = new System.Drawing.Point(21, 91);
            this.lab_Cht.Name = "lab_Cht";
            this.lab_Cht.Size = new System.Drawing.Size(90, 24);
            this.lab_Cht.TabIndex = 1;
            this.lab_Cht.Text = "國文成績:";
            // 
            // lab_Eng
            // 
            this.lab_Eng.AutoSize = true;
            this.lab_Eng.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Eng.Location = new System.Drawing.Point(21, 131);
            this.lab_Eng.Name = "lab_Eng";
            this.lab_Eng.Size = new System.Drawing.Size(90, 24);
            this.lab_Eng.TabIndex = 2;
            this.lab_Eng.Text = "英文成績:";
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_Math.Location = new System.Drawing.Point(21, 171);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(90, 24);
            this.lab_Math.TabIndex = 3;
            this.lab_Math.Text = "數學成績:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btn_Clear.Location = new System.Drawing.Point(52, 448);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(228, 42);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "重設所有資料";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btn_Add.Location = new System.Drawing.Point(52, 248);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(228, 42);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "加入學生資料";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btn_Random.Location = new System.Drawing.Point(52, 298);
            this.btn_Random.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(228, 42);
            this.btn_Random.TabIndex = 15;
            this.btn_Random.Text = "隨機加入資料";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // btn_Random20
            // 
            this.btn_Random20.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btn_Random20.Location = new System.Drawing.Point(52, 348);
            this.btn_Random20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Random20.Name = "btn_Random20";
            this.btn_Random20.Size = new System.Drawing.Size(228, 42);
            this.btn_Random20.TabIndex = 16;
            this.btn_Random20.Text = "隨機加入20筆資料";
            this.btn_Random20.UseVisualStyleBackColor = true;
            this.btn_Random20.Click += new System.EventHandler(this.btn_Random20_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btn_Result.Location = new System.Drawing.Point(52, 398);
            this.btn_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(228, 42);
            this.btn_Result.TabIndex = 17;
            this.btn_Result.Text = "各科統計";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(326, 16);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lab_Show);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lab_est);
            this.splitContainer.Size = new System.Drawing.Size(520, 474);
            this.splitContainer.SplitterDistance = 326;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 18;
            // 
            // lab_Show
            // 
            this.lab_Show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_Show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Show.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Show.Location = new System.Drawing.Point(13, 13);
            this.lab_Show.Name = "lab_Show";
            this.lab_Show.Size = new System.Drawing.Size(495, 300);
            this.lab_Show.TabIndex = 0;
            this.lab_Show.Text = "姓名        國文  英文  數學   總分  平均       最高      最低";
            // 
            // lab_est
            // 
            this.lab_est.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_est.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_est.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_est.Location = new System.Drawing.Point(13, 11);
            this.lab_est.Name = "lab_est";
            this.lab_est.Size = new System.Drawing.Size(495, 120);
            this.lab_est.TabIndex = 0;
            this.lab_est.Text = "總分/平均/最高分/最低分";
            // 
            // frm_Lab05_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 506);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Random20);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Gbox_KeyIn);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab05_StudentsGrade";
            this.Text = " Students Grade";
            this.Gbox_KeyIn.ResumeLayout(false);
            this.Gbox_KeyIn.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_KeyIn;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.TextBox txt_Eng;
        private System.Windows.Forms.TextBox txt_Cht;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lab_Cht;
        private System.Windows.Forms.Label lab_Eng;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Random20;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lab_Show;
        private System.Windows.Forms.Label lab_est;
    }
}