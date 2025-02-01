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
    public partial class Form1 : Form
    {
        FrontPage frontPage;
        ScraptBook book;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frontPage = new FrontPage();
            SwitchPage(frontPage);
            pageContainer.Dock = DockStyle.Fill;
        }

        private void SwitchPage(UserControl page)
        {
            pageContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pageContainer.Controls.Add( page );
        }

        private void pageContainer_Resize(object sender, EventArgs e)
        {
        }

        private void scraptBook_Click(object sender, EventArgs e)
        {
            if (book == null || book.IsDisposed)
            {
                book = new ScraptBook();
            }
            book.Show();
        }

    }
}
