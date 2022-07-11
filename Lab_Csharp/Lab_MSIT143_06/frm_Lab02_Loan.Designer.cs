
namespace Lab_MSIT143_06
{
    partial class frm_Lab02_Loan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab02_Loan));
            this.lab_01 = new System.Windows.Forms.Label();
            this.lab_03 = new System.Windows.Forms.Label();
            this.lab_02 = new System.Windows.Forms.Label();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.txt_04 = new System.Windows.Forms.TextBox();
            this.btn_01 = new System.Windows.Forms.Button();
            this.lab_04 = new System.Windows.Forms.Label();
            this.btn_03 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.lab_001 = new System.Windows.Forms.Label();
            this.lab_002 = new System.Windows.Forms.Label();
            this.lab_003 = new System.Windows.Forms.Label();
            this.lab_004 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_01
            // 
            this.lab_01.AutoSize = true;
            this.lab_01.BackColor = System.Drawing.Color.Transparent;
            this.lab_01.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_01.ForeColor = System.Drawing.Color.Black;
            this.lab_01.Location = new System.Drawing.Point(63, 38);
            this.lab_01.Name = "lab_01";
            this.lab_01.Size = new System.Drawing.Size(122, 31);
            this.lab_01.TabIndex = 0;
            this.lab_01.Text = "貸款金額 :";
            // 
            // lab_03
            // 
            this.lab_03.AutoSize = true;
            this.lab_03.BackColor = System.Drawing.Color.Transparent;
            this.lab_03.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_03.ForeColor = System.Drawing.Color.Black;
            this.lab_03.Location = new System.Drawing.Point(87, 160);
            this.lab_03.Name = "lab_03";
            this.lab_03.Size = new System.Drawing.Size(98, 31);
            this.lab_03.TabIndex = 1;
            this.lab_03.Text = "年利率 :";
            // 
            // lab_02
            // 
            this.lab_02.AutoSize = true;
            this.lab_02.BackColor = System.Drawing.Color.Transparent;
            this.lab_02.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_02.ForeColor = System.Drawing.Color.Black;
            this.lab_02.Location = new System.Drawing.Point(63, 99);
            this.lab_02.Name = "lab_02";
            this.lab_02.Size = new System.Drawing.Size(122, 31);
            this.lab_02.TabIndex = 2;
            this.lab_02.Text = "貸款年期 :";
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_01.Location = new System.Drawing.Point(195, 33);
            this.txt_01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_01.MaxLength = 9;
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(407, 43);
            this.txt_01.TabIndex = 4;
            this.txt_01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_01_KeyPress);
            this.txt_01.MouseLeave += new System.EventHandler(this.txt_01_MouseLeave);
            this.txt_01.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_01_MouseMove);
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_02.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_02.Location = new System.Drawing.Point(194, 94);
            this.txt_02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_02.MaxLength = 2;
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(407, 43);
            this.txt_02.TabIndex = 5;
            this.txt_02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_01_KeyPress);
            this.txt_02.MouseLeave += new System.EventHandler(this.txt_02_MouseLeave);
            this.txt_02.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_02_MouseMove);
            // 
            // txt_03
            // 
            this.txt_03.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_03.Location = new System.Drawing.Point(194, 155);
            this.txt_03.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_03.MaxLength = 4;
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(407, 43);
            this.txt_03.TabIndex = 6;
            this.txt_03.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_03_KeyPress);
            this.txt_03.MouseLeave += new System.EventHandler(this.txt_03_MouseLeave);
            this.txt_03.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_03_MouseMove);
            // 
            // txt_04
            // 
            this.txt_04.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_04.Location = new System.Drawing.Point(194, 216);
            this.txt_04.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_04.MaxLength = 9;
            this.txt_04.Name = "txt_04";
            this.txt_04.Size = new System.Drawing.Size(407, 43);
            this.txt_04.TabIndex = 7;
            this.txt_04.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_01_KeyPress);
            this.txt_04.MouseLeave += new System.EventHandler(this.txt_04_MouseLeave);
            this.txt_04.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_04_MouseMove);
            // 
            // btn_01
            // 
            this.btn_01.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_01.Location = new System.Drawing.Point(55, 560);
            this.btn_01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(171, 43);
            this.btn_01.TabIndex = 8;
            this.btn_01.Text = "月付款";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // lab_04
            // 
            this.lab_04.AutoSize = true;
            this.lab_04.BackColor = System.Drawing.Color.Transparent;
            this.lab_04.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_04.ForeColor = System.Drawing.Color.Black;
            this.lab_04.Location = new System.Drawing.Point(87, 221);
            this.lab_04.Name = "lab_04";
            this.lab_04.Size = new System.Drawing.Size(98, 31);
            this.lab_04.TabIndex = 9;
            this.lab_04.Text = "頭期款 :";
            // 
            // btn_03
            // 
            this.btn_03.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_03.Location = new System.Drawing.Point(431, 560);
            this.btn_03.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(171, 43);
            this.btn_03.TabIndex = 12;
            this.btn_03.Text = "Report";
            this.btn_03.UseVisualStyleBackColor = true;
            this.btn_03.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // btn_02
            // 
            this.btn_02.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_02.Location = new System.Drawing.Point(243, 560);
            this.btn_02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(171, 43);
            this.btn_02.TabIndex = 11;
            this.btn_02.Text = "總付款";
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // lab_001
            // 
            this.lab_001.BackColor = System.Drawing.Color.White;
            this.lab_001.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lab_001.Location = new System.Drawing.Point(416, 39);
            this.lab_001.Name = "lab_001";
            this.lab_001.Size = new System.Drawing.Size(180, 30);
            this.lab_001.TabIndex = 13;
            this.lab_001.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_002
            // 
            this.lab_002.BackColor = System.Drawing.Color.White;
            this.lab_002.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lab_002.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_002.Location = new System.Drawing.Point(416, 100);
            this.lab_002.Name = "lab_002";
            this.lab_002.Size = new System.Drawing.Size(180, 30);
            this.lab_002.TabIndex = 14;
            this.lab_002.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_003
            // 
            this.lab_003.BackColor = System.Drawing.Color.White;
            this.lab_003.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lab_003.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_003.Location = new System.Drawing.Point(416, 161);
            this.lab_003.Name = "lab_003";
            this.lab_003.Size = new System.Drawing.Size(180, 30);
            this.lab_003.TabIndex = 15;
            this.lab_003.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_004
            // 
            this.lab_004.BackColor = System.Drawing.Color.White;
            this.lab_004.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.lab_004.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_004.Location = new System.Drawing.Point(416, 222);
            this.lab_004.Name = "lab_004";
            this.lab_004.Size = new System.Drawing.Size(180, 30);
            this.lab_004.TabIndex = 16;
            this.lab_004.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Lab02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(659, 616);
            this.Controls.Add(this.lab_004);
            this.Controls.Add(this.lab_003);
            this.Controls.Add(this.lab_002);
            this.Controls.Add(this.lab_001);
            this.Controls.Add(this.btn_03);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.lab_04);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.txt_04);
            this.Controls.Add(this.txt_03);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.lab_02);
            this.Controls.Add(this.lab_03);
            this.Controls.Add(this.lab_01);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab02_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_01;
        private System.Windows.Forms.Label lab_03;
        private System.Windows.Forms.Label lab_02;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_03;
        private System.Windows.Forms.TextBox txt_04;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Label lab_04;
        private System.Windows.Forms.Button btn_03;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Label lab_001;
        private System.Windows.Forms.Label lab_002;
        private System.Windows.Forms.Label lab_003;
        private System.Windows.Forms.Label lab_004;
    }
}

