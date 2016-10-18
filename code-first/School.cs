using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first
{
    class School : DbContext
    {
       
        public DbSet<Student> Student { get; set; }
        public DbSet<Education> Education { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
    }
}
