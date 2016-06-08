using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Structure_Helper
{
    public partial class JobStructures : Form
    {
        public JobStructures()
        {
            InitializeComponent();
            this.Text = "Job " + Program.CurrentJob.JobNumber;
            this.lstbx_Structures.DataSource = Program.CurrentJob.Structures;
            this.lstbx_Structures.DisplayMember = "Shot";
            this.btn_EditStructure.Enabled = false;
            lstbx_Structures.ClearSelected();
        }

        private void btn_AddStructure_Click(object sender, EventArgs e)
        {
            Structure structure = new Structure();
            Program.CurrentJob.Structures.Add(structure);
            EnterStructInfo enterStructInfo = new EnterStructInfo(structure);
            enterStructInfo.MdiParent = Program.StartScrn;
            enterStructInfo.Show();
        }

        public ListBox StructureList
        {
            get { return lstbx_Structures; }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //create new text file to save current data - always overwrites old 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.SaveJobFile(saveFileDialog1.FileName);                
            }
        }

        private void btn_EditStructure_Click(object sender, EventArgs e)
        {
            Structure structure = (Structure)lstbx_Structures.SelectedItem;
            this.Hide();
            EnterStructInfo enterStructInfo = new EnterStructInfo(structure);
            enterStructInfo.MdiParent = Program.StartScrn;
            enterStructInfo.Show();
        }

        private void lstbx_Structures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_Structures.SelectedIndex == -1)
            {
                btn_EditStructure.Enabled = false;
            }
            else
            {
                btn_EditStructure.Enabled = true;
            }
        }

        private void btn_Connections_Click(object sender, EventArgs e)
        {
            var connections = new DisplayConnections();
            connections.MdiParent = Program.StartScrn;
            connections.Show();
        }

        public Job CurrentJob
        {
            get { return Program.CurrentJob; }
        }

        private void btn_SketchStructures_Click(object sender, EventArgs e)
        {
            Sketch sketch = new Sketch();
            sketch.Show();
            sketch.SketchArea.Paint += new PaintEventHandler(sketch.sketchArea_PaintConnections);
        }

        public override void Refresh()
        {
            base.Refresh();
            this.lstbx_Structures.DataSource = null;
            this.lstbx_Structures.DataSource = Program.CurrentJob.Structures;
            this.lstbx_Structures.DisplayMember = "Shot";
        }

        private void JobStructures_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this Job?", "Closing Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
