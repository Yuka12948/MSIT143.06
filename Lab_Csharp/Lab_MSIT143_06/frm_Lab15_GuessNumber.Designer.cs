
namespace Lab_MSIT143_06
{
    partial class frm_Lab15_GuessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab15_GuessNumber));
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.lab_PlsInput = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_guess
            // 
            this.txt_guess.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guess.Location = new System.Drawing.Point(40, 112);
            this.txt_guess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_guess.MaxLength = 3;
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(324, 40);
            this.txt_guess.TabIndex = 0;
            this.txt_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_guess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_Guess
            // 
            this.btn_Guess.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guess.Location = new System.Drawing.Point(392, 55);
            this.btn_Guess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(100, 43);
            this.btn_Guess.TabIndex = 1;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // lab_PlsInput
            // 
            this.lab_PlsInput.AutoSize = true;
            this.lab_PlsInput.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PlsInput.Location = new System.Drawing.Point(68, 64);
            this.lab_PlsInput.Name = "lab_PlsInput";
            this.lab_PlsInput.Size = new System.Drawing.Size(267, 34);
            this.lab_PlsInput.TabIndex = 2;
            this.lab_PlsInput.Text = "Please input a number.";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(392, 109);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 43);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Lab15_GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lab_PlsInput);
            this.Controls.Add(this.btn_Guess);
            this.Controls.Add(this.txt_guess);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 700);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab15_GuessNumber";
            this.Text = "Guess A Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Label lab_PlsInput;
        private System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.TextBox txt_guess;
    }
}