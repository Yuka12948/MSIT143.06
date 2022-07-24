
namespace Lab_MSIT143_06
{
    partial class frm_Lab01_HelloFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab01_HelloFrom));
            this.lab_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.lab_Birth = new System.Windows.Forms.Label();
            this.lab_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lab_Tittle = new System.Windows.Forms.Label();
            this.rBtn_female = new System.Windows.Forms.RadioButton();
            this.rBtn_male = new System.Windows.Forms.RadioButton();
            this.btn_JOKE = new System.Windows.Forms.Button();
            this.date_Picker = new System.Windows.Forms.DateTimePicker();
            this.lab_IDCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.lab_Name.Font = new System.Drawing.Font("Impact", 18F);
            this.lab_Name.ForeColor = System.Drawing.Color.Black;
            this.lab_Name.Location = new System.Drawing.Point(43, 109);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(78, 29);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "Neme :";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(127, 110);
            this.txt_Name.MaxLength = 50;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(234, 34);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_Name_Leave);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.DimGray;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Impact", 20F);
            this.btn_Enter.ForeColor = System.Drawing.Color.White;
            this.btn_Enter.Location = new System.Drawing.Point(411, 547);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(87, 57);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            this.btn_Enter.MouseLeave += new System.EventHandler(this.btn_Enter_MouseLeave);
            this.btn_Enter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Enter_MouseMove);
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.BackColor = System.Drawing.Color.Transparent;
            this.lab_Gender.Font = new System.Drawing.Font("Impact", 18F);
            this.lab_Gender.ForeColor = System.Drawing.Color.Black;
            this.lab_Gender.Location = new System.Drawing.Point(43, 226);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(93, 29);
            this.lab_Gender.TabIndex = 3;
            this.lab_Gender.Text = "Gender :";
            // 
            // lab_Birth
            // 
            this.lab_Birth.AutoSize = true;
            this.lab_Birth.BackColor = System.Drawing.Color.Transparent;
            this.lab_Birth.Font = new System.Drawing.Font("Impact", 18F);
            this.lab_Birth.ForeColor = System.Drawing.Color.Black;
            this.lab_Birth.Location = new System.Drawing.Point(43, 148);
            this.lab_Birth.Name = "lab_Birth";
            this.lab_Birth.Size = new System.Drawing.Size(141, 29);
            this.lab_Birth.TabIndex = 4;
            this.lab_Birth.Text = "Date of Birth :";
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.BackColor = System.Drawing.Color.Transparent;
            this.lab_ID.Font = new System.Drawing.Font("Impact", 18F);
            this.lab_ID.ForeColor = System.Drawing.Color.Black;
            this.lab_ID.Location = new System.Drawing.Point(43, 187);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(124, 29);
            this.lab_ID.TabIndex = 5;
            this.lab_ID.Text = "ID Number :";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ID.Location = new System.Drawing.Point(173, 188);
            this.txt_ID.MaxLength = 10;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(188, 34);
            this.txt_ID.TabIndex = 8;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            this.txt_ID.Enter += new System.EventHandler(this.txt_ID_Enter);
            this.txt_ID.Leave += new System.EventHandler(this.txt_ID_Leave);
            // 
            // lab_Tittle
            // 
            this.lab_Tittle.AutoSize = true;
            this.lab_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.lab_Tittle.Font = new System.Drawing.Font("Impact", 30F);
            this.lab_Tittle.ForeColor = System.Drawing.Color.Black;
            this.lab_Tittle.Location = new System.Drawing.Point(27, 36);
            this.lab_Tittle.Name = "lab_Tittle";
            this.lab_Tittle.Size = new System.Drawing.Size(351, 48);
            this.lab_Tittle.TabIndex = 9;
            this.lab_Tittle.Text = " -Basic Information -";
            // 
            // rBtn_female
            // 
            this.rBtn_female.AutoSize = true;
            this.rBtn_female.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_female.Font = new System.Drawing.Font("Impact", 18F);
            this.rBtn_female.Location = new System.Drawing.Point(228, 224);
            this.rBtn_female.Name = "rBtn_female";
            this.rBtn_female.Size = new System.Drawing.Size(99, 33);
            this.rBtn_female.TabIndex = 10;
            this.rBtn_female.TabStop = true;
            this.rBtn_female.Text = "female";
            this.rBtn_female.UseVisualStyleBackColor = false;
            // 
            // rBtn_male
            // 
            this.rBtn_male.AutoSize = true;
            this.rBtn_male.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_male.Font = new System.Drawing.Font("Impact", 18F);
            this.rBtn_male.ForeColor = System.Drawing.Color.Black;
            this.rBtn_male.Location = new System.Drawing.Point(142, 224);
            this.rBtn_male.Name = "rBtn_male";
            this.rBtn_male.Size = new System.Drawing.Size(80, 33);
            this.rBtn_male.TabIndex = 11;
            this.rBtn_male.TabStop = true;
            this.rBtn_male.Tag = "";
            this.rBtn_male.Text = "male";
            this.rBtn_male.UseVisualStyleBackColor = false;
            // 
            // btn_JOKE
            // 
            this.btn_JOKE.BackColor = System.Drawing.Color.DimGray;
            this.btn_JOKE.FlatAppearance.BorderSize = 0;
            this.btn_JOKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JOKE.Font = new System.Drawing.Font("Impact", 20F);
            this.btn_JOKE.ForeColor = System.Drawing.Color.White;
            this.btn_JOKE.Location = new System.Drawing.Point(504, 547);
            this.btn_JOKE.Name = "btn_JOKE";
            this.btn_JOKE.Size = new System.Drawing.Size(140, 57);
            this.btn_JOKE.TabIndex = 16;
            this.btn_JOKE.Text = "Don\'t click";
            this.btn_JOKE.UseVisualStyleBackColor = false;
            this.btn_JOKE.Click += new System.EventHandler(this.btn_JOKE_Click);
            this.btn_JOKE.MouseLeave += new System.EventHandler(this.btn_JOKE_MouseLeave);
            this.btn_JOKE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_JOKE_MouseMove);
            // 
            // date_Picker
            // 
            this.date_Picker.CustomFormat = "yyyy-MM-dd";
            this.date_Picker.Font = new System.Drawing.Font("jf open 粉圓 1.1", 13F);
            this.date_Picker.Location = new System.Drawing.Point(190, 151);
            this.date_Picker.MaxDate = new System.DateTime(2200, 6, 23, 0, 0, 0, 0);
            this.date_Picker.MinDate = new System.DateTime(1870, 1, 1, 0, 0, 0, 0);
            this.date_Picker.Name = "date_Picker";
            this.date_Picker.ShowUpDown = true;
            this.date_Picker.Size = new System.Drawing.Size(171, 30);
            this.date_Picker.TabIndex = 18;
            this.date_Picker.Value = new System.DateTime(2022, 6, 23, 0, 0, 0, 0);
            // 
            // lab_IDCorrect
            // 
            this.lab_IDCorrect.AutoSize = true;
            this.lab_IDCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lab_IDCorrect.Location = new System.Drawing.Point(367, 198);
            this.lab_IDCorrect.Name = "lab_IDCorrect";
            this.lab_IDCorrect.Size = new System.Drawing.Size(0, 16);
            this.lab_IDCorrect.TabIndex = 19;
            // 
            // frm_Lab01_HelloFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(659, 616);
            this.Controls.Add(this.lab_IDCorrect);
            this.Controls.Add(this.date_Picker);
            this.Controls.Add(this.btn_JOKE);
            this.Controls.Add(this.rBtn_male);
            this.Controls.Add(this.rBtn_female);
            this.Controls.Add(this.lab_Tittle);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.lab_Birth);
            this.Controls.Add(this.lab_Gender);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lab_Name);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab01_HelloFrom";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.Label lab_Birth;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lab_Tittle;
        private System.Windows.Forms.RadioButton rBtn_female;
        private System.Windows.Forms.RadioButton rBtn_male;
        private System.Windows.Forms.Button btn_JOKE;
        private System.Windows.Forms.DateTimePicker date_Picker;
        private System.Windows.Forms.Label lab_IDCorrect;
    }
}

