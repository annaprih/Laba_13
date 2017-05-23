using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba13.Model
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("Laba13")
        {

        }
        public DbSet<Subjects> setSubjectses { get; set; }

    }
}
