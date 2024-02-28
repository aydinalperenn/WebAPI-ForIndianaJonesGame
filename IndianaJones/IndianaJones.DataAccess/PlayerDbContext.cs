using IndianaJones.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianaJones.DataAccess
{
    public class PlayerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // ------------------  CHANGE THE FOLLOWING CHANGES ACCORDING TO YOUR OWN DATABASE INFORMATION AS IN THE EXAMPLE  ---------------------------------

            // SAMPLE:
            optionsBuilder.UseSqlServer("Server=YOURSERVER; Database=YOURDATABASE;uid=YOURID;pwd=YOURPASSWORD;Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=True ");
        }

        public DbSet<Player> Tbl_Player { get; set; }
        public DbSet<QA> Tbl_QA { get; set; }
        public DbSet<Rewards> Tbl_Rewards { get; set; }
    }
}
