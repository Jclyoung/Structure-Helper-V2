using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Helper.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string JobNumber { get; set; }
    }

    public class JobDBContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
    }
}
