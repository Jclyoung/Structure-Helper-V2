using Structure_Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Helper.Models
{
    public class Structure
    {
        public int ID { get; set; }
        public string Job { get; set; }
        public string Shot { get; set; }
        public string Label { get; set; }
        public double Elevation { get; set; }
        public double Northing { get; set; }
        public double Easting { get; set; }
        public StructureType Type { get; set; }
        public double X { get; set; }
        public double Y { get; set; } 
    }

    public class StructureDBContext: DbContext
    {
        public DbSet<Structure> Structures { get; set; }
    }
}
