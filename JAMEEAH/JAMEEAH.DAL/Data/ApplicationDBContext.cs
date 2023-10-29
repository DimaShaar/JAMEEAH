using JAMEEAH.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jameeah.Domain.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Jameeahs> Jameeahs { get; set; }
        public DbSet<Members> Members { get; set; }

    }
}
