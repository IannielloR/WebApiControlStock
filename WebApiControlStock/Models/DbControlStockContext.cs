using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApiControlStock.Models
{
    public class DbControlStockContext: DbContext
    {
        public DbControlStockContext(DbContextOptions<DbControlStockContext> options
            ) : base(options) { }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
