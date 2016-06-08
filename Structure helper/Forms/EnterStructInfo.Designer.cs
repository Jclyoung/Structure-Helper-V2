namespace Structure_Helper
{
    partial class EnterStructInfo
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
            this.txt_Label = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_StructureType = new System.Windows.Forms.ComboBox();
            this.btn_EditAddPipes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ShotNumber = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Label
            // 
            this.txt_Label.Location = new System.Drawing.Point(154, 76);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 20);
            this.txt_Label.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Structure Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Structure Label";
            // 
            // cmb_StructureType
            // 
            this.cmb_StructureType.DisplayMember = "(none)";
            this.cmb_StructureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StructureType.FormattingEnabled = true;
            this.cmb_StructureType.Location = new System.Drawing.Point(154, 108);
            this.cmb_StructureType.Name = "cmb_StructureType";
            this.cmb_StructureType.Size = new System.Drawing.Size(121, 21);
            this.cmb_StructureType.TabIndex = 5;
            // 
            // btn_EditAddPipes
            // 
            this.btn_EditAddPipes.Location = new System.Drawing.Point(105, 238);
            this.btn_EditAddPipes.Name = "btn_EditAddPipes";
            this.btn_EditAddPipes.Size = new System.Drawing.Size(98, 23);
            this.btn_EditAddPipes.TabIndex = 8;
            this.btn_EditAddPipes.Text = "Add/Edit Pipes";
            this.btn_EditAddPipes.UseVisualStyleBackColor = true;
            this.btn_EditAddPipes.Click += new System.EventHandler(this.btn_AddEditPipes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shot #";
            // 
            // txt_ShotNumber
            // 
            this.txt_ShotNumber.Location = new System.Drawing.Point(154, 36);
            this.txt_ShotNumber.Name = "txt_ShotNumber";
            this.txt_ShotNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_ShotNumber.TabIndex = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(168, 285);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveExit
            // 
            this.btn_SaveExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_SaveExit.Location = new System.Drawing.Point(43, 285);
            this.btn_SaveExit.Name = "btn_SaveExit";
            this.btn_SaveExit.Size = new System.Drawing.Size(98, 23);
            this.btn_SaveExit.TabIndex = 12;
            this.btn_SaveExit.Text = "Done";
            this.btn_SaveExit.UseVisualStyleBackColor = true;
            this.btn_SaveExit.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // EnterStructInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(308, 330);
            this.Controls.Add(this.btn_SaveExit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_ShotNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_EditAddPipes);
            this.Controls.Add(this.cmb_StructureType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterStructInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterStructInfo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_StructureType;
        private System.Windows.Forms.Button btn_EditAddPipes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ShotNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveExit;
    }
}

