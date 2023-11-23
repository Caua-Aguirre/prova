using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prova.Models;

namespace prova.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<prova.Models.cadclientes> cadclientes { get; set; } = default!;

        public DbSet<prova.Models.cadmaquinas>? cadmaquinas { get; set; }

        public DbSet<prova.Models.inventario>? inventario { get; set; }
    }
}
