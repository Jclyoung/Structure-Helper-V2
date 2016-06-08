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
    public partial class Sketch : Form
    {
        List<Structure> sideViewStructures;
        string view;

        public Sketch()
        {
            InitializeComponent();
            sideViewStructures = new List<Structure>();
            view = "connections";
            lst_SideViewStructures.DisplayMember = "Shot";
            this.Size = new Size(this.Width, Convert.ToInt32((MaxNorthing - MinNorthing) * MapScale)+100);
        }

        public float MapScale
        {
            get { return (sketchArea.Width-20)/(MaxEasting - MinEasting); }
        }

        public float MaxEasting
        {
            //find smallest easting for all structure coords
            get { return Program.CurrentJob.Structures.Max(x => x.Easting); }
        }

        public float MinEasting
        {
            //find largest easting for all structure coords
            get { return Program.CurrentJob.Structures.Min(x => x.Easting); }
        }

        public float MaxNorthing
        { get { return Program.CurrentJob.Structures.Max(x => x.Northing); } }

        public float MinNorthing
        { get { return Program.CurrentJob.Structures.Min(x => x.Northing); } }


        public void sketchArea_PaintStructuresTop(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (Structure s in Program.CurrentJob.Structures)
            {
                int x = Convert.ToInt32((s.Easting - MinEasting) * MapScale + 10);
                int y = Convert.ToInt32((MaxNorthing - s.Northing) * MapScale + 10);
                Rectangle rect = new Rectangle(x, y, 10, 10);
                s.Rect = rect;
                e.Graphics.FillEllipse(brush, rect);
            }
        }

        public void sketchArea_PaintStructuresSide(object sender, PaintEventArgs e)
        {
            //determine connections
            List<Connection> sideViewConnections = new List<Connection>();
            for (int i = 0; i < sideViewStructures.Count - 1; i++)
            {
                var s1 = sideViewStructures[i];
                var s2 = sideViewStructures[i + 1];
                foreach (Connection c in Program.Connections)
                {
                    string[] arr = c.Name.Substring(1,c.Name.Length-2).Split(',');
                    if (arr[0] == s1.Shot && arr[1] == s2.Shot || arr[0] == s2.Shot && arr[1] == s1.Shot)
                    {
                        sideViewConnections.Add(c);
                        break;
                    }
                }
            }

            float maxElevation = sideViewStructures.Max(z => z.Elevation);
            var a = sideViewConnections.Min(z => z.lowerEnd.Invert);
            var b = sideViewConnections.Min(z => z.upperEnd.Invert);
            float lowestInvert = Math.Min(a, b);
            float sideDistance=0;
            List<float> sideDistances = new List<float>();
            for(int i = 0; i<sideViewStructures.Count-1;i++)
            {
                double x1 = sideViewStructures[i].Easting;
                double x2 = sideViewStructures[i+1].Easting;
                double y1 = sideViewStructures[i].Northing;
                double y2 = sideViewStructures[i+1].Northing;
                sideDistance+= (float)Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));

                sideDistances.Add((float)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            }

            //20pixel padding around edges
            float sideScaleVert = (sketchArea.Height-40)/(maxElevation -lowestInvert);
            float sideScaleHorz = (sketchArea.Width-40)/sideDistance;

            //draw each stucture as rect
            sideDistance = 0;

            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Blue,3);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            int x=0, y=0, height=0;
            int width = 8;
            Point start = new Point(0,0), end;
            for (int i = 0; i < sideViewConnections.Count; i++)
            {
                //upper structure when i = 0
                if (i == 0)
                {
                    x = 20 - width / 2;
                    y = 20;
                    height = Convert.ToInt32((sideViewConnections[i].upperStructure.Elevation - sideViewConnections[i].upperEnd.Invert)*sideScaleVert);

                    e.Graphics.FillRectangle(brush, x, y, width, height);
                    start = new Point(x, y + height);
                }

                x += Convert.ToInt32(sideDistances[i]*sideScaleHorz);
                y = Convert.ToInt32((maxElevation - sideViewConnections[i].lowerStructure.Elevation) * sideScaleVert + 20);
                height = Convert.ToInt32((sideViewConnections[i].lowerStructure.Elevation-sideViewConnections[i].lowerEnd.Invert)*sideScaleVert);

                e.Graphics.FillRectangle(brush, x, y, width, height);
                end = new Point(x, y + height);
                e.Graphics.DrawLine(pen, start, end);

                start = end;
            }
            //find Connection it is part of and use inverts for lower/upperPipe
        }

        public void sketchArea_PaintConnections(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;

            Point start = new Point();
            Point end = new Point();
            float maxNorthing = Program.CurrentJob.Structures.Max(x => x.Northing);

            foreach (Connection c in Program.Connections)
            {
                start.X = Convert.ToInt32(MapScale * (c.upperStructure.Easting - MinEasting)) + 10;
                start.Y = Convert.ToInt32(MapScale * (maxNorthing - c.upperStructure.Northing)) + 10;
                end.X = Convert.ToInt32(MapScale * (c.lowerStructure.Easting - MinEasting)) + 10;
                end.Y = Convert.ToInt32(MapScale * (maxNorthing - c.lowerStructure.Northing)) + 10;
                e.Graphics.DrawLine(pen, start, end);
            }
            
            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (Structure s in Program.CurrentJob.Structures)
            {
                int x = Convert.ToInt32((s.Easting - MinEasting) * MapScale + 10);
                int y = Convert.ToInt32((MaxNorthing - s.Northing) * MapScale + 10);
                Rectangle rect = new Rectangle(x-5, y-5, 10, 10);
                s.Rect = rect;
                e.Graphics.FillEllipse(brush, rect);
            }

        }        

        private void sketchArea_Resize(object sender, EventArgs e)
        {
            sketchArea.Refresh();
        }

        private void sketchArea_MouseClickNormal(object sender, MouseEventArgs e)
        {
            foreach(Structure s in Program.CurrentJob.Structures)
                if (s.Rect.Contains(sketchArea.PointToClient(MousePosition)))
                {
                    EnterStructInfo structInfo = new EnterStructInfo(s);
                    structInfo.Show();
                    break;
                }
        }

        private void sketchArea_MouseClickSelect(object sender, MouseEventArgs e)
        {
            foreach (Structure s in Program.CurrentJob.Structures)
                if (s.Rect.Contains(sketchArea.PointToClient(MousePosition)))
                {
                    sideViewStructures.Add(s);
                    if (sideViewStructures.Count > 1)
                        btn_ShowSide.Enabled = true;
                    else
                        btn_ShowSide.Enabled = false;
                    break;
                }
            lst_SideViewStructures.DataSource = null;
            lst_SideViewStructures.DataSource = sideViewStructures;
            lst_SideViewStructures.DisplayMember = "Shot";
        }

        public PictureBox SketchArea { get { return sketchArea; } }

        private void btn_CancelSide_Click(object sender, EventArgs e)
        {
            btn_ShowSide.Visible = false;
            btn_ChangeView.Visible = true;
            lst_SideViewStructures.Refresh();
            sideViewStructures.Clear();
            btn_CancelSide.Visible = false;
            lst_SideViewStructures.Visible = false;
            lst_SideViewStructures.DataSource = null;
            sketchArea.MouseClick += new MouseEventHandler(sketchArea_MouseClickNormal);
            sketchArea.MouseClick -= new MouseEventHandler(sketchArea_MouseClickSelect);
        }

        private void btn_ShowSide_Click(object sender, EventArgs e)
        {
            sketchArea.Paint -= new PaintEventHandler(sketchArea_PaintConnections);
            sketchArea.Paint += new PaintEventHandler(sketchArea_PaintStructuresSide);
            sketchArea.Refresh();
            view = "side";
            btn_ChangeView.Text = "Show Top View";
            btn_ChangeView.Visible = true;
            btn_CancelSide.Visible = false;
            btn_ShowSide.Visible = false;
            sketchArea.MouseClick -= new MouseEventHandler(sketchArea_MouseClickSelect);
            sketchArea.Refresh();
        }

        private void btn_ChangeView_Click(object sender, EventArgs e)
        {
            if (view == "connections")
            {
                lst_SideViewStructures.Visible = true;
                btn_ShowSide.Visible = true;
                btn_CancelSide.Visible = true;
                btn_ChangeView.Visible = false;
                sketchArea.MouseClick -= new MouseEventHandler(sketchArea_MouseClickNormal);
                sketchArea.MouseClick += new MouseEventHandler(sketchArea_MouseClickSelect);
            }

            if (view == "side")
            {
                btn_ChangeView.Text = "Choose Structures for Side View";
                view = "connections";
                sketchArea.Paint -= new PaintEventHandler(sketchArea_PaintStructuresSide);
                sketchArea.Paint += new PaintEventHandler(sketchArea_PaintConnections);
                sketchArea.Refresh();
                lst_SideViewStructures.Visible = false;
                sketchArea.MouseClick += new MouseEventHandler(sketchArea_MouseClickNormal);
            }
        }
    }
}
