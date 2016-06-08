using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_Helper;

namespace Structure_Helper.Models
{
    public class PipeEnd
    {
        public int ID { get; set; }
        public Structure ParentStructure { get; set; }
        public PipeType Type { get; set; }
        public string Direction { get; set; }
        public double Invert { get; set; }
        public double Diameter { get; set; }
        public Flow Flow { get; set; }
    }
}
