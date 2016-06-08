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
    public partial class EnterPipeInfo : Form
    {
        Structure currentStructure;
        public PipeEnd CurrentPipe { get; set; }
        bool add;
        public new StructurePipes Parent { get; set; }

        public EnterPipeInfo(Structure s, bool add = true, PipeEnd pipe = null)
        {
            InitializeComponent();
            currentStructure = s;
            if (add)
            {
                CurrentPipe = new PipeEnd(currentStructure);
                currentStructure.Pipes.Add(CurrentPipe);                
            }
            else
                CurrentPipe = pipe;

            this.add = add;
            CurrentPipe.ID = ((char)(currentStructure.Pipes.IndexOf(CurrentPipe) + 'A')).ToString();

            txt_Diameter.Text = (add ? "0" : CurrentPipe.Diameter.ToString());
            txt_Direction.Text = (add ? "0" : CurrentPipe.Direction.ToString());
            txt_Invert.Text = (add ? "0" : CurrentPipe.Invert.ToString());
            cmb_PipeType.SelectedItem = (add ? PipeType.unknown : CurrentPipe.Type);
            cmb_PipeType.Text = (add ? "unknown" : CurrentPipe.Type.ToString());
            if (add)
                CurrentPipe.Flow = Flow.unknown;
            if (CurrentPipe.Flow == Flow.In)
                rd_In.Checked = true;
            if (CurrentPipe.Flow == Flow.Out)
                rd_Out.Checked = true;

            this.cmb_PipeType.DataSource = Enum.GetNames(typeof(PipeType));
            cmb_PipeType.Text = (add ? "unknown" : CurrentPipe.Type.ToString());
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            CurrentPipe.Invert = float.Parse(txt_Invert.Text);
            CurrentPipe.Diameter = float.Parse(txt_Diameter.Text);
            CurrentPipe.Direction = float.Parse(txt_Direction.Text);
            CurrentPipe.Type = (PipeType)Enum.Parse(typeof(PipeType), cmb_PipeType.Text);

            if (rd_In.Checked || rd_Out.Checked)
                CurrentPipe.Flow = (Flow)Enum.Parse(typeof(Flow), (rd_Out.Checked ? rd_Out.Text : rd_In.Text));
            else
                CurrentPipe.Flow = Flow.unknown;

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterPipeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Refresh();
        }
    }
}
