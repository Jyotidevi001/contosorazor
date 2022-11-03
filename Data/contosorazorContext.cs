using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using contosorazor.models;

namespace contosorazor.Data
{
    public class contosorazorContext : DbContext
    {
        public contosorazorContext (DbContextOptions<contosorazorContext> options)
            : base(options)
        {
        }

        public DbSet<contosorazor.models.Student> Student { get; set; } = default!;
    }
}
