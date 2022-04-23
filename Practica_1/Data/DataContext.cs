using Microsoft.EntityFrameworkCore;
using Practica_1.Data.Entities;

namespace Practica_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Entrance> Entrances { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}
