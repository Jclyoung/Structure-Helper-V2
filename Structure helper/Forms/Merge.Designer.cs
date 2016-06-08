namespace Structure_Helper
{
    partial class Merge
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
            this.btn_SelectJobFile = new System.Windows.Forms.Button();
            this.btn_SelectShotFile = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_JobFile = new System.Windows.Forms.TextBox();
            this.txt_ShotFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_SelectJobFile
            // 
            this.btn_SelectJobFile.Location = new System.Drawing.Point(232, 101);
            this.btn_SelectJobFile.Name = "btn_SelectJobFile";
            this.btn_SelectJobFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectJobFile.TabIndex = 0;
            this.btn_SelectJobFile.Text = "Browse...";
            this.btn_SelectJobFile.UseVisualStyleBackColor = true;
            this.btn_SelectJobFile.Click += new System.EventHandler(this.btn_SelectJobFile_Click);
            // 
            // btn_SelectShotFile
            // 
            this.btn_SelectShotFile.Location = new System.Drawing.Point(232, 199);
            this.btn_SelectShotFile.Name = "btn_SelectShotFile";
            this.btn_SelectShotFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectShotFile.TabIndex = 1;
            this.btn_SelectShotFile.Text = "Browse...";
            this.btn_SelectShotFile.UseVisualStyleBackColor = true;
            this.btn_SelectShotFile.Click += new System.EventHandler(this.btn_SelectShotFile_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Merge.Enabled = false;
            this.btn_Merge.Location = new System.Drawing.Point(54, 298);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(75, 23);
            this.btn_Merge.TabIndex = 2;
            this.btn_Merge.Text = "Merge";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(187, 298);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Existing Job File";
            // 
            // txt_JobFile
            // 
            this.txt_JobFile.Location = new System.Drawing.Point(34, 103);
            this.txt_JobFile.Name = "txt_JobFile";
            this.txt_JobFile.Size = new System.Drawing.Size(192, 20);
            this.txt_JobFile.TabIndex = 5;
            // 
            // txt_ShotFile
            // 
            this.txt_ShotFile.Location = new System.Drawing.Point(34, 199);
            this.txt_ShotFile.Name = "txt_ShotFile";
            this.txt_ShotFile.Size = new System.Drawing.Size(192, 20);
            this.txt_ShotFile.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Shot File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Merge
            // 
            this.AcceptButton = this.btn_Merge;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(317, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ShotFile);
            this.Controls.Add(this.txt_JobFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Merge);
            this.Controls.Add(this.btn_SelectShotFile);
            this.Controls.Add(this.btn_SelectJobFile);
            this.Name = "Merge";
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectJobFile;
        private System.Windows.Forms.Button btn_SelectShotFile;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_JobFile;
        private System.Windows.Forms.TextBox txt_ShotFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}