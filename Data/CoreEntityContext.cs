using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreEntity.Models;

namespace CoreEntity.Data
{
    public class CoreEntityContext : DbContext
    {
        public CoreEntityContext (DbContextOptions<CoreEntityContext> options)
            : base(options)
        {
        }

        public DbSet<CoreEntity.Models.Product> Product { get; set; }

        public DbSet<CoreEntity.Models.Purchase> Purchase { get; set; }

        public DbSet<CoreEntity.Models.Sale> Sale { get; set; }
    }
}
