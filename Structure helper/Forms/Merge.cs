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
    public partial class Merge : Form
    {
        public Merge()
        {
            InitializeComponent();
            txt_JobFile.Text = "";
            txt_ShotFile.Text = "";
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            File.MergeFiles(txt_JobFile.Text, txt_ShotFile.Text);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.SaveJobFile(saveFileDialog1.FileName);
                this.Dispose();
                (new JobStructures()).Show();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_SelectShotFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_ShotFile.Text = openFileDialog1.FileName;
            }

            if (txt_ShotFile.Text != "" && txt_JobFile.Text != "")
                btn_Merge.Enabled = true;
            else
                btn_Merge.Enabled = false;
        }

        private void btn_SelectJobFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Structure Helper Save|*.shs";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_JobFile.Text = openFileDialog1.FileName;
            }

            if (txt_ShotFile.Text != "" && txt_JobFile.Text != "")
                btn_Merge.Enabled = true;
            else
                btn_Merge.Enabled = false;
        }
    }
}
