
namespace Lab_MSIT143_06
{
    partial class frm_Lab12_Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lab12_Notepad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟新檔 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔 = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存檔案 = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.預覽列印 = new System.Windows.Forms.ToolStripMenuItem();
            this.列印 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束 = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原 = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下 = new System.Windows.Forms.ToolStripMenuItem();
            this.複製 = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上 = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.尋找 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.全選 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂 = new System.Windows.Forms.ToolStripMenuItem();
            this.選項 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行 = new System.Windows.Forms.ToolStripMenuItem();
            this.字型 = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色 = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幫助 = new System.Windows.Forms.ToolStripMenuItem();
            this.關於 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtn_Add = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Open = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Undo = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Cut = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Copy = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_About = new System.Windows.Forms.ToolStripButton();
            this.txt_ReadWrite_Temp = new System.Windows.Forms.TextBox();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.directorySearcher = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.格式MToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(904, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟新檔,
            this.開啟舊檔,
            this.儲存檔案,
            this.另存新檔,
            this.toolStripSeparator1,
            this.預覽列印,
            this.列印,
            this.toolStripSeparator2,
            this.結束});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.檔案FToolStripMenuItem.Text = "檔案 (F)";
            // 
            // 開啟新檔
            // 
            this.開啟新檔.Image = ((System.Drawing.Image)(resources.GetObject("開啟新檔.Image")));
            this.開啟新檔.Name = "開啟新檔";
            this.開啟新檔.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.開啟新檔.Size = new System.Drawing.Size(270, 24);
            this.開啟新檔.Text = "開啟新檔 (N)";
            this.開啟新檔.Click += new System.EventHandler(this.開啟新檔_Click);
            // 
            // 開啟舊檔
            // 
            this.開啟舊檔.Image = ((System.Drawing.Image)(resources.GetObject("開啟舊檔.Image")));
            this.開啟舊檔.Name = "開啟舊檔";
            this.開啟舊檔.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟舊檔.Size = new System.Drawing.Size(270, 24);
            this.開啟舊檔.Text = "開啟舊檔 (O)";
            this.開啟舊檔.Click += new System.EventHandler(this.開啟舊檔_Click);
            // 
            // 儲存檔案
            // 
            this.儲存檔案.Image = ((System.Drawing.Image)(resources.GetObject("儲存檔案.Image")));
            this.儲存檔案.Name = "儲存檔案";
            this.儲存檔案.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存檔案.Size = new System.Drawing.Size(270, 24);
            this.儲存檔案.Text = "儲存檔案 (S)";
            this.儲存檔案.Click += new System.EventHandler(this.儲存檔案_Click);
            // 
            // 另存新檔
            // 
            this.另存新檔.Image = ((System.Drawing.Image)(resources.GetObject("另存新檔.Image")));
            this.另存新檔.Name = "另存新檔";
            this.另存新檔.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.另存新檔.Size = new System.Drawing.Size(270, 24);
            this.另存新檔.Text = "另存新檔 (A)";
            this.另存新檔.Click += new System.EventHandler(this.另存新檔_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // 預覽列印
            // 
            this.預覽列印.Image = ((System.Drawing.Image)(resources.GetObject("預覽列印.Image")));
            this.預覽列印.Name = "預覽列印";
            this.預覽列印.Size = new System.Drawing.Size(270, 24);
            this.預覽列印.Text = "預覽列印 (V)";
            this.預覽列印.Click += new System.EventHandler(this.預覽列印_Click);
            // 
            // 列印
            // 
            this.列印.Image = ((System.Drawing.Image)(resources.GetObject("列印.Image")));
            this.列印.Name = "列印";
            this.列印.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印.Size = new System.Drawing.Size(270, 24);
            this.列印.Text = "列印 (P)";
            this.列印.Click += new System.EventHandler(this.列印_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // 結束
            // 
            this.結束.Image = ((System.Drawing.Image)(resources.GetObject("結束.Image")));
            this.結束.Name = "結束";
            this.結束.Size = new System.Drawing.Size(270, 24);
            this.結束.Text = "結束 (X)";
            this.結束.Click += new System.EventHandler(this.結束_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原,
            this.取消復原,
            this.toolStripSeparator3,
            this.剪下,
            this.複製,
            this.貼上,
            this.刪除,
            this.toolStripSeparator4,
            this.尋找,
            this.toolStripSeparator5,
            this.全選});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.編輯EToolStripMenuItem.Text = "編輯 (E)";
            // 
            // 復原
            // 
            this.復原.Image = ((System.Drawing.Image)(resources.GetObject("復原.Image")));
            this.復原.Name = "復原";
            this.復原.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原.Size = new System.Drawing.Size(224, 24);
            this.復原.Text = "復原 (U)";
            this.復原.Click += new System.EventHandler(this.復原_Click);
            // 
            // 取消復原
            // 
            this.取消復原.Image = ((System.Drawing.Image)(resources.GetObject("取消復原.Image")));
            this.取消復原.Name = "取消復原";
            this.取消復原.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原.Size = new System.Drawing.Size(224, 24);
            this.取消復原.Text = "取消復原 (R)";
            this.取消復原.Click += new System.EventHandler(this.取消復原_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // 剪下
            // 
            this.剪下.Image = ((System.Drawing.Image)(resources.GetObject("剪下.Image")));
            this.剪下.Name = "剪下";
            this.剪下.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下.Size = new System.Drawing.Size(224, 24);
            this.剪下.Text = "剪下 (T)";
            this.剪下.Click += new System.EventHandler(this.剪下_Click);
            // 
            // 複製
            // 
            this.複製.Image = ((System.Drawing.Image)(resources.GetObject("複製.Image")));
            this.複製.Name = "複製";
            this.複製.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製.Size = new System.Drawing.Size(224, 24);
            this.複製.Text = "複製 (C)";
            this.複製.Click += new System.EventHandler(this.複製_Click);
            // 
            // 貼上
            // 
            this.貼上.Image = ((System.Drawing.Image)(resources.GetObject("貼上.Image")));
            this.貼上.Name = "貼上";
            this.貼上.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上.Size = new System.Drawing.Size(224, 24);
            this.貼上.Text = "貼上 (P)";
            this.貼上.Click += new System.EventHandler(this.貼上_Click);
            // 
            // 刪除
            // 
            this.刪除.Image = ((System.Drawing.Image)(resources.GetObject("刪除.Image")));
            this.刪除.Name = "刪除";
            this.刪除.Size = new System.Drawing.Size(224, 24);
            this.刪除.Text = "刪除 (L)";
            this.刪除.Click += new System.EventHandler(this.刪除_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // 尋找
            // 
            this.尋找.Image = ((System.Drawing.Image)(resources.GetObject("尋找.Image")));
            this.尋找.Name = "尋找";
            this.尋找.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.尋找.Size = new System.Drawing.Size(224, 24);
            this.尋找.Text = "尋找 (F)";
            this.尋找.Click += new System.EventHandler(this.尋找_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // 全選
            // 
            this.全選.Image = ((System.Drawing.Image)(resources.GetObject("全選.Image")));
            this.全選.Name = "全選";
            this.全選.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全選.Size = new System.Drawing.Size(224, 24);
            this.全選.Text = "全選( A)";
            this.全選.Click += new System.EventHandler(this.全選_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂,
            this.選項});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.工具TToolStripMenuItem.Text = "工具 (T)";
            // 
            // 自訂
            // 
            this.自訂.Name = "自訂";
            this.自訂.Size = new System.Drawing.Size(137, 24);
            this.自訂.Text = "自訂 (C)";
            this.自訂.Click += new System.EventHandler(this.自訂_Click);
            // 
            // 選項
            // 
            this.選項.Image = ((System.Drawing.Image)(resources.GetObject("選項.Image")));
            this.選項.Name = "選項";
            this.選項.Size = new System.Drawing.Size(137, 24);
            this.選項.Text = "選項 (O)";
            this.選項.Click += new System.EventHandler(this.選項_Click);
            // 
            // 格式MToolStripMenuItem
            // 
            this.格式MToolStripMenuItem.Checked = true;
            this.格式MToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.格式MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自動換行,
            this.字型,
            this.顏色});
            this.格式MToolStripMenuItem.Name = "格式MToolStripMenuItem";
            this.格式MToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.格式MToolStripMenuItem.Text = "格式 (M)";
            // 
            // 自動換行
            // 
            this.自動換行.Checked = true;
            this.自動換行.CheckState = System.Windows.Forms.CheckState.Checked;
            this.自動換行.Name = "自動換行";
            this.自動換行.Size = new System.Drawing.Size(172, 24);
            this.自動換行.Text = "自動換行 (W)";
            this.自動換行.Click += new System.EventHandler(this.自動換行_Click);
            // 
            // 字型
            // 
            this.字型.Image = ((System.Drawing.Image)(resources.GetObject("字型.Image")));
            this.字型.Name = "字型";
            this.字型.Size = new System.Drawing.Size(172, 24);
            this.字型.Text = "字型 (F)...";
            this.字型.Click += new System.EventHandler(this.字型_Click);
            // 
            // 顏色
            // 
            this.顏色.Image = ((System.Drawing.Image)(resources.GetObject("顏色.Image")));
            this.顏色.Name = "顏色";
            this.顏色.Size = new System.Drawing.Size(172, 24);
            this.顏色.Text = "顏色 (C)...";
            this.顏色.Click += new System.EventHandler(this.顏色_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.幫助,
            this.關於});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.說明HToolStripMenuItem.Text = "說明 (H)";
            // 
            // 幫助
            // 
            this.幫助.Image = ((System.Drawing.Image)(resources.GetObject("幫助.Image")));
            this.幫助.Name = "幫助";
            this.幫助.Size = new System.Drawing.Size(136, 24);
            this.幫助.Text = "幫助 (H)";
            this.幫助.Click += new System.EventHandler(this.幫助_Click);
            // 
            // 關於
            // 
            this.關於.Image = ((System.Drawing.Image)(resources.GetObject("關於.Image")));
            this.關於.Name = "關於";
            this.關於.Size = new System.Drawing.Size(136, 24);
            this.關於.Text = "關於 (A)";
            this.關於.Click += new System.EventHandler(this.關於_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn_Add,
            this.toolBtn_Open,
            this.toolBtn_Save,
            this.toolStripSeparator7,
            this.toolBtn_Print,
            this.toolStripSeparator8,
            this.toolBtn_Undo,
            this.toolBtn_Redo,
            this.toolStripSeparator11,
            this.toolBtn_Cut,
            this.toolBtn_Copy,
            this.toolBtn_Paste,
            this.toolStripSeparator9,
            this.toolBtn_Search,
            this.toolStripSeparator10,
            this.toolBtn_About});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(904, 62);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtn_Add
            // 
            this.toolBtn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Add.Image")));
            this.toolBtn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Add.Name = "toolBtn_Add";
            this.toolBtn_Add.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Add.Text = "開啟新檔 (N)";
            this.toolBtn_Add.Click += new System.EventHandler(this.開啟新檔_Click);
            // 
            // toolBtn_Open
            // 
            this.toolBtn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Open.Image")));
            this.toolBtn_Open.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Open.Name = "toolBtn_Open";
            this.toolBtn_Open.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Open.Text = "開啟舊檔 (O)";
            this.toolBtn_Open.Click += new System.EventHandler(this.開啟舊檔_Click);
            // 
            // toolBtn_Save
            // 
            this.toolBtn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Save.Image")));
            this.toolBtn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Save.Name = "toolBtn_Save";
            this.toolBtn_Save.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Save.Text = "儲存檔案 (S)";
            this.toolBtn_Save.Click += new System.EventHandler(this.儲存檔案_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 62);
            // 
            // toolBtn_Print
            // 
            this.toolBtn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Print.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Print.Image")));
            this.toolBtn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Print.Name = "toolBtn_Print";
            this.toolBtn_Print.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Print.Text = "列印 (P)";
            this.toolBtn_Print.Click += new System.EventHandler(this.列印_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 62);
            // 
            // toolBtn_Undo
            // 
            this.toolBtn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Undo.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Undo.Image")));
            this.toolBtn_Undo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Undo.Name = "toolBtn_Undo";
            this.toolBtn_Undo.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Undo.Text = "復原 (U)";
            this.toolBtn_Undo.Click += new System.EventHandler(this.復原_Click);
            // 
            // toolBtn_Redo
            // 
            this.toolBtn_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Redo.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Redo.Image")));
            this.toolBtn_Redo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Redo.Name = "toolBtn_Redo";
            this.toolBtn_Redo.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Redo.Text = "取消復原 (R)";
            this.toolBtn_Redo.Click += new System.EventHandler(this.取消復原_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 62);
            // 
            // toolBtn_Cut
            // 
            this.toolBtn_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Cut.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Cut.Image")));
            this.toolBtn_Cut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Cut.Name = "toolBtn_Cut";
            this.toolBtn_Cut.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Cut.Text = "剪下 (T)";
            this.toolBtn_Cut.ToolTipText = "剪下 (T)";
            this.toolBtn_Cut.Click += new System.EventHandler(this.剪下_Click);
            // 
            // toolBtn_Copy
            // 
            this.toolBtn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Copy.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Copy.Image")));
            this.toolBtn_Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Copy.Name = "toolBtn_Copy";
            this.toolBtn_Copy.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Copy.Text = "複製 (C)";
            this.toolBtn_Copy.Click += new System.EventHandler(this.複製_Click);
            // 
            // toolBtn_Paste
            // 
            this.toolBtn_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Paste.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Paste.Image")));
            this.toolBtn_Paste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Paste.Name = "toolBtn_Paste";
            this.toolBtn_Paste.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Paste.Text = "貼上 (P)";
            this.toolBtn_Paste.Click += new System.EventHandler(this.貼上_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 62);
            // 
            // toolBtn_Search
            // 
            this.toolBtn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Search.Image")));
            this.toolBtn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Search.Name = "toolBtn_Search";
            this.toolBtn_Search.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_Search.Text = "尋找 (F)";
            this.toolBtn_Search.Click += new System.EventHandler(this.尋找_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 62);
            // 
            // toolBtn_About
            // 
            this.toolBtn_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_About.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_About.Image")));
            this.toolBtn_About.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_About.Name = "toolBtn_About";
            this.toolBtn_About.Size = new System.Drawing.Size(54, 59);
            this.toolBtn_About.Text = "關於 (A)";
            this.toolBtn_About.Click += new System.EventHandler(this.關於_Click);
            // 
            // txt_ReadWrite_Temp
            // 
            this.txt_ReadWrite_Temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ReadWrite_Temp.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_ReadWrite_Temp.Location = new System.Drawing.Point(831, 95);
            this.txt_ReadWrite_Temp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ReadWrite_Temp.Multiline = true;
            this.txt_ReadWrite_Temp.Name = "txt_ReadWrite_Temp";
            this.txt_ReadWrite_Temp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ReadWrite_Temp.Size = new System.Drawing.Size(61, 33);
            this.txt_ReadWrite_Temp.TabIndex = 2;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.richTextBox.Location = new System.Drawing.Point(12, 95);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox.Size = new System.Drawing.Size(880, 496);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // directorySearcher
            // 
            this.directorySearcher.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frm_Lab12_Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.txt_ReadWrite_Temp);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Lab12_Notepad";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.frm_Lab12_Notepad_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟新檔;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊檔;
        private System.Windows.Forms.ToolStripMenuItem 儲存檔案;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印;
        private System.Windows.Forms.ToolStripMenuItem 列印;
        private System.Windows.Forms.ToolStripMenuItem 結束;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原;
        private System.Windows.Forms.ToolStripMenuItem 取消復原;
        private System.Windows.Forms.ToolStripMenuItem 剪下;
        private System.Windows.Forms.ToolStripMenuItem 複製;
        private System.Windows.Forms.ToolStripMenuItem 貼上;
        private System.Windows.Forms.ToolStripMenuItem 刪除;
        private System.Windows.Forms.ToolStripMenuItem 尋找;
        private System.Windows.Forms.ToolStripMenuItem 全選;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動換行;
        private System.Windows.Forms.ToolStripMenuItem 字型;
        private System.Windows.Forms.ToolStripMenuItem 顏色;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 自訂;
        private System.Windows.Forms.ToolStripMenuItem 選項;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolBtn_Add;
        private System.Windows.Forms.ToolStripButton toolBtn_Open;
        private System.Windows.Forms.ToolStripButton toolBtn_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolBtn_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolBtn_Cut;
        private System.Windows.Forms.ToolStripButton toolBtn_Copy;
        private System.Windows.Forms.ToolStripButton toolBtn_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolBtn_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolBtn_About;
        private System.Windows.Forms.ToolStripMenuItem 幫助;
        private System.Windows.Forms.TextBox txt_ReadWrite_Temp;
        private System.Windows.Forms.ToolStripButton toolBtn_Undo;
        private System.Windows.Forms.ToolStripButton toolBtn_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.DirectoryServices.DirectorySearcher directorySearcher;
    }
}