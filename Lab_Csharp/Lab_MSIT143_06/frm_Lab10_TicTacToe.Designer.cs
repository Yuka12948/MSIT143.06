
namespace Lab_MSIT143_06
{
    partial class frm_Lab10_TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab10_TicTacToe));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tSBtn_restart = new System.Windows.Forms.ToolStripButton();
            this.tSBtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.Btn_A1 = new System.Windows.Forms.Button();
            this.Btn_A2 = new System.Windows.Forms.Button();
            this.Btn_A3 = new System.Windows.Forms.Button();
            this.Btn_B3 = new System.Windows.Forms.Button();
            this.Btn_B2 = new System.Windows.Forms.Button();
            this.Btn_B1 = new System.Windows.Forms.Button();
            this.Btn_C3 = new System.Windows.Forms.Button();
            this.Btn_C2 = new System.Windows.Forms.Button();
            this.Btn_C1 = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtn_restart,
            this.tSBtn_Exit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(334, 55);
            this.toolStrip.TabIndex = 1;
            // 
            // tSBtn_restart
            // 
            this.tSBtn_restart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn_restart.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_restart.Image")));
            this.tSBtn_restart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBtn_restart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_restart.Name = "tSBtn_restart";
            this.tSBtn_restart.Size = new System.Drawing.Size(44, 52);
            this.tSBtn_restart.Text = "New Game";
            this.tSBtn_restart.Click += new System.EventHandler(this.TSBtn_restart_Click);
            // 
            // tSBtn_Exit
            // 
            this.tSBtn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("tSBtn_Exit.Image")));
            this.tSBtn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtn_Exit.Name = "tSBtn_Exit";
            this.tSBtn_Exit.Size = new System.Drawing.Size(44, 43);
            this.tSBtn_Exit.Text = "Close";
            this.tSBtn_Exit.Click += new System.EventHandler(this.TSBtn_Exit_Click);
            // 
            // Btn_A1
            // 
            this.Btn_A1.AutoSize = true;
            this.Btn_A1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_A1.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_A1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_A1.Location = new System.Drawing.Point(11, 58);
            this.Btn_A1.Name = "Btn_A1";
            this.Btn_A1.Size = new System.Drawing.Size(100, 100);
            this.Btn_A1.TabIndex = 2;
            this.Btn_A1.UseVisualStyleBackColor = false;
            this.Btn_A1.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_A2
            // 
            this.Btn_A2.AutoSize = true;
            this.Btn_A2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_A2.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_A2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_A2.Location = new System.Drawing.Point(117, 58);
            this.Btn_A2.Name = "Btn_A2";
            this.Btn_A2.Size = new System.Drawing.Size(100, 100);
            this.Btn_A2.TabIndex = 3;
            this.Btn_A2.UseVisualStyleBackColor = false;
            this.Btn_A2.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_A3
            // 
            this.Btn_A3.AutoSize = true;
            this.Btn_A3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_A3.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_A3.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_A3.Location = new System.Drawing.Point(223, 58);
            this.Btn_A3.Name = "Btn_A3";
            this.Btn_A3.Size = new System.Drawing.Size(100, 100);
            this.Btn_A3.TabIndex = 4;
            this.Btn_A3.UseVisualStyleBackColor = false;
            this.Btn_A3.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_B3
            // 
            this.Btn_B3.AutoSize = true;
            this.Btn_B3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_B3.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_B3.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_B3.Location = new System.Drawing.Point(223, 164);
            this.Btn_B3.Name = "Btn_B3";
            this.Btn_B3.Size = new System.Drawing.Size(100, 100);
            this.Btn_B3.TabIndex = 7;
            this.Btn_B3.UseVisualStyleBackColor = false;
            this.Btn_B3.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_B2
            // 
            this.Btn_B2.AutoSize = true;
            this.Btn_B2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_B2.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_B2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_B2.Location = new System.Drawing.Point(117, 164);
            this.Btn_B2.Name = "Btn_B2";
            this.Btn_B2.Size = new System.Drawing.Size(100, 100);
            this.Btn_B2.TabIndex = 6;
            this.Btn_B2.UseVisualStyleBackColor = false;
            this.Btn_B2.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_B1
            // 
            this.Btn_B1.AutoSize = true;
            this.Btn_B1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_B1.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_B1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_B1.Location = new System.Drawing.Point(11, 164);
            this.Btn_B1.Name = "Btn_B1";
            this.Btn_B1.Size = new System.Drawing.Size(100, 100);
            this.Btn_B1.TabIndex = 5;
            this.Btn_B1.UseVisualStyleBackColor = false;
            this.Btn_B1.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_C3
            // 
            this.Btn_C3.AutoSize = true;
            this.Btn_C3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_C3.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_C3.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_C3.Location = new System.Drawing.Point(223, 270);
            this.Btn_C3.Name = "Btn_C3";
            this.Btn_C3.Size = new System.Drawing.Size(100, 100);
            this.Btn_C3.TabIndex = 10;
            this.Btn_C3.UseVisualStyleBackColor = false;
            this.Btn_C3.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_C2
            // 
            this.Btn_C2.AutoSize = true;
            this.Btn_C2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_C2.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_C2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_C2.Location = new System.Drawing.Point(117, 270);
            this.Btn_C2.Name = "Btn_C2";
            this.Btn_C2.Size = new System.Drawing.Size(100, 100);
            this.Btn_C2.TabIndex = 9;
            this.Btn_C2.UseVisualStyleBackColor = false;
            this.Btn_C2.Click += new System.EventHandler(this.button_click);
            // 
            // Btn_C1
            // 
            this.Btn_C1.AutoSize = true;
            this.Btn_C1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_C1.Font = new System.Drawing.Font("華康儷粗圓(P)", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_C1.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_C1.Location = new System.Drawing.Point(11, 270);
            this.Btn_C1.Name = "Btn_C1";
            this.Btn_C1.Size = new System.Drawing.Size(100, 100);
            this.Btn_C1.TabIndex = 8;
            this.Btn_C1.UseVisualStyleBackColor = false;
            this.Btn_C1.Click += new System.EventHandler(this.button_click);
            // 
            // frm_Lab10_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.Btn_C3);
            this.Controls.Add(this.Btn_C2);
            this.Controls.Add(this.Btn_C1);
            this.Controls.Add(this.Btn_B3);
            this.Controls.Add(this.Btn_B2);
            this.Controls.Add(this.Btn_B1);
            this.Controls.Add(this.Btn_A3);
            this.Controls.Add(this.Btn_A2);
            this.Controls.Add(this.Btn_A1);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Lab10_TicTacToe";
            this.Text = "TicTacToe";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tSBtn_restart;
        private System.Windows.Forms.ToolStripButton tSBtn_Exit;
        private System.Windows.Forms.Button Btn_A1;
        private System.Windows.Forms.Button Btn_A2;
        private System.Windows.Forms.Button Btn_A3;
        private System.Windows.Forms.Button Btn_B3;
        private System.Windows.Forms.Button Btn_B2;
        private System.Windows.Forms.Button Btn_B1;
        private System.Windows.Forms.Button Btn_C3;
        private System.Windows.Forms.Button Btn_C2;
        private System.Windows.Forms.Button Btn_C1;
    }
}