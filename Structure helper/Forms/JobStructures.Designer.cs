namespace Structure_Helper
{
    partial class JobStructures
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
            this.lstbx_Structures = new System.Windows.Forms.ListBox();
            this.btn_AddStructure = new System.Windows.Forms.Button();
            this.btn_EditStructure = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connections = new System.Windows.Forms.Button();
            this.btn_SketchStructures = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lstbx_Structures
            // 
            this.lstbx_Structures.DisplayMember = "Shot";
            this.lstbx_Structures.FormattingEnabled = true;
            this.lstbx_Structures.Location = new System.Drawing.Point(26, 40);
            this.lstbx_Structures.Name = "lstbx_Structures";
            this.lstbx_Structures.Size = new System.Drawing.Size(101, 238);
            this.lstbx_Structures.TabIndex = 0;
            this.lstbx_Structures.SelectedIndexChanged += new System.EventHandler(this.lstbx_Structures_SelectedIndexChanged);
            // 
            // btn_AddStructure
            // 
            this.btn_AddStructure.Location = new System.Drawing.Point(143, 40);
            this.btn_AddStructure.Name = "btn_AddStructure";
            this.btn_AddStructure.Size = new System.Drawing.Size(101, 23);
            this.btn_AddStructure.TabIndex = 1;
            this.btn_AddStructure.Text = "Add Structure";
            this.btn_AddStructure.UseVisualStyleBackColor = true;
            this.btn_AddStructure.Click += new System.EventHandler(this.btn_AddStructure_Click);
            // 
            // btn_EditStructure
            // 
            this.btn_EditStructure.Location = new System.Drawing.Point(143, 81);
            this.btn_EditStructure.Name = "btn_EditStructure";
            this.btn_EditStructure.Size = new System.Drawing.Size(101, 23);
            this.btn_EditStructure.TabIndex = 2;
            this.btn_EditStructure.Text = "Edit Structure";
            this.btn_EditStructure.UseVisualStyleBackColor = true;
            this.btn_EditStructure.Click += new System.EventHandler(this.btn_EditStructure_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(152, 255);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save Job";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Structures:";
            // 
            // btn_Connections
            // 
            this.btn_Connections.Location = new System.Drawing.Point(143, 122);
            this.btn_Connections.Name = "btn_Connections";
            this.btn_Connections.Size = new System.Drawing.Size(101, 23);
            this.btn_Connections.TabIndex = 5;
            this.btn_Connections.Text = "Connections";
            this.btn_Connections.UseVisualStyleBackColor = true;
            this.btn_Connections.Click += new System.EventHandler(this.btn_Connections_Click);
            // 
            // btn_SketchStructures
            // 
            this.btn_SketchStructures.Location = new System.Drawing.Point(143, 166);
            this.btn_SketchStructures.Name = "btn_SketchStructures";
            this.btn_SketchStructures.Size = new System.Drawing.Size(101, 23);
            this.btn_SketchStructures.TabIndex = 6;
            this.btn_SketchStructures.Text = "Sketch Structures";
            this.btn_SketchStructures.UseVisualStyleBackColor = true;
            this.btn_SketchStructures.Click += new System.EventHandler(this.btn_SketchStructures_Click);
            // 
            // JobStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 306);
            this.Controls.Add(this.btn_SketchStructures);
            this.Controls.Add(this.btn_Connections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_EditStructure);
            this.Controls.Add(this.btn_AddStructure);
            this.Controls.Add(this.lstbx_Structures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JobStructures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Structures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JobStructures_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_Structures;
        private System.Windows.Forms.Button btn_AddStructure;
        private System.Windows.Forms.Button btn_EditStructure;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connections;
        private System.Windows.Forms.Button btn_SketchStructures;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}