using Microsoft.EntityFrameworkCore;
using MiMascota.web.Data.Entities;

namespace MiMascota.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
