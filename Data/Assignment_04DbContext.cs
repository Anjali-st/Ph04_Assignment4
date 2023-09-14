using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssignment_04.Models;

namespace WebAppAssignment_04.Data
{
    public class Assignment_04DbContext : DbContext
    {
        public Assignment_04DbContext (DbContextOptions<Assignment_04DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssignment_04.Models.Student> Student { get; set; } = default!;
    }
}
