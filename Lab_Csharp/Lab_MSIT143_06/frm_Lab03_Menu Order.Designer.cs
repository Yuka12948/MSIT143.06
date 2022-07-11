
namespace Lab_MSIT143_06
{
    partial class frm_Lab03_MenuOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab03_MenuOrder));
            this.Gbox_Menu = new System.Windows.Forms.GroupBox();
            this.btn_Liquor = new System.Windows.Forms.Button();
            this.btn_Sake = new System.Windows.Forms.Button();
            this.btn_Wine = new System.Windows.Forms.Button();
            this.btn_Beer = new System.Windows.Forms.Button();
            this.Gbox_List = new System.Windows.Forms.GroupBox();
            this.lab_List = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.Gbox_Total = new System.Windows.Forms.GroupBox();
            this.lab_Total = new System.Windows.Forms.Label();
            this.Gbox_Pay = new System.Windows.Forms.GroupBox();
            this.lab_10off = new System.Windows.Forms.Label();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_CreditCard = new System.Windows.Forms.Button();
            this.Gbox_Menu.SuspendLayout();
            this.Gbox_List.SuspendLayout();
            this.Gbox_Total.SuspendLayout();
            this.Gbox_Pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_Menu
            // 
            this.Gbox_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Menu.Controls.Add(this.btn_Liquor);
            this.Gbox_Menu.Controls.Add(this.btn_Sake);
            this.Gbox_Menu.Controls.Add(this.btn_Wine);
            this.Gbox_Menu.Controls.Add(this.btn_Beer);
            this.Gbox_Menu.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.Gbox_Menu.Location = new System.Drawing.Point(14, 16);
            this.Gbox_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Menu.Name = "Gbox_Menu";
            this.Gbox_Menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Menu.Size = new System.Drawing.Size(279, 564);
            this.Gbox_Menu.TabIndex = 0;
            this.Gbox_Menu.TabStop = false;
            this.Gbox_Menu.Text = "酒單 Menu";
            // 
            // btn_Liquor
            // 
            this.btn_Liquor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Liquor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Liquor.BackgroundImage")));
            this.btn_Liquor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Liquor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Liquor.ForeColor = System.Drawing.Color.Black;
            this.btn_Liquor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Liquor.Location = new System.Drawing.Point(16, 303);
            this.btn_Liquor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Liquor.Name = "btn_Liquor";
            this.btn_Liquor.Size = new System.Drawing.Size(120, 245);
            this.btn_Liquor.TabIndex = 3;
            this.btn_Liquor.Tag = "";
            this.btn_Liquor.Text = "白酒 LIQUOR NT320";
            this.btn_Liquor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Liquor.UseVisualStyleBackColor = false;
            this.btn_Liquor.Click += new System.EventHandler(this.btn_Liquor_Click);
            // 
            // btn_Sake
            // 
            this.btn_Sake.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Sake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sake.BackgroundImage")));
            this.btn_Sake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sake.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Sake.ForeColor = System.Drawing.Color.Black;
            this.btn_Sake.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sake.Location = new System.Drawing.Point(145, 48);
            this.btn_Sake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sake.Name = "btn_Sake";
            this.btn_Sake.Size = new System.Drawing.Size(120, 245);
            this.btn_Sake.TabIndex = 1;
            this.btn_Sake.Tag = "";
            this.btn_Sake.Text = "清酒 SAKE NT500";
            this.btn_Sake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sake.UseVisualStyleBackColor = false;
            this.btn_Sake.Click += new System.EventHandler(this.btn_Sake_Click);
            // 
            // btn_Wine
            // 
            this.btn_Wine.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Wine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Wine.BackgroundImage")));
            this.btn_Wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Wine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Wine.ForeColor = System.Drawing.Color.Black;
            this.btn_Wine.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Wine.Location = new System.Drawing.Point(145, 303);
            this.btn_Wine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Wine.Name = "btn_Wine";
            this.btn_Wine.Size = new System.Drawing.Size(120, 245);
            this.btn_Wine.TabIndex = 2;
            this.btn_Wine.Tag = "";
            this.btn_Wine.Text = "紅酒 WINE NT320";
            this.btn_Wine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Wine.UseVisualStyleBackColor = false;
            this.btn_Wine.Click += new System.EventHandler(this.btn_Wine_Click);
            // 
            // btn_Beer
            // 
            this.btn_Beer.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Beer.BackgroundImage")));
            this.btn_Beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Beer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Beer.ForeColor = System.Drawing.Color.Black;
            this.btn_Beer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Beer.Location = new System.Drawing.Point(16, 48);
            this.btn_Beer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Beer.Name = "btn_Beer";
            this.btn_Beer.Size = new System.Drawing.Size(120, 245);
            this.btn_Beer.TabIndex = 0;
            this.btn_Beer.Tag = "";
            this.btn_Beer.Text = "啤酒 BEER NT120";
            this.btn_Beer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Beer.UseVisualStyleBackColor = false;
            this.btn_Beer.Click += new System.EventHandler(this.btn_Beer_Click);
            // 
            // Gbox_List
            // 
            this.Gbox_List.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_List.Controls.Add(this.lab_List);
            this.Gbox_List.Controls.Add(this.btn_Clear);
            this.Gbox_List.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.Gbox_List.Location = new System.Drawing.Point(609, 16);
            this.Gbox_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_List.Name = "Gbox_List";
            this.Gbox_List.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_List.Size = new System.Drawing.Size(281, 564);
            this.Gbox_List.TabIndex = 1;
            this.Gbox_List.TabStop = false;
            this.Gbox_List.Text = "購物清單 List";
            // 
            // lab_List
            // 
            this.lab_List.AutoEllipsis = true;
            this.lab_List.BackColor = System.Drawing.Color.White;
            this.lab_List.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lab_List.Location = new System.Drawing.Point(15, 48);
            this.lab_List.Name = "lab_List";
            this.lab_List.Padding = new System.Windows.Forms.Padding(0, 13, 3, 0);
            this.lab_List.Size = new System.Drawing.Size(251, 442);
            this.lab_List.TabIndex = 2;
            this.lab_List.Text = "尚未點餐";
            this.lab_List.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(14, 505);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(253, 43);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清除 Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Gbox_Total
            // 
            this.Gbox_Total.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Total.Controls.Add(this.lab_Total);
            this.Gbox_Total.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.Gbox_Total.Location = new System.Drawing.Point(299, 16);
            this.Gbox_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Total.Name = "Gbox_Total";
            this.Gbox_Total.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Total.Size = new System.Drawing.Size(304, 131);
            this.Gbox_Total.TabIndex = 2;
            this.Gbox_Total.TabStop = false;
            this.Gbox_Total.Text = "總金額 Total Price";
            // 
            // lab_Total
            // 
            this.lab_Total.BackColor = System.Drawing.Color.Black;
            this.lab_Total.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.lab_Total.ForeColor = System.Drawing.Color.White;
            this.lab_Total.Location = new System.Drawing.Point(21, 48);
            this.lab_Total.Name = "lab_Total";
            this.lab_Total.Size = new System.Drawing.Size(260, 56);
            this.lab_Total.TabIndex = 0;
            this.lab_Total.Text = "NT$ 0";
            this.lab_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Gbox_Pay
            // 
            this.Gbox_Pay.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gbox_Pay.Controls.Add(this.lab_10off);
            this.Gbox_Pay.Controls.Add(this.btn_Cash);
            this.Gbox_Pay.Controls.Add(this.btn_CreditCard);
            this.Gbox_Pay.Font = new System.Drawing.Font("微軟正黑體", 15F);
            this.Gbox_Pay.Location = new System.Drawing.Point(299, 155);
            this.Gbox_Pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Pay.Name = "Gbox_Pay";
            this.Gbox_Pay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gbox_Pay.Size = new System.Drawing.Size(304, 130);
            this.Gbox_Pay.TabIndex = 3;
            this.Gbox_Pay.TabStop = false;
            this.Gbox_Pay.Text = "付款方式 Pay";
            // 
            // lab_10off
            // 
            this.lab_10off.AutoSize = true;
            this.lab_10off.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.lab_10off.Location = new System.Drawing.Point(157, 96);
            this.lab_10off.Name = "lab_10off";
            this.lab_10off.Size = new System.Drawing.Size(127, 19);
            this.lab_10off.TabIndex = 2;
            this.lab_10off.Text = "信用卡付款 享9折";
            // 
            // btn_Cash
            // 
            this.btn_Cash.Location = new System.Drawing.Point(20, 44);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(119, 45);
            this.btn_Cash.TabIndex = 0;
            this.btn_Cash.Text = "現金";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_CreditCard
            // 
            this.btn_CreditCard.Location = new System.Drawing.Point(162, 44);
            this.btn_CreditCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreditCard.Name = "btn_CreditCard";
            this.btn_CreditCard.Size = new System.Drawing.Size(119, 45);
            this.btn_CreditCard.TabIndex = 1;
            this.btn_CreditCard.Text = "信用卡";
            this.btn_CreditCard.UseVisualStyleBackColor = true;
            this.btn_CreditCard.Click += new System.EventHandler(this.btn_CreditCard_Click);
            // 
            // frm_Lab03_MenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.Gbox_Pay);
            this.Controls.Add(this.Gbox_Total);
            this.Controls.Add(this.Gbox_List);
            this.Controls.Add(this.Gbox_Menu);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab03_MenuOrder";
            this.Text = "Bar 點餐系統";
            this.Gbox_Menu.ResumeLayout(false);
            this.Gbox_List.ResumeLayout(false);
            this.Gbox_Total.ResumeLayout(false);
            this.Gbox_Pay.ResumeLayout(false);
            this.Gbox_Pay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_Menu;
        private System.Windows.Forms.Button btn_Liquor;
        private System.Windows.Forms.Button btn_Sake;
        private System.Windows.Forms.Button btn_Wine;
        private System.Windows.Forms.Button btn_Beer;
        private System.Windows.Forms.GroupBox Gbox_List;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox Gbox_Total;
        private System.Windows.Forms.GroupBox Gbox_Pay;
        private System.Windows.Forms.Button btn_CreditCard;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Label lab_10off;
        private System.Windows.Forms.Label lab_Total;
        internal System.Windows.Forms.Label lab_List;
    }
}