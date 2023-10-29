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

        public DbSet<_Jameeah> Jameeah { get; set; }
        public DbSet<Member> Members { get; set; }

    }
}
