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
    public partial class CreateConnection : Form
    {
        public Structure SelectedStructure { get; set; }
        public PipeEnd SelectedPipe { get; set; }
        Structure structure1, structure2;

        public CreateConnection(Structure a)
        {
            InitializeComponent();
            this.structure1 = a;

            lst_Pipes1.DataSource = a.Pipes;
            lst_Pipes1.DisplayMember = "ID";
            lst_Structures.DataSource = Program.CurrentJob.Structures;
            lst_Structures.DisplayMember = "Shot";
            btn_Connect.Enabled = false;
            lst_Structures.ClearSelected();
            label1.Text = structure1.Shot;
            sketchArea2.Refresh();
            sketchArea1.Refresh();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Program.Connections.Connect((PipeEnd)lst_Pipes1.SelectedItem, (PipeEnd)lst_Pipes2.SelectedItem);
            this.Dispose();
        }

        private void lst_Structures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Structures.SelectedItem != null)
            {
                structure2 = (Structure)lst_Structures.SelectedItem;
                sketchArea2.Refresh();
                lst_Pipes2.DataSource = null;
                lst_Pipes2.DataSource = structure2.Pipes;
                lst_Pipes2.DisplayMember = "ID";
                label2.Text = structure2.Shot;
            }
        }

        private void sketchArea1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);

            Point center = new Point(sketchArea1.Width / 2, sketchArea1.Height / 2);
            int height = sketchArea1.Height / 3, width = height;
            int x = center.X - height / 2;
            int y = center.Y - height / 2;

            Rectangle rect = new Rectangle(x, y, width, height);
            Pen pen;

            foreach (PipeEnd p in structure1.Pipes)
            {

                int size = 4;
                if (lst_Pipes1.SelectedItem == p)
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

                double angle = (90 - p.Direction) * Math.PI / 180;
                Point endPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height), center.Y - Convert.ToInt32(Math.Sin(angle) * height));
                Point startPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height / 2), center.Y - Convert.ToInt32(Math.Sin(angle) * height / 2));
                e.Graphics.DrawLine(pen, startPoint, endPoint);
            }

            e.Graphics.FillEllipse(brush, rect);

        }

        private void sketchArea2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.Black);

            Point center = new Point(sketchArea2.Width / 2, sketchArea2.Height / 2);
            int height = sketchArea1.Height / 3, width = height;
            int x = center.X - height / 2;
            int y = center.Y - height / 2;

            Rectangle rect = new Rectangle(x, y, width, height);
            Pen pen;

            foreach (PipeEnd p in structure2.Pipes)
            {

                int size = 4;
                if (lst_Pipes2.SelectedItem == p)
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

                double angle = (90 - p.Direction) * Math.PI / 180;
                Point endPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height), center.Y - Convert.ToInt32(Math.Sin(angle) * height));
                Point startPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height / 2), center.Y - Convert.ToInt32(Math.Sin(angle) * height / 2));
                e.Graphics.DrawLine(pen, startPoint, endPoint);
            }

            e.Graphics.FillEllipse(brush, rect);
        }

        private void lst_Pipes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Pipes2.SelectedItem != null && structure1 != structure2 && lst_Pipes1.SelectedItem != null)
            {
                btn_Connect.Enabled = true;
                sketchArea2.Refresh();
            }
            else
                btn_Connect.Enabled = false;
        }

        private void btnAddPipe_Click(object sender, EventArgs e)
        {
            EnterPipeInfo enterPipeInfo = new EnterPipeInfo(structure2);

            enterPipeInfo.ShowDialog();
            sketchArea2.Refresh();
        }

        private void btnAddPipe_Click_1(object sender, EventArgs e)
        {
            EnterPipeInfo addPipe = new EnterPipeInfo(structure2);
            addPipe.ShowDialog();
        }

        private void lst_Pipes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sketchArea1.Refresh();
        }


    }
}
