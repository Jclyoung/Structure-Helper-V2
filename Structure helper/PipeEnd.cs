using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Helper
{
    public enum Flow
    {
        unknown,
        In,
        Out
    }

    public class PipeEnd
    {
        public float Direction { get; set; }
        public float Diameter { get; set; }
        public PipeType Type { get; set; }
        public string ID { get; set; }
        public Structure ParentStructure { get; set; }
        public Flow Flow { get; set; }
        public float Invert { get; set; }

        public PipeEnd(Structure s)
        {
            this.Direction = 0;
            this.Diameter = 0;
            this.Type = PipeType.unknown;
            this.ParentStructure = s;
            this.Flow = Flow.unknown;
            this.Invert = 0;
        }
    }
}
