using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Helper
{
    public class Job
    {
        protected List<Structure> structures;
        protected Connections connections;
        protected string jobNumber;

        public Job(string number)
        {
            this.jobNumber = number;
            this.structures = new List<Structure>();
            connections = new Connections();
        }

        public string JobNumber
        {
            get { return jobNumber; }
        }

        public List<Structure> Structures
        {
            get { return structures; }
        }
    }
}
