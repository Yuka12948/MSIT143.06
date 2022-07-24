using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MSIT143_06
{
    public partial class frm_Lab12_Notepad : Form
    {
        private OpenFileDialog OPfileDialog = new OpenFileDialog();
        private SaveFileDialog SVfileDialog = new SaveFileDialog();
        private bool richboxTextHasChanged = false;

        public frm_Lab12_Notepad()
        {
            InitializeComponent();
        }

        private void frm_Lab12_Notepad_Load(object sender, EventArgs e)
        {
            OPfileDialog.FileName = "";
            OPfileDialog.Multiselect = false; //該值確定是否可以選擇多個檔案
            OPfileDialog.Title = "開啟檔案";
            OPfileDialog.Filter = "所有檔案(*.*)|*.*|文字文件(*.txt)|*.txt"; //設定要選擇的檔案的型別
            OPfileDialog.FilterIndex = 2;

            SVfileDialog.Title = "另存新檔";
            SVfileDialog.Filter = "所有檔案(*.*)|*.*|文字文件(*.txt)|*.txt";
            SVfileDialog.FilterIndex = 2;
        }

        private void 開啟新檔_Click(object sender, EventArgs e)
        {
            //判定內容有無修改 有>>提示是否儲存 無 >> Clear
            if (OPfileDialog.FileName != "" && richboxTextHasChanged == true && MessageBox.Show($"要儲存對 {Name} 內容的變更嗎?", "資訊提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //儲存
                richTextBox.SaveFile(OPfileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                //初始化 Clear
                OPfileDialog.FileName = "";
                this.Text = "記事本";
                this.richTextBox.Clear();
                this.richboxTextHasChanged = false;
            }
        }

        private void 開啟舊檔_Click(object sender, EventArgs e)
        {
            OPfileDialog.ShowDialog(); //選擇開啟文字檔案
            if (OPfileDialog.FileName != "")
            {
                //將文字檔案裡面的內容載入到介面內
                richTextBox.LoadFile(OPfileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = OPfileDialog.FileName + "-記事本";
                #region
                /* 原textbox程式碼
                var fileContent = string.Empty;
                var filePath = string.Empty;

                // 1.選擇檔案用 OpenDialog
                OpenFileDialog OPfileDialog = new OpenFileDialog();
                //OPfileDialog.InitialDirectory = "指定開啟路徑";
                OPfileDialog.Multiselect = false; //該值確定是否可以選擇多個檔案
                OPfileDialog.Title = "開啟檔案";
                OPfileDialog.Filter = "所有檔案(*.*)|*.*|文字文件(*.txt)|*.txt"; //設定要選擇的檔案的型別
                OPfileDialog.FilterIndex = 2;
                //OPfileDialog.RestoreDirectory = true;
                if (OPfileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = OPfileDialog.FileName;//返回檔案的完整路徑
                    filePath = OPfileDialog.FileName; //獲取指定文件的路徑
                    var fileStream = OPfileDialog.OpenFile(); //將文件內容讀入

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        txt_ReadWrite.Text = reader.ReadToEnd();
                    }
                    this.Text = Path.GetFileName(filePath);
                }
                */
                #endregion
            }
        }

        private void 儲存檔案_Click(object sender, EventArgs e)
        {
            if (OPfileDialog.FileName != "")
            {
                richTextBox.SaveFile(OPfileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                if (SVfileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(SVfileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }                 
            //MessageBox.Show("請先開啟文字檔案", "資訊提示", MessageBoxButtons.OK);
            #region
            /*
            FileStream fs = new FileStream(this.Text, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(txt_ReadWrite.Text);
            sw.Close();
            fs.Close();
            */
            #endregion
        }

        //string words = "";
        private void 另存新檔_Click(object sender, EventArgs e)
        {
            if (SVfileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(SVfileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            #region
            //words = richTextBox.Text;

            //SaveFileDialog SVfileDialog = new SaveFileDialog();
            //SVfileDialog.Title = "另存新檔";
            //SVfileDialog.Filter = "所有檔案(*.*)|*.*|文字文件(*.txt)|*.txt";
            //SVfileDialog.FilterIndex = 2;

            //if (SVfileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var filePath = SVfileDialog.FileName;
            //    FileStream fs = new FileStream(filePath, FileMode.Create);
            //    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            //    sw.Write(richTextBox.Text);
            //    sw.Close();
            //    fs.Close();
            //}
            #endregion
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void 預覽列印_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void 列印_Click(object sender, EventArgs e)
        {
            this.printDialog.Document = this.printDocument;
            this.printDialog.PrinterSettings = this.pageSetupDialog.PrinterSettings;
            if (this.printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.printDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "wrongMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 結束_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void 取消復原_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void 剪下_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void 複製_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
            #region
            //Clipboard.SetDataObject(txt_ReadWrite.SelectedText);
            #endregion
        }

        private void 貼上_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
            #region
            /*
            //貼在滑鼠游標點選的指定位置
            string text = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
            int selectIndex = txt_ReadWrite.SelectionStart;
            txt_ReadWrite.Text = txt_ReadWrite.Text.Insert(selectIndex, text);
            //todo 貼上後游標維持原位
            //txt_ReadWrite.Select(txt_ReadWrite.Text, 0);
            //textBox1.Select(textBox1.SelectionStart, 0);
            */
            #endregion
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = "";
        }

        private void 尋找_Click(object sender, EventArgs e)
        {
            directorySearcher.SearchScope = System.DirectoryServices.SearchScope.Subtree;
            ////SqlDataSource1.SelectCommand = "SELECT [Title], [Content], [Date], [Id] FROM [Table]";
            //if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            //{
            //    SqlDataSource1.SelectCommand += "WHERE [Content] LIKE '%'+@search+'%'";
            //    SqlDataSource1.SelectParameters.Add("search", txtSearch.Text);
            //}
        }
        
        private void 全選_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void 自訂_Click(object sender, EventArgs e)
        {

        }

        private void 選項_Click(object sender, EventArgs e)
        {

        }

        bool checkState = true; //true = 有勾選 false = 沒勾選
        private void 自動換行_Click(object sender, EventArgs e)
        {
            if (checkState == true)
            {
                自動換行.CheckState = CheckState.Unchecked;
                richTextBox.Multiline = true;
                richTextBox.WordWrap = false;
                richTextBox.ScrollBars = RichTextBoxScrollBars.Horizontal;

            }
            else if (checkState == false)
            {
                自動換行.CheckState = CheckState.Checked;
                richTextBox.Multiline = true;
                richTextBox.WordWrap = true;
                richTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            checkState = !checkState;
        }

        private void 字型_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
        }

        private void 顏色_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextBox.ForeColor =colorDialog.Color;
        }

        private void 幫助_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zh.wikipedia.org/zh-tw/%E8%A8%98%E4%BA%8B%E6%9C%AC");
        }

        private void 關於_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"MSIT143_06 Yuka ver. Notepad\n版本 0.0.1 (C# 01.07.2022)\n" +
                            $"Yuka. 著作權所有，敬請安心使用。\n\n" +
                            $"使用者介面依照個人喜好設計，不好用也沒得抱怨，謝謝。", "關於 Notepad");
        }

        #region
        //參考網頁(全功能) https://iter01.com/144183.html
        //參考網頁(註解詳細) https://tw511.com/a/01/29862.html
        // 參考網頁(Richtextbox) https://www.796t.com/content/1549223310.html
        #endregion
    }
}
