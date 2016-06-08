namespace Structure_Helper
{
    partial class DisplayConnections
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
            this.lst_Connections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_Connections
            // 
            this.lst_Connections.FormattingEnabled = true;
            this.lst_Connections.Location = new System.Drawing.Point(28, 32);
            this.lst_Connections.Name = "lst_Connections";
            this.lst_Connections.Size = new System.Drawing.Size(120, 277);
            this.lst_Connections.TabIndex = 0;
            // 
            // DisplayConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 348);
            this.Controls.Add(this.lst_Connections);
            this.Name = "DisplayConnections";
            this.Text = "Connections";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Connections;
    }
}