using System;
using Microsoft;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InputForm.Models
{
    public class PensionContext:DbContext
    {
        public DbSet<PersonDB> Persons { get; set; }
        public DbSet<PersSavingDB> PersSavings { get; set; }
        public PensionContext(DbContextOptions<PensionContext> options):base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
