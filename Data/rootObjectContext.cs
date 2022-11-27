using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Data
{
    public class rootObjectContext : DbContext
    {
       /* public rootObjectContext(DbContextOptions<rootObjectContext> options)
            : base(options)
        {

        }
        */
        public DbSet<Rootobject> rootobjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\mssqllocaldb; Initial catalog=rootObjectDb; Integrated Security=true");
       
        }
    }
}
