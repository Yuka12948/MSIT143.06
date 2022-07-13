
namespace Lab_MSIT143_06
{
    partial class frm_Lab08_MyClac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab08_MyClac));
            this.lab_Num1 = new System.Windows.Forms.Label();
            this.lab_Num2 = new System.Windows.Forms.Label();
            this.lab_Answer = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.lab_Result = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_DividedBy = new System.Windows.Forms.Button();
            this.btn_multipliedBy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Num1
            // 
            this.lab_Num1.AutoSize = true;
            this.lab_Num1.BackColor = System.Drawing.Color.Transparent;
            this.lab_Num1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Num1.ForeColor = System.Drawing.Color.Silver;
            this.lab_Num1.Location = new System.Drawing.Point(23, 28);
            this.lab_Num1.Name = "lab_Num1";
            this.lab_Num1.Size = new System.Drawing.Size(69, 26);
            this.lab_Num1.TabIndex = 0;
            this.lab_Num1.Text = "Num1 : ";
            // 
            // lab_Num2
            // 
            this.lab_Num2.AutoSize = true;
            this.lab_Num2.BackColor = System.Drawing.Color.Transparent;
            this.lab_Num2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Num2.ForeColor = System.Drawing.Color.Silver;
            this.lab_Num2.Location = new System.Drawing.Point(135, 28);
            this.lab_Num2.Name = "lab_Num2";
            this.lab_Num2.Size = new System.Drawing.Size(72, 26);
            this.lab_Num2.TabIndex = 1;
            this.lab_Num2.Text = "Num2 : ";
            // 
            // lab_Answer
            // 
            this.lab_Answer.AutoSize = true;
            this.lab_Answer.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Answer.ForeColor = System.Drawing.Color.DarkGray;
            this.lab_Answer.Location = new System.Drawing.Point(23, 101);
            this.lab_Answer.Name = "lab_Answer";
            this.lab_Answer.Size = new System.Drawing.Size(87, 26);
            this.lab_Answer.TabIndex = 2;
            this.lab_Answer.Text = "Answer : ";
            // 
            // txt_Num1
            // 
            this.txt_Num1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num1.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txt_Num1.ForeColor = System.Drawing.Color.LightBlue;
            this.txt_Num1.Location = new System.Drawing.Point(28, 58);
            this.txt_Num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(106, 26);
            this.txt_Num1.TabIndex = 4;
            this.txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num_KeyPress);
            // 
            // txt_Num2
            // 
            this.txt_Num2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num2.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txt_Num2.ForeColor = System.Drawing.Color.LightBlue;
            this.txt_Num2.Location = new System.Drawing.Point(140, 58);
            this.txt_Num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(106, 26);
            this.txt_Num2.TabIndex = 5;
            this.txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num_KeyPress);
            // 
            // lab_Result
            // 
            this.lab_Result.BackColor = System.Drawing.Color.AliceBlue;
            this.lab_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Result.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Result.ForeColor = System.Drawing.Color.SteelBlue;
            this.lab_Result.Location = new System.Drawing.Point(28, 133);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(218, 57);
            this.lab_Result.TabIndex = 6;
            this.lab_Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.White;
            this.btn_plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_plus.BackgroundImage")));
            this.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_plus.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(28, 209);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(50, 50);
            this.btn_plus.TabIndex = 7;
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.White;
            this.btn_minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minus.BackgroundImage")));
            this.btn_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minus.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(84, 209);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 50);
            this.btn_minus.TabIndex = 8;
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_DividedBy
            // 
            this.btn_DividedBy.BackColor = System.Drawing.Color.White;
            this.btn_DividedBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DividedBy.BackgroundImage")));
            this.btn_DividedBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DividedBy.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_DividedBy.FlatAppearance.BorderSize = 0;
            this.btn_DividedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DividedBy.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_DividedBy.ForeColor = System.Drawing.Color.White;
            this.btn_DividedBy.Location = new System.Drawing.Point(196, 209);
            this.btn_DividedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DividedBy.Name = "btn_DividedBy";
            this.btn_DividedBy.Size = new System.Drawing.Size(50, 50);
            this.btn_DividedBy.TabIndex = 10;
            this.btn_DividedBy.UseVisualStyleBackColor = false;
            this.btn_DividedBy.Click += new System.EventHandler(this.btn_DividedBy_Click);
            // 
            // btn_multipliedBy
            // 
            this.btn_multipliedBy.BackColor = System.Drawing.Color.White;
            this.btn_multipliedBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_multipliedBy.BackgroundImage")));
            this.btn_multipliedBy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_multipliedBy.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btn_multipliedBy.FlatAppearance.BorderSize = 0;
            this.btn_multipliedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multipliedBy.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_multipliedBy.ForeColor = System.Drawing.Color.White;
            this.btn_multipliedBy.Location = new System.Drawing.Point(140, 209);
            this.btn_multipliedBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_multipliedBy.Name = "btn_multipliedBy";
            this.btn_multipliedBy.Size = new System.Drawing.Size(50, 50);
            this.btn_multipliedBy.TabIndex = 9;
            this.btn_multipliedBy.UseVisualStyleBackColor = false;
            this.btn_multipliedBy.Click += new System.EventHandler(this.btn_multipliedBy_Click);
            // 
            // frm_Lab08_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(275, 287);
            this.Controls.Add(this.btn_DividedBy);
            this.Controls.Add(this.btn_multipliedBy);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.lab_Result);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lab_Answer);
            this.Controls.Add(this.lab_Num2);
            this.Controls.Add(this.lab_Num1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab08_MyClac";
            this.Text = "My Clac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Num1;
        private System.Windows.Forms.Label lab_Num2;
        private System.Windows.Forms.Label lab_Answer;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_DividedBy;
        private System.Windows.Forms.Button btn_multipliedBy;
    }
}