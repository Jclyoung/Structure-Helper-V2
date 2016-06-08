namespace Structure_Helper
{
    partial class StartScrn
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShotFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mergeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Structure Helper save|*.shs|Text files|*.txt|All files|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Text Files |*.txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem1,
            this.openJobToolStripMenuItem,
            this.openShotFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.mergeFilesToolStripMenuItem});
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newJobToolStripMenuItem.Text = "File";
            // 
            // newJobToolStripMenuItem1
            // 
            this.newJobToolStripMenuItem1.Name = "newJobToolStripMenuItem1";
            this.newJobToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.newJobToolStripMenuItem1.Text = "New Job";
            this.newJobToolStripMenuItem1.Click += new System.EventHandler(this.newJobToolStripMenuItem1_Click);
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openJobToolStripMenuItem.Text = "Open Job File";
            this.openJobToolStripMenuItem.Click += new System.EventHandler(this.openJobToolStripMenuItem_Click);
            // 
            // openShotFileToolStripMenuItem
            // 
            this.openShotFileToolStripMenuItem.Name = "openShotFileToolStripMenuItem";
            this.openShotFileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openShotFileToolStripMenuItem.Text = "Open Shot File";
            this.openShotFileToolStripMenuItem.Click += new System.EventHandler(this.openShotFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // mergeFilesToolStripMenuItem
            // 
            this.mergeFilesToolStripMenuItem.Name = "mergeFilesToolStripMenuItem";
            this.mergeFilesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mergeFilesToolStripMenuItem.Text = "Merge Files";
            this.mergeFilesToolStripMenuItem.Click += new System.EventHandler(this.mergeFilesToolStripMenuItem_Click);
            // 
            // StartScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 556);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartScrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Helper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openShotFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mergeFilesToolStripMenuItem;
    }
}