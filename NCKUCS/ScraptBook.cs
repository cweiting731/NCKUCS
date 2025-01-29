using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKUCS
{
    public partial class ScraptBook : Form
    {
        int MARGIN = 10;
        Color autoSaveColor = Color.LightGray;
        Color unAutoSaveColor = Color.White;

        /// 
        
        bool isSave = false;
        bool AutoSave = false;
        public ScraptBook()
        {
            InitializeComponent();
        }

        private void ScraptBook_Load(object sender, EventArgs e)
        {
            Anchor_Object();
        }

        private void BoldItem_Click(object sender, EventArgs e)
        {
            Font currentFont = textPlace.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
            textPlace.SelectionFont = new Font(currentFont, newStyle);
        }

        private void ItalicsItem_Click(object sender, EventArgs e)
        {
            Font currentFont = textPlace.SelectionFont;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
            textPlace.SelectionFont = new Font(currentFont, newStyle);
        }

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

        private void btnAutoSave_Click(object sender, EventArgs e)
        {
            AutoSave = !AutoSave;
            btnAutoSave.BackColor = AutoSave ? autoSaveColor : unAutoSaveColor;
            labelInfo.Text = AutoSave ? "Auto Save On" : "Auto Save Off";
        }
    }
}
