using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiControlStock.Models;

namespace WebApiControlStock.Data
{
    public class DbControlStockContext : DbContext
    {
        public DbControlStockContext(DbContextOptions<DbControlStockContext> options
            ) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
