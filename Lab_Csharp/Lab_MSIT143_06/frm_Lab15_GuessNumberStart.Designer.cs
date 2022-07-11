
namespace Lab_MSIT143_06
{
    partial class frm_Lab15_GuessNumberStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab15_GuessNumberStart));
            this.lab_1to100 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.lab_TEXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_1to100
            // 
            this.lab_1to100.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_1to100.Location = new System.Drawing.Point(55, 12);
            this.lab_1to100.Name = "lab_1to100";
            this.lab_1to100.Size = new System.Drawing.Size(506, 51);
            this.lab_1to100.TabIndex = 0;
            this.lab_1to100.Text = "Please Guess A Number Between 1 to 100 !";
            this.lab_1to100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(65, 123);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(229, 60);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start !";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Answer
            // 
            this.btn_Answer.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Answer.Location = new System.Drawing.Point(318, 123);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(229, 60);
            this.btn_Answer.TabIndex = 2;
            this.btn_Answer.Text = "See the answer !";
            this.btn_Answer.UseVisualStyleBackColor = true;
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // lab_TEXT
            // 
            this.lab_TEXT.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TEXT.Location = new System.Drawing.Point(65, 68);
            this.lab_TEXT.Name = "lab_TEXT";
            this.lab_TEXT.Size = new System.Drawing.Size(482, 38);
            this.lab_TEXT.TabIndex = 3;
            this.lab_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Lab15_GuessNumberStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 211);
            this.Controls.Add(this.lab_TEXT);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lab_1to100);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab15_GuessNumberStart";
            this.Text = "Guess the number!";
            this.Load += new System.EventHandler(this.frm_Lab15_GuessNumberStart_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Answer;
        internal System.Windows.Forms.Label lab_TEXT;
        internal System.Windows.Forms.Label lab_1to100;
    }
}