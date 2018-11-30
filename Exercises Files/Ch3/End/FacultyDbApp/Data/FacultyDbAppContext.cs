using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FacultyDbApp.Models
{
    public class FacultyDbAppContext : DbContext
    {
        public FacultyDbAppContext (DbContextOptions<FacultyDbAppContext> options)
            : base(options)
        {
        }

        public DbSet<FacultyDbApp.Models.Faculty> Faculty { get; set; }
    }
}
