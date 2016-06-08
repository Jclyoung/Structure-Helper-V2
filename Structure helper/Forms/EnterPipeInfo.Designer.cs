namespace Structure_Helper
{
    partial class EnterPipeInfo
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.Label();
            this.txt_Direction = new System.Windows.Forms.TextBox();
            this.txt_Invert = new System.Windows.Forms.TextBox();
            this.txt_Diameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_PipeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_Out = new System.Windows.Forms.RadioButton();
            this.rd_In = new System.Windows.Forms.RadioButton();
            this.grp_Flow = new System.Windows.Forms.GroupBox();
            this.btn_Done = new System.Windows.Forms.Button();
            this.grp_Flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(161, 284);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Direction
            // 
            this.Direction.AutoSize = true;
            this.Direction.Location = new System.Drawing.Point(37, 42);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(49, 13);
            this.Direction.TabIndex = 1;
            this.Direction.Text = "Direction";
            // 
            // txt_Direction
            // 
            this.txt_Direction.Location = new System.Drawing.Point(121, 39);
            this.txt_Direction.Name = "txt_Direction";
            this.txt_Direction.Size = new System.Drawing.Size(100, 20);
            this.txt_Direction.TabIndex = 2;
            // 
            // txt_Invert
            // 
            this.txt_Invert.Location = new System.Drawing.Point(121, 115);
            this.txt_Invert.Name = "txt_Invert";
            this.txt_Invert.Size = new System.Drawing.Size(100, 20);
            this.txt_Invert.TabIndex = 3;
            // 
            // txt_Diameter
            // 
            this.txt_Diameter.Location = new System.Drawing.Point(121, 153);
            this.txt_Diameter.Name = "txt_Diameter";
            this.txt_Diameter.Size = new System.Drawing.Size(100, 20);
            this.txt_Diameter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diameter";
            // 
            // cmb_PipeType
            // 
            this.cmb_PipeType.FormattingEnabled = true;
            this.cmb_PipeType.Location = new System.Drawing.Point(121, 191);
            this.cmb_PipeType.Name = "cmb_PipeType";
            this.cmb_PipeType.Size = new System.Drawing.Size(121, 21);
            this.cmb_PipeType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // rd_Out
            // 
            this.rd_Out.AutoSize = true;
            this.rd_Out.Location = new System.Drawing.Point(94, 18);
            this.rd_Out.Name = "rd_Out";
            this.rd_Out.Size = new System.Drawing.Size(42, 17);
            this.rd_Out.TabIndex = 11;
            this.rd_Out.TabStop = true;
            this.rd_Out.Text = "Out";
            this.rd_Out.UseVisualStyleBackColor = true;
            // 
            // rd_In
            // 
            this.rd_In.AutoSize = true;
            this.rd_In.Location = new System.Drawing.Point(40, 18);
            this.rd_In.Name = "rd_In";
            this.rd_In.Size = new System.Drawing.Size(34, 17);
            this.rd_In.TabIndex = 12;
            this.rd_In.TabStop = true;
            this.rd_In.Text = "In\r\n";
            this.rd_In.UseVisualStyleBackColor = true;
            // 
            // grp_Flow
            // 
            this.grp_Flow.Controls.Add(this.rd_In);
            this.grp_Flow.Controls.Add(this.rd_Out);
            this.grp_Flow.Location = new System.Drawing.Point(56, 68);
            this.grp_Flow.Name = "grp_Flow";
            this.grp_Flow.Size = new System.Drawing.Size(152, 41);
            this.grp_Flow.TabIndex = 13;
            this.grp_Flow.TabStop = false;
            this.grp_Flow.Text = "Flow";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(49, 284);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(75, 23);
            this.btn_Done.TabIndex = 14;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // EnterPipeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.grp_Flow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_PipeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Diameter);
            this.Controls.Add(this.txt_Invert);
            this.Controls.Add(this.txt_Direction);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterPipeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipe Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterPipeInfo_FormClosed);
            this.grp_Flow.ResumeLayout(false);
            this.grp_Flow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label Direction;
        private System.Windows.Forms.TextBox txt_Direction;
        private System.Windows.Forms.TextBox txt_Invert;
        private System.Windows.Forms.TextBox txt_Diameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_PipeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_Out;
        private System.Windows.Forms.RadioButton rd_In;
        private System.Windows.Forms.GroupBox grp_Flow;
        private System.Windows.Forms.Button btn_Done;
    }
}