using APIDiligenciaProveedores.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDiligenciaProveedores.Context
{
    /* ORM */
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Proveedor> Proveedors { get; set; }

    }
}
