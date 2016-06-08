using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Deployment.Application;

namespace Structure_Helper
{
    public partial class StartScrn : Form
    {
        public JobStructures structureList;

        public StartScrn()
        {
            InitializeComponent();
            Program.StartScrn = this;
            Program.Connections = new Connections();

            //label1.Text = "version " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
        }

        private void newJobToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnterJobNum enterJobNum = new EnterJobNum();
            enterJobNum.ShowDialog();
        }

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.LoadFile(openFileDialog1.FileName);
                var structureList = new JobStructures();
                structureList.MdiParent = Program.StartScrn;
                structureList.Show();
            }
        }

        private void openShotFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                File.LoadShotFile(openFileDialog2.FileName);
                var structureList = new JobStructures();
                structureList.MdiParent = Program.StartScrn;
                structureList.Show();
            }
        }

        private void mergeFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((new Merge()).ShowDialog() == DialogResult.OK)
            {
                var jobStructures = new JobStructures();
                structureList.MdiParent = this;
                structureList.Show();
            }
        }
    }
}
