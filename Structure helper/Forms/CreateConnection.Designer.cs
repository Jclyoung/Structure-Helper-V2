namespace Structure_Helper
{
    partial class CreateConnection
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
            this.lst_Structures = new System.Windows.Forms.ListBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.sketchArea1 = new System.Windows.Forms.Panel();
            this.sketchArea2 = new System.Windows.Forms.Panel();
            this.lst_Pipes1 = new System.Windows.Forms.ListBox();
            this.lst_Pipes2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Structures
            // 
            this.lst_Structures.FormattingEnabled = true;
            this.lst_Structures.Location = new System.Drawing.Point(518, 51);
            this.lst_Structures.Name = "lst_Structures";
            this.lst_Structures.Size = new System.Drawing.Size(96, 251);
            this.lst_Structures.TabIndex = 0;
            this.lst_Structures.SelectedIndexChanged += new System.EventHandler(this.lst_Structures_SelectedIndexChanged);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(181, 51);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(102, 30);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Make Connection";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // sketchArea1
            // 
            this.sketchArea1.BackColor = System.Drawing.SystemColors.Window;
            this.sketchArea1.Location = new System.Drawing.Point(15, 117);
            this.sketchArea1.Name = "sketchArea1";
            this.sketchArea1.Size = new System.Drawing.Size(185, 185);
            this.sketchArea1.TabIndex = 11;
            this.sketchArea1.Paint += new System.Windows.Forms.PaintEventHandler(this.sketchArea1_Paint);
            // 
            // sketchArea2
            // 
            this.sketchArea2.BackColor = System.Drawing.SystemColors.Window;
            this.sketchArea2.Location = new System.Drawing.Point(308, 117);
            this.sketchArea2.Name = "sketchArea2";
            this.sketchArea2.Size = new System.Drawing.Size(185, 185);
            this.sketchArea2.TabIndex = 12;
            this.sketchArea2.Paint += new System.Windows.Forms.PaintEventHandler(this.sketchArea2_Paint);
            // 
            // lst_Pipes1
            // 
            this.lst_Pipes1.DisplayMember = "Invert";
            this.lst_Pipes1.FormattingEnabled = true;
            this.lst_Pipes1.Location = new System.Drawing.Point(57, 29);
            this.lst_Pipes1.Name = "lst_Pipes1";
            this.lst_Pipes1.Size = new System.Drawing.Size(101, 82);
            this.lst_Pipes1.TabIndex = 13;
            this.lst_Pipes1.SelectedIndexChanged += new System.EventHandler(this.lst_Pipes1_SelectedIndexChanged);
            // 
            // lst_Pipes2
            // 
            this.lst_Pipes2.DisplayMember = "Invert";
            this.lst_Pipes2.FormattingEnabled = true;
            this.lst_Pipes2.Location = new System.Drawing.Point(308, 29);
            this.lst_Pipes2.Name = "lst_Pipes2";
            this.lst_Pipes2.Size = new System.Drawing.Size(101, 82);
            this.lst_Pipes2.TabIndex = 14;
            this.lst_Pipes2.SelectedIndexChanged += new System.EventHandler(this.lst_Pipes2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Structure";
            // 
            // btnAddPipe
            // 
            this.btnAddPipe.Location = new System.Drawing.Point(418, 29);
            this.btnAddPipe.Name = "btnAddPipe";
            this.btnAddPipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddPipe.TabIndex = 18;
            this.btnAddPipe.Text = "Add Pipe";
            this.btnAddPipe.UseVisualStyleBackColor = true;
            this.btnAddPipe.Click += new System.EventHandler(this.btnAddPipe_Click_1);
            // 
            // CreateConnection
            // 
            this.AcceptButton = this.btn_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 314);
            this.Controls.Add(this.btnAddPipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_Pipes2);
            this.Controls.Add(this.lst_Pipes1);
            this.Controls.Add(this.sketchArea2);
            this.Controls.Add(this.sketchArea1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lst_Structures);
            this.Name = "CreateConnection";
            this.Text = "Create a Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Structures;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Panel sketchArea1;
        private System.Windows.Forms.Panel sketchArea2;
        private System.Windows.Forms.ListBox lst_Pipes1;
        private System.Windows.Forms.ListBox lst_Pipes2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPipe;
    }
}