using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Structure_Helper
{
    public enum StructureType
    {
        unknown,
        CB,
        SWCB,
        CBL,
        CBR,
        DWCB,
        JB,
        DI,
        YI,
        HW,
        FES,
        CI,
        SSMH,
        GT,
        CO
    };

    public enum PipeType
    {
        unknown,
        RCP,
        CMP,
        HDPE,
        CPP,
        PVC,
        DIP,
        Clay
    };

    public class Structure
    {
        protected StructureType type;
        protected string shotNumber, label;
        protected List<PipeEnd> pipes;
        public float Easting { get; set; }
        public float Northing { get; set; }
        public float Elevation { get; set; }
        public Rectangle Rect { get; set; }

        public Structure()
        {
            this.shotNumber = "none";
            this.label = "none";
            pipes = new List<PipeEnd>();
            type = StructureType.unknown;
            NumPipes = "0";
            this.Northing = 0;
            this.Easting = 0;
        }


        public string Shot
        {
            get
            {
                if (shotNumber == "none" || shotNumber == "")
                    return label;
                else
                    return shotNumber;
            }
            set
            { shotNumber = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public string NumPipes { get; set; }

        public StructureType Type
        {
            get { return type; }
            set { type = value; }
        }

        public List<PipeEnd> Pipes
        {
            get { return pipes; }
        }
    }
}
