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
    public partial class EnterStructInfo : Form
    {
        Structure structure;
        private bool connecting;

        public EnterStructInfo(Structure structure)
        {
            InitializeComponent();
            this.structure = structure;
            this.cmb_StructureType.DataSource = Enum.GetNames(typeof(StructureType));
            this.Text = Program.CurrentJob.JobNumber.ToString();
            txt_Label.Text = structure.Label;
            txt_ShotNumber.Text = structure.Shot.ToString();
            cmb_StructureType.Text = structure.Type.ToString();
            if (connecting)
                btn_EditAddPipes.Visible = false;
            else
                btn_EditAddPipes.Visible = true;
        }

        public new JobStructures Parent { get; set; }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Show();
            this.Dispose();
        }

        private void EnterStructInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Show();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (txt_Label.Text == "" && txt_ShotNumber.Text == "")
            {
                MessageBox.Show("Must enter either a value for either Label or Shot");
            }
            else
            {
                SaveInfo();
                this.Dispose();
            }
        }

        private void btn_CaptureCoords_Click(object sender, EventArgs e)
        {
            //to be implemented
        }

        private void btn_AddEditPipes_Click(object sender, EventArgs e)
        {
            if (txt_Label.Text == "" && txt_ShotNumber.Text == "")
            {
                MessageBox.Show("Must enter either a value for either Label or Shot");
            }
            else
            {
                SaveInfo();
                StructurePipes pipeList = new StructurePipes(structure);
                pipeList.MdiParent = Program.StartScrn;
                pipeList.Show();
                pipeList.DrawStructure();
            }
        }

        void SaveInfo()
        {
            structure.Label = txt_Label.Text.ToString();
            structure.Shot = txt_ShotNumber.Text.ToString();
            structure.Type = (StructureType)Enum.Parse(typeof(StructureType), cmb_StructureType.Text);
        }
    }
}
