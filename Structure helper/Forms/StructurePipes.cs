using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Structure_Helper
{
    public partial class StructurePipes : Form
    {
        public new Form Parent { get; set; }
        private Structure structure;
        public ListBox PipeList { get; private set; }
        
        public StructurePipes(Structure structure, bool connecting=false)
        {
            InitializeComponent();
            this.structure = structure;
            PipeList = lstbx_Pipes;
            lstbx_Pipes.DataSource = structure.Pipes;
            lstbx_Pipes.DisplayMember = "ID";
            btn_EditPipe.Enabled = false;
            lstbx_Pipes.ClearSelected();
            if (connecting)
            {
                btn_ConnectExisting.Visible = false;
                btn_ConnectNew.Visible = false;
                btn_Done.Visible = false;
                btn_ConnectToSelected.Visible = true;
            }
        }

        private void btn_AddPipe_Click(object sender, EventArgs e)
        {
            EnterPipeInfo enterPipeInfo = new EnterPipeInfo(structure);

            enterPipeInfo.Parent = this;
            enterPipeInfo.ShowDialog();
        }

        private void btn_EditPipe_Click(object sender, EventArgs e)
        {            
            PipeEnd p = (PipeEnd)lstbx_Pipes.SelectedItem;
            EnterPipeInfo enterPipeInfo = new EnterPipeInfo(structure, false,p);
            this.Hide();
            enterPipeInfo.Show();
            enterPipeInfo.Parent = this;            
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StructurePipes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Show();
        }

        public void DrawStructure()
        {
            Graphics graphics = sketchArea.CreateGraphics();
            graphics.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);
            
            Point center = new Point(sketchArea.Width / 2, sketchArea.Height / 2);
            int height = sketchArea.Height / 3, width = height;
            int x = center.X - height / 2;
            int y = center.Y - height / 2;

            Rectangle rect = new Rectangle(x,y,width,height);
            Pen pen;

            foreach (PipeEnd p in structure.Pipes)
            {

                int size = 4;
                if (lstbx_Pipes.SelectedItem == p)
                    size = 6;
                if (p.Flow == Flow.In)
                {    
                    pen = new Pen(Color.Black, size);
                    pen.StartCap = LineCap.ArrowAnchor;
                }
                else
                {
                    pen = new Pen(Color.Red, size);
                    pen.EndCap = LineCap.ArrowAnchor;
                }

                double angle = (90-p.Direction)*Math.PI/180;
                Point endPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height), center.Y - Convert.ToInt32(Math.Sin(angle) * height));
                Point startPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height/2), center.Y - Convert.ToInt32(Math.Sin(angle) * height/2));
                graphics.DrawLine(pen, startPoint,endPoint);
            }

            graphics.FillEllipse(brush, rect);
        }

        private void sldr_Direction_ValueChanged(object sender, EventArgs e)
        {
            PipeEnd p = (PipeEnd)lstbx_Pipes.SelectedItem;
            p.Direction = (sldr_Direction.Value <= 180 ? 180 - sldr_Direction.Value : 360 + 180 - sldr_Direction.Value);
            DrawStructure();
        }

        private void lstbx_Pipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_Pipes.SelectedIndex != -1)
            {
                btn_EditPipe.Enabled = true;
                sldr_Direction.Enabled = true;
                btn_ConnectExisting.Enabled = true;
                btn_ConnectNew.Enabled = true;
                PipeEnd p = (PipeEnd)lstbx_Pipes.SelectedItem;
                sldr_Direction.Value = (p.Direction <= 180 ? 180 - (int)p.Direction : 360 + 180 - (int)p.Direction);
                btn_ConnectToSelected.Enabled = true;
                sketchArea.Refresh();
            }
            else
            {
                btn_ConnectNew.Enabled = false;
                btn_ConnectExisting.Enabled = false;
                sldr_Direction.Enabled = false;
                btn_EditPipe.Enabled = false;
                btn_ConnectToSelected.Enabled = false;
            }
        }

        public override void Refresh()
        {
            DrawStructure();
            lstbx_Pipes.DataSource = null;
            lstbx_Pipes.DataSource = structure.Pipes;
            lstbx_Pipes.DisplayMember = "ID";
        }

        private void btn_ConnectExisting_Click(object sender, EventArgs e)
        {
            CreateConnection connect = new CreateConnection(structure);
            connect.ShowDialog();
        }

        private void btn_ConnectNew_Click(object sender, EventArgs e)
        {
            PipeEnd p = (PipeEnd)lstbx_Pipes.SelectedItem;

            Structure s = new Structure();
            Program.CurrentJob.Structures.Add(s);
            EnterStructInfo enterStructInfo = new EnterStructInfo(s);
            if (enterStructInfo.ShowDialog() == DialogResult.Cancel)
                Program.CurrentJob.Structures.Remove(s);
        }

        private void sketchArea_Paint(object sender, PaintEventArgs e)
        {
            DrawStructure();
        }

        private void btn_ConnectToSelected_Click(object sender, EventArgs e)
        {
            btn_ConnectToSelected.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
