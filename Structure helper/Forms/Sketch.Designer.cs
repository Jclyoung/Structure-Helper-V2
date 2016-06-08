namespace Structure_Helper
{
    partial class Sketch
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
            this.btn_ChangeView = new System.Windows.Forms.Button();
            this.lst_SideViewStructures = new System.Windows.Forms.ListBox();
            this.btn_ShowSide = new System.Windows.Forms.Button();
            this.btn_CancelSide = new System.Windows.Forms.Button();
            this.sketchArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sketchArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangeView
            // 
            this.btn_ChangeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeView.Location = new System.Drawing.Point(1191, 23);
            this.btn_ChangeView.Name = "btn_ChangeView";
            this.btn_ChangeView.Size = new System.Drawing.Size(75, 70);
            this.btn_ChangeView.TabIndex = 1;
            this.btn_ChangeView.Text = "Choose Structures for Side View";
            this.btn_ChangeView.UseVisualStyleBackColor = true;
            this.btn_ChangeView.Click += new System.EventHandler(this.btn_ChangeView_Click);
            // 
            // lst_SideViewStructures
            // 
            this.lst_SideViewStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_SideViewStructures.FormattingEnabled = true;
            this.lst_SideViewStructures.Location = new System.Drawing.Point(1175, 99);
            this.lst_SideViewStructures.Name = "lst_SideViewStructures";
            this.lst_SideViewStructures.Size = new System.Drawing.Size(91, 238);
            this.lst_SideViewStructures.TabIndex = 2;
            this.lst_SideViewStructures.Visible = false;
            // 
            // btn_ShowSide
            // 
            this.btn_ShowSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowSide.Enabled = false;
            this.btn_ShowSide.Location = new System.Drawing.Point(1188, 362);
            this.btn_ShowSide.Name = "btn_ShowSide";
            this.btn_ShowSide.Size = new System.Drawing.Size(75, 34);
            this.btn_ShowSide.TabIndex = 3;
            this.btn_ShowSide.Text = "Show Side View";
            this.btn_ShowSide.UseVisualStyleBackColor = true;
            this.btn_ShowSide.Visible = false;
            this.btn_ShowSide.Click += new System.EventHandler(this.btn_ShowSide_Click);
            // 
            // btn_CancelSide
            // 
            this.btn_CancelSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelSide.Location = new System.Drawing.Point(1188, 402);
            this.btn_CancelSide.Name = "btn_CancelSide";
            this.btn_CancelSide.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelSide.TabIndex = 4;
            this.btn_CancelSide.Text = "Cancel";
            this.btn_CancelSide.UseVisualStyleBackColor = true;
            this.btn_CancelSide.Visible = false;
            this.btn_CancelSide.Click += new System.EventHandler(this.btn_CancelSide_Click);
            // 
            // sketchArea
            // 
            this.sketchArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sketchArea.BackColor = System.Drawing.SystemColors.Window;
            this.sketchArea.Location = new System.Drawing.Point(12, 23);
            this.sketchArea.Name = "sketchArea";
            this.sketchArea.Size = new System.Drawing.Size(1140, 588);
            this.sketchArea.TabIndex = 0;
            this.sketchArea.TabStop = false;
            this.sketchArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sketchArea_MouseClickNormal);
            this.sketchArea.Resize += new System.EventHandler(this.sketchArea_Resize);
            // 
            // Sketch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 623);
            this.Controls.Add(this.sketchArea);
            this.Controls.Add(this.btn_CancelSide);
            this.Controls.Add(this.btn_ShowSide);
            this.Controls.Add(this.lst_SideViewStructures);
            this.Controls.Add(this.btn_ChangeView);
            this.MinimumSize = new System.Drawing.Size(1294, 659);
            this.Name = "Sketch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sketch";
            ((System.ComponentModel.ISupportInitialize)(this.sketchArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeView;
        private System.Windows.Forms.ListBox lst_SideViewStructures;
        private System.Windows.Forms.Button btn_ShowSide;
        private System.Windows.Forms.Button btn_CancelSide;
        private System.Windows.Forms.PictureBox sketchArea;


    }
}