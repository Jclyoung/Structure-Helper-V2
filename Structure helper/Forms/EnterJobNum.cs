using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_Helper
{
    public partial class EnterJobNum : Form
    {
        private DialogResult result;
        public EnterJobNum()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (txt_JobNumber.Text !="")
            {
                Program.CurrentJob = new Job(this.txt_JobNumber.Text.ToString());
                JobStructures jobStructures = new JobStructures();
                jobStructures.MdiParent = Program.StartScrn;
                jobStructures.Show();
                result = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                txt_JobNumber.Clear();
                MessageBox.Show("Please Enter a Job Number");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Program.CurrentJob = null;
        }
    }
}
