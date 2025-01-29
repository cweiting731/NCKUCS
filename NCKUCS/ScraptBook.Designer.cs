namespace NCKUCS
{
    partial class ScraptBook
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoldItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItalicsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnderlineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPlace = new System.Windows.Forms.RichTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnAutoSave = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.儲存ToolStripMenuItem,
            this.文字ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1113, 40);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.儲存ToolStripMenuItem.Text = "儲存";
            // 
            // 文字ToolStripMenuItem
            // 
            this.文字ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldItem,
            this.ItalicsItem,
            this.UnderlineItem,
            this.ColorItem});
            this.文字ToolStripMenuItem.Name = "文字ToolStripMenuItem";
            this.文字ToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.文字ToolStripMenuItem.Text = "文字";
            // 
            // BoldItem
            // 
            this.BoldItem.Name = "BoldItem";
            this.BoldItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BoldItem.Size = new System.Drawing.Size(253, 38);
            this.BoldItem.Text = "粗體";
            this.BoldItem.Click += new System.EventHandler(this.BoldItem_Click);
            // 
            // ItalicsItem
            // 
            this.ItalicsItem.Name = "ItalicsItem";
            this.ItalicsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ItalicsItem.Size = new System.Drawing.Size(253, 38);
            this.ItalicsItem.Text = "斜體";
            this.ItalicsItem.Click += new System.EventHandler(this.ItalicsItem_Click);
            // 
            // UnderlineItem
            // 
            this.UnderlineItem.Name = "UnderlineItem";
            this.UnderlineItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UnderlineItem.Size = new System.Drawing.Size(253, 38);
            this.UnderlineItem.Text = "底線";
            this.UnderlineItem.Click += new System.EventHandler(this.UnderlineItem_Click);
            // 
            // ColorItem
            // 
            this.ColorItem.Name = "ColorItem";
            this.ColorItem.Size = new System.Drawing.Size(253, 38);
            this.ColorItem.Text = "顏色";
            // 
            // textPlace
            // 
            this.textPlace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textPlace.Location = new System.Drawing.Point(0, 41);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(1113, 565);
            this.textPlace.TabIndex = 1;
            this.textPlace.Text = "";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInfo.Location = new System.Drawing.Point(-3, 612);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(998, 35);
            this.labelInfo.TabIndex = 2;
            // 
            // btnAutoSave
            // 
            this.btnAutoSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAutoSave.Location = new System.Drawing.Point(1001, 612);
            this.btnAutoSave.Name = "btnAutoSave";
            this.btnAutoSave.Size = new System.Drawing.Size(112, 35);
            this.btnAutoSave.TabIndex = 3;
            this.btnAutoSave.Text = "auto save";
            this.btnAutoSave.UseVisualStyleBackColor = true;
            this.btnAutoSave.Click += new System.EventHandler(this.btnAutoSave_Click);
            // 
            // ScraptBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 646);
            this.Controls.Add(this.btnAutoSave);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "ScraptBook";
            this.Text = "剪貼簿";
            this.Load += new System.EventHandler(this.ScraptBook_Load);
            this.Resize += new System.EventHandler(this.ScraptBook_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textPlace;
        private System.Windows.Forms.ToolStripMenuItem 文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoldItem;
        private System.Windows.Forms.ToolStripMenuItem ItalicsItem;
        private System.Windows.Forms.ToolStripMenuItem UnderlineItem;
        private System.Windows.Forms.ToolStripMenuItem ColorItem;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnAutoSave;
    }
}