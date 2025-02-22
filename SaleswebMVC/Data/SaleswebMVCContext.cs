using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleswebMVC.Models;

namespace SaleswebMVC.Data
{
    public class SaleswebMVCContext : DbContext
    {
        public SaleswebMVCContext (DbContextOptions<SaleswebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SaleswebMVC.Models.Departament> Departament { get; set; } = default!;
    }
}
