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
using System.Xml.Serialization;

namespace NCKUCS
{
    public partial class ScraptBook : Form
    {
        private int MARGIN = 10;
        private Color autoSaveColor = Color.LightGray;
        private Color unAutoSaveColor = Color.White;
        private string filePath = "../../res/scraptBook.rtf"; 
        private int AutoSaveInterval = 60000; 
        /// 
        
        private bool isSave = true;
        private bool AutoSave = true;
        private bool isNew = false;
        private Timer AutoSaveTimer; 
        public ScraptBook()
        {
            InitializeComponent();
        }

        private void ScraptBook_Load(object sender, EventArgs e)
        {
            Anchor_Object();
            if (!File.Exists(filePath))
            {
                using (RichTextBox tmp = new RichTextBox())
                {
                    tmp.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
            }

            textPlace.LoadFile(filePath, RichTextBoxStreamType.RichText);

            btnAutoSave.BackColor = AutoSave ? autoSaveColor : unAutoSaveColor;

            AutoSaveTimer = new Timer();
            AutoSaveTimer.Interval = AutoSaveInterval;
            AutoSaveTimer.Tick += AutoSaveTimer_Tick;
            AutoSaveTimer.Start();
            //Console.WriteLine(textPlace.Font);
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            if (!isSave && !isNew && AutoSave && filePath != "")
            {
                SaveFile();
                labelInfo.Text = "auto save successfully";
            }
        }

        // Bold Text
        private void BoldItem_Click(object sender, EventArgs e)
        {
            Font currentFont = textPlace.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
            textPlace.SelectionFont = new Font(currentFont, newStyle);
        }

        // Italic Text
        private void ItalicsItem_Click(object sender, EventArgs e)
        {
            Font currentFont = textPlace.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
            textPlace.SelectionFont = new Font(currentFont, newStyle);
        }

        // Underline Text
        private void UnderlineItem_Click(object sender, EventArgs e)
        {
            Font currentFont = textPlace.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
            textPlace.SelectionFont = new Font(currentFont, newStyle);
        }

        private void ScraptBook_Resize(object sender, EventArgs e)
        {
            Anchor_Object();
        }

        // Change all object location after resize form
        private void Anchor_Object()
        {
            btnAutoSave.Left = (this.ClientSize.Width - btnAutoSave.Width - MARGIN);
            btnAutoSave.Top = (this.ClientSize.Height - btnAutoSave.Height - MARGIN);
            labelInfo.Left = MARGIN;
            labelInfo.Width = (this.ClientSize.Width - btnAutoSave.Width - 2 * MARGIN);
            labelInfo.Top = btnAutoSave.Top;
            textPlace.Height = (this.ClientSize.Height - labelInfo.Height - menu.Height - MARGIN);
            textPlace.Width = (this.ClientSize.Width - 2 * MARGIN);
            textPlace.Left = MARGIN;
        }

        // auto save button click
        private void btnAutoSave_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(AutoSave);
            if (isNew)
            {
                DialogResult result = DialogResult.Yes;
                result = MessageBox.Show("需要先儲存檔案才能開啟auto save", "未儲存的檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveNewFile();
                }
                else
                {
                    return;
                }
            }
            else
            {
                AutoSave = !AutoSave;
                btnAutoSave.BackColor = AutoSave ? autoSaveColor : unAutoSaveColor;
            }

            labelInfo.Text = AutoSave ? "Auto Save On" : "Auto Save Off";
            if (AutoSave) AutoSaveTimer.Start();
            else AutoSaveTimer.Stop();
        }

        private void OpenFileItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = DialogResult.Yes;
                result = MessageBox.Show("尚未儲存檔案，是否儲存檔案", "未儲存的檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (isNew) SaveNewFile();
                    else SaveFile();
                }
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RTF 檔案 (*.rtf)|*.rtf|純文字檔 (*.txt)|*.txt";
                openFileDialog.InitialDirectory = Path.GetFullPath("../../res");
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    if (Path.GetExtension(filePath).ToLower() == ".rtf")
                    {
                        textPlace.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        textPlace.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    }

                    isNew = false;
                    isSave = true;

                    if (!AutoSave)
                    {
                        AutoSave = true;
                        btnAutoSave.BackColor = autoSaveColor;
                        AutoSaveTimer.Start();
                    }
                }
            }
        }
        private void OpenNewItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (!isSave)
            {
                result = MessageBox.Show("檔案尚未儲存，是否要儲存檔案", "未儲存的變更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (result == DialogResult.Yes)
            {
                if (isNew) SaveNewFile();
                else SaveFile();
            }
            
            InitTextPlace();
            filePath = "";

            isNew = true;
            isSave = true;

            if (AutoSave)
            {
                AutoSave = false;
                btnAutoSave.BackColor = unAutoSaveColor;
                AutoSaveTimer.Stop();
            }
        }

        private void InitTextPlace()
        {
            textPlace.Clear();
            textPlace.Font = new Font("微軟正黑體", 12);
            textPlace.ForeColor = Color.Black;
        }

        private void SaveNewItem_Click(object sender, EventArgs e)
        {
            SaveNewFile();
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (isNew) // first save
            {
                SaveNewFile();
            }
            else
            {
                SaveFile();
            }
        }

        private void textPlace_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void SaveFile() // save file which exists
        {
            if (filePath != "" && File.Exists(filePath))
            {
                try
                {
                    textPlace.SaveFile(filePath);
                    labelInfo.Text = "成功存檔";

                    isNew = false;
                    isSave = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存檔案發生錯誤" +  ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveNewFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "RTF 檔案 (*.rtf)|*.rtf|純文字檔 (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = Path.GetFullPath("../../res");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    if (Path.GetExtension(filePath).ToLower() == ".rtf")
                    {
                        textPlace.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        textPlace.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    }

                    labelInfo.Text = "另存新檔成功, auto save on";

                    isNew = false;
                    isSave = true;

                    if (!AutoSave)
                    {
                        AutoSave = true;
                        btnAutoSave.BackColor = autoSaveColor;
                        AutoSaveTimer.Start();
                    }
                }
            }

        }

    }
}
